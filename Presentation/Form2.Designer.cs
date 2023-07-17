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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            PnlHalo = new Panel();
            LbHaloDesc = new Label();
            LbHalo = new Label();
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
            PnlEnd = new Panel();
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
            LbChtMsgBlue = new Label();
            LbChtMsgRed = new Label();
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
            PnlHotkey = new Panel();
            LbHotKeyDesc = new Label();
            LbHotKey = new Label();
            CbHotKeyEnabled = new CheckBox();
            LbHotKeyEnabled = new Label();
            TbxHKF3 = new TextBox();
            LbHKF3 = new Label();
            TbxHKF2 = new TextBox();
            LbHKF2 = new Label();
            TbxHKF1 = new TextBox();
            LbHKF1 = new Label();
            LbHotKeyFunction = new Label();
            TbxHKF6 = new TextBox();
            LbHKF6 = new Label();
            TbxHKF5 = new TextBox();
            LbHKF5 = new Label();
            TbxHKF4 = new TextBox();
            LbHKF4 = new Label();
            TbxHKF9 = new TextBox();
            LbHKF9 = new Label();
            TbxHKF8 = new TextBox();
            LbHKF8 = new Label();
            TbxHKF7 = new TextBox();
            LbHKF7 = new Label();
            TbxHKF12 = new TextBox();
            LbHKF12 = new Label();
            TbxHKF11 = new TextBox();
            LbHKF11 = new Label();
            TbxHKF10 = new TextBox();
            LbHKF10 = new Label();
            LbHotKeyAltShift = new Label();
            TbxHKAS0 = new TextBox();
            LbHKAS0 = new Label();
            TbxHKAS9 = new TextBox();
            LbHKAS9 = new Label();
            TbxHKAS8 = new TextBox();
            LbHKAS8 = new Label();
            TbxHKAS7 = new TextBox();
            LbHKAS7 = new Label();
            TbxHKAS6 = new TextBox();
            LbHKAS6 = new Label();
            TbxHKAS5 = new TextBox();
            LbHKAS5 = new Label();
            TbxHKAS4 = new TextBox();
            LbHKAS4 = new Label();
            TbxHKAS3 = new TextBox();
            LbHKAS3 = new Label();
            TbxHKAS2 = new TextBox();
            LbHKAS2 = new Label();
            TbxHKAS1 = new TextBox();
            LbHKAS1 = new Label();
            TbxHKASN0 = new TextBox();
            LbHKASN0 = new Label();
            TbxHKASN9 = new TextBox();
            LbHKASN9 = new Label();
            TbxHKASN8 = new TextBox();
            LbHKASN8 = new Label();
            TbxHKASN7 = new TextBox();
            LbHKASN7 = new Label();
            TbxHKASN6 = new TextBox();
            LbHKASN6 = new Label();
            TbxHKASN5 = new TextBox();
            LbHKASN5 = new Label();
            TbxHKASN4 = new TextBox();
            LbHKASN4 = new Label();
            TbxHKASN3 = new TextBox();
            LbHKASN3 = new Label();
            TbxHKASN2 = new TextBox();
            LbHKASN2 = new Label();
            TbxHKASN1 = new TextBox();
            LbHKASN1 = new Label();
            LbHotKeyAltShiftNum = new Label();
            TbxHkA0 = new TextBox();
            LbHkA0 = new Label();
            TbxHkA9 = new TextBox();
            LbHkA9 = new Label();
            TbxHkA8 = new TextBox();
            LbHkA8 = new Label();
            TbxHkA7 = new TextBox();
            LbHkA7 = new Label();
            TbxHkA6 = new TextBox();
            LbHkA6 = new Label();
            TbxHkA5 = new TextBox();
            LbHkA5 = new Label();
            TbxHkA4 = new TextBox();
            LbHkA4 = new Label();
            TbxHkA3 = new TextBox();
            LbHkA3 = new Label();
            TbxHkA2 = new TextBox();
            LbHkA2 = new Label();
            TbxHkA1 = new TextBox();
            LbHkA1 = new Label();
            LbHotKeyAlt = new Label();
            TbxHkC0 = new TextBox();
            LbHkC0 = new Label();
            TbxHkC9 = new TextBox();
            LbHkC9 = new Label();
            TbxHkC8 = new TextBox();
            LbHkC8 = new Label();
            TbxHkC7 = new TextBox();
            LbHkC7 = new Label();
            TbxHkC6 = new TextBox();
            LbHkC6 = new Label();
            TbxHkC5 = new TextBox();
            LbHkC5 = new Label();
            TbxHkC4 = new TextBox();
            LbHkC4 = new Label();
            TbxHkC3 = new TextBox();
            LbHkC3 = new Label();
            TbxHkC2 = new TextBox();
            LbHkC2 = new Label();
            TbxHkC1 = new TextBox();
            LbHkC1 = new Label();
            LbHotKeyCtrl = new Label();
            TbxHKCN0 = new TextBox();
            LbHkCN0 = new Label();
            TbxHKCN9 = new TextBox();
            LbHkCN9 = new Label();
            TbxHKCN8 = new TextBox();
            LbHkCN8 = new Label();
            TbxHKCN7 = new TextBox();
            LbHkCN = new Label();
            TbxHKCN6 = new TextBox();
            LbHkCN6 = new Label();
            TbxHKCN5 = new TextBox();
            LbHkCN5 = new Label();
            TbxHKCN4 = new TextBox();
            LbHkCN4 = new Label();
            TbxHKCN3 = new TextBox();
            LbHkCN3 = new Label();
            TbxHKCN2 = new TextBox();
            LbHkCN2 = new Label();
            TbxHKCN1 = new TextBox();
            LbHkCN1 = new Label();
            LbHotKeyCtrlNum = new Label();
            TbxHkCAS0 = new TextBox();
            LbHkCAS0 = new Label();
            TbxHkCAS9 = new TextBox();
            LbHkCAS9 = new Label();
            TbxHkCAS8 = new TextBox();
            LbHkCAS8 = new Label();
            TbxHkCAS7 = new TextBox();
            LbHkCAS7 = new Label();
            TbxHkCAS6 = new TextBox();
            LbHkCAS6 = new Label();
            TbxHkCAS5 = new TextBox();
            LbHkCAS5 = new Label();
            TbxHkCAS4 = new TextBox();
            LbHkCAS4 = new Label();
            TbxHkCAS3 = new TextBox();
            LbHkCAS3 = new Label();
            TbxHkCAS2 = new TextBox();
            LbHkCAS2 = new Label();
            TbxHkCAS1 = new TextBox();
            LbHkCAS1 = new Label();
            LbHotKeyCtrlAltShift = new Label();
            TbxHkCASN0 = new TextBox();
            LbHkCASN0 = new Label();
            TbxHkCASN9 = new TextBox();
            LbHkCASN9 = new Label();
            TbxHkCASN8 = new TextBox();
            LbHkCASN8 = new Label();
            TbxHkCASN7 = new TextBox();
            LbHkCASN7 = new Label();
            TbxHkCASN6 = new TextBox();
            LbHkCASN6 = new Label();
            TbxHkCASN5 = new TextBox();
            LbHkCASN5 = new Label();
            TbxHkCASN4 = new TextBox();
            LbHkCASN4 = new Label();
            TbxHkCASN3 = new TextBox();
            LbHkCASN3 = new Label();
            TbxHkCASN2 = new TextBox();
            LbHkCASN2 = new Label();
            TbxHkCASN1 = new TextBox();
            LbHkCASN1 = new Label();
            LbHotKeyCtrlAltShiftNum = new Label();
            TbxHkAN0 = new TextBox();
            LbHkAN0 = new Label();
            TbxHkAN9 = new TextBox();
            LbHkAN9 = new Label();
            TbxHkAN8 = new TextBox();
            LbHkAN8 = new Label();
            TbxHkAN7 = new TextBox();
            LbHkAN7 = new Label();
            TbxHkAN6 = new TextBox();
            LbHkAN6 = new Label();
            TbxHkAN5 = new TextBox();
            LbHkAN5 = new Label();
            TbxHkAN4 = new TextBox();
            LbHkAN4 = new Label();
            TbxHkAN3 = new TextBox();
            LbHkAN3 = new Label();
            TbxHkAN2 = new TextBox();
            LbHkAN2 = new Label();
            TbxHkAN1 = new TextBox();
            LbHkAN1 = new Label();
            LbHotKeyAltNum = new Label();
            BtnCCColor = new Button();
            BtnCMFfaColor = new Button();
            BtnCMRedColor = new Button();
            BtnCMBlueColor = new Button();
            BtnCIColor = new Button();
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
            PnlHotkey.SuspendLayout();
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
            // PnlEnd
            // 
            PnlEnd.BackColor = SystemColors.ControlLight;
            PnlEnd.BorderStyle = BorderStyle.Fixed3D;
            PnlEnd.Location = new Point(36, 7271);
            PnlEnd.Margin = new Padding(3, 38, 3, 3);
            PnlEnd.Name = "PnlEnd";
            PnlEnd.Size = new Size(543, 63);
            PnlEnd.TabIndex = 4;
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
            LbSvMsgColorA.Location = new Point(-33, 3535);
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
            LbSvMsgColorR.Location = new Point(59, 3535);
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
            LbSvMsgColorG.Location = new Point(146, 3535);
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
            LbChtMsgFfaG.Location = new Point(146, 3867);
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
            LbChtMsgFfaR.Location = new Point(59, 3867);
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
            LbChtMsgFfaA.Location = new Point(-33, 3867);
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
            PnlChtMsg.Controls.Add(LbChtMsgBlue);
            PnlChtMsg.Controls.Add(LbChtMsgRed);
            PnlChtMsg.Controls.Add(LbChtMsgOff);
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
            // LbChtMsgBlue
            // 
            LbChtMsgBlue.AutoSize = true;
            LbChtMsgBlue.BackColor = SystemColors.ControlLight;
            LbChtMsgBlue.Location = new Point(8, 55);
            LbChtMsgBlue.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgBlue.Name = "LbChtMsgBlue";
            LbChtMsgBlue.Size = new Size(90, 15);
            LbChtMsgBlue.TabIndex = 311;
            LbChtMsgBlue.Text = "color blue team";
            // 
            // LbChtMsgRed
            // 
            LbChtMsgRed.AutoSize = true;
            LbChtMsgRed.BackColor = SystemColors.ControlLight;
            LbChtMsgRed.Location = new Point(8, 28);
            LbChtMsgRed.Margin = new Padding(8, 12, 8, 0);
            LbChtMsgRed.Name = "LbChtMsgRed";
            LbChtMsgRed.Size = new Size(84, 15);
            LbChtMsgRed.TabIndex = 310;
            LbChtMsgRed.Text = "color red team";
            // 
            // LbChtMsgRedG
            // 
            LbChtMsgRedG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgRedG.AutoSize = true;
            LbChtMsgRedG.Location = new Point(146, 3894);
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
            LbChtMsgRedR.Location = new Point(59, 3894);
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
            LbChtMsgRedA.Location = new Point(-33, 3894);
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
            LbChtMsgBlueG.Location = new Point(146, 3921);
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
            LbChtMsgBlueR.Location = new Point(59, 3921);
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
            LbChtMsgBlueA.Location = new Point(-33, 3921);
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
            LbSvMsgColorB.Location = new Point(236, 3535);
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
            LbChtMsgBlueB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgBlueB.AutoSize = true;
            LbChtMsgBlueB.Location = new Point(236, 3921);
            LbChtMsgBlueB.Margin = new Padding(0);
            LbChtMsgBlueB.Name = "LbChtMsgBlueB";
            LbChtMsgBlueB.Size = new Size(14, 15);
            LbChtMsgBlueB.TabIndex = 309;
            LbChtMsgBlueB.Text = "b";
            LbChtMsgBlueB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgBlueB
            // 
            TbxChtMsgBlueB.Location = new Point(471, 3918);
            TbxChtMsgBlueB.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgBlueB.Name = "TbxChtMsgBlueB";
            TbxChtMsgBlueB.Size = new Size(72, 23);
            TbxChtMsgBlueB.TabIndex = 308;
            // 
            // LbChtMsgRedB
            // 
            LbChtMsgRedB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgRedB.AutoSize = true;
            LbChtMsgRedB.Location = new Point(236, 3894);
            LbChtMsgRedB.Margin = new Padding(0);
            LbChtMsgRedB.Name = "LbChtMsgRedB";
            LbChtMsgRedB.Size = new Size(14, 15);
            LbChtMsgRedB.TabIndex = 307;
            LbChtMsgRedB.Text = "b";
            LbChtMsgRedB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgRedB
            // 
            TbxChtMsgRedB.Location = new Point(471, 3891);
            TbxChtMsgRedB.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgRedB.Name = "TbxChtMsgRedB";
            TbxChtMsgRedB.Size = new Size(72, 23);
            TbxChtMsgRedB.TabIndex = 306;
            // 
            // LbChtMsgFfaB
            // 
            LbChtMsgFfaB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgFfaB.AutoSize = true;
            LbChtMsgFfaB.Location = new Point(236, 3867);
            LbChtMsgFfaB.Margin = new Padding(0);
            LbChtMsgFfaB.Name = "LbChtMsgFfaB";
            LbChtMsgFfaB.Size = new Size(14, 15);
            LbChtMsgFfaB.TabIndex = 305;
            LbChtMsgFfaB.Text = "b";
            LbChtMsgFfaB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtMsgFfaB
            // 
            TbxChtMsgFfaB.Location = new Point(471, 3864);
            TbxChtMsgFfaB.Margin = new Padding(0, 3, 0, 3);
            TbxChtMsgFfaB.Name = "TbxChtMsgFfaB";
            TbxChtMsgFfaB.Size = new Size(72, 23);
            TbxChtMsgFfaB.TabIndex = 304;
            // 
            // LbChtInColorB
            // 
            LbChtInColorB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtInColorB.AutoSize = true;
            LbChtInColorB.Location = new Point(236, 4253);
            LbChtInColorB.Margin = new Padding(0);
            LbChtInColorB.Name = "LbChtInColorB";
            LbChtInColorB.Size = new Size(14, 15);
            LbChtInColorB.TabIndex = 342;
            LbChtInColorB.Text = "b";
            LbChtInColorB.TextAlign = ContentAlignment.MiddleRight;
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
            LbChtInColorG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtInColorG.AutoSize = true;
            LbChtInColorG.Location = new Point(146, 4253);
            LbChtInColorG.Margin = new Padding(0);
            LbChtInColorG.Name = "LbChtInColorG";
            LbChtInColorG.Size = new Size(14, 15);
            LbChtInColorG.TabIndex = 328;
            LbChtInColorG.Text = "g";
            LbChtInColorG.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtInColorR
            // 
            LbChtInColorR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtInColorR.AutoSize = true;
            LbChtInColorR.Location = new Point(59, 4253);
            LbChtInColorR.Margin = new Padding(0);
            LbChtInColorR.Name = "LbChtInColorR";
            LbChtInColorR.Size = new Size(11, 15);
            LbChtInColorR.TabIndex = 327;
            LbChtInColorR.Text = "r";
            LbChtInColorR.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtInColorA
            // 
            LbChtInColorA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtInColorA.AutoSize = true;
            LbChtInColorA.Location = new Point(-33, 4253);
            LbChtInColorA.Margin = new Padding(0);
            LbChtInColorA.Name = "LbChtInColorA";
            LbChtInColorA.Size = new Size(13, 15);
            LbChtInColorA.TabIndex = 326;
            LbChtInColorA.Text = "a";
            LbChtInColorA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbxChtInColorG
            // 
            TbxChtInColorG.Location = new Point(381, 4250);
            TbxChtInColorG.Margin = new Padding(0, 3, 0, 3);
            TbxChtInColorG.Name = "TbxChtInColorG";
            TbxChtInColorG.Size = new Size(72, 23);
            TbxChtInColorG.TabIndex = 325;
            // 
            // TbxChtInColorR
            // 
            TbxChtInColorR.Location = new Point(291, 4250);
            TbxChtInColorR.Margin = new Padding(0, 3, 0, 3);
            TbxChtInColorR.Name = "TbxChtInColorR";
            TbxChtInColorR.Size = new Size(72, 23);
            TbxChtInColorR.TabIndex = 324;
            // 
            // TbxChtInColorA
            // 
            TbxChtInColorA.Location = new Point(201, 4250);
            TbxChtInColorA.Margin = new Padding(0, 3, 0, 3);
            TbxChtInColorA.Name = "TbxChtInColorA";
            TbxChtInColorA.Size = new Size(72, 23);
            TbxChtInColorA.TabIndex = 323;
            // 
            // LbChtIn
            // 
            LbChtIn.AutoSize = true;
            LbChtIn.Location = new Point(14, 4226);
            LbChtIn.Margin = new Padding(8, 12, 8, 0);
            LbChtIn.Name = "LbChtIn";
            LbChtIn.Size = new Size(61, 15);
            LbChtIn.TabIndex = 322;
            LbChtIn.Text = "chat input";
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
            LbChtInColor.AutoSize = true;
            LbChtInColor.BackColor = SystemColors.ControlLight;
            LbChtInColor.Location = new Point(34, 4253);
            LbChtInColor.Margin = new Padding(8, 12, 8, 0);
            LbChtInColor.Name = "LbChtInColor";
            LbChtInColor.Size = new Size(34, 15);
            LbChtInColor.TabIndex = 311;
            LbChtInColor.Text = "color";
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
            LbSvMsgOffY.Location = new Point(57, 3562);
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
            LbSvMsgOffX.Location = new Point(-33, 3562);
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
            LbSvMsgDimY.Location = new Point(57, 3589);
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
            LbSvMsgDimX.Location = new Point(-33, 3589);
            LbSvMsgDimX.Margin = new Padding(0);
            LbSvMsgDimX.Name = "LbSvMsgDimX";
            LbSvMsgDimX.Size = new Size(13, 15);
            LbSvMsgDimX.TabIndex = 345;
            LbSvMsgDimX.Text = "x";
            LbSvMsgDimX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgOffY
            // 
            LbChtMsgOffY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgOffY.AutoSize = true;
            LbChtMsgOffY.Location = new Point(57, 3948);
            LbChtMsgOffY.Margin = new Padding(0);
            LbChtMsgOffY.Name = "LbChtMsgOffY";
            LbChtMsgOffY.Size = new Size(13, 15);
            LbChtMsgOffY.TabIndex = 348;
            LbChtMsgOffY.Text = "y";
            LbChtMsgOffY.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbChtMsgOffX
            // 
            LbChtMsgOffX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbChtMsgOffX.AutoSize = true;
            LbChtMsgOffX.Location = new Point(-33, 3948);
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
            LbChtMsgDimY.Location = new Point(57, 3975);
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
            LbChtMsgDimX.Location = new Point(-33, 3975);
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
            LbChtInOffY.Location = new Point(57, 4280);
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
            LbChtInOffX.Location = new Point(-33, 4280);
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
            // PnlHotkey
            // 
            PnlHotkey.BackColor = SystemColors.ControlLight;
            PnlHotkey.BorderStyle = BorderStyle.Fixed3D;
            PnlHotkey.Controls.Add(LbHotKeyDesc);
            PnlHotkey.Controls.Add(LbHotKey);
            PnlHotkey.Location = new Point(8, 4414);
            PnlHotkey.Margin = new Padding(3, 38, 3, 3);
            PnlHotkey.Name = "PnlHotkey";
            PnlHotkey.Size = new Size(543, 63);
            PnlHotkey.TabIndex = 211;
            // 
            // LbHotKeyDesc
            // 
            LbHotKeyDesc.AutoSize = true;
            LbHotKeyDesc.Location = new Point(4, 24);
            LbHotKeyDesc.Name = "LbHotKeyDesc";
            LbHotKeyDesc.Size = new Size(436, 30);
            LbHotKeyDesc.TabIndex = 1;
            LbHotKeyDesc.Text = "hotkey configuration.\r\nhotkeys can be configured to emit EITHER Halo scripts *OR* Chimera commands.";
            // 
            // LbHotKey
            // 
            LbHotKey.AutoSize = true;
            LbHotKey.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbHotKey.Location = new Point(4, 5);
            LbHotKey.Name = "LbHotKey";
            LbHotKey.Size = new Size(51, 19);
            LbHotKey.TabIndex = 0;
            LbHotKey.Text = "hotkey";
            // 
            // CbHotKeyEnabled
            // 
            CbHotKeyEnabled.AutoSize = true;
            CbHotKeyEnabled.Location = new Point(180, 4490);
            CbHotKeyEnabled.Name = "CbHotKeyEnabled";
            CbHotKeyEnabled.Size = new Size(15, 14);
            CbHotKeyEnabled.TabIndex = 362;
            CbHotKeyEnabled.UseVisualStyleBackColor = true;
            // 
            // LbHotKeyEnabled
            // 
            LbHotKeyEnabled.AutoSize = true;
            LbHotKeyEnabled.Location = new Point(14, 4488);
            LbHotKeyEnabled.Margin = new Padding(8, 8, 8, 0);
            LbHotKeyEnabled.Name = "LbHotKeyEnabled";
            LbHotKeyEnabled.Size = new Size(49, 15);
            LbHotKeyEnabled.TabIndex = 361;
            LbHotKeyEnabled.Text = "enabled";
            // 
            // TbxHKF3
            // 
            TbxHKF3.Location = new Point(180, 4593);
            TbxHKF3.Margin = new Padding(3, 3, 10, 3);
            TbxHKF3.Name = "TbxHKF3";
            TbxHKF3.Size = new Size(371, 23);
            TbxHKF3.TabIndex = 373;
            // 
            // LbHKF3
            // 
            LbHKF3.AutoSize = true;
            LbHKF3.Location = new Point(14, 4596);
            LbHKF3.Margin = new Padding(8, 12, 8, 0);
            LbHKF3.Name = "LbHKF3";
            LbHKF3.Size = new Size(17, 15);
            LbHKF3.TabIndex = 372;
            LbHKF3.Text = "f3";
            // 
            // TbxHKF2
            // 
            TbxHKF2.Location = new Point(180, 4566);
            TbxHKF2.Margin = new Padding(3, 3, 10, 3);
            TbxHKF2.Name = "TbxHKF2";
            TbxHKF2.Size = new Size(371, 23);
            TbxHKF2.TabIndex = 370;
            // 
            // LbHKF2
            // 
            LbHKF2.AutoSize = true;
            LbHKF2.Location = new Point(14, 4569);
            LbHKF2.Margin = new Padding(8, 12, 8, 0);
            LbHKF2.Name = "LbHKF2";
            LbHKF2.Size = new Size(17, 15);
            LbHKF2.TabIndex = 369;
            LbHKF2.Text = "f2";
            // 
            // TbxHKF1
            // 
            TbxHKF1.Location = new Point(180, 4539);
            TbxHKF1.Margin = new Padding(3, 3, 10, 3);
            TbxHKF1.Name = "TbxHKF1";
            TbxHKF1.Size = new Size(371, 23);
            TbxHKF1.TabIndex = 367;
            // 
            // LbHKF1
            // 
            LbHKF1.AutoSize = true;
            LbHKF1.Location = new Point(14, 4542);
            LbHKF1.Margin = new Padding(8, 12, 8, 0);
            LbHKF1.Name = "LbHKF1";
            LbHKF1.Size = new Size(17, 15);
            LbHKF1.TabIndex = 366;
            LbHKF1.Text = "f1";
            // 
            // LbHotKeyFunction
            // 
            LbHotKeyFunction.AutoSize = true;
            LbHotKeyFunction.Location = new Point(14, 4515);
            LbHotKeyFunction.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyFunction.Name = "LbHotKeyFunction";
            LbHotKeyFunction.Size = new Size(117, 15);
            LbHotKeyFunction.TabIndex = 363;
            LbHotKeyFunction.Text = "function key hotkeys";
            // 
            // TbxHKF6
            // 
            TbxHKF6.Location = new Point(180, 4674);
            TbxHKF6.Margin = new Padding(3, 3, 10, 3);
            TbxHKF6.Name = "TbxHKF6";
            TbxHKF6.Size = new Size(371, 23);
            TbxHKF6.TabIndex = 379;
            // 
            // LbHKF6
            // 
            LbHKF6.AutoSize = true;
            LbHKF6.Location = new Point(14, 4677);
            LbHKF6.Margin = new Padding(8, 12, 8, 0);
            LbHKF6.Name = "LbHKF6";
            LbHKF6.Size = new Size(17, 15);
            LbHKF6.TabIndex = 378;
            LbHKF6.Text = "f6";
            // 
            // TbxHKF5
            // 
            TbxHKF5.Location = new Point(180, 4647);
            TbxHKF5.Margin = new Padding(3, 3, 10, 3);
            TbxHKF5.Name = "TbxHKF5";
            TbxHKF5.Size = new Size(371, 23);
            TbxHKF5.TabIndex = 377;
            // 
            // LbHKF5
            // 
            LbHKF5.AutoSize = true;
            LbHKF5.Location = new Point(14, 4650);
            LbHKF5.Margin = new Padding(8, 12, 8, 0);
            LbHKF5.Name = "LbHKF5";
            LbHKF5.Size = new Size(17, 15);
            LbHKF5.TabIndex = 376;
            LbHKF5.Text = "f5";
            // 
            // TbxHKF4
            // 
            TbxHKF4.Location = new Point(180, 4620);
            TbxHKF4.Margin = new Padding(3, 3, 10, 3);
            TbxHKF4.Name = "TbxHKF4";
            TbxHKF4.Size = new Size(371, 23);
            TbxHKF4.TabIndex = 375;
            // 
            // LbHKF4
            // 
            LbHKF4.AutoSize = true;
            LbHKF4.Location = new Point(14, 4623);
            LbHKF4.Margin = new Padding(8, 12, 8, 0);
            LbHKF4.Name = "LbHKF4";
            LbHKF4.Size = new Size(17, 15);
            LbHKF4.TabIndex = 374;
            LbHKF4.Text = "f4";
            // 
            // TbxHKF9
            // 
            TbxHKF9.Location = new Point(180, 4755);
            TbxHKF9.Margin = new Padding(3, 3, 10, 3);
            TbxHKF9.Name = "TbxHKF9";
            TbxHKF9.Size = new Size(371, 23);
            TbxHKF9.TabIndex = 385;
            // 
            // LbHKF9
            // 
            LbHKF9.AutoSize = true;
            LbHKF9.Location = new Point(14, 4758);
            LbHKF9.Margin = new Padding(8, 12, 8, 0);
            LbHKF9.Name = "LbHKF9";
            LbHKF9.Size = new Size(17, 15);
            LbHKF9.TabIndex = 384;
            LbHKF9.Text = "f9";
            // 
            // TbxHKF8
            // 
            TbxHKF8.Location = new Point(180, 4728);
            TbxHKF8.Margin = new Padding(3, 3, 10, 3);
            TbxHKF8.Name = "TbxHKF8";
            TbxHKF8.Size = new Size(371, 23);
            TbxHKF8.TabIndex = 383;
            // 
            // LbHKF8
            // 
            LbHKF8.AutoSize = true;
            LbHKF8.Location = new Point(14, 4731);
            LbHKF8.Margin = new Padding(8, 12, 8, 0);
            LbHKF8.Name = "LbHKF8";
            LbHKF8.Size = new Size(17, 15);
            LbHKF8.TabIndex = 382;
            LbHKF8.Text = "f8";
            // 
            // TbxHKF7
            // 
            TbxHKF7.Location = new Point(180, 4701);
            TbxHKF7.Margin = new Padding(3, 3, 10, 3);
            TbxHKF7.Name = "TbxHKF7";
            TbxHKF7.Size = new Size(371, 23);
            TbxHKF7.TabIndex = 381;
            // 
            // LbHKF7
            // 
            LbHKF7.AutoSize = true;
            LbHKF7.Location = new Point(14, 4704);
            LbHKF7.Margin = new Padding(8, 12, 8, 0);
            LbHKF7.Name = "LbHKF7";
            LbHKF7.Size = new Size(17, 15);
            LbHKF7.TabIndex = 380;
            LbHKF7.Text = "f7";
            // 
            // TbxHKF12
            // 
            TbxHKF12.Location = new Point(180, 4836);
            TbxHKF12.Margin = new Padding(3, 3, 10, 3);
            TbxHKF12.Name = "TbxHKF12";
            TbxHKF12.Size = new Size(371, 23);
            TbxHKF12.TabIndex = 391;
            // 
            // LbHKF12
            // 
            LbHKF12.AutoSize = true;
            LbHKF12.Location = new Point(14, 4839);
            LbHKF12.Margin = new Padding(8, 12, 8, 0);
            LbHKF12.Name = "LbHKF12";
            LbHKF12.Size = new Size(23, 15);
            LbHKF12.TabIndex = 390;
            LbHKF12.Text = "f12";
            // 
            // TbxHKF11
            // 
            TbxHKF11.Location = new Point(180, 4809);
            TbxHKF11.Margin = new Padding(3, 3, 10, 3);
            TbxHKF11.Name = "TbxHKF11";
            TbxHKF11.Size = new Size(371, 23);
            TbxHKF11.TabIndex = 389;
            // 
            // LbHKF11
            // 
            LbHKF11.AutoSize = true;
            LbHKF11.Location = new Point(14, 4812);
            LbHKF11.Margin = new Padding(8, 12, 8, 0);
            LbHKF11.Name = "LbHKF11";
            LbHKF11.Size = new Size(23, 15);
            LbHKF11.TabIndex = 388;
            LbHKF11.Text = "f11";
            // 
            // TbxHKF10
            // 
            TbxHKF10.Location = new Point(180, 4782);
            TbxHKF10.Margin = new Padding(3, 3, 10, 3);
            TbxHKF10.Name = "TbxHKF10";
            TbxHKF10.Size = new Size(371, 23);
            TbxHKF10.TabIndex = 387;
            // 
            // LbHKF10
            // 
            LbHKF10.AutoSize = true;
            LbHKF10.Location = new Point(14, 4785);
            LbHKF10.Margin = new Padding(8, 12, 8, 0);
            LbHKF10.Name = "LbHKF10";
            LbHKF10.Size = new Size(23, 15);
            LbHKF10.TabIndex = 386;
            LbHKF10.Text = "f10";
            // 
            // LbHotKeyAltShift
            // 
            LbHotKeyAltShift.AutoSize = true;
            LbHotKeyAltShift.Location = new Point(14, 4866);
            LbHotKeyAltShift.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyAltShift.Name = "LbHotKeyAltShift";
            LbHotKeyAltShift.Size = new Size(110, 15);
            LbHotKeyAltShift.TabIndex = 392;
            LbHotKeyAltShift.Text = "alt+shift+# hotkeys";
            // 
            // TbxHKAS0
            // 
            TbxHKAS0.Location = new Point(180, 5133);
            TbxHKAS0.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS0.Name = "TbxHKAS0";
            TbxHKAS0.Size = new Size(371, 23);
            TbxHKAS0.TabIndex = 412;
            // 
            // LbHKAS0
            // 
            LbHKAS0.AutoSize = true;
            LbHKAS0.Location = new Point(14, 5136);
            LbHKAS0.Margin = new Padding(8, 12, 8, 0);
            LbHKAS0.Name = "LbHKAS0";
            LbHKAS0.Size = new Size(59, 15);
            LbHKAS0.TabIndex = 411;
            LbHKAS0.Text = "alt_shift_0";
            // 
            // TbxHKAS9
            // 
            TbxHKAS9.Location = new Point(180, 5106);
            TbxHKAS9.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS9.Name = "TbxHKAS9";
            TbxHKAS9.Size = new Size(371, 23);
            TbxHKAS9.TabIndex = 410;
            // 
            // LbHKAS9
            // 
            LbHKAS9.AutoSize = true;
            LbHKAS9.Location = new Point(14, 5109);
            LbHKAS9.Margin = new Padding(8, 12, 8, 0);
            LbHKAS9.Name = "LbHKAS9";
            LbHKAS9.Size = new Size(59, 15);
            LbHKAS9.TabIndex = 409;
            LbHKAS9.Text = "alt_shift_9";
            // 
            // TbxHKAS8
            // 
            TbxHKAS8.Location = new Point(180, 5079);
            TbxHKAS8.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS8.Name = "TbxHKAS8";
            TbxHKAS8.Size = new Size(371, 23);
            TbxHKAS8.TabIndex = 408;
            // 
            // LbHKAS8
            // 
            LbHKAS8.AutoSize = true;
            LbHKAS8.Location = new Point(14, 5082);
            LbHKAS8.Margin = new Padding(8, 12, 8, 0);
            LbHKAS8.Name = "LbHKAS8";
            LbHKAS8.Size = new Size(59, 15);
            LbHKAS8.TabIndex = 407;
            LbHKAS8.Text = "alt_shift_8";
            // 
            // TbxHKAS7
            // 
            TbxHKAS7.Location = new Point(180, 5052);
            TbxHKAS7.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS7.Name = "TbxHKAS7";
            TbxHKAS7.Size = new Size(371, 23);
            TbxHKAS7.TabIndex = 406;
            // 
            // LbHKAS7
            // 
            LbHKAS7.AutoSize = true;
            LbHKAS7.Location = new Point(14, 5055);
            LbHKAS7.Margin = new Padding(8, 12, 8, 0);
            LbHKAS7.Name = "LbHKAS7";
            LbHKAS7.Size = new Size(59, 15);
            LbHKAS7.TabIndex = 405;
            LbHKAS7.Text = "alt_shift_7";
            // 
            // TbxHKAS6
            // 
            TbxHKAS6.Location = new Point(180, 5025);
            TbxHKAS6.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS6.Name = "TbxHKAS6";
            TbxHKAS6.Size = new Size(371, 23);
            TbxHKAS6.TabIndex = 404;
            // 
            // LbHKAS6
            // 
            LbHKAS6.AutoSize = true;
            LbHKAS6.Location = new Point(14, 5028);
            LbHKAS6.Margin = new Padding(8, 12, 8, 0);
            LbHKAS6.Name = "LbHKAS6";
            LbHKAS6.Size = new Size(59, 15);
            LbHKAS6.TabIndex = 403;
            LbHKAS6.Text = "alt_shift_6";
            // 
            // TbxHKAS5
            // 
            TbxHKAS5.Location = new Point(180, 4998);
            TbxHKAS5.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS5.Name = "TbxHKAS5";
            TbxHKAS5.Size = new Size(371, 23);
            TbxHKAS5.TabIndex = 402;
            // 
            // LbHKAS5
            // 
            LbHKAS5.AutoSize = true;
            LbHKAS5.Location = new Point(14, 5001);
            LbHKAS5.Margin = new Padding(8, 12, 8, 0);
            LbHKAS5.Name = "LbHKAS5";
            LbHKAS5.Size = new Size(59, 15);
            LbHKAS5.TabIndex = 401;
            LbHKAS5.Text = "alt_shift_5";
            // 
            // TbxHKAS4
            // 
            TbxHKAS4.Location = new Point(180, 4971);
            TbxHKAS4.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS4.Name = "TbxHKAS4";
            TbxHKAS4.Size = new Size(371, 23);
            TbxHKAS4.TabIndex = 400;
            // 
            // LbHKAS4
            // 
            LbHKAS4.AutoSize = true;
            LbHKAS4.Location = new Point(14, 4974);
            LbHKAS4.Margin = new Padding(8, 12, 8, 0);
            LbHKAS4.Name = "LbHKAS4";
            LbHKAS4.Size = new Size(59, 15);
            LbHKAS4.TabIndex = 399;
            LbHKAS4.Text = "alt_shift_4";
            // 
            // TbxHKAS3
            // 
            TbxHKAS3.Location = new Point(180, 4944);
            TbxHKAS3.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS3.Name = "TbxHKAS3";
            TbxHKAS3.Size = new Size(371, 23);
            TbxHKAS3.TabIndex = 398;
            // 
            // LbHKAS3
            // 
            LbHKAS3.AutoSize = true;
            LbHKAS3.Location = new Point(14, 4947);
            LbHKAS3.Margin = new Padding(8, 12, 8, 0);
            LbHKAS3.Name = "LbHKAS3";
            LbHKAS3.Size = new Size(59, 15);
            LbHKAS3.TabIndex = 397;
            LbHKAS3.Text = "alt_shift_3";
            // 
            // TbxHKAS2
            // 
            TbxHKAS2.Location = new Point(180, 4917);
            TbxHKAS2.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS2.Name = "TbxHKAS2";
            TbxHKAS2.Size = new Size(371, 23);
            TbxHKAS2.TabIndex = 396;
            // 
            // LbHKAS2
            // 
            LbHKAS2.AutoSize = true;
            LbHKAS2.Location = new Point(14, 4920);
            LbHKAS2.Margin = new Padding(8, 12, 8, 0);
            LbHKAS2.Name = "LbHKAS2";
            LbHKAS2.Size = new Size(59, 15);
            LbHKAS2.TabIndex = 395;
            LbHKAS2.Text = "alt_shift_2";
            // 
            // TbxHKAS1
            // 
            TbxHKAS1.Location = new Point(180, 4890);
            TbxHKAS1.Margin = new Padding(3, 3, 10, 3);
            TbxHKAS1.Name = "TbxHKAS1";
            TbxHKAS1.Size = new Size(371, 23);
            TbxHKAS1.TabIndex = 394;
            // 
            // LbHKAS1
            // 
            LbHKAS1.AutoSize = true;
            LbHKAS1.Location = new Point(14, 4893);
            LbHKAS1.Margin = new Padding(8, 12, 8, 0);
            LbHKAS1.Name = "LbHKAS1";
            LbHKAS1.Size = new Size(59, 15);
            LbHKAS1.TabIndex = 393;
            LbHKAS1.Text = "alt_shift_1";
            // 
            // TbxHKASN0
            // 
            TbxHKASN0.Location = new Point(180, 5430);
            TbxHKASN0.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN0.Name = "TbxHKASN0";
            TbxHKASN0.Size = new Size(371, 23);
            TbxHKASN0.TabIndex = 433;
            // 
            // LbHKASN0
            // 
            LbHKASN0.AutoSize = true;
            LbHKASN0.Location = new Point(14, 5433);
            LbHKASN0.Margin = new Padding(8, 12, 8, 0);
            LbHKASN0.Name = "LbHKASN0";
            LbHKASN0.Size = new Size(89, 15);
            LbHKASN0.TabIndex = 432;
            LbHKASN0.Text = "alt_shift_num_0";
            // 
            // TbxHKASN9
            // 
            TbxHKASN9.Location = new Point(180, 5403);
            TbxHKASN9.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN9.Name = "TbxHKASN9";
            TbxHKASN9.Size = new Size(371, 23);
            TbxHKASN9.TabIndex = 431;
            // 
            // LbHKASN9
            // 
            LbHKASN9.AutoSize = true;
            LbHKASN9.Location = new Point(14, 5406);
            LbHKASN9.Margin = new Padding(8, 12, 8, 0);
            LbHKASN9.Name = "LbHKASN9";
            LbHKASN9.Size = new Size(89, 15);
            LbHKASN9.TabIndex = 430;
            LbHKASN9.Text = "alt_shift_num_9";
            // 
            // TbxHKASN8
            // 
            TbxHKASN8.Location = new Point(180, 5376);
            TbxHKASN8.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN8.Name = "TbxHKASN8";
            TbxHKASN8.Size = new Size(371, 23);
            TbxHKASN8.TabIndex = 429;
            // 
            // LbHKASN8
            // 
            LbHKASN8.AutoSize = true;
            LbHKASN8.Location = new Point(14, 5379);
            LbHKASN8.Margin = new Padding(8, 12, 8, 0);
            LbHKASN8.Name = "LbHKASN8";
            LbHKASN8.Size = new Size(89, 15);
            LbHKASN8.TabIndex = 428;
            LbHKASN8.Text = "alt_shift_num_8";
            // 
            // TbxHKASN7
            // 
            TbxHKASN7.Location = new Point(180, 5349);
            TbxHKASN7.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN7.Name = "TbxHKASN7";
            TbxHKASN7.Size = new Size(371, 23);
            TbxHKASN7.TabIndex = 427;
            // 
            // LbHKASN7
            // 
            LbHKASN7.AutoSize = true;
            LbHKASN7.Location = new Point(14, 5352);
            LbHKASN7.Margin = new Padding(8, 12, 8, 0);
            LbHKASN7.Name = "LbHKASN7";
            LbHKASN7.Size = new Size(89, 15);
            LbHKASN7.TabIndex = 426;
            LbHKASN7.Text = "alt_shift_num_7";
            // 
            // TbxHKASN6
            // 
            TbxHKASN6.Location = new Point(180, 5322);
            TbxHKASN6.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN6.Name = "TbxHKASN6";
            TbxHKASN6.Size = new Size(371, 23);
            TbxHKASN6.TabIndex = 425;
            // 
            // LbHKASN6
            // 
            LbHKASN6.AutoSize = true;
            LbHKASN6.Location = new Point(14, 5325);
            LbHKASN6.Margin = new Padding(8, 12, 8, 0);
            LbHKASN6.Name = "LbHKASN6";
            LbHKASN6.Size = new Size(89, 15);
            LbHKASN6.TabIndex = 424;
            LbHKASN6.Text = "alt_shift_num_6";
            // 
            // TbxHKASN5
            // 
            TbxHKASN5.Location = new Point(180, 5295);
            TbxHKASN5.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN5.Name = "TbxHKASN5";
            TbxHKASN5.Size = new Size(371, 23);
            TbxHKASN5.TabIndex = 423;
            // 
            // LbHKASN5
            // 
            LbHKASN5.AutoSize = true;
            LbHKASN5.Location = new Point(14, 5298);
            LbHKASN5.Margin = new Padding(8, 12, 8, 0);
            LbHKASN5.Name = "LbHKASN5";
            LbHKASN5.Size = new Size(89, 15);
            LbHKASN5.TabIndex = 422;
            LbHKASN5.Text = "alt_shift_num_5";
            // 
            // TbxHKASN4
            // 
            TbxHKASN4.Location = new Point(180, 5268);
            TbxHKASN4.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN4.Name = "TbxHKASN4";
            TbxHKASN4.Size = new Size(371, 23);
            TbxHKASN4.TabIndex = 421;
            // 
            // LbHKASN4
            // 
            LbHKASN4.AutoSize = true;
            LbHKASN4.Location = new Point(14, 5271);
            LbHKASN4.Margin = new Padding(8, 12, 8, 0);
            LbHKASN4.Name = "LbHKASN4";
            LbHKASN4.Size = new Size(89, 15);
            LbHKASN4.TabIndex = 420;
            LbHKASN4.Text = "alt_shift_num_4";
            // 
            // TbxHKASN3
            // 
            TbxHKASN3.Location = new Point(180, 5241);
            TbxHKASN3.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN3.Name = "TbxHKASN3";
            TbxHKASN3.Size = new Size(371, 23);
            TbxHKASN3.TabIndex = 419;
            // 
            // LbHKASN3
            // 
            LbHKASN3.AutoSize = true;
            LbHKASN3.Location = new Point(14, 5244);
            LbHKASN3.Margin = new Padding(8, 12, 8, 0);
            LbHKASN3.Name = "LbHKASN3";
            LbHKASN3.Size = new Size(89, 15);
            LbHKASN3.TabIndex = 418;
            LbHKASN3.Text = "alt_shift_num_3";
            // 
            // TbxHKASN2
            // 
            TbxHKASN2.Location = new Point(180, 5214);
            TbxHKASN2.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN2.Name = "TbxHKASN2";
            TbxHKASN2.Size = new Size(371, 23);
            TbxHKASN2.TabIndex = 417;
            // 
            // LbHKASN2
            // 
            LbHKASN2.AutoSize = true;
            LbHKASN2.Location = new Point(14, 5217);
            LbHKASN2.Margin = new Padding(8, 12, 8, 0);
            LbHKASN2.Name = "LbHKASN2";
            LbHKASN2.Size = new Size(89, 15);
            LbHKASN2.TabIndex = 416;
            LbHKASN2.Text = "alt_shift_num_2";
            // 
            // TbxHKASN1
            // 
            TbxHKASN1.Location = new Point(180, 5187);
            TbxHKASN1.Margin = new Padding(3, 3, 10, 3);
            TbxHKASN1.Name = "TbxHKASN1";
            TbxHKASN1.Size = new Size(371, 23);
            TbxHKASN1.TabIndex = 415;
            // 
            // LbHKASN1
            // 
            LbHKASN1.AutoSize = true;
            LbHKASN1.Location = new Point(14, 5190);
            LbHKASN1.Margin = new Padding(8, 12, 8, 0);
            LbHKASN1.Name = "LbHKASN1";
            LbHKASN1.Size = new Size(89, 15);
            LbHKASN1.TabIndex = 414;
            LbHKASN1.Text = "alt_shift_num_1";
            // 
            // LbHotKeyAltShiftNum
            // 
            LbHotKeyAltShiftNum.AutoSize = true;
            LbHotKeyAltShiftNum.Location = new Point(14, 5163);
            LbHotKeyAltShiftNum.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyAltShiftNum.Name = "LbHotKeyAltShiftNum";
            LbHotKeyAltShiftNum.Size = new Size(148, 15);
            LbHotKeyAltShiftNum.TabIndex = 413;
            LbHotKeyAltShiftNum.Text = "alt+shift+numpad hotkeys";
            // 
            // TbxHkA0
            // 
            TbxHkA0.Location = new Point(180, 5727);
            TbxHkA0.Margin = new Padding(3, 3, 10, 3);
            TbxHkA0.Name = "TbxHkA0";
            TbxHkA0.Size = new Size(371, 23);
            TbxHkA0.TabIndex = 454;
            // 
            // LbHkA0
            // 
            LbHkA0.AutoSize = true;
            LbHkA0.Location = new Point(14, 5730);
            LbHkA0.Margin = new Padding(8, 12, 8, 0);
            LbHkA0.Name = "LbHkA0";
            LbHkA0.Size = new Size(31, 15);
            LbHkA0.TabIndex = 453;
            LbHkA0.Text = "alt_0";
            // 
            // TbxHkA9
            // 
            TbxHkA9.Location = new Point(180, 5700);
            TbxHkA9.Margin = new Padding(3, 3, 10, 3);
            TbxHkA9.Name = "TbxHkA9";
            TbxHkA9.Size = new Size(371, 23);
            TbxHkA9.TabIndex = 452;
            // 
            // LbHkA9
            // 
            LbHkA9.AutoSize = true;
            LbHkA9.Location = new Point(14, 5703);
            LbHkA9.Margin = new Padding(8, 12, 8, 0);
            LbHkA9.Name = "LbHkA9";
            LbHkA9.Size = new Size(31, 15);
            LbHkA9.TabIndex = 451;
            LbHkA9.Text = "alt_9";
            // 
            // TbxHkA8
            // 
            TbxHkA8.Location = new Point(180, 5673);
            TbxHkA8.Margin = new Padding(3, 3, 10, 3);
            TbxHkA8.Name = "TbxHkA8";
            TbxHkA8.Size = new Size(371, 23);
            TbxHkA8.TabIndex = 450;
            // 
            // LbHkA8
            // 
            LbHkA8.AutoSize = true;
            LbHkA8.Location = new Point(14, 5676);
            LbHkA8.Margin = new Padding(8, 12, 8, 0);
            LbHkA8.Name = "LbHkA8";
            LbHkA8.Size = new Size(31, 15);
            LbHkA8.TabIndex = 449;
            LbHkA8.Text = "alt_8";
            // 
            // TbxHkA7
            // 
            TbxHkA7.Location = new Point(180, 5646);
            TbxHkA7.Margin = new Padding(3, 3, 10, 3);
            TbxHkA7.Name = "TbxHkA7";
            TbxHkA7.Size = new Size(371, 23);
            TbxHkA7.TabIndex = 448;
            // 
            // LbHkA7
            // 
            LbHkA7.AutoSize = true;
            LbHkA7.Location = new Point(14, 5649);
            LbHkA7.Margin = new Padding(8, 12, 8, 0);
            LbHkA7.Name = "LbHkA7";
            LbHkA7.Size = new Size(31, 15);
            LbHkA7.TabIndex = 447;
            LbHkA7.Text = "alt_7";
            // 
            // TbxHkA6
            // 
            TbxHkA6.Location = new Point(180, 5619);
            TbxHkA6.Margin = new Padding(3, 3, 10, 3);
            TbxHkA6.Name = "TbxHkA6";
            TbxHkA6.Size = new Size(371, 23);
            TbxHkA6.TabIndex = 446;
            // 
            // LbHkA6
            // 
            LbHkA6.AutoSize = true;
            LbHkA6.Location = new Point(14, 5622);
            LbHkA6.Margin = new Padding(8, 12, 8, 0);
            LbHkA6.Name = "LbHkA6";
            LbHkA6.Size = new Size(31, 15);
            LbHkA6.TabIndex = 445;
            LbHkA6.Text = "alt_6";
            // 
            // TbxHkA5
            // 
            TbxHkA5.Location = new Point(180, 5592);
            TbxHkA5.Margin = new Padding(3, 3, 10, 3);
            TbxHkA5.Name = "TbxHkA5";
            TbxHkA5.Size = new Size(371, 23);
            TbxHkA5.TabIndex = 444;
            // 
            // LbHkA5
            // 
            LbHkA5.AutoSize = true;
            LbHkA5.Location = new Point(14, 5595);
            LbHkA5.Margin = new Padding(8, 12, 8, 0);
            LbHkA5.Name = "LbHkA5";
            LbHkA5.Size = new Size(31, 15);
            LbHkA5.TabIndex = 443;
            LbHkA5.Text = "alt_5";
            // 
            // TbxHkA4
            // 
            TbxHkA4.Location = new Point(180, 5565);
            TbxHkA4.Margin = new Padding(3, 3, 10, 3);
            TbxHkA4.Name = "TbxHkA4";
            TbxHkA4.Size = new Size(371, 23);
            TbxHkA4.TabIndex = 442;
            // 
            // LbHkA4
            // 
            LbHkA4.AutoSize = true;
            LbHkA4.Location = new Point(14, 5568);
            LbHkA4.Margin = new Padding(8, 12, 8, 0);
            LbHkA4.Name = "LbHkA4";
            LbHkA4.Size = new Size(31, 15);
            LbHkA4.TabIndex = 441;
            LbHkA4.Text = "alt_4";
            // 
            // TbxHkA3
            // 
            TbxHkA3.Location = new Point(180, 5538);
            TbxHkA3.Margin = new Padding(3, 3, 10, 3);
            TbxHkA3.Name = "TbxHkA3";
            TbxHkA3.Size = new Size(371, 23);
            TbxHkA3.TabIndex = 440;
            // 
            // LbHkA3
            // 
            LbHkA3.AutoSize = true;
            LbHkA3.Location = new Point(14, 5541);
            LbHkA3.Margin = new Padding(8, 12, 8, 0);
            LbHkA3.Name = "LbHkA3";
            LbHkA3.Size = new Size(31, 15);
            LbHkA3.TabIndex = 439;
            LbHkA3.Text = "alt_3";
            // 
            // TbxHkA2
            // 
            TbxHkA2.Location = new Point(180, 5511);
            TbxHkA2.Margin = new Padding(3, 3, 10, 3);
            TbxHkA2.Name = "TbxHkA2";
            TbxHkA2.Size = new Size(371, 23);
            TbxHkA2.TabIndex = 438;
            // 
            // LbHkA2
            // 
            LbHkA2.AutoSize = true;
            LbHkA2.Location = new Point(14, 5514);
            LbHkA2.Margin = new Padding(8, 12, 8, 0);
            LbHkA2.Name = "LbHkA2";
            LbHkA2.Size = new Size(31, 15);
            LbHkA2.TabIndex = 437;
            LbHkA2.Text = "alt_2";
            // 
            // TbxHkA1
            // 
            TbxHkA1.Location = new Point(180, 5484);
            TbxHkA1.Margin = new Padding(3, 3, 10, 3);
            TbxHkA1.Name = "TbxHkA1";
            TbxHkA1.Size = new Size(371, 23);
            TbxHkA1.TabIndex = 436;
            // 
            // LbHkA1
            // 
            LbHkA1.AutoSize = true;
            LbHkA1.Location = new Point(14, 5487);
            LbHkA1.Margin = new Padding(8, 12, 8, 0);
            LbHkA1.Name = "LbHkA1";
            LbHkA1.Size = new Size(31, 15);
            LbHkA1.TabIndex = 435;
            LbHkA1.Text = "alt_1";
            // 
            // LbHotKeyAlt
            // 
            LbHotKeyAlt.AutoSize = true;
            LbHotKeyAlt.Location = new Point(14, 5460);
            LbHotKeyAlt.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyAlt.Name = "LbHotKeyAlt";
            LbHotKeyAlt.Size = new Size(79, 15);
            LbHotKeyAlt.TabIndex = 434;
            LbHotKeyAlt.Text = "alt+# hotkeys";
            // 
            // TbxHkC0
            // 
            TbxHkC0.Location = new Point(180, 6321);
            TbxHkC0.Margin = new Padding(3, 3, 10, 3);
            TbxHkC0.Name = "TbxHkC0";
            TbxHkC0.Size = new Size(371, 23);
            TbxHkC0.TabIndex = 475;
            // 
            // LbHkC0
            // 
            LbHkC0.AutoSize = true;
            LbHkC0.Location = new Point(14, 6324);
            LbHkC0.Margin = new Padding(8, 12, 8, 0);
            LbHkC0.Name = "LbHkC0";
            LbHkC0.Size = new Size(35, 15);
            LbHkC0.TabIndex = 474;
            LbHkC0.Text = "ctrl_0";
            // 
            // TbxHkC9
            // 
            TbxHkC9.Location = new Point(180, 6294);
            TbxHkC9.Margin = new Padding(3, 3, 10, 3);
            TbxHkC9.Name = "TbxHkC9";
            TbxHkC9.Size = new Size(371, 23);
            TbxHkC9.TabIndex = 473;
            // 
            // LbHkC9
            // 
            LbHkC9.AutoSize = true;
            LbHkC9.Location = new Point(14, 6297);
            LbHkC9.Margin = new Padding(8, 12, 8, 0);
            LbHkC9.Name = "LbHkC9";
            LbHkC9.Size = new Size(35, 15);
            LbHkC9.TabIndex = 472;
            LbHkC9.Text = "ctrl_9";
            // 
            // TbxHkC8
            // 
            TbxHkC8.Location = new Point(180, 6267);
            TbxHkC8.Margin = new Padding(3, 3, 10, 3);
            TbxHkC8.Name = "TbxHkC8";
            TbxHkC8.Size = new Size(371, 23);
            TbxHkC8.TabIndex = 471;
            // 
            // LbHkC8
            // 
            LbHkC8.AutoSize = true;
            LbHkC8.Location = new Point(14, 6270);
            LbHkC8.Margin = new Padding(8, 12, 8, 0);
            LbHkC8.Name = "LbHkC8";
            LbHkC8.Size = new Size(35, 15);
            LbHkC8.TabIndex = 470;
            LbHkC8.Text = "ctrl_8";
            // 
            // TbxHkC7
            // 
            TbxHkC7.Location = new Point(180, 6240);
            TbxHkC7.Margin = new Padding(3, 3, 10, 3);
            TbxHkC7.Name = "TbxHkC7";
            TbxHkC7.Size = new Size(371, 23);
            TbxHkC7.TabIndex = 469;
            // 
            // LbHkC7
            // 
            LbHkC7.AutoSize = true;
            LbHkC7.Location = new Point(14, 6243);
            LbHkC7.Margin = new Padding(8, 12, 8, 0);
            LbHkC7.Name = "LbHkC7";
            LbHkC7.Size = new Size(35, 15);
            LbHkC7.TabIndex = 468;
            LbHkC7.Text = "ctrl_7";
            // 
            // TbxHkC6
            // 
            TbxHkC6.Location = new Point(180, 6213);
            TbxHkC6.Margin = new Padding(3, 3, 10, 3);
            TbxHkC6.Name = "TbxHkC6";
            TbxHkC6.Size = new Size(371, 23);
            TbxHkC6.TabIndex = 467;
            // 
            // LbHkC6
            // 
            LbHkC6.AutoSize = true;
            LbHkC6.Location = new Point(14, 6216);
            LbHkC6.Margin = new Padding(8, 12, 8, 0);
            LbHkC6.Name = "LbHkC6";
            LbHkC6.Size = new Size(35, 15);
            LbHkC6.TabIndex = 466;
            LbHkC6.Text = "ctrl_6";
            // 
            // TbxHkC5
            // 
            TbxHkC5.Location = new Point(180, 6186);
            TbxHkC5.Margin = new Padding(3, 3, 10, 3);
            TbxHkC5.Name = "TbxHkC5";
            TbxHkC5.Size = new Size(371, 23);
            TbxHkC5.TabIndex = 465;
            // 
            // LbHkC5
            // 
            LbHkC5.AutoSize = true;
            LbHkC5.Location = new Point(14, 6189);
            LbHkC5.Margin = new Padding(8, 12, 8, 0);
            LbHkC5.Name = "LbHkC5";
            LbHkC5.Size = new Size(35, 15);
            LbHkC5.TabIndex = 464;
            LbHkC5.Text = "ctrl_5";
            // 
            // TbxHkC4
            // 
            TbxHkC4.Location = new Point(180, 6159);
            TbxHkC4.Margin = new Padding(3, 3, 10, 3);
            TbxHkC4.Name = "TbxHkC4";
            TbxHkC4.Size = new Size(371, 23);
            TbxHkC4.TabIndex = 463;
            // 
            // LbHkC4
            // 
            LbHkC4.AutoSize = true;
            LbHkC4.Location = new Point(14, 6162);
            LbHkC4.Margin = new Padding(8, 12, 8, 0);
            LbHkC4.Name = "LbHkC4";
            LbHkC4.Size = new Size(35, 15);
            LbHkC4.TabIndex = 462;
            LbHkC4.Text = "ctrl_4";
            // 
            // TbxHkC3
            // 
            TbxHkC3.Location = new Point(180, 6132);
            TbxHkC3.Margin = new Padding(3, 3, 10, 3);
            TbxHkC3.Name = "TbxHkC3";
            TbxHkC3.Size = new Size(371, 23);
            TbxHkC3.TabIndex = 461;
            // 
            // LbHkC3
            // 
            LbHkC3.AutoSize = true;
            LbHkC3.Location = new Point(14, 6135);
            LbHkC3.Margin = new Padding(8, 12, 8, 0);
            LbHkC3.Name = "LbHkC3";
            LbHkC3.Size = new Size(35, 15);
            LbHkC3.TabIndex = 460;
            LbHkC3.Text = "ctrl_3";
            // 
            // TbxHkC2
            // 
            TbxHkC2.Location = new Point(180, 6105);
            TbxHkC2.Margin = new Padding(3, 3, 10, 3);
            TbxHkC2.Name = "TbxHkC2";
            TbxHkC2.Size = new Size(371, 23);
            TbxHkC2.TabIndex = 459;
            // 
            // LbHkC2
            // 
            LbHkC2.AutoSize = true;
            LbHkC2.Location = new Point(14, 6108);
            LbHkC2.Margin = new Padding(8, 12, 8, 0);
            LbHkC2.Name = "LbHkC2";
            LbHkC2.Size = new Size(35, 15);
            LbHkC2.TabIndex = 458;
            LbHkC2.Text = "ctrl_2";
            // 
            // TbxHkC1
            // 
            TbxHkC1.Location = new Point(180, 6078);
            TbxHkC1.Margin = new Padding(3, 3, 10, 3);
            TbxHkC1.Name = "TbxHkC1";
            TbxHkC1.Size = new Size(371, 23);
            TbxHkC1.TabIndex = 457;
            // 
            // LbHkC1
            // 
            LbHkC1.AutoSize = true;
            LbHkC1.Location = new Point(14, 6081);
            LbHkC1.Margin = new Padding(8, 12, 8, 0);
            LbHkC1.Name = "LbHkC1";
            LbHkC1.Size = new Size(35, 15);
            LbHkC1.TabIndex = 456;
            LbHkC1.Text = "ctrl_1";
            // 
            // LbHotKeyCtrl
            // 
            LbHotKeyCtrl.AutoSize = true;
            LbHotKeyCtrl.Location = new Point(14, 6054);
            LbHotKeyCtrl.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyCtrl.Name = "LbHotKeyCtrl";
            LbHotKeyCtrl.Size = new Size(83, 15);
            LbHotKeyCtrl.TabIndex = 455;
            LbHotKeyCtrl.Text = "ctrl+# hotkeys";
            // 
            // TbxHKCN0
            // 
            TbxHKCN0.Location = new Point(180, 6618);
            TbxHKCN0.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN0.Name = "TbxHKCN0";
            TbxHKCN0.Size = new Size(371, 23);
            TbxHKCN0.TabIndex = 496;
            // 
            // LbHkCN0
            // 
            LbHkCN0.AutoSize = true;
            LbHkCN0.Location = new Point(14, 6621);
            LbHkCN0.Margin = new Padding(8, 12, 8, 0);
            LbHkCN0.Name = "LbHkCN0";
            LbHkCN0.Size = new Size(65, 15);
            LbHkCN0.TabIndex = 495;
            LbHkCN0.Text = "ctrl_num_0";
            // 
            // TbxHKCN9
            // 
            TbxHKCN9.Location = new Point(180, 6591);
            TbxHKCN9.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN9.Name = "TbxHKCN9";
            TbxHKCN9.Size = new Size(371, 23);
            TbxHKCN9.TabIndex = 494;
            // 
            // LbHkCN9
            // 
            LbHkCN9.AutoSize = true;
            LbHkCN9.Location = new Point(14, 6594);
            LbHkCN9.Margin = new Padding(8, 12, 8, 0);
            LbHkCN9.Name = "LbHkCN9";
            LbHkCN9.Size = new Size(65, 15);
            LbHkCN9.TabIndex = 493;
            LbHkCN9.Text = "ctrl_num_9";
            // 
            // TbxHKCN8
            // 
            TbxHKCN8.Location = new Point(180, 6564);
            TbxHKCN8.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN8.Name = "TbxHKCN8";
            TbxHKCN8.Size = new Size(371, 23);
            TbxHKCN8.TabIndex = 492;
            // 
            // LbHkCN8
            // 
            LbHkCN8.AutoSize = true;
            LbHkCN8.Location = new Point(14, 6567);
            LbHkCN8.Margin = new Padding(8, 12, 8, 0);
            LbHkCN8.Name = "LbHkCN8";
            LbHkCN8.Size = new Size(65, 15);
            LbHkCN8.TabIndex = 491;
            LbHkCN8.Text = "ctrl_num_8";
            // 
            // TbxHKCN7
            // 
            TbxHKCN7.Location = new Point(180, 6537);
            TbxHKCN7.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN7.Name = "TbxHKCN7";
            TbxHKCN7.Size = new Size(371, 23);
            TbxHKCN7.TabIndex = 490;
            // 
            // LbHkCN
            // 
            LbHkCN.AutoSize = true;
            LbHkCN.Location = new Point(14, 6540);
            LbHkCN.Margin = new Padding(8, 12, 8, 0);
            LbHkCN.Name = "LbHkCN";
            LbHkCN.Size = new Size(65, 15);
            LbHkCN.TabIndex = 489;
            LbHkCN.Text = "ctrl_num_7";
            // 
            // TbxHKCN6
            // 
            TbxHKCN6.Location = new Point(180, 6510);
            TbxHKCN6.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN6.Name = "TbxHKCN6";
            TbxHKCN6.Size = new Size(371, 23);
            TbxHKCN6.TabIndex = 488;
            // 
            // LbHkCN6
            // 
            LbHkCN6.AutoSize = true;
            LbHkCN6.Location = new Point(14, 6513);
            LbHkCN6.Margin = new Padding(8, 12, 8, 0);
            LbHkCN6.Name = "LbHkCN6";
            LbHkCN6.Size = new Size(65, 15);
            LbHkCN6.TabIndex = 487;
            LbHkCN6.Text = "ctrl_num_6";
            // 
            // TbxHKCN5
            // 
            TbxHKCN5.Location = new Point(180, 6483);
            TbxHKCN5.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN5.Name = "TbxHKCN5";
            TbxHKCN5.Size = new Size(371, 23);
            TbxHKCN5.TabIndex = 486;
            // 
            // LbHkCN5
            // 
            LbHkCN5.AutoSize = true;
            LbHkCN5.Location = new Point(14, 6486);
            LbHkCN5.Margin = new Padding(8, 12, 8, 0);
            LbHkCN5.Name = "LbHkCN5";
            LbHkCN5.Size = new Size(65, 15);
            LbHkCN5.TabIndex = 485;
            LbHkCN5.Text = "ctrl_num_5";
            // 
            // TbxHKCN4
            // 
            TbxHKCN4.Location = new Point(180, 6456);
            TbxHKCN4.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN4.Name = "TbxHKCN4";
            TbxHKCN4.Size = new Size(371, 23);
            TbxHKCN4.TabIndex = 484;
            // 
            // LbHkCN4
            // 
            LbHkCN4.AutoSize = true;
            LbHkCN4.Location = new Point(14, 6459);
            LbHkCN4.Margin = new Padding(8, 12, 8, 0);
            LbHkCN4.Name = "LbHkCN4";
            LbHkCN4.Size = new Size(65, 15);
            LbHkCN4.TabIndex = 483;
            LbHkCN4.Text = "ctrl_num_4";
            // 
            // TbxHKCN3
            // 
            TbxHKCN3.Location = new Point(180, 6429);
            TbxHKCN3.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN3.Name = "TbxHKCN3";
            TbxHKCN3.Size = new Size(371, 23);
            TbxHKCN3.TabIndex = 482;
            // 
            // LbHkCN3
            // 
            LbHkCN3.AutoSize = true;
            LbHkCN3.Location = new Point(14, 6432);
            LbHkCN3.Margin = new Padding(8, 12, 8, 0);
            LbHkCN3.Name = "LbHkCN3";
            LbHkCN3.Size = new Size(65, 15);
            LbHkCN3.TabIndex = 481;
            LbHkCN3.Text = "ctrl_num_3";
            // 
            // TbxHKCN2
            // 
            TbxHKCN2.Location = new Point(180, 6402);
            TbxHKCN2.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN2.Name = "TbxHKCN2";
            TbxHKCN2.Size = new Size(371, 23);
            TbxHKCN2.TabIndex = 480;
            // 
            // LbHkCN2
            // 
            LbHkCN2.AutoSize = true;
            LbHkCN2.Location = new Point(14, 6405);
            LbHkCN2.Margin = new Padding(8, 12, 8, 0);
            LbHkCN2.Name = "LbHkCN2";
            LbHkCN2.Size = new Size(65, 15);
            LbHkCN2.TabIndex = 479;
            LbHkCN2.Text = "ctrl_num_2";
            // 
            // TbxHKCN1
            // 
            TbxHKCN1.Location = new Point(180, 6375);
            TbxHKCN1.Margin = new Padding(3, 3, 10, 3);
            TbxHKCN1.Name = "TbxHKCN1";
            TbxHKCN1.Size = new Size(371, 23);
            TbxHKCN1.TabIndex = 478;
            // 
            // LbHkCN1
            // 
            LbHkCN1.AutoSize = true;
            LbHkCN1.Location = new Point(14, 6378);
            LbHkCN1.Margin = new Padding(8, 12, 8, 0);
            LbHkCN1.Name = "LbHkCN1";
            LbHkCN1.Size = new Size(65, 15);
            LbHkCN1.TabIndex = 477;
            LbHkCN1.Text = "ctrl_num_1";
            // 
            // LbHotKeyCtrlNum
            // 
            LbHotKeyCtrlNum.AutoSize = true;
            LbHotKeyCtrlNum.Location = new Point(14, 6351);
            LbHotKeyCtrlNum.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyCtrlNum.Name = "LbHotKeyCtrlNum";
            LbHotKeyCtrlNum.Size = new Size(101, 15);
            LbHotKeyCtrlNum.TabIndex = 476;
            LbHotKeyCtrlNum.Text = "ctrl+num hotkeys";
            // 
            // TbxHkCAS0
            // 
            TbxHkCAS0.Location = new Point(180, 6915);
            TbxHkCAS0.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS0.Name = "TbxHkCAS0";
            TbxHkCAS0.Size = new Size(371, 23);
            TbxHkCAS0.TabIndex = 517;
            // 
            // LbHkCAS0
            // 
            LbHkCAS0.AutoSize = true;
            LbHkCAS0.Location = new Point(14, 6918);
            LbHkCAS0.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS0.Name = "LbHkCAS0";
            LbHkCAS0.Size = new Size(81, 15);
            LbHkCAS0.TabIndex = 516;
            LbHkCAS0.Text = "ctrl_alt_shift_0";
            // 
            // TbxHkCAS9
            // 
            TbxHkCAS9.Location = new Point(180, 6888);
            TbxHkCAS9.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS9.Name = "TbxHkCAS9";
            TbxHkCAS9.Size = new Size(371, 23);
            TbxHkCAS9.TabIndex = 515;
            // 
            // LbHkCAS9
            // 
            LbHkCAS9.AutoSize = true;
            LbHkCAS9.Location = new Point(14, 6891);
            LbHkCAS9.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS9.Name = "LbHkCAS9";
            LbHkCAS9.Size = new Size(81, 15);
            LbHkCAS9.TabIndex = 514;
            LbHkCAS9.Text = "ctrl_alt_shift_9";
            // 
            // TbxHkCAS8
            // 
            TbxHkCAS8.Location = new Point(180, 6861);
            TbxHkCAS8.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS8.Name = "TbxHkCAS8";
            TbxHkCAS8.Size = new Size(371, 23);
            TbxHkCAS8.TabIndex = 513;
            // 
            // LbHkCAS8
            // 
            LbHkCAS8.AutoSize = true;
            LbHkCAS8.Location = new Point(14, 6864);
            LbHkCAS8.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS8.Name = "LbHkCAS8";
            LbHkCAS8.Size = new Size(81, 15);
            LbHkCAS8.TabIndex = 512;
            LbHkCAS8.Text = "ctrl_alt_shift_8";
            // 
            // TbxHkCAS7
            // 
            TbxHkCAS7.Location = new Point(180, 6834);
            TbxHkCAS7.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS7.Name = "TbxHkCAS7";
            TbxHkCAS7.Size = new Size(371, 23);
            TbxHkCAS7.TabIndex = 511;
            // 
            // LbHkCAS7
            // 
            LbHkCAS7.AutoSize = true;
            LbHkCAS7.Location = new Point(14, 6837);
            LbHkCAS7.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS7.Name = "LbHkCAS7";
            LbHkCAS7.Size = new Size(81, 15);
            LbHkCAS7.TabIndex = 510;
            LbHkCAS7.Text = "ctrl_alt_shift_7";
            // 
            // TbxHkCAS6
            // 
            TbxHkCAS6.Location = new Point(180, 6807);
            TbxHkCAS6.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS6.Name = "TbxHkCAS6";
            TbxHkCAS6.Size = new Size(371, 23);
            TbxHkCAS6.TabIndex = 509;
            // 
            // LbHkCAS6
            // 
            LbHkCAS6.AutoSize = true;
            LbHkCAS6.Location = new Point(14, 6810);
            LbHkCAS6.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS6.Name = "LbHkCAS6";
            LbHkCAS6.Size = new Size(81, 15);
            LbHkCAS6.TabIndex = 508;
            LbHkCAS6.Text = "ctrl_alt_shift_6";
            // 
            // TbxHkCAS5
            // 
            TbxHkCAS5.Location = new Point(180, 6780);
            TbxHkCAS5.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS5.Name = "TbxHkCAS5";
            TbxHkCAS5.Size = new Size(371, 23);
            TbxHkCAS5.TabIndex = 507;
            // 
            // LbHkCAS5
            // 
            LbHkCAS5.AutoSize = true;
            LbHkCAS5.Location = new Point(14, 6783);
            LbHkCAS5.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS5.Name = "LbHkCAS5";
            LbHkCAS5.Size = new Size(81, 15);
            LbHkCAS5.TabIndex = 506;
            LbHkCAS5.Text = "ctrl_alt_shift_5";
            // 
            // TbxHkCAS4
            // 
            TbxHkCAS4.Location = new Point(180, 6753);
            TbxHkCAS4.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS4.Name = "TbxHkCAS4";
            TbxHkCAS4.Size = new Size(371, 23);
            TbxHkCAS4.TabIndex = 505;
            // 
            // LbHkCAS4
            // 
            LbHkCAS4.AutoSize = true;
            LbHkCAS4.Location = new Point(14, 6756);
            LbHkCAS4.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS4.Name = "LbHkCAS4";
            LbHkCAS4.Size = new Size(81, 15);
            LbHkCAS4.TabIndex = 504;
            LbHkCAS4.Text = "ctrl_alt_shift_4";
            // 
            // TbxHkCAS3
            // 
            TbxHkCAS3.Location = new Point(180, 6726);
            TbxHkCAS3.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS3.Name = "TbxHkCAS3";
            TbxHkCAS3.Size = new Size(371, 23);
            TbxHkCAS3.TabIndex = 503;
            // 
            // LbHkCAS3
            // 
            LbHkCAS3.AutoSize = true;
            LbHkCAS3.Location = new Point(14, 6729);
            LbHkCAS3.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS3.Name = "LbHkCAS3";
            LbHkCAS3.Size = new Size(81, 15);
            LbHkCAS3.TabIndex = 502;
            LbHkCAS3.Text = "ctrl_alt_shift_3";
            // 
            // TbxHkCAS2
            // 
            TbxHkCAS2.Location = new Point(180, 6699);
            TbxHkCAS2.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS2.Name = "TbxHkCAS2";
            TbxHkCAS2.Size = new Size(371, 23);
            TbxHkCAS2.TabIndex = 501;
            // 
            // LbHkCAS2
            // 
            LbHkCAS2.AutoSize = true;
            LbHkCAS2.Location = new Point(14, 6702);
            LbHkCAS2.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS2.Name = "LbHkCAS2";
            LbHkCAS2.Size = new Size(81, 15);
            LbHkCAS2.TabIndex = 500;
            LbHkCAS2.Text = "ctrl_alt_shift_2";
            // 
            // TbxHkCAS1
            // 
            TbxHkCAS1.Location = new Point(180, 6672);
            TbxHkCAS1.Margin = new Padding(3, 3, 10, 3);
            TbxHkCAS1.Name = "TbxHkCAS1";
            TbxHkCAS1.Size = new Size(371, 23);
            TbxHkCAS1.TabIndex = 499;
            // 
            // LbHkCAS1
            // 
            LbHkCAS1.AutoSize = true;
            LbHkCAS1.Location = new Point(14, 6675);
            LbHkCAS1.Margin = new Padding(8, 12, 8, 0);
            LbHkCAS1.Name = "LbHkCAS1";
            LbHkCAS1.Size = new Size(81, 15);
            LbHkCAS1.TabIndex = 498;
            LbHkCAS1.Text = "ctrl_alt_shift_1";
            // 
            // LbHotKeyCtrlAltShift
            // 
            LbHotKeyCtrlAltShift.AutoSize = true;
            LbHotKeyCtrlAltShift.Location = new Point(14, 6648);
            LbHotKeyCtrlAltShift.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyCtrlAltShift.Name = "LbHotKeyCtrlAltShift";
            LbHotKeyCtrlAltShift.Size = new Size(135, 15);
            LbHotKeyCtrlAltShift.TabIndex = 497;
            LbHotKeyCtrlAltShift.Text = "ctrl+alt+shift+# hotkeys";
            // 
            // TbxHkCASN0
            // 
            TbxHkCASN0.Location = new Point(180, 7212);
            TbxHkCASN0.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN0.Name = "TbxHkCASN0";
            TbxHkCASN0.Size = new Size(371, 23);
            TbxHkCASN0.TabIndex = 538;
            // 
            // LbHkCASN0
            // 
            LbHkCASN0.AutoSize = true;
            LbHkCASN0.Location = new Point(14, 7215);
            LbHkCASN0.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN0.Name = "LbHkCASN0";
            LbHkCASN0.Size = new Size(111, 15);
            LbHkCASN0.TabIndex = 537;
            LbHkCASN0.Text = "ctrl_alt_shift_num_0";
            // 
            // TbxHkCASN9
            // 
            TbxHkCASN9.Location = new Point(180, 7185);
            TbxHkCASN9.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN9.Name = "TbxHkCASN9";
            TbxHkCASN9.Size = new Size(371, 23);
            TbxHkCASN9.TabIndex = 536;
            // 
            // LbHkCASN9
            // 
            LbHkCASN9.AutoSize = true;
            LbHkCASN9.Location = new Point(14, 7188);
            LbHkCASN9.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN9.Name = "LbHkCASN9";
            LbHkCASN9.Size = new Size(111, 15);
            LbHkCASN9.TabIndex = 535;
            LbHkCASN9.Text = "ctrl_alt_shift_num_9";
            // 
            // TbxHkCASN8
            // 
            TbxHkCASN8.Location = new Point(180, 7158);
            TbxHkCASN8.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN8.Name = "TbxHkCASN8";
            TbxHkCASN8.Size = new Size(371, 23);
            TbxHkCASN8.TabIndex = 534;
            // 
            // LbHkCASN8
            // 
            LbHkCASN8.AutoSize = true;
            LbHkCASN8.Location = new Point(14, 7161);
            LbHkCASN8.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN8.Name = "LbHkCASN8";
            LbHkCASN8.Size = new Size(111, 15);
            LbHkCASN8.TabIndex = 533;
            LbHkCASN8.Text = "ctrl_alt_shift_num_8";
            // 
            // TbxHkCASN7
            // 
            TbxHkCASN7.Location = new Point(180, 7131);
            TbxHkCASN7.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN7.Name = "TbxHkCASN7";
            TbxHkCASN7.Size = new Size(371, 23);
            TbxHkCASN7.TabIndex = 532;
            // 
            // LbHkCASN7
            // 
            LbHkCASN7.AutoSize = true;
            LbHkCASN7.Location = new Point(14, 7134);
            LbHkCASN7.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN7.Name = "LbHkCASN7";
            LbHkCASN7.Size = new Size(111, 15);
            LbHkCASN7.TabIndex = 531;
            LbHkCASN7.Text = "ctrl_alt_shift_num_7";
            // 
            // TbxHkCASN6
            // 
            TbxHkCASN6.Location = new Point(180, 7104);
            TbxHkCASN6.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN6.Name = "TbxHkCASN6";
            TbxHkCASN6.Size = new Size(371, 23);
            TbxHkCASN6.TabIndex = 530;
            // 
            // LbHkCASN6
            // 
            LbHkCASN6.AutoSize = true;
            LbHkCASN6.Location = new Point(14, 7107);
            LbHkCASN6.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN6.Name = "LbHkCASN6";
            LbHkCASN6.Size = new Size(111, 15);
            LbHkCASN6.TabIndex = 529;
            LbHkCASN6.Text = "ctrl_alt_shift_num_6";
            // 
            // TbxHkCASN5
            // 
            TbxHkCASN5.Location = new Point(180, 7077);
            TbxHkCASN5.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN5.Name = "TbxHkCASN5";
            TbxHkCASN5.Size = new Size(371, 23);
            TbxHkCASN5.TabIndex = 528;
            // 
            // LbHkCASN5
            // 
            LbHkCASN5.AutoSize = true;
            LbHkCASN5.Location = new Point(14, 7080);
            LbHkCASN5.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN5.Name = "LbHkCASN5";
            LbHkCASN5.Size = new Size(111, 15);
            LbHkCASN5.TabIndex = 527;
            LbHkCASN5.Text = "ctrl_alt_shift_num_5";
            // 
            // TbxHkCASN4
            // 
            TbxHkCASN4.Location = new Point(180, 7050);
            TbxHkCASN4.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN4.Name = "TbxHkCASN4";
            TbxHkCASN4.Size = new Size(371, 23);
            TbxHkCASN4.TabIndex = 526;
            // 
            // LbHkCASN4
            // 
            LbHkCASN4.AutoSize = true;
            LbHkCASN4.Location = new Point(14, 7053);
            LbHkCASN4.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN4.Name = "LbHkCASN4";
            LbHkCASN4.Size = new Size(111, 15);
            LbHkCASN4.TabIndex = 525;
            LbHkCASN4.Text = "ctrl_alt_shift_num_4";
            // 
            // TbxHkCASN3
            // 
            TbxHkCASN3.Location = new Point(180, 7023);
            TbxHkCASN3.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN3.Name = "TbxHkCASN3";
            TbxHkCASN3.Size = new Size(371, 23);
            TbxHkCASN3.TabIndex = 524;
            // 
            // LbHkCASN3
            // 
            LbHkCASN3.AutoSize = true;
            LbHkCASN3.Location = new Point(14, 7026);
            LbHkCASN3.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN3.Name = "LbHkCASN3";
            LbHkCASN3.Size = new Size(111, 15);
            LbHkCASN3.TabIndex = 523;
            LbHkCASN3.Text = "ctrl_alt_shift_num_3";
            // 
            // TbxHkCASN2
            // 
            TbxHkCASN2.Location = new Point(180, 6996);
            TbxHkCASN2.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN2.Name = "TbxHkCASN2";
            TbxHkCASN2.Size = new Size(371, 23);
            TbxHkCASN2.TabIndex = 522;
            // 
            // LbHkCASN2
            // 
            LbHkCASN2.AutoSize = true;
            LbHkCASN2.Location = new Point(14, 6999);
            LbHkCASN2.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN2.Name = "LbHkCASN2";
            LbHkCASN2.Size = new Size(111, 15);
            LbHkCASN2.TabIndex = 521;
            LbHkCASN2.Text = "ctrl_alt_shift_num_2";
            // 
            // TbxHkCASN1
            // 
            TbxHkCASN1.Location = new Point(180, 6969);
            TbxHkCASN1.Margin = new Padding(3, 3, 10, 3);
            TbxHkCASN1.Name = "TbxHkCASN1";
            TbxHkCASN1.Size = new Size(371, 23);
            TbxHkCASN1.TabIndex = 520;
            // 
            // LbHkCASN1
            // 
            LbHkCASN1.AutoSize = true;
            LbHkCASN1.Location = new Point(14, 6972);
            LbHkCASN1.Margin = new Padding(8, 12, 8, 0);
            LbHkCASN1.Name = "LbHkCASN1";
            LbHkCASN1.Size = new Size(111, 15);
            LbHkCASN1.TabIndex = 519;
            LbHkCASN1.Text = "ctrl_alt_shift_num_1";
            // 
            // LbHotKeyCtrlAltShiftNum
            // 
            LbHotKeyCtrlAltShiftNum.AutoSize = true;
            LbHotKeyCtrlAltShiftNum.Location = new Point(14, 6945);
            LbHotKeyCtrlAltShiftNum.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyCtrlAltShiftNum.Name = "LbHotKeyCtrlAltShiftNum";
            LbHotKeyCtrlAltShiftNum.Size = new Size(153, 15);
            LbHotKeyCtrlAltShiftNum.TabIndex = 518;
            LbHotKeyCtrlAltShiftNum.Text = "ctrl+alt+shift+num hotkeys";
            // 
            // TbxHkAN0
            // 
            TbxHkAN0.Location = new Point(180, 6024);
            TbxHkAN0.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN0.Name = "TbxHkAN0";
            TbxHkAN0.Size = new Size(371, 23);
            TbxHkAN0.TabIndex = 559;
            // 
            // LbHkAN0
            // 
            LbHkAN0.AutoSize = true;
            LbHkAN0.Location = new Point(14, 6027);
            LbHkAN0.Margin = new Padding(8, 12, 8, 0);
            LbHkAN0.Name = "LbHkAN0";
            LbHkAN0.Size = new Size(61, 15);
            LbHkAN0.TabIndex = 558;
            LbHkAN0.Text = "alt_num_0";
            // 
            // TbxHkAN9
            // 
            TbxHkAN9.Location = new Point(180, 5997);
            TbxHkAN9.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN9.Name = "TbxHkAN9";
            TbxHkAN9.Size = new Size(371, 23);
            TbxHkAN9.TabIndex = 557;
            // 
            // LbHkAN9
            // 
            LbHkAN9.AutoSize = true;
            LbHkAN9.Location = new Point(14, 6000);
            LbHkAN9.Margin = new Padding(8, 12, 8, 0);
            LbHkAN9.Name = "LbHkAN9";
            LbHkAN9.Size = new Size(61, 15);
            LbHkAN9.TabIndex = 556;
            LbHkAN9.Text = "alt_num_9";
            // 
            // TbxHkAN8
            // 
            TbxHkAN8.Location = new Point(180, 5970);
            TbxHkAN8.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN8.Name = "TbxHkAN8";
            TbxHkAN8.Size = new Size(371, 23);
            TbxHkAN8.TabIndex = 555;
            // 
            // LbHkAN8
            // 
            LbHkAN8.AutoSize = true;
            LbHkAN8.Location = new Point(14, 5973);
            LbHkAN8.Margin = new Padding(8, 12, 8, 0);
            LbHkAN8.Name = "LbHkAN8";
            LbHkAN8.Size = new Size(61, 15);
            LbHkAN8.TabIndex = 554;
            LbHkAN8.Text = "alt_num_8";
            // 
            // TbxHkAN7
            // 
            TbxHkAN7.Location = new Point(180, 5943);
            TbxHkAN7.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN7.Name = "TbxHkAN7";
            TbxHkAN7.Size = new Size(371, 23);
            TbxHkAN7.TabIndex = 553;
            // 
            // LbHkAN7
            // 
            LbHkAN7.AutoSize = true;
            LbHkAN7.Location = new Point(14, 5946);
            LbHkAN7.Margin = new Padding(8, 12, 8, 0);
            LbHkAN7.Name = "LbHkAN7";
            LbHkAN7.Size = new Size(61, 15);
            LbHkAN7.TabIndex = 552;
            LbHkAN7.Text = "alt_num_7";
            // 
            // TbxHkAN6
            // 
            TbxHkAN6.Location = new Point(180, 5916);
            TbxHkAN6.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN6.Name = "TbxHkAN6";
            TbxHkAN6.Size = new Size(371, 23);
            TbxHkAN6.TabIndex = 551;
            // 
            // LbHkAN6
            // 
            LbHkAN6.AutoSize = true;
            LbHkAN6.Location = new Point(14, 5919);
            LbHkAN6.Margin = new Padding(8, 12, 8, 0);
            LbHkAN6.Name = "LbHkAN6";
            LbHkAN6.Size = new Size(61, 15);
            LbHkAN6.TabIndex = 550;
            LbHkAN6.Text = "alt_num_6";
            // 
            // TbxHkAN5
            // 
            TbxHkAN5.Location = new Point(180, 5889);
            TbxHkAN5.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN5.Name = "TbxHkAN5";
            TbxHkAN5.Size = new Size(371, 23);
            TbxHkAN5.TabIndex = 549;
            // 
            // LbHkAN5
            // 
            LbHkAN5.AutoSize = true;
            LbHkAN5.Location = new Point(14, 5892);
            LbHkAN5.Margin = new Padding(8, 12, 8, 0);
            LbHkAN5.Name = "LbHkAN5";
            LbHkAN5.Size = new Size(61, 15);
            LbHkAN5.TabIndex = 548;
            LbHkAN5.Text = "alt_num_5";
            // 
            // TbxHkAN4
            // 
            TbxHkAN4.Location = new Point(180, 5862);
            TbxHkAN4.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN4.Name = "TbxHkAN4";
            TbxHkAN4.Size = new Size(371, 23);
            TbxHkAN4.TabIndex = 547;
            // 
            // LbHkAN4
            // 
            LbHkAN4.AutoSize = true;
            LbHkAN4.Location = new Point(14, 5865);
            LbHkAN4.Margin = new Padding(8, 12, 8, 0);
            LbHkAN4.Name = "LbHkAN4";
            LbHkAN4.Size = new Size(61, 15);
            LbHkAN4.TabIndex = 546;
            LbHkAN4.Text = "alt_num_4";
            // 
            // TbxHkAN3
            // 
            TbxHkAN3.Location = new Point(180, 5835);
            TbxHkAN3.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN3.Name = "TbxHkAN3";
            TbxHkAN3.Size = new Size(371, 23);
            TbxHkAN3.TabIndex = 545;
            // 
            // LbHkAN3
            // 
            LbHkAN3.AutoSize = true;
            LbHkAN3.Location = new Point(14, 5838);
            LbHkAN3.Margin = new Padding(8, 12, 8, 0);
            LbHkAN3.Name = "LbHkAN3";
            LbHkAN3.Size = new Size(61, 15);
            LbHkAN3.TabIndex = 544;
            LbHkAN3.Text = "alt_num_3";
            // 
            // TbxHkAN2
            // 
            TbxHkAN2.Location = new Point(180, 5808);
            TbxHkAN2.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN2.Name = "TbxHkAN2";
            TbxHkAN2.Size = new Size(371, 23);
            TbxHkAN2.TabIndex = 543;
            // 
            // LbHkAN2
            // 
            LbHkAN2.AutoSize = true;
            LbHkAN2.Location = new Point(14, 5811);
            LbHkAN2.Margin = new Padding(8, 12, 8, 0);
            LbHkAN2.Name = "LbHkAN2";
            LbHkAN2.Size = new Size(61, 15);
            LbHkAN2.TabIndex = 542;
            LbHkAN2.Text = "alt_num_2";
            // 
            // TbxHkAN1
            // 
            TbxHkAN1.Location = new Point(180, 5781);
            TbxHkAN1.Margin = new Padding(3, 3, 10, 3);
            TbxHkAN1.Name = "TbxHkAN1";
            TbxHkAN1.Size = new Size(371, 23);
            TbxHkAN1.TabIndex = 541;
            // 
            // LbHkAN1
            // 
            LbHkAN1.AutoSize = true;
            LbHkAN1.Location = new Point(14, 5784);
            LbHkAN1.Margin = new Padding(8, 12, 8, 0);
            LbHkAN1.Name = "LbHkAN1";
            LbHkAN1.Size = new Size(61, 15);
            LbHkAN1.TabIndex = 540;
            LbHkAN1.Text = "alt_num_1";
            // 
            // LbHotKeyAltNum
            // 
            LbHotKeyAltNum.AutoSize = true;
            LbHotKeyAltNum.Location = new Point(14, 5757);
            LbHotKeyAltNum.Margin = new Padding(8, 12, 8, 0);
            LbHotKeyAltNum.Name = "LbHotKeyAltNum";
            LbHotKeyAltNum.Size = new Size(97, 15);
            LbHotKeyAltNum.TabIndex = 539;
            LbHotKeyAltNum.Text = "alt+num hotkeys";
            // 
            // BtnCCColor
            // 
            BtnCCColor.FlatStyle = FlatStyle.Popup;
            BtnCCColor.Location = new Point(558, 3532);
            BtnCCColor.Margin = new Padding(15, 3, 3, 3);
            BtnCCColor.Name = "BtnCCColor";
            BtnCCColor.Size = new Size(24, 23);
            BtnCCColor.TabIndex = 560;
            BtnCCColor.UseVisualStyleBackColor = true;
            // 
            // BtnCMFfaColor
            // 
            BtnCMFfaColor.FlatStyle = FlatStyle.Popup;
            BtnCMFfaColor.Location = new Point(558, 3864);
            BtnCMFfaColor.Margin = new Padding(15, 3, 3, 3);
            BtnCMFfaColor.Name = "BtnCMFfaColor";
            BtnCMFfaColor.Size = new Size(24, 23);
            BtnCMFfaColor.TabIndex = 561;
            BtnCMFfaColor.UseVisualStyleBackColor = true;
            // 
            // BtnCMRedColor
            // 
            BtnCMRedColor.FlatStyle = FlatStyle.Popup;
            BtnCMRedColor.Location = new Point(558, 3891);
            BtnCMRedColor.Margin = new Padding(15, 3, 3, 3);
            BtnCMRedColor.Name = "BtnCMRedColor";
            BtnCMRedColor.Size = new Size(24, 23);
            BtnCMRedColor.TabIndex = 562;
            BtnCMRedColor.UseVisualStyleBackColor = true;
            // 
            // BtnCMBlueColor
            // 
            BtnCMBlueColor.FlatStyle = FlatStyle.Popup;
            BtnCMBlueColor.Location = new Point(558, 3918);
            BtnCMBlueColor.Margin = new Padding(15, 3, 3, 3);
            BtnCMBlueColor.Name = "BtnCMBlueColor";
            BtnCMBlueColor.Size = new Size(24, 23);
            BtnCMBlueColor.TabIndex = 563;
            BtnCMBlueColor.UseVisualStyleBackColor = true;
            // 
            // BtnCIColor
            // 
            BtnCIColor.FlatStyle = FlatStyle.Popup;
            BtnCIColor.Location = new Point(558, 4250);
            BtnCIColor.Margin = new Padding(15, 3, 3, 3);
            BtnCIColor.Name = "BtnCIColor";
            BtnCIColor.Size = new Size(24, 23);
            BtnCIColor.TabIndex = 564;
            BtnCIColor.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(638, 1057);
            Controls.Add(BtnCIColor);
            Controls.Add(BtnCMBlueColor);
            Controls.Add(BtnCMRedColor);
            Controls.Add(BtnCMFfaColor);
            Controls.Add(BtnCCColor);
            Controls.Add(TbxHkAN0);
            Controls.Add(LbHkAN0);
            Controls.Add(TbxHkAN9);
            Controls.Add(LbHkAN9);
            Controls.Add(TbxHkAN8);
            Controls.Add(LbHkAN8);
            Controls.Add(TbxHkAN7);
            Controls.Add(LbHkAN7);
            Controls.Add(TbxHkAN6);
            Controls.Add(LbHkAN6);
            Controls.Add(TbxHkAN5);
            Controls.Add(LbHkAN5);
            Controls.Add(TbxHkAN4);
            Controls.Add(LbHkAN4);
            Controls.Add(TbxHkAN3);
            Controls.Add(LbHkAN3);
            Controls.Add(TbxHkAN2);
            Controls.Add(LbHkAN2);
            Controls.Add(TbxHkAN1);
            Controls.Add(LbHkAN1);
            Controls.Add(LbHotKeyAltNum);
            Controls.Add(TbxHkCASN0);
            Controls.Add(LbHkCASN0);
            Controls.Add(TbxHkCASN9);
            Controls.Add(LbHkCASN9);
            Controls.Add(TbxHkCASN8);
            Controls.Add(LbHkCASN8);
            Controls.Add(TbxHkCASN7);
            Controls.Add(LbHkCASN7);
            Controls.Add(TbxHkCASN6);
            Controls.Add(LbHkCASN6);
            Controls.Add(TbxHkCASN5);
            Controls.Add(LbHkCASN5);
            Controls.Add(TbxHkCASN4);
            Controls.Add(LbHkCASN4);
            Controls.Add(TbxHkCASN3);
            Controls.Add(LbHkCASN3);
            Controls.Add(TbxHkCASN2);
            Controls.Add(LbHkCASN2);
            Controls.Add(TbxHkCASN1);
            Controls.Add(LbHkCASN1);
            Controls.Add(LbHotKeyCtrlAltShiftNum);
            Controls.Add(TbxHkCAS0);
            Controls.Add(LbHkCAS0);
            Controls.Add(TbxHkCAS9);
            Controls.Add(LbHkCAS9);
            Controls.Add(TbxHkCAS8);
            Controls.Add(LbHkCAS8);
            Controls.Add(TbxHkCAS7);
            Controls.Add(LbHkCAS7);
            Controls.Add(TbxHkCAS6);
            Controls.Add(LbHkCAS6);
            Controls.Add(TbxHkCAS5);
            Controls.Add(LbHkCAS5);
            Controls.Add(TbxHkCAS4);
            Controls.Add(LbHkCAS4);
            Controls.Add(TbxHkCAS3);
            Controls.Add(LbHkCAS3);
            Controls.Add(TbxHkCAS2);
            Controls.Add(LbHkCAS2);
            Controls.Add(TbxHkCAS1);
            Controls.Add(LbHkCAS1);
            Controls.Add(LbHotKeyCtrlAltShift);
            Controls.Add(TbxHKCN0);
            Controls.Add(LbHkCN0);
            Controls.Add(TbxHKCN9);
            Controls.Add(LbHkCN9);
            Controls.Add(TbxHKCN8);
            Controls.Add(LbHkCN8);
            Controls.Add(TbxHKCN7);
            Controls.Add(LbHkCN);
            Controls.Add(TbxHKCN6);
            Controls.Add(LbHkCN6);
            Controls.Add(TbxHKCN5);
            Controls.Add(LbHkCN5);
            Controls.Add(TbxHKCN4);
            Controls.Add(LbHkCN4);
            Controls.Add(TbxHKCN3);
            Controls.Add(LbHkCN3);
            Controls.Add(TbxHKCN2);
            Controls.Add(LbHkCN2);
            Controls.Add(TbxHKCN1);
            Controls.Add(LbHkCN1);
            Controls.Add(LbHotKeyCtrlNum);
            Controls.Add(TbxHkC0);
            Controls.Add(LbHkC0);
            Controls.Add(TbxHkC9);
            Controls.Add(LbHkC9);
            Controls.Add(TbxHkC8);
            Controls.Add(LbHkC8);
            Controls.Add(TbxHkC7);
            Controls.Add(LbHkC7);
            Controls.Add(TbxHkC6);
            Controls.Add(LbHkC6);
            Controls.Add(TbxHkC5);
            Controls.Add(LbHkC5);
            Controls.Add(TbxHkC4);
            Controls.Add(LbHkC4);
            Controls.Add(TbxHkC3);
            Controls.Add(LbHkC3);
            Controls.Add(TbxHkC2);
            Controls.Add(LbHkC2);
            Controls.Add(TbxHkC1);
            Controls.Add(LbHkC1);
            Controls.Add(LbHotKeyCtrl);
            Controls.Add(TbxHkA0);
            Controls.Add(LbHkA0);
            Controls.Add(TbxHkA9);
            Controls.Add(LbHkA9);
            Controls.Add(TbxHkA8);
            Controls.Add(LbHkA8);
            Controls.Add(TbxHkA7);
            Controls.Add(LbHkA7);
            Controls.Add(TbxHkA6);
            Controls.Add(LbHkA6);
            Controls.Add(TbxHkA5);
            Controls.Add(LbHkA5);
            Controls.Add(TbxHkA4);
            Controls.Add(LbHkA4);
            Controls.Add(TbxHkA3);
            Controls.Add(LbHkA3);
            Controls.Add(TbxHkA2);
            Controls.Add(LbHkA2);
            Controls.Add(TbxHkA1);
            Controls.Add(LbHkA1);
            Controls.Add(LbHotKeyAlt);
            Controls.Add(TbxHKASN0);
            Controls.Add(LbHKASN0);
            Controls.Add(TbxHKASN9);
            Controls.Add(LbHKASN9);
            Controls.Add(TbxHKASN8);
            Controls.Add(LbHKASN8);
            Controls.Add(TbxHKASN7);
            Controls.Add(LbHKASN7);
            Controls.Add(TbxHKASN6);
            Controls.Add(LbHKASN6);
            Controls.Add(TbxHKASN5);
            Controls.Add(LbHKASN5);
            Controls.Add(TbxHKASN4);
            Controls.Add(LbHKASN4);
            Controls.Add(TbxHKASN3);
            Controls.Add(LbHKASN3);
            Controls.Add(TbxHKASN2);
            Controls.Add(LbHKASN2);
            Controls.Add(TbxHKASN1);
            Controls.Add(LbHKASN1);
            Controls.Add(LbHotKeyAltShiftNum);
            Controls.Add(TbxHKAS0);
            Controls.Add(LbHKAS0);
            Controls.Add(TbxHKAS9);
            Controls.Add(LbHKAS9);
            Controls.Add(TbxHKAS8);
            Controls.Add(LbHKAS8);
            Controls.Add(TbxHKAS7);
            Controls.Add(LbHKAS7);
            Controls.Add(TbxHKAS6);
            Controls.Add(LbHKAS6);
            Controls.Add(TbxHKAS5);
            Controls.Add(LbHKAS5);
            Controls.Add(TbxHKAS4);
            Controls.Add(LbHKAS4);
            Controls.Add(TbxHKAS3);
            Controls.Add(LbHKAS3);
            Controls.Add(TbxHKAS2);
            Controls.Add(LbHKAS2);
            Controls.Add(TbxHKAS1);
            Controls.Add(LbHKAS1);
            Controls.Add(LbHotKeyAltShift);
            Controls.Add(TbxHKF12);
            Controls.Add(LbHKF12);
            Controls.Add(TbxHKF11);
            Controls.Add(LbHKF11);
            Controls.Add(TbxHKF10);
            Controls.Add(LbHKF10);
            Controls.Add(TbxHKF9);
            Controls.Add(LbHKF9);
            Controls.Add(TbxHKF8);
            Controls.Add(LbHKF8);
            Controls.Add(TbxHKF7);
            Controls.Add(LbHKF7);
            Controls.Add(TbxHKF6);
            Controls.Add(LbHKF6);
            Controls.Add(TbxHKF5);
            Controls.Add(LbHKF5);
            Controls.Add(TbxHKF4);
            Controls.Add(LbHKF4);
            Controls.Add(TbxHKF3);
            Controls.Add(LbHKF3);
            Controls.Add(TbxHKF2);
            Controls.Add(LbHKF2);
            Controls.Add(TbxHKF1);
            Controls.Add(LbHKF1);
            Controls.Add(LbHotKeyFunction);
            Controls.Add(CbHotKeyEnabled);
            Controls.Add(LbHotKeyEnabled);
            Controls.Add(PnlHotkey);
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
            Controls.Add(PnlEnd);
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
            Controls.Add(PnlHalo);
            Controls.Add(PnlSvMsg);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            PnlHotkey.ResumeLayout(false);
            PnlHotkey.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlHalo;
        private Label LbHalo;
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
        private Panel PnlEnd;
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
        private TextBox TbxHKAS6;
        private TextBox TbxChtMsgLineH;
        private TextBox TbxChtMsgFadeTime;
        private TextBox TbxChtMsgDisTime;
        private TextBox TbxChtMsgAniTime;
        private TextBox TbxHkCASN7;
        private TextBox TbxChtMsgOC;
        private TextBox TbxChtMsgDimX;
        private TextBox TbxHkCASN4;
        private Label LbHKAS7;
        private Label LbHKAS6;
        private Label LbHKAS5;
        private TextBox TbxChtMsgFfa;
        private TextBox TbxHkCASN2;
        private TextBox TbxHkCASN1;
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
        private Label LbHkCASN1;
        private Label LbChtMsgFfa;
        private Panel PnlChtMsg;
        private Label LbHkAN9;
        private Label LbHkAN8;
        private Label LbHkAN7;
        private TextBox TbxHkAN0;
        private TextBox TbxHkAN9;
        private TextBox TbxHkAN8;
        private Label LbHkAN6;
        private Label LbHkAN5;
        private Label LbHkAN4;
        private TextBox TbxHkAN7;
        private TextBox TbxHkAN6;
        private TextBox TbxHkAN5;
        private Label LbSvMsgColorB;
        private TextBox TbxSvMsgColorB;
        private Label LbHkAN2;
        private TextBox TbxHkAN3;
        private Label LbHkAN1;
        private TextBox TbxHkAN2;
        private Label LbChtMsgFfaB;
        private TextBox TbxHkAN1;
        private Label label47;
        private Label label46;
        private Label LbHkAN0;
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
        private Label LbHKF2;
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
        private Panel PnlHotkey;
        private Label LbHotKeyDesc;
        private Label LbHotKey;
        private CheckBox CbHotKeyEnabled;
        private Label LbHotKeyEnabled;
        private TextBox TbxHKF3;
        private Label LbHKF3;
        private TextBox TbxHKF2;
        private TextBox TbxHKF1;
        private Label LbHKF1;
        private Label LbHotKeyFunction;
        private TextBox TbxHKF6;
        private Label LbHKF6;
        private TextBox TbxHKF5;
        private Label LbHKF5;
        private TextBox TbxHKF4;
        private Label LbHKF4;
        private TextBox TbxHKF9;
        private Label LbHKF9;
        private TextBox TbxHKF8;
        private Label LbHKF8;
        private TextBox TbxHKF7;
        private Label LbHKF7;
        private TextBox TbxHKF12;
        private Label LbHKF12;
        private TextBox TbxHKF11;
        private Label LbHKF11;
        private TextBox TbxHKF10;
        private Label LbHKF10;
        private Label LbHotKeyAltShift;
        private TextBox TbxHKAS0;
        private Label LbHKAS0;
        private TextBox TbxHKAS9;
        private Label LbHKAS9;
        private TextBox TbxHKAS8;
        private Label LbHKAS8;
        private TextBox TbxHKAS7;
        private TextBox TbxHKAS5;
        private TextBox TbxHKAS4;
        private Label LbHKAS4;
        private TextBox TbxHKAS3;
        private Label LbHKAS3;
        private TextBox TbxHKAS2;
        private Label LbHKAS2;
        private TextBox TbxHKAS1;
        private Label LbHKAS1;
        private TextBox TbxHKASN0;
        private Label LbHKASN0;
        private TextBox TbxHKASN9;
        private Label LbHKASN9;
        private TextBox TbxHKASN8;
        private Label LbHKASN8;
        private TextBox TbxHKASN7;
        private Label LbHKASN7;
        private TextBox TbxHKASN6;
        private Label LbHKASN6;
        private TextBox TbxHKASN5;
        private Label LbHKASN5;
        private TextBox TbxHKASN4;
        private Label LbHKASN4;
        private TextBox TbxHKASN3;
        private Label LbHKASN3;
        private TextBox TbxHKASN2;
        private Label LbHKASN2;
        private TextBox TbxHKASN1;
        private Label LbHKASN1;
        private Label LbHotKeyAltShiftNum;
        private TextBox TbxHkA0;
        private Label LbHkA0;
        private TextBox TbxHkA9;
        private Label LbHkA9;
        private TextBox TbxHkA8;
        private Label LbHkA8;
        private TextBox TbxHkA7;
        private Label LbHkA7;
        private TextBox TbxHkA6;
        private Label LbHkA6;
        private TextBox TbxHkA5;
        private Label LbHkA5;
        private TextBox TbxHkA4;
        private Label LbHkA4;
        private TextBox TbxHkA3;
        private Label LbHkA3;
        private TextBox TbxHkA2;
        private Label LbHkA2;
        private TextBox TbxHkA1;
        private Label LbHkA1;
        private Label LbHotKeyAlt;
        private TextBox TbxHkC0;
        private Label LbHkC0;
        private TextBox TbxHkC9;
        private Label LbHkC9;
        private TextBox TbxHkC8;
        private Label LbHkC8;
        private TextBox TbxHkC7;
        private Label LbHkC7;
        private TextBox TbxHkC6;
        private Label LbHkC6;
        private TextBox TbxHkC5;
        private Label LbHkC5;
        private TextBox TbxHkC4;
        private Label LbHkC4;
        private TextBox TbxHkC3;
        private Label LbHkC3;
        private TextBox TbxHkC2;
        private Label LbHkC2;
        private TextBox TbxHkC1;
        private Label LbHkC1;
        private Label LbHotKeyCtrl;
        private TextBox TbxHKCN0;
        private Label LbHkCN0;
        private TextBox TbxHKCN9;
        private Label LbHkCN9;
        private TextBox TbxHKCN8;
        private Label LbHkCN8;
        private TextBox TbxHKCN7;
        private Label LbHkCN;
        private TextBox TbxHKCN6;
        private Label LbHkCN6;
        private TextBox TbxHKCN5;
        private Label LbHkCN5;
        private TextBox TbxHKCN4;
        private Label LbHkCN4;
        private TextBox TbxHKCN3;
        private Label LbHkCN3;
        private TextBox TbxHKCN2;
        private Label LbHkCN2;
        private TextBox TbxHKCN1;
        private Label LbHkCN1;
        private Label LbHotKeyCtrlNum;
        private TextBox TbxHkCAS0;
        private Label LbHkCAS0;
        private TextBox TbxHkCAS9;
        private Label LbHkCAS9;
        private TextBox TbxHkCAS8;
        private Label LbHkCAS8;
        private TextBox TbxHkCAS7;
        private Label LbHkCAS7;
        private TextBox TbxHkCAS6;
        private Label LbHkCAS6;
        private TextBox TbxHkCAS5;
        private Label LbHkCAS5;
        private TextBox TbxHkCAS4;
        private Label LbHkCAS4;
        private TextBox TbxHkCAS3;
        private Label LbHkCAS3;
        private TextBox TbxHkCAS2;
        private Label LbHkCAS2;
        private TextBox TbxHkCAS1;
        private Label LbHkCAS1;
        private Label LbHotKeyCtrlAltShift;
        private TextBox TbxHkCASN0;
        private Label LbHkCASN0;
        private TextBox TbxHkCASN9;
        private Label LbHkCASN9;
        private TextBox TbxHkCASN8;
        private Label LbHkCASN8;
        private Label LbHkCASN7;
        private TextBox TbxHkCASN6;
        private Label LbHkCASN6;
        private TextBox TbxHkCASN5;
        private Label LbHkCASN5;
        private Label LbHkCASN4;
        private TextBox TbxHkCASN3;
        private Label LbHkCASN3;
        private Label LbHkCASN2;
        private Label LbHotKeyCtrlAltShiftNum;
        private TextBox TbxHkAN4;
        private Label LbHkAN3;
        private Label LbHotKeyAltNum;
        private Button BtnCCColor;
        private Button BtnCMFfaColor;
        private Button BtnCMRedColor;
        private Button BtnCMBlueColor;
        private Button BtnCIColor;
    }
}