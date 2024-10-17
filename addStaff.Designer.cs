namespace dbproject
{
    partial class addStaff
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
            goToAdmin = new Button();
            add = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            addStaffRole = new TextBox();
            addStaffName = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            addShift = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)addShift).BeginInit();
            SuspendLayout();
            // 
            // goToAdmin
            // 
            goToAdmin.BackColor = Color.FromArgb(187, 161, 79);
            goToAdmin.FlatStyle = FlatStyle.Flat;
            goToAdmin.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goToAdmin.Location = new Point(376, 421);
            goToAdmin.Name = "goToAdmin";
            goToAdmin.Size = new Size(101, 32);
            goToAdmin.TabIndex = 36;
            goToAdmin.Text = "Admin";
            goToAdmin.UseVisualStyleBackColor = false;
            goToAdmin.Click += goToAdmin_Click;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(187, 161, 79);
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.Location = new Point(247, 421);
            add.Name = "add";
            add.Size = new Size(112, 32);
            add.TabIndex = 35;
            add.Text = "Add Staff";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(187, 161, 79);
            panel4.Location = new Point(243, 522);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 12);
            panel4.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(187, 161, 79);
            panel3.Location = new Point(243, 540);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 12);
            panel3.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 161, 79);
            panel2.Location = new Point(242, 504);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 12);
            panel2.TabIndex = 32;
            // 
            // addStaffRole
            // 
            addStaffRole.Font = new Font("Cascadia Mono", 14F);
            addStaffRole.Location = new Point(444, 152);
            addStaffRole.Name = "addStaffRole";
            addStaffRole.Size = new Size(233, 35);
            addStaffRole.TabIndex = 28;
            // 
            // addStaffName
            // 
            addStaffName.Font = new Font("Cascadia Mono", 14F);
            addStaffName.Location = new Point(444, 94);
            addStaffName.Name = "addStaffName";
            addStaffName.Size = new Size(233, 35);
            addStaffName.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 14F);
            label6.ForeColor = Color.FromArgb(187, 161, 79);
            label6.Location = new Point(242, 202);
            label6.Name = "label6";
            label6.Size = new Size(210, 32);
            label6.TabIndex = 26;
            label6.Text = "Shift (hours):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 14F);
            label3.ForeColor = Color.FromArgb(187, 161, 79);
            label3.Location = new Point(243, 152);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 23;
            label3.Text = "Role:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 14F);
            label2.ForeColor = Color.FromArgb(187, 161, 79);
            label2.Location = new Point(243, 97);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 22;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(187, 161, 79);
            label1.Location = new Point(243, 8);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 21;
            label1.Text = "Add Staff";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 161, 79);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 562);
            panel1.TabIndex = 20;
            // 
            // addShift
            // 
            addShift.Font = new Font("Cascadia Mono", 14F);
            addShift.Location = new Point(444, 202);
            addShift.Name = "addShift";
            addShift.Size = new Size(233, 35);
            addShift.TabIndex = 31;
            // 
            // addStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 59, 59);
            ClientSize = new Size(842, 563);
            Controls.Add(goToAdmin);
            Controls.Add(add);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(addShift);
            Controls.Add(addStaffRole);
            Controls.Add(addStaffName);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "addStaff";
            Text = "addStaff";
            Load += addStaff_Load;
            ((System.ComponentModel.ISupportInitialize)addShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goToAdmin;
        private Button add;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox addStaffRole;
        private TextBox addStaffName;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private NumericUpDown addShift;
    }
}