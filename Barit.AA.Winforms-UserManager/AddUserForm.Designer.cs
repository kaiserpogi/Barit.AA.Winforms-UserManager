namespace Barit.AA.Winforms_UserManager
{
    partial class AddUserForm
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
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtboxFname = new TextBox();
            btnSave = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 132);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Username: ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(94, 129);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 23);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 162);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Password: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(233, 23);
            txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 103);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 7;
            label1.Text = "Full Name: ";
            // 
            // txtboxFname
            // 
            txtboxFname.Location = new Point(95, 100);
            txtboxFname.Name = "txtboxFname";
            txtboxFname.Size = new Size(233, 23);
            txtboxFname.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gainsboro;
            btnSave.Location = new Point(148, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 37);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "ADD USER FORM";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 237);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtboxFname);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Name = "AddUserForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtboxFname;
        private Button btnSave;
        private Label label4;
    }
}
