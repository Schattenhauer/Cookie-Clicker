
namespace Cookie_Clicker_PA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_kekse = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalerSpielstandLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pB_Store = new System.Windows.Forms.PictureBox();
            this.lb_Preis = new System.Windows.Forms.Label();
            this.lb_multiplikator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_kekse_titel = new System.Windows.Forms.CheckBox();
            this.cb_verstecken_minimized = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lb_cps = new System.Windows.Forms.Label();
            this.t_cps = new System.Windows.Forms.Timer(this.components);
            this.t_auto_clicker = new System.Windows.Forms.Timer(this.components);
            this.lb_warnung = new System.Windows.Forms.Label();
            this.lb_timeout = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_auto_buyer = new System.Windows.Forms.CheckBox();
            this.bt_ab_buy = new System.Windows.Forms.Button();
            this.cb_auto_clicker = new System.Windows.Forms.CheckBox();
            this.bt_ac_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Store)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // l_kekse
            // 
            this.l_kekse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_kekse.Location = new System.Drawing.Point(11, 166);
            this.l_kekse.Name = "l_kekse";
            this.l_kekse.Size = new System.Drawing.Size(347, 40);
            this.l_kekse.TabIndex = 1;
            this.l_kekse.Text = "0";
            this.l_kekse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.lokalerSpielstandLöschenToolStripMenuItem,
            this.toolStripSeparator1,
            this.überToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // lokalerSpielstandLöschenToolStripMenuItem
            // 
            this.lokalerSpielstandLöschenToolStripMenuItem.Name = "lokalerSpielstandLöschenToolStripMenuItem";
            this.lokalerSpielstandLöschenToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.lokalerSpielstandLöschenToolStripMenuItem.Text = "Lokaler Spielstand löschen";
            this.lokalerSpielstandLöschenToolStripMenuItem.Click += new System.EventHandler(this.lokalerSpielstandLöschenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.überToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // pB_Store
            // 
            this.pB_Store.Image = ((System.Drawing.Image)(resources.GetObject("pB_Store.Image")));
            this.pB_Store.Location = new System.Drawing.Point(267, 77);
            this.pB_Store.Name = "pB_Store";
            this.pB_Store.Size = new System.Drawing.Size(66, 62);
            this.pB_Store.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Store.TabIndex = 3;
            this.pB_Store.TabStop = false;
            this.pB_Store.Visible = false;
            this.pB_Store.Click += new System.EventHandler(this.pB_Store_Click);
            // 
            // lb_Preis
            // 
            this.lb_Preis.AutoSize = true;
            this.lb_Preis.Location = new System.Drawing.Point(267, 142);
            this.lb_Preis.Name = "lb_Preis";
            this.lb_Preis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Preis.Size = new System.Drawing.Size(56, 15);
            this.lb_Preis.TabIndex = 4;
            this.lb_Preis.Text = "Preis: 200";
            this.lb_Preis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_multiplikator
            // 
            this.lb_multiplikator.AutoSize = true;
            this.lb_multiplikator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_multiplikator.Location = new System.Drawing.Point(11, 208);
            this.lb_multiplikator.Name = "lb_multiplikator";
            this.lb_multiplikator.Size = new System.Drawing.Size(0, 15);
            this.lb_multiplikator.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_kekse_titel);
            this.groupBox1.Controls.Add(this.cb_verstecken_minimized);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optionen";
            // 
            // cb_kekse_titel
            // 
            this.cb_kekse_titel.AutoSize = true;
            this.cb_kekse_titel.Location = new System.Drawing.Point(6, 47);
            this.cb_kekse_titel.Name = "cb_kekse_titel";
            this.cb_kekse_titel.Size = new System.Drawing.Size(243, 34);
            this.cb_kekse_titel.TabIndex = 1;
            this.cb_kekse_titel.Text = "Kekse und Multiplikator im Titel anzeigen\r\n(erst bei nächsten klick)";
            this.cb_kekse_titel.UseVisualStyleBackColor = true;
            // 
            // cb_verstecken_minimized
            // 
            this.cb_verstecken_minimized.AutoSize = true;
            this.cb_verstecken_minimized.Location = new System.Drawing.Point(6, 22);
            this.cb_verstecken_minimized.Name = "cb_verstecken_minimized";
            this.cb_verstecken_minimized.Size = new System.Drawing.Size(176, 19);
            this.cb_verstecken_minimized.TabIndex = 0;
            this.cb_verstecken_minimized.Text = "Verstecken beim Minimieren";
            this.cb_verstecken_minimized.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cookie Clicker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // lb_cps
            // 
            this.lb_cps.AutoSize = true;
            this.lb_cps.Location = new System.Drawing.Point(11, 231);
            this.lb_cps.Name = "lb_cps";
            this.lb_cps.Size = new System.Drawing.Size(66, 30);
            this.lb_cps.TabIndex = 7;
            this.lb_cps.Text = "0 clicks/s\r\n0 cookies/s";
            // 
            // t_cps
            // 
            this.t_cps.Interval = 1000;
            this.t_cps.Tick += new System.EventHandler(this.t_cps_Tick);
            // 
            // t_auto_clicker
            // 
            this.t_auto_clicker.Interval = 1;
            this.t_auto_clicker.Tick += new System.EventHandler(this.t_auto_clicker_Tick);
            // 
            // lb_warnung
            // 
            this.lb_warnung.AutoSize = true;
            this.lb_warnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_warnung.ForeColor = System.Drawing.Color.Red;
            this.lb_warnung.Location = new System.Drawing.Point(119, 21);
            this.lb_warnung.Name = "lb_warnung";
            this.lb_warnung.Size = new System.Drawing.Size(128, 15);
            this.lb_warnung.TabIndex = 8;
            this.lb_warnung.Text = "Auto-Clicker erkannt!";
            this.lb_warnung.Visible = false;
            // 
            // lb_timeout
            // 
            this.lb_timeout.AutoSize = true;
            this.lb_timeout.Location = new System.Drawing.Point(267, 24);
            this.lb_timeout.Name = "lb_timeout";
            this.lb_timeout.Size = new System.Drawing.Size(57, 15);
            this.lb_timeout.TabIndex = 9;
            this.lb_timeout.Text = "Timeout: ";
            this.lb_timeout.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_auto_buyer);
            this.groupBox2.Controls.Add(this.bt_ab_buy);
            this.groupBox2.Controls.Add(this.cb_auto_clicker);
            this.groupBox2.Controls.Add(this.bt_ac_buy);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 102);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto-Clicker";
            // 
            // cb_auto_buyer
            // 
            this.cb_auto_buyer.AutoSize = true;
            this.cb_auto_buyer.Location = new System.Drawing.Point(122, 61);
            this.cb_auto_buyer.Name = "cb_auto_buyer";
            this.cb_auto_buyer.Size = new System.Drawing.Size(87, 19);
            this.cb_auto_buyer.TabIndex = 3;
            this.cb_auto_buyer.Text = "Auto-Buyer";
            this.cb_auto_buyer.UseVisualStyleBackColor = true;
            this.cb_auto_buyer.Visible = false;
            this.cb_auto_buyer.CheckedChanged += new System.EventHandler(this.cb_auto_buyer_CheckedChanged);
            // 
            // bt_ab_buy
            // 
            this.bt_ab_buy.Location = new System.Drawing.Point(85, 61);
            this.bt_ab_buy.Name = "bt_ab_buy";
            this.bt_ab_buy.Size = new System.Drawing.Size(175, 23);
            this.bt_ab_buy.TabIndex = 2;
            this.bt_ab_buy.Text = "Auto-Buyer Kaufen (500 Tsd.)";
            this.bt_ab_buy.UseVisualStyleBackColor = true;
            this.bt_ab_buy.Click += new System.EventHandler(this.bt_ab_buy_Click);
            // 
            // cb_auto_clicker
            // 
            this.cb_auto_clicker.AutoSize = true;
            this.cb_auto_clicker.Location = new System.Drawing.Point(122, 25);
            this.cb_auto_clicker.Name = "cb_auto_clicker";
            this.cb_auto_clicker.Size = new System.Drawing.Size(93, 19);
            this.cb_auto_clicker.TabIndex = 1;
            this.cb_auto_clicker.Text = "Auto-Clicker";
            this.cb_auto_clicker.UseVisualStyleBackColor = true;
            this.cb_auto_clicker.Visible = false;
            this.cb_auto_clicker.CheckedChanged += new System.EventHandler(this.cb_auto_clicker_CheckedChanged);
            // 
            // bt_ac_buy
            // 
            this.bt_ac_buy.Location = new System.Drawing.Point(85, 22);
            this.bt_ac_buy.Name = "bt_ac_buy";
            this.bt_ac_buy.Size = new System.Drawing.Size(175, 23);
            this.bt_ac_buy.TabIndex = 0;
            this.bt_ac_buy.Text = "Auto-Clicker Kaufen (10 Tsd.)";
            this.bt_ac_buy.UseVisualStyleBackColor = true;
            this.bt_ac_buy.Click += new System.EventHandler(this.bt_ac_buy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(370, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_timeout);
            this.Controls.Add(this.lb_warnung);
            this.Controls.Add(this.lb_cps);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_multiplikator);
            this.Controls.Add(this.pB_Store);
            this.Controls.Add(this.lb_Preis);
            this.Controls.Add(this.l_kekse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cookie Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Store)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_kekse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pB_Store;
        private System.Windows.Forms.Label lb_Preis;
        private System.Windows.Forms.Label lb_multiplikator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_verstecken_minimized;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cb_kekse_titel;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalerSpielstandLöschenToolStripMenuItem;
        private System.Windows.Forms.Label lb_cps;
        private System.Windows.Forms.Timer t_cps;
        private System.Windows.Forms.Timer t_auto_clicker;
        private System.Windows.Forms.Label lb_warnung;
        private System.Windows.Forms.Label lb_timeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_auto_clicker;
        private System.Windows.Forms.Button bt_ac_buy;
        private System.Windows.Forms.CheckBox cb_auto_buyer;
        private System.Windows.Forms.Button bt_ab_buy;
    }
}

