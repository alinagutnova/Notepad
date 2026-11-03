using System.Reflection;

namespace Notepad
{
    public partial class FormMain : Form
    {
        string current_filename = "";
        bool wasChanged = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wasChanged)
            {
                //MessageBox.Show("")
            }

            textBoxField.Text = "";
            current_filename = "";
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                textBoxField.Text = sr.ReadToEnd();
                sr.Close();
                current_filename = openFileDialog.FileName;

                /*string s="";
                while (!sr.EndOfStream)
                { 
                    s+= sr.ReadLine()+"\r\n";
                }*/
            }
        }

        void SaveToFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(textBoxField.Text);
            sw.Close();
        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_filename))
            {
                ñîõğàíèòüÊàêToolStripMenuItem_Click(sender, e);
                return;
            }
            SaveToFile(current_filename);
        }

        private void ñîõğàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(saveFileDialog.FileName);
                current_filename = saveFileDialog.FileName;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*string exePath = Assembly.GetEntryAssembly().Location;
            string dirPath = Path.GetDirectoryName(exePath);
            saveFileDialog.InitialDirectory = dirPath;*/
        }

        private void textBoxField_TextChanged(object sender, EventArgs e)
        {
            wasChanged = true;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
