using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cookie_Clicker_PA
{
    public partial class Über : Form
    {
        public Über()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rtb_changelog.Text = File.ReadAllText(Form1.data + "changlog.txt", Encoding.Default);

            label1.Text = "Cookie Clicker " + Form1.ver + "\n \n" + "Programmer: Lucas Schattauer\nIdea: Andy Gerome Bergner, Lucas Schattauer\n\nChangelog";
        }
    }
}
