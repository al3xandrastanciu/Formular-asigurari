namespace Formular
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.tbInceput = new System.Windows.Forms.TextBox();
            this.tbSfarsit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxTipuri = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.userControl11 = new Formular.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numar polita:";
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(303, 63);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(100, 20);
            this.tbNr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip asigurare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suma asigurata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data inceperii asigurarii:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data de expirare a asigurarii:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbTip
            // 
            this.tbTip.AllowDrop = true;
            this.tbTip.Location = new System.Drawing.Point(303, 108);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(100, 20);
            this.tbTip.TabIndex = 6;
            this.tbTip.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbTip_DragDrop);
            this.tbTip.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbTip_DragEnter);
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(303, 160);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 20);
            this.tbSuma.TabIndex = 7;
            // 
            // tbInceput
            // 
            this.tbInceput.Location = new System.Drawing.Point(303, 211);
            this.tbInceput.Name = "tbInceput";
            this.tbInceput.Size = new System.Drawing.Size(100, 20);
            this.tbInceput.TabIndex = 8;
            // 
            // tbSfarsit
            // 
            this.tbSfarsit.Location = new System.Drawing.Point(303, 255);
            this.tbSfarsit.Name = "tbSfarsit";
            this.tbSfarsit.Size = new System.Drawing.Size(100, 20);
            this.tbSfarsit.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adauga asigurare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            this.vizualizareToolStripMenuItem.Click += new System.EventHandler(this.vizualizareToolStripMenuItem_Click);
            // 
            // listBoxTipuri
            // 
            this.listBoxTipuri.FormattingEnabled = true;
            this.listBoxTipuri.Items.AddRange(new object[] {
            "Bunuri",
            "Viata",
            "RCA",
            "CASCO",
            "Sanatate"});
            this.listBoxTipuri.Location = new System.Drawing.Point(505, 111);
            this.listBoxTipuri.Name = "listBoxTipuri";
            this.listBoxTipuri.Size = new System.Drawing.Size(120, 69);
            this.listBoxTipuri.TabIndex = 12;
            this.listBoxTipuri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxTipuri_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipuri de asigurari:";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(652, 351);
            this.userControl11.Logo = ((System.Drawing.Image)(resources.GetObject("userControl11.Logo")));
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(136, 94);
            this.userControl11.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxTipuri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSfarsit);
            this.Controls.Add(this.tbInceput);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.TextBox tbInceput;
        private System.Windows.Forms.TextBox tbSfarsit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxTipuri;
        private System.Windows.Forms.Label label6;
        private UserControl1 userControl11;
    }
}