namespace chimera_editor
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            TSMFile = new ToolStripMenuItem();
            STBFileNew = new ToolStripMenuItem();
            STBFileOpen = new ToolStripMenuItem();
            STBFileClose = new ToolStripMenuItem();
            TSSFileA = new ToolStripSeparator();
            STBFileSave = new ToolStripMenuItem();
            STBFileSaveAs = new ToolStripMenuItem();
            TSSFileB = new ToolStripSeparator();
            STBFileExit = new ToolStripMenuItem();
            TSMEdit = new ToolStripMenuItem();
            STBEditUndo = new ToolStripMenuItem();
            TSSEditA = new ToolStripSeparator();
            STBEditCut = new ToolStripMenuItem();
            STBEditCopy = new ToolStripMenuItem();
            STBEditPaste = new ToolStripMenuItem();
            STBEditClear = new ToolStripMenuItem();
            TSMWindow = new ToolStripMenuItem();
            STBWinCascade = new ToolStripMenuItem();
            STBWinHor = new ToolStripMenuItem();
            STBWinVer = new ToolStripMenuItem();
            STBWinArrIcons = new ToolStripMenuItem();
            TSSWindA = new ToolStripSeparator();
            TSMHelp = new ToolStripMenuItem();
            STBHelpAbout = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMFile, TSMEdit, TSMWindow, TSMHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(870, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMFile
            // 
            TSMFile.DropDownItems.AddRange(new ToolStripItem[] { STBFileNew, STBFileOpen, STBFileClose, TSSFileA, STBFileSave, STBFileSaveAs, TSSFileB, STBFileExit });
            TSMFile.Name = "TSMFile";
            TSMFile.Size = new Size(37, 20);
            TSMFile.Text = "File";
            // 
            // STBFileNew
            // 
            STBFileNew.Name = "STBFileNew";
            STBFileNew.Size = new Size(180, 22);
            STBFileNew.Text = "New...";
            STBFileNew.Click += STBFileNew_Click;
            // 
            // STBFileOpen
            // 
            STBFileOpen.Name = "STBFileOpen";
            STBFileOpen.Size = new Size(180, 22);
            STBFileOpen.Text = "Open...";
            STBFileOpen.Click += STBFileOpen_Click;
            // 
            // STBFileClose
            // 
            STBFileClose.Name = "STBFileClose";
            STBFileClose.Size = new Size(180, 22);
            STBFileClose.Text = "Close";
            // 
            // TSSFileA
            // 
            TSSFileA.Name = "TSSFileA";
            TSSFileA.Size = new Size(177, 6);
            // 
            // STBFileSave
            // 
            STBFileSave.Name = "STBFileSave";
            STBFileSave.Size = new Size(180, 22);
            STBFileSave.Text = "Save";
            // 
            // STBFileSaveAs
            // 
            STBFileSaveAs.Name = "STBFileSaveAs";
            STBFileSaveAs.Size = new Size(180, 22);
            STBFileSaveAs.Text = "Save As...";
            // 
            // TSSFileB
            // 
            TSSFileB.Name = "TSSFileB";
            TSSFileB.Size = new Size(177, 6);
            // 
            // STBFileExit
            // 
            STBFileExit.Name = "STBFileExit";
            STBFileExit.Size = new Size(180, 22);
            STBFileExit.Text = "Exit";
            // 
            // TSMEdit
            // 
            TSMEdit.DropDownItems.AddRange(new ToolStripItem[] { STBEditUndo, TSSEditA, STBEditCut, STBEditCopy, STBEditPaste, STBEditClear });
            TSMEdit.Name = "TSMEdit";
            TSMEdit.Size = new Size(39, 20);
            TSMEdit.Text = "Edit";
            // 
            // STBEditUndo
            // 
            STBEditUndo.Name = "STBEditUndo";
            STBEditUndo.Size = new Size(103, 22);
            STBEditUndo.Text = "Undo";
            // 
            // TSSEditA
            // 
            TSSEditA.Name = "TSSEditA";
            TSSEditA.Size = new Size(100, 6);
            // 
            // STBEditCut
            // 
            STBEditCut.Name = "STBEditCut";
            STBEditCut.Size = new Size(103, 22);
            STBEditCut.Text = "Cut";
            // 
            // STBEditCopy
            // 
            STBEditCopy.Name = "STBEditCopy";
            STBEditCopy.Size = new Size(103, 22);
            STBEditCopy.Text = "Copy";
            // 
            // STBEditPaste
            // 
            STBEditPaste.Name = "STBEditPaste";
            STBEditPaste.Size = new Size(103, 22);
            STBEditPaste.Text = "Paste";
            // 
            // STBEditClear
            // 
            STBEditClear.Name = "STBEditClear";
            STBEditClear.Size = new Size(103, 22);
            STBEditClear.Text = "Clear";
            // 
            // TSMWindow
            // 
            TSMWindow.DropDownItems.AddRange(new ToolStripItem[] { STBWinCascade, STBWinHor, STBWinVer, STBWinArrIcons, TSSWindA });
            TSMWindow.Name = "TSMWindow";
            TSMWindow.Size = new Size(63, 20);
            TSMWindow.Text = "Window";
            // 
            // STBWinCascade
            // 
            STBWinCascade.Name = "STBWinCascade";
            STBWinCascade.Size = new Size(159, 22);
            STBWinCascade.Text = "Cascade";
            // 
            // STBWinHor
            // 
            STBWinHor.Name = "STBWinHor";
            STBWinHor.Size = new Size(159, 22);
            STBWinHor.Text = "Tile Horizontally";
            // 
            // STBWinVer
            // 
            STBWinVer.Name = "STBWinVer";
            STBWinVer.Size = new Size(159, 22);
            STBWinVer.Text = "Tile Vertically";
            // 
            // STBWinArrIcons
            // 
            STBWinArrIcons.Name = "STBWinArrIcons";
            STBWinArrIcons.Size = new Size(159, 22);
            STBWinArrIcons.Text = "Arrange Icons";
            // 
            // TSSWindA
            // 
            TSSWindA.Name = "TSSWindA";
            TSSWindA.Size = new Size(156, 6);
            // 
            // TSMHelp
            // 
            TSMHelp.DropDownItems.AddRange(new ToolStripItem[] { STBHelpAbout });
            TSMHelp.Name = "TSMHelp";
            TSMHelp.Size = new Size(44, 20);
            TSMHelp.Text = "Help";
            // 
            // STBHelpAbout
            // 
            STBHelpAbout.Name = "STBHelpAbout";
            STBHelpAbout.Size = new Size(107, 22);
            STBHelpAbout.Text = "About";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Chimera Ini (*.ini)|*.ini";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(870, 644);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "HCE Kraken";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMFile;
        private ToolStripMenuItem TSMEdit;
        private ToolStripMenuItem TSMWindow;
        private ToolStripMenuItem TSMHelp;
        private ToolStripSeparator TSSFileA;
        private ToolStripSeparator TSSFileB;
        private ToolStripSeparator TSSEditA;
        private ToolStripSeparator TSSWindA;
        private ToolStripMenuItem STBFileNew;
        private ToolStripMenuItem STBFileOpen;
        private ToolStripMenuItem STBFileClose;
        private ToolStripMenuItem STBFileSave;
        private ToolStripMenuItem STBFileSaveAs;
        private ToolStripMenuItem STBFileExit;
        private ToolStripMenuItem STBEditUndo;
        private ToolStripMenuItem STBEditCut;
        private ToolStripMenuItem STBEditCopy;
        private ToolStripMenuItem STBEditPaste;
        private ToolStripMenuItem STBEditClear;
        private ToolStripMenuItem STBWinCascade;
        private ToolStripMenuItem STBWinHor;
        private ToolStripMenuItem STBWinVer;
        private ToolStripMenuItem STBWinArrIcons;
        private ToolStripMenuItem STBHelpAbout;
        private OpenFileDialog openFileDialog1;
    }
}