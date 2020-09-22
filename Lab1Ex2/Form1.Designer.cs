namespace Lab1Ex2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnAverageFirstN = new System.Windows.Forms.Button();
            this.txtEnqueue = new System.Windows.Forms.TextBox();
            this.txtDequeue = new System.Windows.Forms.TextBox();
            this.txtNQueue = new System.Windows.Forms.TextBox();
            this.txtNDataPoints = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtQueueContents = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.Location = new System.Drawing.Point(22, 22);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(225, 45);
            this.btnEnqueue.TabIndex = 0;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.Location = new System.Drawing.Point(22, 87);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(225, 44);
            this.btnDequeue.TabIndex = 1;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnAverageFirstN
            // 
            this.btnAverageFirstN.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageFirstN.Location = new System.Drawing.Point(22, 212);
            this.btnAverageFirstN.Name = "btnAverageFirstN";
            this.btnAverageFirstN.Size = new System.Drawing.Size(719, 43);
            this.btnAverageFirstN.TabIndex = 2;
            this.btnAverageFirstN.Text = "Dequeue and average first N data points";
            this.btnAverageFirstN.UseVisualStyleBackColor = true;
            this.btnAverageFirstN.Click += new System.EventHandler(this.btnAverageFirstN_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(16, 154);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 32);
            label1.TabIndex = 3;
            label1.Text = "Items in Queue";
            // 
            // txtEnqueue
            // 
            this.txtEnqueue.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnqueue.Location = new System.Drawing.Point(271, 23);
            this.txtEnqueue.Name = "txtEnqueue";
            this.txtEnqueue.Size = new System.Drawing.Size(470, 39);
            this.txtEnqueue.TabIndex = 4;
            // 
            // txtDequeue
            // 
            this.txtDequeue.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDequeue.Location = new System.Drawing.Point(271, 87);
            this.txtDequeue.Name = "txtDequeue";
            this.txtDequeue.Size = new System.Drawing.Size(470, 39);
            this.txtDequeue.TabIndex = 5;
            // 
            // txtNQueue
            // 
            this.txtNQueue.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNQueue.Location = new System.Drawing.Point(271, 146);
            this.txtNQueue.Name = "txtNQueue";
            this.txtNQueue.Size = new System.Drawing.Size(470, 39);
            this.txtNQueue.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(16, 281);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 32);
            label2.TabIndex = 7;
            label2.Text = "N: ";
            // 
            // txtNDataPoints
            // 
            this.txtNDataPoints.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDataPoints.Location = new System.Drawing.Point(63, 278);
            this.txtNDataPoints.Name = "txtNDataPoints";
            this.txtNDataPoints.Size = new System.Drawing.Size(184, 39);
            this.txtNDataPoints.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(265, 281);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(131, 32);
            label3.TabIndex = 9;
            label3.Text = "Average: ";
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(390, 278);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(351, 39);
            this.txtAverage.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(16, 345);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(230, 32);
            label4.TabIndex = 11;
            label4.Text = "Queue Contents: ";
            // 
            // txtQueueContents
            // 
            this.txtQueueContents.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueueContents.Location = new System.Drawing.Point(22, 393);
            this.txtQueueContents.Multiline = true;
            this.txtQueueContents.Name = "txtQueueContents";
            this.txtQueueContents.Size = new System.Drawing.Size(719, 460);
            this.txtQueueContents.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 865);
            this.Controls.Add(this.txtQueueContents);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtNDataPoints);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtNQueue);
            this.Controls.Add(this.txtDequeue);
            this.Controls.Add(this.txtEnqueue);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnAverageFirstN);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnEnqueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnAverageFirstN;
        private System.Windows.Forms.TextBox txtEnqueue;
        private System.Windows.Forms.TextBox txtDequeue;
        private System.Windows.Forms.TextBox txtNQueue;
        private System.Windows.Forms.TextBox txtNDataPoints;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtQueueContents;
        private System.Windows.Forms.Timer timer1;
    }
}

