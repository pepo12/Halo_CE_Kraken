namespace chimera_editor.Presentation
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            LbAKVersion = new Label();
            LbAKVersionNumber = new Label();
            LbAKCredits = new Label();
            PicBoxDuck = new PictureBox();
            BtnAKOk = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxDuck).BeginInit();
            SuspendLayout();
            // 
            // LbAKVersion
            // 
            LbAKVersion.AutoSize = true;
            LbAKVersion.Location = new Point(12, 9);
            LbAKVersion.Name = "LbAKVersion";
            LbAKVersion.Size = new Size(45, 15);
            LbAKVersion.TabIndex = 0;
            LbAKVersion.Text = "Version";
            // 
            // LbAKVersionNumber
            // 
            LbAKVersionNumber.AutoSize = true;
            LbAKVersionNumber.Location = new Point(63, 9);
            LbAKVersionNumber.Name = "LbAKVersionNumber";
            LbAKVersionNumber.Size = new Size(57, 15);
            LbAKVersionNumber.TabIndex = 1;
            LbAKVersionNumber.Text = "(number)";
            // 
            // LbAKCredits
            // 
            LbAKCredits.AutoSize = true;
            LbAKCredits.Location = new Point(12, 34);
            LbAKCredits.Margin = new Padding(3, 10, 3, 0);
            LbAKCredits.Name = "LbAKCredits";
            LbAKCredits.Size = new Size(226, 165);
            LbAKCredits.TabIndex = 2;
            LbAKCredits.Text = "By Environment Cartography Department\r\n\r\nColaboration with:\r\nEin'x\r\nMangoFizz\r\n\r\n\r\n\r\n\r\n\r\nHalo CE Chimera SnowyMouse\r\n";
            // 
            // PicBoxDuck
            // 
            PicBoxDuck.Image = (Image)resources.GetObject("PicBoxDuck.Image");
            PicBoxDuck.Location = new Point(294, 34);
            PicBoxDuck.Name = "PicBoxDuck";
            PicBoxDuck.Size = new Size(128, 128);
            PicBoxDuck.TabIndex = 3;
            PicBoxDuck.TabStop = false;
            // 
            // BtnAKOk
            // 
            BtnAKOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAKOk.FlatStyle = FlatStyle.Popup;
            BtnAKOk.Location = new Point(326, 176);
            BtnAKOk.Name = "BtnAKOk";
            BtnAKOk.Size = new Size(75, 23);
            BtnAKOk.TabIndex = 4;
            BtnAKOk.Text = "Ok";
            BtnAKOk.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 211);
            Controls.Add(BtnAKOk);
            Controls.Add(PicBoxDuck);
            Controls.Add(LbAKCredits);
            Controls.Add(LbAKVersionNumber);
            Controls.Add(LbAKVersion);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "About Kraken";
            ((System.ComponentModel.ISupportInitialize)PicBoxDuck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbAKVersion;
        private Label LbAKVersionNumber;
        private Label LbAKCredits;
        private PictureBox PicBoxDuck;
        private Button BtnAKOk;
    }
}