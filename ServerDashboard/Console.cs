using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace ServerDashboard
{
    public partial class Console : Form
    {
        Process _process;
        String _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

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
        }

        private async void BTN_StartServer_Click(object sender, EventArgs e)
        {
            TSL_Status.Text = "Starting Server...";
            if(RTB_ConsoleLog.Text.Length > 0)
                RTB_ConsoleLog.Clear();

            BTN_StartServer.Enabled = false;
            BTN_StopServer.Enabled = true;

            await Task.Run(() =>
            {
                // Set up the process with the command you want to run
                _process = new Process();
                _process.StartInfo.FileName = "cmd.exe";
                _process.StartInfo.Arguments = $"/c cd \"{_path}\" && java -Xmx1G -Xms1G -jar purpur-1.20.4.jar nogui";
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

                // Begin asynchronously reading the output
                _process.BeginOutputReadLine();

                // Wait for the process to exit
                _process.WaitForExit();

                // Close the process
                _process.Close();
                TSL_Status.Text = "Server stopped.";
                TSL_ServerPort.Text = "";
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
                    BTN_SendCommand.BeginInvoke(new Action(() => { BTN_SendCommand.Enabled = true; }));
                    TBX_Command.BeginInvoke(new Action(() => { TBX_Command.Enabled = true; TBX_Command.Focus(); }));
                }

                if(e.Data.Contains("Stopping the server"))
                {
                    BTN_SendCommand.BeginInvoke(new Action(() => { BTN_SendCommand.Enabled = false; }));
                    TBX_Command.BeginInvoke(new Action(() => { TBX_Command.Enabled = false; TBX_Command.Clear(); }));
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
            var input = "stop" + Environment.NewLine;
            _process.StandardInput.WriteLine(input);
            TSL_Status.Text = "Stopping server...";
        }

        private void BTN_AgreeToEula_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\marce\Documents\server\";
            try
            {
                var EULA = File.ReadAllText(path + @"eula.txt");
                EULA = EULA.Replace("eula=false", "eula=true");
                File.WriteAllText(path + @"eula.txt", EULA);

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

        private void TSL_Directory_Click(object sender, EventArgs e)
        {
            var fBD = new FolderBrowserDialog();
            if(fBD.ShowDialog() == DialogResult.OK)
            {
                _path = fBD.SelectedPath;
                TSL_Directory.Text = "Directory: " + _path;
            }
        }
    }
}