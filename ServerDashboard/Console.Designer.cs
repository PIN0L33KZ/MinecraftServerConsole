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
            CMS_ConsoleLog = new ContextMenuStrip(components);
            TSI_ExportLogToFile = new ToolStripMenuItem();
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
            TSL_Spacing7 = new ToolStripStatusLabel();
            TSL_DefaultGamemode = new ToolStripStatusLabel();
            PNL_LowerSpaceing = new Panel();
            TBX_Command = new TextBox();
            BTN_SendCommand = new Button();
            PNL_PlayerList = new Panel();
            LBX_PlayerList = new ListBox();
            CMS_PlayerList = new ContextMenuStrip(components);
            SMI_KickPlayer = new ToolStripMenuItem();
            SMI_BanPlayer = new ToolStripMenuItem();
            SMI_OpPlayer = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            SMI_MessagePlayer = new ToolStripMenuItem();
            SMI_SetGamemodePlayer = new ToolStripMenuItem();
            SMI_SetCreative = new ToolStripMenuItem();
            SMI_SetSurvival = new ToolStripMenuItem();
            SMI_SetAdventure = new ToolStripMenuItem();
            SMI_SetSpectator = new ToolStripMenuItem();
            PNL_PluginsList = new Panel();
            CMS_PluginsList = new ContextMenuStrip(components);
            SMI_EditPluiginConfig = new ToolStripMenuItem();
            SMI_CheckPluiginUpdate = new ToolStripMenuItem();
            SPC_Main = new SplitContainer();
            GBX_PluginsList = new GroupBox();
            LBX_PluginsList = new ListBox();
            GBX_PlayersList = new GroupBox();
            PNL_UpperSpaceing.SuspendLayout();
            PNL_Fill.SuspendLayout();
            CMS_ConsoleLog.SuspendLayout();
            STS_Status.SuspendLayout();
            PNL_LowerSpaceing.SuspendLayout();
            CMS_PlayerList.SuspendLayout();
            CMS_PluginsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SPC_Main).BeginInit();
            SPC_Main.Panel1.SuspendLayout();
            SPC_Main.Panel2.SuspendLayout();
            SPC_Main.SuspendLayout();
            GBX_PluginsList.SuspendLayout();
            GBX_PlayersList.SuspendLayout();
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
            PNL_UpperSpaceing.Size = new Size(1000, 58);
            PNL_UpperSpaceing.TabIndex = 0;
            // 
            // BTN_AgreeToEula
            // 
            BTN_AgreeToEula.Anchor = AnchorStyles.Right;
            BTN_AgreeToEula.AutoEllipsis = true;
            BTN_AgreeToEula.BackColor = Color.White;
            BTN_AgreeToEula.Enabled = false;
            BTN_AgreeToEula.Font = new Font("Segoe UI", 9F);
            BTN_AgreeToEula.Location = new Point(854, 18);
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
            BTN_StopServer.Location = new Point(496, 18);
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
            BTN_StartServer.Location = new Point(415, 18);
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
            PNL_Fill.Size = new Size(1000, 502);
            PNL_Fill.TabIndex = 1;
            // 
            // RTB_ConsoleLog
            // 
            RTB_ConsoleLog.BackColor = Color.Black;
            RTB_ConsoleLog.ContextMenuStrip = CMS_ConsoleLog;
            RTB_ConsoleLog.Dock = DockStyle.Fill;
            RTB_ConsoleLog.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RTB_ConsoleLog.ForeColor = Color.Silver;
            RTB_ConsoleLog.Location = new Point(0, 0);
            RTB_ConsoleLog.Name = "RTB_ConsoleLog";
            RTB_ConsoleLog.ReadOnly = true;
            RTB_ConsoleLog.Size = new Size(1000, 502);
            RTB_ConsoleLog.TabIndex = 0;
            RTB_ConsoleLog.TabStop = false;
            RTB_ConsoleLog.Text = "";
            RTB_ConsoleLog.WordWrap = false;
            // 
            // CMS_ConsoleLog
            // 
            CMS_ConsoleLog.Items.AddRange(new ToolStripItem[] { TSI_ExportLogToFile });
            CMS_ConsoleLog.Name = "CMS_ConsoleLog";
            CMS_ConsoleLog.RenderMode = ToolStripRenderMode.System;
            CMS_ConsoleLog.Size = new Size(162, 26);
            // 
            // TSI_ExportLogToFile
            // 
            TSI_ExportLogToFile.Name = "TSI_ExportLogToFile";
            TSI_ExportLogToFile.Size = new Size(161, 22);
            TSI_ExportLogToFile.Text = "Export log to file";
            TSI_ExportLogToFile.Click += TSI_ExportLogToFile_Clicked;
            // 
            // STS_Status
            // 
            STS_Status.BackColor = SystemColors.ControlLight;
            STS_Status.Font = new Font("Segoe UI", 9F);
            STS_Status.Items.AddRange(new ToolStripItem[] { TSL_Status, TSL_Spacing1, TSL_IP, TSL_Spacing2, TSL_ServerPort, TSL_Spacing3, TSL_Directory, TSL_Spacing4, TSL_RamState, TSL_Spacing5, TSL_CpuState, TSL_Spacing6, TSL_PingState, TSL_Spacing7, TSL_DefaultGamemode });
            STS_Status.Location = new Point(0, 603);
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
            // TSL_Spacing7
            // 
            TSL_Spacing7.Name = "TSL_Spacing7";
            TSL_Spacing7.Size = new Size(22, 17);
            TSL_Spacing7.Text = "     ";
            // 
            // TSL_DefaultGamemode
            // 
            TSL_DefaultGamemode.Name = "TSL_DefaultGamemode";
            TSL_DefaultGamemode.Size = new Size(0, 17);
            // 
            // PNL_LowerSpaceing
            // 
            PNL_LowerSpaceing.BackColor = SystemColors.Control;
            PNL_LowerSpaceing.Controls.Add(TBX_Command);
            PNL_LowerSpaceing.Controls.Add(BTN_SendCommand);
            PNL_LowerSpaceing.Dock = DockStyle.Bottom;
            PNL_LowerSpaceing.Location = new Point(0, 560);
            PNL_LowerSpaceing.Name = "PNL_LowerSpaceing";
            PNL_LowerSpaceing.Size = new Size(1000, 43);
            PNL_LowerSpaceing.TabIndex = 3;
            // 
            // TBX_Command
            // 
            TBX_Command.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBX_Command.AutoCompleteCustomSource.AddRange(new string[] { "?", "ability", "advancement", "alwaysday", "attribute", "ban", "ban-ip", "banlist", "bossbar", "camera", "camerashake", "changesetting", "clear", "clearspawnpoint", "clone", "connect", "damage", "data", "datapack", "daylock", "debug", "dedicatedwsserver", "defaultgamemode", "deop", "dialogue", "difficulty", "effect", "enchant", "event", "execute", "experience", "fill", "fillbiome", "fog", "forceload", "function", "gamemode", "gamerule", "gametest", "give", "help", "immutableworld", "item", "jfr", "kick", "kill", "list", "locate", "loot", "me", "mobevent", "msg", "music", "op", "ops", "pardon", "pardon-ip", "particle", "perf", "permission", "place", "playanimation", "playsound", "publish", "random", "recipe", "reload", "remove", "replaceitem", "return", "ride", "save", "save-all", "save-off", "save-on", "say", "schedule", "scoreboard", "script", "scriptevent", "seed", "setblock", "setidletimeout", "setmaxplayers", "setworldspawn", "spawnpoint", "spectate", "spreadplayers", "stop", "stopsound", "structure", "summon", "tag", "team", "teammsg", "teleport", "tell", "tellraw", "testfor", "testforblock", "testforblocks", "tickingarea", "time", "title", "titleraw", "tm", "toggledownfall", "tp", "trigger", "transferserver", "volumearea", "w", "wb", "weather", "whitelist", "worldborder", "worldbuilder", "wsserver", "xp", "?", "/ability", "/advancement", "/alwaysday", "/attribute", "/ban", "/ban-ip", "/banlist", "/bossbar", "/camera", "/camerashake", "/changesetting", "/clear", "/clearspawnpoint", "/clone", "/connect", "/damage", "/data", "/datapack", "/daylock", "/debug", "/dedicatedwsserver", "/defaultgamemode", "/deop", "/dialogue", "/difficulty", "/effect", "/enchant", "/event", "/execute", "/experience", "/fill", "/fillbiome", "/fog", "/forceload", "/function", "/gamemode", "/gamerule", "/gametest", "/give", "/help", "/immutableworld", "/item", "/jfr", "/kick", "/kill", "/list", "/locate", "/loot", "/me", "/mobevent", "/msg", "/music", "/op", "/ops", "/pardon", "/pardon-ip", "/particle", "/perf", "/permission", "/place", "/playanimation", "/playsound", "/publish", "/random", "/recipe", "/reload", "/remove", "/replaceitem", "/return", "/ride", "/save", "/save-all", "/save-off", "/save-on", "/say", "/schedule", "/scoreboard", "/script", "/scriptevent", "/seed", "/setblock", "/setidletimeout", "/setmaxplayers", "/setworldspawn", "/spawnpoint", "/spectate", "/spreadplayers", "/stop", "/stopsound", "/structure", "/summon", "/tag", "/team", "/teammsg", "/teleport", "/tell", "/tellraw", "/testfor", "/testforblock", "/testforblocks", "/tickingarea", "/time", "/title", "/titleraw", "/tm", "/toggledownfall", "/tp", "/trigger", "/transferserver", "/volumearea", "/w", "/wb", "/weather", "/whitelist", "/worldborder", "/worldbuilder", "/wsserver", "/xp" });
            TBX_Command.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TBX_Command.BackColor = SystemColors.Control;
            TBX_Command.CausesValidation = false;
            TBX_Command.Enabled = false;
            TBX_Command.Font = new Font("Segoe UI", 9F);
            TBX_Command.ForeColor = SystemColors.ControlText;
            TBX_Command.Location = new Point(12, 10);
            TBX_Command.Name = "TBX_Command";
            TBX_Command.Size = new Size(885, 23);
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
            BTN_SendCommand.Location = new Point(903, 10);
            BTN_SendCommand.Name = "BTN_SendCommand";
            BTN_SendCommand.Size = new Size(75, 23);
            BTN_SendCommand.TabIndex = 1;
            BTN_SendCommand.Text = "Send";
            BTN_SendCommand.UseVisualStyleBackColor = false;
            BTN_SendCommand.Click += BTN_SendCommand_Click;
            // 
            // PNL_PlayerList
            // 
            PNL_PlayerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PNL_PlayerList.AutoSize = true;
            PNL_PlayerList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PNL_PlayerList.Location = new Point(2, 0);
            PNL_PlayerList.Name = "PNL_PlayerList";
            PNL_PlayerList.Size = new Size(0, 0);
            PNL_PlayerList.TabIndex = 4;
            // 
            // LBX_PlayerList
            // 
            LBX_PlayerList.BackColor = SystemColors.Control;
            LBX_PlayerList.BorderStyle = BorderStyle.None;
            LBX_PlayerList.Dock = DockStyle.Fill;
            LBX_PlayerList.FormattingEnabled = true;
            LBX_PlayerList.HorizontalScrollbar = true;
            LBX_PlayerList.ItemHeight = 15;
            LBX_PlayerList.Location = new Point(3, 19);
            LBX_PlayerList.Name = "LBX_PlayerList";
            LBX_PlayerList.Size = new Size(273, 261);
            LBX_PlayerList.Sorted = true;
            LBX_PlayerList.TabIndex = 1;
            LBX_PlayerList.UseTabStops = false;
            LBX_PlayerList.MouseUp += LBX_PlayerList_MouseUp;
            // 
            // CMS_PlayerList
            // 
            CMS_PlayerList.Items.AddRange(new ToolStripItem[] { SMI_KickPlayer, SMI_BanPlayer, SMI_OpPlayer, toolStripMenuItem1, SMI_MessagePlayer, SMI_SetGamemodePlayer });
            CMS_PlayerList.Name = "CMS_PlayerList";
            CMS_PlayerList.RenderMode = ToolStripRenderMode.System;
            CMS_PlayerList.Size = new Size(208, 120);
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
            SMI_SetCreative.Size = new Size(129, 22);
            SMI_SetCreative.Text = "Creative";
            SMI_SetCreative.Click += SMI_SetCreative_Click;
            // 
            // SMI_SetSurvival
            // 
            SMI_SetSurvival.Name = "SMI_SetSurvival";
            SMI_SetSurvival.Size = new Size(129, 22);
            SMI_SetSurvival.Text = "Survival";
            SMI_SetSurvival.Click += SMI_SetSurvival_Click;
            // 
            // SMI_SetAdventure
            // 
            SMI_SetAdventure.Name = "SMI_SetAdventure";
            SMI_SetAdventure.Size = new Size(129, 22);
            SMI_SetAdventure.Text = "Adventure";
            SMI_SetAdventure.Click += SMI_SetAdventure_Click;
            // 
            // SMI_SetSpectator
            // 
            SMI_SetSpectator.Name = "SMI_SetSpectator";
            SMI_SetSpectator.Size = new Size(129, 22);
            SMI_SetSpectator.Text = "Spectator";
            SMI_SetSpectator.Click += SMI_SetSpectator_Click;
            // 
            // PNL_PluginsList
            // 
            PNL_PluginsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PNL_PluginsList.AutoSize = true;
            PNL_PluginsList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PNL_PluginsList.Location = new Point(204, 33);
            PNL_PluginsList.Name = "PNL_PluginsList";
            PNL_PluginsList.Size = new Size(0, 0);
            PNL_PluginsList.TabIndex = 5;
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
            // SPC_Main
            // 
            SPC_Main.Dock = DockStyle.Fill;
            SPC_Main.Location = new Point(0, 0);
            SPC_Main.Name = "SPC_Main";
            // 
            // SPC_Main.Panel1
            // 
            SPC_Main.Panel1.Controls.Add(PNL_Fill);
            SPC_Main.Panel1.Controls.Add(PNL_UpperSpaceing);
            SPC_Main.Panel1.Controls.Add(PNL_LowerSpaceing);
            SPC_Main.Panel1MinSize = 1000;
            // 
            // SPC_Main.Panel2
            // 
            SPC_Main.Panel2.AutoScroll = true;
            SPC_Main.Panel2.Controls.Add(GBX_PluginsList);
            SPC_Main.Panel2.Controls.Add(GBX_PlayersList);
            SPC_Main.Panel2.Controls.Add(PNL_PlayerList);
            SPC_Main.Panel2.Controls.Add(PNL_PluginsList);
            SPC_Main.Panel2MinSize = 0;
            SPC_Main.Size = new Size(1298, 603);
            SPC_Main.SplitterDistance = 1000;
            SPC_Main.TabIndex = 6;
            // 
            // GBX_PluginsList
            // 
            GBX_PluginsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GBX_PluginsList.Controls.Add(LBX_PluginsList);
            GBX_PluginsList.Location = new Point(9, 289);
            GBX_PluginsList.Name = "GBX_PluginsList";
            GBX_PluginsList.Size = new Size(276, 304);
            GBX_PluginsList.TabIndex = 7;
            GBX_PluginsList.TabStop = false;
            GBX_PluginsList.Text = "Plugins (0):";
            // 
            // LBX_PluginsList
            // 
            LBX_PluginsList.BackColor = SystemColors.Control;
            LBX_PluginsList.BorderStyle = BorderStyle.None;
            LBX_PluginsList.Dock = DockStyle.Fill;
            LBX_PluginsList.FormattingEnabled = true;
            LBX_PluginsList.HorizontalScrollbar = true;
            LBX_PluginsList.ItemHeight = 15;
            LBX_PluginsList.Location = new Point(3, 19);
            LBX_PluginsList.Name = "LBX_PluginsList";
            LBX_PluginsList.Size = new Size(270, 282);
            LBX_PluginsList.Sorted = true;
            LBX_PluginsList.TabIndex = 1;
            LBX_PluginsList.UseTabStops = false;
            LBX_PluginsList.MouseUp += LBX_PluginsList_MouseUp;
            // 
            // GBX_PlayersList
            // 
            GBX_PlayersList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GBX_PlayersList.Controls.Add(LBX_PlayerList);
            GBX_PlayersList.Location = new Point(8, 3);
            GBX_PlayersList.Name = "GBX_PlayersList";
            GBX_PlayersList.Size = new Size(279, 283);
            GBX_PlayersList.TabIndex = 6;
            GBX_PlayersList.TabStop = false;
            GBX_PlayersList.Text = "Players (0):";
            // 
            // Console
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 625);
            Controls.Add(SPC_Main);
            Controls.Add(STS_Status);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(956, 664);
            Name = "Console";
            Text = "ඞ Console";
            FormClosing += Console_FormClosing;
            SizeChanged += Console_SizeChanged;
            KeyDown += Console_KeyDown;
            PNL_UpperSpaceing.ResumeLayout(false);
            PNL_Fill.ResumeLayout(false);
            CMS_ConsoleLog.ResumeLayout(false);
            STS_Status.ResumeLayout(false);
            STS_Status.PerformLayout();
            PNL_LowerSpaceing.ResumeLayout(false);
            PNL_LowerSpaceing.PerformLayout();
            CMS_PlayerList.ResumeLayout(false);
            CMS_PluginsList.ResumeLayout(false);
            SPC_Main.Panel1.ResumeLayout(false);
            SPC_Main.Panel2.ResumeLayout(false);
            SPC_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SPC_Main).EndInit();
            SPC_Main.ResumeLayout(false);
            GBX_PluginsList.ResumeLayout(false);
            GBX_PlayersList.ResumeLayout(false);
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
        private SplitContainer SPC_Main;
        private ListBox LBX_PluginsList;
        private GroupBox GBX_PlayersList;
        private GroupBox GBX_PluginsList;
        private ContextMenuStrip CMS_ConsoleLog;
        private ToolStripMenuItem TSI_ExportLogToFile;
        private ToolStripStatusLabel TSL_Spacing7;
        private ToolStripStatusLabel TSL_DefaultGamemode;
    }
}
