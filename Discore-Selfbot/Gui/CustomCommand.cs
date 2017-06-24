using System;
using ComponentFactory.Krypton.Toolkit;

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

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CC_MessageTextDone_Click(object sender, EventArgs e)
        {
            //CustomTextFormat movie = new CustomTextFormat()
            //{
            //Type = "Test Name",
            //Year = "Year"
            //};
            //using (StreamWriter file = File.CreateText("movie.json"))
            //{
            //JsonSerializer serializer = new JsonSerializer();
            //serializer.Serialize(file, movie);
            //}
        }
    }
}
