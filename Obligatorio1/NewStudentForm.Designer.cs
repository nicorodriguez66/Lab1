namespace Obligatorio1
{
    partial class NewStudentForm
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
            this.studentNameTxtBox = new System.Windows.Forms.TextBox();
            this.studentSurnameTxtBox = new System.Windows.Forms.TextBox();
            this.studentNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentIdCardTxtBox = new System.Windows.Forms.TextBox();
            this.studentCreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNameTxtBox
            // 
            this.studentNameTxtBox.Location = new System.Drawing.Point(127, 12);
            this.studentNameTxtBox.Name = "studentNameTxtBox";
            this.studentNameTxtBox.Size = new System.Drawing.Size(130, 20);
            this.studentNameTxtBox.TabIndex = 2;
            // 
            // studentSurnameTxtBox
            // 
            this.studentSurnameTxtBox.Location = new System.Drawing.Point(127, 38);
            this.studentSurnameTxtBox.Name = "studentSurnameTxtBox";
            this.studentSurnameTxtBox.Size = new System.Drawing.Size(130, 20);
            this.studentSurnameTxtBox.TabIndex = 3;
            // 
            // studentNumberTxtBox
            // 
            this.studentNumberTxtBox.Location = new System.Drawing.Point(127, 64);
            this.studentNumberTxtBox.Name = "studentNumberTxtBox";
            this.studentNumberTxtBox.Size = new System.Drawing.Size(130, 20);
            this.studentNumberTxtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "IdCard";
            // 
            // studentIdCardTxtBox
            // 
            this.studentIdCardTxtBox.Location = new System.Drawing.Point(127, 90);
            this.studentIdCardTxtBox.Name = "studentIdCardTxtBox";
            this.studentIdCardTxtBox.Size = new System.Drawing.Size(130, 20);
            this.studentIdCardTxtBox.TabIndex = 9;
            // 
            // studentCreateBtn
            // 
            this.studentCreateBtn.Location = new System.Drawing.Point(128, 120);
            this.studentCreateBtn.Name = "studentCreateBtn";
            this.studentCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.studentCreateBtn.TabIndex = 10;
            this.studentCreateBtn.Text = "Create";
            this.studentCreateBtn.UseVisualStyleBackColor = true;
            this.studentCreateBtn.Click += new System.EventHandler(this.studentCreateBtn_Click);
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 157);
            this.Controls.Add(this.studentCreateBtn);
            this.Controls.Add(this.studentIdCardTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNumberTxtBox);
            this.Controls.Add(this.studentSurnameTxtBox);
            this.Controls.Add(this.studentNameTxtBox);
            this.Name = "NewStudentForm";
            this.Text = "NewStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNameTxtBox;
        private System.Windows.Forms.TextBox studentSurnameTxtBox;
        private System.Windows.Forms.TextBox studentNumberTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentIdCardTxtBox;
        private System.Windows.Forms.Button studentCreateBtn;
    }
}