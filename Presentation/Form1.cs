using chimera_editor.Presentation;


namespace chimera_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void STBFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //aqui va el codigo para abrir y leer el archivo
                STBFileOpen.Text = openFileDialog1.FileName;
                IniFile fileManager = new IniFile(STBFileOpen.Text);
                Form2 editor = new Form2();
                editor.MdiParent = this;
                editor.Show();
            }

        }

        private void STBFileNew_Click(object sender, EventArgs e)
        {
            Form2 editor = new Form2();
            editor.MdiParent = this;
            editor.Show();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}