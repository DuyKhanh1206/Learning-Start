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
            this.cbChange1 = new System.Windows.Forms.CheckBox();
            this.bntRead = new System.Windows.Forms.Button();
            this.bntOpen1 = new System.Windows.Forms.Button();
            this.tbLinkOpen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLinkWrite = new System.Windows.Forms.TextBox();
            this.cbChange2 = new System.Windows.Forms.CheckBox();
            this.bntWrite = new System.Windows.Forms.Button();
            this.bntOpen2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bntClear = new System.Windows.Forms.Button();
            this.cbASC__JIS = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChange1);
            this.groupBox1.Controls.Add(this.bntRead);
            this.groupBox1.Controls.Add(this.bntOpen1);
            this.groupBox1.Controls.Add(this.tbLinkOpen);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "読み込み";
            // 
            // cbChange1
            // 
            this.cbChange1.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbChange1.BackColor = System.Drawing.Color.SpringGreen;
            this.cbChange1.Checked = true;
            this.cbChange1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChange1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbChange1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbChange1.Location = new System.Drawing.Point(430, 69);
            this.cbChange1.Name = "cbChange1";
            this.cbChange1.Size = new System.Drawing.Size(90, 25);
            this.cbChange1.TabIndex = 6;
            this.cbChange1.Text = "暗号化オン";
            this.cbChange1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbChange1.UseVisualStyleBackColor = false;
            this.cbChange1.CheckedChanged += new System.EventHandler(this.cbChange1_CheckedChanged);
            // 
            // bntRead
            // 
            this.bntRead.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bntRead.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntRead.Location = new System.Drawing.Point(526, 69);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(90, 25);
            this.bntRead.TabIndex = 3;
            this.bntRead.Text = "読み込み";
            this.bntRead.UseVisualStyleBackColor = true;
            this.bntRead.Click += new System.EventHandler(this.bntRead_Click);
            // 
            // bntOpen1
            // 
            this.bntOpen1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bntOpen1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntOpen1.Location = new System.Drawing.Point(526, 18);
            this.bntOpen1.Name = "bntOpen1";
            this.bntOpen1.Size = new System.Drawing.Size(90, 40);
            this.bntOpen1.TabIndex = 1;
            this.bntOpen1.Text = "参照";
            this.bntOpen1.UseVisualStyleBackColor = true;
            this.bntOpen1.Click += new System.EventHandler(this.bntOpen1_Click);
            // 
            // tbLinkOpen
            // 
            this.tbLinkOpen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLinkOpen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLinkOpen.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLinkOpen.Location = new System.Drawing.Point(7, 18);
            this.tbLinkOpen.Multiline = true;
            this.tbLinkOpen.Name = "tbLinkOpen";
            this.tbLinkOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLinkOpen.Size = new System.Drawing.Size(513, 40);
            this.tbLinkOpen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLinkWrite);
            this.groupBox2.Controls.Add(this.cbChange2);
            this.groupBox2.Controls.Add(this.bntWrite);
            this.groupBox2.Controls.Add(this.bntOpen2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "書き込み";
            // 
            // tbLinkWrite
            // 
            this.tbLinkWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLinkWrite.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLinkWrite.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLinkWrite.Location = new System.Drawing.Point(7, 17);
            this.tbLinkWrite.Multiline = true;
            this.tbLinkWrite.Name = "tbLinkWrite";
            this.tbLinkWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLinkWrite.Size = new System.Drawing.Size(513, 40);
            this.tbLinkWrite.TabIndex = 8;
            // 
            // cbChange2
            // 
            this.cbChange2.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbChange2.BackColor = System.Drawing.Color.SpringGreen;
            this.cbChange2.Checked = true;
            this.cbChange2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChange2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbChange2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbChange2.Location = new System.Drawing.Point(430, 69);
            this.cbChange2.Name = "cbChange2";
            this.cbChange2.Size = new System.Drawing.Size(90, 25);
            this.cbChange2.TabIndex = 7;
            this.cbChange2.Text = "暗号化オン";
            this.cbChange2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbChange2.UseVisualStyleBackColor = false;
            this.cbChange2.CheckedChanged += new System.EventHandler(this.cbChange2_CheckedChanged);
            // 
            // bntWrite
            // 
            this.bntWrite.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bntWrite.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntWrite.Location = new System.Drawing.Point(526, 69);
            this.bntWrite.Name = "bntWrite";
            this.bntWrite.Size = new System.Drawing.Size(90, 25);
            this.bntWrite.TabIndex = 4;
            this.bntWrite.Text = "書き込み";
            this.bntWrite.UseVisualStyleBackColor = true;
            this.bntWrite.Click += new System.EventHandler(this.bntWrite_Click);
            // 
            // bntOpen2
            // 
            this.bntOpen2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bntOpen2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntOpen2.Location = new System.Drawing.Point(526, 17);
            this.bntOpen2.Name = "bntOpen2";
            this.bntOpen2.Size = new System.Drawing.Size(90, 40);
            this.bntOpen2.TabIndex = 2;
            this.bntOpen2.Text = "参照";
            this.bntOpen2.UseVisualStyleBackColor = true;
            this.bntOpen2.Click += new System.EventHandler(this.bntOpen2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbDisplay);
            this.groupBox3.Controls.Add(this.bntClear);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(653, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 388);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "テキストエディタ";
            // 
            // tbDisplay
            // 
            this.tbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbDisplay.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDisplay.Location = new System.Drawing.Point(6, 49);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDisplay.Size = new System.Drawing.Size(405, 333);
            this.tbDisplay.TabIndex = 4;
            // 
            // bntClear
            // 
            this.bntClear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bntClear.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bntClear.Location = new System.Drawing.Point(6, 19);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 25);
            this.bntClear.TabIndex = 3;
            this.bntClear.Text = "表示クリア";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // cbASC__JIS
            // 
            this.cbASC__JIS.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbASC__JIS.BackColor = System.Drawing.Color.SpringGreen;
            this.cbASC__JIS.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbASC__JIS.Checked = true;
            this.cbASC__JIS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbASC__JIS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbASC__JIS.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbASC__JIS.Location = new System.Drawing.Point(12, 271);
            this.cbASC__JIS.Name = "cbASC__JIS";
            this.cbASC__JIS.Size = new System.Drawing.Size(105, 25);
            this.cbASC__JIS.TabIndex = 5;
            this.cbASC__JIS.Text = "ASCII";
            this.cbASC__JIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbASC__JIS.UseVisualStyleBackColor = false;
            this.cbASC__JIS.CheckedChanged += new System.EventHandler(this.cbASC__JIS_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1087, 433);
            this.Controls.Add(this.cbASC__JIS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "カイン_EnDeCode";
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
        private System.Windows.Forms.Button bntOpen1;
        private System.Windows.Forms.TextBox tbLinkOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntWrite;
        private System.Windows.Forms.Button bntOpen2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.CheckBox cbASC__JIS;
        private System.Windows.Forms.CheckBox cbChange1;
        private System.Windows.Forms.CheckBox cbChange2;
        private System.Windows.Forms.TextBox tbLinkWrite;
    }
}

