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
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnThread1Start = new System.Windows.Forms.Button();
            this.btnThread1Stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThread2Start_Click = new System.Windows.Forms.Button();
            this.btnThread2Stop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timDisplayRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblTypeWriter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTimer.Location = new System.Drawing.Point(15, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(109, 23);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00.000";
            // 
            // btnThread1Start
            // 
            this.btnThread1Start.Location = new System.Drawing.Point(130, 18);
            this.btnThread1Start.Name = "btnThread1Start";
            this.btnThread1Start.Size = new System.Drawing.Size(75, 23);
            this.btnThread1Start.TabIndex = 1;
            this.btnThread1Start.Text = "Start";
            this.btnThread1Start.UseVisualStyleBackColor = true;
            this.btnThread1Start.Click += new System.EventHandler(this.btnThread1Start_Click);
            // 
            // btnThread1Stop
            // 
            this.btnThread1Stop.Location = new System.Drawing.Point(130, 59);
            this.btnThread1Stop.Name = "btnThread1Stop";
            this.btnThread1Stop.Size = new System.Drawing.Size(75, 23);
            this.btnThread1Stop.TabIndex = 2;
            this.btnThread1Stop.Text = "Stop";
            this.btnThread1Stop.UseVisualStyleBackColor = true;
            this.btnThread1Stop.Click += new System.EventHandler(this.btnThread1Stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.btnThread1Start);
            this.groupBox1.Controls.Add(this.btnThread1Stop);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread1-Timer-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTypeWriter);
            this.groupBox2.Controls.Add(this.btnThread2Start_Click);
            this.groupBox2.Controls.Add(this.btnThread2Stop);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 216);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread2-TypeWriter-";
            // 
            // btnThread2Start_Click
            // 
            this.btnThread2Start_Click.Location = new System.Drawing.Point(452, 18);
            this.btnThread2Start_Click.Name = "btnThread2Start_Click";
            this.btnThread2Start_Click.Size = new System.Drawing.Size(75, 23);
            this.btnThread2Start_Click.TabIndex = 8;
            this.btnThread2Start_Click.Text = "Start";
            this.btnThread2Start_Click.UseVisualStyleBackColor = true;
            this.btnThread2Start_Click.Click += new System.EventHandler(this.btnThread2Start_Click_Click);
            // 
            // btnThread2Stop
            // 
            this.btnThread2Stop.Location = new System.Drawing.Point(452, 59);
            this.btnThread2Stop.Name = "btnThread2Stop";
            this.btnThread2Stop.Size = new System.Drawing.Size(75, 23);
            this.btnThread2Stop.TabIndex = 9;
            this.btnThread2Stop.Text = "Stop";
            this.btnThread2Stop.UseVisualStyleBackColor = true;
            this.btnThread2Stop.Click += new System.EventHandler(this.btnThread2Stop_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(98, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "終了";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timDisplayRefresh
            // 
            this.timDisplayRefresh.Enabled = true;
            this.timDisplayRefresh.Interval = 50;
            this.timDisplayRefresh.Tick += new System.EventHandler(this.timDisplayRefresh_Tick);
            // 
            // lblTypeWriter
            // 
            this.lblTypeWriter.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTypeWriter.Location = new System.Drawing.Point(6, 20);
            this.lblTypeWriter.Name = "lblTypeWriter";
            this.lblTypeWriter.Size = new System.Drawing.Size(440, 183);
            this.lblTypeWriter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 240);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnThread1Start;
        private System.Windows.Forms.Button btnThread1Stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThread2Start_Click;
        private System.Windows.Forms.Button btnThread2Stop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timDisplayRefresh;
        private System.Windows.Forms.Label lblTypeWriter;
    }
}

