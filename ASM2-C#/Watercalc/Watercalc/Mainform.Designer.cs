namespace Watercalc
{
    partial class Main_interface
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
            btn_history = new Button();
            btn_cost = new Button();
            btn_night = new Button();
            btn_h = new Button();
            btn_p = new Button();
            btn_a = new Button();
            btn_b = new Button();
            label1 = new Label();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_history
            // 
            btn_history.Location = new Point(1, 0);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(145, 224);
            btn_history.TabIndex = 0;
            btn_history.Text = "History";
            btn_history.UseVisualStyleBackColor = true;
            btn_history.Click += btn_history_Click;
            // 
            // btn_cost
            // 
            btn_cost.Location = new Point(1, 219);
            btn_cost.Name = "btn_cost";
            btn_cost.Size = new Size(145, 264);
            btn_cost.TabIndex = 1;
            btn_cost.Text = "Cost";
            btn_cost.UseVisualStyleBackColor = true;
            btn_cost.Click += btn_cost_Click;
            // 
            // btn_night
            // 
            btn_night.AutoSize = true;
            btn_night.Location = new Point(1, 477);
            btn_night.Name = "btn_night";
            btn_night.Size = new Size(145, 154);
            btn_night.TabIndex = 2;
            btn_night.Text = "Night Mode";
            btn_night.UseVisualStyleBackColor = true;
            btn_night.Click += btn_night_Click;
            // 
            // btn_h
            // 
            btn_h.Location = new Point(180, 254);
            btn_h.Name = "btn_h";
            btn_h.Size = new Size(198, 195);
            btn_h.TabIndex = 3;
            btn_h.Text = "House Hold";
            btn_h.UseVisualStyleBackColor = true;
            btn_h.Click += btn_h_Click;
            // 
            // btn_p
            // 
            btn_p.Location = new Point(672, 254);
            btn_p.Name = "btn_p";
            btn_p.Size = new Size(198, 195);
            btn_p.TabIndex = 4;
            btn_p.Text = " Production units";
            btn_p.UseVisualStyleBackColor = true;
            btn_p.Click += btn_p_Click;
            // 
            // btn_a
            // 
            btn_a.Location = new Point(423, 254);
            btn_a.Name = "btn_a";
            btn_a.Size = new Size(198, 195);
            btn_a.TabIndex = 5;
            btn_a.Text = "Administrative agency or public services";
            btn_a.UseVisualStyleBackColor = true;
            btn_a.Click += btn_a_Click;
            // 
            // btn_b
            // 
            btn_b.Location = new Point(914, 254);
            btn_b.Name = "btn_b";
            btn_b.Size = new Size(198, 195);
            btn_b.TabIndex = 6;
            btn_b.Text = "Business services";
            btn_b.UseVisualStyleBackColor = true;
            btn_b.Click += btn_b_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 93);
            label1.Name = "label1";
            label1.Size = new Size(466, 44);
            label1.TabIndex = 7;
            label1.Text = "Water Bill Calculator";
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(914, 512);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(198, 84);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Main_interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 628);
            Controls.Add(btn_exit);
            Controls.Add(label1);
            Controls.Add(btn_b);
            Controls.Add(btn_a);
            Controls.Add(btn_p);
            Controls.Add(btn_h);
            Controls.Add(btn_night);
            Controls.Add(btn_cost);
            Controls.Add(btn_history);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main_interface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "-";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_history;
        private Button btn_cost;
        private Button btn_night;
        private Button btn_h;
        private Button btn_p;
        private Button btn_a;
        private Button btn_b;
        private Label label1;
        private Button btn_exit;
    }
}
