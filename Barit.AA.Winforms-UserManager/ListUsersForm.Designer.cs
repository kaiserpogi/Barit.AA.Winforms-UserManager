namespace Barit.AA.Winforms_UserManager
{
    partial class ListUsersForm
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
            dgViewUsers = new DataGridView();
            label4 = new Label();
            btnNew = new Button();
            btnView = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dgViewUsers
            // 
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new Point(1, 49);
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.Size = new Size(347, 311);
            dgViewUsers.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 18);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "List of Users";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(69, 389);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 11;
            btnNew.Text = "New User";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(205, 389);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 12;
            btnView.Text = "View User";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(254, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 438);
            Controls.Add(btnRefresh);
            Controls.Add(btnView);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(dgViewUsers);
            Name = "ListUsersForm";
            Text = "ListUsersForm";
            Load += ListUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViewUsers;
        private Label label4;
        private Button btnNew;
        private Button btnView;
        private Button btnRefresh;
    }
}