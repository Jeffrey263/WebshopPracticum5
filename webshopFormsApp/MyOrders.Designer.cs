namespace webshopFormsApp
{
    partial class MyOrders
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.ordersBox = new System.Windows.Forms.ListBox();
            this.selectedBox = new System.Windows.Forms.ListBox();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.balanceLabel);
            this.groupBox2.Controls.Add(this.OrdersBtn);
            this.groupBox2.Controls.Add(this.ShopBtn);
            this.groupBox2.Controls.Add(this.welcomeMessage);
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 55);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
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
            // OrdersBtn
            // 
            this.OrdersBtn.Location = new System.Drawing.Point(576, 21);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(165, 23);
            this.OrdersBtn.TabIndex = 2;
            this.OrdersBtn.Text = "My Orders";
            this.OrdersBtn.UseVisualStyleBackColor = true;
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(434, 21);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(123, 23);
            this.ShopBtn.TabIndex = 1;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
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
            // ordersBox
            // 
            this.ordersBox.FormattingEnabled = true;
            this.ordersBox.ItemHeight = 16;
            this.ordersBox.Location = new System.Drawing.Point(30, 121);
            this.ordersBox.Name = "ordersBox";
            this.ordersBox.Size = new System.Drawing.Size(307, 468);
            this.ordersBox.TabIndex = 13;
            this.ordersBox.SelectedIndexChanged += new System.EventHandler(this.ordersBox_SelectedIndexChanged);
            // 
            // selectedBox
            // 
            this.selectedBox.FormattingEnabled = true;
            this.selectedBox.ItemHeight = 16;
            this.selectedBox.Location = new System.Drawing.Point(464, 121);
            this.selectedBox.Name = "selectedBox";
            this.selectedBox.Size = new System.Drawing.Size(307, 420);
            this.selectedBox.TabIndex = 14;
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Location = new System.Drawing.Point(30, 98);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(71, 17);
            this.ordersLabel.TabIndex = 15;
            this.ordersLabel.Text = "My orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selected Order";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(461, 559);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(43, 17);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "total: ";
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 621);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordersLabel);
            this.Controls.Add(this.selectedBox);
            this.Controls.Add(this.ordersBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.ListBox ordersBox;
        private System.Windows.Forms.ListBox selectedBox;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalLabel;
    }
}