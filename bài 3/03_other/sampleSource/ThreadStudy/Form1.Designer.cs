namespace ThreadStudy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThread1Start = new System.Windows.Forms.Button();
            this.btnThread1Stop = new System.Windows.Forms.Button();
            this.btnThread1Start2 = new System.Windows.Forms.Button();
            this.btnThread1Stop2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThread1Start
            // 
            this.btnThread1Start.Location = new System.Drawing.Point(22, 12);
            this.btnThread1Start.Name = "btnThread1Start";
            this.btnThread1Start.Size = new System.Drawing.Size(75, 23);
            this.btnThread1Start.TabIndex = 1;
            this.btnThread1Start.Text = "Start1";
            this.btnThread1Start.UseVisualStyleBackColor = true;
            this.btnThread1Start.Click += new System.EventHandler(this.btnThread1Start_Click);
            // 
            // btnThread1Stop
            // 
            this.btnThread1Stop.Location = new System.Drawing.Point(22, 53);
            this.btnThread1Stop.Name = "btnThread1Stop";
            this.btnThread1Stop.Size = new System.Drawing.Size(75, 23);
            this.btnThread1Stop.TabIndex = 2;
            this.btnThread1Stop.Text = "Stop1";
            this.btnThread1Stop.UseVisualStyleBackColor = true;
            this.btnThread1Stop.Click += new System.EventHandler(this.btnThread1Stop_Click);
            // 
            // btnThread1Start2
            // 
            this.btnThread1Start2.Location = new System.Drawing.Point(173, 12);
            this.btnThread1Start2.Name = "btnThread1Start2";
            this.btnThread1Start2.Size = new System.Drawing.Size(75, 23);
            this.btnThread1Start2.TabIndex = 3;
            this.btnThread1Start2.Text = "Start2";
            this.btnThread1Start2.UseVisualStyleBackColor = true;
            this.btnThread1Start2.Click += new System.EventHandler(this.btnThread1Start2_Click);
            // 
            // btnThread1Stop2
            // 
            this.btnThread1Stop2.Location = new System.Drawing.Point(173, 53);
            this.btnThread1Stop2.Name = "btnThread1Stop2";
            this.btnThread1Stop2.Size = new System.Drawing.Size(75, 23);
            this.btnThread1Stop2.TabIndex = 4;
            this.btnThread1Stop2.Text = "Stop2";
            this.btnThread1Stop2.UseVisualStyleBackColor = true;
            this.btnThread1Stop2.Click += new System.EventHandler(this.btnThread1Stop2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 119);
            this.Controls.Add(this.btnThread1Start2);
            this.Controls.Add(this.btnThread1Stop2);
            this.Controls.Add(this.btnThread1Start);
            this.Controls.Add(this.btnThread1Stop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThread1Start;
        private System.Windows.Forms.Button btnThread1Stop;
        private System.Windows.Forms.Button btnThread1Start2;
        private System.Windows.Forms.Button btnThread1Stop2;
    }
}

