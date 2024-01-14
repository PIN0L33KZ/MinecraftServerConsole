namespace ServerDashboard
{
    partial class Console
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
            PNL_UpperSpaceing = new Panel();
            BTN_AgreeToEula = new Button();
            BTN_StopServer = new Button();
            BTN_StartServer = new Button();
            PNL_Fill = new Panel();
            RTB_ConsoleLog = new RichTextBox();
            STS_Status = new StatusStrip();
            TSL_Status = new ToolStripStatusLabel();
            TSL_Spacing1 = new ToolStripStatusLabel();
            TSL_IP = new ToolStripStatusLabel();
            TSL_Spacing2 = new ToolStripStatusLabel();
            TSL_ServerPort = new ToolStripStatusLabel();
            TSL_Spacing3 = new ToolStripStatusLabel();
            TSL_Directory = new ToolStripStatusLabel();
            TSL_Spacing4 = new ToolStripStatusLabel();
            TSL_RamState = new ToolStripStatusLabel();
            TSL_Spacing5 = new ToolStripStatusLabel();
            TSL_CpuState = new ToolStripStatusLabel();
            TSL_Spacing6 = new ToolStripStatusLabel();
            TSL_PingState = new ToolStripStatusLabel();
            PNL_LowerSpaceing = new Panel();
            TBX_Command = new TextBox();
            BTN_SendCommand = new Button();
            PNL_PlayerList = new Panel();
            LBX_PlayerList = new ListBox();
            LBL_PlayerList = new Label();
            CMS_PlayerList = new ContextMenuStrip(components);
            SMI_KickPlayer = new ToolStripMenuItem();
            SMI_BanPlayer = new ToolStripMenuItem();
            SMI_OpPlayer = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            SMI_MessagePlayer = new ToolStripMenuItem();
            PNL_PluginsList = new Panel();
            LBX_PluginsList = new ListBox();
            LBL_PluginsList = new Label();
            CMS_PluginsList = new ContextMenuStrip(components);
            SMI_EditPluiginConfig = new ToolStripMenuItem();
            SMI_CheckPluiginUpdate = new ToolStripMenuItem();
            SMI_SetGamemodePlayer = new ToolStripMenuItem();
            SMI_SetCreative = new ToolStripMenuItem();
            SMI_SetSurvival = new ToolStripMenuItem();
            SMI_SetAdventure = new ToolStripMenuItem();
            SMI_SetSpectator = new ToolStripMenuItem();
            PNL_UpperSpaceing.SuspendLayout();
            PNL_Fill.SuspendLayout();
            STS_Status.SuspendLayout();
            PNL_LowerSpaceing.SuspendLayout();
            PNL_PlayerList.SuspendLayout();
            CMS_PlayerList.SuspendLayout();
            PNL_PluginsList.SuspendLayout();
            CMS_PluginsList.SuspendLayout();
            SuspendLayout();
            // 
            // PNL_UpperSpaceing
            // 
            PNL_UpperSpaceing.BackColor = SystemColors.Control;
            PNL_UpperSpaceing.Controls.Add(BTN_AgreeToEula);
            PNL_UpperSpaceing.Controls.Add(BTN_StopServer);
            PNL_UpperSpaceing.Controls.Add(BTN_StartServer);
            PNL_UpperSpaceing.Dock = DockStyle.Top;
            PNL_UpperSpaceing.Location = new Point(0, 0);
            PNL_UpperSpaceing.Name = "PNL_UpperSpaceing";
            PNL_UpperSpaceing.Size = new Size(992, 58);
            PNL_UpperSpaceing.TabIndex = 0;
            // 
            // BTN_AgreeToEula
            // 
            BTN_AgreeToEula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_AgreeToEula.AutoEllipsis = true;
            BTN_AgreeToEula.BackColor = Color.White;
            BTN_AgreeToEula.Enabled = false;
            BTN_AgreeToEula.Font = new Font("Segoe UI", 9F);
            BTN_AgreeToEula.Location = new Point(864, 18);
            BTN_AgreeToEula.Name = "BTN_AgreeToEula";
            BTN_AgreeToEula.Size = new Size(119, 23);
            BTN_AgreeToEula.TabIndex = 2;
            BTN_AgreeToEula.Text = "Agree to EULA";
            BTN_AgreeToEula.UseVisualStyleBackColor = false;
            BTN_AgreeToEula.Click += BTN_AgreeToEula_Click;
            // 
            // BTN_StopServer
            // 
            BTN_StopServer.Anchor = AnchorStyles.Top;
            BTN_StopServer.AutoEllipsis = true;
            BTN_StopServer.BackColor = Color.White;
            BTN_StopServer.Enabled = false;
            BTN_StopServer.Font = new Font("Segoe UI", 9F);
            BTN_StopServer.Location = new Point(501, 18);
            BTN_StopServer.Name = "BTN_StopServer";
            BTN_StopServer.Size = new Size(75, 23);
            BTN_StopServer.TabIndex = 1;
            BTN_StopServer.Text = "Stop";
            BTN_StopServer.UseVisualStyleBackColor = false;
            BTN_StopServer.Click += BTN_StopServer_Click;
            // 
            // BTN_StartServer
            // 
            BTN_StartServer.Anchor = AnchorStyles.Top;
            BTN_StartServer.AutoEllipsis = true;
            BTN_StartServer.BackColor = Color.White;
            BTN_StartServer.Font = new Font("Segoe UI", 9F);
            BTN_StartServer.Location = new Point(420, 18);
            BTN_StartServer.Name = "BTN_StartServer";
            BTN_StartServer.Size = new Size(75, 23);
            BTN_StartServer.TabIndex = 0;
            BTN_StartServer.Text = "Start";
            BTN_StartServer.UseVisualStyleBackColor = false;
            BTN_StartServer.Click += BTN_StartServer_Click;
            // 
            // PNL_Fill
            // 
            PNL_Fill.Controls.Add(RTB_ConsoleLog);
            PNL_Fill.Dock = DockStyle.Fill;
            PNL_Fill.Location = new Point(0, 58);
            PNL_Fill.Name = "PNL_Fill";
            PNL_Fill.Size = new Size(992, 442);
            PNL_Fill.TabIndex = 1;
            // 
            // RTB_ConsoleLog
            // 
            RTB_ConsoleLog.BackColor = Color.Black;
            RTB_ConsoleLog.BorderStyle = BorderStyle.None;
            RTB_ConsoleLog.Dock = DockStyle.Fill;
            RTB_ConsoleLog.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RTB_ConsoleLog.ForeColor = Color.Silver;
            RTB_ConsoleLog.Location = new Point(0, 0);
            RTB_ConsoleLog.Name = "RTB_ConsoleLog";
            RTB_ConsoleLog.ReadOnly = true;
            RTB_ConsoleLog.Size = new Size(992, 442);
            RTB_ConsoleLog.TabIndex = 0;
            RTB_ConsoleLog.TabStop = false;
            RTB_ConsoleLog.Text = "";
            RTB_ConsoleLog.WordWrap = false;
            // 
            // STS_Status
            // 
            STS_Status.BackColor = SystemColors.ControlLight;
            STS_Status.Font = new Font("Segoe UI", 9F);
            STS_Status.Items.AddRange(new ToolStripItem[] { TSL_Status, TSL_Spacing1, TSL_IP, TSL_Spacing2, TSL_ServerPort, TSL_Spacing3, TSL_Directory, TSL_Spacing4, TSL_RamState, TSL_Spacing5, TSL_CpuState, TSL_Spacing6, TSL_PingState });
            STS_Status.Location = new Point(0, 543);
            STS_Status.Name = "STS_Status";
            STS_Status.Size = new Size(1298, 22);
            STS_Status.TabIndex = 2;
            // 
            // TSL_Status
            // 
            TSL_Status.ForeColor = SystemColors.ControlText;
            TSL_Status.Image = Properties.Resources.gray_circle;
            TSL_Status.Name = "TSL_Status";
            TSL_Status.Size = new Size(55, 17);
            TSL_Status.Text = "Ready";
            // 
            // TSL_Spacing1
            // 
            TSL_Spacing1.ForeColor = SystemColors.ControlText;
            TSL_Spacing1.Name = "TSL_Spacing1";
            TSL_Spacing1.Size = new Size(22, 17);
            TSL_Spacing1.Text = "     ";
            // 
            // TSL_IP
            // 
            TSL_IP.ForeColor = SystemColors.ControlText;
            TSL_IP.Name = "TSL_IP";
            TSL_IP.Size = new Size(75, 17);
            TSL_IP.Text = "Fetching IP...";
            // 
            // TSL_Spacing2
            // 
            TSL_Spacing2.ForeColor = SystemColors.ControlText;
            TSL_Spacing2.Name = "TSL_Spacing2";
            TSL_Spacing2.Size = new Size(22, 17);
            TSL_Spacing2.Text = "     ";
            // 
            // TSL_ServerPort
            // 
            TSL_ServerPort.ForeColor = SystemColors.ControlText;
            TSL_ServerPort.Name = "TSL_ServerPort";
            TSL_ServerPort.Size = new Size(0, 17);
            // 
            // TSL_Spacing3
            // 
            TSL_Spacing3.Name = "TSL_Spacing3";
            TSL_Spacing3.Size = new Size(22, 17);
            TSL_Spacing3.Text = "     ";
            // 
            // TSL_Directory
            // 
            TSL_Directory.Name = "TSL_Directory";
            TSL_Directory.Size = new Size(55, 17);
            TSL_Directory.Text = "Directory";
            TSL_Directory.Click += TSL_Directory_Click;
            // 
            // TSL_Spacing4
            // 
            TSL_Spacing4.Name = "TSL_Spacing4";
            TSL_Spacing4.Size = new Size(22, 17);
            TSL_Spacing4.Text = "     ";
            // 
            // TSL_RamState
            // 
            TSL_RamState.Name = "TSL_RamState";
            TSL_RamState.Size = new Size(73, 17);
            TSL_RamState.Text = "RAM usage: ";
            // 
            // TSL_Spacing5
            // 
            TSL_Spacing5.Name = "TSL_Spacing5";
            TSL_Spacing5.Size = new Size(22, 17);
            TSL_Spacing5.Text = "     ";
            // 
            // TSL_CpuState
            // 
            TSL_CpuState.Name = "TSL_CpuState";
            TSL_CpuState.Size = new Size(67, 17);
            TSL_CpuState.Text = "CPU usage:";
            // 
            // TSL_Spacing6
            // 
            TSL_Spacing6.Name = "TSL_Spacing6";
            TSL_Spacing6.Size = new Size(22, 17);
            TSL_Spacing6.Text = "     ";
            // 
            // TSL_PingState
            // 
            TSL_PingState.Name = "TSL_PingState";
            TSL_PingState.Size = new Size(59, 17);
            TSL_PingState.Text = "Ping: 0ms";
            // 
            // PNL_LowerSpaceing
            // 
            PNL_LowerSpaceing.BackColor = SystemColors.Control;
            PNL_LowerSpaceing.Controls.Add(TBX_Command);
            PNL_LowerSpaceing.Controls.Add(BTN_SendCommand);
            PNL_LowerSpaceing.Dock = DockStyle.Bottom;
            PNL_LowerSpaceing.Location = new Point(0, 500);
            PNL_LowerSpaceing.Name = "PNL_LowerSpaceing";
            PNL_LowerSpaceing.Size = new Size(1298, 43);
            PNL_LowerSpaceing.TabIndex = 3;
            // 
            // TBX_Command
            // 
            TBX_Command.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBX_Command.AutoCompleteCustomSource.AddRange(new string[] { "?", "ability", "advancement", "alwaysday", "attribute", "ban", "ban-ip", "banlist", "bossbar", "camera", "camerashake", "changesetting", "clear", "clearspawnpoint", "clone", "connect", "damage", "data", "datapack", "daylock", "debug", "dedicatedwsserver", "defaultgamemode", "deop", "dialogue", "difficulty", "effect", "enchant", "event", "execute", "experience", "fill", "fillbiome", "fog", "forceload", "function", "gamemode", "gamerule", "gametest", "give", "help", "immutableworld", "item", "jfr", "kick", "kill", "list", "locate", "loot", "me", "mobevent", "msg", "music", "op", "ops", "pardon", "pardon-ip", "particle", "perf", "permission", "place", "playanimation", "playsound", "publish", "random", "recipe", "reload", "remove", "replaceitem", "return", "ride", "save", "save-all", "save-off", "save-on", "say", "schedule", "scoreboard", "script", "scriptevent", "seed", "setblock", "setidletimeout", "setmaxplayers", "setworldspawn", "spawnpoint", "spectate", "spreadplayers", "stop", "stopsound", "structure", "summon", "tag", "team", "teammsg", "teleport", "tell", "tellraw", "testfor", "testforblock", "testforblocks", "tickingarea", "time", "title", "titleraw", "tm", "toggledownfall", "tp", "trigger", "transferserver", "volumearea", "w", "wb", "weather", "whitelist", "worldborder", "worldbuilder", "wsserver", "xp" });
            TBX_Command.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TBX_Command.BackColor = SystemColors.Control;
            TBX_Command.CausesValidation = false;
            TBX_Command.Enabled = false;
            TBX_Command.Font = new Font("Segoe UI", 9F);
            TBX_Command.ForeColor = SystemColors.ControlText;
            TBX_Command.Location = new Point(12, 10);
            TBX_Command.Name = "TBX_Command";
            TBX_Command.Size = new Size(1201, 23);
            TBX_Command.TabIndex = 0;
            TBX_Command.WordWrap = false;
            TBX_Command.KeyDown += TBX_Command_KeyDown;
            // 
            // BTN_SendCommand
            // 
            BTN_SendCommand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_SendCommand.AutoEllipsis = true;
            BTN_SendCommand.BackColor = Color.White;
            BTN_SendCommand.Enabled = false;
            BTN_SendCommand.Font = new Font("Segoe UI", 9F);
            BTN_SendCommand.Location = new Point(1219, 10);
            BTN_SendCommand.Name = "BTN_SendCommand";
            BTN_SendCommand.Size = new Size(75, 23);
            BTN_SendCommand.TabIndex = 1;
            BTN_SendCommand.Text = "Send";
            BTN_SendCommand.UseVisualStyleBackColor = false;
            BTN_SendCommand.Click += BTN_SendCommand_Click;
            // 
            // PNL_PlayerList
            // 
            PNL_PlayerList.Controls.Add(LBX_PlayerList);
            PNL_PlayerList.Controls.Add(LBL_PlayerList);
            PNL_PlayerList.Dock = DockStyle.Right;
            PNL_PlayerList.Location = new Point(992, 0);
            PNL_PlayerList.Name = "PNL_PlayerList";
            PNL_PlayerList.Size = new Size(153, 500);
            PNL_PlayerList.TabIndex = 4;
            // 
            // LBX_PlayerList
            // 
            LBX_PlayerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LBX_PlayerList.BackColor = SystemColors.Control;
            LBX_PlayerList.BorderStyle = BorderStyle.None;
            LBX_PlayerList.FormattingEnabled = true;
            LBX_PlayerList.HorizontalScrollbar = true;
            LBX_PlayerList.ItemHeight = 15;
            LBX_PlayerList.Location = new Point(0, 33);
            LBX_PlayerList.Name = "LBX_PlayerList";
            LBX_PlayerList.Size = new Size(153, 465);
            LBX_PlayerList.Sorted = true;
            LBX_PlayerList.TabIndex = 1;
            LBX_PlayerList.UseTabStops = false;
            LBX_PlayerList.MouseUp += LBX_PlayerList_MouseUp;
            // 
            // LBL_PlayerList
            // 
            LBL_PlayerList.AutoSize = true;
            LBL_PlayerList.Location = new Point(6, 9);
            LBL_PlayerList.Name = "LBL_PlayerList";
            LBL_PlayerList.Size = new Size(64, 15);
            LBL_PlayerList.TabIndex = 0;
            LBL_PlayerList.Text = "Players (0):";
            // 
            // CMS_PlayerList
            // 
            CMS_PlayerList.Items.AddRange(new ToolStripItem[] { SMI_KickPlayer, SMI_BanPlayer, SMI_OpPlayer, toolStripMenuItem1, SMI_MessagePlayer, SMI_SetGamemodePlayer });
            CMS_PlayerList.Name = "CMS_PlayerList";
            CMS_PlayerList.RenderMode = ToolStripRenderMode.System;
            CMS_PlayerList.Size = new Size(208, 142);
            // 
            // SMI_KickPlayer
            // 
            SMI_KickPlayer.Name = "SMI_KickPlayer";
            SMI_KickPlayer.Size = new Size(207, 22);
            SMI_KickPlayer.Text = "Kick player";
            SMI_KickPlayer.Click += SMI_KickPlayer_Click;
            // 
            // SMI_BanPlayer
            // 
            SMI_BanPlayer.Name = "SMI_BanPlayer";
            SMI_BanPlayer.Size = new Size(207, 22);
            SMI_BanPlayer.Text = "Ban player";
            SMI_BanPlayer.Click += SMI_BanPlayer_Click;
            // 
            // SMI_OpPlayer
            // 
            SMI_OpPlayer.Name = "SMI_OpPlayer";
            SMI_OpPlayer.Size = new Size(207, 22);
            SMI_OpPlayer.Text = "Make player an OP";
            SMI_OpPlayer.Click += SMI_OpPlayer_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(204, 6);
            // 
            // SMI_MessagePlayer
            // 
            SMI_MessagePlayer.Name = "SMI_MessagePlayer";
            SMI_MessagePlayer.Size = new Size(207, 22);
            SMI_MessagePlayer.Text = "Message player";
            SMI_MessagePlayer.Click += SMI_MsgPlayer_Click;
            // 
            // PNL_PluginsList
            // 
            PNL_PluginsList.Controls.Add(LBX_PluginsList);
            PNL_PluginsList.Controls.Add(LBL_PluginsList);
            PNL_PluginsList.Dock = DockStyle.Right;
            PNL_PluginsList.Location = new Point(1145, 0);
            PNL_PluginsList.Name = "PNL_PluginsList";
            PNL_PluginsList.Size = new Size(153, 500);
            PNL_PluginsList.TabIndex = 5;
            // 
            // LBX_PluginsList
            // 
            LBX_PluginsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LBX_PluginsList.BackColor = SystemColors.Control;
            LBX_PluginsList.BorderStyle = BorderStyle.None;
            LBX_PluginsList.FormattingEnabled = true;
            LBX_PluginsList.HorizontalScrollbar = true;
            LBX_PluginsList.ItemHeight = 15;
            LBX_PluginsList.Location = new Point(0, 33);
            LBX_PluginsList.Name = "LBX_PluginsList";
            LBX_PluginsList.Size = new Size(153, 465);
            LBX_PluginsList.Sorted = true;
            LBX_PluginsList.TabIndex = 1;
            LBX_PluginsList.UseTabStops = false;
            LBX_PluginsList.MouseUp += LBX_PluginsList_MouseUp;
            // 
            // LBL_PluginsList
            // 
            LBL_PluginsList.AutoSize = true;
            LBL_PluginsList.Location = new Point(6, 9);
            LBL_PluginsList.Name = "LBL_PluginsList";
            LBL_PluginsList.Size = new Size(66, 15);
            LBL_PluginsList.TabIndex = 0;
            LBL_PluginsList.Text = "Plugins (0):";
            // 
            // CMS_PluginsList
            // 
            CMS_PluginsList.Items.AddRange(new ToolStripItem[] { SMI_EditPluiginConfig, SMI_CheckPluiginUpdate });
            CMS_PluginsList.Name = "CMS_PlayerList";
            CMS_PluginsList.RenderMode = ToolStripRenderMode.System;
            CMS_PluginsList.Size = new Size(171, 48);
            // 
            // SMI_EditPluiginConfig
            // 
            SMI_EditPluiginConfig.Name = "SMI_EditPluiginConfig";
            SMI_EditPluiginConfig.Size = new Size(170, 22);
            SMI_EditPluiginConfig.Text = "Edit config";
            SMI_EditPluiginConfig.Click += SMI_EditPluiginConfig_Click;
            // 
            // SMI_CheckPluiginUpdate
            // 
            SMI_CheckPluiginUpdate.Name = "SMI_CheckPluiginUpdate";
            SMI_CheckPluiginUpdate.Size = new Size(170, 22);
            SMI_CheckPluiginUpdate.Text = "Check for updates";
            SMI_CheckPluiginUpdate.Click += SMI_CheckPluiginUpdate_Click;
            // 
            // SMI_SetGamemodePlayer
            // 
            SMI_SetGamemodePlayer.DropDownItems.AddRange(new ToolStripItem[] { SMI_SetCreative, SMI_SetSurvival, SMI_SetAdventure, SMI_SetSpectator });
            SMI_SetGamemodePlayer.Name = "SMI_SetGamemodePlayer";
            SMI_SetGamemodePlayer.Size = new Size(207, 22);
            SMI_SetGamemodePlayer.Text = "Set gamemode for player";
            // 
            // SMI_SetCreative
            // 
            SMI_SetCreative.Name = "SMI_SetCreative";
            SMI_SetCreative.Size = new Size(180, 22);
            SMI_SetCreative.Text = "Creative";
            SMI_SetCreative.Click += SMI_SetCreative_Click;
            // 
            // SMI_SetSurvival
            // 
            SMI_SetSurvival.Name = "SMI_SetSurvival";
            SMI_SetSurvival.Size = new Size(180, 22);
            SMI_SetSurvival.Text = "Survival";
            SMI_SetSurvival.Click += SMI_SetSurvival_Click;
            // 
            // SMI_SetAdventure
            // 
            SMI_SetAdventure.Name = "SMI_SetAdventure";
            SMI_SetAdventure.Size = new Size(180, 22);
            SMI_SetAdventure.Text = "Adventure";
            SMI_SetAdventure.Click += SMI_SetAdventure_Click;
            // 
            // SMI_SetSpectator
            // 
            SMI_SetSpectator.Name = "SMI_SetSpectator";
            SMI_SetSpectator.Size = new Size(180, 22);
            SMI_SetSpectator.Text = "Spectator";
            SMI_SetSpectator.Click += SMI_SetSpectator_Click;
            // 
            // Console
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 565);
            Controls.Add(PNL_Fill);
            Controls.Add(PNL_UpperSpaceing);
            Controls.Add(PNL_PlayerList);
            Controls.Add(PNL_PluginsList);
            Controls.Add(PNL_LowerSpaceing);
            Controls.Add(STS_Status);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(758, 549);
            Name = "Console";
            Text = "Console";
            FormClosing += Console_FormClosing;
            KeyDown += Console_KeyDown;
            PNL_UpperSpaceing.ResumeLayout(false);
            PNL_Fill.ResumeLayout(false);
            STS_Status.ResumeLayout(false);
            STS_Status.PerformLayout();
            PNL_LowerSpaceing.ResumeLayout(false);
            PNL_LowerSpaceing.PerformLayout();
            PNL_PlayerList.ResumeLayout(false);
            PNL_PlayerList.PerformLayout();
            CMS_PlayerList.ResumeLayout(false);
            PNL_PluginsList.ResumeLayout(false);
            PNL_PluginsList.PerformLayout();
            CMS_PluginsList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PNL_UpperSpaceing;
        private Panel PNL_Fill;
        private Button BTN_StartServer;
        private RichTextBox RTB_ConsoleLog;
        private Button BTN_StopServer;
        private Button BTN_AgreeToEula;
        private StatusStrip STS_Status;
        private ToolStripStatusLabel TSL_Status;
        private ToolStripStatusLabel TSL_ServerPort;
        private ToolStripStatusLabel TSL_IP;
        private ToolStripStatusLabel TSL_Spacing1;
        private ToolStripStatusLabel TSL_Spacing2;
        private Panel PNL_LowerSpaceing;
        private TextBox TBX_Command;
        private Button BTN_SendCommand;
        private ToolStripStatusLabel TSL_Spacing3;
        private ToolStripStatusLabel TSL_Directory;
        private Panel PNL_PlayerList;
        private Label LBL_PlayerList;
        private ListBox LBX_PlayerList;
        private ContextMenuStrip CMS_PlayerList;
        private ToolStripMenuItem SMI_KickPlayer;
        private ToolStripMenuItem SMI_BanPlayer;
        private ToolStripMenuItem SMI_OpPlayer;
        private ToolStripStatusLabel TSL_Spacing4;
        private ToolStripStatusLabel TSL_RamState;
        private ToolStripStatusLabel TSL_Spacing5;
        private ToolStripStatusLabel TSL_CpuState;
        private Panel PNL_PluginsList;
        private ListBox LBX_PluginsList;
        private Label LBL_PluginsList;
        private ContextMenuStrip CMS_PluginsList;
        private ToolStripMenuItem SMI_EditPluiginConfig;
        private ToolStripMenuItem SMI_CheckPluiginUpdate;
        private ToolStripStatusLabel TSL_Spacing6;
        private ToolStripStatusLabel TSL_PingState;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem SMI_MessagePlayer;
        private ToolStripMenuItem SMI_SetGamemodePlayer;
        private ToolStripMenuItem SMI_SetCreative;
        private ToolStripMenuItem SMI_SetSurvival;
        private ToolStripMenuItem SMI_SetAdventure;
        private ToolStripMenuItem SMI_SetSpectator;
    }
}
