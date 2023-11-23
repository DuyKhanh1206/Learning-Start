namespace プログラムSQLine
{
    partial class frmAddPhoneNumber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.NumPhoneID = new System.Windows.Forms.NumericUpDown();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.bntRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPhoneID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "電話番号ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ユーザ ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "電話番号";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtUserID.Location = new System.Drawing.Point(110, 86);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(156, 20);
            this.txtUserID.TabIndex = 3;
            // 
            // NumPhoneID
            // 
            this.NumPhoneID.Location = new System.Drawing.Point(110, 46);
            this.NumPhoneID.Name = "NumPhoneID";
            this.NumPhoneID.Size = new System.Drawing.Size(156, 19);
            this.NumPhoneID.TabIndex = 4;
            this.NumPhoneID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(110, 129);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(156, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // bntRegister
            // 
            this.bntRegister.Location = new System.Drawing.Point(113, 173);
            this.bntRegister.Name = "bntRegister";
            this.bntRegister.Size = new System.Drawing.Size(109, 23);
            this.bntRegister.TabIndex = 6;
            this.bntRegister.Text = "登録";
            this.bntRegister.UseVisualStyleBackColor = true;
            this.bntRegister.Click += new System.EventHandler(this.bntRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(107, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "グエン．カイン";
            // 
            // frmAddPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 209);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntRegister);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.NumPhoneID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPhoneNumber";
            this.Text = "frmAddPhoneNumber";
            ((System.ComponentModel.ISupportInitialize)(this.NumPhoneID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.NumericUpDown NumPhoneID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button bntRegister;
        private System.Windows.Forms.Label label4;
    }
}