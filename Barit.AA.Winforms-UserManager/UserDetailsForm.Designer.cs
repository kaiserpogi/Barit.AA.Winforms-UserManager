namespace Barit.AA.Winforms_UserManager
{
    partial class UserDetailsForm
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
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 131);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 10;
            label1.Text = "Full Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 190);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 160);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "Username: ";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(119, 229);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 131);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 14;
            label4.Text = "Aevron Andrei Barit";
           
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 190);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 13;
            label5.Text = "*********";
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 160);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 12;
            label6.Text = "aevpogi";
            label6.Click += label6_Click;
            // 
            // UserDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 373);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "UserDetailsForm";
            Text = "UserDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}