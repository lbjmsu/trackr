﻿
namespace trackrForms
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
            this.components = new System.ComponentModel.Container();
            this.newHabitButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.todaysProgressLabel = new System.Windows.Forms.Label();
            this.currentStreakLabel = new System.Windows.Forms.Label();
            this.goalColumnLabel = new System.Windows.Forms.Label();
            this.habitColumnLabel = new System.Windows.Forms.Label();
            this.displayMetricsButton = new System.Windows.Forms.Button();
            this.editHabitsButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.habitHistoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trackrDBDataSet = new trackrForms.trackrDBDataSet();
            this.trackrDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitHistoryTableTableAdapter = new trackrForms.trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter();
            this.habitTableTableAdapter = new trackrForms.trackrDBDataSetTableAdapters.habitTableTableAdapter();
            this.dailyDashboardContainer = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitHistoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSetBindingSource)).BeginInit();
            this.dailyDashboardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // newHabitButton
            // 
            this.newHabitButton.Location = new System.Drawing.Point(76, 437);
            this.newHabitButton.Margin = new System.Windows.Forms.Padding(2);
            this.newHabitButton.Name = "newHabitButton";
            this.newHabitButton.Size = new System.Drawing.Size(88, 23);
            this.newHabitButton.TabIndex = 0;
            this.newHabitButton.Text = "New Habit";
            this.newHabitButton.UseVisualStyleBackColor = true;
            this.newHabitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.syncToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.syncToolStripMenuItem.Text = "Sync";
            this.syncToolStripMenuItem.Click += new System.EventHandler(this.syncToolStripMenuItem_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.AutoScroll = true;
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Location = new System.Drawing.Point(47, 114);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 7;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.Size = new System.Drawing.Size(500, 304);
            this.tableLayout.TabIndex = 5;
            this.tableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayout_Paint);
            // 
            // todaysProgressLabel
            // 
            this.todaysProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todaysProgressLabel.AutoSize = true;
            this.todaysProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysProgressLabel.Location = new System.Drawing.Point(303, 88);
            this.todaysProgressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todaysProgressLabel.Name = "todaysProgressLabel";
            this.todaysProgressLabel.Size = new System.Drawing.Size(104, 13);
            this.todaysProgressLabel.TabIndex = 7;
            this.todaysProgressLabel.Text = "Today\'s Progress";
            this.todaysProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentStreakLabel
            // 
            this.currentStreakLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentStreakLabel.AutoSize = true;
            this.currentStreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStreakLabel.Location = new System.Drawing.Point(440, 88);
            this.currentStreakLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentStreakLabel.Name = "currentStreakLabel";
            this.currentStreakLabel.Size = new System.Drawing.Size(89, 13);
            this.currentStreakLabel.TabIndex = 8;
            this.currentStreakLabel.Text = "Current Streak";
            this.currentStreakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goalColumnLabel
            // 
            this.goalColumnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalColumnLabel.AutoSize = true;
            this.goalColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalColumnLabel.Location = new System.Drawing.Point(220, 88);
            this.goalColumnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goalColumnLabel.Name = "goalColumnLabel";
            this.goalColumnLabel.Size = new System.Drawing.Size(33, 13);
            this.goalColumnLabel.TabIndex = 9;
            this.goalColumnLabel.Text = "Goal";
            this.goalColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habitColumnLabel
            // 
            this.habitColumnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.habitColumnLabel.AutoSize = true;
            this.habitColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitColumnLabel.Location = new System.Drawing.Point(91, 88);
            this.habitColumnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.habitColumnLabel.Name = "habitColumnLabel";
            this.habitColumnLabel.Size = new System.Drawing.Size(37, 13);
            this.habitColumnLabel.TabIndex = 0;
            this.habitColumnLabel.Text = "Habit";
            this.habitColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayMetricsButton
            // 
            this.displayMetricsButton.Location = new System.Drawing.Point(421, 437);
            this.displayMetricsButton.Margin = new System.Windows.Forms.Padding(2);
            this.displayMetricsButton.Name = "displayMetricsButton";
            this.displayMetricsButton.Size = new System.Drawing.Size(94, 24);
            this.displayMetricsButton.TabIndex = 6;
            this.displayMetricsButton.Text = "Display Metrics";
            this.displayMetricsButton.UseVisualStyleBackColor = true;
            this.displayMetricsButton.Click += new System.EventHandler(this.displayMetricsButton_Click);
            // 
            // editHabitsButton
            // 
            this.editHabitsButton.Location = new System.Drawing.Point(244, 437);
            this.editHabitsButton.Margin = new System.Windows.Forms.Padding(2);
            this.editHabitsButton.Name = "editHabitsButton";
            this.editHabitsButton.Size = new System.Drawing.Size(91, 24);
            this.editHabitsButton.TabIndex = 7;
            this.editHabitsButton.Text = "Edit Habits";
            this.editHabitsButton.UseVisualStyleBackColor = true;
            this.editHabitsButton.Click += new System.EventHandler(this.EditHabitsButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(128, 16);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(336, 31);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "<DateTime Placeholder>";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateLabel.Visible = false;
            // 
            // habitHistoryTableBindingSource
            // 
            this.habitHistoryTableBindingSource.DataMember = "habitHistoryTable";
            this.habitHistoryTableBindingSource.DataSource = this.trackrDBDataSet;
            // 
            // trackrDBDataSet
            // 
            this.trackrDBDataSet.DataSetName = "trackrDBDataSet";
            this.trackrDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trackrDBDataSetBindingSource
            // 
            this.trackrDBDataSetBindingSource.DataSource = this.trackrDBDataSet;
            this.trackrDBDataSetBindingSource.Position = 0;
            // 
            // habitHistoryTableTableAdapter
            // 
            this.habitHistoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // habitTableTableAdapter
            // 
            this.habitTableTableAdapter.ClearBeforeFill = true;
            // 
            // dailyDashboardContainer
            // 
            this.dailyDashboardContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dailyDashboardContainer.Controls.Add(this.dateLabel);
            this.dailyDashboardContainer.Controls.Add(this.newHabitButton);
            this.dailyDashboardContainer.Controls.Add(this.tableLayout);
            this.dailyDashboardContainer.Controls.Add(this.currentStreakLabel);
            this.dailyDashboardContainer.Controls.Add(this.habitColumnLabel);
            this.dailyDashboardContainer.Controls.Add(this.todaysProgressLabel);
            this.dailyDashboardContainer.Controls.Add(this.editHabitsButton);
            this.dailyDashboardContainer.Controls.Add(this.goalColumnLabel);
            this.dailyDashboardContainer.Controls.Add(this.displayMetricsButton);
            this.dailyDashboardContainer.Location = new System.Drawing.Point(126, 27);
            this.dailyDashboardContainer.Name = "dailyDashboardContainer";
            this.dailyDashboardContainer.Size = new System.Drawing.Size(590, 500);
            this.dailyDashboardContainer.TabIndex = 11;
            this.dailyDashboardContainer.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dailyDashboardContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "trackr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitHistoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackrDBDataSetBindingSource)).EndInit();
            this.dailyDashboardContainer.ResumeLayout(false);
            this.dailyDashboardContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newHabitButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label habitColumnLabel;
        private System.Windows.Forms.Label todaysProgressLabel;
        private System.Windows.Forms.Label currentStreakLabel;
        private System.Windows.Forms.Label goalColumnLabel;
        private System.Windows.Forms.Button displayMetricsButton;
        private System.Windows.Forms.BindingSource trackrDBDataSetBindingSource;
        private trackrDBDataSet trackrDBDataSet;
        private System.Windows.Forms.BindingSource habitHistoryTableBindingSource;
        private trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter habitHistoryTableTableAdapter;
        private trackrDBDataSetTableAdapters.habitTableTableAdapter habitTableTableAdapter;
        private System.Windows.Forms.Button editHabitsButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox dailyDashboardContainer;
    }
}

