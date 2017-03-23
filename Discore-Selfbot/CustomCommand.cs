using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;

namespace Discore_Selfbot
{
    
    public partial class CustomCommand : KryptonForm
    {
        public CustomCommand()
        {
            InitializeComponent();
           
        }

        private void CustomCommand_Load(object sender, EventArgs e)
        {

        }

        private void BtnTextAdd_Click(object sender, EventArgs e)
        {
            if (TextCommand.Text == "")
            {
                MessageBox.Show("Command is empty");
                return;
            }
            if (TextMessage.Text == "")
            {
                MessageBox.Show("Message is empty");
                return;
            }
            string Check = CommandCheck(TextCommand.Text);
            if (Check == "Used")
            {
                MessageBox.Show($"This command self {TextCommand.Text} is already being used by the selfbot");
                return;
            }
            if (Check == "File")
            {
                MessageBox.Show($"Custom command self {TextCommand.Text} already exists");
                return;
            }
            using (StreamWriter sw = File.CreateText(Program.SelfbotDir + "Custom\\" + TextCommand.Text + ".txt"))
            {
                sw.WriteLine("text");
            }
            using (StreamWriter sw = File.CreateText(Program.SelfbotDir + "Custom\\" + TextCommand.Text + ".message.txt"))
            {
                sw.Write(TextMessage.Text);
            }
            Program.MyForm.CustomCommandsList.Items.Add(TextCommand.Text);
            this.Close();
        }

        private void BtnEmbedAdd_Click(object sender, EventArgs e)
        {
            if (EmbedCommand.Text == "")
            {
                MessageBox.Show("Command is empty");
                return;
            }
            if (EmbedMessage.Text == "")
            {
                MessageBox.Show("Message is empty");
                return;
            }
            string Check = CommandCheck(EmbedCommand.Text);
            if (Check == "Used")
            {
                MessageBox.Show($"This command self {EmbedCommand.Text} is already being used by the selfbot");
                return;
            }
            if (Check == "File")
            {
                MessageBox.Show($"Custom command self {EmbedCommand.Text} already exists");
                return;
            }
            using (StreamWriter sw = File.CreateText(Program.SelfbotDir + "Custom\\" + EmbedCommand.Text + ".txt"))
            {
                sw.WriteLine("embed");
                sw.WriteLine(EmbedTitle.Text);
            }
            using (StreamWriter sw = File.CreateText(Program.SelfbotDir + "Custom\\" + EmbedCommand.Text + ".message.txt"))
            {
                sw.Write(EmbedMessage.Text);
            }
            Program.MyForm.CustomCommandsList.Items.Add(EmbedCommand.Text);
            this.Close();
        }
        public string CommandCheck(string Command)
        {
            string Code = "";
            string[] Selfbot = new string[] { "test", "neko", "clean", "ping", "guild", "uptime", "calc", "info", "cleanembed", "cleanembeds", "form", "gui", "bot", "botinfo", "lenny", "lewd", "user", "find", "tag", "addtag", "deltag", "an", "an bind", "tags", "an add", "an del", "an list", "embed", "tembed" };
            if (Selfbot.Contains(Command) || Command.Contains("."))
            {
                Code = "Used";
            }
            if (File.Exists(Program.SelfbotDir + "Custom\\" + Command + ".txt"))
            {
                Code = "File";
            }
            return Code;
        }

        private void GallerySelect_Click(object sender, EventArgs e)
        {
            var thread = new Thread(new ParameterizedThreadStart(param => {
                this.TopMost = false;
                if (GallerySelector.ShowDialog() == DialogResult.OK)
                {
                    GalleryFolder.Text = GallerySelector.SelectedPath + "\\";
                    List<string> ImageList = new List<string>();
                    foreach (var File in Directory.GetFiles(GalleryFolder.Text))
                    {
                        if (File.ToLower().Contains(".png") || File.ToLower().Contains(".jpg") || File.ToLower().Contains(".gif"))
                        {
                            ImageList.Add(File);
                        }
                    }
                    GalleryImages.Text = $"Images: {ImageList.Count}";
                    GalleryFolder.Visible = true;
                }
                this.TopMost = true;
                //Gat.Controls.OpenDialogView openDialog = new Gat.Controls.OpenDialogView();
                //Gat.Controls.OpenDialogViewModel vm = (Gat.Controls.OpenDialogViewModel)openDialog.DataContext;
                //vm.IsDirectoryChooser = true;
                //bool? result = vm.Show();
                //if (result == true)
                //{
                //Console.WriteLine(vm.SelectedFilePath);
                //}
            }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void GalleryEnter_Click(object sender, EventArgs e)
        {
            if (GalleryCommand.Text == "")
            {
                MessageBox.Show("Command is empty");
                return;
            }
            if (GalleryFolder.Text == "")
            {
                MessageBox.Show("No folder selected");
                return;
            }
            if (GalleryImages.Text.Contains("0"))
            {
                MessageBox.Show("No images found in folder");
                return;
            }
            string Check = CommandCheck(GalleryCommand.Text);
            if (Check == "Used")
            {
                MessageBox.Show($"This command self {GalleryCommand.Text} is already being used by the selfbot");
                return;
            }
            if (Check == "File")
            {
                MessageBox.Show($"Custom command self {GalleryCommand.Text} already exists");
                return;
            }
            using (StreamWriter sw = File.CreateText(Program.SelfbotDir + "Custom\\" + GalleryCommand.Text + ".txt"))
            {
                sw.WriteLine("gallery");
                sw.WriteLine(GalleryFolder.Text);
            }
            Program.MyForm.CustomCommandsList.Items.Add(GalleryCommand.Text);
            this.Close();
        }

        private void LinkEnter_Click(object sender, EventArgs e)
        {
            if (LinkCommand.Text == "")
            {
                MessageBox.Show("Command is empty");
                return;
            }
            if (LinkUrl.Text == "")
            {
                MessageBox.Show("Url is empty");
                return;
            }
            string Check = CommandCheck(LinkCommand.Text);
            if (Check == "Used")
            {
                MessageBox.Show($"This command self {LinkCommand.Text} is already being used by the selfbot");
                return;
            }
            if (Check == "File")
            {
                MessageBox.Show($"Custom command self {LinkCommand.Text} already exists");
                return;
            }
            using (StreamWriter sw = File.CreateText(Program.SelfbotDir + "Custom\\" + LinkCommand.Text + ".txt"))
            {
                sw.WriteLine("link");
                sw.WriteLine(LinkTitle.Text);
                sw.WriteLine(LinkUrl.Text);
            }
            Program.MyForm.CustomCommandsList.Items.Add(LinkCommand.Text);
            this.Close();
        }
    }
}
