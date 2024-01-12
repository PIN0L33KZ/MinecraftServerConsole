using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace ServerDashboard
{
    public partial class Console : Form
    {
        Process _process;
        String _path = "Please select a directory by clicking this text.";
        String _jarFile;
        List<string> _players;
        Timer _updateRamAndCpu;

        public Console()
        {
            InitializeComponent();

            var adresses = Dns.GetHostAddresses(Dns.GetHostName());
            var ip = "";
            foreach(var ad in adresses)
            {
                if(ad.AddressFamily == AddressFamily.InterNetwork) { ip = ad.ToString(); }
            }
            TSL_IP.Text = "IP: " + ip;

            TSL_Directory.Text = "Directory: " + _path;

            _updateRamAndCpu = new Timer() { Interval = 1000 };
            _updateRamAndCpu.Tick += updateRamAndCpu_Tick;
            _updateRamAndCpu.Start();
        }

        private async void BTN_StartServer_Click(object sender, EventArgs e)
        {
            if(_path == "Please select a directory by clicking this text.")
            {
                RTB_ConsoleLog.AppendText("Please select a directory first!");
                return;
            }

            TSL_Status.Text = "Starting Server...";
            if(RTB_ConsoleLog.Text.Length > 0)
                RTB_ConsoleLog.Clear();

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
                _process.Start();
                TSL_Status.Text = "Server running...";

                _players = new List<string>();

                // Begin asynchronously reading the output
                _process.BeginOutputReadLine();
                _process.BeginErrorReadLine();

                // Wait for the process to exit
                _process.WaitForExit();

                // Close the process
                _process.Close();
                TSL_Status.Text = "Server stopped.";
                TSL_ServerPort.Text = "";
                _players.Clear();
            });

            BTN_StopServer.Enabled = false;
            BTN_StartServer.Enabled = true;

            if(RTB_ConsoleLog.Text.Contains("You need to agree to the EULA"))
            {
                BTN_AgreeToEula.Enabled = true;
                TSL_Status.Text = "Error, EULA isn't agreed by user. Aborting.";
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(!string.IsNullOrEmpty(e.Data))
            {
                // Use BeginInvoke to update the UI from the output data received event
                RTB_ConsoleLog.BeginInvoke(new Action(() =>
                {
                    RTB_ConsoleLog.AppendText($"{e.Data}{Environment.NewLine}");
                    RTB_ConsoleLog.ScrollToCaret(); // Auto-scroll to the end
                }));

                if(e.Data.Contains("Starting Minecraft server on"))
                {
                    var port = e.Data.Split(':');

                    TSL_ServerPort.Text = "Port: " + port[4];
                }

                if(e.Data.Contains("Done"))
                {
                    BTN_StopServer.BeginInvoke(new Action(() => { BTN_StopServer.Enabled = true; }));
                    BTN_SendCommand.BeginInvoke(new Action(() => { BTN_SendCommand.Enabled = true; }));
                    TBX_Command.BeginInvoke(new Action(() => { TBX_Command.Enabled = true; TBX_Command.Focus(); }));
                }

                if(e.Data.Contains("Stopping the server"))
                {
                    BTN_SendCommand.BeginInvoke(new Action(() => { BTN_SendCommand.Enabled = false; }));
                    TBX_Command.BeginInvoke(new Action(() => { TBX_Command.Enabled = false; TBX_Command.Clear(); }));
                }

                if(e.Data.Contains("joined the game"))
                {
                    var tmpString = e.Data.Split(" ");
                    _players.Add(tmpString[2]);

                    LBX_PlayerList.BeginInvoke(new Action(() => { LBX_PlayerList.Items.Clear(); }));
                    foreach(var player in _players)
                    {
                        LBX_PlayerList.BeginInvoke(new Action(() => { LBX_PlayerList.Items.Add(player); }));
                    }
                    LBL_PlayerList.BeginInvoke(new Action(() => { LBL_PlayerList.Text = $"Players ({_players.Count}):"; }));
                }

                if(e.Data.Contains("left the game"))
                {
                    var tmpString = e.Data.Split(" ");
                    _players.Remove(tmpString[2]);

                    LBX_PlayerList.BeginInvoke(new Action(() => { LBX_PlayerList.Items.Clear(); }));
                    foreach(var player in _players)
                    {
                        LBX_PlayerList.BeginInvoke(new Action(() => { LBX_PlayerList.Items.Add(player); }));
                    }
                    LBL_PlayerList.BeginInvoke(new Action(() => { LBL_PlayerList.Text = $"Players ({_players.Count}):"; }));
                }
            }
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(!string.IsNullOrEmpty(e.Data))
            {
                // Use BeginInvoke to update the UI from the output data received event
                RTB_ConsoleLog.BeginInvoke(new Action(() =>
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
            var input = "stop" + Environment.NewLine;
            _process.StandardInput.WriteLine(input);
            TSL_Status.Text = "Stopping server...";
        }

        private void BTN_AgreeToEula_Click(object sender, EventArgs e)
        {
            try
            {
                var EULA = File.ReadAllText(_path + @"\eula.txt");
                EULA = EULA.Replace("eula=false", "eula=true");
                File.WriteAllText(_path + @"\eula.txt", EULA);

                BTN_AgreeToEula.Enabled = false;
                MessageBox.Show("EULA agreed successfully!");
                TSL_Status.Text = "EULA agreed by user.";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to agree to eula.\n" + ex.Message);
            }
        }

        private void BTN_SendCommand_Click(object sender, EventArgs e)
        {
            RTB_ConsoleLog.AppendText("               > " + TBX_Command.Text.Trim() + Environment.NewLine);
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
            var fBD = new FolderBrowserDialog();
            if(fBD.ShowDialog() == DialogResult.OK)
            {
                _path = fBD.SelectedPath;
                TSL_Directory.Text = "Directory: " + _path;
            }

            var files = Directory.GetFiles(_path, "*.jar");
            if(files.Length == 0)
            {
                if(MessageBox.Show("No .jar files detected in this directory. Download the latest?", "Download server.jar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                {
                    return;
                }

                // Download latest .jar file from serverjars.com
                var webClient = new WebClient();
                await Task.Run(new Action(() => { webClient.DownloadFile(@"https://serverjars.com/api/fetchJar/servers/purpur/", _path + @"\server.jar"); }));
                _jarFile = @"server.jar";

                MessageBox.Show(".jar file was downloaded successfully! You can start your server now.", "Download server.jar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var _jarFileSplitLength = files[0].Split('\\').Length;
                _jarFile = files[0].Split('\\')[_jarFileSplitLength -1];
            }
        }

        private void KickPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
                return;

            string reason = Interaction.InputBox("Enter reason:", "Kick reason", "Kicked by an operator.");

            foreach(var selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"kick {selectedPlayer} {reason}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void LBX_PlayerList_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var index = LBX_PlayerList.IndexFromPoint(e.Location);

                if(index >= 0)
                {
                    LBX_PlayerList.SelectedItem = LBX_PlayerList.Items[index];
                    CMS_PlayerList.Show(LBX_PlayerList, e.Location);
                }
            }
        }

        private void banPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
                return;

            string reason = Interaction.InputBox("Enter reason:", "Ban reason", "Banned by an operator.");

            foreach(var selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                _process.StandardInput.WriteLine($"ban {selectedPlayer} {reason}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void makePlayerAnOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LBX_PlayerList.SelectedItems.Count == 0)
                return;


            foreach(var selectedPlayer in LBX_PlayerList.SelectedItems)
            {
                if(MessageBox.Show($"Do you really want to give all the power to {selectedPlayer}?", "Make player an operator?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    return;
                }
                _process.StandardInput.WriteLine($"op {selectedPlayer}");
            }

            LBX_PlayerList.SelectedIndex = -1;
        }

        private void updateRamAndCpu_Tick(object sender, EventArgs e)
        {
            #region RAM
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new
            {
                FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
                TotalVisibleMemorySize = Double.Parse(mo["TotalVisibleMemorySize"].ToString())
            }).FirstOrDefault();

            if(memoryValues != null)
            {
                var percent = ((memoryValues.TotalVisibleMemorySize - memoryValues.FreePhysicalMemory) / memoryValues.TotalVisibleMemorySize) * 100;

                TSL_RamState.Text = "RAM usage: " + Math.Round(percent).ToString() + "%";
            }
            #endregion


            #region CPU
            
            #endregion
        }
    }
}