using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chimera_editor.Logical
{
    internal class Chimera
    {
        //Definicion de atributos
        private string Path;
        private int BoolPath;
        private int BoolDownPath;
        private string DownPath;
        private int BoolMapsPath;
        private string MapsPath;
        private int BoolExec;
        private string Exec;
        private int GamePorts;
        private int ServerPort;
        private int ClientPort;
        private int IntroVideos;
        private int Console;
        private int OptiDef;
        private int MenuMusic;
        private int BackPlay;
        private int MultiInst;
        private int BoolHash;
        private string Hash;
        private int ShowSeg;
        private int SupFatal;
        private int EnblVideoMode;
        private int ResHeight;
        private int Resolution;
        private int ResWidth;
        private int BoolRefRate;
        private int RefRate;
        private int BoolVsync;
        private int Vsync;
        private int Windowed;
        private int Borderless;
        private int AutoQuery;
        private string MstrSvList;
        private double ScoreboardFade;
        private string ScoreboardFont;
        private string NameFont;
        private int BoolMstrSvList;
        private int BoolMstrSvKey;
        private string MstrSvKey;
        private int BoolMstrSvNatP;
        private string MstrSvNatP;
        private int BoolMstrSvNatS;
        private string MstrSvNatS;
        private int BoolMapSize;
        private string MapSize;
        private int MapMmryBuffer;
        private int Benchmark;
        private string DownloadFont;
        private string DownloadUrl;
        private int DownloadRetail;
        private int FontOverEnabled;
        private int SystemFW;
        private int SystemFO;
        private string SystemFF; //fuente de system
        private int SystemFS;
        private int SystemXO;
        private int SystemSX;
        private int SystemSY;
        private int SystemYO;
        private int LargeSY;
        private int LargeYO;
        private int LargeSX;
        private int LargeXO;
        private int LargeFS;
        private int LargeFW;
        private int LargeFO;
        private string LargeFF; //fuente de large
        private int SmallSY;
        private int SmallYO;
        private int SmallSX;
        private int SmallXO;
        private int SmallFS;
        private int SmallFW;
        private int SmallFO;
        private string SmallFF; //fuente de small
        private int SmallerSY;
        private int SmallerYO;
        private int SmallerSX;
        private int SmallerXO;
        private int SmallerFS;
        private int SmallerFW;
        private int SmallerFO;
        private string SmallerFF; //fuente de smaller
        private int TickerSY;
        private int TickerYO;
        private int TickerSX;
        private int TickerXO;
        private int TickerFS;
        private int TickerFW;
        private int TickerFO;
        private string TickerFF; //fuente de ticker
        private int ConsoleSY;
        private int ConsoleYO;
        private int ConsoleSX;
        private int ConsoleXO;
        private int ConsoleFS;
        private int ConsoleFW;
        private int ConsoleFO;
        private string ConsoleFF; //fuente de console
        private int ControllerEnabled;
        private int CustomCEnabled;
        //Revisar el tipo de dato de ControllerConfig porque no supe que tipo era
        //Si no es int entonces corregir tambien su set y get
        private string ControllerConfig;
        private int Scrollback;
        private int ConsoleBuffer;
        private int ConsoleSoft;
        private double LineHeight;
        private int XMargin;
        private double CFadeStart;
        private double CFadeTime;
        private int AllowRcon;
        private double SvMsgColorA;
        private double SvMsgColorR;
        private double SvMsgColorG;
        private double SvMsgColorB;
        private int SvMsgOffX;
        private int SvMsgDimX;
        private int SvMsgOC;
        private double SvMsgAniTime;
        private double SvMsgDisTime;
        private double SvMsgFadeTime;
        private double SvMsgLineH;
        private int SvMsgOffY;
        private int SvMsgDimY;
        private int ChtMsgDimY;
        private double ChtMsgLineH;
        private double ChtMsgFadeTime;
        private double ChtMsgDisTime;
        private double ChtMsgAniTime;
        private int ChtMsgOC;
        private int ChtMsgDimX;
        private int ChtInOffY;
        private int ChtInWidth;
        private int ChtInOffX;
        private string SvMsgAnchor;
        private int SvMsgCHide;
        private string SvMsgFont;
        private string ChtMsgFont;
        private int ChtMsgCHide;
        private string ChtMsgAnchor;
        private string ChtInFont;
        private string ChtInAnchor;
        private double ChtMsgRedG;
        private double ChtMsgRedR;
        private double ChtMsgRedA;
        private double ChtMsgRedB;
        private double ChtMsgBlueG;
        private double ChtMsgBlueR;
        private double ChtMsgBlueA;
        private double ChtMsgBlueB;
        private double ChtInColorG;
        private double ChtInColorR;
        private double ChtInColorA;
        private double ChtInColorB;
        private int ChtMsgOffY;
        private int ChtMsgOffX;
        private double ChtMsgFfaB;
        private double ChtMsgFfaG;
        private double ChtMsgFfaR;
        private double ChtMsgFfaA;
        private int HotKeyEnabled;
        //Hotkeys (HK) (guardan Strings)
        private string HKF3;
        private string HKF2;
        private string HKF1;
        private string HKF6;
        private string HKF5;
        private string HKF4;
        private string HKF9;
        private string HKF8;
        private string HKF7;
        private string HKF12;
        private string HKF11;
        private string HKF10;
        private string HKAS0;
        private string HKAS9;
        private string HKAS8;
        private string HKAS7;
        private string HKAS6;
        private string HKAS5;
        private string HKAS4;
        private string HKAS3;
        private string HKAS2;
        private string HKAS1;
        private string HkAN0;
        private string HkAN9;
        private string HkAN8;
        private string HkAN7;
        private string HkAN6;
        private string HkAN5;
        private string HkAN3;
        private string HkAN2;
        private string HkAN1;
        private string HKASN0;
        private string HKASN9;
        private string HKASN8;
        private string HKASN7;
        private string HKASN6;
        private string HKASN5;
        private string HKASN4;
        private string HKASN3;
        private string HKASN2;
        private string HKASN1;
        private string HkA0;
        private string HkA9;
        private string HkA8;
        private string HkA7;
        private string HkA6;
        private string HkA5;
        private string HkA4;
        private string HkA3;
        private string HkA2;
        private string HkA1;
        private string HkC0;
        private string HkC9;
        private string HkC8;
        private string HkC7;
        private string HkC6;
        private string HkC5;
        private string HkC4;
        private string HkC3;
        private string HkC2;
        private string HkC1;
        private string HKCN0;
        private string HKCN9;
        private string HKCN8;
        private string HKCN7;
        private string HKCN6;
        private string HKCN5;
        private string HKCN4;
        private string HKCN3;
        private string HKCN2;
        private string HKCN1;
        private string HkCAS0;
        private string HkCAS9;
        private string HkCAS8;
        private string HkCAS7;
        private string HkCAS6;
        private string HkCAS5;
        private string HkCAS4;
        private string HkCAS3;
        private string HkCAS2;
        private string HkCAS1;
        private string HkCASN0;
        private string HkCASN9;
        private string HkCASN8;
        private string HkCASN6;
        private string HkCASN5;
        private string HkCASN3;
        private string HkCASN7;
        private string HkCASN4;
        private string HkCASN2;
        private string HkCASN1;
        private string HkAN4;

        //Definicion de metodos Set and Get

        public string Path1 { get => Path; set => Path = value; }
        public int BoolPath1 { get => BoolPath; set => BoolPath = value; }
        public int BoolDownPath1 { get => BoolDownPath; set => BoolDownPath = value; }
        public string DownPath1 { get => DownPath; set => DownPath = value; }
        public int BoolMapsPath1 { get => BoolMapsPath; set => BoolMapsPath = value; }
        public string MapsPath1 { get => MapsPath; set => MapsPath = value; }
        public int BoolExec1 { get => BoolExec; set => BoolExec = value; }
        public string Exec1 { get => Exec; set => Exec = value; }
        public int GamePorts1 { get => GamePorts; set => GamePorts = value; }
        public int ServerPort1 { get => ServerPort; set => ServerPort = value; }
        public int ClientPort1 { get => ClientPort; set => ClientPort = value; }
        public int IntroVideos1 { get => IntroVideos; set => IntroVideos = value; }
        public int Console1 { get => Console; set => Console = value; }
        public int OptiDef1 { get => OptiDef; set => OptiDef = value; }
        public int MenuMusic1 { get => MenuMusic; set => MenuMusic = value; }
        public int BackPlay1 { get => BackPlay; set => BackPlay = value; }
        public int MultiInst1 { get => MultiInst; set => MultiInst = value; }
        public int BoolHash1 { get => BoolHash; set => BoolHash = value; }
        public string Hash1 { get => Hash; set => Hash = value; }
        public int ShowSeg1 { get => ShowSeg; set => ShowSeg = value; }
        public int SupFatal1 { get => SupFatal; set => SupFatal = value; }
        public int EnblVideoMode1 { get => EnblVideoMode; set => EnblVideoMode = value; }
        public int ResHeight1 { get => ResHeight; set => ResHeight = value; }
        public int Resolution1 { get => Resolution; set => Resolution = value; }
        public int ResWidth1 { get => ResWidth; set => ResWidth = value; }
        public int BoolRefRate1 { get => BoolRefRate; set => BoolRefRate = value; }
        public int RefRate1 { get => RefRate; set => RefRate = value; }
        public int BoolVsync1 { get => BoolVsync; set => BoolVsync = value; }
        public int Vsync1 { get => Vsync; set => Vsync = value; }
        public int Windowed1 { get => Windowed; set => Windowed = value; }
        public int Borderless1 { get => Borderless; set => Borderless = value; }
        public int AutoQuery1 { get => AutoQuery; set => AutoQuery = value; }
        public string MstrSvList1 { get => MstrSvList; set => MstrSvList = value; }
        public double ScoreboardFade1 { get => ScoreboardFade; set => ScoreboardFade = value; }
        public string ScoreboardFont1 { get => ScoreboardFont; set => ScoreboardFont = value; }
        public string NameFont1 { get => NameFont; set => NameFont = value; }
        public int BoolMstrSvList1 { get => BoolMstrSvList; set => BoolMstrSvList = value; }
        public int BoolMstrSvKey1 { get => BoolMstrSvKey; set => BoolMstrSvKey = value; }
        public string MstrSvKey1 { get => MstrSvKey; set => MstrSvKey = value; }
        public int BoolMstrSvNatP1 { get => BoolMstrSvNatP; set => BoolMstrSvNatP = value; }
        public string MstrSvNatP1 { get => MstrSvNatP; set => MstrSvNatP = value; }
        public int BoolMstrSvNatS1 { get => BoolMstrSvNatS; set => BoolMstrSvNatS = value; }
        public string MstrSvNatS1 { get => MstrSvNatS; set => MstrSvNatS = value; }
        public int BoolMapSize1 { get => BoolMapSize; set => BoolMapSize = value; }
        public string MapSize1 { get => MapSize; set => MapSize = value; }
        public int MapMmryBuffer1 { get => MapMmryBuffer; set => MapMmryBuffer = value; }
        public int Benchmark1 { get => Benchmark; set => Benchmark = value; }
        public string DownloadFont1 { get => DownloadFont; set => DownloadFont = value; }
        public string DownloadUrl1 { get => DownloadUrl; set => DownloadUrl = value; }
        public int DownloadRetail1 { get => DownloadRetail; set => DownloadRetail = value; }
        public int FontOverEnabled1 { get => FontOverEnabled; set => FontOverEnabled = value; }
        public int SystemFW1 { get => SystemFW; set => SystemFW = value; }
        public int SystemFO1 { get => SystemFO; set => SystemFO = value; }
        public string SystemFF1 { get => SystemFF; set => SystemFF = value; }
        public int SystemFS1 { get => SystemFS; set => SystemFS = value; }
        public int SystemXO1 { get => SystemXO; set => SystemXO = value; }
        public int SystemSX1 { get => SystemSX; set => SystemSX = value; }
        public int SystemSY1 { get => SystemSY; set => SystemSY = value; }
        public int SystemYO1 { get => SystemYO; set => SystemYO = value; }
        public int LargeSY1 { get => LargeSY; set => LargeSY = value; }
        public int LargeYO1 { get => LargeYO; set => LargeYO = value; }
        public int LargeSX1 { get => LargeSX; set => LargeSX = value; }
        public int LargeXO1 { get => LargeXO; set => LargeXO = value; }
        public int LargeFS1 { get => LargeFS; set => LargeFS = value; }
        public int LargeFW1 { get => LargeFW; set => LargeFW = value; }
        public int LargeFO1 { get => LargeFO; set => LargeFO = value; }
        public string LargeFF1 { get => LargeFF; set => LargeFF = value; }
        public int SmallSY1 { get => SmallSY; set => SmallSY = value; }
        public int SmallYO1 { get => SmallYO; set => SmallYO = value; }
        public int SmallSX1 { get => SmallSX; set => SmallSX = value; }
        public int SmallXO1 { get => SmallXO; set => SmallXO = value; }
        public int SmallFS1 { get => SmallFS; set => SmallFS = value; }
        public int SmallFW1 { get => SmallFW; set => SmallFW = value; }
        public int SmallFO1 { get => SmallFO; set => SmallFO = value; }
        public string SmallFF1 { get => SmallFF; set => SmallFF = value; }
        public int SmallerSY1 { get => SmallerSY; set => SmallerSY = value; }
        public int SmallerYO1 { get => SmallerYO; set => SmallerYO = value; }
        public int SmallerSX1 { get => SmallerSX; set => SmallerSX = value; }
        public int SmallerXO1 { get => SmallerXO; set => SmallerXO = value; }
        public int SmallerFS1 { get => SmallerFS; set => SmallerFS = value; }
        public int SmallerFW1 { get => SmallerFW; set => SmallerFW = value; }
        public int SmallerFO1 { get => SmallerFO; set => SmallerFO = value; }
        public string SmallerFF1 { get => SmallerFF; set => SmallerFF = value; }
        public int TickerSY1 { get => TickerSY; set => TickerSY = value; }
        public int TickerYO1 { get => TickerYO; set => TickerYO = value; }
        public int TickerSX1 { get => TickerSX; set => TickerSX = value; }
        public int TickerXO1 { get => TickerXO; set => TickerXO = value; }
        public int TickerFS1 { get => TickerFS; set => TickerFS = value; }
        public int TickerFW1 { get => TickerFW; set => TickerFW = value; }
        public int TickerFO1 { get => TickerFO; set => TickerFO = value; }
        public string TickerFF1 { get => TickerFF; set => TickerFF = value; }
        public int ConsoleSY1 { get => ConsoleSY; set => ConsoleSY = value; }
        public int ConsoleYO1 { get => ConsoleYO; set => ConsoleYO = value; }
        public int ConsoleSX1 { get => ConsoleSX; set => ConsoleSX = value; }
        public int ConsoleXO1 { get => ConsoleXO; set => ConsoleXO = value; }
        public int ConsoleFS1 { get => ConsoleFS; set => ConsoleFS = value; }
        public int ConsoleFW1 { get => ConsoleFW; set => ConsoleFW = value; }
        public int ConsoleFO1 { get => ConsoleFO; set => ConsoleFO = value; }
        public string ConsoleFF1 { get => ConsoleFF; set => ConsoleFF = value; }
        public int ControllerEnabled1 { get => ControllerEnabled; set => ControllerEnabled = value; }
        public int CustomCEnabled1 { get => CustomCEnabled; set => CustomCEnabled = value; }
        public string ControllerConfig1 { get => ControllerConfig; set => ControllerConfig = value; }
        public int Scrollback1 { get => Scrollback; set => Scrollback = value; }
        public int ConsoleBuffer1 { get => ConsoleBuffer; set => ConsoleBuffer = value; }
        public int ConsoleSoft1 { get => ConsoleSoft; set => ConsoleSoft = value; }
        public double LineHeight1 { get => LineHeight; set => LineHeight = value; }
        public int XMargin1 { get => XMargin; set => XMargin = value; }
        public double CFadeStart1 { get => CFadeStart; set => CFadeStart = value; }
        public double CFadeTime1 { get => CFadeTime; set => CFadeTime = value; }
        public int AllowRcon1 { get => AllowRcon; set => AllowRcon = value; }
        public double SvMsgColorA1 { get => SvMsgColorA; set => SvMsgColorA = value; }
        public double SvMsgColorR1 { get => SvMsgColorR; set => SvMsgColorR = value; }
        public double SvMsgColorG1 { get => SvMsgColorG; set => SvMsgColorG = value; }
        public double SvMsgColorB1 { get => SvMsgColorB; set => SvMsgColorB = value; }
        public int SvMsgOffX1 { get => SvMsgOffX; set => SvMsgOffX = value; }
        public int SvMsgDimX1 { get => SvMsgDimX; set => SvMsgDimX = value; }
        public int SvMsgOC1 { get => SvMsgOC; set => SvMsgOC = value; }
        public double SvMsgAniTime1 { get => SvMsgAniTime; set => SvMsgAniTime = value; }
        public double SvMsgDisTime1 { get => SvMsgDisTime; set => SvMsgDisTime = value; }
        public double SvMsgFadeTime1 { get => SvMsgFadeTime; set => SvMsgFadeTime = value; }
        public double SvMsgLineH1 { get => SvMsgLineH; set => SvMsgLineH = value; }
        public int SvMsgOffY1 { get => SvMsgOffY; set => SvMsgOffY = value; }
        public int SvMsgDimY1 { get => SvMsgDimY; set => SvMsgDimY = value; }
        public int ChtMsgDimY1 { get => ChtMsgDimY; set => ChtMsgDimY = value; }
        public double ChtMsgLineH1 { get => ChtMsgLineH; set => ChtMsgLineH = value; }
        public double ChtMsgFadeTime1 { get => ChtMsgFadeTime; set => ChtMsgFadeTime = value; }
        public double ChtMsgDisTime1 { get => ChtMsgDisTime; set => ChtMsgDisTime = value; }
        public double ChtMsgAniTime1 { get => ChtMsgAniTime; set => ChtMsgAniTime = value; }
        public int ChtMsgOC1 { get => ChtMsgOC; set => ChtMsgOC = value; }
        public int ChtMsgDimX1 { get => ChtMsgDimX; set => ChtMsgDimX = value; }
        public int ChtInOffY1 { get => ChtInOffY; set => ChtInOffY = value; }
        public int ChtInWidth1 { get => ChtInWidth; set => ChtInWidth = value; }
        public int ChtInOffX1 { get => ChtInOffX; set => ChtInOffX = value; }
        public string SvMsgAnchor1 { get => SvMsgAnchor; set => SvMsgAnchor = value; }
        public int SvMsgCHide1 { get => SvMsgCHide; set => SvMsgCHide = value; }
        public string SvMsgFont1 { get => SvMsgFont; set => SvMsgFont = value; }
        public string ChtMsgFont1 { get => ChtMsgFont; set => ChtMsgFont = value; }
        public int ChtMsgCHide1 { get => ChtMsgCHide; set => ChtMsgCHide = value; }
        public string ChtMsgAnchor1 { get => ChtMsgAnchor; set => ChtMsgAnchor = value; }
        public string ChtInFont1 { get => ChtInFont; set => ChtInFont = value; }
        public string ChtInAnchor1 { get => ChtInAnchor; set => ChtInAnchor = value; }
        public double ChtMsgRedG1 { get => ChtMsgRedG; set => ChtMsgRedG = value; }
        public double ChtMsgRedR1 { get => ChtMsgRedR; set => ChtMsgRedR = value; }
        public double ChtMsgRedA1 { get => ChtMsgRedA; set => ChtMsgRedA = value; }
        public double ChtMsgRedB1 { get => ChtMsgRedB; set => ChtMsgRedB = value; }
        public double ChtMsgBlueG1 { get => ChtMsgBlueG; set => ChtMsgBlueG = value; }
        public double ChtMsgBlueR1 { get => ChtMsgBlueR; set => ChtMsgBlueR = value; }
        public double ChtMsgBlueA1 { get => ChtMsgBlueA; set => ChtMsgBlueA = value; }
        public double ChtMsgBlueB1 { get => ChtMsgBlueB; set => ChtMsgBlueB = value; }
        public double ChtInColorG1 { get => ChtInColorG; set => ChtInColorG = value; }
        public double ChtInColorR1 { get => ChtInColorR; set => ChtInColorR = value; }
        public double ChtInColorA1 { get => ChtInColorA; set => ChtInColorA = value; }
        public double ChtInColorB1 { get => ChtInColorB; set => ChtInColorB = value; }
        public int ChtMsgOffY1 { get => ChtMsgOffY; set => ChtMsgOffY = value; }
        public int ChtMsgOffX1 { get => ChtMsgOffX; set => ChtMsgOffX = value; }
        public double ChtMsgFfaB1 { get => ChtMsgFfaB; set => ChtMsgFfaB = value; }
        public double ChtMsgFfaG1 { get => ChtMsgFfaG; set => ChtMsgFfaG = value; }
        public double ChtMsgFfaR1 { get => ChtMsgFfaR; set => ChtMsgFfaR = value; }
        public double ChtMsgFfaA1 { get => ChtMsgFfaA; set => ChtMsgFfaA = value; }
        public int HotKeyEnabled1 { get => HotKeyEnabled; set => HotKeyEnabled = value; }
        public string HKF31 { get => HKF3; set => HKF3 = value; }
        public string HKF21 { get => HKF2; set => HKF2 = value; }
        public string HKF13 { get => HKF1; set => HKF1 = value; }
        public string HKF61 { get => HKF6; set => HKF6 = value; }
        public string HKF51 { get => HKF5; set => HKF5 = value; }
        public string HKF41 { get => HKF4; set => HKF4 = value; }
        public string HKF91 { get => HKF9; set => HKF9 = value; }
        public string HKF81 { get => HKF8; set => HKF8 = value; }
        public string HKF71 { get => HKF7; set => HKF7 = value; }
        public string HKF121 { get => HKF12; set => HKF12 = value; }
        public string HKF111 { get => HKF11; set => HKF11 = value; }
        public string HKF101 { get => HKF10; set => HKF10 = value; }
        public string HKAS01 { get => HKAS0; set => HKAS0 = value; }
        public string HKAS91 { get => HKAS9; set => HKAS9 = value; }
        public string HKAS81 { get => HKAS8; set => HKAS8 = value; }
        public string HKAS71 { get => HKAS7; set => HKAS7 = value; }
        public string HKAS61 { get => HKAS6; set => HKAS6 = value; }
        public string HKAS51 { get => HKAS5; set => HKAS5 = value; }
        public string HKAS41 { get => HKAS4; set => HKAS4 = value; }
        public string HKAS31 { get => HKAS3; set => HKAS3 = value; }
        public string HKAS21 { get => HKAS2; set => HKAS2 = value; }
        public string HKAS11 { get => HKAS1; set => HKAS1 = value; }
        public string HkAN01 { get => HkAN0; set => HkAN0 = value; }
        public string HkAN91 { get => HkAN9; set => HkAN9 = value; }
        public string HkAN81 { get => HkAN8; set => HkAN8 = value; }
        public string HkAN71 { get => HkAN7; set => HkAN7 = value; }
        public string HkAN61 { get => HkAN6; set => HkAN6 = value; }
        public string HkAN51 { get => HkAN5; set => HkAN5 = value; }
        public string HkAN31 { get => HkAN3; set => HkAN3 = value; }
        public string HkAN21 { get => HkAN2; set => HkAN2 = value; }
        public string HkAN11 { get => HkAN1; set => HkAN1 = value; }
        public string HKASN01 { get => HKASN0; set => HKASN0 = value; }
        public string HKASN91 { get => HKASN9; set => HKASN9 = value; }
        public string HKASN81 { get => HKASN8; set => HKASN8 = value; }
        public string HKASN71 { get => HKASN7; set => HKASN7 = value; }
        public string HKASN61 { get => HKASN6; set => HKASN6 = value; }
        public string HKASN51 { get => HKASN5; set => HKASN5 = value; }
        public string HKASN41 { get => HKASN4; set => HKASN4 = value; }
        public string HKASN31 { get => HKASN3; set => HKASN3 = value; }
        public string HKASN21 { get => HKASN2; set => HKASN2 = value; }
        public string HKASN11 { get => HKASN1; set => HKASN1 = value; }
        public string HkA01 { get => HkA0; set => HkA0 = value; }
        public string HkA91 { get => HkA9; set => HkA9 = value; }
        public string HkA81 { get => HkA8; set => HkA8 = value; }
        public string HkA71 { get => HkA7; set => HkA7 = value; }
        public string HkA61 { get => HkA6; set => HkA6 = value; }
        public string HkA51 { get => HkA5; set => HkA5 = value; }
        public string HkA41 { get => HkA4; set => HkA4 = value; }
        public string HkA31 { get => HkA3; set => HkA3 = value; }
        public string HkA21 { get => HkA2; set => HkA2 = value; }
        public string HkA11 { get => HkA1; set => HkA1 = value; }
        public string HkC01 { get => HkC0; set => HkC0 = value; }
        public string HkC91 { get => HkC9; set => HkC9 = value; }
        public string HkC81 { get => HkC8; set => HkC8 = value; }
        public string HkC71 { get => HkC7; set => HkC7 = value; }
        public string HkC61 { get => HkC6; set => HkC6 = value; }
        public string HkC51 { get => HkC5; set => HkC5 = value; }
        public string HkC41 { get => HkC4; set => HkC4 = value; }
        public string HkC31 { get => HkC3; set => HkC3 = value; }
        public string HkC21 { get => HkC2; set => HkC2 = value; }
        public string HkC11 { get => HkC1; set => HkC1 = value; }
        public string HKCN01 { get => HKCN0; set => HKCN0 = value; }
        public string HKCN91 { get => HKCN9; set => HKCN9 = value; }
        public string HKCN81 { get => HKCN8; set => HKCN8 = value; }
        public string HKCN71 { get => HKCN7; set => HKCN7 = value; }
        public string HKCN61 { get => HKCN6; set => HKCN6 = value; }
        public string HKCN51 { get => HKCN5; set => HKCN5 = value; }
        public string HKCN41 { get => HKCN4; set => HKCN4 = value; }
        public string HKCN31 { get => HKCN3; set => HKCN3 = value; }
        public string HKCN21 { get => HKCN2; set => HKCN2 = value; }
        public string HKCN11 { get => HKCN1; set => HKCN1 = value; }
        public string HkCAS01 { get => HkCAS0; set => HkCAS0 = value; }
        public string HkCAS91 { get => HkCAS9; set => HkCAS9 = value; }
        public string HkCAS81 { get => HkCAS8; set => HkCAS8 = value; }
        public string HkCAS71 { get => HkCAS7; set => HkCAS7 = value; }
        public string HkCAS61 { get => HkCAS6; set => HkCAS6 = value; }
        public string HkCAS51 { get => HkCAS5; set => HkCAS5 = value; }
        public string HkCAS41 { get => HkCAS4; set => HkCAS4 = value; }
        public string HkCAS31 { get => HkCAS3; set => HkCAS3 = value; }
        public string HkCAS21 { get => HkCAS2; set => HkCAS2 = value; }
        public string HkCAS11 { get => HkCAS1; set => HkCAS1 = value; }
        public string HkCASN01 { get => HkCASN0; set => HkCASN0 = value; }
        public string HkCASN91 { get => HkCASN9; set => HkCASN9 = value; }
        public string HkCASN81 { get => HkCASN8; set => HkCASN8 = value; }
        public string HkCASN61 { get => HkCASN6; set => HkCASN6 = value; }
        public string HkCASN51 { get => HkCASN5; set => HkCASN5 = value; }
        public string HkCASN31 { get => HkCASN3; set => HkCASN3 = value; }
        public string HkCASN71 { get => HkCASN7; set => HkCASN7 = value; }
        public string HkCASN41 { get => HkCASN4; set => HkCASN4 = value; }
        public string HkCASN21 { get => HkCASN2; set => HkCASN2 = value; }
        public string HkCASN11 { get => HkCASN1; set => HkCASN1 = value; }
        public string HkAN41 { get => HkAN4; set => HkAN4 = value; }
    }
}
