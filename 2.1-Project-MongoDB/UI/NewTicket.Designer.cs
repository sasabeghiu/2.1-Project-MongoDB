
namespace UI
{
    partial class NewTicket
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
            this.btnSubmitTKT = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxDeadline = new System.Windows.Forms.ComboBox();
            this.comboBoxincident = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxreportedbyuser = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.dateTimePickerincident = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSubmitTKT
            // 
            this.btnSubmitTKT.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmitTKT.ForeColor = System.Drawing.Color.White;
            this.btnSubmitTKT.Location = new System.Drawing.Point(721, 452);
            this.btnSubmitTKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitTKT.Name = "btnSubmitTKT";
            this.btnSubmitTKT.Size = new System.Drawing.Size(119, 49);
            this.btnSubmitTKT.TabIndex = 52;
            this.btnSubmitTKT.Text = "Submit Ticket";
            this.btnSubmitTKT.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(721, 363);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxDeadline
            // 
            this.comboBoxDeadline.FormattingEnabled = true;
            this.comboBoxDeadline.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters"});
            this.comboBoxDeadline.Location = new System.Drawing.Point(319, 436);
            this.comboBoxDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDeadline.Name = "comboBoxDeadline";
            this.comboBoxDeadline.Size = new System.Drawing.Size(252, 24);
            this.comboBoxDeadline.TabIndex = 49;
            // 
            // comboBoxincident
            // 
            this.comboBoxincident.FormattingEnabled = true;
            this.comboBoxincident.Items.AddRange(new object[] {
            "Employee",
            "ServiceDesk"});
            this.comboBoxincident.Location = new System.Drawing.Point(319, 307);
            this.comboBoxincident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxincident.Name = "comboBoxincident";
            this.comboBoxincident.Size = new System.Drawing.Size(252, 24);
            this.comboBoxincident.TabIndex = 48;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(319, 266);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(252, 22);
            this.txtSubject.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 32);
            this.label8.TabIndex = 43;
            this.label8.Text = "Create new incident ticket";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(846, 50);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 17);
            this.lblLogin.TabIndex = 42;
            this.lblLogin.Text = "User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Logged in as:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Deadline/follow up:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Reported by user:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Type of incident:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Subject of incident:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Date/time reported:";
            // 
            // btnIM
            // 
            this.btnIM.Location = new System.Drawing.Point(383, 90);
            this.btnIM.Margin = new System.Windows.Forms.Padding(4);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(188, 28);
            this.btnIM.TabIndex = 33;
            this.btnIM.Text = "Incident Management";
            this.btnIM.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(189, 90);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(188, 28);
            this.btnDashboard.TabIndex = 32;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnUM
            // 
            this.btnUM.Location = new System.Drawing.Point(581, 90);
            this.btnUM.Margin = new System.Windows.Forms.Padding(4);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(188, 28);
            this.btnUM.TabIndex = 31;
            this.btnUM.Text = "User Management";
            this.btnUM.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(319, 479);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(252, 63);
            this.richTextBoxDescription.TabIndex = 53;
            this.richTextBoxDescription.Text = "";
            // 
            // comboBoxreportedbyuser
            // 
            this.comboBoxreportedbyuser.FormattingEnabled = true;
            this.comboBoxreportedbyuser.Items.AddRange(new object[] {
            "Employee",
            "ServiceDesk"});
            this.comboBoxreportedbyuser.Location = new System.Drawing.Point(319, 350);
            this.comboBoxreportedbyuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxreportedbyuser.Name = "comboBoxreportedbyuser";
            this.comboBoxreportedbyuser.Size = new System.Drawing.Size(252, 24);
            this.comboBoxreportedbyuser.TabIndex = 55;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Employee",
            "ServiceDesk"});
            this.comboBoxPriority.Location = new System.Drawing.Point(319, 393);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(252, 24);
            this.comboBoxPriority.TabIndex = 56;
            // 
            // dateTimePickerincident
            // 
            this.dateTimePickerincident.Location = new System.Drawing.Point(319, 227);
            this.dateTimePickerincident.Name = "dateTimePickerincident";
            this.dateTimePickerincident.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerincident.TabIndex = 57;
            // 
            // NewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateTimePickerincident);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxreportedbyuser);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.btnSubmitTKT);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxDeadline);
            this.Controls.Add(this.comboBoxincident);
            this.Controls.Add(this.txtSubject);
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
            this.Name = "NewTicket";
            this.Text = "NewTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitTKT;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxDeadline;
        private System.Windows.Forms.ComboBox comboBoxincident;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxreportedbyuser;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.DateTimePicker dateTimePickerincident;
    }
}