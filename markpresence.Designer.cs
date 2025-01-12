namespace Student_management
{
    partial class markpresence
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
            this.Save = new System.Windows.Forms.Button();
            this.absentBox = new System.Windows.Forms.ListBox();
            this.presnetBox = new System.Windows.Forms.ListBox();
            this.studentBox = new System.Windows.Forms.ListBox();
            this.absentbtn = new System.Windows.Forms.Button();
            this.prsentbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // classnumber
            // 
            this.classnumber.BackColor = System.Drawing.Color.Black;
            this.classnumber.ForeColor = System.Drawing.Color.White;
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
            this.classnumber.Location = new System.Drawing.Point(60, 66);
            this.classnumber.Name = "classnumber";
            this.classnumber.Size = new System.Drawing.Size(84, 28);
            this.classnumber.TabIndex = 43;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Black;
            this.Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(602, 444);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 55);
            this.Save.TabIndex = 42;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // absentBox
            // 
            this.absentBox.BackColor = System.Drawing.Color.Black;
            this.absentBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentBox.ForeColor = System.Drawing.Color.White;
            this.absentBox.FormattingEnabled = true;
            this.absentBox.ItemHeight = 29;
            this.absentBox.Location = new System.Drawing.Point(259, 48);
            this.absentBox.Name = "absentBox";
            this.absentBox.Size = new System.Drawing.Size(213, 352);
            this.absentBox.TabIndex = 41;
            // 
            // presnetBox
            // 
            this.presnetBox.BackColor = System.Drawing.Color.Black;
            this.presnetBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presnetBox.ForeColor = System.Drawing.Color.White;
            this.presnetBox.FormattingEnabled = true;
            this.presnetBox.ItemHeight = 29;
            this.presnetBox.Location = new System.Drawing.Point(898, 48);
            this.presnetBox.Name = "presnetBox";
            this.presnetBox.Size = new System.Drawing.Size(213, 352);
            this.presnetBox.TabIndex = 40;
            // 
            // studentBox
            // 
            this.studentBox.BackColor = System.Drawing.Color.Black;
            this.studentBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBox.ForeColor = System.Drawing.Color.White;
            this.studentBox.FormattingEnabled = true;
            this.studentBox.ItemHeight = 29;
            this.studentBox.Location = new System.Drawing.Point(567, 48);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(213, 352);
            this.studentBox.TabIndex = 39;
            // 
            // absentbtn
            // 
            this.absentbtn.BackColor = System.Drawing.Color.Black;
            this.absentbtn.ForeColor = System.Drawing.Color.White;
            this.absentbtn.Location = new System.Drawing.Point(478, 163);
            this.absentbtn.Name = "absentbtn";
            this.absentbtn.Size = new System.Drawing.Size(83, 37);
            this.absentbtn.TabIndex = 38;
            this.absentbtn.Text = "Absent";
            this.absentbtn.UseVisualStyleBackColor = false;
            this.absentbtn.Click += new System.EventHandler(this.absentbtn_Click_1);
            // 
            // prsentbtn
            // 
            this.prsentbtn.BackColor = System.Drawing.Color.Black;
            this.prsentbtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prsentbtn.ForeColor = System.Drawing.Color.White;
            this.prsentbtn.Location = new System.Drawing.Point(786, 163);
            this.prsentbtn.Name = "prsentbtn";
            this.prsentbtn.Size = new System.Drawing.Size(106, 37);
            this.prsentbtn.TabIndex = 37;
            this.prsentbtn.Text = "Present";
            this.prsentbtn.UseVisualStyleBackColor = false;
            this.prsentbtn.Click += new System.EventHandler(this.prsentbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "choose the class number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classnumber);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.absentBox);
            this.Controls.Add(this.presnetBox);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.absentbtn);
            this.Controls.Add(this.prsentbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classnumber;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListBox absentBox;
        private System.Windows.Forms.ListBox presnetBox;
        private System.Windows.Forms.ListBox studentBox;
        private System.Windows.Forms.Button absentbtn;
        private System.Windows.Forms.Button prsentbtn;
        private System.Windows.Forms.Label label1;
    }
}