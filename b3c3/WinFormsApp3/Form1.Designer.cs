namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHoTen = new Label();
            label1 = new Label();
            label2 = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.LightSkyBlue;
            lblHoTen.Location = new Point(0, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(801, 76);
            lblHoTen.TabIndex = 0;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 110);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ lót";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 143);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            label2.Click += label2_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(203, 107);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(530, 27);
            txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.Pink;
            txtTen.Location = new Point(203, 140);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(530, 27);
            txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(122, 249);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(118, 41);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(370, 249);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(118, 41);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(592, 249);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(117, 41);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(356, 326);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(162, 47);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Thoát Chương Trình";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button exitBtn;
    }
}
