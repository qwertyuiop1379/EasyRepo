using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace EasyRepoSetup
{
    public partial class form_setup : Form
    {
        public form_setup()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Capture = false;
                Message msg = Message.Create(Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_install_Click(object sender, EventArgs e)
        {
            button_install.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button_confirm.Visible = true;
            check_desktop.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            text_path.Visible = true;
            button_browse.Visible = true;

        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (text_path.Text.EndsWith(@"\"))
            {
                text_path.Text = text_path.Text.Remove(text_path.Text.Length - 1);
            }
            if (!Directory.Exists(text_path.Text))
            {
                Directory.CreateDirectory(text_path.Text);
            }
            Directory.CreateDirectory(Path.Combine(text_path.Text, "x64"));
            Directory.CreateDirectory(Path.Combine(text_path.Text, "x86"));
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://github.com/qwertyuiop1379/EasyRepo/raw/master/ICSharpCode.SharpZipLib.dll", text_path.Text + @"\ICSharpCode.SharpZipLib.dll");
                client.DownloadFile("https://github.com/qwertyuiop1379/EasyRepo/raw/master/SevenZipExtractor.dll", text_path.Text + @"\SevenZipExtractor.dll");
                client.DownloadFile("https://github.com/qwertyuiop1379/EasyRepo/raw/master/EasyRepo.exe", text_path.Text + @"\EasyRepo.exe");
                client.DownloadFile("https://github.com/qwertyuiop1379/EasyRepo/raw/master/icon.ico", text_path.Text + @"\icon.ico");
                client.DownloadFile("https://github.com/qwertyuiop1379/EasyRepo/raw/master/7z64.dll", text_path.Text + @"\x64\7z.dll");
                client.DownloadFile("https://github.com/qwertyuiop1379/EasyRepo/raw/master/7z86.dll", text_path.Text + @"\x86\7z.dll");
            }
            if (check_desktop.Checked)
            {
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\EasyRepo.url"))
                {
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine($@"URL=file:///{text_path.Text}\EasyRepo.exe");
                    writer.WriteLine("IconIndex=0");
                    writer.WriteLine($@"IconFile={text_path.Text}\icon.ico");
                    writer.Flush();
                }
            }
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
            dialog.Title = "Choose a path";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = false;
            dialog.ValidateNames = false;
            dialog.FileName = "Select Folder.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                text_path.Text = dialog.FileName.Remove(dialog.FileName.Length - 14);
            }
        }
    }
}
