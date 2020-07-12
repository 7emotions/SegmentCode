namespace LEDSegmentCode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.calc = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.anode = new System.Windows.Forms.RadioButton();
            this.cathode = new System.Windows.Forms.RadioButton();
            this.led1 = new LEDSegmentCode.LED();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(253, 223);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 1;
            this.calc.Text = "Generate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(216, 152);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 12);
            this.date.TabIndex = 2;
            this.date.Text = "HexCode:";
            // 
            // anode
            // 
            this.anode.AutoSize = true;
            this.anode.Location = new System.Drawing.Point(256, 70);
            this.anode.Name = "anode";
            this.anode.Size = new System.Drawing.Size(53, 16);
            this.anode.TabIndex = 3;
            this.anode.TabStop = true;
            this.anode.Text = "Anode";
            this.anode.UseVisualStyleBackColor = true;
            // 
            // cathode
            // 
            this.cathode.AutoSize = true;
            this.cathode.Location = new System.Drawing.Point(256, 92);
            this.cathode.Name = "cathode";
            this.cathode.Size = new System.Drawing.Size(65, 16);
            this.cathode.TabIndex = 3;
            this.cathode.TabStop = true;
            this.cathode.Text = "Cathode";
            this.cathode.UseVisualStyleBackColor = true;
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Black;
            this.led1.Location = new System.Drawing.Point(12, 12);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(169, 234);
            this.led1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 272);
            this.Controls.Add(this.cathode);
            this.Controls.Add(this.anode);
            this.Controls.Add(this.date);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.led1);
            this.Name = "Form1";
            this.Text = "LEDSegmentCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LED led1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.RadioButton anode;
        private System.Windows.Forms.RadioButton cathode;
    }
}

