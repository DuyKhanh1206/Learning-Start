namespace En_DeCode_basic
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntRead = new System.Windows.Forms.Button();
            this.bntChange1 = new System.Windows.Forms.Button();
            this.bntOpen1 = new System.Windows.Forms.Button();
            this.tbLinkOpen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntWrite = new System.Windows.Forms.Button();
            this.bntChange2 = new System.Windows.Forms.Button();
            this.bntOpen2 = new System.Windows.Forms.Button();
            this.tbLinkWrite = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bntClear = new System.Windows.Forms.Button();
            this.bntASC__JIS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntRead);
            this.groupBox1.Controls.Add(this.bntChange1);
            this.groupBox1.Controls.Add(this.bntOpen1);
            this.groupBox1.Controls.Add(this.tbLinkOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "読み込み";
            // 
            // bntRead
            // 
            this.bntRead.Location = new System.Drawing.Point(446, 49);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(75, 25);
            this.bntRead.TabIndex = 3;
            this.bntRead.Text = "読み込み";
            this.bntRead.UseVisualStyleBackColor = true;
            this.bntRead.Click += new System.EventHandler(this.bntRead_Click);
            // 
            // bntChange1
            // 
            this.bntChange1.BackColor = System.Drawing.Color.SpringGreen;
            this.bntChange1.Location = new System.Drawing.Point(365, 49);
            this.bntChange1.Name = "bntChange1";
            this.bntChange1.Size = new System.Drawing.Size(75, 25);
            this.bntChange1.TabIndex = 2;
            this.bntChange1.Text = "暗号化オン";
            this.bntChange1.UseVisualStyleBackColor = false;
            this.bntChange1.Click += new System.EventHandler(this.bntChange1_Click);
            // 
            // bntOpen1
            // 
            this.bntOpen1.Location = new System.Drawing.Point(446, 19);
            this.bntOpen1.Name = "bntOpen1";
            this.bntOpen1.Size = new System.Drawing.Size(75, 25);
            this.bntOpen1.TabIndex = 1;
            this.bntOpen1.Text = "参照";
            this.bntOpen1.UseVisualStyleBackColor = true;
            this.bntOpen1.Click += new System.EventHandler(this.bntOpen1_Click);
            // 
            // tbLinkOpen
            // 
            this.tbLinkOpen.Location = new System.Drawing.Point(7, 18);
            this.tbLinkOpen.Multiline = true;
            this.tbLinkOpen.Name = "tbLinkOpen";
            this.tbLinkOpen.Size = new System.Drawing.Size(433, 25);
            this.tbLinkOpen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntWrite);
            this.groupBox2.Controls.Add(this.bntChange2);
            this.groupBox2.Controls.Add(this.bntOpen2);
            this.groupBox2.Controls.Add(this.tbLinkWrite);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "書き込み";
            // 
            // bntWrite
            // 
            this.bntWrite.Location = new System.Drawing.Point(446, 58);
            this.bntWrite.Name = "bntWrite";
            this.bntWrite.Size = new System.Drawing.Size(75, 25);
            this.bntWrite.TabIndex = 4;
            this.bntWrite.Text = "書き込み";
            this.bntWrite.UseVisualStyleBackColor = true;
            this.bntWrite.Click += new System.EventHandler(this.bntWrite_Click);
            // 
            // bntChange2
            // 
            this.bntChange2.BackColor = System.Drawing.Color.SpringGreen;
            this.bntChange2.Location = new System.Drawing.Point(365, 58);
            this.bntChange2.Name = "bntChange2";
            this.bntChange2.Size = new System.Drawing.Size(75, 25);
            this.bntChange2.TabIndex = 3;
            this.bntChange2.Text = "暗号化オン";
            this.bntChange2.UseVisualStyleBackColor = false;
            this.bntChange2.Click += new System.EventHandler(this.bntChange2_Click);
            // 
            // bntOpen2
            // 
            this.bntOpen2.Location = new System.Drawing.Point(446, 25);
            this.bntOpen2.Name = "bntOpen2";
            this.bntOpen2.Size = new System.Drawing.Size(75, 25);
            this.bntOpen2.TabIndex = 2;
            this.bntOpen2.Text = "参照";
            this.bntOpen2.UseVisualStyleBackColor = true;
            this.bntOpen2.Click += new System.EventHandler(this.bntOpen2_Click);
            // 
            // tbLinkWrite
            // 
            this.tbLinkWrite.Location = new System.Drawing.Point(7, 23);
            this.tbLinkWrite.Multiline = true;
            this.tbLinkWrite.Name = "tbLinkWrite";
            this.tbLinkWrite.Size = new System.Drawing.Size(433, 25);
            this.tbLinkWrite.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbDisplay);
            this.groupBox3.Controls.Add(this.bntClear);
            this.groupBox3.Location = new System.Drawing.Point(571, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 388);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "テキストエディタ";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(6, 49);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDisplay.Size = new System.Drawing.Size(459, 333);
            this.tbDisplay.TabIndex = 4;
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(6, 19);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 25);
            this.bntClear.TabIndex = 3;
            this.bntClear.Text = "表示クリア";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // bntASC__JIS
            // 
            this.bntASC__JIS.BackColor = System.Drawing.Color.SpringGreen;
            this.bntASC__JIS.Location = new System.Drawing.Point(19, 250);
            this.bntASC__JIS.Name = "bntASC__JIS";
            this.bntASC__JIS.Size = new System.Drawing.Size(75, 25);
            this.bntASC__JIS.TabIndex = 3;
            this.bntASC__JIS.Text = "ASCII";
            this.bntASC__JIS.UseVisualStyleBackColor = false;
            this.bntASC__JIS.Click += new System.EventHandler(this.bntASC__JIS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 428);
            this.Controls.Add(this.bntASC__JIS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntRead;
        private System.Windows.Forms.Button bntChange1;
        private System.Windows.Forms.Button bntOpen1;
        private System.Windows.Forms.TextBox tbLinkOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntWrite;
        private System.Windows.Forms.Button bntChange2;
        private System.Windows.Forms.Button bntOpen2;
        private System.Windows.Forms.TextBox tbLinkWrite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntASC__JIS;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}

