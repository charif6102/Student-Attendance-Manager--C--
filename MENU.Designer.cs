namespace Student_management
{
    partial class MENU
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.modifyStudentBtn = new System.Windows.Forms.Button();
            this.customButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.Black;
            this.addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentBtn.Location = new System.Drawing.Point(495, 74);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(208, 364);
            this.addStudentBtn.TabIndex = 8;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click_1);
            // 
            // modifyStudentBtn
            // 
            this.modifyStudentBtn.BackColor = System.Drawing.Color.Black;
            this.modifyStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyStudentBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyStudentBtn.ForeColor = System.Drawing.Color.White;
            this.modifyStudentBtn.Location = new System.Drawing.Point(28, 73);
            this.modifyStudentBtn.Name = "modifyStudentBtn";
            this.modifyStudentBtn.Size = new System.Drawing.Size(208, 364);
            this.modifyStudentBtn.TabIndex = 9;
            this.modifyStudentBtn.Text = "Modify Student";
            this.modifyStudentBtn.UseVisualStyleBackColor = false;
            this.modifyStudentBtn.Click += new System.EventHandler(this.modifyStudentBtn_Click_1);
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.Color.Black;
            this.customButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton.ForeColor = System.Drawing.Color.White;
            this.customButton.Location = new System.Drawing.Point(261, 73);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(208, 364);
            this.customButton.TabIndex = 12;
            this.customButton.Text = "Check Schedule";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(971, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 364);
            this.button1.TabIndex = 16;
            this.button1.Text = "Mark Presence";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 18F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(731, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 364);
            this.button2.TabIndex = 17;
            this.button2.Text = "Consult Absence";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.modifyStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MENU";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button modifyStudentBtn;
        private System.Windows.Forms.Button customButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
