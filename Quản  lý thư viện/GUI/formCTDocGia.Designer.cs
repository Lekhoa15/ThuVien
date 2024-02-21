namespace Quản__lý_thư_viện.GUI
{
    partial class formCTDocGia
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
            name1 = new Label();
            name2 = new Label();
            name3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            name4 = new Label();
            txtmadocgia = new TextBox();
            txttendocgia = new TextBox();
            txtsdt = new TextBox();
            txtdiachi = new TextBox();
            label1 = new Label();
            btnsua = new Button();
            btnhuy = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.Location = new Point(79, 89);
            name1.Name = "name1";
            name1.Size = new Size(84, 20);
            name1.TabIndex = 0;
            name1.Text = "Mã độc giả";
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.Location = new Point(79, 159);
            name2.Name = "name2";
            name2.Size = new Size(86, 20);
            name2.TabIndex = 1;
            name2.Text = "Tên độc giả";
            // 
            // name3
            // 
            name3.AutoSize = true;
            name3.Location = new Point(457, 89);
            name3.Name = "name3";
            name3.Size = new Size(36, 20);
            name3.TabIndex = 2;
            name3.Text = "SĐT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(526, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // name4
            // 
            name4.AutoSize = true;
            name4.Location = new Point(419, 167);
            name4.Name = "name4";
            name4.Size = new Size(74, 20);
            name4.TabIndex = 4;
            name4.Text = "Ngày sinh";
            // 
            // txtmadocgia
            // 
            txtmadocgia.Location = new Point(200, 86);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(125, 27);
            txtmadocgia.TabIndex = 5;
            // 
            // txttendocgia
            // 
            txttendocgia.Location = new Point(199, 164);
            txttendocgia.Name = "txttendocgia";
            txttendocgia.Size = new Size(183, 27);
            txttendocgia.TabIndex = 6;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(532, 93);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(244, 27);
            txtsdt.TabIndex = 7;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(200, 234);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(182, 27);
            txtdiachi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 234);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 9;
            label1.Text = "Địa chỉ";
            // 
            // btnsua
            // 
            btnsua.Location = new Point(95, 337);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 10;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += button1_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(353, 337);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 11;
            btnhuy.Text = "Hủy";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(615, 337);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 29);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // formCTDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(btnhuy);
            Controls.Add(btnsua);
            Controls.Add(label1);
            Controls.Add(txtdiachi);
            Controls.Add(txtsdt);
            Controls.Add(txttendocgia);
            Controls.Add(txtmadocgia);
            Controls.Add(name4);
            Controls.Add(dateTimePicker1);
            Controls.Add(name3);
            Controls.Add(name2);
            Controls.Add(name1);
            Name = "formCTDocGia";
            Text = "formCTDocGia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name1;
        private Label name2;
        private Label name3;
        private DateTimePicker dateTimePicker1;
        private Label name4;
        private TextBox txtmadocgia;
        private TextBox txttendocgia;
        private TextBox txtsdt;
        private TextBox txtdiachi;
        private Label label1;
        private Button btnsua;
        private Button btnhuy;
        private Button btnthoat;
    }
}