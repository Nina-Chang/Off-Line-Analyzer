namespace Off_Line_Analyzer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.skinBtnLoad = new CCWin.SkinControl.SkinButton();
            this.skinBtnClear = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1160, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1160, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1160, 261);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(214, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heart Rate(From ECG):";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(39, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 202);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(39, 312);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 226);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(39, 542);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 216);
            this.panel3.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // skinBtnLoad
            // 
            this.skinBtnLoad.BackColor = System.Drawing.Color.Transparent;
            this.skinBtnLoad.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinBtnLoad.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinBtnLoad.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinBtnLoad.DownBack = null;
            this.skinBtnLoad.DownBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinBtnLoad.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinBtnLoad.GlowColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinBtnLoad.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinBtnLoad.IsDrawGlass = false;
            this.skinBtnLoad.Location = new System.Drawing.Point(39, 46);
            this.skinBtnLoad.MouseBack = null;
            this.skinBtnLoad.MouseBaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinBtnLoad.Name = "skinBtnLoad";
            this.skinBtnLoad.NormlBack = null;
            this.skinBtnLoad.Radius = 20;
            this.skinBtnLoad.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinBtnLoad.Size = new System.Drawing.Size(152, 47);
            this.skinBtnLoad.TabIndex = 7;
            this.skinBtnLoad.Text = "Load";
            this.skinBtnLoad.UseVisualStyleBackColor = false;
            this.skinBtnLoad.Click += new System.EventHandler(this.skinBtnLoad_Click);
            // 
            // skinBtnClear
            // 
            this.skinBtnClear.BackColor = System.Drawing.Color.Transparent;
            this.skinBtnClear.BaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinBtnClear.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinBtnClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinBtnClear.DownBack = null;
            this.skinBtnClear.DownBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinBtnClear.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinBtnClear.GlowColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinBtnClear.InnerBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinBtnClear.IsDrawGlass = false;
            this.skinBtnClear.Location = new System.Drawing.Point(919, 46);
            this.skinBtnClear.MouseBack = null;
            this.skinBtnClear.MouseBaseColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinBtnClear.Name = "skinBtnClear";
            this.skinBtnClear.NormlBack = null;
            this.skinBtnClear.Radius = 15;
            this.skinBtnClear.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinBtnClear.Size = new System.Drawing.Size(151, 45);
            this.skinBtnClear.TabIndex = 8;
            this.skinBtnClear.Text = "Clear";
            this.skinBtnClear.UseVisualStyleBackColor = false;
            this.skinBtnClear.Click += new System.EventHandler(this.skinBtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CaptionFont = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1110, 775);
            this.Controls.Add(this.skinBtnClear);
            this.Controls.Add(this.skinBtnLoad);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Radius = 30;
            this.Text = "Off-line Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CCWin.SkinControl.SkinButton skinBtnLoad;
        private CCWin.SkinControl.SkinButton skinBtnClear;
    }
}

