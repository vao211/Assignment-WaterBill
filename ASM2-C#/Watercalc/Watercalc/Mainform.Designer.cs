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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_interface));
            btnHistory = new Button();
            btnCost = new Button();
            btnNight = new Button();
            btnH = new Button();
            btnP = new Button();
            btnA = new Button();
            btnB = new Button();
            label1 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.Location = new Point(1, 0);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(145, 224);
            btnHistory.TabIndex = 0;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnCost
            // 
            btnCost.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCost.Location = new Point(1, 219);
            btnCost.Name = "btnCost";
            btnCost.Size = new Size(145, 261);
            btnCost.TabIndex = 1;
            btnCost.Text = "Cost";
            btnCost.UseVisualStyleBackColor = true;
            btnCost.Click += btnCost_Click;
            // 
            // btnNight
            // 
            btnNight.AutoSize = true;
            btnNight.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNight.Location = new Point(1, 477);
            btnNight.Name = "btnNight";
            btnNight.Size = new Size(145, 154);
            btnNight.TabIndex = 2;
            btnNight.Text = "Night Mode";
            btnNight.UseVisualStyleBackColor = true;
            btnNight.Click += btnNight_Click;
            // 
            // btnH
            // 
            btnH.Location = new Point(180, 285);
            btnH.Name = "btnH";
            btnH.Size = new Size(198, 195);
            btnH.TabIndex = 3;
            btnH.Text = "House Hold";
            btnH.UseVisualStyleBackColor = true;
            btnH.Click += btnH_Click;
            // 
            // btnP
            // 
            btnP.Location = new Point(672, 285);
            btnP.Name = "btnP";
            btnP.Size = new Size(198, 195);
            btnP.TabIndex = 4;
            btnP.Text = " Production units";
            btnP.UseVisualStyleBackColor = true;
            btnP.Click += btnP_Click;
            // 
            // btnA
            // 
            btnA.Location = new Point(423, 285);
            btnA.Name = "btnA";
            btnA.Size = new Size(198, 195);
            btnA.TabIndex = 5;
            btnA.Text = "Administrative agency or public services";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(914, 285);
            btnB.Name = "btnB";
            btnB.Size = new Size(198, 195);
            btnB.TabIndex = 6;
            btnB.Text = "Business services";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
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
            // btnExit
            // 
            btnExit.Location = new Point(951, 543);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(198, 84);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Main_interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 628);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnP);
            Controls.Add(btnH);
            Controls.Add(btnNight);
            Controls.Add(btnCost);
            Controls.Add(btnHistory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main_interface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHistory;
        private Button btnCost;
        private Button btnNight;
        private Button btnH;
        private Button btnP;
        private Button btnA;
        private Button btnB;
        private Label label1;
        private Button btnExit;
    }
}
