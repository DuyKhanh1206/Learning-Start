namespace Encoder
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
            this.txtReadFilePath = new System.Windows.Forms.TextBox();
            this.btnReadReference = new System.Windows.Forms.Button();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cbxWrite = new System.Windows.Forms.CheckBox();
            this.cbxRead = new System.Windows.Forms.CheckBox();
            this.txtWriteFilePath = new System.Windows.Forms.TextBox();
            this.btnWriteReference = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTextClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxEncode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReadFilePath
            // 
            this.txtReadFilePath.Location = new System.Drawing.Point(6, 20);
            this.txtReadFilePath.Multiline = true;
            this.txtReadFilePath.Name = "txtReadFilePath";
            this.txtReadFilePath.Size = new System.Drawing.Size(412, 31);
            this.txtReadFilePath.TabIndex = 0;
            // 
            // btnReadReference
            // 
            this.btnReadReference.Location = new System.Drawing.Point(424, 18);
            this.btnReadReference.Name = "btnReadReference";
            this.btnReadReference.Size = new System.Drawing.Size(75, 23);
            this.btnReadReference.TabIndex = 1;
            this.btnReadReference.Text = "参照";
            this.btnReadReference.UseVisualStyleBackColor = true;
            this.btnReadReference.Click += new System.EventHandler(this.btnReadReference_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(6, 50);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(504, 429);
            this.txtEditor.TabIndex = 2;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(424, 55);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "読み込み";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(424, 55);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "書き込み";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cbxWrite
            // 
            this.cbxWrite.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxWrite.BackColor = System.Drawing.Color.PaleGreen;
            this.cbxWrite.Location = new System.Drawing.Point(338, 55);
            this.cbxWrite.Name = "cbxWrite";
            this.cbxWrite.Size = new System.Drawing.Size(80, 23);
            this.cbxWrite.TabIndex = 6;
            this.cbxWrite.Text = "暗号化オフ";
            this.cbxWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxWrite.UseVisualStyleBackColor = false;
            this.cbxWrite.CheckedChanged += new System.EventHandler(this.cbxWrite_CheckedChanged);
            // 
            // cbxRead
            // 
            this.cbxRead.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxRead.BackColor = System.Drawing.Color.PaleGreen;
            this.cbxRead.Location = new System.Drawing.Point(338, 55);
            this.cbxRead.Name = "cbxRead";
            this.cbxRead.Size = new System.Drawing.Size(80, 23);
            this.cbxRead.TabIndex = 7;
            this.cbxRead.Text = "暗号化オフ";
            this.cbxRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxRead.UseVisualStyleBackColor = false;
            this.cbxRead.CheckedChanged += new System.EventHandler(this.cbxRead_CheckedChanged);
            // 
            // txtWriteFilePath
            // 
            this.txtWriteFilePath.Location = new System.Drawing.Point(6, 20);
            this.txtWriteFilePath.Multiline = true;
            this.txtWriteFilePath.Name = "txtWriteFilePath";
            this.txtWriteFilePath.Size = new System.Drawing.Size(412, 31);
            this.txtWriteFilePath.TabIndex = 8;
            // 
            // btnWriteReference
            // 
            this.btnWriteReference.Location = new System.Drawing.Point(424, 18);
            this.btnWriteReference.Name = "btnWriteReference";
            this.btnWriteReference.Size = new System.Drawing.Size(75, 23);
            this.btnWriteReference.TabIndex = 9;
            this.btnWriteReference.Text = "参照";
            this.btnWriteReference.UseVisualStyleBackColor = true;
            this.btnWriteReference.Click += new System.EventHandler(this.btnWriteReference_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReadFilePath);
            this.groupBox1.Controls.Add(this.btnReadReference);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.cbxRead);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "読み込み";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWriteFilePath);
            this.groupBox2.Controls.Add(this.btnWrite);
            this.groupBox2.Controls.Add(this.btnWriteReference);
            this.groupBox2.Controls.Add(this.cbxWrite);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 91);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "書き込み";
            // 
            // btnTextClear
            // 
            this.btnTextClear.Location = new System.Drawing.Point(6, 18);
            this.btnTextClear.Name = "btnTextClear";
            this.btnTextClear.Size = new System.Drawing.Size(75, 23);
            this.btnTextClear.TabIndex = 12;
            this.btnTextClear.Text = "表示クリア";
            this.btnTextClear.UseVisualStyleBackColor = true;
            this.btnTextClear.Click += new System.EventHandler(this.btnTextClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEditor);
            this.groupBox3.Controls.Add(this.btnTextClear);
            this.groupBox3.Location = new System.Drawing.Point(546, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 490);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "テキストエディタ";
            // 
            // cbxEncode
            // 
            this.cbxEncode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxEncode.BackColor = System.Drawing.Color.PaleGreen;
            this.cbxEncode.Location = new System.Drawing.Point(18, 226);
            this.cbxEncode.Name = "cbxEncode";
            this.cbxEncode.Size = new System.Drawing.Size(80, 23);
            this.cbxEncode.TabIndex = 14;
            this.cbxEncode.Text = "ASCII";
            this.cbxEncode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxEncode.UseVisualStyleBackColor = false;
            this.cbxEncode.CheckedChanged += new System.EventHandler(this.cbxEncode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 512);
            this.Controls.Add(this.cbxEncode);
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

        private System.Windows.Forms.TextBox txtReadFilePath;
        private System.Windows.Forms.Button btnReadReference;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.CheckBox cbxWrite;
        private System.Windows.Forms.CheckBox cbxRead;
        private System.Windows.Forms.TextBox txtWriteFilePath;
        private System.Windows.Forms.Button btnWriteReference;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTextClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxEncode;
    }
}

