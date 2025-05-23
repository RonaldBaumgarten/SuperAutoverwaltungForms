namespace AutoverwaltungForms
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
            label1 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lst = new ListBox();
            label3 = new Label();
            lblGesamtwert = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAnzahl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(169, 28);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 0;
            label1.Text = "Super Autoverwaltung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(302, 93);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Alle Autos:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(47, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "neu erstellen";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(47, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "bearbeiten";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(47, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "loeschen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lst
            // 
            lst.FormattingEnabled = true;
            lst.ItemHeight = 15;
            lst.Location = new Point(302, 117);
            lst.Name = "lst";
            lst.Size = new Size(287, 229);
            lst.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(302, 394);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 6;
            label3.Text = "Gesamtwert:";
            // 
            // lblGesamtwert
            // 
            lblGesamtwert.AutoSize = true;
            lblGesamtwert.BackColor = SystemColors.ControlLightLight;
            lblGesamtwert.Font = new Font("Segoe UI", 12F);
            lblGesamtwert.Location = new Point(492, 384);
            lblGesamtwert.Name = "lblGesamtwert";
            lblGesamtwert.Size = new Size(0, 21);
            lblGesamtwert.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(302, 359);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 8;
            label4.Text = "Anzahl:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(328, 204);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 9;
            // 
            // lblAnzahl
            // 
            lblAnzahl.AutoSize = true;
            lblAnzahl.BackColor = SystemColors.ControlLightLight;
            lblAnzahl.Font = new Font("Segoe UI", 12F);
            lblAnzahl.Location = new Point(530, 359);
            lblAnzahl.Name = "lblAnzahl";
            lblAnzahl.Size = new Size(19, 21);
            lblAnzahl.TabIndex = 10;
            lblAnzahl.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 452);
            Controls.Add(lblAnzahl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblGesamtwert);
            Controls.Add(label3);
            Controls.Add(lst);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListBox lst;
        private Label label3;
        private Label lblGesamtwert;
        private Label label4;
        private Label label5;
        private Label lblAnzahl;
    }
}
