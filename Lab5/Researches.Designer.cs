namespace Lab5
{
    partial class Researches
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
            this.OrgName = new System.Windows.Forms.TextBox();
            this.Organization = new System.Windows.Forms.Label();
            this.ResearchLabel = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.PublicationList = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrgName
            // 
            this.OrgName.Location = new System.Drawing.Point(54, 34);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new System.Drawing.Size(147, 23);
            this.OrgName.TabIndex = 0;
            this.OrgName.Validating += new System.ComponentModel.CancelEventHandler(this.OrgName_Validating);
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Organization.Location = new System.Drawing.Point(54, 9);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(145, 20);
            this.Organization.TabIndex = 1;
            this.Organization.Text = "Organization Name";
            // 
            // ResearchLabel
            // 
            this.ResearchLabel.AutoSize = true;
            this.ResearchLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResearchLabel.Location = new System.Drawing.Point(227, 9);
            this.ResearchLabel.Name = "ResearchLabel";
            this.ResearchLabel.Size = new System.Drawing.Size(124, 20);
            this.ResearchLabel.TabIndex = 3;
            this.ResearchLabel.Text = "Research Theme";
            // 
            // Theme
            // 
            this.Theme.Location = new System.Drawing.Point(227, 34);
            this.Theme.Name = "Theme";
            this.Theme.Size = new System.Drawing.Size(147, 23);
            this.Theme.TabIndex = 2;
            this.Theme.Validating += new System.ComponentModel.CancelEventHandler(this.Theme_Validating);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CostLabel.Location = new System.Drawing.Point(400, 9);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 20);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(400, 34);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(147, 23);
            this.Cost.TabIndex = 4;
            this.Cost.Validating += new System.ComponentModel.CancelEventHandler(this.Cost_Validating);
            // 
            // PublicationList
            // 
            this.PublicationList.FormattingEnabled = true;
            this.PublicationList.ItemHeight = 15;
            this.PublicationList.Location = new System.Drawing.Point(54, 85);
            this.PublicationList.Name = "PublicationList";
            this.PublicationList.Size = new System.Drawing.Size(649, 244);
            this.PublicationList.TabIndex = 6;
            this.PublicationList.SelectedIndexChanged += new System.EventHandler(this.PublicationList_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(54, 344);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(92, 39);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(335, 344);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(92, 39);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(611, 344);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(92, 39);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(335, 399);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 39);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(583, 34);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(139, 23);
            this.Date.TabIndex = 11;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(583, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(96, 20);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Signing date";
            // 
            // Researches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PublicationList);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.ResearchLabel);
            this.Controls.Add(this.Theme);
            this.Controls.Add(this.Organization);
            this.Controls.Add(this.OrgName);
            this.Name = "Researches";
            this.Text = "Researches";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Researches_FormClosing);
            this.Load += new System.EventHandler(this.Researches_Load);
            this.Click += new System.EventHandler(this.Researches_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OrgName;
        private Label Organization;
        private Label ResearchLabel;
        private TextBox Theme;
        private Label CostLabel;
        private TextBox Cost;
        private ListBox PublicationList;
        private Button Add;
        private Button Remove;
        private Button Edit;
        private Button Save;
        private DateTimePicker Date;
        private Label DateLabel;
    }
}