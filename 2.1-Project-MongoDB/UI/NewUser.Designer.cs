
namespace UI
{
    partial class NewUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxpassword = new System.Windows.Forms.CheckBox();
            this.comboBoxlocation = new System.Windows.Forms.ComboBox();
            this.comboBoxuser = new System.Windows.Forms.ComboBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxlname = new System.Windows.Forms.TextBox();
            this.textBoxfname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.errorProviderText = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderText)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(557, 351);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 40);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD USER";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 279);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 40);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // checkBoxpassword
            // 
            this.checkBoxpassword.AutoSize = true;
            this.checkBoxpassword.Location = new System.Drawing.Point(256, 377);
            this.checkBoxpassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxpassword.Name = "checkBoxpassword";
            this.checkBoxpassword.Size = new System.Drawing.Size(240, 17);
            this.checkBoxpassword.TabIndex = 28;
            this.checkBoxpassword.Text = "yes, a password e-mail will be sent to the user";
            this.checkBoxpassword.UseVisualStyleBackColor = true;
            // 
            // comboBoxlocation
            // 
            this.comboBoxlocation.FormattingEnabled = true;
            this.comboBoxlocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters"});
            this.comboBoxlocation.Location = new System.Drawing.Point(256, 339);
            this.comboBoxlocation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxlocation.Name = "comboBoxlocation";
            this.comboBoxlocation.Size = new System.Drawing.Size(190, 21);
            this.comboBoxlocation.TabIndex = 27;
            this.comboBoxlocation.Leave += new System.EventHandler(this.comboBoxlocation_Leave);
            // 
            // comboBoxuser
            // 
            this.comboBoxuser.FormattingEnabled = true;
            this.comboBoxuser.Items.AddRange(new object[] {
            "Employee",
            "ServiceDesk"});
            this.comboBoxuser.Location = new System.Drawing.Point(256, 235);
            this.comboBoxuser.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxuser.Name = "comboBoxuser";
            this.comboBoxuser.Size = new System.Drawing.Size(190, 21);
            this.comboBoxuser.TabIndex = 26;
            this.comboBoxuser.Leave += new System.EventHandler(this.comboBoxuser_Leave);
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(256, 302);
            this.textBoxphone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(190, 20);
            this.textBoxphone.TabIndex = 24;
            this.textBoxphone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxphone_Validating);
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(256, 265);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(190, 20);
            this.textBoxemail.TabIndex = 23;
            this.textBoxemail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxemail_Validating);
            // 
            // textBoxlname
            // 
            this.textBoxlname.Location = new System.Drawing.Point(256, 197);
            this.textBoxlname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxlname.Name = "textBoxlname";
            this.textBoxlname.Size = new System.Drawing.Size(190, 20);
            this.textBoxlname.TabIndex = 22;
            this.textBoxlname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxlname_Validating);
            // 
            // textBoxfname
            // 
            this.textBoxfname.Location = new System.Drawing.Point(256, 162);
            this.textBoxfname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxfname.Name = "textBoxfname";
            this.textBoxfname.Size = new System.Drawing.Size(190, 20);
            this.textBoxfname.TabIndex = 25;
            this.textBoxfname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxfname_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Create new user";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Send password?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Location/branch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-mail address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type of user:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "First name:";
            // 
            // btnIM
            // 
            this.btnIM.Location = new System.Drawing.Point(304, 57);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(141, 23);
            this.btnIM.TabIndex = 13;
            this.btnIM.Text = "Incident Management";
            this.btnIM.UseVisualStyleBackColor = true;
            this.btnIM.Click += new System.EventHandler(this.BtnIM_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(158, 57);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(141, 23);
            this.btnDashboard.TabIndex = 12;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnUM
            // 
            this.btnUM.Location = new System.Drawing.Point(452, 57);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(141, 23);
            this.btnUM.TabIndex = 11;
            this.btnUM.Text = "User Management";
            this.btnUM.UseVisualStyleBackColor = true;
            this.btnUM.Click += new System.EventHandler(this.BtnUM_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Logged in as:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(651, 24);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(29, 13);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "User";
            // 
            // errorProviderText
            // 
            this.errorProviderText.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderText.ContainerControl = this;
            this.errorProviderText.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderText.Icon")));
            this.errorProviderText.RightToLeftChanged += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.checkBoxpassword);
            this.Controls.Add(this.comboBoxlocation);
            this.Controls.Add(this.comboBoxuser);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxlname);
            this.Controls.Add(this.textBoxfname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIM);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnUM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxpassword;
        private System.Windows.Forms.ComboBox comboBoxlocation;
        private System.Windows.Forms.ComboBox comboBoxuser;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxlname;
        private System.Windows.Forms.TextBox textBoxfname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ErrorProvider errorProviderText;
    }
}