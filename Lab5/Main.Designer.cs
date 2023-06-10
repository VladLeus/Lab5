namespace Lab5
{
    partial class Main
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
            this.ResearchList = new System.Windows.Forms.ListBox();
            this.Researches = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResearchList
            // 
            this.ResearchList.FormattingEnabled = true;
            this.ResearchList.ItemHeight = 15;
            this.ResearchList.Location = new System.Drawing.Point(69, 31);
            this.ResearchList.Name = "ResearchList";
            this.ResearchList.Size = new System.Drawing.Size(680, 304);
            this.ResearchList.TabIndex = 0;
            this.ResearchList.SelectedIndexChanged += new System.EventHandler(this.ResearchList_SelectedIndexChanged);
            // 
            // Researches
            // 
            this.Researches.AutoSize = true;
            this.Researches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Researches.Location = new System.Drawing.Point(69, 7);
            this.Researches.Name = "Researches";
            this.Researches.Size = new System.Drawing.Size(94, 21);
            this.Researches.TabIndex = 1;
            this.Researches.Text = "Researches";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(69, 357);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 45);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(375, 357);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(97, 45);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(652, 357);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 45);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Researches);
            this.Controls.Add(this.ResearchList);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ResearchList;
        private Label Researches;
        private Button Add;
        private Button Remove;
        private Button Edit;
    }
}