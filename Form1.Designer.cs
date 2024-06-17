namespace CSharp_DangKiMonHoc
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.cbxNienkhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.clbMonhoc = new System.Windows.Forms.CheckedListBox();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(261, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÍ MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỌ VÀ TÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIÊN KHÓA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LÓP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HỌC KỲ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MÔN HỌC";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(310, 103);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 20);
            this.txtMSSV.TabIndex = 7;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(310, 139);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(100, 20);
            this.txtHovaten.TabIndex = 8;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(247, 244);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(28, 17);
            this.rad1.TabIndex = 11;
            this.rad1.TabStop = true;
            this.rad1.Text = "I";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(361, 244);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(31, 17);
            this.rad2.TabIndex = 12;
            this.rad2.TabStop = true;
            this.rad2.Text = "II";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(493, 244);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(34, 17);
            this.rad3.TabIndex = 13;
            this.rad3.TabStop = true;
            this.rad3.Text = "III";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(616, 246);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(35, 17);
            this.rad4.TabIndex = 14;
            this.rad4.TabStop = true;
            this.rad4.Text = "IV";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // cbxNienkhoa
            // 
            this.cbxNienkhoa.FormattingEnabled = true;
            this.cbxNienkhoa.Location = new System.Drawing.Point(310, 173);
            this.cbxNienkhoa.Name = "cbxNienkhoa";
            this.cbxNienkhoa.Size = new System.Drawing.Size(171, 21);
            this.cbxNienkhoa.TabIndex = 15;
            this.cbxNienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbxNienkhoa_SelectedIndexChanged);
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(310, 209);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(171, 21);
            this.cbxLop.TabIndex = 16;
            // 
            // clbMonhoc
            // 
            this.clbMonhoc.FormattingEnabled = true;
            this.clbMonhoc.Items.AddRange(new object[] {
            "LTWIN",
            "LT Internet",
            "Mạng máy tính",
            "UML"});
            this.clbMonhoc.Location = new System.Drawing.Point(251, 288);
            this.clbMonhoc.Name = "clbMonhoc";
            this.clbMonhoc.Size = new System.Drawing.Size(177, 79);
            this.clbMonhoc.TabIndex = 17;
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(161, 404);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(113, 50);
            this.btnDangki.TabIndex = 18;
            this.btnDangki.Text = "ĐĂNG KÍ";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(520, 404);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 50);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(337, 404);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 50);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.clbMonhoc);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxNienkhoa);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.ComboBox cbxNienkhoa;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.CheckedListBox clbMonhoc;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
    }
}

