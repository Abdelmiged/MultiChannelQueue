
namespace MultiQueueSimulation
{
    partial class PerformanceMeasuresForm
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
            this.averageWaitingTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.systemMeasuresLabel = new System.Windows.Forms.Label();
            this.probabilityCustomerInQueueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maximumQueueLengthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.utilizationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.averageServiceTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serverMeasuresLabel = new System.Windows.Forms.Label();
            this.idleProbabilityLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nextServerButton = new System.Windows.Forms.Button();
            this.previousServerButton = new System.Windows.Forms.Button();
            this.serverIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // averageWaitingTimeLabel
            // 
            this.averageWaitingTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageWaitingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageWaitingTimeLabel.Location = new System.Drawing.Point(240, 66);
            this.averageWaitingTimeLabel.Name = "averageWaitingTimeLabel";
            this.averageWaitingTimeLabel.Size = new System.Drawing.Size(85, 30);
            this.averageWaitingTimeLabel.TabIndex = 4;
            this.averageWaitingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Average Waiting Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // systemMeasuresLabel
            // 
            this.systemMeasuresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemMeasuresLabel.Location = new System.Drawing.Point(74, 20);
            this.systemMeasuresLabel.Name = "systemMeasuresLabel";
            this.systemMeasuresLabel.Size = new System.Drawing.Size(154, 23);
            this.systemMeasuresLabel.TabIndex = 5;
            this.systemMeasuresLabel.Text = "System Measures";
            this.systemMeasuresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // probabilityCustomerInQueueLabel
            // 
            this.probabilityCustomerInQueueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.probabilityCustomerInQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probabilityCustomerInQueueLabel.Location = new System.Drawing.Point(240, 127);
            this.probabilityCustomerInQueueLabel.Name = "probabilityCustomerInQueueLabel";
            this.probabilityCustomerInQueueLabel.Size = new System.Drawing.Size(85, 30);
            this.probabilityCustomerInQueueLabel.TabIndex = 7;
            this.probabilityCustomerInQueueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Probability of Customer in Queue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maximumQueueLengthLabel
            // 
            this.maximumQueueLengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximumQueueLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumQueueLengthLabel.Location = new System.Drawing.Point(240, 186);
            this.maximumQueueLengthLabel.Name = "maximumQueueLengthLabel";
            this.maximumQueueLengthLabel.Size = new System.Drawing.Size(85, 30);
            this.maximumQueueLengthLabel.TabIndex = 9;
            this.maximumQueueLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum Queue Length";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utilizationLabel
            // 
            this.utilizationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.utilizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizationLabel.Location = new System.Drawing.Point(611, 186);
            this.utilizationLabel.Name = "utilizationLabel";
            this.utilizationLabel.Size = new System.Drawing.Size(141, 30);
            this.utilizationLabel.TabIndex = 16;
            this.utilizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Utilization";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // averageServiceTimeLabel
            // 
            this.averageServiceTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageServiceTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageServiceTimeLabel.Location = new System.Drawing.Point(611, 127);
            this.averageServiceTimeLabel.Name = "averageServiceTimeLabel";
            this.averageServiceTimeLabel.Size = new System.Drawing.Size(141, 30);
            this.averageServiceTimeLabel.TabIndex = 14;
            this.averageServiceTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Average Service Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverMeasuresLabel
            // 
            this.serverMeasuresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverMeasuresLabel.Location = new System.Drawing.Point(501, 20);
            this.serverMeasuresLabel.Name = "serverMeasuresLabel";
            this.serverMeasuresLabel.Size = new System.Drawing.Size(154, 23);
            this.serverMeasuresLabel.TabIndex = 12;
            this.serverMeasuresLabel.Text = "Server Measures";
            this.serverMeasuresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idleProbabilityLabel
            // 
            this.idleProbabilityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idleProbabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idleProbabilityLabel.Location = new System.Drawing.Point(611, 66);
            this.idleProbabilityLabel.Name = "idleProbabilityLabel";
            this.idleProbabilityLabel.Size = new System.Drawing.Size(141, 30);
            this.idleProbabilityLabel.TabIndex = 11;
            this.idleProbabilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 30);
            this.label10.TabIndex = 10;
            this.label10.Text = "Idle Probability";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextServerButton
            // 
            this.nextServerButton.Location = new System.Drawing.Point(661, 256);
            this.nextServerButton.Name = "nextServerButton";
            this.nextServerButton.Size = new System.Drawing.Size(91, 40);
            this.nextServerButton.TabIndex = 18;
            this.nextServerButton.Text = "Next";
            this.nextServerButton.UseVisualStyleBackColor = true;
            this.nextServerButton.Click += new System.EventHandler(this.nextServerButton_Click);
            // 
            // previousServerButton
            // 
            this.previousServerButton.Location = new System.Drawing.Point(442, 256);
            this.previousServerButton.Name = "previousServerButton";
            this.previousServerButton.Size = new System.Drawing.Size(91, 40);
            this.previousServerButton.TabIndex = 17;
            this.previousServerButton.Text = "Previous";
            this.previousServerButton.UseVisualStyleBackColor = true;
            this.previousServerButton.Click += new System.EventHandler(this.previousServerButton_Click);
            // 
            // serverIdLabel
            // 
            this.serverIdLabel.Location = new System.Drawing.Point(539, 256);
            this.serverIdLabel.Name = "serverIdLabel";
            this.serverIdLabel.Size = new System.Drawing.Size(116, 40);
            this.serverIdLabel.TabIndex = 19;
            this.serverIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformanceMeasuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 350);
            this.Controls.Add(this.serverIdLabel);
            this.Controls.Add(this.nextServerButton);
            this.Controls.Add(this.previousServerButton);
            this.Controls.Add(this.utilizationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.averageServiceTimeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serverMeasuresLabel);
            this.Controls.Add(this.idleProbabilityLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maximumQueueLengthLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.probabilityCustomerInQueueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.systemMeasuresLabel);
            this.Controls.Add(this.averageWaitingTimeLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(795, 397);
            this.MinimumSize = new System.Drawing.Size(795, 397);
            this.Name = "PerformanceMeasuresForm";
            this.Text = "PerformanceMeasures";
            this.Load += new System.EventHandler(this.PerformanceMeasures_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label averageWaitingTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label systemMeasuresLabel;
        private System.Windows.Forms.Label probabilityCustomerInQueueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maximumQueueLengthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label utilizationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label averageServiceTimeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label serverMeasuresLabel;
        private System.Windows.Forms.Label idleProbabilityLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button nextServerButton;
        private System.Windows.Forms.Button previousServerButton;
        private System.Windows.Forms.Label serverIdLabel;
    }
}