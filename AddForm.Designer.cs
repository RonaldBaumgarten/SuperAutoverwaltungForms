namespace AutoverwaltungForms
{
    partial class AddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtModell = new TextBox();
            cmbMarke = new ComboBox();
            textBox1 = new TextBox();
            lblAntrieb = new Label();
            lblExtras = new Label();
            rdoBenzin = new RadioButton();
            rdoDiesel = new RadioButton();
            chkKlima = new CheckBox();
            chkSitzheizung = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            lblBaujahr = new Label();
            cmbBaujahr = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(85, 55);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Modellname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(85, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 1;
            label2.Text = "Marke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(85, 142);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "Preis";
            // 
            // txtModell
            // 
            txtModell.Location = new Point(216, 57);
            txtModell.Name = "txtModell";
            txtModell.Size = new Size(100, 23);
            txtModell.TabIndex = 3;
            // 
            // cmbMarke
            // 
            cmbMarke.FormattingEnabled = true;
            cmbMarke.Items.AddRange(new object[] { "BMW", "Mercedes", "Toyota", "Tesla", "VW" });
            cmbMarke.Location = new Point(214, 101);
            cmbMarke.Name = "cmbMarke";
            cmbMarke.Size = new Size(121, 23);
            cmbMarke.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblAntrieb
            // 
            lblAntrieb.AutoSize = true;
            lblAntrieb.Font = new Font("Segoe UI", 12F);
            lblAntrieb.Location = new Point(85, 223);
            lblAntrieb.Name = "lblAntrieb";
            lblAntrieb.Size = new Size(61, 21);
            lblAntrieb.TabIndex = 6;
            lblAntrieb.Text = "Antrieb";
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Font = new Font("Segoe UI", 12F);
            lblExtras.Location = new Point(85, 309);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new Size(51, 21);
            lblExtras.TabIndex = 7;
            lblExtras.Text = "Extras";
            // 
            // rdoBenzin
            // 
            rdoBenzin.AutoSize = true;
            rdoBenzin.Location = new Point(188, 226);
            rdoBenzin.Name = "rdoBenzin";
            rdoBenzin.Size = new Size(60, 19);
            rdoBenzin.TabIndex = 8;
            rdoBenzin.TabStop = true;
            rdoBenzin.Text = "Benzin";
            rdoBenzin.UseVisualStyleBackColor = true;
            // 
            // rdoDiesel
            // 
            rdoDiesel.AutoSize = true;
            rdoDiesel.Location = new Point(188, 281);
            rdoDiesel.Name = "rdoDiesel";
            rdoDiesel.Size = new Size(56, 19);
            rdoDiesel.TabIndex = 9;
            rdoDiesel.TabStop = true;
            rdoDiesel.Text = "Diesel";
            rdoDiesel.UseVisualStyleBackColor = true;
            // 
            // chkKlima
            // 
            chkKlima.AutoSize = true;
            chkKlima.Location = new Point(100, 365);
            chkKlima.Name = "chkKlima";
            chkKlima.Size = new Size(91, 19);
            chkKlima.TabIndex = 10;
            chkKlima.Text = "Klimaanlage";
            chkKlima.UseVisualStyleBackColor = true;
            // 
            // chkSitzheizung
            // 
            chkSitzheizung.AutoSize = true;
            chkSitzheizung.Location = new Point(216, 365);
            chkSitzheizung.Name = "chkSitzheizung";
            chkSitzheizung.Size = new Size(86, 19);
            chkSitzheizung.TabIndex = 11;
            chkSitzheizung.Text = "Sitzheizung";
            chkSitzheizung.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(396, 359);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 12;
            button1.Text = "Hinzufuegen";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(559, 359);
            button2.Name = "button2";
            button2.Size = new Size(130, 34);
            button2.TabIndex = 13;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblBaujahr
            // 
            lblBaujahr.AutoSize = true;
            lblBaujahr.Font = new Font("Segoe UI", 12F);
            lblBaujahr.Location = new Point(85, 189);
            lblBaujahr.Name = "lblBaujahr";
            lblBaujahr.Size = new Size(63, 21);
            lblBaujahr.TabIndex = 14;
            lblBaujahr.Text = "Baujahr";
            // 
            // cmbBaujahr
            // 
            cmbBaujahr.FormattingEnabled = true;
            cmbBaujahr.Location = new Point(214, 191);
            cmbBaujahr.Name = "cmbBaujahr";
            cmbBaujahr.Size = new Size(121, 23);
            cmbBaujahr.TabIndex = 15;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBaujahr);
            Controls.Add(lblBaujahr);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkSitzheizung);
            Controls.Add(chkKlima);
            Controls.Add(rdoDiesel);
            Controls.Add(rdoBenzin);
            Controls.Add(lblExtras);
            Controls.Add(lblAntrieb);
            Controls.Add(textBox1);
            Controls.Add(cmbMarke);
            Controls.Add(txtModell);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtModell;
        private ComboBox cmbMarke;
        private TextBox textBox1;
        private Label lblAntrieb;
        private Label lblExtras;
        private RadioButton rdoBenzin;
        private RadioButton rdoDiesel;
        private CheckBox chkKlima;
        private CheckBox chkSitzheizung;
        private Button button1;
        private Button button2;
        private Label lblBaujahr;
        private ComboBox cmbBaujahr;
    }
}