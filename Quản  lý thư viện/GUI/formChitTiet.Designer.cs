namespace Quản__lý_thư_viện.GUI
{
    partial class formChitTiet
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMasach = new TextBox();
            txtMaloai = new TextBox();
            txtTensach = new TextBox();
            txtnamxuatban = new TextBox();
            txtSoluong = new TextBox();
            txtTacgia = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnsua = new Button();
            button2 = new Button();
            btnhuy = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 195);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sách";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 275);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 195);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Năm xuất bản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 272);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 104);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã sách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(596, 277);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 6;
            label7.Text = "Tác giả";
            // 
            // txtMasach
            // 
            txtMasach.Location = new Point(200, 105);
            txtMasach.Name = "txtMasach";
            txtMasach.Size = new Size(162, 27);
            txtMasach.TabIndex = 7;
            // 
            // txtMaloai
            // 
            txtMaloai.Location = new Point(550, 104);
            txtMaloai.Name = "txtMaloai";
            txtMaloai.Size = new Size(162, 27);
            txtMaloai.TabIndex = 8;
            // 
            // txtTensach
            // 
            txtTensach.Location = new Point(200, 188);
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(162, 27);
            txtTensach.TabIndex = 9;
            // 
            // txtnamxuatban
            // 
            txtnamxuatban.Location = new Point(550, 192);
            txtnamxuatban.Name = "txtnamxuatban";
            txtnamxuatban.Size = new Size(162, 27);
            txtnamxuatban.TabIndex = 10;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(407, 272);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(162, 27);
            txtSoluong.TabIndex = 11;
            // 
            // txtTacgia
            // 
            txtTacgia.Location = new Point(667, 272);
            txtTacgia.Name = "txtTacgia";
            txtTacgia.Size = new Size(162, 27);
            txtTacgia.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(138, 272);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(159, 353);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 14;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(640, 353);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(395, 353);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 16;
            btnhuy.Text = "Hủy";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(345, 26);
            label8.Name = "label8";
            label8.Size = new Size(264, 41);
            label8.TabIndex = 17;
            label8.Text = "Chi tiết sản phẩm";
            // 
            // formChitTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 450);
            Controls.Add(label8);
            Controls.Add(btnhuy);
            Controls.Add(button2);
            Controls.Add(btnsua);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtTacgia);
            Controls.Add(txtSoluong);
            Controls.Add(txtnamxuatban);
            Controls.Add(txtTensach);
            Controls.Add(txtMaloai);
            Controls.Add(txtMasach);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formChitTiet";
            Text = "formChitTiet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMasach;
        private TextBox txtMaloai;
        private TextBox txtTensach;
        private TextBox txtnamxuatban;
        private TextBox txtSoluong;
        private TextBox txtTacgia;
        private DateTimePicker dateTimePicker1;
        private Button btnsua;
        private Button button2;
        private Button btnhuy;
        private Label label8;
    }
}