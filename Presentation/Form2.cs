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
                string Path = "path=" + TbxPath.Text;
            } 
            else 
            {
                string Path = ";path=\\Users\\whatever\\you\\want\\to\\put\\here ";
            }

            //Download path
            if (CbDownPath.Checked)
            {
                string DownPath = "download_map_path=" + TbxDownPath.Text; ;
            } 
            else 
            {
                string DownPath = ";download_map_path=C:\\Users\\whatever\\you\\want\\to\\put\\here";
            }

            //Maps path
            if (CbMapsPath.Checked)
            {
                string MapsPath = "map_path=" + TbxMapsPath.Text;
            }
            else 
            {
                string MapsPath = ";map_path=maps";
            }
            
            //Exec
            if (CbExec.Checked)
            {
                string Exec = "exec=" + TbxExec.Text;
            }
            else 
            {
                string Exec = ";exec=C:\\Users\\path\\to\\init.txt";
            }

            //Game Ports
            if (CbGamePorts.Checked)
            {
                //Validar que se reciva si o si un numero entero
                try
                {
                    int ServerPort = int.Parse(TbxServerPort.Text);
                    int ClientPort = int.Parse(TbxClientPort.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The port must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Construir las cadenas con los tipos de datos ya validados
                string ServerPortString = "server_port=" + TbxServerPort.Text;
                string ClientPortString = "client_port=" + TbxClientPort.Text;

            }
            else
            {
                //Default Ports
                string ServerPortString = ";server_port=2302";
                string ClientPortString = ";client_port=0";
            }
            
            //Intro Videos
            if (CbIntroVideos.Checked)
            {
                string IntroVideos = "intro_videos=1";
            }
            else
            {
                string IntroVideos = ";intro_videos=1";
            }

            //Console
            if (CbConsole.Checked)
            {
                string Console = "console=1";
            } 
            else
            {
                string Console = "console=0";
            }
            
            //Optimal Defaults
            if (CbOptiDef.Checked)
            {
                string OptiDef = "optimal_defaults=1";
            }
            else
            {
                string OptiDef = "optimal_defaults=0";
            }

            //Main Menu Music
            if (CbMenuMusic.Checked)
            {
                string MenuMusic = "main_menu_music=1";
            }
            else
            {
                string MenuMusic = "main_menu_music=0";
            }

            //Background playback
            if (CbBackPlay.Checked)
            {
                string BackPlay = "background_playback=1";
            }
            else
            {
                string BackPlay = "background_playback=0";
            }
            
            //Multiple Instances
            if (CbBackPlay.Checked)
            {
                string MultiInst = "multiple_instances=1";
            }
            else
            {
                string MultiInst = "multiple_instances=0";
            }
            
            //hash
            if (CbHash.Checked)
            {
                string Hash = "hash=" + TbxHash.Text;
            }
            else
            {
                string Hash = "hash=%";
            }

            //Suppress Fatal Errors 
            if (CbSupFatal.Checked)
            {
                string SupFatal = "suppress_fatal_errors=1";
            }
            else
            {
                string SupFatal = ";suppress_fatal_errors=1";
            }

            //Show Segmentation Fault 
            if (CbShowSeg.Checked)
            {
                string ShowSeg = "show_segmentation_fault=1";
            }
            else
            {
                string ShowSeg = ";show_segmentation_fault=1";
            }

            //Enable the [video_mode] settings 
            if (CbEnblVideoMode.Checked)
            {
                string EnblVideoMode = "enabled=1";
            }
            else
            {
                string EnblVideoMode = "enabled=0";
            }

            //Resolution to use
            if (CbResolution.Checked)
            {
                string ResWidth = "width="+TbxResWidth.Text;
                string ResHeight = "height="+TbxResHeight.Text;
            }
            else
            {
                string ResWidth = "width=auto";
                string ResHeight = "height=auto";
            }

            // Refresh rate(Hz) refresh_rate=0
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



            //Hotkeys (HK) ;enabled=1
            if (CbHotKeyEnabled.Checked)
            {
                string HotKeyEnabled = "enabled=1";
            }
            else
            {
                string HotKeyEnabled = ";enabled=1";
            }

            //Continuar con las estructura a partir de aqui, tambien
            //ordenarlas porque hay algunas desordenadas.

            // Function key hotkeys
            string HKF1 = TbxHKF1.Text;
            string HKF2 = TbxHKF2.Text;
            string HKF3 = TbxHKF3.Text;
            string HKF4;
            string HKF5;
            string HKF6;
            string HKF7;
            string HKF8;
            string HKF9;
            // Alt+Shift+# hotkeys
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
