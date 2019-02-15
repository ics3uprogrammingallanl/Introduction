namespace PerAreaVolAllanL
{
    partial class frmPerAreaVol
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
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(467, 172);
            this.btnQuestion1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(212, 55);
            this.btnQuestion1.TabIndex = 0;
            this.btnQuestion1.Text = "Answer";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Location = new System.Drawing.Point(467, 324);
            this.btnQuestion2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(212, 55);
            this.btnQuestion2.TabIndex = 1;
            this.btnQuestion2.Text = "Answer";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Click += new System.EventHandler(this.btnQuestion2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(467, 484);
            this.btnQuestion3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(212, 55);
            this.btnQuestion3.TabIndex = 2;
            this.btnQuestion3.Text = "Answer";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.btnQuestion3_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(858, 184);
            this.lblAnswer1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(30, 31);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "?";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(858, 336);
            this.lblAnswer2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(30, 31);
            this.lblAnswer2.TabIndex = 4;
            this.lblAnswer2.Text = "?";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(858, 496);
            this.lblAnswer3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(30, 31);
            this.lblAnswer3.TabIndex = 5;
            this.lblAnswer3.Text = "?";
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.Location = new System.Drawing.Point(34, 138);
            this.lblQuestion1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(394, 119);
            this.lblQuestion1.TabIndex = 6;
            this.lblQuestion1.Text = "Calculate the perimeter of a rectangle with a length of 7 and a width of 12. ";
            this.lblQuestion1.Click += new System.EventHandler(this.lblQuestion1_Click);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.CausesValidation = false;
            this.lblQuestion2.Location = new System.Drawing.Point(34, 303);
            this.lblQuestion2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(354, 103);
            this.lblQuestion2.TabIndex = 7;
            this.lblQuestion2.Text = "Calculate the area of a circle with a radius of 9.";
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.Location = new System.Drawing.Point(34, 460);
            this.lblQuestion3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(388, 103);
            this.lblQuestion3.TabIndex = 8;
            this.lblQuestion3.Text = "Calculate the volume of a sphere with a radius of 3.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(459, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Math Questions";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 713);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnQuestion1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Allan L";
            this.Load += new System.EventHandler(this.frmPerAreaVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Label lblTitle;
    }
}

