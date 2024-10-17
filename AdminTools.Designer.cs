namespace dbproject
{
    partial class AdminTools
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            userDataGridView = new DataGridView();
            label3 = new Label();
            staffDataGridView = new DataGridView();
            label4 = new Label();
            invDataView = new DataGridView();
            addFoodButton = new Button();
            removeFood = new Button();
            addStaffButton = new Button();
            removeStaff = new Button();
            seeOrders = new Button();
            revenue = new Button();
            inStockOrders = new Button();
            paymentDetails = new Button();
            hughrev = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invDataView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 161, 79);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 719);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(187, 161, 79);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(253, 21);
            label1.Name = "label1";
            label1.Size = new Size(323, 40);
            label1.TabIndex = 1;
            label1.Text = "Admin Tools - CMS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(187, 161, 79);
            label2.Location = new Point(253, 91);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 2;
            label2.Text = "User Data:";
            label2.Click += label2_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            userDataGridView.Location = new Point(253, 135);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 51;
            userDataGridView.Size = new Size(355, 162);
            userDataGridView.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(187, 161, 79);
            label3.Location = new Point(253, 331);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 4;
            label3.Text = "Staff Data:";
            // 
            // staffDataGridView
            // 
            staffDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            staffDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffDataGridView.Location = new Point(253, 378);
            staffDataGridView.Name = "staffDataGridView";
            staffDataGridView.RowHeadersWidth = 51;
            staffDataGridView.Size = new Size(355, 162);
            staffDataGridView.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(187, 161, 79);
            label4.Location = new Point(659, 91);
            label4.Name = "label4";
            label4.Size = new Size(143, 30);
            label4.TabIndex = 6;
            label4.Text = "Inventory:";
            // 
            // invDataView
            // 
            invDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            invDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            invDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Cascadia Code", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            invDataView.DefaultCellStyle = dataGridViewCellStyle4;
            invDataView.Location = new Point(659, 135);
            invDataView.Name = "invDataView";
            invDataView.RowHeadersWidth = 51;
            invDataView.Size = new Size(598, 405);
            invDataView.TabIndex = 7;
            // 
            // addFoodButton
            // 
            addFoodButton.BackColor = Color.FromArgb(187, 161, 79);
            addFoodButton.FlatStyle = FlatStyle.Flat;
            addFoodButton.Font = new Font("Cascadia Code", 10F);
            addFoodButton.ForeColor = SystemColors.ActiveCaptionText;
            addFoodButton.Location = new Point(253, 580);
            addFoodButton.Name = "addFoodButton";
            addFoodButton.Size = new Size(110, 33);
            addFoodButton.TabIndex = 8;
            addFoodButton.Text = "Add food";
            addFoodButton.UseVisualStyleBackColor = false;
            addFoodButton.Click += addFoodButton_Click;
            // 
            // removeFood
            // 
            removeFood.BackColor = Color.FromArgb(187, 161, 79);
            removeFood.FlatStyle = FlatStyle.Flat;
            removeFood.Font = new Font("Cascadia Code", 10F);
            removeFood.ForeColor = SystemColors.ActiveCaptionText;
            removeFood.Location = new Point(383, 580);
            removeFood.Name = "removeFood";
            removeFood.Size = new Size(143, 33);
            removeFood.TabIndex = 9;
            removeFood.Text = "Remove Food";
            removeFood.UseVisualStyleBackColor = false;
            removeFood.Click += removeFood_Click;
            // 
            // addStaffButton
            // 
            addStaffButton.BackColor = Color.FromArgb(187, 161, 79);
            addStaffButton.FlatStyle = FlatStyle.Flat;
            addStaffButton.Font = new Font("Cascadia Code", 10F);
            addStaffButton.ForeColor = SystemColors.ActiveCaptionText;
            addStaffButton.Location = new Point(253, 632);
            addStaffButton.Name = "addStaffButton";
            addStaffButton.Size = new Size(110, 33);
            addStaffButton.TabIndex = 10;
            addStaffButton.Text = "Add Staff";
            addStaffButton.UseVisualStyleBackColor = false;
            addStaffButton.Click += addStaffButton_Click;
            // 
            // removeStaff
            // 
            removeStaff.BackColor = Color.FromArgb(187, 161, 79);
            removeStaff.FlatStyle = FlatStyle.Flat;
            removeStaff.Font = new Font("Cascadia Code", 10F);
            removeStaff.ForeColor = SystemColors.ActiveCaptionText;
            removeStaff.Location = new Point(383, 632);
            removeStaff.Name = "removeStaff";
            removeStaff.Size = new Size(143, 33);
            removeStaff.TabIndex = 11;
            removeStaff.Text = "Remove Staff";
            removeStaff.UseVisualStyleBackColor = false;
            removeStaff.Click += removeStaff_Click;
            // 
            // seeOrders
            // 
            seeOrders.BackColor = Color.FromArgb(187, 161, 79);
            seeOrders.FlatStyle = FlatStyle.Flat;
            seeOrders.Font = new Font("Cascadia Code", 10F);
            seeOrders.ForeColor = SystemColors.ActiveCaptionText;
            seeOrders.Location = new Point(659, 571);
            seeOrders.Name = "seeOrders";
            seeOrders.Size = new Size(143, 33);
            seeOrders.TabIndex = 12;
            seeOrders.Text = "See Orders";
            seeOrders.UseVisualStyleBackColor = false;
            seeOrders.Click += seeOrders_Click;
            // 
            // revenue
            // 
            revenue.BackColor = Color.FromArgb(187, 161, 79);
            revenue.FlatStyle = FlatStyle.Flat;
            revenue.Font = new Font("Cascadia Code", 10F);
            revenue.ForeColor = SystemColors.ActiveCaptionText;
            revenue.Location = new Point(808, 571);
            revenue.Name = "revenue";
            revenue.Size = new Size(143, 33);
            revenue.TabIndex = 13;
            revenue.Text = "Revenue";
            revenue.UseVisualStyleBackColor = false;
            revenue.Click += revenue_Click;
            // 
            // inStockOrders
            // 
            inStockOrders.BackColor = Color.FromArgb(187, 161, 79);
            inStockOrders.FlatStyle = FlatStyle.Flat;
            inStockOrders.Font = new Font("Cascadia Code", 10F);
            inStockOrders.ForeColor = SystemColors.ActiveCaptionText;
            inStockOrders.Location = new Point(957, 571);
            inStockOrders.Name = "inStockOrders";
            inStockOrders.Size = new Size(162, 33);
            inStockOrders.TabIndex = 14;
            inStockOrders.Text = "in Stock Order";
            inStockOrders.UseVisualStyleBackColor = false;
            inStockOrders.Click += inStockOrders_Click;
            // 
            // paymentDetails
            // 
            paymentDetails.BackColor = Color.FromArgb(187, 161, 79);
            paymentDetails.FlatStyle = FlatStyle.Flat;
            paymentDetails.Font = new Font("Cascadia Code", 10F);
            paymentDetails.ForeColor = SystemColors.ActiveCaptionText;
            paymentDetails.Location = new Point(659, 610);
            paymentDetails.Name = "paymentDetails";
            paymentDetails.Size = new Size(176, 33);
            paymentDetails.TabIndex = 15;
            paymentDetails.Text = "Payment Details";
            paymentDetails.UseVisualStyleBackColor = false;
            paymentDetails.Click += paymentDetails_Click;
            // 
            // hughrev
            // 
            hughrev.BackColor = Color.FromArgb(187, 161, 79);
            hughrev.FlatStyle = FlatStyle.Flat;
            hughrev.Font = new Font("Cascadia Code", 10F);
            hughrev.ForeColor = SystemColors.ActiveCaptionText;
            hughrev.Location = new Point(841, 610);
            hughrev.Name = "hughrev";
            hughrev.Size = new Size(195, 33);
            hughrev.TabIndex = 16;
            hughrev.Text = "high rev customer";
            hughrev.UseVisualStyleBackColor = false;
            hughrev.Click += hughrev_Click;
            // 
            // AdminTools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 59, 59);
            ClientSize = new Size(1269, 719);
            Controls.Add(hughrev);
            Controls.Add(paymentDetails);
            Controls.Add(inStockOrders);
            Controls.Add(revenue);
            Controls.Add(seeOrders);
            Controls.Add(removeStaff);
            Controls.Add(addStaffButton);
            Controls.Add(removeFood);
            Controls.Add(addFoodButton);
            Controls.Add(invDataView);
            Controls.Add(label4);
            Controls.Add(staffDataGridView);
            Controls.Add(label3);
            Controls.Add(userDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AdminTools";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTools";
            Load += AdminTools_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)invDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridView userDataGridView;
        private Label label3;
        private DataGridView staffDataGridView;
        private Label label4;
        private DataGridView invDataView;
        private Button addFoodButton;
        private Button removeFood;
        private Button addStaffButton;
        private Button removeStaff;
        private Button seeOrders;
        private Button revenue;
        private Button inStockOrders;
        private Button paymentDetails;
        private Button hughrev;
    }
}