namespace Watercalc
{
    partial class calc
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
            txt_numMem = new TextBox();
            txt_lastIndex = new TextBox();
            txt_thisIndex = new TextBox();
            lbl_numMem = new Label();
            lbl_lastIndex = new Label();
            lbl_thisIndex = new Label();
            btn_calc = new Button();
            btn_clear = new Button();
            txt_result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_exit = new Button();
            label3 = new Label();
            txt_consum = new TextBox();
            label4 = new Label();
            btn_save = new Button();
            lbl_name = new Label();
            txt_name = new TextBox();
            SuspendLayout();
            // 
            // txt_numMem
            // 
            txt_numMem.Location = new Point(133, 198);
            txt_numMem.Multiline = true;
            txt_numMem.Name = "txt_numMem";
            txt_numMem.Size = new Size(261, 44);
            txt_numMem.TabIndex = 0;
            // 
            // txt_lastIndex
            // 
            txt_lastIndex.Location = new Point(133, 330);
            txt_lastIndex.Multiline = true;
            txt_lastIndex.Name = "txt_lastIndex";
            txt_lastIndex.Size = new Size(261, 47);
            txt_lastIndex.TabIndex = 1;
            // 
            // txt_thisIndex
            // 
            txt_thisIndex.Location = new Point(133, 466);
            txt_thisIndex.Multiline = true;
            txt_thisIndex.Name = "txt_thisIndex";
            txt_thisIndex.Size = new Size(261, 47);
            txt_thisIndex.TabIndex = 2;
            // 
            // lbl_numMem
            // 
            lbl_numMem.AutoSize = true;
            lbl_numMem.Location = new Point(9, 201);
            lbl_numMem.Name = "lbl_numMem";
            lbl_numMem.Size = new Size(118, 15);
            lbl_numMem.TabIndex = 3;
            lbl_numMem.Text = "Number of Members";
            // 
            // lbl_lastIndex
            // 
            lbl_lastIndex.AutoSize = true;
            lbl_lastIndex.Location = new Point(14, 330);
            lbl_lastIndex.Name = "lbl_lastIndex";
            lbl_lastIndex.Size = new Size(99, 15);
            lbl_lastIndex.TabIndex = 4;
            lbl_lastIndex.Text = "Last Month Index";
            // 
            // lbl_thisIndex
            // 
            lbl_thisIndex.AutoSize = true;
            lbl_thisIndex.Location = new Point(14, 466);
            lbl_thisIndex.Name = "lbl_thisIndex";
            lbl_thisIndex.Size = new Size(99, 15);
            lbl_thisIndex.TabIndex = 5;
            lbl_thisIndex.Text = "This Month Index";
            // 
            // btn_calc
            // 
            btn_calc.Location = new Point(545, 292);
            btn_calc.Name = "btn_calc";
            btn_calc.Size = new Size(108, 92);
            btn_calc.TabIndex = 6;
            btn_calc.Text = "Calculate";
            btn_calc.UseVisualStyleBackColor = true;
            btn_calc.Click += btn_calc_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(569, 396);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(61, 42);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_result
            // 
            txt_result.Cursor = Cursors.No;
            txt_result.Enabled = false;
            txt_result.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(765, 327);
            txt_result.Multiline = true;
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(305, 47);
            txt_result.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(682, 325);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 10;
            label1.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1076, 330);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "VND";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(983, 476);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(99, 72);
            btn_exit.TabIndex = 12;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(682, 408);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 13;
            label3.Text = "Consumption:";
            // 
            // txt_consum
            // 
            txt_consum.AllowDrop = true;
            txt_consum.Enabled = false;
            txt_consum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_consum.Location = new Point(783, 408);
            txt_consum.Name = "txt_consum";
            txt_consum.Size = new Size(242, 23);
            txt_consum.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1049, 412);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 15;
            label4.Text = "M3";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(834, 476);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(108, 72);
            btn_save.TabIndex = 16;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(492, 198);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(71, 30);
            lbl_name.TabIndex = 17;
            lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(569, 198);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(389, 48);
            txt_name.TabIndex = 18;
            // 
            // calc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 634);
            Controls.Add(txt_name);
            Controls.Add(lbl_name);
            Controls.Add(btn_save);
            Controls.Add(label4);
            Controls.Add(txt_consum);
            Controls.Add(label3);
            Controls.Add(btn_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_result);
            Controls.Add(btn_clear);
            Controls.Add(btn_calc);
            Controls.Add(lbl_thisIndex);
            Controls.Add(lbl_lastIndex);
            Controls.Add(lbl_numMem);
            Controls.Add(txt_thisIndex);
            Controls.Add(txt_lastIndex);
            Controls.Add(txt_numMem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "calc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt_numMem;
        private TextBox txt_lastIndex;
        private TextBox txt_thisIndex;
        private Label lbl_numMem;
        private Label lbl_lastIndex;
        private Label lbl_thisIndex;
        private Button btn_calc;
        private Button btn_clear;
        private TextBox txt_result;
        private Label label1;
        private Label label2;
        private Button btn_exit;
        private Label label3;
        private TextBox txt_consum;
        private Label label4;
        private Button btn_save;
        private Label lbl_name;
        private TextBox txt_name;
    }
}