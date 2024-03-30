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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calc));
            txtNumMem = new TextBox();
            txtLastIndex = new TextBox();
            txtThisIndex = new TextBox();
            lbl_numMem = new Label();
            lbl_lastIndex = new Label();
            lbl_thisIndex = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            label3 = new Label();
            txtConsum = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            lbl_name = new Label();
            txtName = new TextBox();
            lbl_type = new Label();
            SuspendLayout();
            // 
            // txtNumMem
            // 
            txtNumMem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumMem.Location = new Point(284, 279);
            txtNumMem.Multiline = true;
            txtNumMem.Name = "txtNumMem";
            txtNumMem.Size = new Size(68, 33);
            txtNumMem.TabIndex = 0;
            // 
            // txtLastIndex
            // 
            txtLastIndex.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLastIndex.Location = new Point(284, 348);
            txtLastIndex.Multiline = true;
            txtLastIndex.Name = "txtLastIndex";
            txtLastIndex.Size = new Size(261, 47);
            txtLastIndex.TabIndex = 1;
            // 
            // txtThisIndex
            // 
            txtThisIndex.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThisIndex.Location = new Point(284, 441);
            txtThisIndex.Multiline = true;
            txtThisIndex.Name = "txtThisIndex";
            txtThisIndex.Size = new Size(261, 47);
            txtThisIndex.TabIndex = 2;
            // 
            // lbl_numMem
            // 
            lbl_numMem.AutoSize = true;
            lbl_numMem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_numMem.Location = new Point(96, 279);
            lbl_numMem.Name = "lbl_numMem";
            lbl_numMem.Size = new Size(168, 21);
            lbl_numMem.TabIndex = 3;
            lbl_numMem.Text = "Number of Members";
            // 
            // lbl_lastIndex
            // 
            lbl_lastIndex.AutoSize = true;
            lbl_lastIndex.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_lastIndex.Location = new Point(122, 360);
            lbl_lastIndex.Name = "lbl_lastIndex";
            lbl_lastIndex.Size = new Size(142, 21);
            lbl_lastIndex.TabIndex = 4;
            lbl_lastIndex.Text = "Last Month Index";
            // 
            // lbl_thisIndex
            // 
            lbl_thisIndex.AutoSize = true;
            lbl_thisIndex.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_thisIndex.Location = new Point(122, 439);
            lbl_thisIndex.Name = "lbl_thisIndex";
            lbl_thisIndex.Size = new Size(143, 21);
            lbl_thisIndex.TabIndex = 5;
            lbl_thisIndex.Text = "This Month Index";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(632, 348);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(93, 77);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(649, 431);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 42);
            btnClear.TabIndex = 7;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtResult
            // 
            txtResult.Cursor = Cursors.No;
            txtResult.Enabled = false;
            txtResult.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(884, 334);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(289, 47);
            txtResult.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(817, 342);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 10;
            label1.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1179, 348);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "VND";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1219, 544);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(136, 97);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(761, 452);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 13;
            label3.Text = "Consumption:";
            // 
            // txtConsum
            // 
            txtConsum.AllowDrop = true;
            txtConsum.Enabled = false;
            txtConsum.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConsum.Location = new Point(884, 439);
            txtConsum.Multiline = true;
            txtConsum.Name = "txtConsum";
            txtConsum.Size = new Size(289, 47);
            txtConsum.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1179, 457);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 15;
            label4.Text = "M3";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(650, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(60, 42);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(413, 161);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(71, 30);
            lbl_name.TabIndex = 17;
            lbl_name.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(490, 153);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 38);
            txtName.TabIndex = 18;
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_type.Location = new Point(8, 8);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(0, 20);
            lbl_type.TabIndex = 19;
            // 
            // calc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 643);
            Controls.Add(lbl_type);
            Controls.Add(txtName);
            Controls.Add(lbl_name);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txtConsum);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lbl_thisIndex);
            Controls.Add(lbl_lastIndex);
            Controls.Add(lbl_numMem);
            Controls.Add(txtThisIndex);
            Controls.Add(txtLastIndex);
            Controls.Add(txtNumMem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "calc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += calc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtNumMem;
        private TextBox txtLastIndex;
        private TextBox txtThisIndex;
        private Label lbl_numMem;
        private Label lbl_lastIndex;
        private Label lbl_thisIndex;
        private Button btnCalc;
        private Button btnClear;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private Label label3;
        private TextBox txtConsum;
        private Label label4;
        private Button btnSave;
        private Label lbl_name;
        private TextBox txtName;
        private Label lbl_type;
    }
}