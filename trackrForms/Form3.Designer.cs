﻿namespace trackrForms
{
    partial class CreateMetrics
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.habitColumnLabel = new System.Windows.Forms.Label();
            this.CompletionRateColumnLabel = new System.Windows.Forms.Label();
            this.firstDateCompletedColumnLabel = new System.Windows.Forms.Label();
            this.habitHistoryTableTableAdapter1 = new trackrForms.trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter();
            this.habitTableTableAdapter1 = new trackrForms.trackrDBDataSetTableAdapters.habitTableTableAdapter();
            this.dateLabel = new System.Windows.Forms.Label();
            this.closeMetricsButton = new System.Windows.Forms.Button();
            this.viewMetricsContainer = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.viewMetricsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoScroll = true;
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayout.Location = new System.Drawing.Point(85, 124);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 7;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayout.Size = new System.Drawing.Size(667, 338);
            this.tableLayout.TabIndex = 6;
            // 
            // habitColumnLabel
            // 
            this.habitColumnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.habitColumnLabel.AutoSize = true;
            this.habitColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitColumnLabel.Location = new System.Drawing.Point(139, 85);
            this.habitColumnLabel.Name = "habitColumnLabel";
            this.habitColumnLabel.Size = new System.Drawing.Size(46, 17);
            this.habitColumnLabel.TabIndex = 1;
            this.habitColumnLabel.Text = "Habit";
            this.habitColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletionRateColumnLabel
            // 
            this.CompletionRateColumnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompletionRateColumnLabel.AutoSize = true;
            this.CompletionRateColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletionRateColumnLabel.Location = new System.Drawing.Point(260, 85);
            this.CompletionRateColumnLabel.Name = "CompletionRateColumnLabel";
            this.CompletionRateColumnLabel.Size = new System.Drawing.Size(145, 17);
            this.CompletionRateColumnLabel.TabIndex = 10;
            this.CompletionRateColumnLabel.Text = "% Completion Rate";
            this.CompletionRateColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstDateCompletedColumnLabel
            // 
            this.firstDateCompletedColumnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstDateCompletedColumnLabel.AutoSize = true;
            this.firstDateCompletedColumnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDateCompletedColumnLabel.Location = new System.Drawing.Point(440, 85);
            this.firstDateCompletedColumnLabel.Name = "firstDateCompletedColumnLabel";
            this.firstDateCompletedColumnLabel.Size = new System.Drawing.Size(118, 17);
            this.firstDateCompletedColumnLabel.TabIndex = 11;
            this.firstDateCompletedColumnLabel.Text = "Longest Streak";
            this.firstDateCompletedColumnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstDateCompletedColumnLabel.Click += new System.EventHandler(this.firstDateCompletedColumnLabel_Click);
            // 
            // habitHistoryTableTableAdapter1
            // 
            this.habitHistoryTableTableAdapter1.ClearBeforeFill = true;
            // 
            // habitTableTableAdapter1
            // 
            this.habitTableTableAdapter1.ClearBeforeFill = true;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(256, 20);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(313, 39);
            this.dateLabel.TabIndex = 12;
            this.dateLabel.Text = "Your Habit Metrics";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeMetricsButton
            // 
            this.closeMetricsButton.Location = new System.Drawing.Point(339, 485);
            this.closeMetricsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeMetricsButton.Name = "closeMetricsButton";
            this.closeMetricsButton.Size = new System.Drawing.Size(160, 28);
            this.closeMetricsButton.TabIndex = 13;
            this.closeMetricsButton.Text = "Close Metrics";
            this.closeMetricsButton.UseVisualStyleBackColor = true;
            this.closeMetricsButton.Click += new System.EventHandler(this.closeMetricsButton_Click);
            // 
            // viewMetricsContainer
            // 
            this.viewMetricsContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewMetricsContainer.Controls.Add(this.dateLabel);
            this.viewMetricsContainer.Controls.Add(this.closeMetricsButton);
            this.viewMetricsContainer.Controls.Add(this.tableLayout);
            this.viewMetricsContainer.Controls.Add(this.habitColumnLabel);
            this.viewMetricsContainer.Controls.Add(this.firstDateCompletedColumnLabel);
            this.viewMetricsContainer.Controls.Add(this.CompletionRateColumnLabel);
            this.viewMetricsContainer.Location = new System.Drawing.Point(116, 28);
            this.viewMetricsContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewMetricsContainer.Name = "viewMetricsContainer";
            this.viewMetricsContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewMetricsContainer.Size = new System.Drawing.Size(820, 528);
            this.viewMetricsContainer.TabIndex = 14;
            this.viewMetricsContainer.TabStop = false;
            // 
            // CreateMetrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.viewMetricsContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateMetrics";
            this.Text = "trackr Metrics";
            this.viewMetricsContainer.ResumeLayout(false);
            this.viewMetricsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label habitColumnLabel;
        private System.Windows.Forms.Label CompletionRateColumnLabel;
        private System.Windows.Forms.Label firstDateCompletedColumnLabel;
        private trackrDBDataSetTableAdapters.habitHistoryTableTableAdapter habitHistoryTableTableAdapter1;
        private trackrDBDataSetTableAdapters.habitTableTableAdapter habitTableTableAdapter1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button closeMetricsButton;
        private System.Windows.Forms.GroupBox viewMetricsContainer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}