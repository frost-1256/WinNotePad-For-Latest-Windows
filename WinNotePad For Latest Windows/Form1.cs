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
using System.Security.Cryptography.X509Certificates;

namespace WinNotePad_For_Latest_Windows
{
    public partial class Form1 : Form
    {
        public string Path { get; set; }
        public Form1()
        {
            InitializeComponent();
            /// <summary>
            /// ver 0.5.1
            /// スパゲッティ・モンスター
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
            MessageBox.Show("v0.0.1.3", "Version Infomation");
            
        }

        private void gitHub情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // このGitHubリポジトリを表示
            System.Diagnostics.Process.Start("https://github.com/frost-1256/WinNotePad-For-Latest-Windows");
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if (txtMain.Modified) {
                var result = MessageBox.Show("Modified",
                                             "NotePad",
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Cancel) {
                    //キャンセルの場合、処理を抜ける
                    return;
                }

                if (result == DialogResult.No)
                {
                    return;
                }

                if (result == DialogResult.Yes){
                    //Yesで、menuSave_Clickイベントに移行する
                    menuSave_Click(sender, e);
                }
                txtMain.Clear();
                txtMain.Modified = false;
                this.Path = null;
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (txtMain.Modified)
            {
                var result = MessageBox.Show("Modified",
                                             "NotePad",
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    //キャンセルの場合、処理を抜ける
                    return;
                }

                if (result == DialogResult.No)
                {
                    return;
                }

                if (result == DialogResult.Yes)
                {
                    //Yesで、menuSave_Clickイベントに移行する
                    menuSave_Click(sender, e);
                }
            }
           {
                OpenDialog.FileName = "";
                var result = OpenDialog.ShowDialog();
                if (result == DialogResult.OK) {

                    string path = OpenDialog.FileName;
                    txtMain.LoadFile(Path, RichTextBoxStreamType.PlainText);
                    txtMain .Modified = false;
                    this.Path = path;
                }
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {

        }
    }
}
