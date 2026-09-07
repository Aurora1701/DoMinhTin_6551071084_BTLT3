namespace WinFormsApp5
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
            lblNhapTen = new Label();
            gbColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            gbFont = new GroupBox();
            txtNhapTen = new TextBox();
            lblLapTrinh = new Label();
            txtLapTrinh = new TextBox();
            exitBtn = new Button();
            chkBold = new CheckBox();
            chkItalic = new CheckBox();
            chkUdl = new CheckBox();
            gbColor.SuspendLayout();
            gbFont.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.BackColor = SystemColors.ActiveCaptionText;
            lblNhapTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNhapTen.ForeColor = Color.DarkGreen;
            lblNhapTen.Location = new Point(74, 35);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(80, 20);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập Tên:";
            // 
            // gbColor
            // 
            gbColor.BackColor = Color.LightBlue;
            gbColor.Controls.Add(radBlack);
            gbColor.Controls.Add(radBlue);
            gbColor.Controls.Add(radGreen);
            gbColor.Controls.Add(radRed);
            gbColor.Location = new Point(92, 74);
            gbColor.Name = "gbColor";
            gbColor.Size = new Size(246, 222);
            gbColor.TabIndex = 1;
            gbColor.TabStop = false;
            gbColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(39, 172);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(39, 125);
            radBlue.Name = "radBlue";
            radBlue.RightToLeft = RightToLeft.No;
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(39, 81);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(39, 42);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // gbFont
            // 
            gbFont.BackColor = Color.PeachPuff;
            gbFont.Controls.Add(chkUdl);
            gbFont.Controls.Add(chkItalic);
            gbFont.Controls.Add(chkBold);
            gbFont.Location = new Point(393, 74);
            gbFont.Name = "gbFont";
            gbFont.Size = new Size(356, 222);
            gbFont.TabIndex = 2;
            gbFont.TabStop = false;
            gbFont.Text = "Font";
            gbFont.Enter += groupBox2_Enter;
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(161, 32);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(607, 27);
            txtNhapTen.TabIndex = 3;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLapTrinh.ForeColor = Color.Maroon;
            lblLapTrinh.Location = new Point(74, 348);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(105, 20);
            lblLapTrinh.TabIndex = 4;
            lblLapTrinh.Text = "Lập Trình Bởi:";
            // 
            // txtLapTrinh
            // 
            txtLapTrinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtLapTrinh.ForeColor = Color.Green;
            txtLapTrinh.Location = new Point(181, 332);
            txtLapTrinh.MinimumSize = new Size(358, 50);
            txtLapTrinh.Name = "txtLapTrinh";
            txtLapTrinh.Size = new Size(358, 50);
            txtLapTrinh.TabIndex = 5;
            txtLapTrinh.TextChanged += textBox2_TextChanged;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(603, 320);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(165, 76);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.DarkBlue;
            chkBold.Location = new Point(40, 46);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = Color.DarkBlue;
            chkItalic.Location = new Point(40, 82);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(133, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkUdl
            // 
            chkUdl.AutoSize = true;
            chkUdl.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            chkUdl.ForeColor = Color.DarkBlue;
            chkUdl.Location = new Point(40, 126);
            chkUdl.Name = "chkUdl";
            chkUdl.Size = new Size(105, 24);
            chkUdl.TabIndex = 2;
            chkUdl.Text = "Gạch Chân";
            chkUdl.UseVisualStyleBackColor = true;
            chkUdl.CheckedChanged += chkUdl_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(txtLapTrinh);
            Controls.Add(lblLapTrinh);
            Controls.Add(txtNhapTen);
            Controls.Add(gbFont);
            Controls.Add(gbColor);
            Controls.Add(lblNhapTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbColor.ResumeLayout(false);
            gbColor.PerformLayout();
            gbFont.ResumeLayout(false);
            gbFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private GroupBox gbColor;
        private GroupBox gbFont;
        private TextBox txtNhapTen;
        private Label lblLapTrinh;
        private TextBox txtLapTrinh;
        private Button exitBtn;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private CheckBox chkUdl;
    }
}
