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
                string ResWidth = "width=" + TbxResWidth.Text;
                string ResHeight = "height=" + TbxResHeight.Text;
            }
            else
            {
                string ResWidth = "width=auto";
                string ResHeight = "height=auto";
            }

            // Refresh rate(Hz) refresh_rate=0
            if (CbRefRate.Checked)
            {
                string RefRate = "refresh_rate=1";
            }
            else
            {
                string RefRate = "refresh_rate=0";
            }

            //Enable double buffer vSync
            if (CbVsync.Checked)
            {
                string Vsync = "vsync=1";
            }
            else
            {
                string Vsync = "vsync=0";
            }

            //Play in a window 
            if (CbWindowed.Checked)
            {
                string Windowed = "windowed=1";
            }
            else
            {
                string Windowed = "windowed=0";
            }

            //Play in borderless fullscreen
            if (CbBorderless.Checked)
            {
                string Borderless = "borderless=1";
            }
            else
            {
                string Borderless = "borderless=0";
            }

            //Scoreboard settings
            //Scoreboard font
            string ScoreboardFont = ComBoxScoreboardFont.Text;

            //Scoreboard fade time
            //Validar que se reciva si o si un numero
            try
            {
                double ScoreboardFade = double.Parse(TbxScoreboardFade.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The ScoreBoard Fade must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string StringScoreboardFade = "fade_time=" + TbxScoreboardFade.Text;

            //Name settings
            //Name Font
            string NameFont = ComBoxNameFont.Text;

            //Server list settings
            //Auto Query
            if (CbAutoQuery.Checked)
            {
                string AutoQuery = "auto_query=1";
            }
            else
            {
                string AutoQuery = "auto_query=0";
            }

            //master server list
            if (CbMstrSvList.Checked)
            {
                string MstrSvList = "master_server_list=" + TbxMstrSvList.Text;
            }
            else
            {
                string MstrSvList = ";master_server_list=s1.master.hosthpc.com";
            }
            
            //master server key
            if (CbMstrSvKey.Checked)
            {
                string MstrSvKey = "master_server_key=" + TbxMstrSvKey.Text;
            }
            else
            {
                string MstrSvKey = ";master_server_key = s1.ms01.hosthpc.com";
            }
            
            //master server nat primary
            if (MstrSvNatP = ceckMstrSvNatP.Checked) {
                string MstrSvNatP = "master_server_nat_primary = natneg1.hosthpc.com";
            }
            else 
            {
                string MstrSvNatP = ""master_server_nat_primary=" + tbxMstrSvNatP.Text;
            }
            
            //master server nat secondary
            if (MstrSvNatS = ceckMstrSvNatS.Checked) {
                string MstrSvNatS = "master_server_nat_primary = natneg1.hosthpc.com";
            }
            else 
            {
                string MstrSvNatS = ""master_server_nat_primary=" + tbxMstrSvNatS.Text;
            }

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
            string HKF1 = "f1=" + TbxHKF1.Text;
            string HKF2 = "f2=" + TbxHKF2.Text;
            string HKF3 = "f3=" + TbxHKF3.Text;
            string HKF4 = "f4=" + TbxHKF4.Text;
            string HKF5 = "f5=" + TbxHKF5.Text;
            string HKF6 = "f6=" + TbxHKF6.Text;
            string HKF7 = "f7=" + TbxHKF7.Text;
            string HKF8 = "f8=" + TbxHKF8.Text;
            string HKF9 = "f9=" + TbxHKF9.Text;
            string HKF10 = "f10=" + TbxHKF10.Text;
            string HKF11 = "f11=" + TbxHKF11.Text;
            string HKF12 = "f12=" + TbxHKF12.Text;
            // Alt+Shift+# hotkeys 
            string HKAS1 = "alt_shift_1=" + TbxHKAS1.Text;
            string HKAS2 = "alt_shift_2=" + TbxHKAS2.Text;
            string HKAS3 = "alt_shift_3=" + TbxHKAS3.Text;
            string HKAS4 = "alt_shift_4=" + TbxHKAS4.Text;
            string HKAS5 = "alt_shift_5=" + TbxHKAS5.Text;
            string HKAS6 = "alt_shift_6=" + TbxHKAS6.Text;
            string HKAS7 = "alt_shift_7=" + TbxHKAS7.Text;
            string HKAS8 = "alt_shift_8=" + TbxHKAS8.Text;
            string HKAS9 = "alt_shift_9=" + TbxHKAS9.Text;
            string HKAS0 = "alt_shift_0=" + TbxHKAS0.Text;
            // Alt+Shift+Numpad hotkeys
            string HKASN1 = "alt_shift_num_1=" + TbxHKASN1.Text;
            string HKASN2 = "alt_shift_num_2=" + TbxHKASN2.Text;
            string HKASN3 = "alt_shift_num_3=" + TbxHKASN3.Text;
            string HKASN4 = "alt_shift_num_4=" + TbxHKASN4.Text;
            string HKASN5 = "alt_shift_num_5=" + TbxHKASN5.Text;
            string HKASN6 = "alt_shift_num_6=" + TbxHKASN6.Text;
            string HKASN7 = "alt_shift_num_7=" + TbxHKASN7.Text;
            string HKASN8 = "alt_shift_num_8=" + TbxHKASN8.Text;
            string HKASN9 = "alt_shift_num_9=" + TbxHKASN9.Text;
            string HKASN0 = "alt_shift_num_0=" + TbxHKASN0.Text;
            // Alt+# hotkeys
            string HkA1 = "alt_1=" + TbxHkA1.Text;
            string HkA2 = "alt_2=" + TbxHkA2.Text;
            string HkA3 = "alt_3=" + TbxHkA3.Text;
            string HkA4 = "alt_4=" + TbxHkA4.Text;
            string HkA5 = "alt_5=" + TbxHkA5.Text;
            string HkA6 = "alt_6=" + TbxHkA6.Text;
            string HkA7 = "alt_7=" + TbxHkA7.Text;
            string HkA8 = "alt_8=" + TbxHkA8.Text;
            string HkA9 = "alt_9=" + TbxHkA9.Text;
            string HkA0 = "alt_0=" + TbxHkA0.Text;
            // Alt+NumPad hotkeys
            string HkAN1 = "alt_num_1=" + TbxHkAN1.Text;
            string HkAN2 = "alt_num_2=" + TbxHkAN2.Text;
            string HkAN3 = "alt_num_3=" + TbxHkAN3.Text;
            string HkAN4 = "alt_num_4=" + TbxHkAN4.Text;
            string HkAN5 = "alt_num_5=" + TbxHkAN5.Text;
            string HkAN6 = "alt_num_6=" + TbxHkAN6.Text;
            string HkAN7 = "alt_num_7=" + TbxHkAN7.Text;
            string HkAN8 = "alt_num_8=" + TbxHkAN8.Text;
            string HkAN9 = "alt_num_9=" + TbxHkAN9.Text;
            string HkAN0 = "alt_num_0=" + TbxHkAN0.Text;
            // Ctrl+# hotkeys
            string HkC1 = "ctrl_1=" + TbxHkC1.Text;
            string HkC2 = "ctrl_2=" + TbxHkC2.Text;
            string HkC3 = "ctrl_3=" + TbxHkC3.Text;
            string HkC4 = "ctrl_4=" + TbxHkC4.Text;
            string HkC5 = "ctrl_5=" + TbxHkC5.Text;
            string HkC6 = "ctrl_6=" + TbxHkC6.Text;
            string HkC7 = "ctrl_7=" + TbxHkC7.Text;
            string HkC8 = "ctrl_8=" + TbxHkC8.Text;
            string HkC9 = "ctrl_9=" + TbxHkC9.Text;
            string HkC0 = "ctrl_0=" + TbxHkC0.Text;
            // Ctrl+Numpad hotkeys
            string HKCN1 = "ctrl_num_1=" + TbxHKCN1.Text;
            string HKCN2 = "ctrl_num_2=" + TbxHKCN2.Text;
            string HKCN3 = "ctrl_num_3=" + TbxHKCN3.Text;
            string HKCN4 = "ctrl_num_4=" + TbxHKCN4.Text;
            string HKCN5 = "ctrl_num_5=" + TbxHKCN5.Text;
            string HKCN6 = "ctrl_num_6=" + TbxHKCN6.Text;
            string HKCN7 = "ctrl_num_7=" + TbxHKCN7.Text;
            string HKCN8 = "ctrl_num_8=" + TbxHKCN8.Text;
            string HKCN9 = "ctrl_num_9=" + TbxHKCN9.Text;
            string HAKCN0 = "ctrl_num_0=" + TbxHKCN0.Text;
            // Ctrl+Alt+Shift+# hotkeys
            string HkCAS1 = "ctrl_alt_shift_1=" + TbxHkCAS1.Text;
            string HkCAS2 = "ctrl_alt_shift_2=" + TbxHkCAS2.Text;
            string HkCAS3 = "ctrl_alt_shift_3=" + TbxHkCAS3.Text;
            string HkCAS4 = "ctrl_alt_shift_4=" + TbxHkCAS4.Text;
            string HkCAS5 = "ctrl_alt_shift_5=" + TbxHkCAS5.Text;
            string HkCAS6 = "ctrl_alt_shift_6=" + TbxHkCAS6.Text;
            string HkCAS7 = "ctrl_alt_shift_7=" + TbxHkCAS7.Text;
            string HkCAS8 = "ctrl_alt_shift_8=" + TbxHkCAS8.Text;
            string HkCAS9 = "ctrl_alt_shift_9=" + TbxHkCAS9.Text;
            string HkCAS0 = "ctrl_alt_shift_0=" + TbxHkCAS0.Text;
            // Ctrl+Alt+Shift+Numpad hotkeys
            string HkCASN1 = "ctrl_alt_shift_num_1=" + TbxHkCASN1.Text;
            string HkCASN2 = "ctrl_alt_shift_num_2=" + TbxHkCASN2.Text;
            string HkCASN3 = "ctrl_alt_shift_num_3=" + TbxHkCASN3.Text;
            string HkCASN4 = "ctrl_alt_shift_num_4=" + TbxHkCASN4.Text;
            string HkCASN5 = "ctrl_alt_shift_num_5=" + TbxHkCASN5.Text;
            string HkCASN6 = "ctrl_alt_shift_num_6=" + TbxHkCASN6.Text;
            string HkCASN7 = "ctrl_alt_shift_num_7=" + TbxHkCASN7.Text;
            string HkCASN8 = "ctrl_alt_shift_num_8=" + TbxHkCASN8.Text;
            string HkCASN9 = "ctrl_alt_shift_num_9=" + TbxHkCASN9.Text;
            string HkCASN0 = "ctrl_alt_shift_num_0=" + TbxHkCASN0.Text;

        }
    }
}
