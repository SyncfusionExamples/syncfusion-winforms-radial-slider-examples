namespace Text_Formatting
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
            this.radialSlider1 = new Syncfusion.Windows.Forms.Tools.RadialSlider();
            this.SuspendLayout();
            // 
            // radialSlider1
            // 
            this.radialSlider1.BeforeTouchSize = new System.Drawing.Size(282, 282);
            this.radialSlider1.EndAngle = 360D;
            this.radialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(151)))), ((int)(((byte)(55)))));
            this.radialSlider1.Location = new System.Drawing.Point(87, 48);
            this.radialSlider1.Name = "radialSlider1";
            this.radialSlider1.RadialDirection = Syncfusion.Windows.Forms.Tools.RadialDirection.Clockwise;
            this.radialSlider1.Size = new System.Drawing.Size(282, 282);
            this.radialSlider1.StartAngle = 0D;
            this.radialSlider1.TabIndex = 0;
            this.radialSlider1.Text = "radialSlider1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 384);
            this.Controls.Add(this.radialSlider1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadialSlider-TextFormatting";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RadialSlider radialSlider1;
    }
}

