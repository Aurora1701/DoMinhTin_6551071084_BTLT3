namespace WinFormsApp1
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
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            showLabel = new Label();
            showTextBox = new TextBox();
            showBtn = new Button();
            tiepBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(337, 78);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.Text = "hello";
            passwordTextBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            passwordLabel.Location = new Point(178, 85);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            passwordLabel.Click += label1_Click;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.Location = new Point(178, 115);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(61, 20);
            showLabel.TabIndex = 2;
            showLabel.Text = "Hien thi";
            // 
            // showTextBox
            // 
            showTextBox.Location = new Point(337, 115);
            showTextBox.Name = "showTextBox";
            showTextBox.Size = new Size(125, 27);
            showTextBox.TabIndex = 3;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(93, 234);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(94, 29);
            showBtn.TabIndex = 4;
            showBtn.Text = "Hien thi";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // tiepBtn
            // 
            tiepBtn.Location = new Point(296, 234);
            tiepBtn.Name = "tiepBtn";
            tiepBtn.Size = new Size(94, 29);
            tiepBtn.TabIndex = 5;
            tiepBtn.Text = "Tiep";
            tiepBtn.UseVisualStyleBackColor = true;
            tiepBtn.Click += tiepBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(509, 234);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Dong";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(tiepBtn);
            Controls.Add(showBtn);
            Controls.Add(showTextBox);
            Controls.Add(showLabel);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Name = "Form1";
            Text = "Hello";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Label showLabel;
        private TextBox showTextBox;
        private Button showBtn;
        private Button tiepBtn;
        private Button closeBtn;
    }
}
