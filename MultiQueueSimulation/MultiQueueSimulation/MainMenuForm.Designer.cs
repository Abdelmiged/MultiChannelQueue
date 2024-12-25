namespace MultiQueueSimulation
{
    partial class MainMenuForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfServersLabel = new System.Windows.Forms.Label();
            this.stoppingNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stoppingCriteriaLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectionMethodLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.interarrivalDistributionButton = new System.Windows.Forms.Button();
            this.serversDistributionButton = new System.Windows.Forms.Button();
            this.beginSimulationButton = new System.Windows.Forms.Button();
            this.simulationTableButton = new System.Windows.Forms.Button();
            this.performanceMeasuresButton = new System.Windows.Forms.Button();
            this.systemNotificationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(394, 354);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(91, 40);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Servers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberOfServersLabel
            // 
            this.numberOfServersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfServersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfServersLabel.Location = new System.Drawing.Point(161, 37);
            this.numberOfServersLabel.Name = "numberOfServersLabel";
            this.numberOfServersLabel.Size = new System.Drawing.Size(141, 30);
            this.numberOfServersLabel.TabIndex = 2;
            this.numberOfServersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stoppingNumberLabel
            // 
            this.stoppingNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stoppingNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoppingNumberLabel.Location = new System.Drawing.Point(161, 104);
            this.stoppingNumberLabel.Name = "stoppingNumberLabel";
            this.stoppingNumberLabel.Size = new System.Drawing.Size(141, 30);
            this.stoppingNumberLabel.TabIndex = 4;
            this.stoppingNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stopping Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stoppingCriteriaLabel
            // 
            this.stoppingCriteriaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stoppingCriteriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoppingCriteriaLabel.Location = new System.Drawing.Point(161, 171);
            this.stoppingCriteriaLabel.Name = "stoppingCriteriaLabel";
            this.stoppingCriteriaLabel.Size = new System.Drawing.Size(141, 30);
            this.stoppingCriteriaLabel.TabIndex = 6;
            this.stoppingCriteriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stopping Criteria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectionMethodLabel
            // 
            this.selectionMethodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionMethodLabel.Location = new System.Drawing.Point(161, 239);
            this.selectionMethodLabel.Name = "selectionMethodLabel";
            this.selectionMethodLabel.Size = new System.Drawing.Size(141, 30);
            this.selectionMethodLabel.TabIndex = 8;
            this.selectionMethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selection Method";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // interarrivalDistributionButton
            // 
            this.interarrivalDistributionButton.Location = new System.Drawing.Point(394, 37);
            this.interarrivalDistributionButton.Name = "interarrivalDistributionButton";
            this.interarrivalDistributionButton.Size = new System.Drawing.Size(204, 44);
            this.interarrivalDistributionButton.TabIndex = 9;
            this.interarrivalDistributionButton.Text = "Interarrival Distribution Table";
            this.interarrivalDistributionButton.UseVisualStyleBackColor = true;
            this.interarrivalDistributionButton.Click += new System.EventHandler(this.interarrivalDistributionButton_Click);
            // 
            // serversDistributionButton
            // 
            this.serversDistributionButton.Location = new System.Drawing.Point(394, 104);
            this.serversDistributionButton.Name = "serversDistributionButton";
            this.serversDistributionButton.Size = new System.Drawing.Size(204, 44);
            this.serversDistributionButton.TabIndex = 10;
            this.serversDistributionButton.Text = "Servers Distribution Tables";
            this.serversDistributionButton.UseVisualStyleBackColor = true;
            this.serversDistributionButton.Click += new System.EventHandler(this.serversDistributionButton_Click);
            // 
            // beginSimulationButton
            // 
            this.beginSimulationButton.Location = new System.Drawing.Point(507, 354);
            this.beginSimulationButton.Name = "beginSimulationButton";
            this.beginSimulationButton.Size = new System.Drawing.Size(91, 40);
            this.beginSimulationButton.TabIndex = 11;
            this.beginSimulationButton.Text = "Begin";
            this.beginSimulationButton.UseVisualStyleBackColor = true;
            this.beginSimulationButton.Click += new System.EventHandler(this.beginSimulationButton_Click);
            // 
            // simulationTableButton
            // 
            this.simulationTableButton.Location = new System.Drawing.Point(394, 171);
            this.simulationTableButton.Name = "simulationTableButton";
            this.simulationTableButton.Size = new System.Drawing.Size(204, 44);
            this.simulationTableButton.TabIndex = 12;
            this.simulationTableButton.Text = "Simulation Table";
            this.simulationTableButton.UseVisualStyleBackColor = true;
            this.simulationTableButton.Click += new System.EventHandler(this.simulationTableButton_Click);
            // 
            // performanceMeasuresButton
            // 
            this.performanceMeasuresButton.Location = new System.Drawing.Point(394, 239);
            this.performanceMeasuresButton.Name = "performanceMeasuresButton";
            this.performanceMeasuresButton.Size = new System.Drawing.Size(204, 44);
            this.performanceMeasuresButton.TabIndex = 13;
            this.performanceMeasuresButton.Text = "Performance Measures";
            this.performanceMeasuresButton.UseVisualStyleBackColor = true;
            this.performanceMeasuresButton.Click += new System.EventHandler(this.performanceMeasuresButton_Click);
            // 
            // systemNotificationLabel
            // 
            this.systemNotificationLabel.ForeColor = System.Drawing.Color.Red;
            this.systemNotificationLabel.Location = new System.Drawing.Point(12, 345);
            this.systemNotificationLabel.Name = "systemNotificationLabel";
            this.systemNotificationLabel.Size = new System.Drawing.Size(217, 46);
            this.systemNotificationLabel.TabIndex = 14;
            this.systemNotificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 400);
            this.Controls.Add(this.systemNotificationLabel);
            this.Controls.Add(this.performanceMeasuresButton);
            this.Controls.Add(this.simulationTableButton);
            this.Controls.Add(this.beginSimulationButton);
            this.Controls.Add(this.serversDistributionButton);
            this.Controls.Add(this.interarrivalDistributionButton);
            this.Controls.Add(this.selectionMethodLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stoppingCriteriaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stoppingNumberLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberOfServersLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.MaximumSize = new System.Drawing.Size(628, 447);
            this.MinimumSize = new System.Drawing.Size(628, 447);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfServersLabel;
        private System.Windows.Forms.Label stoppingNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stoppingCriteriaLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectionMethodLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button interarrivalDistributionButton;
        private System.Windows.Forms.Button serversDistributionButton;
        private System.Windows.Forms.Button beginSimulationButton;
        private System.Windows.Forms.Button simulationTableButton;
        private System.Windows.Forms.Button performanceMeasuresButton;
        private System.Windows.Forms.Label systemNotificationLabel;
    }
}

