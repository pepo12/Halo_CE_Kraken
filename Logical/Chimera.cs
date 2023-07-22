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
        private int Path; //directorio de los perfiles de jugadores
        private int CbPath;
        private string TbxPath;
        private int CbDownPath;
        private string TbxDownPath;
        private int DownPath; //directorio donde se descargan los mapas
        private int CbMapsPath;
        private string TbxMapsPath;
        private int MapsPath; //directorio de los mapas stock
        private int CbExec;
        private string TbxExec;
        private int Exec; //archivo para ejecutar una serie de comandos al iniciar
        private int CbGamePorts;
        private string TbxServerPort;
        private string TbxClientPort;
        private int ServerPort;
        private int ClientPort;
        private int CbIntroVideos; //omitir cinematicas
        private int CbConsole;
        private int CbOptiDef; //usar comandos para un juego optimo
        private int CbMenuMusic;
        private int CbBackPlay; //reproducir juego de fondo
        private int CbMultiInst;
        private int CbHash;
        private string TbxHash;
        private int Hash;
        private int CbShowSeg; //mostrar segmentation fault
        private int CbSupFatal;
        private int CbEnblVideoMode;
        private int ResHeight;
        private int CbResolution;
        private int ResWidth;
        private string TbxResWidth;
        private string TbxResHeight;
        private int CbRefRate; //tasa de refresh de video
        private string TbxRefRate;
        private int RefRate;
        private int CbVsync;
        private string TbxVsync;
        private int Vsync;
        private int CbWindowed;
        private int CbBorderless;
        private string TbxScoreboardFade;
        private int CbAutoQuery;
        private int MstrSvList;
        private int ScoreboardFade;
        private int PnlNameSet;
        private int ComBoxScoreboardFont;
        private int ComBoxNameFont;
        private int CbMstrSvList; //url del servidor maestro
        private int CbMstrSvKey; //clave del servidor maestro
        private int MstrSvKey;
        private int CbMstrSvNatP; //nat primaria del servidor maestro
        private int MstrSvNatP;
        private int CbMstrSvNatS; //nat secundaria del servidor maestro
        private int MstrSvNatS;
        private int PnlMemory;
        private int CbMapSize; //cantidad de memoria para los mapas en ram
        private int MapSize;
        private int CbMapMmryBuffer;
        private int CbBenchmark;
        private int ComBoxDownloadFont;
        private int DownloadUrl; //direccion del repositorio
        private int CbDownloadRetail; //descargar mapas con cosas stock
        private int PnlFontOver;
        private int CbFontOverEnabled;
        private int SystemFW;
        private int CbSystemFO;
        private int SystemFF; //fuente de system
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
        private int CbLargeFO;
        private int LargeFF; //fuente de large
        private int SmallSY;
        private int SmallYO;
        private int SmallSX;
        private int SmallXO;
        private int SmallFS;
        private int SmallFW;
        private int CbSmallFO;
        private int SmallFF; //fuente de small
        private int SmallerSY;
        private int SmallerYO;
        private int SmallerSX;
        private int SmallerXO;
        private int SmallerFS;
        private int SmallerFW;
        private int CbSmallerFO;
        private int SmallerFF; //fuente de smaller
        private int TickerSY;
        private int TickerYO;
        private int TickerSX;
        private int TickerXO;
        private int TickerFS;
        private int TickerFW;
        private int CbTickerFO;
        private int TickerFF;
        private int ConsoleSY;
        private int ConsoleYO;
        private int ConsoleSX;
        private int ConsoleXO;
        private int ConsoleFS;
        private int ConsoleFW;
        private int CbConsoleFO;
        private int ConsoleFF; //fuente de console
        private int CbControllerEnabled;
        private int PnlController;
        private int CbCustomCEnabled;
        private int PnlCustomC;
        private int ControllerConfig;
        private int CbScrollback;
        private int ConsoleBuffer;
        private int ConsoleSoft;
        private int LineHeight;
        private int XMargin;
        private int CFadeStart;
        private int CFadeTime;
        private int PnlCustomChat;
        private int CbAllowRcon;
        private int SvMsgColorA;
        private int SvMsgColorR;
        private int SvMsgColorG;
        private int SvMsgOffX;
        private int SvMsgDimX;
        private int SvMsgOC;
        private int SvMsgAniTime;
        private int SvMsgDisTime;
        private int SvMsgFadeTime;
        private int SvMsgLineH;
        private int PnlSvMsg;
        private int SvMsgOffY;
        private int SvMsgDimY;
        private int ChtMsgDimY;
        private int HKAS6;
        private int ChtMsgLineH;
        private int ChtMsgFadeTime;
        private int ChtMsgDisTime;
        private int ChtMsgAniTime;
        private int HkCASN7;
        private int ChtMsgOC;
        private int ChtMsgDimX;
        private int HkCASN4;
        private int ChtMsgFfa;
        private int HkCASN2;
        private int HkCASN1;
        private int PnlChtMsg;
        private int HkAN0;
        private int HkAN9;
        private int HkAN8;
        private int HkAN7;
        private int HkAN6;
        private int HkAN5;
        private int SvMsgColorB;
        private int HkAN3;
        private int HkAN2;
        private int HkAN1;
        private int ChtInColorB;
        private int int42;
        private int ChtInOffY;
        private int int50;
        private int ChtInWidth;
        private int ChtInOffX;
        private int int54;
        private int int55;
        private int int56;
        private int PnlChtIn;
        private int ComBoxSvMsgAnchor;
        private int CbSvMsgCHide;
        private int ComBoxSvMsgFont;
        private int ComBoxChtMsgFont;
        private int CbChtMsgCHide;
        private int ComBoxChtMsgAnchor;
        private int ComBoxChtInFont;
        private int ComBoxChtInAnchor;
        private int ChtMsgRedG;
        private int ChtMsgRedR;
        private int ChtMsgRedA;
        private int ChtMsgBlueG;
        private int ChtMsgBlueR;
        private int ChtMsgBlueA;
        private int ChtMsgBlueB;
        private int ChtMsgRedB;
        private int ChtMsgFfaB;
        private int ChtInColorG;
        private int ChtInColorR;
        private int ChtInColorA;
        private int ChtMsgOffY;
        private int ChtMsgOffX;
        private int ChtMsgFfaR;
        private int ChtMsgFfaA;
        private int PnlHotkey;
        private int CbHotKeyEnabled;
        private int HKF3;
        private int HKF2;
        private int HKF1;
        private int HKF6;
        private int HKF5;
        private int HKF4;
        private int HKF9;
        private int HKF8;
        private int HKF7;
        private int HKF12;
        private int HKF11;
        private int HKF10;
        private int HKAS0;
        private int HKAS9;
        private int HKAS8;
        private int HKAS7;
        private int HKAS5;
        private int HKAS4;
        private int HKAS3;
        private int HKAS2;
        private int HKAS1;
        private int HKASN0;
        private int HKASN9;
        private int HKASN8;
        private int HKASN7;
        private int HKASN6;
        private int HKASN5;
        private int HKASN4;
        private int HKASN3;
        private int HKASN2;
        private int HKASN1;
        private int HkA0;
        private int HkA9;
        private int HkA8;
        private int HkA7;
        private int HkA6;
        private int HkA5;
        private int HkA4;
        private int HkA3;
        private int HkA2;
        private int HkA1;
        private int HkC0;
        private int HkC9;
        private int HkC8;
        private int HkC7;
        private int HkC6;
        private int HkC5;
        private int HkC4;
        private int HkC3;
        private int HkC2;
        private int HkC1;
        private int HKCN0;
        private int HKCN9;
        private int HKCN8;
        private int HKCN7;
        private int HKCN6;
        private int HKCN5;
        private int HKCN4;
        private int HKCN3;
        private int HKCN2;
        private int HKCN1;
        private int HkCAS0;
        private int HkCAS9;
        private int HkCAS8;
        private int HkCAS7;
        private int HkCAS6;
        private int HkCAS5;
        private int HkCAS4;
        private int HkCAS3;
        private int HkCAS2;
        private int HkCAS1;
        private int HkCASN0;
        private int HkCASN9;
        private int HkCASN8;
        private int HkCASN6;
        private int HkCASN5;
        private int HkCASN3;
        private int HkAN4;

        //Definicion de metodos Set and Get
        //TODO cuando esten bien definidos los atributos
    }
}
