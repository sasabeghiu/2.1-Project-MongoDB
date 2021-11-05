
namespace UI
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblLogged = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnUM = new System.Windows.Forms.Button();
            this.chartOpen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUrgent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUrgent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Location = new System.Drawing.Point(651, 24);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(29, 13);
            this.lblLoggedIn.TabIndex = 0;
            this.lblLoggedIn.Text = "User";
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Location = new System.Drawing.Point(576, 24);
            this.lblLogged.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(71, 13);
            this.lblLogged.TabIndex = 25;
            this.lblLogged.Text = "Logged in as:";
            // 
            // btnIM
            // 
            this.btnIM.Location = new System.Drawing.Point(304, 57);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(141, 23);
            this.btnIM.TabIndex = 23;
            this.btnIM.Text = "Incident Management";
            this.btnIM.UseVisualStyleBackColor = true;
            this.btnIM.Click += new System.EventHandler(this.BtnIM_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(158, 57);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(141, 23);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnUM
            // 
            this.btnUM.Location = new System.Drawing.Point(452, 57);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(141, 23);
            this.btnUM.TabIndex = 21;
            this.btnUM.Text = "User Management";
            this.btnUM.UseVisualStyleBackColor = true;
            this.btnUM.Click += new System.EventHandler(this.BtnUM_Click);
            // 
            // chartOpen
            // 
            this.chartOpen.BorderlineColor = System.Drawing.Color.DarkOrange;
            this.chartOpen.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea7.Name = "ChartArea1";
            this.chartOpen.ChartAreas.Add(chartArea7);
            this.chartOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartOpen.Location = new System.Drawing.Point(71, 174);
            this.chartOpen.Name = "chartOpen";
            this.chartOpen.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series7.BorderColor = System.Drawing.Color.Transparent;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Name = "Series1";
            this.chartOpen.Series.Add(series7);
            this.chartOpen.Size = new System.Drawing.Size(306, 262);
            this.chartOpen.TabIndex = 32;
            this.chartOpen.Text = "chart1";
            title13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title13.ForeColor = System.Drawing.Color.DimGray;
            title13.Name = "Title1";
            title13.Text = "Unresolved incidents";
            title14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title14.ForeColor = System.Drawing.Color.DimGray;
            title14.Name = "Title2";
            title14.Text = "All tickets currently open";
            this.chartOpen.Titles.Add(title13);
            this.chartOpen.Titles.Add(title14);
            this.chartOpen.Click += new System.EventHandler(this.chartOpen_Click);
            // 
            // chartUrgent
            // 
            this.chartUrgent.BorderlineColor = System.Drawing.Color.Red;
            this.chartUrgent.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea8.Name = "ChartArea1";
            this.chartUrgent.ChartAreas.Add(chartArea8);
            this.chartUrgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartUrgent.Location = new System.Drawing.Point(418, 174);
            this.chartUrgent.Name = "chartUrgent";
            this.chartUrgent.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartUrgent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series8.BorderColor = System.Drawing.Color.Transparent;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Name = "Series2";
            this.chartUrgent.Series.Add(series8);
            this.chartUrgent.Size = new System.Drawing.Size(306, 262);
            this.chartUrgent.TabIndex = 33;
            this.chartUrgent.Text = "chart2";
            title15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title15.ForeColor = System.Drawing.Color.DimGray;
            title15.Name = "Title1";
            title15.Text = "Incidents past deadline";
            title16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title16.ForeColor = System.Drawing.Color.DimGray;
            title16.Name = "Title2";
            title16.Text = "These tickets need your immediate attention";
            this.chartUrgent.Titles.Add(title15);
            this.chartUrgent.Titles.Add(title16);
            this.chartUrgent.Click += new System.EventHandler(this.chartUrgent_Click);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.Location = new System.Drawing.Point(65, 110);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(237, 31);
            this.lblHeadline.TabIndex = 34;
            this.lblHeadline.Text = "Current incidents";
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(225)))));
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.ForeColor = System.Drawing.Color.White;
            this.btnShowList.Location = new System.Drawing.Point(567, 110);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(113, 41);
            this.btnShowList.TabIndex = 35;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.chartUrgent);
            this.Controls.Add(this.chartOpen);
            this.Controls.Add(this.lblLogged);
            this.Controls.Add(this.btnIM);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnUM);
            this.Controls.Add(this.lblLoggedIn);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUrgent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUrgent;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Button btnShowList;
    }
}