namespace KMeansClustering
{
    partial class Form1
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
            this.btnCluster = new System.Windows.Forms.Button();
            this.lstRawData = new System.Windows.Forms.ListBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtNumberOfClusters = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNormalize = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.txtNormalized = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCluster
            // 
            this.btnCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCluster.Location = new System.Drawing.Point(93, 270);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Size = new System.Drawing.Size(60, 23);
            this.btnCluster.TabIndex = 0;
            this.btnCluster.Text = "Cluster";
            this.btnCluster.UseVisualStyleBackColor = true;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // lstRawData
            // 
            this.lstRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstRawData.FormattingEnabled = true;
            this.lstRawData.ItemHeight = 16;
            this.lstRawData.Items.AddRange(new object[] {
            "{220.0,64.0}",
            "{170.0,72.0}",
            "{130.0,51.0}",
            "{110.0,65.0}",
            "{120.0,77.0}",
            "{240.0,68.0}",
            "{250.0,65.0}",
            "{260.0,71.0}",
            "{140.0,63.0}",
            "{230.0,66.0}",
            "{120.0,78.0}",
            "{160.0,79.0}",
            "{170.0,70.0}",
            "{240.0,75.0}",
            "{130.0,63.0}",
            "{140.0,52.0}",
            "{250.0,63.0}",
            "{160.0,55.0}",
            "{280.0,66.0}",
            "{150.0,67.0}"});
            this.lstRawData.Location = new System.Drawing.Point(12, 65);
            this.lstRawData.Name = "lstRawData";
            this.lstRawData.Size = new System.Drawing.Size(141, 164);
            this.lstRawData.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtWeight.Location = new System.Drawing.Point(61, 39);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(92, 22);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            // 
            // txtNumberOfClusters
            // 
            this.txtNumberOfClusters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumberOfClusters.Location = new System.Drawing.Point(102, 244);
            this.txtNumberOfClusters.Name = "txtNumberOfClusters";
            this.txtNumberOfClusters.Size = new System.Drawing.Size(51, 22);
            this.txtNumberOfClusters.TabIndex = 3;
            this.txtNumberOfClusters.Text = "3";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHeight.Location = new System.Drawing.Point(61, 13);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(92, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(13, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "# of Clusters:";
            // 
            // txtIterations
            // 
            this.txtIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIterations.Location = new System.Drawing.Point(312, 65);
            this.txtIterations.Multiline = true;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIterations.Size = new System.Drawing.Size(280, 225);
            this.txtIterations.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOutput.Location = new System.Drawing.Point(598, 65);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(280, 225);
            this.txtOutput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(312, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iterations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(595, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output:";
            // 
            // btnNormalize
            // 
            this.btnNormalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNormalize.Location = new System.Drawing.Point(6, 270);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(81, 23);
            this.btnNormalize.TabIndex = 0;
            this.btnNormalize.Text = "Normalize";
            this.btnNormalize.UseVisualStyleBackColor = true;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblN.Location = new System.Drawing.Point(159, 46);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(112, 16);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "Normalized Data:";
            // 
            // txtNormalized
            // 
            this.txtNormalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNormalized.Location = new System.Drawing.Point(159, 65);
            this.txtNormalized.Multiline = true;
            this.txtNormalized.Name = "txtNormalized";
            this.txtNormalized.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNormalized.Size = new System.Drawing.Size(147, 225);
            this.txtNormalized.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 302);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtNormalized);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtNumberOfClusters);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lstRawData);
            this.Controls.Add(this.btnNormalize);
            this.Controls.Add(this.btnCluster);
            this.Name = "Form1";
            this.Text = "K Means Clustering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCluster;
        private System.Windows.Forms.ListBox lstRawData;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtNumberOfClusters;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNormalize;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtNormalized;
    }
}

