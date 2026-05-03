namespace POGOY_H2___CPE262_Final_Project
{
    partial class AnalyticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticsForm));
            panelSidebar = new Panel();
            btnExit = new Button();
            btnTopJobs = new Button();
            btnApplicationsStatus = new Button();
            btnJobsPerLocation = new Button();
            label2 = new Label();
            btnJobsPerCategory = new Button();
            chartAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartAnalytics).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panelSidebar.Controls.Add(btnExit);
            panelSidebar.Controls.Add(btnTopJobs);
            panelSidebar.Controls.Add(btnApplicationsStatus);
            panelSidebar.Controls.Add(btnJobsPerLocation);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(btnJobsPerCategory);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 853);
            panelSidebar.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.White;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 720);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(350, 100);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnTopJobs
            // 
            btnTopJobs.FlatAppearance.BorderSize = 0;
            btnTopJobs.FlatAppearance.MouseDownBackColor = Color.White;
            btnTopJobs.FlatAppearance.MouseOverBackColor = Color.Black;
            btnTopJobs.FlatStyle = FlatStyle.Flat;
            btnTopJobs.ForeColor = Color.White;
            btnTopJobs.Location = new Point(0, 470);
            btnTopJobs.Name = "btnTopJobs";
            btnTopJobs.Size = new Size(350, 100);
            btnTopJobs.TabIndex = 12;
            btnTopJobs.Text = "Top Jobs";
            btnTopJobs.UseVisualStyleBackColor = true;
            btnTopJobs.Click += btnTopJobs_Click;
            // 
            // btnApplicationsStatus
            // 
            btnApplicationsStatus.FlatAppearance.BorderSize = 0;
            btnApplicationsStatus.FlatAppearance.MouseDownBackColor = Color.White;
            btnApplicationsStatus.FlatAppearance.MouseOverBackColor = Color.Black;
            btnApplicationsStatus.FlatStyle = FlatStyle.Flat;
            btnApplicationsStatus.ForeColor = Color.White;
            btnApplicationsStatus.Location = new Point(0, 370);
            btnApplicationsStatus.Name = "btnApplicationsStatus";
            btnApplicationsStatus.Size = new Size(350, 100);
            btnApplicationsStatus.TabIndex = 11;
            btnApplicationsStatus.Text = "Applications Status";
            btnApplicationsStatus.UseVisualStyleBackColor = true;
            btnApplicationsStatus.Click += btnApplicationsStatus_Click;
            // 
            // btnJobsPerLocation
            // 
            btnJobsPerLocation.FlatAppearance.BorderSize = 0;
            btnJobsPerLocation.FlatAppearance.MouseDownBackColor = Color.White;
            btnJobsPerLocation.FlatAppearance.MouseOverBackColor = Color.Black;
            btnJobsPerLocation.FlatStyle = FlatStyle.Flat;
            btnJobsPerLocation.ForeColor = Color.White;
            btnJobsPerLocation.Location = new Point(0, 270);
            btnJobsPerLocation.Name = "btnJobsPerLocation";
            btnJobsPerLocation.Size = new Size(350, 100);
            btnJobsPerLocation.TabIndex = 10;
            btnJobsPerLocation.Text = "Jobs Per Location";
            btnJobsPerLocation.UseVisualStyleBackColor = true;
            btnJobsPerLocation.Click += btnJobsPerLocation_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 40);
            label2.Name = "label2";
            label2.Size = new Size(143, 45);
            label2.TabIndex = 9;
            label2.Text = "Analytics";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJobsPerCategory
            // 
            btnJobsPerCategory.FlatAppearance.BorderSize = 0;
            btnJobsPerCategory.FlatAppearance.MouseDownBackColor = Color.White;
            btnJobsPerCategory.FlatAppearance.MouseOverBackColor = Color.Black;
            btnJobsPerCategory.FlatStyle = FlatStyle.Flat;
            btnJobsPerCategory.ForeColor = Color.White;
            btnJobsPerCategory.Location = new Point(0, 170);
            btnJobsPerCategory.Name = "btnJobsPerCategory";
            btnJobsPerCategory.Size = new Size(350, 100);
            btnJobsPerCategory.TabIndex = 0;
            btnJobsPerCategory.Text = "Jobs Per Category";
            btnJobsPerCategory.UseVisualStyleBackColor = true;
            btnJobsPerCategory.Click += btnJobsPerCategory_Click;
            // 
            // chartAnalytics
            // 
            chartAnalytics.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartAnalytics.ChartAreas.Add(chartArea1);
            chartAnalytics.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartAnalytics.Legends.Add(legend1);
            chartAnalytics.Location = new Point(350, 0);
            chartAnalytics.Name = "chartAnalytics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartAnalytics.Series.Add(series1);
            chartAnalytics.Size = new Size(1072, 853);
            chartAnalytics.TabIndex = 7;
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(chartAnalytics);
            Controls.Add(panelSidebar);
            Name = "AnalyticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnalyticsForm";
            Load += AnalyticsForm_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartAnalytics).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblWelcome;
        private Label label1;
        private Button btnLogout;
        private Button btnFrequency;
        private Button btnViewApplicants;
        private Button btnEditJob;
        private Button btnJobsPerCategory;
        private Label label2;
        private Button btnJobsPerLocation;
        private Button btnApplicationsStatus;
        private Button btnTopJobs;
        private Button btnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics;
    }
}