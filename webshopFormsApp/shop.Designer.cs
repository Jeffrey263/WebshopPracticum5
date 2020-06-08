namespace webshopFormsApp
{
    partial class Shop
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
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.basketBox = new System.Windows.Forms.ListBox();
            this.productPrice = new System.Windows.Forms.Label();
            this.ProductDesc = new System.Windows.Forms.Label();
            this.addToBasket = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.removeSelected = new System.Windows.Forms.Button();
            this.basketAlert = new System.Windows.Forms.Label();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.Location = new System.Drawing.Point(17, 24);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(94, 20);
            this.welcomeMessage.TabIndex = 0;
            this.welcomeMessage.Text = "welcome: ";
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.ItemHeight = 16;
            this.productsBox.Location = new System.Drawing.Point(18, 74);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(361, 484);
            this.productsBox.TabIndex = 1;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // basketBox
            // 
            this.basketBox.FormattingEnabled = true;
            this.basketBox.ItemHeight = 16;
            this.basketBox.Location = new System.Drawing.Point(414, 314);
            this.basketBox.Name = "basketBox";
            this.basketBox.Size = new System.Drawing.Size(361, 244);
            this.basketBox.TabIndex = 2;
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Location = new System.Drawing.Point(271, 46);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(64, 17);
            this.productPrice.TabIndex = 5;
            this.productPrice.Text = "***prijs***";
            // 
            // ProductDesc
            // 
            this.ProductDesc.AutoSize = true;
            this.ProductDesc.Location = new System.Drawing.Point(16, 86);
            this.ProductDesc.Name = "ProductDesc";
            this.ProductDesc.Size = new System.Drawing.Size(116, 17);
            this.ProductDesc.TabIndex = 6;
            this.ProductDesc.Text = "***omschrijving***";
            // 
            // addToBasket
            // 
            this.addToBasket.Location = new System.Drawing.Point(146, 144);
            this.addToBasket.Name = "addToBasket";
            this.addToBasket.Size = new System.Drawing.Size(215, 23);
            this.addToBasket.TabIndex = 7;
            this.addToBasket.Text = "Add  to basket";
            this.addToBasket.UseVisualStyleBackColor = true;
            this.addToBasket.Click += new System.EventHandler(this.addToBasketPressed);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(6, 144);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 22);
            this.quantity.TabIndex = 8;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productName);
            this.groupBox1.Controls.Add(this.addToBasket);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.productPrice);
            this.groupBox1.Controls.Add(this.ProductDesc);
            this.groupBox1.Location = new System.Drawing.Point(414, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(16, 46);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(73, 17);
            this.productName.TabIndex = 9;
            this.productName.Text = "***naam***";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bakset";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.balanceLabel);
            this.groupBox2.Controls.Add(this.OrdersBtn);
            this.groupBox2.Controls.Add(this.ShopBtn);
            this.groupBox2.Controls.Add(this.welcomeMessage);
            this.groupBox2.Location = new System.Drawing.Point(18, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 55);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Location = new System.Drawing.Point(576, 21);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(165, 23);
            this.OrdersBtn.TabIndex = 2;
            this.OrdersBtn.Text = "My Orders";
            this.OrdersBtn.UseVisualStyleBackColor = true;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(434, 21);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(123, 23);
            this.ShopBtn.TabIndex = 1;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(18, 575);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(361, 23);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // removeSelected
            // 
            this.removeSelected.ForeColor = System.Drawing.Color.DarkRed;
            this.removeSelected.Location = new System.Drawing.Point(414, 575);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(161, 23);
            this.removeSelected.TabIndex = 12;
            this.removeSelected.Text = "Clear Basket";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // basketAlert
            // 
            this.basketAlert.AutoSize = true;
            this.basketAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.basketAlert.Location = new System.Drawing.Point(411, 601);
            this.basketAlert.Name = "basketAlert";
            this.basketAlert.Size = new System.Drawing.Size(66, 17);
            this.basketAlert.TabIndex = 10;
            this.basketAlert.Text = "***alert***";
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Location = new System.Drawing.Point(614, 575);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(161, 23);
            this.PlaceOrder.TabIndex = 13;
            this.PlaceOrder.Text = "Place order";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(221, 24);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(86, 20);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "balance: ";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.PlaceOrder);
            this.Controls.Add(this.basketAlert);
            this.Controls.Add(this.removeSelected);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.basketBox);
            this.Controls.Add(this.productsBox);
            this.Name = "Shop";
            this.Text = "shop";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.ListBox basketBox;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label ProductDesc;
        private System.Windows.Forms.Button addToBasket;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.Label basketAlert;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.Label balanceLabel;
    }
}