namespace autoClick
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.mouse_x = new System.Windows.Forms.TextBox();
            this.mouse_y = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择坐标";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mouse_x
            // 
            this.mouse_x.Location = new System.Drawing.Point(42, 79);
            this.mouse_x.Name = "mouse_x";
            this.mouse_x.Size = new System.Drawing.Size(100, 24);
            this.mouse_x.TabIndex = 1;
            // 
            // mouse_y
            // 
            this.mouse_y.Location = new System.Drawing.Point(149, 78);
            this.mouse_y.Name = "mouse_y";
            this.mouse_y.Size = new System.Drawing.Size(100, 24);
            this.mouse_y.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "开始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("方正姚体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(148, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "秒";
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(42, 129);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(100, 24);
            this.times.TabIndex = 4;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.times);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mouse_y);
            this.Controls.Add(this.mouse_x);
            this.Controls.Add(this.button1);
            this.Name = "main";
            this.Text = "auto_click";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mouse_x;
        private System.Windows.Forms.TextBox mouse_y;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox times;
    }
}

