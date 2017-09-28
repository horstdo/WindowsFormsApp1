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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTListBoxFuellen = new System.Windows.Forms.Button();
            this.BTListBoxEintraegeLoeschen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTListBoxTextAnhaengen = new System.Windows.Forms.Button();
            this.buttonOutlook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonSchliessen = new System.Windows.Forms.Button();
            this.nOTESDATABASEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESDATABASEBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTListBoxFuellen
            // 
            this.BTListBoxFuellen.Location = new System.Drawing.Point(4, 43);
            this.BTListBoxFuellen.Name = "BTListBoxFuellen";
            this.BTListBoxFuellen.Size = new System.Drawing.Size(161, 20);
            this.BTListBoxFuellen.TabIndex = 0;
            this.BTListBoxFuellen.Text = "Listbox füllen";
            this.BTListBoxFuellen.UseVisualStyleBackColor = true;
            this.BTListBoxFuellen.Click += new System.EventHandler(this.BTListBoxFuellen_Click);
            // 
            // BTListBoxEintraegeLoeschen
            // 
            this.BTListBoxEintraegeLoeschen.Location = new System.Drawing.Point(5, 19);
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
            this.listBox1.Size = new System.Drawing.Size(586, 368);
            this.listBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTListBoxTextAnhaengen);
            this.groupBox1.Controls.Add(this.buttonOutlook);
            this.groupBox1.Controls.Add(this.BTListBoxFuellen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(623, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // BTListBoxTextAnhaengen
            // 
            this.BTListBoxTextAnhaengen.Location = new System.Drawing.Point(5, 18);
            this.BTListBoxTextAnhaengen.Name = "BTListBoxTextAnhaengen";
            this.BTListBoxTextAnhaengen.Size = new System.Drawing.Size(161, 20);
            this.BTListBoxTextAnhaengen.TabIndex = 1;
            this.BTListBoxTextAnhaengen.Text = "Listbox mit Text füllen";
            this.BTListBoxTextAnhaengen.UseVisualStyleBackColor = true;
            this.BTListBoxTextAnhaengen.Click += new System.EventHandler(this.BTListBoxTextAnhaengen_Click);
            // 
            // buttonOutlook
            // 
            this.buttonOutlook.Location = new System.Drawing.Point(5, 98);
            this.buttonOutlook.Name = "buttonOutlook";
            this.buttonOutlook.Size = new System.Drawing.Size(159, 23);
            this.buttonOutlook.TabIndex = 8;
            this.buttonOutlook.Text = "Outlook";
            this.buttonOutlook.UseVisualStyleBackColor = true;
            this.buttonOutlook.Click += new System.EventHandler(this.ButtonOutlook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lotus Notes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTNotes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 449);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(13, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(586, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(5, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Listbox sortieren";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.BTListBoxEintraegeLoeschen);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(623, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // ButtonSchliessen
            // 
            this.ButtonSchliessen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonSchliessen.Location = new System.Drawing.Point(4, 19);
            this.ButtonSchliessen.Name = "ButtonSchliessen";
            this.ButtonSchliessen.Size = new System.Drawing.Size(160, 23);
            this.ButtonSchliessen.TabIndex = 0;
            this.ButtonSchliessen.Text = "Schliessen";
            this.ButtonSchliessen.UseVisualStyleBackColor = true;
            this.ButtonSchliessen.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ButtonSchliessen);
            this.groupBox5.Location = new System.Drawing.Point(623, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 93);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Location = new System.Drawing.Point(623, 329);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 132);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listeneinträge";
            // 
            // Form1
            // 
            this.CancelButton = this.ButtonSchliessen;
            this.ClientSize = new System.Drawing.Size(808, 466);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESDATABASEBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.Button ButtonSchliessen;
        private System.Windows.Forms.BindingSource nOTESDATABASEBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonOutlook;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
    }
}

