using System;
using System.IO;
using System.Windows.Forms;

namespace EasyRepo
{
    public partial class form_init : Form
    {
        string repoPath;

        public form_init()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_createRepo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Path to initialize repository";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                repoPath = folder.SelectedPath;
                if (Directory.Exists(repoPath))
                {
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Filter = "ImageFiles|*.png";
                    fileDialog.Title = "Choose an image for your repo.";
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(repoPath + @"\CydiaIcon.png"))
                        {
                            File.Delete(repoPath + @"\CydiaIcon.png");
                        }
                        File.Copy(fileDialog.FileName, repoPath + @"\CydiaIcon.png");
                    }
                    Directory.CreateDirectory(repoPath + @"\debs");
                    Directory.CreateDirectory(repoPath + @"\depictions");
                    using (var stream = new StreamWriter(repoPath + @"\Release", true))
                    {
                        var repoName = Prompt.ShowDialog("Repository name", "Info");
                        stream.WriteLine("Origin: " + repoName);
                        stream.WriteLine("Label: " + repoName);
                        stream.WriteLine("Suite: stable");
                        stream.WriteLine("Version: 1.0");
                        stream.WriteLine("Codename: " + Prompt.ShowDialog("Code name", "Info"));
                        stream.WriteLine("Architectures: iphoneos-arm");
                        stream.WriteLine("Components: main");
                        stream.WriteLine("Description: " + Prompt.ShowDialog("Repository description", "Info"));
                    }
                    new form_manager(repoPath, true).Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Please choose a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_alreadyHave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Path to existing repository";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                repoPath = folder.SelectedPath;
                if (Directory.Exists(repoPath))
                {
                    new form_manager(repoPath, true).Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Please choose a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 50, Top = 40, Width = 400};
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}