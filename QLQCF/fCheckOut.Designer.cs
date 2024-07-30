namespace QLQCFTest
{
    partial class fCheckOut
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
            txbMoney = new TextBox();
            btnCheckOut = new Button();
            cbTypeMoney = new ComboBox();
            label2 = new Label();
            txbCode = new TextBox();
            lbMoney = new Label();
            btnCheckCode = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            btnNumSurcharge = new Button();
            txbNumSurcharge = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txbMoney
            // 
            txbMoney.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbMoney.Location = new Point(0, 40);
            txbMoney.Name = "txbMoney";
            txbMoney.Size = new Size(325, 32);
            txbMoney.TabIndex = 1;
            txbMoney.TextAlign = HorizontalAlignment.Center;
            txbMoney.TextChanged += textBox1_TextChanged;
            txbMoney.KeyPress += txbMoney_KeyPress;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.Location = new Point(109, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(219, 55);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Xác Nhận Thanh Toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // cbTypeMoney
            // 
            cbTypeMoney.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbTypeMoney.FormattingEnabled = true;
            cbTypeMoney.Items.AddRange(new object[] { "VND", "USD", "BẢNG", "NDT", "YÊN" });
            cbTypeMoney.Location = new Point(335, 40);
            cbTypeMoney.Name = "cbTypeMoney";
            cbTypeMoney.Size = new Size(82, 32);
            cbTypeMoney.TabIndex = 3;
            cbTypeMoney.Text = "VND";
            cbTypeMoney.KeyPress += cbTypeMoney_KeyPress;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(299, 29);
            label2.TabIndex = 4;
            label2.Text = "Nhập Mã Giảm Giá";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbCode
            // 
            txbCode.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbCode.Location = new Point(3, 48);
            txbCode.Name = "txbCode";
            txbCode.Size = new Size(325, 32);
            txbCode.TabIndex = 5;
            txbCode.TextAlign = HorizontalAlignment.Center;
            txbCode.KeyPress += txbCode_KeyPress;
            // 
            // lbMoney
            // 
            lbMoney.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMoney.ForeColor = Color.FromArgb(255, 128, 0);
            lbMoney.Location = new Point(188, 3);
            lbMoney.Name = "lbMoney";
            lbMoney.Size = new Size(240, 43);
            lbMoney.TabIndex = 6;
            lbMoney.Text = "Nhập Mã Giảm Giá";
            lbMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCheckCode
            // 
            btnCheckCode.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckCode.Location = new Point(338, 23);
            btnCheckCode.Name = "btnCheckCode";
            btnCheckCode.Size = new Size(82, 57);
            btnCheckCode.TabIndex = 8;
            btnCheckCode.Text = "Check";
            btnCheckCode.UseVisualStyleBackColor = true;
            btnCheckCode.Click += btnCheckCode_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCheckOut);
            panel1.Location = new Point(3, 296);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 73);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnNumSurcharge);
            panel3.Controls.Add(txbNumSurcharge);
            panel3.Location = new Point(2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 110);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 27);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 0;
            label3.Text = "Số Lượng Phụ Thu:";
            // 
            // btnNumSurcharge
            // 
            btnNumSurcharge.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumSurcharge.Location = new Point(163, 74);
            btnNumSurcharge.Name = "btnNumSurcharge";
            btnNumSurcharge.Size = new Size(74, 31);
            btnNumSurcharge.TabIndex = 11;
            btnNumSurcharge.Text = "Xong";
            btnNumSurcharge.UseVisualStyleBackColor = true;
            btnNumSurcharge.Click += btnNumSurcharge_Click;
            // 
            // txbNumSurcharge
            // 
            txbNumSurcharge.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbNumSurcharge.Location = new Point(194, 23);
            txbNumSurcharge.Name = "txbNumSurcharge";
            txbNumSurcharge.Size = new Size(206, 32);
            txbNumSurcharge.TabIndex = 1;
            txbNumSurcharge.Text = "0";
            txbNumSurcharge.TextAlign = HorizontalAlignment.Right;
            txbNumSurcharge.KeyPress += txbMoney_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbCode);
            panel2.Controls.Add(btnCheckCode);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 83);
            panel2.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lbMoney);
            panel4.Location = new Point(3, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 46);
            panel4.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(210, 43);
            label1.TabIndex = 7;
            label1.Text = "Số Tiền Cần Phải Trả";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txbMoney);
            panel5.Controls.Add(cbTypeMoney);
            panel5.Location = new Point(3, 189);
            panel5.Name = "panel5";
            panel5.Size = new Size(428, 103);
            panel5.TabIndex = 14;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(296, 29);
            label5.TabIndex = 4;
            label5.Text = "Nhập Số Tiền Khách Trả";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(3, 91);
            label4.Name = "label4";
            label4.Size = new Size(429, 2);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(3, 184);
            label6.Name = "label6";
            label6.Size = new Size(429, 2);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // fCheckOut
            // 
            AcceptButton = btnCheckOut;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 371);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            Load += fCheckOut_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txbMoney;
        private Button btnCheckOut;
        private ComboBox cbTypeMoney;
        private Label label2;
        private TextBox txbCode;
        private Label lbMoney;
        private Button btnCheckCode;
        private Panel panel1;
        private Label label3;
        private TextBox txbNumSurcharge;
        private Button btnNumSurcharge;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label6;
    }
}