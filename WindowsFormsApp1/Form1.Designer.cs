namespace WindowsFormsApp1
{

    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTListBoxFuellen = new System.Windows.Forms.Button();
            this.BTListBoxEintraegeLoeschen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTListBoxTextAnhaengen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTSchliessen = new System.Windows.Forms.Button();
            this.nOTESDATABASEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESDATABASEBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTListBoxFuellen
            // 
            this.BTListBoxFuellen.Location = new System.Drawing.Point(6, 19);
            this.BTListBoxFuellen.Name = "BTListBoxFuellen";
            this.BTListBoxFuellen.Size = new System.Drawing.Size(161, 20);
            this.BTListBoxFuellen.TabIndex = 0;
            this.BTListBoxFuellen.Text = "Listbox füllen";
            this.BTListBoxFuellen.UseVisualStyleBackColor = true;
            this.BTListBoxFuellen.Click += new System.EventHandler(this.BTListBoxFuellen_Click);
            // 
            // BTListBoxEintraegeLoeschen
            // 
            this.BTListBoxEintraegeLoeschen.Location = new System.Drawing.Point(6, 49);
            this.BTListBoxEintraegeLoeschen.Name = "BTListBoxEintraegeLoeschen";
            this.BTListBoxEintraegeLoeschen.Size = new System.Drawing.Size(161, 20);
            this.BTListBoxEintraegeLoeschen.TabIndex = 0;
            this.BTListBoxEintraegeLoeschen.Text = "Gewählte Einträge löschen";
            this.BTListBoxEintraegeLoeschen.UseVisualStyleBackColor = true;
            this.BTListBoxEintraegeLoeschen.Click += new System.EventHandler(this.BTListBoxEintraegeLoeschen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 19);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(586, 121);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTListBoxTextAnhaengen);
            this.groupBox1.Controls.Add(this.BTListBoxFuellen);
            this.groupBox1.Controls.Add(this.BTListBoxEintraegeLoeschen);
            this.groupBox1.Location = new System.Drawing.Point(623, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BTListBoxTextAnhaengen
            // 
            this.BTListBoxTextAnhaengen.Location = new System.Drawing.Point(6, 79);
            this.BTListBoxTextAnhaengen.Name = "BTListBoxTextAnhaengen";
            this.BTListBoxTextAnhaengen.Size = new System.Drawing.Size(161, 20);
            this.BTListBoxTextAnhaengen.TabIndex = 1;
            this.BTListBoxTextAnhaengen.Text = "Listbox mit Text füllen";
            this.BTListBoxTextAnhaengen.UseVisualStyleBackColor = true;
            this.BTListBoxTextAnhaengen.Click += new System.EventHandler(this.BTListBoxTextAnhaengen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 200);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Sortierung Listbox";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lotus Notes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTNotes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(623, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 92);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // BTSchliessen
            // 
            this.BTSchliessen.Location = new System.Drawing.Point(7, 218);
            this.BTSchliessen.Name = "BTSchliessen";
            this.BTSchliessen.Size = new System.Drawing.Size(160, 23);
            this.BTSchliessen.TabIndex = 0;
            this.BTSchliessen.Text = "Schliessen";
            this.BTSchliessen.UseVisualStyleBackColor = true;
            this.BTSchliessen.Click += new System.EventHandler(this.BTSchliessen_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(586, 199);
            this.listBox2.TabIndex = 9;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Sortierung Listbox";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 250);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTSchliessen);
            this.groupBox5.Location = new System.Drawing.Point(622, 211);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 250);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(808, 466);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nOTESDATABASEBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button BTListBoxFuellen;
        private System.Windows.Forms.Button BTListBoxEintraegeLoeschen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTListBoxTextAnhaengen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BTSchliessen;
        private System.Windows.Forms.BindingSource nOTESDATABASEBindingSource;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

