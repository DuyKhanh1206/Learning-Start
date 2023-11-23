namespace thread_basic
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
            this.bntStartT1 = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.bntStartT2 = new System.Windows.Forms.Button();
            this.lbThreadTimer1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTextResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntStartT1
            // 
            this.bntStartT1.Location = new System.Drawing.Point(168, 34);
            this.bntStartT1.Margin = new System.Windows.Forms.Padding(4);
            this.bntStartT1.Name = "bntStartT1";
            this.bntStartT1.Size = new System.Drawing.Size(100, 33);
            this.bntStartT1.TabIndex = 0;
            this.bntStartT1.Text = "Start";
            this.bntStartT1.UseVisualStyleBackColor = true;
            this.bntStartT1.Click += new System.EventHandler(this.bntStartT1_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancel.Location = new System.Drawing.Point(95, 189);
            this.bntCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(100, 33);
            this.bntCancel.TabIndex = 1;
            this.bntCancel.Text = "終了";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntStartT2
            // 
            this.bntStartT2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntStartT2.Location = new System.Drawing.Point(412, 34);
            this.bntStartT2.Margin = new System.Windows.Forms.Padding(4);
            this.bntStartT2.Name = "bntStartT2";
            this.bntStartT2.Size = new System.Drawing.Size(100, 33);
            this.bntStartT2.TabIndex = 3;
            this.bntStartT2.Text = "Start";
            this.bntStartT2.UseVisualStyleBackColor = true;
            this.bntStartT2.Click += new System.EventHandler(this.bntStartT2_Click);
            // 
            // lbThreadTimer1
            // 
            this.lbThreadTimer1.AutoSize = true;
            this.lbThreadTimer1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThreadTimer1.Location = new System.Drawing.Point(26, 37);
            this.lbThreadTimer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThreadTimer1.Name = "lbThreadTimer1";
            this.lbThreadTimer1.Size = new System.Drawing.Size(119, 23);
            this.lbThreadTimer1.TabIndex = 6;
            this.lbThreadTimer1.Text = "00 : 00 : 000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbThreadTimer1);
            this.groupBox1.Controls.Add(this.bntStartT1);
            this.groupBox1.Controls.Add(this.bntCancel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(297, 230);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread_Timer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTextResult);
            this.groupBox2.Controls.Add(this.bntStartT2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(309, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 230);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread_Writer";
            // 
            // lbTextResult
            // 
            this.lbTextResult.AutoSize = true;
            this.lbTextResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextResult.Location = new System.Drawing.Point(31, 34);
            this.lbTextResult.Name = "lbTextResult";
            this.lbTextResult.Size = new System.Drawing.Size(0, 21);
            this.lbTextResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bntCancel;
            this.ClientSize = new System.Drawing.Size(876, 265);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "basic parallel programming";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntStartT1;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button bntStartT2;
        private System.Windows.Forms.Label lbThreadTimer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTextResult;
    }
}

