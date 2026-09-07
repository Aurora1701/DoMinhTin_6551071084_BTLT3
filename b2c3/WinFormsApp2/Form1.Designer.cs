namespace WinFormsApp2
{
    partial class frmSimpleEvent
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
            btn_clickMe = new Button();
            SuspendLayout();
            // 
            // btn_clickMe
            // 
            btn_clickMe.BackgroundImageLayout = ImageLayout.None;
            btn_clickMe.FlatAppearance.BorderColor = Color.Cyan;
            btn_clickMe.FlatAppearance.BorderSize = 5;
            btn_clickMe.FlatStyle = FlatStyle.Flat;
            btn_clickMe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_clickMe.ForeColor = Color.Red;
            btn_clickMe.Location = new Point(251, 114);
            btn_clickMe.Name = "btn_clickMe";
            btn_clickMe.Size = new Size(378, 193);
            btn_clickMe.TabIndex = 0;
            btn_clickMe.Text = "CLICK ME";
            btn_clickMe.UseVisualStyleBackColor = true;
            btn_clickMe.Click += btn_clickMe_Click;
            // 
            // frmSimpleEvent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(900, 450);
            Controls.Add(btn_clickMe);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "frmSimpleEvent";
            Text = "Simple Event Example";
            Load += frmSimpleEvent_Load;
            Click += frmSimpleEvent_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_clickMe;
    }
}
