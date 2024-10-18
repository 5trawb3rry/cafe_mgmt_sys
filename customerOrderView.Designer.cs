namespace dbproject
{
    partial class customerOrderView
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
            customerMenuView = new DataGridView();
            label1 = new Label();
            itemChosen = new NumericUpDown();
            label6 = new Label();
            addToCart = new Button();
            button1 = new Button();
            removeFromCart = new Button();
            getPayment = new TextBox();
            label2 = new Label();
            label3 = new Label();
            getCustomerID = new NumericUpDown();
            label4 = new Label();
            priceGrid = new DataGridView();
            label5 = new Label();
            cart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customerMenuView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemChosen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getCustomerID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cart).BeginInit();
            SuspendLayout();
            // 
            // customerMenuView
            // 
            customerMenuView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerMenuView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            customerMenuView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerMenuView.Location = new Point(12, 52);
            customerMenuView.Name = "customerMenuView";
            customerMenuView.RowHeadersWidth = 51;
            customerMenuView.Size = new Size(507, 188);
            customerMenuView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(187, 161, 79);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 40);
            label1.TabIndex = 3;
            label1.Text = "Available Items:";
            label1.Click += label1_Click;
            // 
            // itemChosen
            // 
            itemChosen.Font = new Font("Cascadia Mono", 14F);
            itemChosen.Location = new Point(157, 257);
            itemChosen.Name = "itemChosen";
            itemChosen.Size = new Size(233, 35);
            itemChosen.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 14F);
            label6.ForeColor = Color.FromArgb(187, 161, 79);
            label6.Location = new Point(16, 257);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 41;
            label6.Text = "Item ID:";
            label6.Click += label6_Click;
            // 
            // addToCart
            // 
            addToCart.BackColor = Color.FromArgb(187, 161, 79);
            addToCart.FlatStyle = FlatStyle.Flat;
            addToCart.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addToCart.Location = new Point(16, 441);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(143, 32);
            addToCart.TabIndex = 45;
            addToCart.Text = "Add to cart";
            addToCart.UseVisualStyleBackColor = false;
            addToCart.Click += addToCart_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 161, 79);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(16, 479);
            button1.Name = "button1";
            button1.Size = new Size(143, 32);
            button1.TabIndex = 47;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // removeFromCart
            // 
            removeFromCart.BackColor = Color.FromArgb(187, 161, 79);
            removeFromCart.FlatStyle = FlatStyle.Flat;
            removeFromCart.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeFromCart.Location = new Point(165, 441);
            removeFromCart.Name = "removeFromCart";
            removeFromCart.Size = new Size(185, 32);
            removeFromCart.TabIndex = 48;
            removeFromCart.Text = "Remove from cart";
            removeFromCart.UseVisualStyleBackColor = false;
            removeFromCart.Click += removeFromCart_Click;
            // 
            // getPayment
            // 
            getPayment.Font = new Font("Cascadia Mono", 14F);
            getPayment.Location = new Point(157, 313);
            getPayment.Name = "getPayment";
            getPayment.Size = new Size(233, 35);
            getPayment.TabIndex = 50;
            getPayment.TextChanged += getPayment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 14F);
            label2.ForeColor = Color.FromArgb(187, 161, 79);
            label2.Location = new Point(16, 316);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 49;
            label2.Text = "Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 14F);
            label3.ForeColor = Color.FromArgb(187, 161, 79);
            label3.Location = new Point(16, 365);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 51;
            label3.Text = "Your ID:";
            // 
            // getCustomerID
            // 
            getCustomerID.Font = new Font("Cascadia Mono", 14F);
            getCustomerID.Location = new Point(157, 365);
            getCustomerID.Name = "getCustomerID";
            getCustomerID.Size = new Size(233, 35);
            getCustomerID.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(187, 161, 79);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(621, 167);
            label4.Name = "label4";
            label4.Size = new Size(125, 40);
            label4.TabIndex = 56;
            label4.Text = "Price:";
            // 
            // priceGrid
            // 
            priceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            priceGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            priceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            priceGrid.Location = new Point(621, 225);
            priceGrid.Name = "priceGrid";
            priceGrid.RowHeadersWidth = 51;
            priceGrid.Size = new Size(209, 67);
            priceGrid.TabIndex = 55;
            priceGrid.CellContentClick += priceGrid_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(187, 161, 79);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(465, 273);
            label5.Name = "label5";
            label5.Size = new Size(107, 40);
            label5.TabIndex = 54;
            label5.Text = "Cart:";
            // 
            // cart
            // 
            cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cart.Location = new Point(465, 316);
            cart.Name = "cart";
            cart.RowHeadersWidth = 51;
            cart.Size = new Size(365, 225);
            cart.TabIndex = 53;
            // 
            // customerOrderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 59, 59);
            ClientSize = new Size(842, 563);
            Controls.Add(label4);
            Controls.Add(priceGrid);
            Controls.Add(label5);
            Controls.Add(cart);
            Controls.Add(getCustomerID);
            Controls.Add(label3);
            Controls.Add(getPayment);
            Controls.Add(label2);
            Controls.Add(removeFromCart);
            Controls.Add(button1);
            Controls.Add(addToCart);
            Controls.Add(itemChosen);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(customerMenuView);
            Name = "customerOrderView";
            Text = "customerOrderView";
            Load += customerOrderView_Load;
            ((System.ComponentModel.ISupportInitialize)customerMenuView).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemChosen).EndInit();
            ((System.ComponentModel.ISupportInitialize)getCustomerID).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customerMenuView;
        private Label label1;
        private NumericUpDown itemChosen;
        private Label label6;
        private Button addToCart;
        private Button button1;
        private Button removeFromCart;
        private TextBox getPayment;
        private Label label2;
        private Label label3;
        private NumericUpDown getCustomerID;
        private Label label4;
        private DataGridView priceGrid;
        private Label label5;
        private DataGridView cart;
    }
}