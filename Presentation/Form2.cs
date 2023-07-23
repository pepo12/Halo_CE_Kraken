using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chimera_editor.Presentation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Metodo para cargar un chimera.ini
        /// <summary>
        /// Metodo para cargar un chimera.ini
        /// </summary>
        public void Form2_Load(object sender, EventArgs e)
        {
            //TODO Cargar archivo .ini
        }


        //Metodo para crear un nuevo chimera.ini
        /* Este metodo captura los datos desde el formulario y los envia
         * a la clase chimera, la clase chimera se encargara de construir la
         * cadena que se guardara en el respectivo Chimera.ini
         */
        /// <summary>
        /// Metodo para crear un nuevo chimera.ini
        /// </summary>
        public void Form2_New()
        {

            //profiles path
            if (CbPath.Checked)
            {
                //int BoolPath = 1;
                string Path = TbxPath.Text;
            } 
            else 
            {
                string Path = " ";
            }

            //Download path
            if (CbDownPath.Checked)
            {
                //int BoolDownPath;
                string DownPath = TbxDownPath.Text;
            } 
            else 
            {
                string DownPath = " ";
            }

            //Maps path
            if (CbMapsPath.Checked)
            {
                //int BoolMapsPath;
                string MapsPath = TbxMapsPath.Text;
            }
            else 
            {
                string MapsPath = " ";
            }
            
            //Exec
            if (CbExec.Checked)
            {
                //int BoolExec;
                string Exec = TbxExec.Text;
            }
            else 
            {
                string Exec = " ";
            }
            
            //Game Ports
            if (CbGamePorts.Checked)
            {
                //int BoolGamePorts;
                try
                {
                    int ServerPort = int.Parse(TbxServerPort.Text);
                    int ClientPort = int.Parse(TbxClientPort.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The port must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Default Ports
                int ServerPort = 2302;
                int ClientPort = 0;
            }
            
            //Intro Videos
            if (CbIntroVideos.Checked)
            {
                int IntroVideos = 1;
            }
            else
            {
                int IntroVideos = 0;
            }

            //Console
            if (CbConsole.Checked)
            {
                int Console = 1;
            } 
            else
            {
                int Console = 0;
            }
            
            //Optimal Defaults
            if (CbOptiDef.Checked)
            {
                int OptiDef = 1;
            }
            else
            {
                int OptiDef = 0;
            }

            //Main Menu Music
            if (CbMenuMusic.Checked)
            {
                int MenuMusic = 1;
            }
            else
            {
                int MenuMusic = 0;
            }

            //Background playback
            if (CbBackPlay.Checked)
            {
                int BackPlay = 1;
            }
            else
            {
                int BackPlay = 0;
            }
            
            //Multiple Instances
            if (CbBackPlay.Checked)
            {
                int MultiInst = 1;
            }
            else
            {
                int MultiInst = 0;
            }
            
            //hash
            if (CbHash.Checked)
            {
                //int BoolHash;
                string Hash = "hash = " + TbxHash.Text.ToString();
            }
            else
            {
                string Hash = " ";
            }
            
            //
            int ShowSeg;
            int SupFatal;
            int EnblVideoMode;
            int ResHeight;
            int Resolution;
            int ResWidth;
            int BoolRefRate;
            int RefRate;
            int BoolVsync;
            int Vsync;
            int Windowed;
            int Borderless;
            int AutoQuery;
            string MstrSvList;
            double ScoreboardFade;
            string ScoreboardFont;
            string NameFont;
            int BoolMstrSvList;
            int BoolMstrSvKey;
            string MstrSvKey;
            int BoolMstrSvNatP;
            string MstrSvNatP;
            int BoolMstrSvNatS;
            string MstrSvNatS;
            int BoolMapSize;
            string MapSize;
            int MapMmryBuffer;
            int Benchmark;
            string DownloadFont;
            string DownloadUrl;
            int DownloadRetail;
            int FontOverEnabled;
            int SystemFW;
            int SystemFO;
            string SystemFF; //fuente de system
            int SystemFS;
            int SystemXO;
            int SystemSX;
            int SystemSY;
            int SystemYO;
            int LargeSY;
            int LargeYO;
            int LargeSX;
            int LargeXO;
            int LargeFS;
            int LargeFW;
            int LargeFO;
            string LargeFF; //fuente de large
            int SmallSY;
            int SmallYO;
            int SmallSX;
            int SmallXO;
            int SmallFS;
            int SmallFW;
            int SmallFO;
            string SmallFF; //fuente de small
            int SmallerSY;
            int SmallerYO;
            int SmallerSX;
            int SmallerXO;
            int SmallerFS;
            int ConsoleFO;
            string ConsoleFF; //fuente de console
            int ControllerEnabled;
            int CustomCEnabled;
            string ControllerConfig;
            int Scrollback;
            int ConsoleBuffer;
            int ConsoleSoft;
            double LineHeight;
            int XMargin;
            double CFadeStart;
            double CFadeTime;
            int AllowRcon;
            double SvMsgColorA;
            double SvMsgColorR;
            double SvMsgColorG;
            double SvMsgColorB;
            int SvMsgOffX;
            int SvMsgDimX;
            int SvMsgOC;
            double SvMsgAniTime;
            double SvMsgDisTime;
            double SvMsgFadeTime;
            double SvMsgLineH;
            int SvMsgOffY;
            int SvMsgDimY;
            int ChtMsgDimY;
            double ChtMsgLineH;
            double ChtMsgFadeTime;
            double ChtMsgDisTime;
            double ChtMsgAniTime;
            int ChtMsgOC;
            int ChtMsgDimX;
            int ChtInOffY;
            int ChtInWidth;
            int ChtInOffX;
            string SvMsgAnchor;
            int SvMsgCHide;
            string SvMsgFont;
            string ChtMsgFont;
            int ChtMsgCHide;
            string ChtMsgAnchor;
            string ChtInFont;
            string ChtInAnchor;
            double ChtMsgRedG;
            double ChtMsgRedR;
            double ChtMsgRedA;
            double ChtMsgRedB;
            double ChtMsgBlueG;
            double ChtMsgBlueR;
            double ChtMsgBlueA;
            double ChtMsgBlueB;
            double ChtInColorG;
            double ChtInColorR;
            double ChtInColorA;
            double ChtInColorB;
            int ChtMsgOffY;
            int ChtMsgOffX;
            double ChtMsgFfaB;
            double ChtMsgFfaG;
            double ChtMsgFfaR;
            double ChtMsgFfaA;
            int HotKeyEnabled;
            //Hotkeys (HK)
            string HKF3;
            string HKF2;
            string HKF1;
            string HKF6;
            string HKF5;
            string HKF4;
            string HKF9;
            string HKF8;
            string HKF7;
            string HKF12;
            string HKF11;
            string HKF10;
            string HKAS0;
            string HKAS9;
            string HKAS8;
            string HKAS7;
            string HKAS6;
            string HKAS5;
            string HKAS4;
            string HKAS3;
            string HKAS2;
            string HKAS1;
            string HkAN0;
            string HkAN9;
            string HkAN8;
            string HkAN7;
            string HkAN6;
            string HkAN5;
            string HkAN3;
            string HkAN2;
            string HkAN1;
            string HKASN0;
            string HKASN9;
            string HKASN8;
            string HKASN7;
            string HKASN6;
            string HKASN5;
            string HKASN4;
            string HKASN3;
            string HKASN2;
            string HKASN1;
            string HkA0;
            string HkA9;
            string HkA8;
            string HkA7;
            string HkA6;
            string HkA5;
            string HkA4;
            string HkA3;
            string HkA2;
            string HkA1;
            string HkC0;
            string HkC9;
            string HkC8;
            string HkC7;
            string HkC6;
            string HkC5;
            string HkC4;
            string HkC3;
            string HkC2;
            string HkC1;
            string HKCN0;
            string HKCN9;
            string HKCN8;
            string HKCN7;
            string HKCN6;
            string HKCN5;
            string HKCN4;
            string HKCN3;
            string HKCN2;
            string HKCN1;
            string HkCAS0;
            string HkCAS9;
            string HkCAS8;
            string HkCAS7;
            string HkCAS6;
            string HkCAS5;
            string HkCAS4;
            string HkCAS3;
            string HkCAS2;
            string HkCAS1;
            string HkCASN0;
            string HkCASN9;
            string HkCASN8;
            string HkCASN6;
            string HkCASN5;
            string HkCASN3;
            string HkCASN7;
            string HkCASN4;
            string HkCASN2;
            string HkCASN1;
            string HkAN4;

        }
    }
}
