namespace MVP_PV221
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrice = new System.Windows.Forms.TextBox();
            numCount = new System.Windows.Forms.NumericUpDown();
            btnCoast = new System.Windows.Forms.Button();
            labCoast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(25, 50);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(159, 27);
            txtPrice.TabIndex = 0;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // numCount
            // 
            numCount.Location = new System.Drawing.Point(222, 50);
            numCount.Name = "numCount";
            numCount.Size = new System.Drawing.Size(135, 27);
            numCount.TabIndex = 1;
            numCount.ValueChanged += numCount_ValueChanged;
            // 
            // btnCoast
            // 
            btnCoast.Location = new System.Drawing.Point(373, 50);
            btnCoast.Name = "btnCoast";
            btnCoast.Size = new System.Drawing.Size(131, 29);
            btnCoast.TabIndex = 2;
            btnCoast.Text = "btnCoast";
            btnCoast.UseVisualStyleBackColor = true;
            btnCoast.Click += btnCoast_Click;
            // 
            // labCoast
            // 
            labCoast.AutoSize = true;
            labCoast.Location = new System.Drawing.Point(454, 122);
            labCoast.Name = "labCoast";
            labCoast.Size = new System.Drawing.Size(50, 20);
            labCoast.TabIndex = 3;
            labCoast.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(583, 319);
            Controls.Add(labCoast);
            Controls.Add(btnCoast);
            Controls.Add(numCount);
            Controls.Add(txtPrice);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnCoast;
        private System.Windows.Forms.Label labCoast;
    }
}
