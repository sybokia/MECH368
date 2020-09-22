namespace Lab1Ex7
{
    partial class Lab1Ex7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtAz = new System.Windows.Forms.TextBox();
            this.btnNewDataPoint = new System.Windows.Forms.Button();
            this.txtCurrentState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Az";
            // 
            // txtAx
            // 
            this.txtAx.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAx.Location = new System.Drawing.Point(56, 19);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(100, 35);
            this.txtAx.TabIndex = 3;
            // 
            // txtAy
            // 
            this.txtAy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAy.Location = new System.Drawing.Point(228, 19);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(100, 35);
            this.txtAy.TabIndex = 4;
            // 
            // txtAz
            // 
            this.txtAz.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAz.Location = new System.Drawing.Point(407, 19);
            this.txtAz.Name = "txtAz";
            this.txtAz.Size = new System.Drawing.Size(100, 35);
            this.txtAz.TabIndex = 5;
            // 
            // btnNewDataPoint
            // 
            this.btnNewDataPoint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDataPoint.Location = new System.Drawing.Point(12, 79);
            this.btnNewDataPoint.Name = "btnNewDataPoint";
            this.btnNewDataPoint.Size = new System.Drawing.Size(495, 46);
            this.btnNewDataPoint.TabIndex = 6;
            this.btnNewDataPoint.Text = "Process New Data Point";
            this.btnNewDataPoint.UseVisualStyleBackColor = true;
            this.btnNewDataPoint.Click += new System.EventHandler(this.btnNewDataPoint_Click);
            // 
            // txtCurrentState
            // 
            this.txtCurrentState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentState.Location = new System.Drawing.Point(334, 139);
            this.txtCurrentState.Name = "txtCurrentState";
            this.txtCurrentState.Size = new System.Drawing.Size(173, 35);
            this.txtCurrentState.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data History";
            // 
            // txtDataHistory
            // 
            this.txtDataHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHistory.Location = new System.Drawing.Point(17, 227);
            this.txtDataHistory.Multiline = true;
            this.txtDataHistory.Name = "txtDataHistory";
            this.txtDataHistory.Size = new System.Drawing.Size(490, 499);
            this.txtDataHistory.TabIndex = 10;
            // 
            // Lab1Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 738);
            this.Controls.Add(this.txtDataHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrentState);
            this.Controls.Add(this.btnNewDataPoint);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtAx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab1Ex7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtAz;
        private System.Windows.Forms.Button btnNewDataPoint;
        private System.Windows.Forms.TextBox txtCurrentState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataHistory;
    }
}

