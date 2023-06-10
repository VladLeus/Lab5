namespace Lab5
{
    partial class PublicationAdd
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
            this.StudentName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Enrollment = new System.Windows.Forms.Label();
            this.Achivments = new System.Windows.Forms.ComboBox();
            this.achivlabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(50, 38);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(165, 23);
            this.StudentName.TabIndex = 0;
            this.StudentName.Validating += new System.ComponentModel.CancelEventHandler(this.StudentName_Validating);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(50, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(107, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Student name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(50, 77);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(129, 20);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Student surname";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(50, 163);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(165, 23);
            this.Date.TabIndex = 4;
            // 
            // Enrollment
            // 
            this.Enrollment.AutoSize = true;
            this.Enrollment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enrollment.Location = new System.Drawing.Point(50, 140);
            this.Enrollment.Name = "Enrollment";
            this.Enrollment.Size = new System.Drawing.Size(174, 20);
            this.Enrollment.TabIndex = 5;
            this.Enrollment.Text = "Student enrollment day";
            // 
            // Achivments
            // 
            this.Achivments.FormattingEnabled = true;
            this.Achivments.Location = new System.Drawing.Point(50, 229);
            this.Achivments.Name = "Achivments";
            this.Achivments.Size = new System.Drawing.Size(165, 23);
            this.Achivments.TabIndex = 6;
            // 
            // achivlabel
            // 
            this.achivlabel.AutoSize = true;
            this.achivlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.achivlabel.Location = new System.Drawing.Point(50, 206);
            this.achivlabel.Name = "achivlabel";
            this.achivlabel.Size = new System.Drawing.Size(222, 20);
            this.achivlabel.TabIndex = 7;
            this.achivlabel.Text = "Student scientific achievments";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(85, 281);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 38);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(50, 100);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(165, 23);
            this.Surname.TabIndex = 9;
            this.Surname.Validating += new System.ComponentModel.CancelEventHandler(this.Surname_Validating);
            // 
            // PublicationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 374);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.achivlabel);
            this.Controls.Add(this.Achivments);
            this.Controls.Add(this.Enrollment);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StudentName);
            this.Name = "PublicationAdd";
            this.Text = "Publication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PublicationAdd_FormClosing);
            this.Load += new System.EventHandler(this.Publication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox StudentName;
        private Label NameLabel;
        private Label SurnameLabel;
        private DateTimePicker Date;
        private Label Enrollment;
        private ComboBox Achivments;
        private Label achivlabel;
        private Button Save;
        private TextBox Surname;
    }
}