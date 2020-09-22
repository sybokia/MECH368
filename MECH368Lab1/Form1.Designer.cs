namespace MECH368Lab1
{
    partial class frmMainWindow
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
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtDrawingWindow = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtRecordedClicks = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(10, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 43);
            label1.TabIndex = 0;
            label1.Text = "X: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(10, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 43);
            label2.TabIndex = 1;
            label2.Text = "Y: ";
            // 
            // txtXPos
            // 
            this.txtXPos.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXPos.Location = new System.Drawing.Point(65, 10);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(264, 51);
            this.txtXPos.TabIndex = 2;
            // 
            // txtYPos
            // 
            this.txtYPos.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYPos.Location = new System.Drawing.Point(65, 70);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(264, 51);
            this.txtYPos.TabIndex = 3;
            // 
            // txtDrawingWindow
            // 
            this.txtDrawingWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrawingWindow.Location = new System.Drawing.Point(348, 10);
            this.txtDrawingWindow.Multiline = true;
            this.txtDrawingWindow.Name = "txtDrawingWindow";
            this.txtDrawingWindow.ReadOnly = true;
            this.txtDrawingWindow.Size = new System.Drawing.Size(815, 798);
            this.txtDrawingWindow.TabIndex = 5;
            this.txtDrawingWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDrawingWindow_MouseClick);
            this.txtDrawingWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDrawingWindow_MouseMove);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(10, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(319, 43);
            label3.TabIndex = 6;
            label3.Text = "Recorded Clicks";
            // 
            // txtRecordedClicks
            // 
            this.txtRecordedClicks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRecordedClicks.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordedClicks.Location = new System.Drawing.Point(18, 191);
            this.txtRecordedClicks.Multiline = true;
            this.txtRecordedClicks.Name = "txtRecordedClicks";
            this.txtRecordedClicks.Size = new System.Drawing.Size(311, 617);
            this.txtRecordedClicks.TabIndex = 7;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 836);
            this.Controls.Add(this.txtRecordedClicks);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtDrawingWindow);
            this.Controls.Add(this.txtYPos);
            this.Controls.Add(this.txtXPos);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.MinimumSize = new System.Drawing.Size(711, 392);
            this.Name = "frmMainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtDrawingWindow;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtRecordedClicks;
    }
}

