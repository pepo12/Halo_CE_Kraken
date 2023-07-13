using System.Drawing.Text;
using System.Security.AccessControl;

namespace chimera_editor.Presentation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlHalo = new Panel();
            LbHaloDesc = new Label();
            LbHalo = new Label();
            VSBEditor = new VScrollBar();
            LbPath = new Label();
            TbxPath = new TextBox();
            BtnPath = new Button();
            CbPath = new CheckBox();
            CbDownPath = new CheckBox();
            BtnDownPath = new Button();
            TbxDownPath = new TextBox();
            LbDownPath = new Label();
            CbMapsPath = new CheckBox();
            BtnMapsPath = new Button();
            TbxMapsPath = new TextBox();
            LbMapsPath = new Label();
            CbExec = new CheckBox();
            BtnExec = new Button();
            TbxExec = new TextBox();
            LbExec = new Label();
            CbGamePorts = new CheckBox();
            TbxServerPort = new TextBox();
            LbGamePorts = new Label();
            TbxClientPort = new TextBox();
            LbServerPort = new Label();
            LbClientPort = new Label();
            CbIntroVideos = new CheckBox();
            LbIntroVideos = new Label();
            CbConsole = new CheckBox();
            LbConsole = new Label();
            CbOptiDef = new CheckBox();
            LbOptiDef = new Label();
            CbMenuMusic = new CheckBox();
            LbMenuMusic = new Label();
            CbBackPlay = new CheckBox();
            LbBackPlay = new Label();
            CbMultiInst = new CheckBox();
            LbMultiInst = new Label();
            CbHash = new CheckBox();
            TbxHash = new TextBox();
            LbHash = new Label();
            PnlErrorHand = new Panel();
            LbErrorHandDesc = new Label();
            LbErrorHand = new Label();
            CbShowSeg = new CheckBox();
            LbShowSeg = new Label();
            CbSupFatal = new CheckBox();
            LbSupFatal = new Label();
            PnlVideoMode = new Panel();
            LbVideoModeDesc = new Label();
            LbVideoMode = new Label();
            panel2 = new Panel();
            CbEnblVideoMode = new CheckBox();
            LbEnblVideoMode = new Label();
            LbResHeight = new Label();
            LbResWidth = new Label();
            TbxResHeight = new TextBox();
            CbResolution = new CheckBox();
            TbxResWidth = new TextBox();
            LbResolution = new Label();
            CbRefRate = new CheckBox();
            TbxRefRate = new TextBox();
            LbRefRate = new Label();
            CbVsync = new CheckBox();
            TbxVsync = new TextBox();
            LbVsync = new Label();
            CbWindowed = new CheckBox();
            LbWindowed = new Label();
            CbBorderless = new CheckBox();
            LbBorderless = new Label();
            PnlScoreboard = new Panel();
            LbScoreboardDesc = new Label();
            LbScoreboard = new Label();
            LbScoreboardFont = new Label();
            TbxScoreboardFade = new TextBox();
            LbScoreboardFade = new Label();
            PnlNameSet = new Panel();
            LbNameSetDesc = new Label();
            LbNameSet = new Label();
            LbNameFont = new Label();
            ComBoxScoreboardFont = new ComboBox();
            ComBoxNameFont = new ComboBox();
            PnlServerList = new Panel();
            LbServerListDesc = new Label();
            LbServerList = new Label();
            CbAutoQuery = new CheckBox();
            LbAutoQuery = new Label();
            CbMstrSvList = new CheckBox();
            TbxMstrSvList = new TextBox();
            LbMstrSvList = new Label();
            CbMstrSvKey = new CheckBox();
            TbxMstrSvKey = new TextBox();
            LbMstrSvKey = new Label();
            CbMstrSvNatP = new CheckBox();
            TbxMstrSvNatP = new TextBox();
            LbMstrSvNatP = new Label();
            CbMstrSvNatS = new CheckBox();
            TbxMstrSvNatS = new TextBox();
            LbMstrSvNatS = new Label();
            PnlMemory = new Panel();
            LbMemoryDesc = new Label();
            LbMemory = new Label();
            CbMapSize = new CheckBox();
            TbxMapSize = new TextBox();
            LbMapSize = new Label();
            CbMapMmryBuffer = new CheckBox();
            LbMapMmryBuffer = new Label();
            CbBenchmark = new CheckBox();
            LbBenchmark = new Label();
            ComBoxDownloadFont = new ComboBox();
            LbDownloadFont = new Label();
            TbxDownloadUrl = new TextBox();
            LbDownloadUrl = new Label();
            CbDownloadRetail = new CheckBox();
            LbDownloadRetail = new Label();
            PnlFontOver = new Panel();
            LbFontOverDesc = new Label();
            LbFontOver = new Label();
            CbFontOverEnabled = new CheckBox();
            LbFontOverEnabled = new Label();
            LbSystemFW = new Label();
            LbSystemFF = new Label();
            TbxSystemFW = new TextBox();
            CbSystemFO = new CheckBox();
            TbxSystemFF = new TextBox();
            LbSystemFO = new Label();
            LbSystemFS = new Label();
            TbxSystemFS = new TextBox();
            LbSystemXY = new Label();
            TbxSystemXO = new TextBox();
            TbxSystemSh = new Label();
            TbxSystemSX = new TextBox();
            TbxSystemSY = new TextBox();
            TbxSystemYO = new TextBox();
            TbxLargeSY = new TextBox();
            TbxLargeYO = new TextBox();
            LbLargeSh = new Label();
            TbxLargeSX = new TextBox();
            LbLargeXY = new Label();
            TbxLargeXO = new TextBox();
            LbLargeFS = new Label();
            TbxLargeFS = new TextBox();
            LbLargeFW = new Label();
            LbLargeFF = new Label();
            TbxLargeFW = new TextBox();
            CbLargeFO = new CheckBox();
            TbxLargeFF = new TextBox();
            LbLargeFO = new Label();
            TbxSmallSY = new TextBox();
            TbxSmallYO = new TextBox();
            LbSmallSh = new Label();
            TbxSmallSX = new TextBox();
            label15 = new Label();
            TbxSmallXO = new TextBox();
            LbSmallFS = new Label();
            TbxSmallFS = new TextBox();
            LbSmallFW = new Label();
            LbSmallFF = new Label();
            TbxSmallFW = new TextBox();
            CbSmallFO = new CheckBox();
            TbxSmallFF = new TextBox();
            LbSmallFO = new Label();
            TbxSmallerSY = new TextBox();
            TbxSmallerYO = new TextBox();
            LbSmallerSh = new Label();
            TbxSmallerSX = new TextBox();
            LbSmallerXY = new Label();
            TbxSmallerXO = new TextBox();
            LbSmallerFS = new Label();
            TbxSmallerFS = new TextBox();
            LbSmallerFW = new Label();
            LbSmallerFF = new Label();
            TbxSmallerFW = new TextBox();
            CbSmallerFO = new CheckBox();
            TbxSmallerFF = new TextBox();
            LbSmallerFO = new Label();
            TbxTickerSY = new TextBox();
            TbxTickerYO = new TextBox();
            LbTickerSh = new Label();
            TbxTickerSX = new TextBox();
            LbTickerXY = new Label();
            TbxTickerXO = new TextBox();
            LbTickerFS = new Label();
            TbxTickerFS = new TextBox();
            LbTickerFW = new Label();
            LbTickerFF = new Label();
            TbxTickerFW = new TextBox();
            CbTickerFO = new CheckBox();
            TbxTickerFF = new TextBox();
            LbTickerFO = new Label();
            TbxConsoleSY = new TextBox();
            TbxConsoleYO = new TextBox();
            LbConsoleSh = new Label();
            TbxConsoleSX = new TextBox();
            TbxConsoleXY = new Label();
            TbxConsoleXO = new TextBox();
            LbConsoleFS = new Label();
            TbxConsoleFS = new TextBox();
            LbConsoleFW = new Label();
            LbConsoleFF = new Label();
            TbxConsoleFW = new TextBox();
            CbConsoleFO = new CheckBox();
            TbxConsoleFF = new TextBox();
            LbConsoleFO = new Label();
            CbControllerEnabled = new CheckBox();
            LbControllerEnabled = new Label();
            PnlController = new Panel();
            LbControllerDesc = new Label();
            LbController = new Label();
            CbCustomCEnabled = new CheckBox();
            LbCustomCEnabled = new Label();
            PnlCustomC = new Panel();
            LbCustomCDesc = new Label();
            LbCustomC = new Label();
            TbxControllerConfig = new TextBox();
            CbScrollback = new CheckBox();
            LbScrollback = new Label();
            TbxConsoleBuffer = new TextBox();
            LbConsoleBuffer = new Label();
            TbxConsoleSoft = new TextBox();
            LbConsoleSoft = new Label();
            TbxLineHeight = new TextBox();
            LbLineHeight = new Label();
            TbxXMargin = new TextBox();
            LbXMargin = new Label();
            TbxCFadeStart = new TextBox();
            LbCFadeStart = new Label();
            TbxCFadeTime = new TextBox();
            PnlCustomChat = new Panel();
            LbCustomChatDesc = new Label();
            LbCustomChat = new Label();
            CbAllowRcon = new CheckBox();
            LbAllowRcon = new Label();
            LbSvMsgColor = new Label();
            LbSvMsgOff = new Label();
            LbSvMsgDim = new Label();
            LbSvMsgOC = new Label();
            LbSvMsgAnchor = new Label();
            LbSvMsgCHide = new Label();
            LbSvMsgFont = new Label();
            LbSvMsgAniTime = new Label();
            LbSvMsgDisTime = new Label();
            LbSvMsgFadeTime = new Label();
            LbSvMsgLineH = new Label();
            LbSvMsg = new Label();
            TbxSvMsgColorA = new TextBox();
            TbxSvMsgColorR = new TextBox();
            TbxSvMsgColorG = new TextBox();
            LbSvMsgColorA = new Label();
            LbSvMsgColorR = new Label();
            LbSvMsgColorG = new Label();
            TbxSvMsgOffX = new TextBox();
            TbxSvMsgDimX = new TextBox();
            TbxSvMsgOC = new TextBox();
            TbxSvMsgAniTime = new TextBox();
            TbxSvMsgDisTime = new TextBox();
            TbxSvMsgFadeTime = new TextBox();
            TbxSvMsgLineH = new TextBox();
            PnlSvMsg = new Panel();
            TbxSvMsgOffY = new TextBox();
            TbxSvMsgDimY = new TextBox();
            TbxChtMsgDimY = new TextBox();
            TbxChtMsgOffY = new TextBox();
            TbxChtMsgLineH = new TextBox();
            TbxChtMsgFadeTime = new TextBox();
            TbxChtMsgDisTime = new TextBox();
            TbxChtMsgAniTime = new TextBox();
            TbxChtMsgOC = new TextBox();
            TbxChtMsgDimX = new TextBox();
            TbxChtMsgOffX = new TextBox();
            LbChtMsgFfaG = new Label();
            LbChtMsgFfaR = new Label();
            LbChtMsgFfaA = new Label();
            TbxChtMsgFfa = new TextBox();
            TbxChtMsgFfaR = new TextBox();
            TbxChtMsgFfaA = new TextBox();
            LbChtMsg = new Label();
            LbChtMsgLineH = new Label();
            LbChtMsgFadeTime = new Label();
            LbChtMsgDisTime = new Label();
            LbChtMsgAniTime = new Label();
            LbChtMsgFont = new Label();
            LbChtMsgCHide = new Label();
            LbChtMsgAnchor = new Label();
            LbChtMsgOC = new Label();
            LbChtMsgDim = new Label();
            LbChtMsgOff = new Label();
            LbChtMsgFfa = new Label();
            PnlChtMsg = new Panel();
            LbChtMsgRedG = new Label();
            LbChtMsgRedR = new Label();
            LbChtMsgRedA = new Label();
            TbxChtMsgRedG = new TextBox();
            TbxChtMsgRedR = new TextBox();
            TbxChtMsgRedA = new TextBox();
            LbChtMsgBlueG = new Label();
            LbChtMsgBlueR = new Label();
            LbChtMsgBlueA = new Label();
            TbxChtMsgBlueG = new TextBox();
            TbxChtMsgBlueR = new TextBox();
            TbxChtMsgBlueA = new TextBox();
            LbSvMsgColorB = new Label();
            TbxSvMsgColorB = new TextBox();
            LbChtMsgBlueB = new Label();
            TbxChtMsgBlueB = new TextBox();
            LbChtMsgRedB = new Label();
            TbxChtMsgRedB = new TextBox();
            LbChtMsgFfaB = new Label();
            TbxChtMsgFfaB = new TextBox();
            LbChtMsgRed = new Label();
            LbChtMsgBlue = new Label();
            LbChtInColorB = new Label();
            TbxChtInColorB = new TextBox();
            TbxChtInOffY = new TextBox();
            TbxChtInWidth = new TextBox();
            TbxChtInOffX = new TextBox();
            LbChtInColorG = new Label();
            LbChtInColorR = new Label();
            LbChtInColorA = new Label();
            TbxChtInColorG = new TextBox();
            TbxChtInColorR = new TextBox();
            TbxChtInColorA = new TextBox();
            LbChtIn = new Label();
            LbChtInFont = new Label();
            LbChtInAnchor = new Label();
            LbChtInWidth = new Label();
            LbChtInOff = new Label();
            LbChtInColor = new Label();
            PnlChtIn = new Panel();
            LbSvMsgOffY = new Label();
            LbSvMsgOffX = new Label();
            LbSvMsgDimY = new Label();
            LbSvMsgDimX = new Label();
            LbChtMsgOffY = new Label();
            LbChtMsgOffX = new Label();
            LbChtMsgDimY = new Label();
            LbChtMsgDimX = new Label();
            ComBoxSvMsgAnchor = new ComboBox();
            CbSvMsgCHide = new CheckBox();
            ComBoxSvMsgFont = new ComboBox();
            ComBoxChtMsgFont = new ComboBox();
            CbChtMsgCHide = new CheckBox();
            ComBoxChtMsgAnchor = new ComboBox();
            ComBoxChtInFont = new ComboBox();
            LbChtInOffY = new Label();
            LbChtInOffX = new Label();
            ComBoxChtInAnchor = new ComboBox();
            PnlHalo.SuspendLayout();
            PnlErrorHand.SuspendLayout();
            PnlVideoMode.SuspendLayout();
            PnlScoreboard.SuspendLayout();
            PnlNameSet.SuspendLayout();
            PnlServerList.SuspendLayout();
            PnlMemory.SuspendLayout();
            PnlFontOver.SuspendLayout();
            PnlController.SuspendLayout();
            PnlCustomC.SuspendLayout();
            PnlCustomChat.SuspendLayout();
            PnlChtMsg.SuspendLayout();
            SuspendLayout();
            // 
            // PnlHalo
            // 
            PnlHalo.BackColor = SystemColors.ControlLight;
            PnlHalo.BorderStyle = BorderStyle.Fixed3D;
            PnlHalo.Controls.Add(LbHaloDesc);
            PnlHalo.Controls.Add(LbHalo);
            PnlHalo.Location = new Point(8, 31);
            PnlHalo.Name = "PnlHalo";
            PnlHalo.Size = new Size(543, 63);
            PnlHalo.TabIndex = 0;
            // 
            // LbHaloDesc
            // 
            LbHaloDesc.AutoSize = true;
            LbHaloDesc.Location = new Point(4, 24);
            LbHaloDesc.Name = "LbHaloDesc";
            LbHaloDesc.Size = new Size(254, 30);
            LbHaloDesc.TabIndex = 1;
            LbHaloDesc.Text = "halo initialization settings.\r\nthis is used to configure how Halo is initialized.";
            // 
            // LbHalo
            // 
            LbHalo.AutoSize = true;
            LbHalo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbHalo.Location = new Point(4, 5);
            LbHalo.Name = "LbHalo";
            LbHalo.Size = new Size(36, 19);
            LbHalo.TabIndex = 0;
            LbHalo.Text = "halo";
            // 
            // VSBEditor
            // 
            VSBEditor.Dock = DockStyle.Right;
            VSBEditor.Location = new Point(604, 0);
            VSBEditor.Name = "VSBEditor";
            VSBEditor.Size = new Size(17, 4840);
            VSBEditor.TabIndex = 1;
            // 
            // LbPath
            // 
            LbPath.AutoSize = true;
            LbPath.Location = new Point(14, 105);
            LbPath.Margin = new Padding(8, 8, 8, 0);
            LbPath.Name = "LbPath";
            LbPath.Size = new Size(73, 15);
            LbPath.TabIndex = 3;
            LbPath.Text = "profiles path";
            // 
            // TbxPath
            // 
            TbxPath.Location = new Point(201, 102);
            TbxPath.Margin = new Padding(3, 3, 10, 3);
            TbxPath.Name = "TbxPath";
            TbxPath.Size = new Size(313, 23);
            TbxPath.TabIndex = 17;
            // 
            // BtnPath
            // 
            BtnPath.Location = new Point(527, 102);
            BtnPath.Name = "BtnPath";
            BtnPath.Size = new Size(24, 23);
            BtnPath.TabIndex = 18;
            BtnPath.Text = "...";
            BtnPath.UseVisualStyleBackColor = true;
            // 
            // CbPath
            // 
            CbPath.AutoSize = true;
            CbPath.Location = new Point(180, 107);
            CbPath.Name = "CbPath";
            CbPath.Size = new Size(15, 14);
            CbPath.TabIndex = 19;
            CbPath.UseVisualStyleBackColor = true;
            // 
            // CbDownPath
            // 
            CbDownPath.AutoSize = true;
            CbDownPath.Location = new Point(180, 134);
            CbDownPath.Name = "CbDownPath";
            CbDownPath.Size = new Size(15, 14);
            CbDownPath.TabIndex = 23;
            CbDownPath.UseVisualStyleBackColor = true;
            // 
            // BtnDownPath
            // 
            BtnDownPath.Location = new Point(527, 129);
            BtnDownPath.Name = "BtnDownPath";
            BtnDownPath.Size = new Size(24, 23);
            BtnDownPath.TabIndex = 22;
            BtnDownPath.Text = "...";
            BtnDownPath.UseVisualStyleBackColor = true;
            // 
            // TbxDownPath
            // 
            TbxDownPath.Location = new Point(201, 129);
            TbxDownPath.Margin = new Padding(3, 3, 10, 3);
            TbxDownPath.Name = "TbxDownPath";
            TbxDownPath.Size = new Size(313, 23);
            TbxDownPath.TabIndex = 21;
            // 
            // LbDownPath
            // 
            LbDownPath.AutoSize = true;
            LbDownPath.Location = new Point(14, 132);
            LbDownPath.Margin = new Padding(8, 12, 8, 0);
            LbDownPath.Name = "LbDownPath";
            LbDownPath.Size = new Size(87, 15);
            LbDownPath.TabIndex = 20;
            LbDownPath.Text = "download path";
            // 
            // CbMapsPath
            // 
            CbMapsPath.AutoSize = true;
            CbMapsPath.Location = new Point(180, 161);
            CbMapsPath.Name = "CbMapsPath";
            CbMapsPath.Size = new Size(15, 14);
            CbMapsPath.TabIndex = 27;
            CbMapsPath.UseVisualStyleBackColor = true;
            // 
            // BtnMapsPath
            // 
            BtnMapsPath.Location = new Point(527, 156);
            BtnMapsPath.Name = "BtnMapsPath";
            BtnMapsPath.Size = new Size(24, 23);
            BtnMapsPath.TabIndex = 26;
            BtnMapsPath.Text = "...";
            BtnMapsPath.UseVisualStyleBackColor = true;
            // 
            // TbxMapsPath
            // 
            TbxMapsPath.Location = new Point(201, 156);
            TbxMapsPath.Margin = new Padding(3, 3, 10, 3);
            TbxMapsPath.Name = "TbxMapsPath";
            TbxMapsPath.Size = new Size(313, 23);
            TbxMapsPath.TabIndex = 25;
            // 
            // LbMapsPath
            // 
            LbMapsPath.AutoSize = true;
            LbMapsPath.Location = new Point(14, 159);
            LbMapsPath.Margin = new Padding(8, 12, 8, 0);
            LbMapsPath.Name = "LbMapsPath";
            LbMapsPath.Size = new Size(63, 15);
            LbMapsPath.TabIndex = 24;
            LbMapsPath.Text = "maps path";
            // 
            // CbExec
            // 
            CbExec.AutoSize = true;
            CbExec.Location = new Point(180, 188);
            CbExec.Name = "CbExec";
            CbExec.Size = new Size(15, 14);
            CbExec.TabIndex = 31;
            CbExec.UseVisualStyleBackColor = true;
            // 
            // BtnExec
            // 
            BtnExec.Location = new Point(527, 183);
            BtnExec.Name = "BtnExec";
            BtnExec.Size = new Size(24, 23);
            BtnExec.TabIndex = 30;
            BtnExec.Text = "...";
            BtnExec.UseVisualStyleBackColor = true;
            // 
            // TbxExec
            // 
            TbxExec.Location = new Point(201, 183);
            TbxExec.Margin = new Padding(3, 3, 10, 3);
            TbxExec.Name = "TbxExec";
            TbxExec.Size = new Size(313, 23);
            TbxExec.TabIndex = 29;
            // 
            // LbExec
            // 
            LbExec.AutoSize = true;
            LbExec.Location = new Point(14, 186);
            LbExec.Margin = new Padding(8, 12, 8, 0);
            LbExec.Name = "LbExec";
            LbExec.Size = new Size(31, 15);
            LbExec.TabIndex = 28;
            LbExec.Text = "exec";
            // 
            // CbGamePorts
            // 
            CbGamePorts.AutoSize = true;
            CbGamePorts.Location = new Point(180, 215);
            CbGamePorts.Name = "CbGamePorts";
            CbGamePorts.Size = new Size(15, 14);
            CbGamePorts.TabIndex = 35;
            CbGamePorts.UseVisualStyleBackColor = true;
            // 
            // TbxServerPort
            // 
            TbxServerPort.Location = new Point(201, 210);
            TbxServerPort.Margin = new Padding(3, 3, 10, 3);
            TbxServerPort.Name = "TbxServerPort";
            TbxServerPort.Size = new Size(118, 23);
            TbxServerPort.TabIndex = 33;
            // 
            // LbGamePorts
            // 
            LbGamePorts.AutoSize = true;
            LbGamePorts.Location = new Point(14, 213);
            LbGamePorts.Margin = new Padding(8, 12, 8, 0);
            LbGamePorts.Name = "LbGamePorts";
            LbGamePorts.Size = new Size(34, 15);
            LbGamePorts.TabIndex = 32;
            LbGamePorts.Text = "ports";
            // 
            // TbxClientPort
            // 
            TbxClientPort.Location = new Point(201, 237);
            TbxClientPort.Margin = new Padding(3, 3, 10, 3);
            TbxClientPort.Name = "TbxClientPort";
            TbxClientPort.Size = new Size(118, 23);
            TbxClientPort.TabIndex = 37;
            // 
            // LbServerPort
            // 
            LbServerPort.AutoSize = true;
            LbServerPort.Location = new Point(333, 213);
            LbServerPort.Margin = new Padding(4, 12, 8, 0);
            LbServerPort.Name = "LbServerPort";
            LbServerPort.Size = new Size(63, 15);
            LbServerPort.TabIndex = 38;
            LbServerPort.Text = "server port";
            // 
            // LbClientPort
            // 
            LbClientPort.AutoSize = true;
            LbClientPort.Location = new Point(333, 240);
            LbClientPort.Margin = new Padding(4, 12, 8, 0);
            LbClientPort.Name = "LbClientPort";
            LbClientPort.Size = new Size(61, 15);
            LbClientPort.TabIndex = 39;
            LbClientPort.Text = "client port";
            // 
            // CbIntroVideos
            // 
            CbIntroVideos.AutoSize = true;
            CbIntroVideos.Location = new Point(180, 269);
            CbIntroVideos.Name = "CbIntroVideos";
            CbIntroVideos.Size = new Size(15, 14);
            CbIntroVideos.TabIndex = 43;
            CbIntroVideos.UseVisualStyleBackColor = true;
            // 
            // LbIntroVideos
            // 
            LbIntroVideos.AutoSize = true;
            LbIntroVideos.Location = new Point(14, 267);
            LbIntroVideos.Margin = new Padding(8, 12, 8, 0);
            LbIntroVideos.Name = "LbIntroVideos";
            LbIntroVideos.Size = new Size(69, 15);
            LbIntroVideos.TabIndex = 42;
            LbIntroVideos.Text = "intro videos";
            // 
            // CbConsole
            // 
            CbConsole.AutoSize = true;
            CbConsole.Location = new Point(180, 296);
            CbConsole.Name = "CbConsole";
            CbConsole.Size = new Size(15, 14);
            CbConsole.TabIndex = 45;
            CbConsole.UseVisualStyleBackColor = true;
            // 
            // LbConsole
            // 
            LbConsole.AutoSize = true;
            LbConsole.Location = new Point(14, 294);
            LbConsole.Margin = new Padding(8, 12, 8, 0);
            LbConsole.Name = "LbConsole";
            LbConsole.Size = new Size(48, 15);
            LbConsole.TabIndex = 44;
            LbConsole.Text = "console";
            // 
            // CbOptiDef
            // 
            CbOptiDef.AutoSize = true;
            CbOptiDef.Location = new Point(180, 323);
            CbOptiDef.Name = "CbOptiDef";
            CbOptiDef.Size = new Size(15, 14);
            CbOptiDef.TabIndex = 47;
            CbOptiDef.UseVisualStyleBackColor = true;
            // 
            // LbOptiDef
            // 
            LbOptiDef.AutoSize = true;
            LbOptiDef.Location = new Point(14, 321);
            LbOptiDef.Margin = new Padding(8, 12, 8, 0);
            LbOptiDef.Name = "LbOptiDef";
            LbOptiDef.Size = new Size(93, 15);
            LbOptiDef.TabIndex = 46;
            LbOptiDef.Text = "optimal defaults";
            // 
            // CbMenuMusic
            // 
            CbMenuMusic.AutoSize = true;
            CbMenuMusic.Location = new Point(180, 350);
            CbMenuMusic.Name = "CbMenuMusic";
            CbMenuMusic.Size = new Size(15, 14);
            CbMenuMusic.TabIndex = 49;
            CbMenuMusic.UseVisualStyleBackColor = true;
            // 
            // LbMenuMusic
            // 
            LbMenuMusic.AutoSize = true;
            LbMenuMusic.Location = new Point(14, 348);
            LbMenuMusic.Margin = new Padding(8, 12, 8, 0);
            LbMenuMusic.Name = "LbMenuMusic";
            LbMenuMusic.Size = new Size(103, 15);
            LbMenuMusic.TabIndex = 48;
            LbMenuMusic.Text = "main menu music";
            // 
            // CbBackPlay
            // 
            CbBackPlay.AutoSize = true;
            CbBackPlay.Location = new Point(180, 377);
            CbBackPlay.Name = "CbBackPlay";
            CbBackPlay.Size = new Size(15, 14);
            CbBackPlay.TabIndex = 51;
            CbBackPlay.UseVisualStyleBackColor = true;
            // 
            // LbBackPlay
            // 
            LbBackPlay.AutoSize = true;
            LbBackPlay.Location = new Point(14, 375);
            LbBackPlay.Margin = new Padding(8, 12, 8, 0);
            LbBackPlay.Name = "LbBackPlay";
            LbBackPlay.Size = new Size(121, 15);
            LbBackPlay.TabIndex = 50;
            LbBackPlay.Text = "background playback";
            // 
            // CbMultiInst
            // 
            CbMultiInst.AutoSize = true;
            CbMultiInst.Location = new Point(180, 404);
            CbMultiInst.Name = "CbMultiInst";
            CbMultiInst.Size = new Size(15, 14);
            CbMultiInst.TabIndex = 53;
            CbMultiInst.UseVisualStyleBackColor = true;
            // 
            // LbMultiInst
            // 
            LbMultiInst.AutoSize = true;
            LbMultiInst.Location = new Point(14, 402);
            LbMultiInst.Margin = new Padding(8, 12, 8, 0);
            LbMultiInst.Name = "LbMultiInst";
            LbMultiInst.Size = new Size(103, 15);
            LbMultiInst.TabIndex = 52;
            LbMultiInst.Text = "multiple instances";
            // 
            // CbHash
            // 
            CbHash.AutoSize = true;
            CbHash.Location = new Point(180, 431);
            CbHash.Name = "CbHash";
            CbHash.Size = new Size(15, 14);
            CbHash.TabIndex = 56;
            CbHash.UseVisualStyleBackColor = true;
            // 
            // TbxHash
            // 
            TbxHash.Location = new Point(201, 426);
            TbxHash.Margin = new Padding(3, 3, 10, 3);
            TbxHash.Name = "TbxHash";
            TbxHash.Size = new Size(313, 23);
            TbxHash.TabIndex = 55;
            // 
            // LbHash
            // 
            LbHash.AutoSize = true;
            LbHash.Location = new Point(14, 429);
            LbHash.Margin = new Padding(8, 12, 8, 0);
            LbHash.Name = "LbHash";
            LbHash.Size = new Size(32, 15);
            LbHash.TabIndex = 54;
            LbHash.Text = "hash";
            // 
            // PnlErrorHand
            // 
            PnlErrorHand.BackColor = SystemColors.ControlLight;
            PnlErrorHand.BorderStyle = BorderStyle.Fixed3D;
            PnlErrorHand.Controls.Add(LbErrorHandDesc);
            PnlErrorHand.Controls.Add(LbErrorHand);
            PnlErrorHand.Location = new Point(8, 482);
            PnlErrorHand.Margin = new Padding(3, 38, 3, 3);
            PnlErrorHand.Name = "PnlErrorHand";
            PnlErrorHand.Size = new Size(543, 63);
            PnlErrorHand.TabIndex = 2;
            // 
            // LbErrorHandDesc
            // 
            LbErrorHandDesc.AutoSize = true;
            LbErrorHandDesc.Location = new Point(4, 24);
            LbErrorHandDesc.Name = "LbErrorHandDesc";
            LbErrorHandDesc.Size = new Size(214, 30);
            LbErrorHandDesc.TabIndex = 1;
            LbErrorHandDesc.Text = "error handling settings.\r\nthis is used to configure error handling.";
            // 
            // LbErrorHand
            // 
            LbErrorHand.AutoSize = true;
            LbErrorHand.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbErrorHand.Location = new Point(4, 5);
            LbErrorHand.Name = "LbErrorHand";
            LbErrorHand.Size = new Size(98, 19);
            LbErrorHand.TabIndex = 0;
            LbErrorHand.Text = "error handling";
            // 
            // CbShowSeg
            // 
            CbShowSeg.AutoSize = true;
            CbShowSeg.Location = new Point(180, 585);
            CbShowSeg.Name = "CbShowSeg";
            CbShowSeg.Size = new Size(15, 14);
            CbShowSeg.TabIndex = 60;
            CbShowSeg.UseVisualStyleBackColor = true;
            // 
            // LbShowSeg
            // 
            LbShowSeg.AutoSize = true;
            LbShowSeg.Location = new Point(14, 583);
            LbShowSeg.Margin = new Padding(8, 12, 8, 0);
            LbShowSeg.Name = "LbShowSeg";
            LbShowSeg.Size = new Size(138, 15);
            LbShowSeg.TabIndex = 59;
            LbShowSeg.Text = "show segmentation fault";
            // 
            // CbSupFatal
            // 
            CbSupFatal.AutoSize = true;
            CbSupFatal.Location = new Point(180, 558);
            CbSupFatal.Name = "CbSupFatal";
            CbSupFatal.Size = new Size(15, 14);
            CbSupFatal.TabIndex = 58;
            CbSupFatal.UseVisualStyleBackColor = true;
            // 
            // LbSupFatal
            // 
            LbSupFatal.AutoSize = true;
            LbSupFatal.Location = new Point(14, 556);
            LbSupFatal.Margin = new Padding(8, 8, 8, 0);
            LbSupFatal.Name = "LbSupFatal";
            LbSupFatal.Size = new Size(107, 15);
            LbSupFatal.TabIndex = 57;
            LbSupFatal.Text = "suppres fatal errors";
            // 
            // PnlVideoMode
            // 
            PnlVideoMode.BackColor = SystemColors.ControlLight;
            PnlVideoMode.BorderStyle = BorderStyle.Fixed3D;
            PnlVideoMode.Controls.Add(LbVideoModeDesc);
            PnlVideoMode.Controls.Add(LbVideoMode);
            PnlVideoMode.Location = new Point(8, 636);
            PnlVideoMode.Margin = new Padding(3, 38, 3, 3);
            PnlVideoMode.Name = "PnlVideoMode";
            PnlVideoMode.Size = new Size(543, 63);
            PnlVideoMode.TabIndex = 3;
            // 
            // LbVideoModeDesc
            // 
            LbVideoModeDesc.AutoSize = true;
            LbVideoModeDesc.Location = new Point(4, 24);
            LbVideoModeDesc.Name = "LbVideoModeDesc";
            LbVideoModeDesc.Size = new Size(246, 30);
            LbVideoModeDesc.TabIndex = 1;
            LbVideoModeDesc.Text = "video mode settings.\r\nthis is used to configure video mode settings.";
            // 
            // LbVideoMode
            // 
            LbVideoMode.AutoSize = true;
            LbVideoMode.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbVideoMode.Location = new Point(4, 5);
            LbVideoMode.Name = "LbVideoMode";
            LbVideoMode.Size = new Size(82, 19);
            LbVideoMode.TabIndex = 0;
            LbVideoMode.Text = "video mode";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(36, 4777);
            panel2.Margin = new Padding(3, 38, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 63);
            panel2.TabIndex = 4;
            // 
            // CbEnblVideoMode
            // 
            CbEnblVideoMode.AutoSize = true;
            CbEnblVideoMode.Location = new Point(180, 712);
            CbEnblVideoMode.Name = "CbEnblVideoMode";
            CbEnblVideoMode.Size = new Size(15, 14);
            CbEnblVideoMode.TabIndex = 62;
            CbEnblVideoMode.UseVisualStyleBackColor = true;
            // 
            // LbEnblVideoMode
            // 
            LbEnblVideoMode.AutoSize = true;
            LbEnblVideoMode.Location = new Point(14, 710);
            LbEnblVideoMode.Margin = new Padding(8, 8, 8, 0);
            LbEnblVideoMode.Name = "LbEnblVideoMode";
            LbEnblVideoMode.Size = new Size(49, 15);
            LbEnblVideoMode.TabIndex = 61;
            LbEnblVideoMode.Text = "enabled";
            // 
            // LbResHeight
            // 
            LbResHeight.AutoSize = true;
            LbResHeight.Location = new Point(333, 764);
            LbResHeight.Margin = new Padding(4, 12, 8, 0);
            LbResHeight.Name = "LbResHeight";
            LbResHeight.Size = new Size(41, 15);
            LbResHeight.TabIndex = 68;
            LbResHeight.Text = "height";
            // 
            // LbResWidth
            // 
            LbResWidth.AutoSize = true;
            LbResWidth.Location = new Point(333, 737);
            LbResWidth.Margin = new Padding(4, 12, 8, 0);
            LbResWidth.Name = "LbResWidth";
            LbResWidth.Size = new Size(37, 15);
            LbResWidth.TabIndex = 67;
            LbResWidth.Text = "width";
            // 
            // TbxResHeight
            // 
            TbxResHeight.Location = new Point(201, 761);
            TbxResHeight.Margin = new Padding(3, 3, 10, 3);
            TbxResHeight.Name = "TbxResHeight";
            TbxResHeight.Size = new Size(118, 23);
            TbxResHeight.TabIndex = 66;
            // 
            // CbResolution
            // 
            CbResolution.AutoSize = true;
            CbResolution.Location = new Point(180, 739);
            CbResolution.Name = "CbResolution";
            CbResolution.Size = new Size(15, 14);
            CbResolution.TabIndex = 65;
            CbResolution.UseVisualStyleBackColor = true;
            // 
            // TbxResWidth
            // 
            TbxResWidth.Location = new Point(201, 734);
            TbxResWidth.Margin = new Padding(3, 3, 10, 3);
            TbxResWidth.Name = "TbxResWidth";
            TbxResWidth.Size = new Size(118, 23);
            TbxResWidth.TabIndex = 64;
            // 
            // LbResolution
            // 
            LbResolution.AutoSize = true;
            LbResolution.Location = new Point(14, 737);
            LbResolution.Margin = new Padding(8, 12, 8, 0);
            LbResolution.Name = "LbResolution";
            LbResolution.Size = new Size(60, 15);
            LbResolution.TabIndex = 63;
            LbResolution.Text = "resolution";
            // 
            // CbRefRate
            // 
            CbRefRate.AutoSize = true;
            CbRefRate.Location = new Point(180, 793);
            CbRefRate.Name = "CbRefRate";
            CbRefRate.Size = new Size(15, 14);
            CbRefRate.TabIndex = 74;
            CbRefRate.UseVisualStyleBackColor = true;
            // 
            // TbxRefRate
            // 
            TbxRefRate.Location = new Point(201, 788);
            TbxRefRate.Margin = new Padding(3, 3, 10, 3);
            TbxRefRate.Name = "TbxRefRate";
            TbxRefRate.Size = new Size(118, 23);
            TbxRefRate.TabIndex = 73;
            // 
            // LbRefRate
            // 
            LbRefRate.AutoSize = true;
            LbRefRate.Location = new Point(14, 791);
            LbRefRate.Margin = new Padding(8, 12, 8, 0);
            LbRefRate.Name = "LbRefRate";
            LbRefRate.Size = new Size(66, 15);
            LbRefRate.TabIndex = 72;
            LbRefRate.Text = "refresh rate";
            // 
            // CbVsync
            // 
            CbVsync.AutoSize = true;
            CbVsync.Location = new Point(180, 820);
            CbVsync.Name = "CbVsync";
            CbVsync.Size = new Size(15, 14);
            CbVsync.TabIndex = 77;
            CbVsync.UseVisualStyleBackColor = true;
            // 
            // TbxVsync
            // 
            TbxVsync.Location = new Point(201, 815);
            TbxVsync.Margin = new Padding(3, 3, 10, 3);
            TbxVsync.Name = "TbxVsync";
            TbxVsync.Size = new Size(118, 23);
            TbxVsync.TabIndex = 76;
            // 
            // LbVsync
            // 
            LbVsync.AutoSize = true;
            LbVsync.Location = new Point(14, 818);
            LbVsync.Margin = new Padding(8, 12, 8, 0);
            LbVsync.Name = "LbVsync";
            LbVsync.Size = new Size(38, 15);
            LbVsync.TabIndex = 75;
            LbVsync.Text = "vSync";
            // 
            // CbWindowed
            // 
            CbWindowed.AutoSize = true;
            CbWindowed.Location = new Point(180, 847);
            CbWindowed.Name = "CbWindowed";
            CbWindowed.Size = new Size(15, 14);
            CbWindowed.TabIndex = 79;
            CbWindowed.UseVisualStyleBackColor = true;
            // 
            // LbWindowed
            // 
            LbWindowed.AutoSize = true;
            LbWindowed.Location = new Point(14, 845);
            LbWindowed.Margin = new Padding(8, 12, 8, 0);
            LbWindowed.Name = "LbWindowed";
            LbWindowed.Size = new Size(62, 15);
            LbWindowed.TabIndex = 78;
            LbWindowed.Text = "windowed";
            // 
            // CbBorderless
            // 
            CbBorderless.AutoSize = true;
            CbBorderless.Location = new Point(180, 874);
            CbBorderless.Name = "CbBorderless";
            CbBorderless.Size = new Size(15, 14);
            CbBorderless.TabIndex = 81;
            CbBorderless.UseVisualStyleBackColor = true;
            // 
            // LbBorderless
            // 
            LbBorderless.AutoSize = true;
            LbBorderless.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LbBorderless.Location = new Point(14, 872);
            LbBorderless.Margin = new Padding(8, 12, 8, 0);
            LbBorderless.Name = "LbBorderless";
            LbBorderless.Size = new Size(61, 15);
            LbBorderless.TabIndex = 80;
            LbBorderless.Text = "borderless";
            // 
            // PnlScoreboard
            // 
            PnlScoreboard.BackColor = SystemColors.ControlLight;
            PnlScoreboard.BorderStyle = BorderStyle.Fixed3D;
            PnlScoreboard.Controls.Add(LbScoreboardDesc);
            PnlScoreboard.Controls.Add(LbScoreboard);
            PnlScoreboard.Location = new Point(8, 925);
            PnlScoreboard.Margin = new Padding(3, 38, 3, 3);
            PnlScoreboard.Name = "PnlScoreboard";
            PnlScoreboard.Size = new Size(543, 63);
            PnlScoreboard.TabIndex = 4;
            // 
            // LbScoreboardDesc
            // 
            LbScoreboardDesc.AutoSize = true;
            LbScoreboardDesc.Location = new Point(4, 24);
            LbScoreboardDesc.Name = "LbScoreboardDesc";
            LbScoreboardDesc.Size = new Size(221, 30);
            LbScoreboardDesc.TabIndex = 1;
            LbScoreboardDesc.Text = "scoreboard settings.\r\nthis is used to customize the scoreboard.";
            // 
            // LbScoreboard
            // 
            LbScoreboard.AutoSize = true;
            LbScoreboard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbScoreboard.Location = new Point(4, 5);
            LbScoreboard.Name = "LbScoreboard";
            LbScoreboard.Size = new Size(78, 19);
            LbScoreboard.TabIndex = 0;
            LbScoreboard.Text = "scoreboard";
            // 
            // LbScoreboardFont
            // 
            LbScoreboardFont.AutoSize = true;
            LbScoreboardFont.Location = new Point(14, 999);
            LbScoreboardFont.Margin = new Padding(8, 8, 8, 0);
            LbScoreboardFont.Name = "LbScoreboardFont";
            LbScoreboardFont.Size = new Size(29, 15);
            LbScoreboardFont.TabIndex = 82;
            LbScoreboardFont.Text = "font";
            // 
            // TbxScoreboardFade
            // 
            TbxScoreboardFade.Location = new Point(201, 1023);
            TbxScoreboardFade.Margin = new Padding(3, 3, 10, 3);
            TbxScoreboardFade.Name = "TbxScoreboardFade";
            TbxScoreboardFade.Size = new Size(118, 23);
            TbxScoreboardFade.TabIndex = 86;
            // 
            // LbScoreboardFade
            // 
            LbScoreboardFade.AutoSize = true;
            LbScoreboardFade.Location = new Point(14, 1026);
            LbScoreboardFade.Margin = new Padding(8, 12, 8, 0);
            LbScoreboardFade.Name = "LbScoreboardFade";
            LbScoreboardFade.Size = new Size(57, 15);
            LbScoreboardFade.TabIndex = 85;
            LbScoreboardFade.Text = "fade time";
            // 
            // PnlNameSet
            // 
            PnlNameSet.BackColor = SystemColors.ControlLight;
            PnlNameSet.BorderStyle = BorderStyle.Fixed3D;
            PnlNameSet.Controls.Add(LbNameSetDesc);
            PnlNameSet.Controls.Add(LbNameSet);
            PnlNameSet.Location = new Point(8, 1079);
            PnlNameSet.Margin = new Padding(3, 38, 3, 3);
            PnlNameSet.Name = "PnlNameSet";
            PnlNameSet.Size = new Size(543, 63);
            PnlNameSet.TabIndex = 5;
            // 
            // LbNameSetDesc
            // 
            LbNameSetDesc.AutoSize = true;
            LbNameSetDesc.Location = new Point(4, 24);
            LbNameSetDesc.Name = "LbNameSetDesc";
            LbNameSetDesc.Size = new Size(358, 30);
            LbNameSetDesc.TabIndex = 1;
            LbNameSetDesc.Text = "name settings.\r\nthis is used to customize names displayed when looking at players.";
            // 
            // LbNameSet
            // 
            LbNameSet.AutoSize = true;
            LbNameSet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbNameSet.Location = new Point(4, 5);
            LbNameSet.Name = "LbNameSet";
            LbNameSet.Size = new Size(43, 19);
            LbNameSet.TabIndex = 0;
            LbNameSet.Text = "name";
            // 
            // LbNameFont
            // 
            LbNameFont.AutoSize = true;
            LbNameFont.Location = new Point(14, 1153);
            LbNameFont.Margin = new Padding(8, 8, 8, 0);
            LbNameFont.Name = "LbNameFont";
            LbNameFont.Size = new Size(29, 15);
            LbNameFont.TabIndex = 87;
            LbNameFont.Text = "font";
            // 
            // ComBoxScoreboardFont
            // 
            ComBoxScoreboardFont.BackColor = SystemColors.ControlLight;
            ComBoxScoreboardFont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxScoreboardFont.FormattingEnabled = true;
            ComBoxScoreboardFont.Items.AddRange(new object[] { "smaller", "small", "large", "console", "system" });
            ComBoxScoreboardFont.Location = new Point(201, 996);
            ComBoxScoreboardFont.Name = "ComBoxScoreboardFont";
            ComBoxScoreboardFont.Size = new Size(118, 23);
            ComBoxScoreboardFont.TabIndex = 89;
            // 
            // ComBoxNameFont
            // 
            ComBoxNameFont.BackColor = SystemColors.ControlLight;
            ComBoxNameFont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxNameFont.FormattingEnabled = true;
            ComBoxNameFont.Items.AddRange(new object[] { "smaller", "small", "large", "console", "system" });
            ComBoxNameFont.Location = new Point(201, 1150);
            ComBoxNameFont.Name = "ComBoxNameFont";
            ComBoxNameFont.Size = new Size(118, 23);
            ComBoxNameFont.TabIndex = 90;
            // 
            // PnlServerList
            // 
            PnlServerList.BackColor = SystemColors.ControlLight;
            PnlServerList.BorderStyle = BorderStyle.Fixed3D;
            PnlServerList.Controls.Add(LbServerListDesc);
            PnlServerList.Controls.Add(LbServerList);
            PnlServerList.Location = new Point(8, 1206);
            PnlServerList.Margin = new Padding(3, 38, 3, 3);
            PnlServerList.Name = "PnlServerList";
            PnlServerList.Size = new Size(543, 63);
            PnlServerList.TabIndex = 6;
            // 
            // LbServerListDesc
            // 
            LbServerListDesc.AutoSize = true;
            LbServerListDesc.Location = new Point(4, 24);
            LbServerListDesc.Name = "LbServerListDesc";
            LbServerListDesc.Size = new Size(268, 30);
            LbServerListDesc.TabIndex = 1;
            LbServerListDesc.Text = "server list settings.\r\nthis is used to configure how the server list works.";
            // 
            // LbServerList
            // 
            LbServerList.AutoSize = true;
            LbServerList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbServerList.Location = new Point(4, 5);
            LbServerList.Name = "LbServerList";
            LbServerList.Size = new Size(70, 19);
            LbServerList.TabIndex = 0;
            LbServerList.Text = "server list";
            // 
            // CbAutoQuery
            // 
            CbAutoQuery.AutoSize = true;
            CbAutoQuery.Location = new Point(180, 1282);
            CbAutoQuery.Name = "CbAutoQuery";
            CbAutoQuery.Size = new Size(15, 14);
            CbAutoQuery.TabIndex = 92;
            CbAutoQuery.UseVisualStyleBackColor = true;
            // 
            // LbAutoQuery
            // 
            LbAutoQuery.AutoSize = true;
            LbAutoQuery.Location = new Point(14, 1280);
            LbAutoQuery.Margin = new Padding(8, 8, 8, 0);
            LbAutoQuery.Name = "LbAutoQuery";
            LbAutoQuery.Size = new Size(64, 15);
            LbAutoQuery.TabIndex = 91;
            LbAutoQuery.Text = "auto query";
            // 
            // CbMstrSvList
            // 
            CbMstrSvList.AutoSize = true;
            CbMstrSvList.Location = new Point(180, 1309);
            CbMstrSvList.Name = "CbMstrSvList";
            CbMstrSvList.Size = new Size(15, 14);
            CbMstrSvList.TabIndex = 95;
            CbMstrSvList.UseVisualStyleBackColor = true;
            // 
            // TbxMstrSvList
            // 
            TbxMstrSvList.Location = new Point(201, 1304);
            TbxMstrSvList.Margin = new Padding(3, 3, 10, 3);
            TbxMstrSvList.Name = "TbxMstrSvList";
            TbxMstrSvList.Size = new Size(313, 23);
            TbxMstrSvList.TabIndex = 94;
            // 
            // LbMstrSvList
            // 
            LbMstrSvList.AutoSize = true;
            LbMstrSvList.Location = new Point(14, 1307);
            LbMstrSvList.Margin = new Padding(8, 12, 8, 0);
            LbMstrSvList.Name = "LbMstrSvList";
            LbMstrSvList.Size = new Size(95, 15);
            LbMstrSvList.TabIndex = 93;
            LbMstrSvList.Text = "master server list";
            // 
            // CbMstrSvKey
            // 
            CbMstrSvKey.AutoSize = true;
            CbMstrSvKey.Location = new Point(180, 1336);
            CbMstrSvKey.Name = "CbMstrSvKey";
            CbMstrSvKey.Size = new Size(15, 14);
            CbMstrSvKey.TabIndex = 98;
            CbMstrSvKey.UseVisualStyleBackColor = true;
            // 
            // TbxMstrSvKey
            // 
            TbxMstrSvKey.Location = new Point(201, 1331);
            TbxMstrSvKey.Margin = new Padding(3, 3, 10, 3);
            TbxMstrSvKey.Name = "TbxMstrSvKey";
            TbxMstrSvKey.Size = new Size(313, 23);
            TbxMstrSvKey.TabIndex = 97;
            // 
            // LbMstrSvKey
            // 
            LbMstrSvKey.AutoSize = true;
            LbMstrSvKey.Location = new Point(14, 1334);
            LbMstrSvKey.Margin = new Padding(8, 12, 8, 0);
            LbMstrSvKey.Name = "LbMstrSvKey";
            LbMstrSvKey.Size = new Size(98, 15);
            LbMstrSvKey.TabIndex = 96;
            LbMstrSvKey.Text = "master server key";
            // 
            // CbMstrSvNatP
            // 
            CbMstrSvNatP.AutoSize = true;
            CbMstrSvNatP.Location = new Point(180, 1363);
            CbMstrSvNatP.Name = "CbMstrSvNatP";
            CbMstrSvNatP.Size = new Size(15, 14);
            CbMstrSvNatP.TabIndex = 101;
            CbMstrSvNatP.UseVisualStyleBackColor = true;
            // 
            // TbxMstrSvNatP
            // 
            TbxMstrSvNatP.Location = new Point(201, 1358);
            TbxMstrSvNatP.Margin = new Padding(3, 3, 10, 3);
            TbxMstrSvNatP.Name = "TbxMstrSvNatP";
            TbxMstrSvNatP.Size = new Size(313, 23);
            TbxMstrSvNatP.TabIndex = 100;
            // 
            // LbMstrSvNatP
            // 
            LbMstrSvNatP.AutoSize = true;
            LbMstrSvNatP.Location = new Point(14, 1361);
            LbMstrSvNatP.Margin = new Padding(8, 12, 8, 0);
            LbMstrSvNatP.Name = "LbMstrSvNatP";
            LbMstrSvNatP.Size = new Size(141, 15);
            LbMstrSvNatP.TabIndex = 99;
            LbMstrSvNatP.Text = "master server nat primary";
            // 
            // CbMstrSvNatS
            // 
            CbMstrSvNatS.AutoSize = true;
            CbMstrSvNatS.Location = new Point(180, 1390);
            CbMstrSvNatS.Name = "CbMstrSvNatS";
            CbMstrSvNatS.Size = new Size(15, 14);
            CbMstrSvNatS.TabIndex = 104;
            CbMstrSvNatS.UseVisualStyleBackColor = true;
            // 
            // TbxMstrSvNatS
            // 
            TbxMstrSvNatS.Location = new Point(201, 1385);
            TbxMstrSvNatS.Margin = new Padding(3, 3, 10, 3);
            TbxMstrSvNatS.Name = "TbxMstrSvNatS";
            TbxMstrSvNatS.Size = new Size(313, 23);
            TbxMstrSvNatS.TabIndex = 103;
            // 
            // LbMstrSvNatS
            // 
            LbMstrSvNatS.AutoSize = true;
            LbMstrSvNatS.Location = new Point(14, 1388);
            LbMstrSvNatS.Margin = new Padding(8, 12, 8, 0);
            LbMstrSvNatS.Name = "LbMstrSvNatS";
            LbMstrSvNatS.Size = new Size(154, 15);
            LbMstrSvNatS.TabIndex = 102;
            LbMstrSvNatS.Text = "master server nat secondary";
            // 
            // PnlMemory
            // 
            PnlMemory.BackColor = SystemColors.ControlLight;
            PnlMemory.BorderStyle = BorderStyle.Fixed3D;
            PnlMemory.Controls.Add(LbMemoryDesc);
            PnlMemory.Controls.Add(LbMemory);
            PnlMemory.Location = new Point(8, 1441);
            PnlMemory.Margin = new Padding(3, 38, 3, 3);
            PnlMemory.Name = "PnlMemory";
            PnlMemory.Size = new Size(543, 78);
            PnlMemory.TabIndex = 7;
            // 
            // LbMemoryDesc
            // 
            LbMemoryDesc.AutoSize = true;
            LbMemoryDesc.Location = new Point(4, 24);
            LbMemoryDesc.Name = "LbMemoryDesc";
            LbMemoryDesc.Size = new Size(395, 45);
            LbMemoryDesc.TabIndex = 1;
            LbMemoryDesc.Text = "map memory settings.\r\nthis is used to configure how to handle how maps are loaded by Chimera.\r\nthis feature does not work if haloce.exe is not LAA patched.";
            // 
            // LbMemory
            // 
            LbMemory.AutoSize = true;
            LbMemory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbMemory.Location = new Point(4, 5);
            LbMemory.Name = "LbMemory";
            LbMemory.Size = new Size(61, 19);
            LbMemory.TabIndex = 0;
            LbMemory.Text = "memory";
            // 
            // CbMapSize
            // 
            CbMapSize.AutoSize = true;
            CbMapSize.Location = new Point(180, 1559);
            CbMapSize.Name = "CbMapSize";
            CbMapSize.Size = new Size(15, 14);
            CbMapSize.TabIndex = 109;
            CbMapSize.UseVisualStyleBackColor = true;
            // 
            // TbxMapSize
            // 
            TbxMapSize.Location = new Point(201, 1554);
            TbxMapSize.Margin = new Padding(3, 3, 10, 3);
            TbxMapSize.Name = "TbxMapSize";
            TbxMapSize.Size = new Size(118, 23);
            TbxMapSize.TabIndex = 108;
            // 
            // LbMapSize
            // 
            LbMapSize.AutoSize = true;
            LbMapSize.Location = new Point(14, 1557);
            LbMapSize.Margin = new Padding(8, 12, 8, 0);
            LbMapSize.Name = "LbMapSize";
            LbMapSize.Size = new Size(53, 15);
            LbMapSize.TabIndex = 107;
            LbMapSize.Text = "map size";
            // 
            // CbMapMmryBuffer
            // 
            CbMapMmryBuffer.AutoSize = true;
            CbMapMmryBuffer.Location = new Point(180, 1532);
            CbMapMmryBuffer.Name = "CbMapMmryBuffer";
            CbMapMmryBuffer.Size = new Size(15, 14);
            CbMapMmryBuffer.TabIndex = 106;
            CbMapMmryBuffer.UseVisualStyleBackColor = true;
            // 
            // LbMapMmryBuffer
            // 
            LbMapMmryBuffer.AutoSize = true;
            LbMapMmryBuffer.Location = new Point(14, 1530);
            LbMapMmryBuffer.Margin = new Padding(8, 8, 8, 0);
            LbMapMmryBuffer.Name = "LbMapMmryBuffer";
            LbMapMmryBuffer.Size = new Size(159, 15);
            LbMapMmryBuffer.TabIndex = 105;
            LbMapMmryBuffer.Text = "enabled map memory buffer";
            // 
            // CbBenchmark
            // 
            CbBenchmark.AutoSize = true;
            CbBenchmark.Location = new Point(180, 1586);
            CbBenchmark.Name = "CbBenchmark";
            CbBenchmark.Size = new Size(15, 14);
            CbBenchmark.TabIndex = 111;
            CbBenchmark.UseVisualStyleBackColor = true;
            // 
            // LbBenchmark
            // 
            LbBenchmark.AutoSize = true;
            LbBenchmark.Location = new Point(14, 1584);
            LbBenchmark.Margin = new Padding(8, 12, 8, 0);
            LbBenchmark.Name = "LbBenchmark";
            LbBenchmark.Size = new Size(67, 15);
            LbBenchmark.TabIndex = 110;
            LbBenchmark.Text = "benchmark";
            // 
            // ComBoxDownloadFont
            // 
            ComBoxDownloadFont.BackColor = SystemColors.ControlLight;
            ComBoxDownloadFont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxDownloadFont.FormattingEnabled = true;
            ComBoxDownloadFont.Items.AddRange(new object[] { "smaller", "small", "large", "console", "system" });
            ComBoxDownloadFont.Location = new Point(201, 1608);
            ComBoxDownloadFont.Name = "ComBoxDownloadFont";
            ComBoxDownloadFont.Size = new Size(118, 23);
            ComBoxDownloadFont.TabIndex = 114;
            // 
            // LbDownloadFont
            // 
            LbDownloadFont.AutoSize = true;
            LbDownloadFont.Location = new Point(14, 1611);
            LbDownloadFont.Margin = new Padding(8, 12, 8, 0);
            LbDownloadFont.Name = "LbDownloadFont";
            LbDownloadFont.Size = new Size(85, 15);
            LbDownloadFont.TabIndex = 112;
            LbDownloadFont.Text = "download font";
            // 
            // TbxDownloadUrl
            // 
            TbxDownloadUrl.Location = new Point(201, 1635);
            TbxDownloadUrl.Margin = new Padding(3, 3, 10, 3);
            TbxDownloadUrl.Name = "TbxDownloadUrl";
            TbxDownloadUrl.Size = new Size(313, 23);
            TbxDownloadUrl.TabIndex = 116;
            // 
            // LbDownloadUrl
            // 
            LbDownloadUrl.AutoSize = true;
            LbDownloadUrl.Location = new Point(14, 1638);
            LbDownloadUrl.Margin = new Padding(8, 12, 8, 0);
            LbDownloadUrl.Name = "LbDownloadUrl";
            LbDownloadUrl.Size = new Size(84, 15);
            LbDownloadUrl.TabIndex = 115;
            LbDownloadUrl.Text = "download URL";
            // 
            // CbDownloadRetail
            // 
            CbDownloadRetail.AutoSize = true;
            CbDownloadRetail.Location = new Point(180, 1667);
            CbDownloadRetail.Name = "CbDownloadRetail";
            CbDownloadRetail.Size = new Size(15, 14);
            CbDownloadRetail.TabIndex = 118;
            CbDownloadRetail.UseVisualStyleBackColor = true;
            // 
            // LbDownloadRetail
            // 
            LbDownloadRetail.AutoSize = true;
            LbDownloadRetail.Location = new Point(14, 1665);
            LbDownloadRetail.Margin = new Padding(8, 12, 8, 0);
            LbDownloadRetail.Name = "LbDownloadRetail";
            LbDownloadRetail.Size = new Size(121, 15);
            LbDownloadRetail.TabIndex = 117;
            LbDownloadRetail.Text = "download retail maps";
            // 
            // PnlFontOver
            // 
            PnlFontOver.BackColor = SystemColors.ControlLight;
            PnlFontOver.BorderStyle = BorderStyle.Fixed3D;
            PnlFontOver.Controls.Add(LbFontOverDesc);
            PnlFontOver.Controls.Add(LbFontOver);
            PnlFontOver.Location = new Point(8, 1718);
            PnlFontOver.Margin = new Padding(3, 38, 3, 3);
            PnlFontOver.Name = "PnlFontOver";
            PnlFontOver.Size = new Size(543, 78);
            PnlFontOver.TabIndex = 8;
            // 
            // LbFontOverDesc
            // 
            LbFontOverDesc.AutoSize = true;
            LbFontOverDesc.Location = new Point(4, 24);
            LbFontOverDesc.Name = "LbFontOverDesc";
            LbFontOverDesc.Size = new Size(298, 45);
            LbFontOverDesc.TabIndex = 1;
            LbFontOverDesc.Text = "font override settings.\r\noverride the fonts used by Chimera with system fonts.\r\nenabling this will also force the widescreen fix to be on.";
            // 
            // LbFontOver
            // 
            LbFontOver.AutoSize = true;
            LbFontOver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbFontOver.Location = new Point(4, 5);
            LbFontOver.Name = "LbFontOver";
            LbFontOver.Size = new Size(90, 19);
            LbFontOver.TabIndex = 0;
            LbFontOver.Text = "font override";
            // 
            // CbFontOverEnabled
            // 
            CbFontOverEnabled.AutoSize = true;
            CbFontOverEnabled.Location = new Point(180, 1809);
            CbFontOverEnabled.Name = "CbFontOverEnabled";
            CbFontOverEnabled.Size = new Size(15, 14);
            CbFontOverEnabled.TabIndex = 120;
            CbFontOverEnabled.UseVisualStyleBackColor = true;
            // 
            // LbFontOverEnabled
            // 
            LbFontOverEnabled.AutoSize = true;
            LbFontOverEnabled.Location = new Point(14, 1807);
            LbFontOverEnabled.Margin = new Padding(8, 8, 8, 0);
            LbFontOverEnabled.Name = "LbFontOverEnabled";
            LbFontOverEnabled.Size = new Size(49, 15);
            LbFontOverEnabled.TabIndex = 119;
            LbFontOverEnabled.Text = "enabled";
            // 
            // LbSystemFW
            // 
            LbSystemFW.AutoSize = true;
            LbSystemFW.Location = new Point(333, 1861);
            LbSystemFW.Margin = new Padding(4, 12, 8, 0);
            LbSystemFW.Name = "LbSystemFW";
            LbSystemFW.Size = new Size(68, 15);
            LbSystemFW.TabIndex = 126;
            LbSystemFW.Text = "font weight";
            // 
            // LbSystemFF
            // 
            LbSystemFF.AutoSize = true;
            LbSystemFF.Location = new Point(333, 1834);
            LbSystemFF.Margin = new Padding(4, 12, 8, 0);
            LbSystemFF.Name = "LbSystemFF";
            LbSystemFF.Size = new Size(65, 15);
            LbSystemFF.TabIndex = 125;
            LbSystemFF.Text = "font family";
            // 
            // TbxSystemFW
            // 
            TbxSystemFW.Location = new Point(201, 1858);
            TbxSystemFW.Margin = new Padding(3, 3, 10, 3);
            TbxSystemFW.Name = "TbxSystemFW";
            TbxSystemFW.Size = new Size(118, 23);
            TbxSystemFW.TabIndex = 124;
            // 
            // CbSystemFO
            // 
            CbSystemFO.AutoSize = true;
            CbSystemFO.Location = new Point(180, 1836);
            CbSystemFO.Name = "CbSystemFO";
            CbSystemFO.Size = new Size(15, 14);
            CbSystemFO.TabIndex = 123;
            CbSystemFO.UseVisualStyleBackColor = true;
            // 
            // TbxSystemFF
            // 
            TbxSystemFF.Location = new Point(201, 1831);
            TbxSystemFF.Margin = new Padding(3, 3, 10, 3);
            TbxSystemFF.Name = "TbxSystemFF";
            TbxSystemFF.Size = new Size(118, 23);
            TbxSystemFF.TabIndex = 122;
            // 
            // LbSystemFO
            // 
            LbSystemFO.AutoSize = true;
            LbSystemFO.Location = new Point(14, 1834);
            LbSystemFO.Margin = new Padding(8, 12, 8, 0);
            LbSystemFO.Name = "LbSystemFO";
            LbSystemFO.Size = new Size(115, 15);
            LbSystemFO.TabIndex = 121;
            LbSystemFO.Text = "system font override";
            // 
            // LbSystemFS
            // 
            LbSystemFS.AutoSize = true;
            LbSystemFS.Location = new Point(333, 1888);
            LbSystemFS.Margin = new Padding(4, 12, 8, 0);
            LbSystemFS.Name = "LbSystemFS";
            LbSystemFS.Size = new Size(51, 15);
            LbSystemFS.TabIndex = 128;
            LbSystemFS.Text = "font size";
            // 
            // TbxSystemFS
            // 
            TbxSystemFS.Location = new Point(201, 1885);
            TbxSystemFS.Margin = new Padding(3, 3, 10, 3);
            TbxSystemFS.Name = "TbxSystemFS";
            TbxSystemFS.Size = new Size(118, 23);
            TbxSystemFS.TabIndex = 127;
            // 
            // LbSystemXY
            // 
            LbSystemXY.AutoSize = true;
            LbSystemXY.Location = new Point(333, 1915);
            LbSystemXY.Margin = new Padding(4, 12, 8, 0);
            LbSystemXY.Name = "LbSystemXY";
            LbSystemXY.Size = new Size(57, 15);
            LbSystemXY.TabIndex = 130;
            LbSystemXY.Text = "xy offsets";
            // 
            // TbxSystemXO
            // 
            TbxSystemXO.Location = new Point(201, 1912);
            TbxSystemXO.Margin = new Padding(3, 3, 10, 3);
            TbxSystemXO.Name = "TbxSystemXO";
            TbxSystemXO.Size = new Size(50, 23);
            TbxSystemXO.TabIndex = 129;
            // 
            // TbxSystemSh
            // 
            TbxSystemSh.AutoSize = true;
            TbxSystemSh.Location = new Point(333, 1942);
            TbxSystemSh.Margin = new Padding(4, 12, 8, 0);
            TbxSystemSh.Name = "TbxSystemSh";
            TbxSystemSh.Size = new Size(81, 15);
            TbxSystemSh.TabIndex = 132;
            TbxSystemSh.Text = "shadow offset";
            // 
            // TbxSystemSX
            // 
            TbxSystemSX.Location = new Point(201, 1939);
            TbxSystemSX.Margin = new Padding(3, 3, 10, 3);
            TbxSystemSX.Name = "TbxSystemSX";
            TbxSystemSX.Size = new Size(50, 23);
            TbxSystemSX.TabIndex = 131;
            // 
            // TbxSystemSY
            // 
            TbxSystemSY.Location = new Point(269, 1939);
            TbxSystemSY.Margin = new Padding(3, 3, 10, 3);
            TbxSystemSY.Name = "TbxSystemSY";
            TbxSystemSY.Size = new Size(50, 23);
            TbxSystemSY.TabIndex = 134;
            // 
            // TbxSystemYO
            // 
            TbxSystemYO.Location = new Point(269, 1912);
            TbxSystemYO.Margin = new Padding(3, 3, 10, 3);
            TbxSystemYO.Name = "TbxSystemYO";
            TbxSystemYO.Size = new Size(50, 23);
            TbxSystemYO.TabIndex = 133;
            // 
            // TbxLargeSY
            // 
            TbxLargeSY.Location = new Point(269, 2074);
            TbxLargeSY.Margin = new Padding(3, 3, 10, 3);
            TbxLargeSY.Name = "TbxLargeSY";
            TbxLargeSY.Size = new Size(50, 23);
            TbxLargeSY.TabIndex = 148;
            // 
            // TbxLargeYO
            // 
            TbxLargeYO.Location = new Point(269, 2047);
            TbxLargeYO.Margin = new Padding(3, 3, 10, 3);
            TbxLargeYO.Name = "TbxLargeYO";
            TbxLargeYO.Size = new Size(50, 23);
            TbxLargeYO.TabIndex = 147;
            // 
            // LbLargeSh
            // 
            LbLargeSh.AutoSize = true;
            LbLargeSh.Location = new Point(333, 2077);
            LbLargeSh.Margin = new Padding(4, 12, 8, 0);
            LbLargeSh.Name = "LbLargeSh";
            LbLargeSh.Size = new Size(81, 15);
            LbLargeSh.TabIndex = 146;
            LbLargeSh.Text = "shadow offset";
            // 
            // TbxLargeSX
            // 
            TbxLargeSX.Location = new Point(201, 2074);
            TbxLargeSX.Margin = new Padding(3, 3, 10, 3);
            TbxLargeSX.Name = "TbxLargeSX";
            TbxLargeSX.Size = new Size(50, 23);
            TbxLargeSX.TabIndex = 145;
            // 
            // LbLargeXY
            // 
            LbLargeXY.AutoSize = true;
            LbLargeXY.Location = new Point(333, 2050);
            LbLargeXY.Margin = new Padding(4, 12, 8, 0);
            LbLargeXY.Name = "LbLargeXY";
            LbLargeXY.Size = new Size(57, 15);
            LbLargeXY.TabIndex = 144;
            LbLargeXY.Text = "xy offsets";
            // 
            // TbxLargeXO
            // 
            TbxLargeXO.Location = new Point(201, 2047);
            TbxLargeXO.Margin = new Padding(3, 3, 10, 3);
            TbxLargeXO.Name = "TbxLargeXO";
            TbxLargeXO.Size = new Size(50, 23);
            TbxLargeXO.TabIndex = 143;
            // 
            // LbLargeFS
            // 
            LbLargeFS.AutoSize = true;
            LbLargeFS.Location = new Point(333, 2023);
            LbLargeFS.Margin = new Padding(4, 12, 8, 0);
            LbLargeFS.Name = "LbLargeFS";
            LbLargeFS.Size = new Size(51, 15);
            LbLargeFS.TabIndex = 142;
            LbLargeFS.Text = "font size";
            // 
            // TbxLargeFS
            // 
            TbxLargeFS.Location = new Point(201, 2020);
            TbxLargeFS.Margin = new Padding(3, 3, 10, 3);
            TbxLargeFS.Name = "TbxLargeFS";
            TbxLargeFS.Size = new Size(118, 23);
            TbxLargeFS.TabIndex = 141;
            // 
            // LbLargeFW
            // 
            LbLargeFW.AutoSize = true;
            LbLargeFW.Location = new Point(333, 1996);
            LbLargeFW.Margin = new Padding(4, 12, 8, 0);
            LbLargeFW.Name = "LbLargeFW";
            LbLargeFW.Size = new Size(68, 15);
            LbLargeFW.TabIndex = 140;
            LbLargeFW.Text = "font weight";
            // 
            // LbLargeFF
            // 
            LbLargeFF.AutoSize = true;
            LbLargeFF.Location = new Point(333, 1969);
            LbLargeFF.Margin = new Padding(4, 12, 8, 0);
            LbLargeFF.Name = "LbLargeFF";
            LbLargeFF.Size = new Size(65, 15);
            LbLargeFF.TabIndex = 139;
            LbLargeFF.Text = "font family";
            // 
            // TbxLargeFW
            // 
            TbxLargeFW.Location = new Point(201, 1993);
            TbxLargeFW.Margin = new Padding(3, 3, 10, 3);
            TbxLargeFW.Name = "TbxLargeFW";
            TbxLargeFW.Size = new Size(118, 23);
            TbxLargeFW.TabIndex = 138;
            // 
            // CbLargeFO
            // 
            CbLargeFO.AutoSize = true;
            CbLargeFO.Location = new Point(180, 1971);
            CbLargeFO.Name = "CbLargeFO";
            CbLargeFO.Size = new Size(15, 14);
            CbLargeFO.TabIndex = 137;
            CbLargeFO.UseVisualStyleBackColor = true;
            // 
            // TbxLargeFF
            // 
            TbxLargeFF.Location = new Point(201, 1966);
            TbxLargeFF.Margin = new Padding(3, 3, 10, 3);
            TbxLargeFF.Name = "TbxLargeFF";
            TbxLargeFF.Size = new Size(118, 23);
            TbxLargeFF.TabIndex = 136;
            // 
            // LbLargeFO
            // 
            LbLargeFO.AutoSize = true;
            LbLargeFO.Location = new Point(14, 1969);
            LbLargeFO.Margin = new Padding(8, 12, 8, 0);
            LbLargeFO.Name = "LbLargeFO";
            LbLargeFO.Size = new Size(104, 15);
            LbLargeFO.TabIndex = 135;
            LbLargeFO.Text = "large font override";
            // 
            // TbxSmallSY
            // 
            TbxSmallSY.Location = new Point(269, 2209);
            TbxSmallSY.Margin = new Padding(3, 3, 10, 3);
            TbxSmallSY.Name = "TbxSmallSY";
            TbxSmallSY.Size = new Size(50, 23);
            TbxSmallSY.TabIndex = 162;
            // 
            // TbxSmallYO
            // 
            TbxSmallYO.Location = new Point(269, 2182);
            TbxSmallYO.Margin = new Padding(3, 3, 10, 3);
            TbxSmallYO.Name = "TbxSmallYO";
            TbxSmallYO.Size = new Size(50, 23);
            TbxSmallYO.TabIndex = 161;
            // 
            // LbSmallSh
            // 
            LbSmallSh.AutoSize = true;
            LbSmallSh.Location = new Point(333, 2212);
            LbSmallSh.Margin = new Padding(4, 12, 8, 0);
            LbSmallSh.Name = "LbSmallSh";
            LbSmallSh.Size = new Size(81, 15);
            LbSmallSh.TabIndex = 160;
            LbSmallSh.Text = "shadow offset";
            // 
            // TbxSmallSX
            // 
            TbxSmallSX.Location = new Point(201, 2209);
            TbxSmallSX.Margin = new Padding(3, 3, 10, 3);
            TbxSmallSX.Name = "TbxSmallSX";
            TbxSmallSX.Size = new Size(50, 23);
            TbxSmallSX.TabIndex = 159;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(333, 2185);
            label15.Margin = new Padding(4, 12, 8, 0);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 158;
            label15.Text = "xy offsets";
            // 
            // TbxSmallXO
            // 
            TbxSmallXO.Location = new Point(201, 2182);
            TbxSmallXO.Margin = new Padding(3, 3, 10, 3);
            TbxSmallXO.Name = "TbxSmallXO";
            TbxSmallXO.Size = new Size(50, 23);
            TbxSmallXO.TabIndex = 157;
            // 
            // LbSmallFS
            // 
            LbSmallFS.AutoSize = true;
            LbSmallFS.Location = new Point(333, 2158);
            LbSmallFS.Margin = new Padding(4, 12, 8, 0);
            LbSmallFS.Name = "LbSmallFS";
            LbSmallFS.Size = new Size(51, 15);
            LbSmallFS.TabIndex = 156;
            LbSmallFS.Text = "font size";
            // 
            // TbxSmallFS
            // 
            TbxSmallFS.Location = new Point(201, 2155);
            TbxSmallFS.Margin = new Padding(3, 3, 10, 3);
            TbxSmallFS.Name = "TbxSmallFS";
            TbxSmallFS.Size = new Size(118, 23);
            TbxSmallFS.TabIndex = 155;
            // 
            // LbSmallFW
            // 
            LbSmallFW.AutoSize = true;
            LbSmallFW.Location = new Point(333, 2131);
            LbSmallFW.Margin = new Padding(4, 12, 8, 0);
            LbSmallFW.Name = "LbSmallFW";
            LbSmallFW.Size = new Size(68, 15);
            LbSmallFW.TabIndex = 154;
            LbSmallFW.Text = "font weight";
            // 
            // LbSmallFF
            // 
            LbSmallFF.AutoSize = true;
            LbSmallFF.Location = new Point(333, 2104);
            LbSmallFF.Margin = new Padding(4, 12, 8, 0);
            LbSmallFF.Name = "LbSmallFF";
            LbSmallFF.Size = new Size(65, 15);
            LbSmallFF.TabIndex = 153;
            LbSmallFF.Text = "font family";
            // 
            // TbxSmallFW
            // 
            TbxSmallFW.Location = new Point(201, 2128);
            TbxSmallFW.Margin = new Padding(3, 3, 10, 3);
            TbxSmallFW.Name = "TbxSmallFW";
            TbxSmallFW.Size = new Size(118, 23);
            TbxSmallFW.TabIndex = 152;
            // 
            // CbSmallFO
            // 
            CbSmallFO.AutoSize = true;
            CbSmallFO.Location = new Point(180, 2106);
            CbSmallFO.Name = "CbSmallFO";
            CbSmallFO.Size = new Size(15, 14);
            CbSmallFO.TabIndex = 151;
            CbSmallFO.UseVisualStyleBackColor = true;
            // 
            // TbxSmallFF
            // 
            TbxSmallFF.Location = new Point(201, 2101);
            TbxSmallFF.Margin = new Padding(3, 3, 10, 3);
            TbxSmallFF.Name = "TbxSmallFF";
            TbxSmallFF.Size = new Size(118, 23);
            TbxSmallFF.TabIndex = 150;
            // 
            // LbSmallFO
            // 
            LbSmallFO.AutoSize = true;
            LbSmallFO.Location = new Point(14, 2104);
            LbSmallFO.Margin = new Padding(8, 12, 8, 0);
            LbSmallFO.Name = "LbSmallFO";
            LbSmallFO.Size = new Size(106, 15);
            LbSmallFO.TabIndex = 149;
            LbSmallFO.Text = "small font override";
            // 
            // TbxSmallerSY
            // 
            TbxSmallerSY.Location = new Point(269, 2344);
            TbxSmallerSY.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerSY.Name = "TbxSmallerSY";
            TbxSmallerSY.Size = new Size(50, 23);
            TbxSmallerSY.TabIndex = 176;
            // 
            // TbxSmallerYO
            // 
            TbxSmallerYO.Location = new Point(269, 2317);
            TbxSmallerYO.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerYO.Name = "TbxSmallerYO";
            TbxSmallerYO.Size = new Size(50, 23);
            TbxSmallerYO.TabIndex = 175;
            // 
            // LbSmallerSh
            // 
            LbSmallerSh.AutoSize = true;
            LbSmallerSh.Location = new Point(333, 2347);
            LbSmallerSh.Margin = new Padding(4, 12, 8, 0);
            LbSmallerSh.Name = "LbSmallerSh";
            LbSmallerSh.Size = new Size(81, 15);
            LbSmallerSh.TabIndex = 174;
            LbSmallerSh.Text = "shadow offset";
            // 
            // TbxSmallerSX
            // 
            TbxSmallerSX.Location = new Point(201, 2344);
            TbxSmallerSX.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerSX.Name = "TbxSmallerSX";
            TbxSmallerSX.Size = new Size(50, 23);
            TbxSmallerSX.TabIndex = 173;
            // 
            // LbSmallerXY
            // 
            LbSmallerXY.AutoSize = true;
            LbSmallerXY.Location = new Point(333, 2320);
            LbSmallerXY.Margin = new Padding(4, 12, 8, 0);
            LbSmallerXY.Name = "LbSmallerXY";
            LbSmallerXY.Size = new Size(57, 15);
            LbSmallerXY.TabIndex = 172;
            LbSmallerXY.Text = "xy offsets";
            // 
            // TbxSmallerXO
            // 
            TbxSmallerXO.Location = new Point(201, 2317);
            TbxSmallerXO.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerXO.Name = "TbxSmallerXO";
            TbxSmallerXO.Size = new Size(50, 23);
            TbxSmallerXO.TabIndex = 171;
            // 
            // LbSmallerFS
            // 
            LbSmallerFS.AutoSize = true;
            LbSmallerFS.Location = new Point(333, 2293);
            LbSmallerFS.Margin = new Padding(4, 12, 8, 0);
            LbSmallerFS.Name = "LbSmallerFS";
            LbSmallerFS.Size = new Size(51, 15);
            LbSmallerFS.TabIndex = 170;
            LbSmallerFS.Text = "font size";
            // 
            // TbxSmallerFS
            // 
            TbxSmallerFS.Location = new Point(201, 2290);
            TbxSmallerFS.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerFS.Name = "TbxSmallerFS";
            TbxSmallerFS.Size = new Size(118, 23);
            TbxSmallerFS.TabIndex = 169;
            // 
            // LbSmallerFW
            // 
            LbSmallerFW.AutoSize = true;
            LbSmallerFW.Location = new Point(333, 2266);
            LbSmallerFW.Margin = new Padding(4, 12, 8, 0);
            LbSmallerFW.Name = "LbSmallerFW";
            LbSmallerFW.Size = new Size(68, 15);
            LbSmallerFW.TabIndex = 168;
            LbSmallerFW.Text = "font weight";
            // 
            // LbSmallerFF
            // 
            LbSmallerFF.AutoSize = true;
            LbSmallerFF.Location = new Point(333, 2239);
            LbSmallerFF.Margin = new Padding(4, 12, 8, 0);
            LbSmallerFF.Name = "LbSmallerFF";
            LbSmallerFF.Size = new Size(65, 15);
            LbSmallerFF.TabIndex = 167;
            LbSmallerFF.Text = "font family";
            // 
            // TbxSmallerFW
            // 
            TbxSmallerFW.Location = new Point(201, 2263);
            TbxSmallerFW.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerFW.Name = "TbxSmallerFW";
            TbxSmallerFW.Size = new Size(118, 23);
            TbxSmallerFW.TabIndex = 166;
            // 
            // CbSmallerFO
            // 
            CbSmallerFO.AutoSize = true;
            CbSmallerFO.Location = new Point(180, 2241);
            CbSmallerFO.Name = "CbSmallerFO";
            CbSmallerFO.Size = new Size(15, 14);
            CbSmallerFO.TabIndex = 165;
            CbSmallerFO.UseVisualStyleBackColor = true;
            // 
            // TbxSmallerFF
            // 
            TbxSmallerFF.Location = new Point(201, 2236);
            TbxSmallerFF.Margin = new Padding(3, 3, 10, 3);
            TbxSmallerFF.Name = "TbxSmallerFF";
            TbxSmallerFF.Size = new Size(118, 23);
            TbxSmallerFF.TabIndex = 164;
            // 
            // LbSmallerFO
            // 
            LbSmallerFO.AutoSize = true;
            LbSmallerFO.Location = new Point(14, 2239);
            LbSmallerFO.Margin = new Padding(8, 12, 8, 0);
            LbSmallerFO.Name = "LbSmallerFO";
            LbSmallerFO.Size = new Size(116, 15);
            LbSmallerFO.TabIndex = 163;
            LbSmallerFO.Text = "smaller font override";
            // 
            // TbxTickerSY
            // 
            TbxTickerSY.Location = new Point(269, 2479);
            TbxTickerSY.Margin = new Padding(3, 3, 10, 3);
            TbxTickerSY.Name = "TbxTickerSY";
            TbxTickerSY.Size = new Size(50, 23);
            TbxTickerSY.TabIndex = 190;
            // 
            // TbxTickerYO
            // 
            TbxTickerYO.Location = new Point(269, 2452);
            TbxTickerYO.Margin = new Padding(3, 3, 10, 3);
            TbxTickerYO.Name = "TbxTickerYO";
            TbxTickerYO.Size = new Size(50, 23);
            TbxTickerYO.TabIndex = 189;
            // 
            // LbTickerSh
            // 
            LbTickerSh.AutoSize = true;
            LbTickerSh.Location = new Point(333, 2482);
            LbTickerSh.Margin = new Padding(4, 12, 8, 0);
            LbTickerSh.Name = "LbTickerSh";
            LbTickerSh.Size = new Size(81, 15);
            LbTickerSh.TabIndex = 188;
            LbTickerSh.Text = "shadow offset";
            // 
            // TbxTickerSX
            // 
            TbxTickerSX.Location = new Point(201, 2479);
            TbxTickerSX.Margin = new Padding(3, 3, 10, 3);
            TbxTickerSX.Name = "TbxTickerSX";
            TbxTickerSX.Size = new Size(50, 23);
            TbxTickerSX.TabIndex = 187;
            // 
            // LbTickerXY
            // 
            LbTickerXY.AutoSize = true;
            LbTickerXY.Location = new Point(333, 2455);
            LbTickerXY.Margin = new Padding(4, 12, 8, 0);
            LbTickerXY.Name = "LbTickerXY";
            LbTickerXY.Size = new Size(57, 15);
            LbTickerXY.TabIndex = 186;
            LbTickerXY.Text = "xy offsets";
            // 
            // TbxTickerXO
            // 
            TbxTickerXO.Location = new Point(201, 2452);
            TbxTickerXO.Margin = new Padding(3, 3, 10, 3);
            TbxTickerXO.Name = "TbxTickerXO";
            TbxTickerXO.Size = new Size(50, 23);
            TbxTickerXO.TabIndex = 185;
            // 
            // LbTickerFS
            // 
            LbTickerFS.AutoSize = true;
            LbTickerFS.Location = new Point(333, 2428);
            LbTickerFS.Margin = new Padding(4, 12, 8, 0);
            LbTickerFS.Name = "LbTickerFS";
            LbTickerFS.Size = new Size(51, 15);
            LbTickerFS.TabIndex = 184;
            LbTickerFS.Text = "font size";
            // 
            // TbxTickerFS
            // 
            TbxTickerFS.Location = new Point(201, 2425);
            TbxTickerFS.Margin = new Padding(3, 3, 10, 3);
            TbxTickerFS.Name = "TbxTickerFS";
            TbxTickerFS.Size = new Size(118, 23);
            TbxTickerFS.TabIndex = 183;
            // 
            // LbTickerFW
            // 
            LbTickerFW.AutoSize = true;
            LbTickerFW.Location = new Point(333, 2401);
            LbTickerFW.Margin = new Padding(4, 12, 8, 0);
            LbTickerFW.Name = "LbTickerFW";
            LbTickerFW.Size = new Size(68, 15);
            LbTickerFW.TabIndex = 182;
            LbTickerFW.Text = "font weight";
            // 
            // LbTickerFF
            // 
            LbTickerFF.AutoSize = true;
            LbTickerFF.Location = new Point(333, 2374);
            LbTickerFF.Margin = new Padding(4, 12, 8, 0);
            LbTickerFF.Name = "LbTickerFF";
            LbTickerFF.Size = new Size(65, 15);
            LbTickerFF.TabIndex = 181;
            LbTickerFF.Text = "font family";
            // 
            // TbxTickerFW
            // 
            TbxTickerFW.Location = new Point(201, 2398);
            TbxTickerFW.Margin = new Padding(3, 3, 10, 3);
            TbxTickerFW.Name = "TbxTickerFW";
            TbxTickerFW.Size = new Size(118, 23);
            TbxTickerFW.TabIndex = 180;
            // 
            // CbTickerFO
            // 
            CbTickerFO.AutoSize = true;
            CbTickerFO.Location = new Point(180, 2376);
            CbTickerFO.Name = "CbTickerFO";
            CbTickerFO.Size = new Size(15, 14);
            CbTickerFO.TabIndex = 179;
            CbTickerFO.UseVisualStyleBackColor = true;
            // 
            // TbxTickerFF
            // 
            TbxTickerFF.Location = new Point(201, 2371);
            TbxTickerFF.Margin = new Padding(3, 3, 10, 3);
            TbxTickerFF.Name = "TbxTickerFF";
            TbxTickerFF.Size = new Size(118, 23);
            TbxTickerFF.TabIndex = 178;
            // 
            // LbTickerFO
            // 
            LbTickerFO.AutoSize = true;
            LbTickerFO.Location = new Point(14, 2374);
            LbTickerFO.Margin = new Padding(8, 12, 8, 0);
            LbTickerFO.Name = "LbTickerFO";
            LbTickerFO.Size = new Size(107, 15);
            LbTickerFO.TabIndex = 177;
            LbTickerFO.Text = "ticker font override";
            // 
            // TbxConsoleSY
            // 
            TbxConsoleSY.Location = new Point(269, 2614);
            TbxConsoleSY.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleSY.Name = "TbxConsoleSY";
            TbxConsoleSY.Size = new Size(50, 23);
            TbxConsoleSY.TabIndex = 204;
            // 
            // TbxConsoleYO
            // 
            TbxConsoleYO.Location = new Point(269, 2587);
            TbxConsoleYO.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleYO.Name = "TbxConsoleYO";
            TbxConsoleYO.Size = new Size(50, 23);
            TbxConsoleYO.TabIndex = 203;
            // 
            // LbConsoleSh
            // 
            LbConsoleSh.AutoSize = true;
            LbConsoleSh.Location = new Point(333, 2617);
            LbConsoleSh.Margin = new Padding(4, 12, 8, 0);
            LbConsoleSh.Name = "LbConsoleSh";
            LbConsoleSh.Size = new Size(81, 15);
            LbConsoleSh.TabIndex = 202;
            LbConsoleSh.Text = "shadow offset";
            // 
            // TbxConsoleSX
            // 
            TbxConsoleSX.Location = new Point(201, 2614);
            TbxConsoleSX.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleSX.Name = "TbxConsoleSX";
            TbxConsoleSX.Size = new Size(50, 23);
            TbxConsoleSX.TabIndex = 201;
            // 
            // TbxConsoleXY
            // 
            TbxConsoleXY.AutoSize = true;
            TbxConsoleXY.Location = new Point(333, 2590);
            TbxConsoleXY.Margin = new Padding(4, 12, 8, 0);
            TbxConsoleXY.Name = "TbxConsoleXY";
            TbxConsoleXY.Size = new Size(57, 15);
            TbxConsoleXY.TabIndex = 200;
            TbxConsoleXY.Text = "xy offsets";
            // 
            // TbxConsoleXO
            // 
            TbxConsoleXO.Location = new Point(201, 2587);
            TbxConsoleXO.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleXO.Name = "TbxConsoleXO";
            TbxConsoleXO.Size = new Size(50, 23);
            TbxConsoleXO.TabIndex = 199;
            // 
            // LbConsoleFS
            // 
            LbConsoleFS.AutoSize = true;
            LbConsoleFS.Location = new Point(333, 2563);
            LbConsoleFS.Margin = new Padding(4, 12, 8, 0);
            LbConsoleFS.Name = "LbConsoleFS";
            LbConsoleFS.Size = new Size(51, 15);
            LbConsoleFS.TabIndex = 198;
            LbConsoleFS.Text = "font size";
            // 
            // TbxConsoleFS
            // 
            TbxConsoleFS.Location = new Point(201, 2560);
            TbxConsoleFS.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleFS.Name = "TbxConsoleFS";
            TbxConsoleFS.Size = new Size(118, 23);
            TbxConsoleFS.TabIndex = 197;
            // 
            // LbConsoleFW
            // 
            LbConsoleFW.AutoSize = true;
            LbConsoleFW.Location = new Point(333, 2536);
            LbConsoleFW.Margin = new Padding(4, 12, 8, 0);
            LbConsoleFW.Name = "LbConsoleFW";
            LbConsoleFW.Size = new Size(68, 15);
            LbConsoleFW.TabIndex = 196;
            LbConsoleFW.Text = "font weight";
            // 
            // LbConsoleFF
            // 
            LbConsoleFF.AutoSize = true;
            LbConsoleFF.Location = new Point(333, 2509);
            LbConsoleFF.Margin = new Padding(4, 12, 8, 0);
            LbConsoleFF.Name = "LbConsoleFF";
            LbConsoleFF.Size = new Size(65, 15);
            LbConsoleFF.TabIndex = 195;
            LbConsoleFF.Text = "font family";
            // 
            // TbxConsoleFW
            // 
            TbxConsoleFW.Location = new Point(201, 2533);
            TbxConsoleFW.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleFW.Name = "TbxConsoleFW";
            TbxConsoleFW.Size = new Size(118, 23);
            TbxConsoleFW.TabIndex = 194;
            // 
            // CbConsoleFO
            // 
            CbConsoleFO.AutoSize = true;
            CbConsoleFO.Location = new Point(180, 2511);
            CbConsoleFO.Name = "CbConsoleFO";
            CbConsoleFO.Size = new Size(15, 14);
            CbConsoleFO.TabIndex = 193;
            CbConsoleFO.UseVisualStyleBackColor = true;
            // 
            // TbxConsoleFF
            // 
            TbxConsoleFF.Location = new Point(201, 2506);
            TbxConsoleFF.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleFF.Name = "TbxConsoleFF";
            TbxConsoleFF.Size = new Size(118, 23);
            TbxConsoleFF.TabIndex = 192;
            // 
            // LbConsoleFO
            // 
            LbConsoleFO.AutoSize = true;
            LbConsoleFO.Location = new Point(14, 2509);
            LbConsoleFO.Margin = new Padding(8, 12, 8, 0);
            LbConsoleFO.Name = "LbConsoleFO";
            LbConsoleFO.Size = new Size(119, 15);
            LbConsoleFO.TabIndex = 191;
            LbConsoleFO.Text = "console font override";
            // 
            // CbControllerEnabled
            // 
            CbControllerEnabled.AutoSize = true;
            CbControllerEnabled.Location = new Point(180, 2746);
            CbControllerEnabled.Name = "CbControllerEnabled";
            CbControllerEnabled.Size = new Size(15, 14);
            CbControllerEnabled.TabIndex = 207;
            CbControllerEnabled.UseVisualStyleBackColor = true;
            // 
            // LbControllerEnabled
            // 
            LbControllerEnabled.AutoSize = true;
            LbControllerEnabled.Location = new Point(14, 2744);
            LbControllerEnabled.Margin = new Padding(8, 8, 8, 0);
            LbControllerEnabled.Name = "LbControllerEnabled";
            LbControllerEnabled.Size = new Size(49, 15);
            LbControllerEnabled.TabIndex = 206;
            LbControllerEnabled.Text = "enabled";
            // 
            // PnlController
            // 
            PnlController.BackColor = SystemColors.ControlLight;
            PnlController.BorderStyle = BorderStyle.Fixed3D;
            PnlController.Controls.Add(LbControllerDesc);
            PnlController.Controls.Add(LbController);
            PnlController.Location = new Point(8, 2670);
            PnlController.Margin = new Padding(3, 38, 3, 3);
            PnlController.Name = "PnlController";
            PnlController.Size = new Size(543, 63);
            PnlController.TabIndex = 205;
            // 
            // LbControllerDesc
            // 
            LbControllerDesc.AutoSize = true;
            LbControllerDesc.Location = new Point(4, 24);
            LbControllerDesc.Name = "LbControllerDesc";
            LbControllerDesc.Size = new Size(194, 30);
            LbControllerDesc.TabIndex = 1;
            LbControllerDesc.Text = "controller settings.\r\nthis is used to configure gamepads.";
            // 
            // LbController
            // 
            LbController.AutoSize = true;
            LbController.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbController.Location = new Point(4, 5);
            LbController.Name = "LbController";
            LbController.Size = new Size(70, 19);
            LbController.TabIndex = 0;
            LbController.Text = "controller";
            // 
            // CbCustomCEnabled
            // 
            CbCustomCEnabled.AutoSize = true;
            CbCustomCEnabled.Location = new Point(180, 3171);
            CbCustomCEnabled.Name = "CbCustomCEnabled";
            CbCustomCEnabled.Size = new Size(15, 14);
            CbCustomCEnabled.TabIndex = 211;
            CbCustomCEnabled.UseVisualStyleBackColor = true;
            // 
            // LbCustomCEnabled
            // 
            LbCustomCEnabled.AutoSize = true;
            LbCustomCEnabled.Location = new Point(14, 3169);
            LbCustomCEnabled.Margin = new Padding(8, 8, 8, 0);
            LbCustomCEnabled.Name = "LbCustomCEnabled";
            LbCustomCEnabled.Size = new Size(49, 15);
            LbCustomCEnabled.TabIndex = 210;
            LbCustomCEnabled.Text = "enabled";
            // 
            // PnlCustomC
            // 
            PnlCustomC.BackColor = SystemColors.ControlLight;
            PnlCustomC.BorderStyle = BorderStyle.Fixed3D;
            PnlCustomC.Controls.Add(LbCustomCDesc);
            PnlCustomC.Controls.Add(LbCustomC);
            PnlCustomC.Location = new Point(8, 3095);
            PnlCustomC.Margin = new Padding(3, 38, 3, 3);
            PnlCustomC.Name = "PnlCustomC";
            PnlCustomC.Size = new Size(543, 63);
            PnlCustomC.TabIndex = 209;
            // 
            // LbCustomCDesc
            // 
            LbCustomCDesc.AutoSize = true;
            LbCustomCDesc.Location = new Point(4, 24);
            LbCustomCDesc.Name = "LbCustomCDesc";
            LbCustomCDesc.Size = new Size(191, 30);
            LbCustomCDesc.TabIndex = 1;
            LbCustomCDesc.Text = "custom console configuration.\r\nthis is the custom console settings.";
            // 
            // LbCustomC
            // 
            LbCustomC.AutoSize = true;
            LbCustomC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbCustomC.Location = new Point(4, 5);
            LbCustomC.Name = "LbCustomC";
            LbCustomC.Size = new Size(107, 19);
            LbCustomC.TabIndex = 0;
            LbCustomC.Text = "custom console";
            // 
            // TbxControllerConfig
            // 
            TbxControllerConfig.Location = new Point(201, 2741);
            TbxControllerConfig.Name = "TbxControllerConfig";
            TbxControllerConfig.Size = new Size(313, 23);
            TbxControllerConfig.TabIndex = 212;
            // 
            // CbScrollback
            // 
            CbScrollback.AutoSize = true;
            CbScrollback.Location = new Point(180, 3194);
            CbScrollback.Name = "CbScrollback";
            CbScrollback.Size = new Size(15, 14);
            CbScrollback.TabIndex = 214;
            CbScrollback.UseVisualStyleBackColor = true;
            // 
            // LbScrollback
            // 
            LbScrollback.AutoSize = true;
            LbScrollback.Location = new Point(14, 3192);
            LbScrollback.Margin = new Padding(8, 8, 8, 0);
            LbScrollback.Name = "LbScrollback";
            LbScrollback.Size = new Size(98, 15);
            LbScrollback.TabIndex = 213;
            LbScrollback.Text = "enable scrollback";
            // 
            // TbxConsoleBuffer
            // 
            TbxConsoleBuffer.Location = new Point(201, 3216);
            TbxConsoleBuffer.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleBuffer.Name = "TbxConsoleBuffer";
            TbxConsoleBuffer.Size = new Size(118, 23);
            TbxConsoleBuffer.TabIndex = 216;
            // 
            // LbConsoleBuffer
            // 
            LbConsoleBuffer.AutoSize = true;
            LbConsoleBuffer.Location = new Point(14, 3219);
            LbConsoleBuffer.Margin = new Padding(8, 12, 8, 0);
            LbConsoleBuffer.Name = "LbConsoleBuffer";
            LbConsoleBuffer.Size = new Size(61, 15);
            LbConsoleBuffer.TabIndex = 215;
            LbConsoleBuffer.Text = "buffer size";
            // 
            // TbxConsoleSoft
            // 
            TbxConsoleSoft.Location = new Point(201, 3243);
            TbxConsoleSoft.Margin = new Padding(3, 3, 10, 3);
            TbxConsoleSoft.Name = "TbxConsoleSoft";
            TbxConsoleSoft.Size = new Size(118, 23);
            TbxConsoleSoft.TabIndex = 218;
            // 
            // LbConsoleSoft
            // 
            LbConsoleSoft.AutoSize = true;
            LbConsoleSoft.Location = new Point(14, 3246);
            LbConsoleSoft.Margin = new Padding(8, 12, 8, 0);
            LbConsoleSoft.Name = "LbConsoleSoft";
            LbConsoleSoft.Size = new Size(84, 15);
            LbConsoleSoft.TabIndex = 217;
            LbConsoleSoft.Text = "buffer size soft";
            // 
            // TbxLineHeight
            // 
            TbxLineHeight.Location = new Point(201, 3270);
            TbxLineHeight.Margin = new Padding(3, 3, 10, 3);
            TbxLineHeight.Name = "TbxLineHeight";
            TbxLineHeight.Size = new Size(118, 23);
            TbxLineHeight.TabIndex = 220;
            // 
            // LbLineHeight
            // 
            LbLineHeight.AutoSize = true;
            LbLineHeight.Location = new Point(14, 3273);
            LbLineHeight.Margin = new Padding(8, 12, 8, 0);
            LbLineHeight.Name = "LbLineHeight";
            LbLineHeight.Size = new Size(63, 15);
            LbLineHeight.TabIndex = 219;
            LbLineHeight.Text = "line height";
            // 
            // TbxXMargin
            // 
            TbxXMargin.Location = new Point(201, 3297);
            TbxXMargin.Margin = new Padding(3, 3, 10, 3);
            TbxXMargin.Name = "TbxXMargin";
            TbxXMargin.Size = new Size(118, 23);
            TbxXMargin.TabIndex = 222;
            // 
            // LbXMargin
            // 
            LbXMargin.AutoSize = true;
            LbXMargin.Location = new Point(14, 3300);
            LbXMargin.Margin = new Padding(8, 12, 8, 0);
            LbXMargin.Name = "LbXMargin";
            LbXMargin.Size = new Size(54, 15);
            LbXMargin.TabIndex = 221;
            LbXMargin.Text = "x margin";
            // 
            // TbxCFadeStart
            // 
            TbxCFadeStart.Location = new Point(201, 3324);
            TbxCFadeStart.Margin = new Padding(3, 3, 10, 3);
            TbxCFadeStart.Name = "TbxCFadeStart";
            TbxCFadeStart.Size = new Size(118, 23);
            TbxCFadeStart.TabIndex = 224;
            // 
            // LbCFadeStart
            // 
            LbCFadeStart.AutoSize = true;
            LbCFadeStart.Location = new Point(14, 3327);
            LbCFadeStart.Margin = new Padding(8, 12, 8, 0);
            LbCFadeStart.Name = "LbCFadeStart";
            LbCFadeStart.Size = new Size(56, 15);
            LbCFadeStart.TabIndex = 223;
            LbCFadeStart.Text = "fade start";
            // 
            // TbxCFadeTime
            // 
            TbxCFadeTime.Location = new Point(201, 3351);
            TbxCFadeTime.Margin = new Padding(3, 3, 10, 3);
            TbxCFadeTime.Name = "TbxCFadeTime";
            TbxCFadeTime.Size = new Size(118, 23);
            TbxCFadeTime.TabIndex = 226;
            // 
            // PnlCustomChat
            // 
            PnlCustomChat.BackColor = SystemColors.ControlLight;
            PnlCustomChat.BorderStyle = BorderStyle.Fixed3D;
            PnlCustomChat.Controls.Add(LbCustomChatDesc);
            PnlCustomChat.Controls.Add(LbCustomChat);
            PnlCustomChat.Location = new Point(8, 3407);
            PnlCustomChat.Margin = new Padding(3, 38, 3, 3);
            PnlCustomChat.Name = "PnlCustomChat";
            PnlCustomChat.Size = new Size(543, 63);
            PnlCustomChat.TabIndex = 210;
            // 
            // LbCustomChatDesc
            // 
            LbCustomChatDesc.AutoSize = true;
            LbCustomChatDesc.Location = new Point(4, 24);
            LbCustomChatDesc.Name = "LbCustomChatDesc";
            LbCustomChatDesc.Size = new Size(212, 30);
            LbCustomChatDesc.TabIndex = 1;
            LbCustomChatDesc.Text = "custom chat configuration.\r\nthis is the custom chat and server chat.";
            // 
            // LbCustomChat
            // 
            LbCustomChat.AutoSize = true;
            LbCustomChat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbCustomChat.Location = new Point(4, 5);
            LbCustomChat.Name = "LbCustomChat";
            LbCustomChat.Size = new Size(86, 19);
            LbCustomChat.TabIndex = 0;
            LbCustomChat.Text = "custom chat";
            // 
            // CbAllowRcon
            // 
            CbAllowRcon.AutoSize = true;
            CbAllowRcon.Location = new Point(180, 3483);
            CbAllowRcon.Name = "CbAllowRcon";
            CbAllowRcon.Size = new Size(15, 14);
            CbAllowRcon.TabIndex = 228;
            CbAllowRcon.UseVisualStyleBackColor = true;
            // 
            // LbAllowRcon
            // 
            LbAllowRcon.AutoSize = true;
            LbAllowRcon.Location = new Point(14, 3481);
            LbAllowRcon.Margin = new Padding(8, 12, 8, 0);
            LbAllowRcon.Name = "LbAllowRcon";
            LbAllowRcon.Size = new Size(120, 15);
            LbAllowRcon.TabIndex = 227;
            LbAllowRcon.Text = "allow unsolicted rcon";
            // 
            // LbSvMsgColor
            // 
            LbSvMsgColor.AutoSize = true;
            LbSvMsgColor.BackColor = SystemColors.ControlLight;
            LbSvMsgColor.Location = new Point(34, 3535);
            LbSvMsgColor.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgColor.Name = "LbSvMsgColor";
            LbSvMsgColor.Size = new Size(34, 15);
            LbSvMsgColor.TabIndex = 229;
            LbSvMsgColor.Text = "color";
            // 
            // LbSvMsgOff
            // 
            LbSvMsgOff.AutoSize = true;
            LbSvMsgOff.BackColor = SystemColors.ControlLight;
            LbSvMsgOff.Location = new Point(34, 3562);
            LbSvMsgOff.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgOff.Name = "LbSvMsgOff";
            LbSvMsgOff.Size = new Size(37, 15);
            LbSvMsgOff.TabIndex = 230;
            LbSvMsgOff.Text = "offset";
            // 
            // LbSvMsgDim
            // 
            LbSvMsgDim.AutoSize = true;
            LbSvMsgDim.BackColor = SystemColors.ControlLight;
            LbSvMsgDim.Location = new Point(34, 3589);
            LbSvMsgDim.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgDim.Name = "LbSvMsgDim";
            LbSvMsgDim.Size = new Size(68, 15);
            LbSvMsgDim.TabIndex = 231;
            LbSvMsgDim.Text = "dimensions";
            // 
            // LbSvMsgOC
            // 
            LbSvMsgOC.AutoSize = true;
            LbSvMsgOC.BackColor = SystemColors.ControlLight;
            LbSvMsgOC.Location = new Point(34, 3616);
            LbSvMsgOC.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgOC.Name = "LbSvMsgOC";
            LbSvMsgOC.Size = new Size(97, 15);
            LbSvMsgOC.TabIndex = 232;
            LbSvMsgOC.Text = "open chat height\r\n";
            // 
            // LbSvMsgAnchor
            // 
            LbSvMsgAnchor.AutoSize = true;
            LbSvMsgAnchor.BackColor = SystemColors.ControlLight;
            LbSvMsgAnchor.Location = new Point(34, 3643);
            LbSvMsgAnchor.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgAnchor.Name = "LbSvMsgAnchor";
            LbSvMsgAnchor.Size = new Size(44, 15);
            LbSvMsgAnchor.TabIndex = 233;
            LbSvMsgAnchor.Text = "anchor";
            // 
            // LbSvMsgCHide
            // 
            LbSvMsgCHide.AutoSize = true;
            LbSvMsgCHide.BackColor = SystemColors.ControlLight;
            LbSvMsgCHide.Location = new Point(34, 3670);
            LbSvMsgCHide.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgCHide.Name = "LbSvMsgCHide";
            LbSvMsgCHide.Size = new Size(74, 15);
            LbSvMsgCHide.TabIndex = 234;
            LbSvMsgCHide.Text = "console hide";
            // 
            // LbSvMsgFont
            // 
            LbSvMsgFont.AutoSize = true;
            LbSvMsgFont.BackColor = SystemColors.ControlLight;
            LbSvMsgFont.Location = new Point(34, 3697);
            LbSvMsgFont.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgFont.Name = "LbSvMsgFont";
            LbSvMsgFont.Size = new Size(29, 15);
            LbSvMsgFont.TabIndex = 235;
            LbSvMsgFont.Text = "font";
            // 
            // LbSvMsgAniTime
            // 
            LbSvMsgAniTime.AutoSize = true;
            LbSvMsgAniTime.BackColor = SystemColors.ControlLight;
            LbSvMsgAniTime.Location = new Point(34, 3724);
            LbSvMsgAniTime.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgAniTime.Name = "LbSvMsgAniTime";
            LbSvMsgAniTime.Size = new Size(88, 15);
            LbSvMsgAniTime.TabIndex = 236;
            LbSvMsgAniTime.Text = "animation time";
            // 
            // LbSvMsgDisTime
            // 
            LbSvMsgDisTime.AutoSize = true;
            LbSvMsgDisTime.BackColor = SystemColors.ControlLight;
            LbSvMsgDisTime.Location = new Point(34, 3751);
            LbSvMsgDisTime.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgDisTime.Name = "LbSvMsgDisTime";
            LbSvMsgDisTime.Size = new Size(71, 15);
            LbSvMsgDisTime.TabIndex = 237;
            LbSvMsgDisTime.Text = "display time";
            // 
            // LbSvMsgFadeTime
            // 
            LbSvMsgFadeTime.AutoSize = true;
            LbSvMsgFadeTime.BackColor = SystemColors.ControlLight;
            LbSvMsgFadeTime.Location = new Point(34, 3778);
            LbSvMsgFadeTime.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgFadeTime.Name = "LbSvMsgFadeTime";
            LbSvMsgFadeTime.Size = new Size(78, 15);
            LbSvMsgFadeTime.TabIndex = 238;
            LbSvMsgFadeTime.Text = "fade out time";
            // 
            // LbSvMsgLineH
            // 
            LbSvMsgLineH.AutoSize = true;
            LbSvMsgLineH.BackColor = SystemColors.ControlLight;
            LbSvMsgLineH.Location = new Point(34, 3805);
            LbSvMsgLineH.Margin = new Padding(8, 12, 8, 0);
            LbSvMsgLineH.Name = "LbSvMsgLineH";
            LbSvMsgLineH.Size = new Size(63, 15);
            LbSvMsgLineH.TabIndex = 239;
            LbSvMsgLineH.Text = "line height";
            // 
            // LbSvMsg
            // 
            LbSvMsg.AutoSize = true;
            LbSvMsg.Location = new Point(14, 3508);
            LbSvMsg.Margin = new Padding(8, 12, 8, 0);
            LbSvMsg.Name = "LbSvMsg";
            LbSvMsg.Size = new Size(92, 15);
            LbSvMsg.TabIndex = 240;
            LbSvMsg.Text = "server messages";
            // 
            // TbxSvMsgColorA
            // 
            TbxSvMsgColorA.Location = new Point(201, 3532);
            TbxSvMsgColorA.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgColorA.Name = "TbxSvMsgColorA";
            TbxSvMsgColorA.Size = new Size(72, 23);
            TbxSvMsgColorA.TabIndex = 241;
            // 
            // TbxSvMsgColorR
            // 
            TbxSvMsgColorR.Location = new Point(291, 3532);
            TbxSvMsgColorR.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgColorR.Name = "TbxSvMsgColorR";
            TbxSvMsgColorR.Size = new Size(72, 23);
            TbxSvMsgColorR.TabIndex = 242;
            // 
            // TbxSvMsgColorG
            // 
            TbxSvMsgColorG.Location = new Point(381, 3532);
            TbxSvMsgColorG.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgColorG.Name = "TbxSvMsgColorG";
            TbxSvMsgColorG.Size = new Size(72, 23);
            TbxSvMsgColorG.TabIndex = 243;
            // 
            // LbSvMsgColorA
            // 
            LbSvMsgColorA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgColorA.AutoSize = true;
            LbSvMsgColorA.Location = new Point(188, 3535);
            LbSvMsgColorA.Margin = new Padding(0);
            LbSvMsgColorA.Name = "LbSvMsgColorA";
            LbSvMsgColorA.Size = new Size(13, 15);
            LbSvMsgColorA.TabIndex = 244;
            LbSvMsgColorA.Text = "a";
            LbSvMsgColorA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSvMsgColorR
            // 
            LbSvMsgColorR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgColorR.AutoSize = true;
            LbSvMsgColorR.Location = new Point(280, 3535);
            LbSvMsgColorR.Margin = new Padding(0);
            LbSvMsgColorR.Name = "LbSvMsgColorR";
            LbSvMsgColorR.Size = new Size(11, 15);
            LbSvMsgColorR.TabIndex = 245;
            LbSvMsgColorR.Text = "r";
            LbSvMsgColorR.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSvMsgColorG
            // 
            LbSvMsgColorG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgColorG.AutoSize = true;
            LbSvMsgColorG.Location = new Point(367, 3535);
            LbSvMsgColorG.Margin = new Padding(0);
            LbSvMsgColorG.Name = "LbSvMsgColorG";
            LbSvMsgColorG.Size = new Size(14, 15);
            LbSvMsgColorG.TabIndex = 246;
            LbSvMsgColorG.Text = "g";
            LbSvMsgColorG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxSvMsgOffX
            // 
            TbxSvMsgOffX.Location = new Point(201, 3559);
            TbxSvMsgOffX.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgOffX.Name = "TbxSvMsgOffX";
            TbxSvMsgOffX.Size = new Size(72, 23);
            TbxSvMsgOffX.TabIndex = 247;
            // 
            // TbxSvMsgDimX
            // 
            TbxSvMsgDimX.Location = new Point(201, 3586);
            TbxSvMsgDimX.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgDimX.Name = "TbxSvMsgDimX";
            TbxSvMsgDimX.Size = new Size(72, 23);
            TbxSvMsgDimX.TabIndex = 248;
            // 
            // TbxSvMsgOC
            // 
            TbxSvMsgOC.Location = new Point(201, 3613);
            TbxSvMsgOC.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgOC.Name = "TbxSvMsgOC";
            TbxSvMsgOC.Size = new Size(72, 23);
            TbxSvMsgOC.TabIndex = 249;
            // 
            // TbxSvMsgAniTime
            // 
            TbxSvMsgAniTime.Location = new Point(201, 3721);
            TbxSvMsgAniTime.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgAniTime.Name = "TbxSvMsgAniTime";
            TbxSvMsgAniTime.Size = new Size(72, 23);
            TbxSvMsgAniTime.TabIndex = 253;
            // 
            // TbxSvMsgDisTime
            // 
            TbxSvMsgDisTime.Location = new Point(201, 3748);
            TbxSvMsgDisTime.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgDisTime.Name = "TbxSvMsgDisTime";
            TbxSvMsgDisTime.Size = new Size(72, 23);
            TbxSvMsgDisTime.TabIndex = 254;
            // 
            // TbxSvMsgFadeTime
            // 
            TbxSvMsgFadeTime.Location = new Point(201, 3775);
            TbxSvMsgFadeTime.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgFadeTime.Name = "TbxSvMsgFadeTime";
            TbxSvMsgFadeTime.Size = new Size(72, 23);
            TbxSvMsgFadeTime.TabIndex = 255;
            // 
            // TbxSvMsgLineH
            // 
            TbxSvMsgLineH.Location = new Point(201, 3802);
            TbxSvMsgLineH.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgLineH.Name = "TbxSvMsgLineH";
            TbxSvMsgLineH.Size = new Size(72, 23);
            TbxSvMsgLineH.TabIndex = 256;
            // 
            // PnlSvMsg
            // 
            PnlSvMsg.BackColor = SystemColors.ControlLight;
            PnlSvMsg.BorderStyle = BorderStyle.Fixed3D;
            PnlSvMsg.Location = new Point(24, 3532);
            PnlSvMsg.Margin = new Padding(3, 38, 3, 3);
            PnlSvMsg.Name = "PnlSvMsg";
            PnlSvMsg.Size = new Size(139, 293);
            PnlSvMsg.TabIndex = 211;
            // 
            // TbxSvMsgOffY
            // 
            TbxSvMsgOffY.Location = new Point(291, 3559);
            TbxSvMsgOffY.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgOffY.Name = "TbxSvMsgOffY";
            TbxSvMsgOffY.Size = new Size(72, 23);
            TbxSvMsgOffY.TabIndex = 257;
            // 
            // TbxSvMsgDimY
            // 
            TbxSvMsgDimY.Location = new Point(291, 3586);
            TbxSvMsgDimY.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgDimY.Name = "TbxSvMsgDimY";
            TbxSvMsgDimY.Size = new Size(72, 23);
            TbxSvMsgDimY.TabIndex = 258;
            // 
            // TbxChtMsgDimY
            // 
            TbxChtMsgDimY.Location = new Point(291, 3972);
            TbxChtMsgDimY.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgDimY.Name = "TbxChtMsgDimY";
            TbxChtMsgDimY.Size = new Size(72, 23);
            TbxChtMsgDimY.TabIndex = 289;
            // 
            // TbxChtMsgOffY
            // 
            TbxChtMsgOffY.Location = new Point(291, 3945);
            TbxChtMsgOffY.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgOffY.Name = "TbxChtMsgOffY";
            TbxChtMsgOffY.Size = new Size(72, 23);
            TbxChtMsgOffY.TabIndex = 288;
            // 
            // TbxChtMsgLineH
            // 
            TbxChtMsgLineH.Location = new Point(201, 4188);
            TbxChtMsgLineH.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgLineH.Name = "TbxChtMsgLineH";
            TbxChtMsgLineH.Size = new Size(72, 23);
            TbxChtMsgLineH.TabIndex = 287;
            // 
            // TbxChtMsgFadeTime
            // 
            TbxChtMsgFadeTime.Location = new Point(201, 4161);
            TbxChtMsgFadeTime.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgFadeTime.Name = "TbxChtMsgFadeTime";
            TbxChtMsgFadeTime.Size = new Size(72, 23);
            TbxChtMsgFadeTime.TabIndex = 286;
            // 
            // TbxChtMsgDisTime
            // 
            TbxChtMsgDisTime.Location = new Point(201, 4134);
            TbxChtMsgDisTime.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgDisTime.Name = "TbxChtMsgDisTime";
            TbxChtMsgDisTime.Size = new Size(72, 23);
            TbxChtMsgDisTime.TabIndex = 285;
            // 
            // TbxChtMsgAniTime
            // 
            TbxChtMsgAniTime.Location = new Point(201, 4107);
            TbxChtMsgAniTime.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgAniTime.Name = "TbxChtMsgAniTime";
            TbxChtMsgAniTime.Size = new Size(72, 23);
            TbxChtMsgAniTime.TabIndex = 284;
            // 
            // TbxChtMsgOC
            // 
            TbxChtMsgOC.Location = new Point(201, 3999);
            TbxChtMsgOC.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgOC.Name = "TbxChtMsgOC";
            TbxChtMsgOC.Size = new Size(72, 23);
            TbxChtMsgOC.TabIndex = 280;
            // 
            // TbxChtMsgDimX
            // 
            TbxChtMsgDimX.Location = new Point(201, 3972);
            TbxChtMsgDimX.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgDimX.Name = "TbxChtMsgDimX";
            TbxChtMsgDimX.Size = new Size(72, 23);
            TbxChtMsgDimX.TabIndex = 279;
            // 
            // TbxChtMsgOffX
            // 
            TbxChtMsgOffX.Location = new Point(201, 3945);
            TbxChtMsgOffX.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgOffX.Name = "TbxChtMsgOffX";
            TbxChtMsgOffX.Size = new Size(72, 23);
            TbxChtMsgOffX.TabIndex = 278;
            // 
            // LbChtMsgFfaG
            // 
            LbChtMsgFfaG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgFfaG.AutoSize = true;
            LbChtMsgFfaG.Location = new Point(367, 3867);
            LbChtMsgFfaG.Margin = new Padding(0);
            LbChtMsgFfaG.Name = "LbChtMsgFfaG";
            LbChtMsgFfaG.Size = new Size(14, 15);
            LbChtMsgFfaG.TabIndex = 277;
            LbChtMsgFfaG.Text = "g";
            LbChtMsgFfaG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgFfaR
            // 
            LbChtMsgFfaR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgFfaR.AutoSize = true;
            LbChtMsgFfaR.Location = new Point(280, 3867);
            LbChtMsgFfaR.Margin = new Padding(0);
            LbChtMsgFfaR.Name = "LbChtMsgFfaR";
            LbChtMsgFfaR.Size = new Size(11, 15);
            LbChtMsgFfaR.TabIndex = 276;
            LbChtMsgFfaR.Text = "r";
            LbChtMsgFfaR.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgFfaA
            // 
            LbChtMsgFfaA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgFfaA.AutoSize = true;
            LbChtMsgFfaA.Location = new Point(188, 3867);
            LbChtMsgFfaA.Margin = new Padding(0);
            LbChtMsgFfaA.Name = "LbChtMsgFfaA";
            LbChtMsgFfaA.Size = new Size(13, 15);
            LbChtMsgFfaA.TabIndex = 275;
            LbChtMsgFfaA.Text = "a";
            LbChtMsgFfaA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgFfa
            // 
            TbxChtMsgFfa.Location = new Point(381, 3864);
            TbxChtMsgFfa.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgFfa.Name = "TbxChtMsgFfa";
            TbxChtMsgFfa.Size = new Size(72, 23);
            TbxChtMsgFfa.TabIndex = 274;
            // 
            // TbxChtMsgFfaR
            // 
            TbxChtMsgFfaR.Location = new Point(291, 3864);
            TbxChtMsgFfaR.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgFfaR.Name = "TbxChtMsgFfaR";
            TbxChtMsgFfaR.Size = new Size(72, 23);
            TbxChtMsgFfaR.TabIndex = 273;
            // 
            // TbxChtMsgFfaA
            // 
            TbxChtMsgFfaA.Location = new Point(201, 3864);
            TbxChtMsgFfaA.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgFfaA.Name = "TbxChtMsgFfaA";
            TbxChtMsgFfaA.Size = new Size(72, 23);
            TbxChtMsgFfaA.TabIndex = 272;
            // 
            // LbChtMsg
            // 
            LbChtMsg.AutoSize = true;
            LbChtMsg.Location = new Point(14, 3840);
            LbChtMsg.Margin = new Padding(8, 12, 8, 0);
            LbChtMsg.Name = "LbChtMsg";
            LbChtMsg.Size = new Size(84, 15);
            LbChtMsg.TabIndex = 271;
            LbChtMsg.Text = "chat messages";
            // 
            // LbChtMsgLineH
            // 
            LbChtMsgLineH.AutoSize = true;
            LbChtMsgLineH.BackColor = SystemColors.ControlLight;
            LbChtMsgLineH.Location = new Point(8, 325);
            LbChtMsgLineH.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgLineH.Name = "LbChtMsgLineH";
            LbChtMsgLineH.Size = new Size(63, 15);
            LbChtMsgLineH.TabIndex = 270;
            LbChtMsgLineH.Text = "line height";
            // 
            // LbChtMsgFadeTime
            // 
            LbChtMsgFadeTime.AutoSize = true;
            LbChtMsgFadeTime.BackColor = SystemColors.ControlLight;
            LbChtMsgFadeTime.Location = new Point(8, 298);
            LbChtMsgFadeTime.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgFadeTime.Name = "LbChtMsgFadeTime";
            LbChtMsgFadeTime.Size = new Size(78, 15);
            LbChtMsgFadeTime.TabIndex = 269;
            LbChtMsgFadeTime.Text = "fade out time";
            // 
            // LbChtMsgDisTime
            // 
            LbChtMsgDisTime.AutoSize = true;
            LbChtMsgDisTime.BackColor = SystemColors.ControlLight;
            LbChtMsgDisTime.Location = new Point(8, 271);
            LbChtMsgDisTime.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgDisTime.Name = "LbChtMsgDisTime";
            LbChtMsgDisTime.Size = new Size(71, 15);
            LbChtMsgDisTime.TabIndex = 268;
            LbChtMsgDisTime.Text = "display time";
            // 
            // LbChtMsgAniTime
            // 
            LbChtMsgAniTime.AutoSize = true;
            LbChtMsgAniTime.BackColor = SystemColors.ControlLight;
            LbChtMsgAniTime.Location = new Point(8, 244);
            LbChtMsgAniTime.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgAniTime.Name = "LbChtMsgAniTime";
            LbChtMsgAniTime.Size = new Size(88, 15);
            LbChtMsgAniTime.TabIndex = 267;
            LbChtMsgAniTime.Text = "animation time";
            // 
            // LbChtMsgFont
            // 
            LbChtMsgFont.AutoSize = true;
            LbChtMsgFont.BackColor = SystemColors.ControlLight;
            LbChtMsgFont.Location = new Point(8, 217);
            LbChtMsgFont.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgFont.Name = "LbChtMsgFont";
            LbChtMsgFont.Size = new Size(29, 15);
            LbChtMsgFont.TabIndex = 266;
            LbChtMsgFont.Text = "font";
            // 
            // LbChtMsgCHide
            // 
            LbChtMsgCHide.AutoSize = true;
            LbChtMsgCHide.BackColor = SystemColors.ControlLight;
            LbChtMsgCHide.Location = new Point(8, 190);
            LbChtMsgCHide.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgCHide.Name = "LbChtMsgCHide";
            LbChtMsgCHide.Size = new Size(74, 15);
            LbChtMsgCHide.TabIndex = 265;
            LbChtMsgCHide.Text = "console hide";
            // 
            // LbChtMsgAnchor
            // 
            LbChtMsgAnchor.AutoSize = true;
            LbChtMsgAnchor.BackColor = SystemColors.ControlLight;
            LbChtMsgAnchor.Location = new Point(8, 163);
            LbChtMsgAnchor.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgAnchor.Name = "LbChtMsgAnchor";
            LbChtMsgAnchor.Size = new Size(44, 15);
            LbChtMsgAnchor.TabIndex = 264;
            LbChtMsgAnchor.Text = "anchor";
            // 
            // LbChtMsgOC
            // 
            LbChtMsgOC.AutoSize = true;
            LbChtMsgOC.BackColor = SystemColors.ControlLight;
            LbChtMsgOC.Location = new Point(8, 136);
            LbChtMsgOC.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgOC.Name = "LbChtMsgOC";
            LbChtMsgOC.Size = new Size(97, 15);
            LbChtMsgOC.TabIndex = 263;
            LbChtMsgOC.Text = "open chat height\r\n";
            // 
            // LbChtMsgDim
            // 
            LbChtMsgDim.AutoSize = true;
            LbChtMsgDim.BackColor = SystemColors.ControlLight;
            LbChtMsgDim.Location = new Point(8, 109);
            LbChtMsgDim.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgDim.Name = "LbChtMsgDim";
            LbChtMsgDim.Size = new Size(68, 15);
            LbChtMsgDim.TabIndex = 262;
            LbChtMsgDim.Text = "dimensions";
            // 
            // LbChtMsgOff
            // 
            LbChtMsgOff.AutoSize = true;
            LbChtMsgOff.BackColor = SystemColors.ControlLight;
            LbChtMsgOff.Location = new Point(8, 82);
            LbChtMsgOff.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgOff.Name = "LbChtMsgOff";
            LbChtMsgOff.Size = new Size(37, 15);
            LbChtMsgOff.TabIndex = 261;
            LbChtMsgOff.Text = "offset";
            // 
            // LbChtMsgFfa
            // 
            LbChtMsgFfa.AutoSize = true;
            LbChtMsgFfa.BackColor = SystemColors.ControlLight;
            LbChtMsgFfa.Location = new Point(34, 3867);
            LbChtMsgFfa.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgFfa.Name = "LbChtMsgFfa";
            LbChtMsgFfa.Size = new Size(51, 15);
            LbChtMsgFfa.TabIndex = 260;
            LbChtMsgFfa.Text = "color ffa";
            // 
            // PnlChtMsg
            // 
            PnlChtMsg.BackColor = SystemColors.ControlLight;
            PnlChtMsg.BorderStyle = BorderStyle.Fixed3D;
            PnlChtMsg.Controls.Add(this.LbChtMsgBlue);
            PnlChtMsg.Controls.Add(this.LbChtMsgRed);
            PnlChtMsg.Controls.Add(this.LbChtMsgOff);
            PnlChtMsg.Controls.Add(LbChtMsgDim);
            PnlChtMsg.Controls.Add(LbChtMsgOC);
            PnlChtMsg.Controls.Add(LbChtMsgAnchor);
            PnlChtMsg.Controls.Add(LbChtMsgCHide);
            PnlChtMsg.Controls.Add(LbChtMsgFont);
            PnlChtMsg.Controls.Add(LbChtMsgAniTime);
            PnlChtMsg.Controls.Add(LbChtMsgDisTime);
            PnlChtMsg.Controls.Add(LbChtMsgFadeTime);
            PnlChtMsg.Controls.Add(LbChtMsgLineH);
            PnlChtMsg.Location = new Point(24, 3864);
            PnlChtMsg.Margin = new Padding(3, 38, 3, 3);
            PnlChtMsg.Name = "PnlChtMsg";
            PnlChtMsg.Size = new Size(139, 347);
            PnlChtMsg.TabIndex = 259;
            // 
            // LbChtMsgRedG
            // 
            LbChtMsgRedG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgRedG.AutoSize = true;
            LbChtMsgRedG.Location = new Point(367, 3894);
            LbChtMsgRedG.Margin = new Padding(0);
            LbChtMsgRedG.Name = "LbChtMsgRedG";
            LbChtMsgRedG.Size = new Size(14, 15);
            LbChtMsgRedG.TabIndex = 295;
            LbChtMsgRedG.Text = "g";
            LbChtMsgRedG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgRedR
            // 
            LbChtMsgRedR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgRedR.AutoSize = true;
            LbChtMsgRedR.Location = new Point(280, 3894);
            LbChtMsgRedR.Margin = new Padding(0);
            LbChtMsgRedR.Name = "LbChtMsgRedR";
            LbChtMsgRedR.Size = new Size(11, 15);
            LbChtMsgRedR.TabIndex = 294;
            LbChtMsgRedR.Text = "r";
            LbChtMsgRedR.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgRedA
            // 
            LbChtMsgRedA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgRedA.AutoSize = true;
            LbChtMsgRedA.Location = new Point(188, 3894);
            LbChtMsgRedA.Margin = new Padding(0);
            LbChtMsgRedA.Name = "LbChtMsgRedA";
            LbChtMsgRedA.Size = new Size(13, 15);
            LbChtMsgRedA.TabIndex = 293;
            LbChtMsgRedA.Text = "a";
            LbChtMsgRedA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgRedG
            // 
            TbxChtMsgRedG.Location = new Point(381, 3891);
            TbxChtMsgRedG.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgRedG.Name = "TbxChtMsgRedG";
            TbxChtMsgRedG.Size = new Size(72, 23);
            TbxChtMsgRedG.TabIndex = 292;
            // 
            // TbxChtMsgRedR
            // 
            TbxChtMsgRedR.Location = new Point(291, 3891);
            TbxChtMsgRedR.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgRedR.Name = "TbxChtMsgRedR";
            TbxChtMsgRedR.Size = new Size(72, 23);
            TbxChtMsgRedR.TabIndex = 291;
            // 
            // TbxChtMsgRedA
            // 
            TbxChtMsgRedA.Location = new Point(201, 3891);
            TbxChtMsgRedA.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgRedA.Name = "TbxChtMsgRedA";
            TbxChtMsgRedA.Size = new Size(72, 23);
            TbxChtMsgRedA.TabIndex = 290;
            // 
            // LbChtMsgBlueG
            // 
            LbChtMsgBlueG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgBlueG.AutoSize = true;
            LbChtMsgBlueG.Location = new Point(367, 3921);
            LbChtMsgBlueG.Margin = new Padding(0);
            LbChtMsgBlueG.Name = "LbChtMsgBlueG";
            LbChtMsgBlueG.Size = new Size(14, 15);
            LbChtMsgBlueG.TabIndex = 301;
            LbChtMsgBlueG.Text = "g";
            LbChtMsgBlueG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgBlueR
            // 
            LbChtMsgBlueR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgBlueR.AutoSize = true;
            LbChtMsgBlueR.Location = new Point(280, 3921);
            LbChtMsgBlueR.Margin = new Padding(0);
            LbChtMsgBlueR.Name = "LbChtMsgBlueR";
            LbChtMsgBlueR.Size = new Size(11, 15);
            LbChtMsgBlueR.TabIndex = 300;
            LbChtMsgBlueR.Text = "r";
            LbChtMsgBlueR.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgBlueA
            // 
            LbChtMsgBlueA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgBlueA.AutoSize = true;
            LbChtMsgBlueA.Location = new Point(188, 3921);
            LbChtMsgBlueA.Margin = new Padding(0);
            LbChtMsgBlueA.Name = "LbChtMsgBlueA";
            LbChtMsgBlueA.Size = new Size(13, 15);
            LbChtMsgBlueA.TabIndex = 299;
            LbChtMsgBlueA.Text = "a";
            LbChtMsgBlueA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgBlueG
            // 
            TbxChtMsgBlueG.Location = new Point(381, 3918);
            TbxChtMsgBlueG.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgBlueG.Name = "TbxChtMsgBlueG";
            TbxChtMsgBlueG.Size = new Size(72, 23);
            TbxChtMsgBlueG.TabIndex = 298;
            // 
            // TbxChtMsgBlueR
            // 
            TbxChtMsgBlueR.Location = new Point(291, 3918);
            TbxChtMsgBlueR.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgBlueR.Name = "TbxChtMsgBlueR";
            TbxChtMsgBlueR.Size = new Size(72, 23);
            TbxChtMsgBlueR.TabIndex = 297;
            // 
            // TbxChtMsgBlueA
            // 
            TbxChtMsgBlueA.Location = new Point(201, 3918);
            TbxChtMsgBlueA.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgBlueA.Name = "TbxChtMsgBlueA";
            TbxChtMsgBlueA.Size = new Size(72, 23);
            TbxChtMsgBlueA.TabIndex = 296;
            // 
            // LbSvMsgColorB
            // 
            LbSvMsgColorB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgColorB.AutoSize = true;
            LbSvMsgColorB.Location = new Point(457, 3535);
            LbSvMsgColorB.Margin = new Padding(0);
            LbSvMsgColorB.Name = "LbSvMsgColorB";
            LbSvMsgColorB.Size = new Size(14, 15);
            LbSvMsgColorB.TabIndex = 303;
            LbSvMsgColorB.Text = "b";
            LbSvMsgColorB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxSvMsgColorB
            // 
            TbxSvMsgColorB.Location = new Point(471, 3532);
            TbxSvMsgColorB.Margin = new Padding(0, 3, 0, 3);
            TbxSvMsgColorB.Name = "TbxSvMsgColorB";
            TbxSvMsgColorB.Size = new Size(72, 23);
            TbxSvMsgColorB.TabIndex = 302;
            // 
            // LbChtMsgBlueB
            // 
            this.LbChtMsgBlueB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtMsgBlueB.AutoSize = true;
            this.LbChtMsgBlueB.Location = new Point(457, 3921);
            this.LbChtMsgBlueB.Margin = new Padding(0);
            this.LbChtMsgBlueB.Name = "LbChtMsgBlueB";
            this.LbChtMsgBlueB.Size = new Size(14, 15);
            this.LbChtMsgBlueB.TabIndex = 309;
            this.LbChtMsgBlueB.Text = "b";
            this.LbChtMsgBlueB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgBlueB
            // 
            this.TbxChtMsgBlueB.Location = new Point(471, 3918);
            this.TbxChtMsgBlueB.Margin = new Padding(0, 3, 0, 3);
            this.TbxChtMsgBlueB.Name = "TbxChtMsgBlueB";
            this.TbxChtMsgBlueB.Size = new Size(72, 23);
            this.TbxChtMsgBlueB.TabIndex = 308;
            // 
            // LbChtMsgRedB
            // 
            this.LbChtMsgRedB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtMsgRedB.AutoSize = true;
            this.LbChtMsgRedB.Location = new Point(457, 3894);
            this.LbChtMsgRedB.Margin = new Padding(0);
            this.LbChtMsgRedB.Name = "LbChtMsgRedB";
            this.LbChtMsgRedB.Size = new Size(14, 15);
            this.LbChtMsgRedB.TabIndex = 307;
            this.LbChtMsgRedB.Text = "b";
            this.LbChtMsgRedB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgRedB
            // 
            this.TbxChtMsgRedB.Location = new Point(471, 3891);
            this.TbxChtMsgRedB.Margin = new Padding(0, 3, 0, 3);
            this.TbxChtMsgRedB.Name = "TbxChtMsgRedB";
            this.TbxChtMsgRedB.Size = new Size(72, 23);
            this.TbxChtMsgRedB.TabIndex = 306;
            // 
            // LbChtMsgFfaB
            // 
            LbChtMsgFfaB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgFfaB.AutoSize = true;
            LbChtMsgFfaB.Location = new Point(457, 3867);
            LbChtMsgFfaB.Margin = new Padding(0);
            LbChtMsgFfaB.Name = "LbChtMsgFfaB";
            LbChtMsgFfaB.Size = new Size(14, 15);
            LbChtMsgFfaB.TabIndex = 305;
            LbChtMsgFfaB.Text = "b";
            LbChtMsgFfaB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgFfaB
            // 
            this.TbxChtMsgFfaB.Location = new Point(471, 3864);
            this.TbxChtMsgFfaB.Margin = new Padding(0, 3, 0, 3);
            this.TbxChtMsgFfaB.Name = "TbxChtMsgFfaB";
            this.TbxChtMsgFfaB.Size = new Size(72, 23);
            this.TbxChtMsgFfaB.TabIndex = 304;
            // 
            // LbChtMsgRed
            // 
            this.LbChtMsgRed.AutoSize = true;
            this.LbChtMsgRed.BackColor = SystemColors.ControlLight;
            this.LbChtMsgRed.Location = new Point(8, 28);
            this.LbChtMsgRed.Margin = new Padding(8, 12, 8, 0);
            this.LbChtMsgRed.Name = "LbChtMsgRed";
            this.LbChtMsgRed.Size = new Size(84, 15);
            this.LbChtMsgRed.TabIndex = 310;
            this.LbChtMsgRed.Text = "color red team";
            // 
            // LbChtMsgBlue
            // 
            this.LbChtMsgBlue.AutoSize = true;
            this.LbChtMsgBlue.BackColor = SystemColors.ControlLight;
            this.LbChtMsgBlue.Location = new Point(8, 55);
            this.LbChtMsgBlue.Margin = new Padding(8, 12, 8, 0);
            this.LbChtMsgBlue.Name = "LbChtMsgBlue";
            this.LbChtMsgBlue.Size = new Size(90, 15);
            this.LbChtMsgBlue.TabIndex = 311;
            this.LbChtMsgBlue.Text = "color blue team";
            // 
            // LbChtInColorB
            // 
            this.LbChtInColorB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtInColorB.AutoSize = true;
            this.LbChtInColorB.Location = new Point(457, 4253);
            this.LbChtInColorB.Margin = new Padding(0);
            this.LbChtInColorB.Name = "LbChtInColorB";
            this.LbChtInColorB.Size = new Size(14, 15);
            this.LbChtInColorB.TabIndex = 342;
            this.LbChtInColorB.Text = "b";
            this.LbChtInColorB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtInColorB
            // 
            TbxChtInColorB.Location = new Point(471, 4250);
            TbxChtInColorB.Margin = new Padding(0, 3, 0, 3);
            TbxChtInColorB.Name = "TbxChtInColorB";
            TbxChtInColorB.Size = new Size(72, 23);
            TbxChtInColorB.TabIndex = 341;
            // 
            // TbxChtInOffY
            // 
            TbxChtInOffY.Location = new Point(291, 4277);
            TbxChtInOffY.Margin = new Padding(0, 3, 0, 3);
            TbxChtInOffY.Name = "TbxChtInOffY";
            TbxChtInOffY.Size = new Size(72, 23);
            TbxChtInOffY.TabIndex = 339;
            // 
            // TbxChtInWidth
            // 
            TbxChtInWidth.Location = new Point(201, 4304);
            TbxChtInWidth.Margin = new Padding(0, 3, 0, 3);
            TbxChtInWidth.Name = "TbxChtInWidth";
            TbxChtInWidth.Size = new Size(72, 23);
            TbxChtInWidth.TabIndex = 330;
            // 
            // TbxChtInOffX
            // 
            TbxChtInOffX.Location = new Point(201, 4277);
            TbxChtInOffX.Margin = new Padding(0, 3, 0, 3);
            TbxChtInOffX.Name = "TbxChtInOffX";
            TbxChtInOffX.Size = new Size(72, 23);
            TbxChtInOffX.TabIndex = 329;
            // 
            // LbChtInColorG
            // 
            this.LbChtInColorG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtInColorG.AutoSize = true;
            this.LbChtInColorG.Location = new Point(367, 4253);
            this.LbChtInColorG.Margin = new Padding(0);
            this.LbChtInColorG.Name = "LbChtInColorG";
            this.LbChtInColorG.Size = new Size(14, 15);
            this.LbChtInColorG.TabIndex = 328;
            this.LbChtInColorG.Text = "b";
            this.LbChtInColorG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtInColorR
            // 
            this.LbChtInColorR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtInColorR.AutoSize = true;
            this.LbChtInColorR.Location = new Point(277, 4253);
            this.LbChtInColorR.Margin = new Padding(0);
            this.LbChtInColorR.Name = "LbChtInColorR";
            this.LbChtInColorR.Size = new Size(14, 15);
            this.LbChtInColorR.TabIndex = 327;
            this.LbChtInColorR.Text = "g";
            this.LbChtInColorR.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtInColorA
            // 
            this.LbChtInColorA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtInColorA.AutoSize = true;
            this.LbChtInColorA.Location = new Point(190, 4253);
            this.LbChtInColorA.Margin = new Padding(0);
            this.LbChtInColorA.Name = "LbChtInColorA";
            this.LbChtInColorA.Size = new Size(11, 15);
            this.LbChtInColorA.TabIndex = 326;
            this.LbChtInColorA.Text = "r";
            this.LbChtInColorA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtInColorG
            // 
            this.TbxChtInColorG.Location = new Point(381, 4250);
            this.TbxChtInColorG.Margin = new Padding(0, 3, 0, 3);
            this.TbxChtInColorG.Name = "TbxChtInColorG";
            this.TbxChtInColorG.Size = new Size(72, 23);
            this.TbxChtInColorG.TabIndex = 325;
            // 
            // TbxChtInColorR
            // 
            this.TbxChtInColorR.Location = new Point(291, 4250);
            this.TbxChtInColorR.Margin = new Padding(0, 3, 0, 3);
            this.TbxChtInColorR.Name = "TbxChtInColorR";
            this.TbxChtInColorR.Size = new Size(72, 23);
            this.TbxChtInColorR.TabIndex = 324;
            // 
            // TbxChtInColorA
            // 
            this.TbxChtInColorA.Location = new Point(201, 4250);
            this.TbxChtInColorA.Margin = new Padding(0, 3, 0, 3);
            this.TbxChtInColorA.Name = "TbxChtInColorA";
            this.TbxChtInColorA.Size = new Size(72, 23);
            this.TbxChtInColorA.TabIndex = 323;
            // 
            // LbChtIn
            // 
            this.LbChtIn.AutoSize = true;
            this.LbChtIn.Location = new Point(14, 4226);
            this.LbChtIn.Margin = new Padding(8, 12, 8, 0);
            this.LbChtIn.Name = "LbChtIn";
            this.LbChtIn.Size = new Size(61, 15);
            this.LbChtIn.TabIndex = 322;
            this.LbChtIn.Text = "chat input";
            // 
            // LbChtInFont
            // 
            LbChtInFont.AutoSize = true;
            LbChtInFont.BackColor = SystemColors.ControlLight;
            LbChtInFont.Location = new Point(34, 4361);
            LbChtInFont.Margin = new Padding(8, 12, 8, 0);
            LbChtInFont.Name = "LbChtInFont";
            LbChtInFont.Size = new Size(29, 15);
            LbChtInFont.TabIndex = 315;
            LbChtInFont.Text = "font";
            // 
            // LbChtInAnchor
            // 
            LbChtInAnchor.AutoSize = true;
            LbChtInAnchor.BackColor = SystemColors.ControlLight;
            LbChtInAnchor.Location = new Point(34, 4334);
            LbChtInAnchor.Margin = new Padding(8, 12, 8, 0);
            LbChtInAnchor.Name = "LbChtInAnchor";
            LbChtInAnchor.Size = new Size(44, 15);
            LbChtInAnchor.TabIndex = 314;
            LbChtInAnchor.Text = "anchor";
            // 
            // LbChtInWidth
            // 
            LbChtInWidth.AutoSize = true;
            LbChtInWidth.BackColor = SystemColors.ControlLight;
            LbChtInWidth.Location = new Point(34, 4307);
            LbChtInWidth.Margin = new Padding(8, 12, 8, 0);
            LbChtInWidth.Name = "LbChtInWidth";
            LbChtInWidth.Size = new Size(37, 15);
            LbChtInWidth.TabIndex = 313;
            LbChtInWidth.Text = "width";
            // 
            // LbChtInOff
            // 
            LbChtInOff.AutoSize = true;
            LbChtInOff.BackColor = SystemColors.ControlLight;
            LbChtInOff.Location = new Point(34, 4280);
            LbChtInOff.Margin = new Padding(8, 12, 8, 0);
            LbChtInOff.Name = "LbChtInOff";
            LbChtInOff.Size = new Size(37, 15);
            LbChtInOff.TabIndex = 312;
            LbChtInOff.Text = "offset";
            // 
            // LbChtInColor
            // 
            this.LbChtInColor.AutoSize = true;
            this.LbChtInColor.BackColor = SystemColors.ControlLight;
            this.LbChtInColor.Location = new Point(34, 4253);
            this.LbChtInColor.Margin = new Padding(8, 12, 8, 0);
            this.LbChtInColor.Name = "LbChtInColor";
            this.LbChtInColor.Size = new Size(34, 15);
            this.LbChtInColor.TabIndex = 311;
            this.LbChtInColor.Text = "color";
            // 
            // PnlChtIn
            // 
            PnlChtIn.BackColor = SystemColors.ControlLight;
            PnlChtIn.BorderStyle = BorderStyle.Fixed3D;
            PnlChtIn.Location = new Point(24, 4250);
            PnlChtIn.Margin = new Padding(3, 38, 3, 3);
            PnlChtIn.Name = "PnlChtIn";
            PnlChtIn.Size = new Size(139, 131);
            PnlChtIn.TabIndex = 310;
            // 
            // LbSvMsgOffY
            // 
            LbSvMsgOffY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgOffY.AutoSize = true;
            LbSvMsgOffY.Location = new Point(278, 3562);
            LbSvMsgOffY.Margin = new Padding(0);
            LbSvMsgOffY.Name = "LbSvMsgOffY";
            LbSvMsgOffY.Size = new Size(13, 15);
            LbSvMsgOffY.TabIndex = 344;
            LbSvMsgOffY.Text = "y";
            LbSvMsgOffY.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSvMsgOffX
            // 
            LbSvMsgOffX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgOffX.AutoSize = true;
            LbSvMsgOffX.Location = new Point(188, 3562);
            LbSvMsgOffX.Margin = new Padding(0);
            LbSvMsgOffX.Name = "LbSvMsgOffX";
            LbSvMsgOffX.Size = new Size(13, 15);
            LbSvMsgOffX.TabIndex = 343;
            LbSvMsgOffX.Text = "x";
            LbSvMsgOffX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSvMsgDimY
            // 
            LbSvMsgDimY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgDimY.AutoSize = true;
            LbSvMsgDimY.Location = new Point(278, 3589);
            LbSvMsgDimY.Margin = new Padding(0);
            LbSvMsgDimY.Name = "LbSvMsgDimY";
            LbSvMsgDimY.Size = new Size(13, 15);
            LbSvMsgDimY.TabIndex = 346;
            LbSvMsgDimY.Text = "y";
            LbSvMsgDimY.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbSvMsgDimX
            // 
            LbSvMsgDimX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbSvMsgDimX.AutoSize = true;
            LbSvMsgDimX.Location = new Point(188, 3589);
            LbSvMsgDimX.Margin = new Padding(0);
            LbSvMsgDimX.Name = "LbSvMsgDimX";
            LbSvMsgDimX.Size = new Size(13, 15);
            LbSvMsgDimX.TabIndex = 345;
            LbSvMsgDimX.Text = "x";
            LbSvMsgDimX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgOffY
            // 
            this.LbChtMsgOffY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.LbChtMsgOffY.AutoSize = true;
            this.LbChtMsgOffY.Location = new Point(278, 3948);
            this.LbChtMsgOffY.Margin = new Padding(0);
            this.LbChtMsgOffY.Name = "LbChtMsgOffY";
            this.LbChtMsgOffY.Size = new Size(13, 15);
            this.LbChtMsgOffY.TabIndex = 348;
            this.LbChtMsgOffY.Text = "y";
            this.LbChtMsgOffY.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgOffX
            // 
            LbChtMsgOffX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgOffX.AutoSize = true;
            LbChtMsgOffX.Location = new Point(188, 3948);
            LbChtMsgOffX.Margin = new Padding(0);
            LbChtMsgOffX.Name = "LbChtMsgOffX";
            LbChtMsgOffX.Size = new Size(13, 15);
            LbChtMsgOffX.TabIndex = 347;
            LbChtMsgOffX.Text = "x";
            LbChtMsgOffX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgDimY
            // 
            LbChtMsgDimY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgDimY.AutoSize = true;
            LbChtMsgDimY.Location = new Point(278, 3975);
            LbChtMsgDimY.Margin = new Padding(0);
            LbChtMsgDimY.Name = "LbChtMsgDimY";
            LbChtMsgDimY.Size = new Size(13, 15);
            LbChtMsgDimY.TabIndex = 350;
            LbChtMsgDimY.Text = "y";
            LbChtMsgDimY.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgDimX
            // 
            LbChtMsgDimX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgDimX.AutoSize = true;
            LbChtMsgDimX.Location = new Point(188, 3975);
            LbChtMsgDimX.Margin = new Padding(0);
            LbChtMsgDimX.Name = "LbChtMsgDimX";
            LbChtMsgDimX.Size = new Size(13, 15);
            LbChtMsgDimX.TabIndex = 349;
            LbChtMsgDimX.Text = "x";
            LbChtMsgDimX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComBoxSvMsgAnchor
            // 
            ComBoxSvMsgAnchor.BackColor = SystemColors.ControlLight;
            ComBoxSvMsgAnchor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxSvMsgAnchor.FormattingEnabled = true;
            ComBoxSvMsgAnchor.Items.AddRange(new object[] { "top left", "top right", "center", "bottom left", "bottom right" });
            ComBoxSvMsgAnchor.Location = new Point(201, 3640);
            ComBoxSvMsgAnchor.Name = "ComBoxSvMsgAnchor";
            ComBoxSvMsgAnchor.Size = new Size(162, 23);
            ComBoxSvMsgAnchor.TabIndex = 351;
            // 
            // CbSvMsgCHide
            // 
            CbSvMsgCHide.AutoSize = true;
            CbSvMsgCHide.Location = new Point(180, 3672);
            CbSvMsgCHide.Name = "CbSvMsgCHide";
            CbSvMsgCHide.Size = new Size(15, 14);
            CbSvMsgCHide.TabIndex = 352;
            CbSvMsgCHide.UseVisualStyleBackColor = true;
            // 
            // ComBoxSvMsgFont
            // 
            ComBoxSvMsgFont.BackColor = SystemColors.ControlLight;
            ComBoxSvMsgFont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxSvMsgFont.FormattingEnabled = true;
            ComBoxSvMsgFont.Items.AddRange(new object[] { "smaller", "small", "large", "console", "system" });
            ComBoxSvMsgFont.Location = new Point(201, 3694);
            ComBoxSvMsgFont.Name = "ComBoxSvMsgFont";
            ComBoxSvMsgFont.Size = new Size(118, 23);
            ComBoxSvMsgFont.TabIndex = 353;
            // 
            // ComBoxChtMsgFont
            // 
            ComBoxChtMsgFont.BackColor = SystemColors.ControlLight;
            ComBoxChtMsgFont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxChtMsgFont.FormattingEnabled = true;
            ComBoxChtMsgFont.Items.AddRange(new object[] { "smaller", "small", "large", "console", "system" });
            ComBoxChtMsgFont.Location = new Point(201, 4080);
            ComBoxChtMsgFont.Name = "ComBoxChtMsgFont";
            ComBoxChtMsgFont.Size = new Size(118, 23);
            ComBoxChtMsgFont.TabIndex = 356;
            // 
            // CbChtMsgCHide
            // 
            CbChtMsgCHide.AutoSize = true;
            CbChtMsgCHide.Location = new Point(180, 4058);
            CbChtMsgCHide.Name = "CbChtMsgCHide";
            CbChtMsgCHide.Size = new Size(15, 14);
            CbChtMsgCHide.TabIndex = 355;
            CbChtMsgCHide.UseVisualStyleBackColor = true;
            // 
            // ComBoxChtMsgAnchor
            // 
            ComBoxChtMsgAnchor.BackColor = SystemColors.ControlLight;
            ComBoxChtMsgAnchor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxChtMsgAnchor.FormattingEnabled = true;
            ComBoxChtMsgAnchor.Items.AddRange(new object[] { "top left", "top right", "center", "bottom left", "bottom right" });
            ComBoxChtMsgAnchor.Location = new Point(201, 4026);
            ComBoxChtMsgAnchor.Name = "ComBoxChtMsgAnchor";
            ComBoxChtMsgAnchor.Size = new Size(162, 23);
            ComBoxChtMsgAnchor.TabIndex = 354;
            // 
            // ComBoxChtInFont
            // 
            ComBoxChtInFont.BackColor = SystemColors.ControlLight;
            ComBoxChtInFont.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxChtInFont.FormattingEnabled = true;
            ComBoxChtInFont.Items.AddRange(new object[] { "smaller", "small", "large", "console", "system" });
            ComBoxChtInFont.Location = new Point(201, 4358);
            ComBoxChtInFont.Name = "ComBoxChtInFont";
            ComBoxChtInFont.Size = new Size(118, 23);
            ComBoxChtInFont.TabIndex = 357;
            // 
            // LbChtInOffY
            // 
            LbChtInOffY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtInOffY.AutoSize = true;
            LbChtInOffY.Location = new Point(278, 4280);
            LbChtInOffY.Margin = new Padding(0);
            LbChtInOffY.Name = "LbChtInOffY";
            LbChtInOffY.Size = new Size(13, 15);
            LbChtInOffY.TabIndex = 359;
            LbChtInOffY.Text = "y";
            LbChtInOffY.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtInOffX
            // 
            LbChtInOffX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtInOffX.AutoSize = true;
            LbChtInOffX.Location = new Point(188, 4280);
            LbChtInOffX.Margin = new Padding(0);
            LbChtInOffX.Name = "LbChtInOffX";
            LbChtInOffX.Size = new Size(13, 15);
            LbChtInOffX.TabIndex = 358;
            LbChtInOffX.Text = "x";
            LbChtInOffX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComBoxChtInAnchor
            // 
            ComBoxChtInAnchor.BackColor = SystemColors.ControlLight;
            ComBoxChtInAnchor.DropDownStyle = ComboBoxStyle.DropDownList;
            ComBoxChtInAnchor.FormattingEnabled = true;
            ComBoxChtInAnchor.Items.AddRange(new object[] { "top left", "top right", "center", "bottom left", "bottom right" });
            ComBoxChtInAnchor.Location = new Point(201, 4331);
            ComBoxChtInAnchor.Name = "ComBoxChtInAnchor";
            ComBoxChtInAnchor.Size = new Size(162, 23);
            ComBoxChtInAnchor.TabIndex = 360;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(638, 619);
            Controls.Add(ComBoxChtInAnchor);
            Controls.Add(LbChtInOffY);
            Controls.Add(LbChtInOffX);
            Controls.Add(ComBoxChtInFont);
            Controls.Add(ComBoxChtMsgFont);
            Controls.Add(CbChtMsgCHide);
            Controls.Add(ComBoxChtMsgAnchor);
            Controls.Add(ComBoxSvMsgFont);
            Controls.Add(CbSvMsgCHide);
            Controls.Add(ComBoxSvMsgAnchor);
            Controls.Add(LbChtMsgDimY);
            Controls.Add(LbChtMsgDimX);
            Controls.Add(LbChtMsgOffY);
            Controls.Add(LbChtMsgOffX);
            Controls.Add(LbSvMsgDimY);
            Controls.Add(LbSvMsgDimX);
            Controls.Add(LbSvMsgOffY);
            Controls.Add(LbSvMsgOffX);
            Controls.Add(LbChtInColorB);
            Controls.Add(TbxChtInColorB);
            Controls.Add(TbxChtInOffY);
            Controls.Add(TbxChtInWidth);
            Controls.Add(TbxChtInOffX);
            Controls.Add(LbChtInColorG);
            Controls.Add(LbChtInColorR);
            Controls.Add(LbChtInColorA);
            Controls.Add(TbxChtInColorG);
            Controls.Add(TbxChtInColorR);
            Controls.Add(TbxChtInColorA);
            Controls.Add(LbChtIn);
            Controls.Add(LbChtInFont);
            Controls.Add(LbChtInAnchor);
            Controls.Add(LbChtInWidth);
            Controls.Add(LbChtInOff);
            Controls.Add(LbChtInColor);
            Controls.Add(PnlChtIn);
            Controls.Add(LbChtMsgBlueB);
            Controls.Add(TbxChtMsgBlueB);
            Controls.Add(LbChtMsgRedB);
            Controls.Add(TbxChtMsgRedB);
            Controls.Add(LbChtMsgFfaB);
            Controls.Add(TbxChtMsgFfaB);
            Controls.Add(LbSvMsgColorB);
            Controls.Add(TbxSvMsgColorB);
            Controls.Add(LbChtMsgBlueG);
            Controls.Add(LbChtMsgBlueR);
            Controls.Add(LbChtMsgBlueA);
            Controls.Add(TbxChtMsgBlueG);
            Controls.Add(TbxChtMsgBlueR);
            Controls.Add(TbxChtMsgBlueA);
            Controls.Add(LbChtMsgRedG);
            Controls.Add(LbChtMsgRedR);
            Controls.Add(LbChtMsgRedA);
            Controls.Add(TbxChtMsgRedG);
            Controls.Add(TbxChtMsgRedR);
            Controls.Add(TbxChtMsgRedA);
            Controls.Add(TbxChtMsgDimY);
            Controls.Add(TbxChtMsgOffY);
            Controls.Add(TbxChtMsgLineH);
            Controls.Add(TbxChtMsgFadeTime);
            Controls.Add(TbxChtMsgDisTime);
            Controls.Add(TbxChtMsgAniTime);
            Controls.Add(TbxChtMsgOC);
            Controls.Add(TbxChtMsgDimX);
            Controls.Add(TbxChtMsgOffX);
            Controls.Add(LbChtMsgFfaG);
            Controls.Add(LbChtMsgFfaR);
            Controls.Add(LbChtMsgFfaA);
            Controls.Add(TbxChtMsgFfa);
            Controls.Add(TbxChtMsgFfaR);
            Controls.Add(TbxChtMsgFfaA);
            Controls.Add(LbChtMsg);
            Controls.Add(LbChtMsgFfa);
            Controls.Add(PnlChtMsg);
            Controls.Add(TbxSvMsgDimY);
            Controls.Add(TbxSvMsgOffY);
            Controls.Add(TbxSvMsgLineH);
            Controls.Add(TbxSvMsgFadeTime);
            Controls.Add(TbxSvMsgDisTime);
            Controls.Add(TbxSvMsgAniTime);
            Controls.Add(TbxSvMsgOC);
            Controls.Add(TbxSvMsgDimX);
            Controls.Add(TbxSvMsgOffX);
            Controls.Add(LbSvMsgColorG);
            Controls.Add(LbSvMsgColorR);
            Controls.Add(LbSvMsgColorA);
            Controls.Add(TbxSvMsgColorG);
            Controls.Add(TbxSvMsgColorR);
            Controls.Add(TbxSvMsgColorA);
            Controls.Add(LbSvMsg);
            Controls.Add(LbSvMsgLineH);
            Controls.Add(LbSvMsgFadeTime);
            Controls.Add(LbSvMsgDisTime);
            Controls.Add(LbSvMsgAniTime);
            Controls.Add(LbSvMsgFont);
            Controls.Add(LbSvMsgCHide);
            Controls.Add(LbSvMsgAnchor);
            Controls.Add(LbSvMsgOC);
            Controls.Add(LbSvMsgDim);
            Controls.Add(LbSvMsgOff);
            Controls.Add(LbSvMsgColor);
            Controls.Add(CbAllowRcon);
            Controls.Add(LbAllowRcon);
            Controls.Add(PnlCustomChat);
            Controls.Add(TbxCFadeTime);
            Controls.Add(TbxCFadeStart);
            Controls.Add(LbCFadeStart);
            Controls.Add(TbxXMargin);
            Controls.Add(LbXMargin);
            Controls.Add(TbxLineHeight);
            Controls.Add(LbLineHeight);
            Controls.Add(TbxConsoleSoft);
            Controls.Add(LbConsoleSoft);
            Controls.Add(TbxConsoleBuffer);
            Controls.Add(LbConsoleBuffer);
            Controls.Add(CbScrollback);
            Controls.Add(LbScrollback);
            Controls.Add(TbxControllerConfig);
            Controls.Add(CbCustomCEnabled);
            Controls.Add(LbCustomCEnabled);
            Controls.Add(PnlCustomC);
            Controls.Add(CbControllerEnabled);
            Controls.Add(LbControllerEnabled);
            Controls.Add(PnlController);
            Controls.Add(TbxConsoleSY);
            Controls.Add(TbxConsoleYO);
            Controls.Add(LbConsoleSh);
            Controls.Add(TbxConsoleSX);
            Controls.Add(TbxConsoleXY);
            Controls.Add(TbxConsoleXO);
            Controls.Add(LbConsoleFS);
            Controls.Add(TbxConsoleFS);
            Controls.Add(LbConsoleFW);
            Controls.Add(LbConsoleFF);
            Controls.Add(TbxConsoleFW);
            Controls.Add(CbConsoleFO);
            Controls.Add(TbxConsoleFF);
            Controls.Add(LbConsoleFO);
            Controls.Add(TbxTickerSY);
            Controls.Add(TbxTickerYO);
            Controls.Add(LbTickerSh);
            Controls.Add(TbxTickerSX);
            Controls.Add(LbTickerXY);
            Controls.Add(TbxTickerXO);
            Controls.Add(LbTickerFS);
            Controls.Add(TbxTickerFS);
            Controls.Add(LbTickerFW);
            Controls.Add(LbTickerFF);
            Controls.Add(TbxTickerFW);
            Controls.Add(CbTickerFO);
            Controls.Add(TbxTickerFF);
            Controls.Add(LbTickerFO);
            Controls.Add(TbxSmallerSY);
            Controls.Add(TbxSmallerYO);
            Controls.Add(LbSmallerSh);
            Controls.Add(TbxSmallerSX);
            Controls.Add(LbSmallerXY);
            Controls.Add(TbxSmallerXO);
            Controls.Add(LbSmallerFS);
            Controls.Add(TbxSmallerFS);
            Controls.Add(LbSmallerFW);
            Controls.Add(LbSmallerFF);
            Controls.Add(TbxSmallerFW);
            Controls.Add(CbSmallerFO);
            Controls.Add(TbxSmallerFF);
            Controls.Add(LbSmallerFO);
            Controls.Add(TbxSmallSY);
            Controls.Add(TbxSmallYO);
            Controls.Add(LbSmallSh);
            Controls.Add(TbxSmallSX);
            Controls.Add(label15);
            Controls.Add(TbxSmallXO);
            Controls.Add(LbSmallFS);
            Controls.Add(TbxSmallFS);
            Controls.Add(LbSmallFW);
            Controls.Add(LbSmallFF);
            Controls.Add(TbxSmallFW);
            Controls.Add(CbSmallFO);
            Controls.Add(TbxSmallFF);
            Controls.Add(LbSmallFO);
            Controls.Add(TbxLargeSY);
            Controls.Add(TbxLargeYO);
            Controls.Add(LbLargeSh);
            Controls.Add(TbxLargeSX);
            Controls.Add(LbLargeXY);
            Controls.Add(TbxLargeXO);
            Controls.Add(LbLargeFS);
            Controls.Add(TbxLargeFS);
            Controls.Add(LbLargeFW);
            Controls.Add(LbLargeFF);
            Controls.Add(TbxLargeFW);
            Controls.Add(CbLargeFO);
            Controls.Add(TbxLargeFF);
            Controls.Add(LbLargeFO);
            Controls.Add(TbxSystemSY);
            Controls.Add(TbxSystemYO);
            Controls.Add(TbxSystemSh);
            Controls.Add(TbxSystemSX);
            Controls.Add(LbSystemXY);
            Controls.Add(TbxSystemXO);
            Controls.Add(LbSystemFS);
            Controls.Add(TbxSystemFS);
            Controls.Add(LbSystemFW);
            Controls.Add(LbSystemFF);
            Controls.Add(TbxSystemFW);
            Controls.Add(CbSystemFO);
            Controls.Add(TbxSystemFF);
            Controls.Add(LbSystemFO);
            Controls.Add(CbFontOverEnabled);
            Controls.Add(LbFontOverEnabled);
            Controls.Add(PnlFontOver);
            Controls.Add(CbDownloadRetail);
            Controls.Add(LbDownloadRetail);
            Controls.Add(TbxDownloadUrl);
            Controls.Add(LbDownloadUrl);
            Controls.Add(ComBoxDownloadFont);
            Controls.Add(LbDownloadFont);
            Controls.Add(CbBenchmark);
            Controls.Add(LbBenchmark);
            Controls.Add(CbMapSize);
            Controls.Add(TbxMapSize);
            Controls.Add(LbMapSize);
            Controls.Add(CbMapMmryBuffer);
            Controls.Add(LbMapMmryBuffer);
            Controls.Add(PnlMemory);
            Controls.Add(CbMstrSvNatS);
            Controls.Add(TbxMstrSvNatS);
            Controls.Add(LbMstrSvNatS);
            Controls.Add(CbMstrSvNatP);
            Controls.Add(TbxMstrSvNatP);
            Controls.Add(LbMstrSvNatP);
            Controls.Add(CbMstrSvKey);
            Controls.Add(TbxMstrSvKey);
            Controls.Add(LbMstrSvKey);
            Controls.Add(CbMstrSvList);
            Controls.Add(TbxMstrSvList);
            Controls.Add(LbMstrSvList);
            Controls.Add(CbAutoQuery);
            Controls.Add(LbAutoQuery);
            Controls.Add(PnlServerList);
            Controls.Add(ComBoxNameFont);
            Controls.Add(ComBoxScoreboardFont);
            Controls.Add(LbNameFont);
            Controls.Add(PnlNameSet);
            Controls.Add(TbxScoreboardFade);
            Controls.Add(LbScoreboardFade);
            Controls.Add(LbScoreboardFont);
            Controls.Add(PnlScoreboard);
            Controls.Add(CbBorderless);
            Controls.Add(LbBorderless);
            Controls.Add(CbWindowed);
            Controls.Add(LbWindowed);
            Controls.Add(CbVsync);
            Controls.Add(TbxVsync);
            Controls.Add(LbVsync);
            Controls.Add(CbRefRate);
            Controls.Add(TbxRefRate);
            Controls.Add(LbRefRate);
            Controls.Add(LbResHeight);
            Controls.Add(LbResWidth);
            Controls.Add(TbxResHeight);
            Controls.Add(CbResolution);
            Controls.Add(TbxResWidth);
            Controls.Add(LbResolution);
            Controls.Add(CbEnblVideoMode);
            Controls.Add(LbEnblVideoMode);
            Controls.Add(panel2);
            Controls.Add(PnlVideoMode);
            Controls.Add(CbShowSeg);
            Controls.Add(LbShowSeg);
            Controls.Add(CbSupFatal);
            Controls.Add(LbSupFatal);
            Controls.Add(PnlErrorHand);
            Controls.Add(CbHash);
            Controls.Add(TbxHash);
            Controls.Add(LbHash);
            Controls.Add(CbMultiInst);
            Controls.Add(LbMultiInst);
            Controls.Add(CbBackPlay);
            Controls.Add(LbBackPlay);
            Controls.Add(CbMenuMusic);
            Controls.Add(LbMenuMusic);
            Controls.Add(CbOptiDef);
            Controls.Add(LbOptiDef);
            Controls.Add(CbConsole);
            Controls.Add(LbConsole);
            Controls.Add(CbIntroVideos);
            Controls.Add(LbIntroVideos);
            Controls.Add(LbClientPort);
            Controls.Add(LbServerPort);
            Controls.Add(TbxClientPort);
            Controls.Add(CbGamePorts);
            Controls.Add(TbxServerPort);
            Controls.Add(LbGamePorts);
            Controls.Add(CbExec);
            Controls.Add(BtnExec);
            Controls.Add(TbxExec);
            Controls.Add(LbExec);
            Controls.Add(CbMapsPath);
            Controls.Add(BtnMapsPath);
            Controls.Add(TbxMapsPath);
            Controls.Add(LbMapsPath);
            Controls.Add(CbDownPath);
            Controls.Add(BtnDownPath);
            Controls.Add(TbxDownPath);
            Controls.Add(LbDownPath);
            Controls.Add(CbPath);
            Controls.Add(BtnPath);
            Controls.Add(TbxPath);
            Controls.Add(LbPath);
            Controls.Add(VSBEditor);
            Controls.Add(PnlHalo);
            Controls.Add(PnlSvMsg);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            PnlHalo.ResumeLayout(false);
            PnlHalo.PerformLayout();
            PnlErrorHand.ResumeLayout(false);
            PnlErrorHand.PerformLayout();
            PnlVideoMode.ResumeLayout(false);
            PnlVideoMode.PerformLayout();
            PnlScoreboard.ResumeLayout(false);
            PnlScoreboard.PerformLayout();
            PnlNameSet.ResumeLayout(false);
            PnlNameSet.PerformLayout();
            PnlServerList.ResumeLayout(false);
            PnlServerList.PerformLayout();
            PnlMemory.ResumeLayout(false);
            PnlMemory.PerformLayout();
            PnlFontOver.ResumeLayout(false);
            PnlFontOver.PerformLayout();
            PnlController.ResumeLayout(false);
            PnlController.PerformLayout();
            PnlCustomC.ResumeLayout(false);
            PnlCustomC.PerformLayout();
            PnlCustomChat.ResumeLayout(false);
            PnlCustomChat.PerformLayout();
            PnlChtMsg.ResumeLayout(false);
            PnlChtMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlHalo;
        private Label LbHalo;
        private VScrollBar VSBEditor;
        private Label LbHaloDesc;
        private Label LbPath;
        private TextBox TbxPath;
        private Button BtnPath;
        private CheckBox CbPath;
        private CheckBox CbDownPath;
        private Button BtnDownPath;
        private TextBox TbxDownPath;
        private Label LbDownPath;
        private CheckBox CbMapsPath;
        private Button BtnMapsPath;
        private TextBox TbxMapsPath;
        private Label LbMapsPath;
        private CheckBox CbExec;
        private Button BtnExec;
        private TextBox TbxExec;
        private Label LbExec;
        private CheckBox CbGamePorts;
        private TextBox TbxServerPort;
        private Label LbGamePorts;
        private TextBox TbxClientPort;
        private Label LbServerPort;
        private Label LbClientPort;
        private CheckBox CbIntroVideos;
        private Label LbIntroVideos;
        private CheckBox CbConsole;
        private Label LbConsole;
        private CheckBox CbOptiDef;
        private Label LbOptiDef;
        private CheckBox CbMenuMusic;
        private Label LbMenuMusic;
        private CheckBox CbBackPlay;
        private Label LbBackPlay;
        private CheckBox CbMultiInst;
        private Label LbMultiInst;
        private CheckBox CbHash;
        private TextBox TbxHash;
        private Label LbHash;
        private Panel PnlErrorHand;
        private Label LbErrorHandDesc;
        private Label LbErrorHand;
        private CheckBox CbShowSeg;
        private Label LbShowSeg;
        private CheckBox CbSupFatal;
        private Label LbSupFatal;
        private Panel PnlVideoMode;
        private Label LbVideoModeDesc;
        private Label LbVideoMode;
        private Panel panel2;
        private CheckBox CbEnblVideoMode;
        private Label LbEnblVideoMode;
        private Label LbResHeight;
        private Label LbResWidth;
        private TextBox TbxResHeight;
        private CheckBox CbResolution;
        private TextBox TbxResWidth;
        private Label LbResolution;
        private CheckBox CbRefRate;
        private TextBox TbxRefRate;
        private Label LbRefRate;
        private CheckBox CbVsync;
        private TextBox TbxVsync;
        private Label LbVsync;
        private CheckBox CbWindowed;
        private Label LbWindowed;
        private CheckBox CbBorderless;
        private Label LbBorderless;
        private Panel PnlScoreboard;
        private Label LbScoreboardDesc;
        private Label LbScoreboard;
        private CheckBox CbAutoQuery;
        private Label LbServerListDesc;
        private TextBox TbxMstrSvList;
        private Label LbServerList;
        private Label LbScoreboardFont;
        private TextBox TbxScoreboardFade;
        private Label LbScoreboardFade;
        private Panel PnlNameSet;
        private Label LbNameSetDesc;
        private Label LbNameSet;
        private Label LbNameFont;
        private ComboBox ComBoxScoreboardFont;
        private ComboBox ComBoxNameFont;
        private Panel PnlServerList;
        private Label LbAutoQuery;
        private CheckBox CbMstrSvList;
        private Label LbMstrSvList;
        private CheckBox CbMstrSvKey;
        private TextBox TbxMstrSvKey;
        private Label LbMstrSvKey;
        private CheckBox CbMstrSvNatP;
        private TextBox TbxMstrSvNatP;
        private Label LbMstrSvNatP;
        private CheckBox CbMstrSvNatS;
        private TextBox TbxMstrSvNatS;
        private Label LbMstrSvNatS;
        private Panel PnlMemory;
        private Label LbMemoryDesc;
        private Label LbMemory;
        private CheckBox CbMapSize;
        private TextBox TbxMapSize;
        private Label LbMapSize;
        private CheckBox CbMapMmryBuffer;
        private Label LbMapMmryBuffer;
        private CheckBox CbBenchmark;
        private Label LbBenchmark;
        private ComboBox ComBoxDownloadFont;
        private Label LbDownloadFont;
        private TextBox TbxDownloadUrl;
        private Label LbDownloadUrl;
        private CheckBox CbDownloadRetail;
        private Label LbDownloadRetail;
        private Panel PnlFontOver;
        private Label LbFontOverDesc;
        private Label LbFontOver;
        private CheckBox CbFontOverEnabled;
        private Label LbFontOverEnabled;
        private Label LbSystemFW;
        private Label LbSystemFF;
        private TextBox TbxSystemFW;
        private CheckBox CbSystemFO;
        private TextBox TbxSystemFF;
        private Label LbSystemFO;
        private Label LbSystemFS;
        private TextBox TbxSystemFS;
        private Label LbSystemXY;
        private TextBox TbxSystemXO;
        private Label TbxSystemSh;
        private TextBox TbxSystemSX;
        private TextBox TbxSystemSY;
        private TextBox TbxSystemYO;
        private TextBox TbxLargeSY;
        private TextBox TbxLargeYO;
        private Label LbLargeSh;
        private TextBox TbxLargeSX;
        private Label LbLargeXY;
        private TextBox TbxLargeXO;
        private Label LbLargeFS;
        private TextBox TbxLargeFS;
        private Label LbLargeFW;
        private Label LbLargeFF;
        private TextBox TbxLargeFW;
        private CheckBox CbLargeFO;
        private TextBox TbxLargeFF;
        private Label LbLargeFO;
        private TextBox TbxSmallSY;
        private TextBox TbxSmallYO;
        private Label LbSmallSh;
        private TextBox TbxSmallSX;
        private Label label15;
        private TextBox TbxSmallXO;
        private Label LbSmallFS;
        private TextBox TbxSmallFS;
        private Label LbSmallFW;
        private Label LbSmallFF;
        private TextBox TbxSmallFW;
        private CheckBox CbSmallFO;
        private TextBox TbxSmallFF;
        private Label LbSmallFO;
        private TextBox TbxSmallerSY;
        private TextBox TbxSmallerYO;
        private Label LbSmallerSh;
        private TextBox TbxSmallerSX;
        private Label LbSmallerXY;
        private TextBox TbxSmallerXO;
        private Label LbSmallerFS;
        private TextBox TbxSmallerFS;
        private Label LbSmallerFW;
        private Label LbSmallerFF;
        private TextBox TbxSmallerFW;
        private CheckBox CbSmallerFO;
        private TextBox TbxSmallerFF;
        private Label LbSmallerFO;
        private TextBox TbxTickerSY;
        private TextBox TbxTickerYO;
        private Label LbTickerSh;
        private TextBox TbxTickerSX;
        private Label LbTickerXY;
        private TextBox TbxTickerXO;
        private Label LbTickerFS;
        private TextBox TbxTickerFS;
        private Label LbTickerFW;
        private Label LbTickerFF;
        private TextBox TbxTickerFW;
        private CheckBox CbTickerFO;
        private TextBox TbxTickerFF;
        private Label LbTickerFO;
        private TextBox TbxConsoleSY;
        private TextBox TbxConsoleYO;
        private Label LbConsoleSh;
        private TextBox TbxConsoleSX;
        private Label TbxConsoleXY;
        private TextBox TbxConsoleXO;
        private Label LbConsoleFS;
        private TextBox TbxConsoleFS;
        private Label LbConsoleFW;
        private Label LbConsoleFF;
        private TextBox TbxConsoleFW;
        private CheckBox CbConsoleFO;
        private TextBox TbxConsoleFF;
        private Label LbConsoleFO;
        private CheckBox CbControllerEnabled;
        private Label LbControllerEnabled;
        private Panel PnlController;
        private Label LbControllerDesc;
        private Label LbController;
        private CheckBox CbCustomCEnabled;
        private Label LbCustomCEnabled;
        private Panel PnlCustomC;
        private Label LbCustomCDesc;
        private Label LbCustomC;
        private TextBox TbxControllerConfig;
        private CheckBox CbScrollback;
        private Label LbScrollback;
        private TextBox TbxConsoleBuffer;
        private Label LbConsoleBuffer;
        private TextBox TbxConsoleSoft;
        private Label LbConsoleSoft;
        private TextBox TbxLineHeight;
        private Label LbLineHeight;
        private TextBox TbxXMargin;
        private Label LbXMargin;
        private TextBox TbxCFadeStart;
        private Label LbCFadeStart;
        private TextBox TbxCFadeTime;
        private Panel PnlCustomChat;
        private Label LbCustomChatDesc;
        private Label LbCustomChat;
        private CheckBox CbAllowRcon;
        private Label LbAllowRcon;
        private Label LbSvMsgColor;
        private Label LbSvMsgOff;
        private Label LbSvMsgDim;
        private Label LbSvMsgOC;
        private Label LbSvMsgAnchor;
        private Label LbSvMsgCHide;
        private Label LbSvMsgFont;
        private Label LbSvMsgAniTime;
        private Label LbSvMsgDisTime;
        private Label LbSvMsgFadeTime;
        private Label LbSvMsgLineH;
        private Label LbSvMsg;
        private TextBox TbxSvMsgColorA;
        private TextBox TbxSvMsgColorR;
        private TextBox TbxSvMsgColorG;
        private Label LbSvMsgColorA;
        private Label LbSvMsgColorR;
        private Label LbSvMsgColorG;
        private TextBox TbxSvMsgOffX;
        private TextBox TbxSvMsgDimX;
        private TextBox TbxSvMsgOC;
        private TextBox TbxSvMsgAniTime;
        private TextBox TbxSvMsgDisTime;
        private TextBox TbxSvMsgFadeTime;
        private TextBox TbxSvMsgLineH;
        private Panel PnlSvMsg;
        private TextBox TbxSvMsgOffY;
        private TextBox TbxSvMsgDimY;
        private TextBox TbxChtMsgDimY;
        private TextBox textBox17;
        private TextBox TbxChtMsgLineH;
        private TextBox TbxChtMsgFadeTime;
        private TextBox TbxChtMsgDisTime;
        private TextBox TbxChtMsgAniTime;
        private TextBox textBox24;
        private TextBox TbxChtMsgOC;
        private TextBox TbxChtMsgDimX;
        private TextBox textBox27;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox TbxChtMsgFfa;
        private TextBox textBox29;
        private TextBox textBox30;
        private Label LbChtMsg;
        private Label LbChtMsgLineH;
        private Label LbChtMsgFadeTime;
        private Label LbChtMsgDisTime;
        private Label LbChtMsgAniTime;
        private Label LbChtMsgFont;
        private Label LbChtMsgCHide;
        private Label LbChtMsgAnchor;
        private Label LbChtMsgOC;
        private Label LbChtMsgDim;
        private Label label33;
        private Label LbChtMsgFfa;
        private Panel PnlChtMsg;
        private Label label36;
        private Label label37;
        private Label label38;
        private TextBox textBox31;
        private TextBox textBox32;
        private TextBox textBox33;
        private Label label39;
        private Label label40;
        private Label label41;
        private TextBox textBox34;
        private TextBox textBox35;
        private TextBox textBox36;
        private Label LbSvMsgColorB;
        private TextBox TbxSvMsgColorB;
        private Label label43;
        private TextBox textBox38;
        private Label label44;
        private TextBox textBox39;
        private Label LbChtMsgFfaB;
        private TextBox textBox40;
        private Label label47;
        private Label label46;
        private Label label35;
        private TextBox TbxChtInColorB;
        private TextBox textBox42;
        private TextBox TbxChtInOffY;
        private TextBox textBox50;
        private TextBox TbxChtInWidth;
        private TextBox TbxChtInOffX;
        private Label label48;
        private Label label49;
        private Label label50;
        private TextBox textBox54;
        private TextBox textBox55;
        private TextBox textBox56;
        private Label label51;
        private Label LbChtInFont;
        private Label LbChtInAnchor;
        private Label LbChtInWidth;
        private Label LbChtInOff;
        private Label label62;
        private Panel PnlChtIn;
        private Label LbSvMsgOffY;
        private Label LbSvMsgOffX;
        private Label LbSvMsgDimY;
        private Label LbSvMsgDimX;
        private Label label3;
        private Label LbChtMsgOffX;
        private Label LbChtMsgDimY;
        private Label LbChtMsgDimX;
        private ComboBox ComBoxSvMsgAnchor;
        private CheckBox CbSvMsgCHide;
        private ComboBox ComBoxSvMsgFont;
        private ComboBox ComBoxChtMsgFont;
        private CheckBox CbChtMsgCHide;
        private ComboBox ComBoxChtMsgAnchor;
        private ComboBox ComBoxChtInFont;
        private Label LbChtInOffY;
        private Label LbChtInOffX;
        private ComboBox ComBoxChtInAnchor;
        private Label LbChtMsgOff;
        private Label LbChtMsgRedG;
        private Label LbChtMsgRedR;
        private Label LbChtMsgRedA;
        private TextBox TbxChtMsgRedG;
        private TextBox TbxChtMsgRedR;
        private TextBox TbxChtMsgRedA;
        private Label LbChtMsgBlueG;
        private Label LbChtMsgBlueR;
        private Label LbChtMsgBlueA;
        private TextBox TbxChtMsgBlueG;
        private TextBox TbxChtMsgBlueR;
        private TextBox TbxChtMsgBlueA;
        private Label LbChtMsgBlueB;
        private TextBox TbxChtMsgBlueB;
        private Label LbChtMsgRedB;
        private TextBox TbxChtMsgRedB;
        private TextBox TbxChtMsgFfaB;
        private Label LbChtMsgRed;
        private Label LbChtMsgBlue;
        private Label LbChtInColorB;
        private Label LbChtInColorG;
        private Label LbChtInColorR;
        private Label LbChtInColorA;
        private TextBox TbxChtInColorG;
        private TextBox TbxChtInColorR;
        private TextBox TbxChtInColorA;
        private Label LbChtIn;
        private Label LbChtInColor;
        private Label LbChtMsgOffY;
        private TextBox TbxChtMsgOffY;
        private TextBox TbxChtMsgOffX;
        private Label LbChtMsgFfaG;
        private Label LbChtMsgFfaR;
        private Label LbChtMsgFfaA;
        private TextBox TbxChtMsgFfaR;
        private TextBox TbxChtMsgFfaA;
    }
}