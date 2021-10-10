
namespace UI
{
    partial class Ticket_overview
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
            this.lblTicketView = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.dataTicket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketView
            // 
            this.lblTicketView.AutoSize = true;
            this.lblTicketView.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketView.Location = new System.Drawing.Point(41, 71);
            this.lblTicketView.Name = "lblTicketView";
            this.lblTicketView.Size = new System.Drawing.Size(305, 52);
            this.lblTicketView.TabIndex = 0;
            this.lblTicketView.Text = "Overview tickets";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(50, 136);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(323, 20);
            this.txtFilter.TabIndex = 1;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(622, 121);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(126, 35);
            this.btnCreateTicket.TabIndex = 2;
            this.btnCreateTicket.Text = "Create Incident";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            // 
            // dataTicket
            // 
            this.dataTicket.AllowUserToAddRows = false;
            this.dataTicket.AllowUserToDeleteRows = false;
            this.dataTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTicket.Location = new System.Drawing.Point(50, 191);
            this.dataTicket.Name = "dataTicket";
            this.dataTicket.ReadOnly = true;
            this.dataTicket.Size = new System.Drawing.Size(698, 238);
            this.dataTicket.TabIndex = 4;
            // 
            // Ticket_overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTicket);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblTicketView);
            this.Name = "Ticket_overview";
            this.Text = "Ticket_overview";
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketView;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.DataGridView dataTicket;
    }
}