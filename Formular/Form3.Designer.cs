namespace Formular
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereAsigurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareAsigurariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereAsigurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareAsigurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.btnAfisareMemorie = new System.Windows.Forms.Button();
            this.btnFisier = new System.Windows.Forms.Button();
            this.btnSalvareFisier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl11 = new Formular.UserControl1();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.ForeColor = System.Drawing.Color.Teal;
            this.textBox1.Location = new System.Drawing.Point(-1, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(950, 456);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereAsigurareToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // stergereAsigurareToolStripMenuItem1
            // 
            this.stergereAsigurareToolStripMenuItem1.Name = "stergereAsigurareToolStripMenuItem1";
            this.stergereAsigurareToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.stergereAsigurareToolStripMenuItem1.Text = "Stergere asigurare";
            this.stergereAsigurareToolStripMenuItem1.Click += new System.EventHandler(this.stergereAsigurareToolStripMenuItem1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 281);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(691, 173);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod Client";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CNP";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adresa";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tip asigurare";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Suma asigurata";
            this.columnHeader7.Width = 90;
            // 
            // serializareToolStripMenuItem1
            // 
            this.serializareToolStripMenuItem1.Name = "serializareToolStripMenuItem1";
            this.serializareToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.serializareToolStripMenuItem1.Text = "Serializare asigurari";
            // 
            // deserializareAsigurariToolStripMenuItem
            // 
            this.deserializareAsigurariToolStripMenuItem.Name = "deserializareAsigurariToolStripMenuItem";
            this.deserializareAsigurariToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deserializareAsigurariToolStripMenuItem.Text = "Deserializare asigurari";
            // 
            // stergereAsigurareToolStripMenuItem
            // 
            this.stergereAsigurareToolStripMenuItem.Name = "stergereAsigurareToolStripMenuItem";
            this.stergereAsigurareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergereAsigurareToolStripMenuItem.Text = "Serializare clienti";
            // 
            // editareAsigurareToolStripMenuItem
            // 
            this.editareAsigurareToolStripMenuItem.Name = "editareAsigurareToolStripMenuItem";
            this.editareAsigurareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editareAsigurareToolStripMenuItem.Text = "Deserializare clienti";
            // 
            // tbAfisare
            // 
            this.tbAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAfisare.Location = new System.Drawing.Point(35, 65);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.ReadOnly = true;
            this.tbAfisare.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAfisare.Size = new System.Drawing.Size(681, 210);
            this.tbAfisare.TabIndex = 2;
            this.tbAfisare.WordWrap = false;
            // 
            // btnAfisareMemorie
            // 
            this.btnAfisareMemorie.Location = new System.Drawing.Point(12, 21);
            this.btnAfisareMemorie.Name = "btnAfisareMemorie";
            this.btnAfisareMemorie.Size = new System.Drawing.Size(153, 23);
            this.btnAfisareMemorie.TabIndex = 3;
            this.btnAfisareMemorie.Text = "Afisare clienti";
            this.btnAfisareMemorie.UseVisualStyleBackColor = true;
            this.btnAfisareMemorie.Click += new System.EventHandler(this.btnAfisareMemorie_Click);
            // 
            // btnFisier
            // 
            this.btnFisier.Location = new System.Drawing.Point(181, 21);
            this.btnFisier.Name = "btnFisier";
            this.btnFisier.Size = new System.Drawing.Size(140, 23);
            this.btnFisier.TabIndex = 4;
            this.btnFisier.Text = "Afisare clienti+ asigurari";
            this.btnFisier.UseVisualStyleBackColor = true;
            this.btnFisier.Click += new System.EventHandler(this.btnFisier_Click);
            // 
            // btnSalvareFisier
            // 
            this.btnSalvareFisier.Location = new System.Drawing.Point(371, 21);
            this.btnSalvareFisier.Name = "btnSalvareFisier";
            this.btnSalvareFisier.Size = new System.Drawing.Size(109, 23);
            this.btnSalvareFisier.TabIndex = 5;
            this.btnSalvareFisier.Text = "Salveaza in fisier";
            this.btnSalvareFisier.UseVisualStyleBackColor = true;
            this.btnSalvareFisier.Click += new System.EventHandler(this.btnSalvareFisier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Grafic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Redirectionare catre baza de date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(674, 357);
            this.userControl11.Logo = ((System.Drawing.Image)(resources.GetObject("userControl11.Logo")));
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(142, 97);
            this.userControl11.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.btnSalvareFisier);
            this.Controls.Add(this.btnFisier);
            this.Controls.Add(this.btnAfisareMemorie);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Name = "Form3";
            this.Text = "Form3";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserializareAsigurariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereAsigurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareAsigurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereAsigurareToolStripMenuItem1;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.Button btnAfisareMemorie;
        private System.Windows.Forms.Button btnFisier;
        private System.Windows.Forms.Button btnSalvareFisier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControl1 userControl11;
    }
}