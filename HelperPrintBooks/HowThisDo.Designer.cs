namespace HelperPrintBooks
{
    partial class HowThisDo
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
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonResult.Location = new System.Drawing.Point(481, 231);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(81, 30);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "Закрыть";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncorrect.Location = new System.Drawing.Point(26, 16);
            this.labelIncorrect.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(31, 18);
            this.labelIncorrect.TabIndex = 7;
            this.labelIncorrect.Text = "text";
            this.labelIncorrect.Click += new System.EventHandler(this.labelIncorrect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.MaximumSize = new System.Drawing.Size(600, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HowThisDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.buttonResult);
            this.Name = "HowThisDo";
            this.Text = "HowThisDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label label2;
    }
}