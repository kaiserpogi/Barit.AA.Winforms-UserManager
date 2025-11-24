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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            btnAdd = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(347, 311);
            dataGridView1.TabIndex = 0;
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
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 389);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
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
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 438);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "ListUsersForm";
            Text = "ListUsersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Button btnAdd;
        private Button btnView;
    }
}