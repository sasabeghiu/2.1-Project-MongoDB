
namespace UI
{
    partial class TransferTicket
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.transferBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transferLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 70);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(26, 128);
            this.transferBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(249, 41);
            this.transferBtn.TabIndex = 5;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transfer Ticket";
            // 
            // transferLbl
            // 
            this.transferLbl.AutoSize = true;
            this.transferLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLbl.Location = new System.Drawing.Point(13, 77);
            this.transferLbl.Name = "transferLbl";
            this.transferLbl.Size = new System.Drawing.Size(107, 15);
            this.transferLbl.TabIndex = 7;
            this.transferLbl.Text = "Transfer from { } to";
            // 
            // TransferTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 189);
            this.Controls.Add(this.transferLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TransferTicket";
            this.Text = "TransferTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transferLbl;
    }
}