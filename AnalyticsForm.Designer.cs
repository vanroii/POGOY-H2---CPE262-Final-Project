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
            btnTopJobs = new Button();
            btnApplicationsStatus = new Button();
            btnJobsPerLocation = new Button();
            btnJobsPerCategory = new Button();
            chartAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartAnalytics).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.Controls.Add(btnTopJobs);
            panelSidebar.Controls.Add(btnApplicationsStatus);
            panelSidebar.Controls.Add(btnJobsPerLocation);
            panelSidebar.Controls.Add(btnJobsPerCategory);
            panelSidebar.Dock = DockStyle.Top;
            panelSidebar.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(1072, 75);
            panelSidebar.TabIndex = 6;
            // 
            // btnTopJobs
            // 
            btnTopJobs.Cursor = Cursors.Hand;
            btnTopJobs.FlatAppearance.BorderColor = Color.Gray;
            btnTopJobs.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnTopJobs.FlatAppearance.MouseDownBackColor = Color.Black;
            btnTopJobs.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnTopJobs.FlatStyle = FlatStyle.Flat;
            btnTopJobs.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTopJobs.ForeColor = Color.White;
            btnTopJobs.Location = new Point(804, 0);
            btnTopJobs.Name = "btnTopJobs";
            btnTopJobs.Size = new Size(270, 75);
            btnTopJobs.TabIndex = 12;
            btnTopJobs.Text = "Top Jobs";
            btnTopJobs.UseVisualStyleBackColor = true;
            btnTopJobs.Click += btnTopJobs_Click;
            // 
            // btnApplicationsStatus
            // 
            btnApplicationsStatus.Cursor = Cursors.Hand;
            btnApplicationsStatus.FlatAppearance.BorderColor = Color.Gray;
            btnApplicationsStatus.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnApplicationsStatus.FlatAppearance.MouseDownBackColor = Color.Black;
            btnApplicationsStatus.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnApplicationsStatus.FlatStyle = FlatStyle.Flat;
            btnApplicationsStatus.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApplicationsStatus.ForeColor = Color.White;
            btnApplicationsStatus.Location = new Point(536, 0);
            btnApplicationsStatus.Name = "btnApplicationsStatus";
            btnApplicationsStatus.Size = new Size(268, 75);
            btnApplicationsStatus.TabIndex = 11;
            btnApplicationsStatus.Text = "Applications Status";
            btnApplicationsStatus.UseVisualStyleBackColor = true;
            btnApplicationsStatus.Click += btnApplicationsStatus_Click;
            // 
            // btnJobsPerLocation
            // 
            btnJobsPerLocation.Cursor = Cursors.Hand;
            btnJobsPerLocation.FlatAppearance.BorderColor = Color.Gray;
            btnJobsPerLocation.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnJobsPerLocation.FlatAppearance.MouseDownBackColor = Color.Black;
            btnJobsPerLocation.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnJobsPerLocation.FlatStyle = FlatStyle.Flat;
            btnJobsPerLocation.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJobsPerLocation.ForeColor = Color.White;
            btnJobsPerLocation.Location = new Point(268, 0);
            btnJobsPerLocation.Name = "btnJobsPerLocation";
            btnJobsPerLocation.Size = new Size(268, 75);
            btnJobsPerLocation.TabIndex = 10;
            btnJobsPerLocation.Text = "Jobs Per Location";
            btnJobsPerLocation.UseVisualStyleBackColor = true;
            btnJobsPerLocation.Click += btnJobsPerLocation_Click;
            // 
            // btnJobsPerCategory
            // 
            btnJobsPerCategory.Cursor = Cursors.Hand;
            btnJobsPerCategory.FlatAppearance.BorderColor = Color.Gray;
            btnJobsPerCategory.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnJobsPerCategory.FlatAppearance.MouseDownBackColor = Color.Black;
            btnJobsPerCategory.FlatAppearance.MouseOverBackColor = Color.Orange;
            btnJobsPerCategory.FlatStyle = FlatStyle.Flat;
            btnJobsPerCategory.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJobsPerCategory.ForeColor = Color.White;
            btnJobsPerCategory.Location = new Point(-2, 0);
            btnJobsPerCategory.Name = "btnJobsPerCategory";
            btnJobsPerCategory.Size = new Size(270, 75);
            btnJobsPerCategory.TabIndex = 0;
            btnJobsPerCategory.Text = "Jobs Per Category";
            btnJobsPerCategory.UseVisualStyleBackColor = true;
            btnJobsPerCategory.Click += btnJobsPerCategory_Click;
            // 
            // chartAnalytics
            // 
            chartAnalytics.BackColor = Color.Transparent;
            chartAnalytics.BackgroundImageLayout = ImageLayout.Stretch;
            chartAnalytics.BorderlineWidth = 0;
            chartAnalytics.BorderSkin.BackColor = Color.Transparent;
            chartAnalytics.BorderSkin.BorderColor = Color.White;
            chartAnalytics.BorderSkin.PageColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartAnalytics.ChartAreas.Add(chartArea1);
            chartAnalytics.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartAnalytics.Legends.Add(legend1);
            chartAnalytics.Location = new Point(0, 75);
            chartAnalytics.Name = "chartAnalytics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartAnalytics.Series.Add(series1);
            chartAnalytics.Size = new Size(1072, 684);
            chartAnalytics.TabIndex = 7;
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 759);
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
        private Button btnJobsPerLocation;
        private Button btnApplicationsStatus;
        private Button btnTopJobs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalytics;
    }
}