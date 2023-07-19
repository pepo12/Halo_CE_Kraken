namespace chimera_editor.Presentation
{
    partial class Form4
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
            LbChimeraDown = new Label();
            LbChimeraLink = new Label();
            BtnChimeraOk = new Button();
            SuspendLayout();
            // 
            // LbChimeraDown
            // 
            LbChimeraDown.AutoSize = true;
            LbChimeraDown.Location = new Point(12, 9);
            LbChimeraDown.Name = "LbChimeraDown";
            LbChimeraDown.Size = new Size(249, 15);
            LbChimeraDown.TabIndex = 0;
            LbChimeraDown.Text = "Download the lastest version of Chimera here:";
            // 
            // LbChimeraLink
            // 
            LbChimeraLink.AutoSize = true;
            LbChimeraLink.Location = new Point(12, 53);
            LbChimeraLink.Name = "LbChimeraLink";
            LbChimeraLink.Size = new Size(279, 15);
            LbChimeraLink.TabIndex = 1;
            LbChimeraLink.Text = "https://github.com/SnowyMouse/chimera/releases";
            // 
            // BtnChimeraOk
            // 
            BtnChimeraOk.FlatStyle = FlatStyle.Popup;
            BtnChimeraOk.Location = new Point(206, 109);
            BtnChimeraOk.Name = "BtnChimeraOk";
            BtnChimeraOk.Size = new Size(75, 23);
            BtnChimeraOk.TabIndex = 2;
            BtnChimeraOk.Text = "Ok";
            BtnChimeraOk.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 144);
            Controls.Add(BtnChimeraOk);
            Controls.Add(LbChimeraLink);
            Controls.Add(LbChimeraDown);
            Name = "Form4";
            Text = "Chimera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbChimeraDown;
        private Label LbChimeraLink;
        private Button BtnChimeraOk;
    }
}