namespace Student_management
{
    partial class consultpresence
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
            this.classnumber = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.absentBox = new System.Windows.Forms.ListBox();
            this.presnetBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classnumber
            // 
            this.classnumber.BackColor = System.Drawing.Color.Black;
            this.classnumber.FormattingEnabled = true;
            this.classnumber.Items.AddRange(new object[] {
            "01",
            "02",
            "03 ",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09"});
            this.classnumber.Location = new System.Drawing.Point(51, 71);
            this.classnumber.Name = "classnumber";
            this.classnumber.Size = new System.Drawing.Size(84, 28);
            this.classnumber.TabIndex = 38;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Black;
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(528, 377);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(134, 55);
            this.search.TabIndex = 37;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // absentBox
            // 
            this.absentBox.BackColor = System.Drawing.Color.Black;
            this.absentBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentBox.ForeColor = System.Drawing.Color.White;
            this.absentBox.FormattingEnabled = true;
            this.absentBox.ItemHeight = 29;
            this.absentBox.Location = new System.Drawing.Point(286, 19);
            this.absentBox.Name = "absentBox";
            this.absentBox.Size = new System.Drawing.Size(213, 352);
            this.absentBox.TabIndex = 36;
            // 
            // presnetBox
            // 
            this.presnetBox.BackColor = System.Drawing.Color.Black;
            this.presnetBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presnetBox.ForeColor = System.Drawing.Color.White;
            this.presnetBox.FormattingEnabled = true;
            this.presnetBox.ItemHeight = 29;
            this.presnetBox.Location = new System.Drawing.Point(704, 19);
            this.presnetBox.Name = "presnetBox";
            this.presnetBox.Size = new System.Drawing.Size(213, 352);
            this.presnetBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "choose the class number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classnumber);
            this.Controls.Add(this.search);
            this.Controls.Add(this.absentBox);
            this.Controls.Add(this.presnetBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classnumber;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox absentBox;
        private System.Windows.Forms.ListBox presnetBox;
        private System.Windows.Forms.Label label1;
    }
}