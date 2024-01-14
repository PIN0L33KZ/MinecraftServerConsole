using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace ServerDashboard
{
    public partial class Console : Form
    {
        private Process _process;
        private string _path = "Please select a directory by clicking this text.";
        private string _jarFile;
        private List<string> _players;

        public Console()
        {
            InitializeComponent();

            IPAddress[] adresses = Dns.GetHostAddresses(Dns.GetHostName());
            string ip = "";
            foreach(IPAddress ad in adresses)
            {
                if(ad.AddressFamily == AddressFamily.InterNetwork) { ip = ad.ToString(); }
            }
            TSL_IP.Text = "IP: " + ip;

            TSL_Directory.Text = "Directory: " + _path;

            Task updateRamState = Task.Run(new Action(UpdateRamState)); // Measure RAM usage in %

            Task updateCpuState = Task.Run(new Action(UpdateCpuState)); // Measure CPU usage in %

            Task updatePingState = Task.Run(new Action(UpdatePingState)); // Measure Roundtrip time in ms

            TBX_Command.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void BTN_StartServer_Click(object sender, EventArgs e)
        {
            if(_path == "Please select a directory by clicking this text.")
            {
                RTB_ConsoleLog.AppendText("ERROR: Please select a directory first!");
                return;
            }

            TSL_Status.Text = "Server starting";
            TSL_Status.Image = Properties.Resources.orange_circle;
            if(RTB_ConsoleLog.Text.Length > 0)
            {
                RTB_ConsoleLog.Clear();
            }

            BTN_StartServer.Enabled = false;

            await Task.Run(() =>
            {
                // Set up the process with the command you want to run
                _process = new Process();
                _process.StartInfo.FileName = "cmd.exe";
                _process.StartInfo.Arguments = $"/c chdir && cd \"{_path}\" && java -Xmx1G -Xms1G -jar {_jarFile} nogui";
                _process.StartInfo.UseShellExecute = false;
                _process.StartInfo.RedirectStandardOutput = true;
                _process.StartInfo.RedirectStandardInput = true;
                _process.StartInfo.RedirectStandardError = true;
                _process.StartInfo.CreateNoWindow = true;


                // Set up event handlers for capturing output
                _process.OutputDataReceived += Process_OutputDataReceived;
                _process.ErrorDataReceived += Process_ErrorDataReceived;

                // Start the process
                _ = _process.Start();

                _players = [];

                // Begin asynchronously reading the output
                _process.BeginOutputReadLine();
                _process.BeginErrorReadLine();

                // Wait for the process to exit
                _process.WaitForExit();

                // Close the process
                _process.Close();
                TSL_Status.Text = "Server stopped";
                TSL_Status.Image = Properties.Resources.red_circle;
                TSL_ServerPort.Text = "";
                TSL_Spacing2.Text = "";
                _players.Clear();
            });

            BTN_StopServer.Enabled = false;
            BTN_StartServer.Enabled = true;

            await Task.Run(new Action(async () => { await Task.Delay(5000); ResetState(); }));

            if(RTB_ConsoleLog.Text.Contains("You need to agree to the EULA"))
            {
                BTN_AgreeToEula.Enabled = true;
                TSL_Status.Text = "Error: EULA isn't agreed by user, aborting";
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(!string.IsNullOrEmpty(e.Data))
            {
                if(e.Data.Contains("Starting Minecraft server on"))
                {
                    if(e.Data.Contains('<') || e.Data.Contains('>'))
                    {
                        return;
                    }

                    string[] port = e.Data.Split(':');

                    TSL_ServerPort.Text = "Port: " + port[4];
                    TSL_Spacing2.Text = "     ";
                }

                if(e.Data.Contains("Done"))
                {
                    if(e.Data.Contains('<') || e.Data.Contains('>'))
                    {
                        return;
                    }

                    _ = BTN_StopServer.BeginInvoke(new Action(() => { BTN_StopServer.Enabled = true; }));
                    _ = BTN_SendCommand.BeginInvoke(new Action(() => { BTN_SendCommand.Enabled = true; }));
                    _ = TBX_Command.BeginInvoke(new Action(() => { TBX_Command.Enabled = true; _ = TBX_Command.Focus(); }));
                    _ = BeginInvoke(new Action(() =>
                    {
                        TSL_Status.Text = "Server running";
                        TSL_Status.Image = Properties.Resources.green_circle;
                    }));
                }

                if(e.Data.Contains("Stopping the server"))
                {
                    if(e.Data.Contains('<') || e.Data.Contains('>'))
                    {
                        return;
                    }

                    _ = BTN_SendCommand.BeginInvoke(new Action(() => { BTN_SendCommand.Enabled = false; }));
                    _ = TBX_Command.BeginInvoke(new Action(() => { TBX_Command.Enabled = false; TBX_Command.Clear(); }));
                }

                if(e.Data.Contains("joined the game"))
                {
                    string[] tmpString = e.Data.Split(" ");
                    if(tmpString[2].Contains('<') || tmpString[2].Contains('>'))
                    {
                        return;
                    }

                    _players.Add(tmpString[2]);

                    _ = LBX_PlayerList.BeginInvoke(new Action(LBX_PlayerList.Items.Clear));
                    foreach(string player in _players)
                    {
                        _ = LBX_PlayerList.BeginInvoke(new Action(() => { _ = LBX_PlayerList.Items.Add(player); }));
                    }
                    _ = GBX_PlayersList.BeginInvoke(new Action(() => { GBX_PlayersList.Text = $"Players ({_players.Count}):"; }));
                }

                if(e.Data.Contains("left the game"))
                {
                    string[] tmpString = e.Data.Split(" ");
                    if(tmpString[2].Contains('<') || tmpString[2].Contains('>'))
                    {
                        return;
                    }

                    _ = _players.Remove(tmpString[2]);

                    _ = LBX_PlayerList.BeginInvoke(new Action(LBX_PlayerList.Items.Clear));
                    foreach(string player in _players)
                    {
                        _ = LBX_PlayerList.BeginInvoke(new Action(() => { _ = LBX_PlayerList.Items.Add(player); }));
                    }
                    _ = GBX_PlayersList.BeginInvoke(new Action(() => { GBX_PlayersList.Text = $"Players ({_players.Count}):"; }));
                }

                _ = e.Data.ToLower().Contains("warn") || e.Data.ToLower().Contains("warning")
                    ? RTB_ConsoleLog.BeginInvoke(new Action(() =>
                    {
                        RTB_ConsoleLog.SelectionStart = RTB_ConsoleLog.TextLength;
                        RTB_ConsoleLog.SelectionLength = 0;
                        RTB_ConsoleLog.SelectionColor = Color.FromArgb(243, 156, 18);
                        RTB_ConsoleLog.AppendText(e.Data + Environment.NewLine);
                        RTB_ConsoleLog.SelectionColor = RTB_ConsoleLog.ForeColor; // Reset color to default
                        RTB_ConsoleLog.ScrollToCaret();
                    }))
                    : e.Data.ToLower().Contains("error")
                        ? RTB_ConsoleLog.BeginInvoke(new Action(() =>
                                        {
                                            RTB_ConsoleLog.SelectionStart = RTB_ConsoleLog.TextLength;
                                            RTB_ConsoleLog.SelectionLength = 0;
                                            RTB_ConsoleLog.SelectionColor = Color.FromArgb(255, 82, 82);
                                            RTB_ConsoleLog.AppendText(e.Data + Environment.NewLine);
                                            RTB_ConsoleLog.SelectionColor = RTB_ConsoleLog.ForeColor; // Reset color to default
                                            RTB_ConsoleLog.ScrollToCaret();
                                        }))
                        : e.Data.ToLower().Contains("fatal")
                                            ? RTB_ConsoleLog.BeginInvoke(new Action(() =>
                                                            {
                                                                RTB_ConsoleLog.SelectionStart = RTB_ConsoleLog.TextLength;
                                                                RTB_ConsoleLog.SelectionLength = 0;
                                                                RTB_ConsoleLog.SelectionColor = Color.FromArgb(255, 53, 53);
                                                                RTB_ConsoleLog.AppendText(e.Data + Environment.NewLine);
                                                                RTB_ConsoleLog.SelectionColor = RTB_ConsoleLog.ForeColor; // Reset color to default
                                                                RTB_ConsoleLog.ScrollToCaret();
                                                            }))
                                            : RTB_ConsoleLog.BeginInvoke(new Action(() =>
                                                            {
                                                                RTB_ConsoleLog.AppendText($"{e.Data}{Environment.NewLine}");
                                                                RTB_ConsoleLog.ScrollToCaret(); // Auto-scroll to the end
                                                            }));
            }
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(!string.IsNullOrEmpty(e.Data))
            {
                // Use BeginInvoke to update the UI from the output data received event
                _ = RTB_ConsoleLog.BeginInvoke(new Action(() =>
                {
                    RTB_ConsoleLog.AppendText($"{e.Data}{Environment.NewLine}");
                    RTB_ConsoleLog.ScrollToCaret(); // Auto-scroll to the end
                }));
            }
        }

        private void BTN_StopServer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wish to shutdown your server?", "Stop server", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }
            string input = "stop" + Environment.NewLine;
            _process.StandardInput.WriteLine(input);
            TSL_Status.Text = "Server stopping";
            TSL_Status.Image = Properties.Resources.orange_circle;
        }

        private void BTN_AgreeToEula_Click(object sender, EventArgs e)
        {
            try
            {
                string EULA = File.ReadAllText(_path + @"\eula.txt");
                EULA = EULA.Replace("eula=false", "eula=true");
                File.WriteAllText(_path + @"\eula.txt", EULA);

                BTN_AgreeToEula.Enabled = false;
                _ = MessageBox.Show("EULA agreed successfully!");
                TSL_Status.Text = "EULA agreed by user";
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show("Unable to agree to eula.\n" + ex.Message);
            }
        }

        private void BTN_SendCommand_Click(object sender, EventArgs e)
        {
            if(TBX_Command.TextLength == 0)
            {
                return;
            }

            if(TBX_Command.Text[0] == '/')
            {
                TBX_Command.Text = TBX_Command.Text.Remove(0, 1);
            }

            RTB_ConsoleLog.SelectionStart = RTB_ConsoleLog.TextLength;
            RTB_ConsoleLog.SelectionLength = 0;
            RTB_ConsoleLog.SelectionColor = Color.FromArgb(37, 93, 213);
            RTB_ConsoleLog.AppendText("         INPUT > " + TBX_Command.Text.Trim() + Environment.NewLine);
            RTB_ConsoleLog.SelectionColor = RTB_ConsoleLog.ForeColor; // Reset color to default
            RTB_ConsoleLog.ScrollToCaret();
            _process.StandardInput.WriteLine(TBX_Command.Text.Trim());
            TBX_Command.Clear();
        }

        private void TBX_Command_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BTN_SendCommand.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private async void TSL_Directory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new();
            if(fBD.ShowDialog() == DialogResult.OK)
            {
                _path = fBD.SelectedPath;
                TSL_Directory.Text = "Directory: " + _path;
            }

            string[] files = Directory.GetFiles(_path, "*.jar");
            if(files.Length == 0)
            {
                if(MessageBox.Show("No .jar files detected in this directory. Download the latest?", "Download server.jar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                {
                    return;
                }

                Cursor = Cursors.WaitCursor;

                // Download latest .jar file from serverjars.com
                WebClient webClient = new();
                await Task.Run(new Action(() => { webClient.DownloadFile(@"https://serverjars.com/api/fetchJar/servers/purpur/", _path + @"\server.jar"); }));
                _jarFile = @"server.jar";

                _ = MessageBox.Show(".jar file was downloaded successfully! You can start your server now.", "Download server.jar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor = Cursors.Default;
            }
            else
            {
                int _jarFileSplitLength = files[0].Split('\\').Length;
                _jarFile = files[0].Split('\\')[_jarFileSplitLength - 1];
            }

            LBX_PluginsList.Items.Clear();
            if(!Directory.Exists(_path + @"\plugins"))
            {
                return;
            }

            string[] pluginFiles = Directory.GetFiles(_path + @"\plugins", "*.jar");
            foreach(string file in pluginFiles)
            {
                string[] fileSplit = file.Split('\\');
                _ = LBX_PluginsList.Items.Add(fileSplit[^1]);
            }

            GBX_PluginsList.Text = $"Plugins ({pluginFiles.Length}): ";
        }

        private void LBX_PlayerList_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int index = LBX_PlayerList.IndexFromPoint(e.Location);

                if(index >= 0)
                {
                    LBX_PlayerList.SelectedItem = LBX_PlayerList.Items[index];
                    CMS_PlayerList.Show(LBX_PlayerList, e.Location);
                }
            }
        }

        private void LBX_PluginsList_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int index = LBX_PluginsList.IndexFromPoint(e.Location);

                if(index >= 0)
                {
                    LBX_PluginsList.SelectedItem = LBX_PluginsList.Items[index];
                    CMS_PluginsList.Show(LBX_PluginsList, e.Location);
                }
            }
        }

        private void SMI_KickPlayer_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            string reason = Interaction.InputBox("Enter reason:", "Kick reason", "Kicked by an operator.");

            if(reason.Length == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"kick {selectedPlayer} {reason}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_BanPlayer_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            string reason = Interaction.InputBox("Enter reason:", "Ban reason", "Banned by an operator.");

            if(reason.Length == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"ban {selectedPlayer} {reason}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_OpPlayer_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                if(MessageBox.Show($"Do you really want to give all the power to {selectedPlayer}?", "Make player an operator?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }
                _process.StandardInput.WriteLine($"op {selectedPlayer}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_MsgPlayer_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            string message = Interaction.InputBox("Enter message:", "Message");

            if(message.Length == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"msg {selectedPlayer} {message}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_CheckPluiginUpdate_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("API is not implemented yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LBX_PluginsList.SelectedIndex = -1;
        }

        private void SMI_EditPluiginConfig_Click(object sender, EventArgs e)
        {
            string pluginName = LBX_PluginsList.SelectedItem.ToString().Remove(LBX_PluginsList.SelectedItem.ToString().Length - 4, 4);
            string[] directoryPathsList = Directory.GetDirectories(_path + @"\plugins");

            foreach(string directory in directoryPathsList)
            {
                string[] directoryTmp = directory.Split('\\');
                string directoryName = directoryTmp[^1];

                string pattern = string.Join(".*", Regex.Escape(directoryName.ToLower()).ToCharArray());

                if(Regex.IsMatch(pluginName.ToLower(), pattern))
                {
                    Process process = new() { StartInfo = new ProcessStartInfo(directory + @"\config.yml") { UseShellExecute = true } };
                    _ = process.Start();
                }
            }
        }

        private void SMI_SetCreative_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"gamemode creative {selectedPlayer}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_SetSurvival_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"gamemode survival {selectedPlayer}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_SetAdventure_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"gamemode adventure {selectedPlayer}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void SMI_SetSpectator_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
            {
                return;
            }

            foreach(object? selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"gamemode spectator {selectedPlayer}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private async void UpdateRamState()
        {
            ManagementObjectSearcher wmiObject = new("select * from Win32_OperatingSystem");

            while(true)
            {
                var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
                {
                    FreePhysicalMemory = double.Parse(mo["FreePhysicalMemory"].ToString()),
                    TotalVisibleMemorySize = double.Parse(mo["TotalVisibleMemorySize"].ToString())
                }).FirstOrDefault();

                if(memoryValues != null)
                {
                    double percent = (memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize * 100;

                    _ = BeginInvoke(new Action(() => { TSL_RamState.Text = "RAM usage: " + Math.Round(percent).ToString() + "%"; }));
                }

                await Task.Delay(1000);
            }
        }

        private async void UpdateCpuState()
        {
            PerformanceCounter c = new("Processor", "% Processor Time", "_Total");

            while(true)
            {
                _ = BeginInvoke(new Action(() => { TSL_CpuState.Text = $"CPU: {Math.Round(c.NextValue())}%"; }));
                await Task.Delay(1000);
            }
        }

        private async void UpdatePingState()
        {
            Ping ping = new();

            while(true)
            {
                PingReply response = await ping.SendPingAsync("8.8.8.8", 30);
                _ = BeginInvoke(new Action(() => { TSL_PingState.Text = $"Ping: {response.RoundtripTime}ms"; }));
                await Task.Delay(1000);
            }
        }

        private async void ResetState()
        {
            await Task.Run(() => { TSL_Status.Text = "Ready"; TSL_Status.Image = Properties.Resources.gray_circle; });
        }

        private void Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!BTN_StopServer.Enabled)
            {
                return;
            }

            e.Cancel = true;
            _ = MessageBox.Show("WARNING! Your server is still running. Shutdown the server befor you can exit the program.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                LBX_PlayerList.SelectedIndex = -1;
                LBX_PluginsList.SelectedIndex = -1;
            }
        }

        private void Console_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState is FormWindowState.Normal or FormWindowState.Maximized)
            {
                SPC_Main.Panel1MinSize = Width - 298;
            }
        }
    }
}