using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Xml;
using System.IO;

namespace Cookie_Clicker_PA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long kekse = 0;
        long keksmulti = 1;
        long kosten = 200;
        string path = Environment.GetEnvironmentVariable("appdata") + @"\Cookie Clicker\";
        public static string data = @"data\";

        int cps_zaehlen = 0;
        int cps_anzeige = 0;
        int cps_cookies = 0;
        int timeout = 0;
        int timeout_counter = 0;
        bool timeout_an;

        bool isAutoClickerPayt = false;
        bool ac_on = false;
        bool ac_gekauft = false;

        bool isAutoBuyerPayt = false;
        bool ab_on = false;
        bool ab_gekauft = false;

        public static string ver = "Ver. " + Application.ProductVersion;

        private void click()
        {
            if (kekse + keksmulti == 9200000000000000000)
            {
                l_kekse.Text = "Infinity";

                return;
            }
            
            cps_zaehlen++;
            t_cps.Start();
            kekse = kekse + keksmulti;
            l_kekse.Text = kekse.ToString();

            if (cb_kekse_titel.Checked == true)
                Text = "Cookie Clicker - " + kekse + ", " + keksmulti + "x";
            else
            {
                Text = "Cookie Clicker";
            }

            notifyIcon1.Text = kekse + ", " + keksmulti + "x";

            if (kekse >= kosten)
            {
                pB_Store.Visible = true;
            }
            else
            {
                pB_Store.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click();

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //schließt
            Close();
        }

        public void schließen(FormClosingEventArgs a)
        {
            DialogResult result = MessageBox.Show("Soll die Anwendung geschlossen werden? Alle nichtgespeicherten Daten gehen verloren", "Schließen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                a.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_multiplikator.Text = "Keksmultiplikator " + keksmulti + "x";

            DialogResult dr;
            dr = MessageBox.Show("Speicherstand laden?", "Laden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                laden();

            if (Directory.Exists(path))
                return;

            DirectoryInfo di = Directory.CreateDirectory(path);
        }

        private void pB_Store_Click(object sender, EventArgs e)
        {
            Store();
        }

        public void Store()
        {
            kekse = kekse - kosten;
            kosten = kosten + 200;
            keksmulti++;
            lb_Preis.Text = "Preis: " + kosten;

            lb_multiplikator.Text = "Keksmultiplikator " + keksmulti + "x";

            if (kekse >= kosten)
            {
                pB_Store.Visible = true;
            }
            else
            {
                pB_Store.Visible = false;
            }

            l_kekse.Text = kekse.ToString();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            zeigen();
        }

        private void zeigen()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if ((cb_verstecken_minimized.Checked == true) & (this.WindowState == FormWindowState.Minimized))
            {

                this.Hide();
                notifyIcon1.Visible = true;

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Soll der Spielstand beim schließen geschlossen werden?", "Schließen und Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
                e.Cancel = true;
            else if (result == DialogResult.Yes)
                speichern();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zweiteForm = new Über();
            zweiteForm.ShowDialog();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speichern();
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laden();
        }

        private void speichern()
        {
            XmlWriter oXmlWriter = null;
            XmlWriterSettings oXmlWriterSettings = new XmlWriterSettings();

            // Eigenschaften / Einstellungen festlegen
            oXmlWriterSettings.Indent = true;
            oXmlWriterSettings.IndentChars = "  ";
            oXmlWriterSettings.NewLineChars = "\r\n";

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }


            oXmlWriter = XmlWriter.Create(path + "speichern.xml", oXmlWriterSettings);

            // XML-Validierungs-Kopf
            oXmlWriter.WriteStartDocument(true);    // true = standalone="yes"



            oXmlWriter.WriteStartElement("kekse");

            oXmlWriter.WriteStartElement("anzahl");
            oXmlWriter.WriteString(kekse.ToString());
            oXmlWriter.WriteEndElement();

            oXmlWriter.WriteStartElement("multi");
            oXmlWriter.WriteString(keksmulti.ToString());
            oXmlWriter.WriteEndElement();

            oXmlWriter.WriteStartElement("preis");
            oXmlWriter.WriteString(kosten.ToString());
            oXmlWriter.WriteEndElement();

            oXmlWriter.WriteStartElement("isAutoClickerPayt");
            oXmlWriter.WriteString(isAutoClickerPayt.ToString());
            oXmlWriter.WriteEndElement();

            oXmlWriter.WriteStartElement("isAutoBuyerPayt");
            oXmlWriter.WriteString(isAutoBuyerPayt.ToString());
            oXmlWriter.WriteEndElement();

            oXmlWriter.WriteEndElement();

            oXmlWriter.Close();

            MessageBox.Show("Spielstand erfolgreich gespeichert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void laden()
        {
            XmlReader oXmlReader = null;
            XmlReaderSettings oXmlReaderSettings = new XmlReaderSettings();

            oXmlReader = XmlReader.Create(path + "speichern.xml");

            oXmlReader.Read();

            try
            {
                oXmlReader.ReadStartElement("kekse");

                oXmlReader.ReadStartElement("anzahl");
                kekse = Convert.ToInt64(oXmlReader.ReadContentAsString());
                oXmlReader.ReadEndElement();

                oXmlReader.ReadStartElement("multi");
                keksmulti = Convert.ToInt64(oXmlReader.ReadContentAsString());
                oXmlReader.ReadEndElement();

                oXmlReader.ReadStartElement("preis");
                kosten = Convert.ToInt64(oXmlReader.ReadContentAsString());
                oXmlReader.ReadEndElement();

                oXmlReader.ReadStartElement("isAutoClickerPayt");
                isAutoClickerPayt = Convert.ToBoolean(oXmlReader.ReadContentAsString());
                oXmlReader.ReadEndElement();

                oXmlReader.ReadStartElement("isAutoBuyerPayt");
                isAutoBuyerPayt = Convert.ToBoolean(oXmlReader.ReadContentAsString());
                oXmlReader.ReadEndElement();

                if (isAutoClickerPayt == true)
                {
                    ac_gekauft = true;
                    bt_ac_buy.Visible = false;
                    cb_auto_clicker.Visible = true;
                }

                if(isAutoBuyerPayt == true)
                {
                    ab_gekauft = true;
                    bt_ab_buy.Visible = false;
                    cb_auto_buyer.Visible = true;
                }

                MessageBox.Show("Spielstand erfolgreich geladen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (XmlException)
            {
                MessageBox.Show("Datei nicht lesbar oder Fehlerhaft!", "Fehler beim lesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            oXmlReader.Close();

            lb_Preis.Text = "Preis: " + kosten;
            lb_multiplikator.Text = "Keksmultiplikator " + keksmulti + "x";
            l_kekse.Text = kekse.ToString();
        }

        private void lokalerSpielstandLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Soll der Lokale Spielstand gelöscht werden?", "Spielstand löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles();
                DirectoryInfo[] dirs = new DirectoryInfo[files.Length];

                /*
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
                */

                foreach (DirectoryInfo dir in dirs)
                {
                    dir.Delete();
                }

                Directory.Delete(path);

                File.Delete("speichern.xml");

                MessageBox.Show("Lokaler Spielstand gelöscht!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void t_cps_Tick(object sender, EventArgs e)
        {
            cps_anzeige = cps_zaehlen;
            cps_zaehlen = 0;
            cps_cookies = Convert.ToInt32(cps_anzeige * keksmulti);
            lb_cps.Text = cps_anzeige + " clicks/s" + "\n" + cps_cookies + " cookies/s";

            if (cps_anzeige >= 40 && ac_on == false)
            {
                pictureBox1.Visible = false;
                lb_warnung.Visible = true;
                lb_timeout.Visible = true;
                timeout += 15;
                timeout_counter = timeout;
                timeout_an = true;
            }


            if (timeout_counter >= 1 && timeout_an == true && ac_on == false)
            {
                timeout_counter--;
                lb_timeout.Text = "Timeout: " + timeout_counter + "s";
                cb_auto_clicker.Enabled = false;
            }
            else
            {
                pictureBox1.Visible = true;
                lb_warnung.Visible = false;
                lb_timeout.Visible = false;
                timeout_an = false;
                cb_auto_clicker.Enabled = true;
            }

            if (ab_on == true)
            {
                if (kekse >= kosten)
                {
                    Store();
                }
            }
        }

        private void t_auto_clicker_Tick(object sender, EventArgs e)
        {
            click();
        }

        private void bt_ac_buy_Click(object sender, EventArgs e)
        {
            if (kekse >= 10000 && ac_gekauft == false)
            {
                kekse = kekse - 10000;
                l_kekse.Text = kekse.ToString();

                ac_gekauft = true;
                bt_ac_buy.Visible = false;
                cb_auto_clicker.Visible = true;
                isAutoClickerPayt = true;
            }
            else
            {
                MessageBox.Show("Du hast noch nicht genügend Kekse!", "Nicht genügend Kekse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_auto_clicker_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_auto_clicker.Checked == true)
            {
                ac_on = true;
                t_auto_clicker.Start();
            }
            else
            {
                ac_on = false;
                t_auto_clicker.Stop();
                cps_zaehlen = 0;
                cps_anzeige = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if(e.Control&&e.Alt)
            {
                if (e.KeyCode == Keys.X)
                {
                    zeigen();
                    MessageBox.Show("was");
                }
            }*/
        }

        private void bt_ab_buy_Click(object sender, EventArgs e)
        {
            if (kekse >= 500000 && ab_gekauft == false)
            {
                kekse = kekse - 500000;
                l_kekse.Text = kekse.ToString();

                ab_gekauft = true;
                bt_ab_buy.Visible = false;
                cb_auto_buyer.Visible = true;
                isAutoBuyerPayt = true;
            }
            else
            {
                MessageBox.Show("Du hast noch nicht genügend Kekse!", "Nicht genügend Kekse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_auto_buyer_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_auto_buyer.Checked == true)
            {
                ab_on = true;
            }
            else
            {
                ab_on = false;
            }
        }
    }
}
