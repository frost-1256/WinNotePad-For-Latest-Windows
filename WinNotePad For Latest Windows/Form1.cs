using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WinNotePad_For_Latest_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /// <summary>
            /// ver 0.5.1
            /// </summary>

        }

        private void 編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.FileVersionInfo ver =
            System.Diagnostics.FileVersionInfo.GetVersionInfo(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            MessageBox.Show(ver);
            
        }

        private void gitHub情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // このGitHubリポジトリを表示
            System.Diagnostics.Process.Start("https://github.com/frost-1256/WinNotePad-For-Latest-Windows");
        }
    }
}
