namespace プログラムSQLine
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntload = new System.Windows.Forms.Button();
            this.bntcancel = new System.Windows.Forms.Button();
            this.bntaddnumber = new System.Windows.Forms.Button();
            this.bntadduser = new System.Windows.Forms.Button();
            this.dgvPhoneBook = new System.Windows.Forms.DataGridView();
            this.phoneBookEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "電話帳 Danh bạ điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "グエン。カィン";
            // 
            // bntload
            // 
            this.bntload.Location = new System.Drawing.Point(37, 327);
            this.bntload.Name = "bntload";
            this.bntload.Size = new System.Drawing.Size(199, 42);
            this.bntload.TabIndex = 3;
            this.bntload.Text = "データ表示";
            this.bntload.UseVisualStyleBackColor = true;
            this.bntload.Click += new System.EventHandler(this.bntload_Click);
            // 
            // bntcancel
            // 
            this.bntcancel.Location = new System.Drawing.Point(37, 376);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(199, 42);
            this.bntcancel.TabIndex = 4;
            this.bntcancel.Text = "キャンセル";
            this.bntcancel.UseVisualStyleBackColor = true;
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // bntaddnumber
            // 
            this.bntaddnumber.Location = new System.Drawing.Point(299, 327);
            this.bntaddnumber.Name = "bntaddnumber";
            this.bntaddnumber.Size = new System.Drawing.Size(199, 42);
            this.bntaddnumber.TabIndex = 5;
            this.bntaddnumber.Text = "電話番号追加";
            this.bntaddnumber.UseVisualStyleBackColor = true;
            this.bntaddnumber.Click += new System.EventHandler(this.bntaddnumber_Click);
            // 
            // bntadduser
            // 
            this.bntadduser.Location = new System.Drawing.Point(299, 375);
            this.bntadduser.Name = "bntadduser";
            this.bntadduser.Size = new System.Drawing.Size(199, 42);
            this.bntadduser.TabIndex = 6;
            this.bntadduser.Text = "ユーザ追加";
            this.bntadduser.UseVisualStyleBackColor = true;
            this.bntadduser.Click += new System.EventHandler(this.bntadduser_Click);
            // 
            // dgvPhoneBook
            // 
            this.dgvPhoneBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneBook.Location = new System.Drawing.Point(37, 83);
            this.dgvPhoneBook.Name = "dgvPhoneBook";
            this.dgvPhoneBook.RowTemplate.Height = 21;
            this.dgvPhoneBook.Size = new System.Drawing.Size(461, 229);
            this.dgvPhoneBook.TabIndex = 7;
            // 
            // phoneBookEntityBindingSource
            // 

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 430);
            this.Controls.Add(this.dgvPhoneBook);
            this.Controls.Add(this.bntadduser);
            this.Controls.Add(this.bntaddnumber);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.bntload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntload;
        private System.Windows.Forms.Button bntcancel;
        private System.Windows.Forms.Button bntaddnumber;
        private System.Windows.Forms.Button bntadduser;
        private System.Windows.Forms.BindingSource phoneBookEntityBindingSource;
        private System.Windows.Forms.DataGridView dgvPhoneBook;
    }
}

