
namespace UI
{
    partial class User_overview
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
            this.lblUserView = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblUserView
            // 
            this.lblUserView.AutoSize = true;
            this.lblUserView.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserView.Location = new System.Drawing.Point(41, 71);
            this.lblUserView.Name = "lblUserView";
            this.lblUserView.Size = new System.Drawing.Size(332, 52);
            this.lblUserView.TabIndex = 0;
            this.lblUserView.Text = "User management";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(50, 136);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(323, 20);
            this.txtFilter.TabIndex = 1;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(622, 121);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(126, 35);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "+ ADD NEW USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(50, 191);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(698, 238);
            this.listUsers.TabIndex = 3;
            // 
            // User_overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblUserView);
            this.Name = "User_overview";
            this.Text = "User_overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserView;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox listUsers;
    }
}