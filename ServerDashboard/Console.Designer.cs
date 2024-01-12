﻿namespace ServerDashboard
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
            PNL_LowerSpaceing = new Panel();
            TBX_Command = new TextBox();
            BTN_SendCommand = new Button();
            PNL_PlayerList = new Panel();
            LBX_PlayerList = new ListBox();
            LBL_PlayerList = new Label();
            CMS_PlayerList = new ContextMenuStrip(components);
            kickPlayerToolStripMenuItem = new ToolStripMenuItem();
            banPlayerToolStripMenuItem = new ToolStripMenuItem();
            makePlayerAnOPToolStripMenuItem = new ToolStripMenuItem();
            PNL_UpperSpaceing.SuspendLayout();
            PNL_Fill.SuspendLayout();
            STS_Status.SuspendLayout();
            PNL_LowerSpaceing.SuspendLayout();
            PNL_PlayerList.SuspendLayout();
            CMS_PlayerList.SuspendLayout();
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
            PNL_UpperSpaceing.Size = new Size(864, 58);
            PNL_UpperSpaceing.TabIndex = 0;
            // 
            // BTN_AgreeToEula
            // 
            BTN_AgreeToEula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_AgreeToEula.AutoEllipsis = true;
            BTN_AgreeToEula.BackColor = Color.White;
            BTN_AgreeToEula.Enabled = false;
            BTN_AgreeToEula.Font = new Font("Segoe UI", 9F);
            BTN_AgreeToEula.Location = new Point(736, 18);
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
            BTN_StopServer.Location = new Point(437, 18);
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
            BTN_StartServer.Location = new Point(356, 18);
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
            PNL_Fill.Size = new Size(864, 442);
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
            RTB_ConsoleLog.Size = new Size(864, 442);
            RTB_ConsoleLog.TabIndex = 0;
            RTB_ConsoleLog.TabStop = false;
            RTB_ConsoleLog.Text = "";
            RTB_ConsoleLog.WordWrap = false;
            // 
            // STS_Status
            // 
            STS_Status.BackColor = SystemColors.ControlLight;
            STS_Status.Font = new Font("Segoe UI", 9F);
            STS_Status.Items.AddRange(new ToolStripItem[] { TSL_Status, TSL_Spacing1, TSL_IP, TSL_Spacing2, TSL_ServerPort, TSL_Spacing3, TSL_Directory });
            STS_Status.Location = new Point(0, 543);
            STS_Status.Name = "STS_Status";
            STS_Status.Size = new Size(1017, 22);
            STS_Status.TabIndex = 2;
            // 
            // TSL_Status
            // 
            TSL_Status.ForeColor = SystemColors.ControlText;
            TSL_Status.Name = "TSL_Status";
            TSL_Status.Size = new Size(48, 17);
            TSL_Status.Text = "Ready...";
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
            // PNL_LowerSpaceing
            // 
            PNL_LowerSpaceing.BackColor = SystemColors.Control;
            PNL_LowerSpaceing.Controls.Add(TBX_Command);
            PNL_LowerSpaceing.Controls.Add(BTN_SendCommand);
            PNL_LowerSpaceing.Dock = DockStyle.Bottom;
            PNL_LowerSpaceing.Location = new Point(0, 500);
            PNL_LowerSpaceing.Name = "PNL_LowerSpaceing";
            PNL_LowerSpaceing.Size = new Size(1017, 43);
            PNL_LowerSpaceing.TabIndex = 3;
            // 
            // TBX_Command
            // 
            TBX_Command.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBX_Command.BackColor = SystemColors.Control;
            TBX_Command.CausesValidation = false;
            TBX_Command.Enabled = false;
            TBX_Command.Font = new Font("Segoe UI", 9F);
            TBX_Command.ForeColor = SystemColors.ControlText;
            TBX_Command.Location = new Point(12, 10);
            TBX_Command.Name = "TBX_Command";
            TBX_Command.Size = new Size(920, 23);
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
            BTN_SendCommand.Location = new Point(938, 10);
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
            PNL_PlayerList.Location = new Point(864, 0);
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
            CMS_PlayerList.Items.AddRange(new ToolStripItem[] { kickPlayerToolStripMenuItem, banPlayerToolStripMenuItem, makePlayerAnOPToolStripMenuItem });
            CMS_PlayerList.Name = "CMS_PlayerList";
            CMS_PlayerList.RenderMode = ToolStripRenderMode.System;
            CMS_PlayerList.Size = new Size(174, 70);
            // 
            // kickPlayerToolStripMenuItem
            // 
            kickPlayerToolStripMenuItem.Name = "kickPlayerToolStripMenuItem";
            kickPlayerToolStripMenuItem.Size = new Size(173, 22);
            kickPlayerToolStripMenuItem.Text = "Kick player";
            kickPlayerToolStripMenuItem.Click += kickPlayerToolStripMenuItem_Click;
            // 
            // banPlayerToolStripMenuItem
            // 
            banPlayerToolStripMenuItem.Name = "banPlayerToolStripMenuItem";
            banPlayerToolStripMenuItem.Size = new Size(173, 22);
            banPlayerToolStripMenuItem.Text = "Ban player";
            banPlayerToolStripMenuItem.Click += banPlayerToolStripMenuItem_Click;
            // 
            // makePlayerAnOPToolStripMenuItem
            // 
            makePlayerAnOPToolStripMenuItem.Name = "makePlayerAnOPToolStripMenuItem";
            makePlayerAnOPToolStripMenuItem.Size = new Size(173, 22);
            makePlayerAnOPToolStripMenuItem.Text = "Make player an OP";
            makePlayerAnOPToolStripMenuItem.Click += makePlayerAnOPToolStripMenuItem_Click;
            // 
            // Console
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 565);
            Controls.Add(PNL_Fill);
            Controls.Add(PNL_UpperSpaceing);
            Controls.Add(PNL_PlayerList);
            Controls.Add(PNL_LowerSpaceing);
            Controls.Add(STS_Status);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(758, 549);
            Name = "Console";
            Text = "Console";
            PNL_UpperSpaceing.ResumeLayout(false);
            PNL_Fill.ResumeLayout(false);
            STS_Status.ResumeLayout(false);
            STS_Status.PerformLayout();
            PNL_LowerSpaceing.ResumeLayout(false);
            PNL_LowerSpaceing.PerformLayout();
            PNL_PlayerList.ResumeLayout(false);
            PNL_PlayerList.PerformLayout();
            CMS_PlayerList.ResumeLayout(false);
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
        private ToolStripMenuItem kickPlayerToolStripMenuItem;
        private ToolStripMenuItem banPlayerToolStripMenuItem;
        private ToolStripMenuItem makePlayerAnOPToolStripMenuItem;
    }
}
