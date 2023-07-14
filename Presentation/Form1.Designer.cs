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
            STBFileNew = new ToolStripTextBox();
            STBFileOpen = new ToolStripTextBox();
            STBFileClose = new ToolStripTextBox();
            TSSFileA = new ToolStripSeparator();
            STBFileSave = new ToolStripTextBox();
            STBFileSaveAs = new ToolStripTextBox();
            TSSFileB = new ToolStripSeparator();
            STBFileExit = new ToolStripTextBox();
            TSMEdit = new ToolStripMenuItem();
            STBEditUndo = new ToolStripTextBox();
            TSSEditA = new ToolStripSeparator();
            STBEditCut = new ToolStripTextBox();
            STBEditCopy = new ToolStripTextBox();
            STBEditPaste = new ToolStripTextBox();
            STBEditClear = new ToolStripTextBox();
            TSMWindow = new ToolStripMenuItem();
            STBWinCascade = new ToolStripTextBox();
            STBWinHor = new ToolStripTextBox();
            STBWinVer = new ToolStripTextBox();
            STBWinArrIcons = new ToolStripTextBox();
            TSSWindA = new ToolStripSeparator();
            TSMHelp = new ToolStripMenuItem();
            STBHelpAbout = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMFile, TSMEdit, TSMWindow, TSMHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1228, 24);
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
            STBFileNew.Size = new Size(100, 23);
            STBFileNew.Text = "New...";
            // 
            // STBFileOpen
            // 
            STBFileOpen.Name = "STBFileOpen";
            STBFileOpen.Size = new Size(100, 23);
            STBFileOpen.Text = "Open...";
            // 
            // STBFileClose
            // 
            STBFileClose.Name = "STBFileClose";
            STBFileClose.Size = new Size(100, 23);
            STBFileClose.Text = "Close";
            // 
            // TSSFileA
            // 
            TSSFileA.Name = "TSSFileA";
            TSSFileA.Size = new Size(157, 6);
            // 
            // STBFileSave
            // 
            STBFileSave.Name = "STBFileSave";
            STBFileSave.Size = new Size(100, 23);
            STBFileSave.Text = "Save";
            // 
            // STBFileSaveAs
            // 
            STBFileSaveAs.Name = "STBFileSaveAs";
            STBFileSaveAs.Size = new Size(100, 23);
            STBFileSaveAs.Text = "Save As...";
            // 
            // TSSFileB
            // 
            TSSFileB.Name = "TSSFileB";
            TSSFileB.Size = new Size(157, 6);
            // 
            // STBFileExit
            // 
            STBFileExit.Name = "STBFileExit";
            STBFileExit.Size = new Size(100, 23);
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
            STBEditUndo.Size = new Size(100, 23);
            STBEditUndo.Text = "Undo";
            // 
            // TSSEditA
            // 
            TSSEditA.Name = "TSSEditA";
            TSSEditA.Size = new Size(157, 6);
            // 
            // STBEditCut
            // 
            STBEditCut.Name = "STBEditCut";
            STBEditCut.Size = new Size(100, 23);
            STBEditCut.Text = "Cut";
            // 
            // STBEditCopy
            // 
            STBEditCopy.Name = "STBEditCopy";
            STBEditCopy.Size = new Size(100, 23);
            STBEditCopy.Text = "Copy";
            // 
            // STBEditPaste
            // 
            STBEditPaste.Name = "STBEditPaste";
            STBEditPaste.Size = new Size(100, 23);
            STBEditPaste.Text = "Paste";
            // 
            // STBEditClear
            // 
            STBEditClear.Name = "STBEditClear";
            STBEditClear.Size = new Size(100, 23);
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
            STBWinCascade.Size = new Size(100, 23);
            STBWinCascade.Text = "Cascade";
            // 
            // STBWinHor
            // 
            STBWinHor.Name = "STBWinHor";
            STBWinHor.Size = new Size(100, 23);
            STBWinHor.Text = "Tile Horizontally";
            // 
            // STBWinVer
            // 
            STBWinVer.Name = "STBWinVer";
            STBWinVer.Size = new Size(100, 23);
            STBWinVer.Text = "Tile Vertically";
            // 
            // STBWinArrIcons
            // 
            STBWinArrIcons.Name = "STBWinArrIcons";
            STBWinArrIcons.Size = new Size(100, 23);
            STBWinArrIcons.Text = "Arrange Icons";
            // 
            // TSSWindA
            // 
            TSSWindA.Name = "TSSWindA";
            TSSWindA.Size = new Size(157, 6);
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
            STBHelpAbout.Size = new Size(100, 23);
            STBHelpAbout.Text = "About";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 644);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMFile;
        private ToolStripTextBox STBFileNew;
        private ToolStripTextBox STBFileOpen;
        private ToolStripTextBox STBFileClose;
        private ToolStripMenuItem TSMEdit;
        private ToolStripMenuItem TSMWindow;
        private ToolStripMenuItem TSMHelp;
        private ToolStripSeparator TSSFileA;
        private ToolStripTextBox STBFileSave;
        private ToolStripTextBox STBFileSaveAs;
        private ToolStripSeparator TSSFileB;
        private ToolStripTextBox STBFileExit;
        private ToolStripTextBox STBEditUndo;
        private ToolStripSeparator TSSEditA;
        private ToolStripTextBox STBEditCut;
        private ToolStripTextBox STBEditCopy;
        private ToolStripTextBox STBEditPaste;
        private ToolStripTextBox STBEditClear;
        private ToolStripTextBox STBWinCascade;
        private ToolStripTextBox STBWinHor;
        private ToolStripTextBox STBWinVer;
        private ToolStripTextBox STBWinArrIcons;
        private ToolStripSeparator TSSWindA;
        private ToolStripTextBox STBHelpAbout;
    }
}