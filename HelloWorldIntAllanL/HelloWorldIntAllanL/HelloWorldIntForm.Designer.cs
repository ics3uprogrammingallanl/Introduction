namespace HelloWorldIntAllanL
{
    partial class frmHelloWorldInt
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
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radArabic = new System.Windows.Forms.RadioButton();
            this.radGreek = new System.Windows.Forms.RadioButton();
            this.radSwedish = new System.Windows.Forms.RadioButton();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.grbHelloWorldInt = new System.Windows.Forms.GroupBox();
            this.grbHelloWorldInt.SuspendLayout();
            this.SuspendLayout();
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.ForeColor = System.Drawing.SystemColors.Control;
            this.radEnglish.Location = new System.Drawing.Point(6, 45);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(79, 24);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(97, 45);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(77, 24);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radArabic
            // 
            this.radArabic.AutoSize = true;
            this.radArabic.Location = new System.Drawing.Point(188, 45);
            this.radArabic.Name = "radArabic";
            this.radArabic.Size = new System.Drawing.Size(72, 24);
            this.radArabic.TabIndex = 2;
            this.radArabic.TabStop = true;
            this.radArabic.Text = "Arabic";
            this.radArabic.UseVisualStyleBackColor = true;
            this.radArabic.CheckedChanged += new System.EventHandler(this.radArabic_CheckedChanged);
            // 
            // radGreek
            // 
            this.radGreek.AutoSize = true;
            this.radGreek.Location = new System.Drawing.Point(279, 45);
            this.radGreek.Name = "radGreek";
            this.radGreek.Size = new System.Drawing.Size(71, 24);
            this.radGreek.TabIndex = 3;
            this.radGreek.TabStop = true;
            this.radGreek.Text = "Greek";
            this.radGreek.UseVisualStyleBackColor = true;
            this.radGreek.CheckedChanged += new System.EventHandler(this.radGreek_CheckedChanged);
            // 
            // radSwedish
            // 
            this.radSwedish.AutoSize = true;
            this.radSwedish.Location = new System.Drawing.Point(370, 45);
            this.radSwedish.Name = "radSwedish";
            this.radSwedish.Size = new System.Drawing.Size(87, 24);
            this.radSwedish.TabIndex = 4;
            this.radSwedish.TabStop = true;
            this.radSwedish.Text = "Swedish";
            this.radSwedish.UseVisualStyleBackColor = true;
            this.radSwedish.CheckedChanged += new System.EventHandler(this.radSwedish_CheckedChanged);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloWorld.Font = new System.Drawing.Font("Malgun Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelloWorld.Location = new System.Drawing.Point(574, 96);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(425, 86);
            this.lblHelloWorld.TabIndex = 5;
            this.lblHelloWorld.Text = "Hello, World";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // grbHelloWorldInt
            // 
            this.grbHelloWorldInt.BackColor = System.Drawing.Color.Transparent;
            this.grbHelloWorldInt.Controls.Add(this.radArabic);
            this.grbHelloWorldInt.Controls.Add(this.radGreek);
            this.grbHelloWorldInt.Controls.Add(this.radSwedish);
            this.grbHelloWorldInt.Controls.Add(this.radFrench);
            this.grbHelloWorldInt.Controls.Add(this.radEnglish);
            this.grbHelloWorldInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHelloWorldInt.ForeColor = System.Drawing.SystemColors.Control;
            this.grbHelloWorldInt.Location = new System.Drawing.Point(583, 284);
            this.grbHelloWorldInt.Name = "grbHelloWorldInt";
            this.grbHelloWorldInt.Size = new System.Drawing.Size(458, 100);
            this.grbHelloWorldInt.TabIndex = 6;
            this.grbHelloWorldInt.TabStop = false;
            this.grbHelloWorldInt.Text = "Languages";
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelloWorldIntAllanL.Properties.Resources._1_U_R58ahr5dtAvtSLGK2wXg;
            this.ClientSize = new System.Drawing.Size(1555, 654);
            this.Controls.Add(this.grbHelloWorldInt);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International Allan L";
            this.Load += new System.EventHandler(this.frmHelloWorldInt_Load);
            this.grbHelloWorldInt.ResumeLayout(false);
            this.grbHelloWorldInt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radArabic;
        private System.Windows.Forms.RadioButton radGreek;
        private System.Windows.Forms.RadioButton radSwedish;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.GroupBox grbHelloWorldInt;
    }
}

