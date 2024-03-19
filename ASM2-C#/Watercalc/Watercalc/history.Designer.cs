namespace Watercalc
{
    partial class History
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
            btn_exit = new Button();
            txt_history = new TextBox();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(1193, 655);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(135, 122);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // txt_history
            // 
            txt_history.Enabled = false;
            txt_history.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_history.Location = new Point(14, 14);
            txt_history.Multiline = true;
            txt_history.Name = "txt_history";
            txt_history.Size = new Size(930, 766);
            txt_history.TabIndex = 1;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(951, 14);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(144, 71);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 784);
            Controls.Add(btn_clear);
            Controls.Add(txt_history);
            Controls.Add(btn_exit);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "history";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private TextBox txt_history;
        private Button btn_clear;
    }
}