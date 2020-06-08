namespace webshopFormsApp
{
    partial class NewOrder
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
            this.orderProducts = new System.Windows.Forms.ListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SendOrder = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.alertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderProducts
            // 
            this.orderProducts.FormattingEnabled = true;
            this.orderProducts.ItemHeight = 16;
            this.orderProducts.Location = new System.Drawing.Point(24, 21);
            this.orderProducts.Name = "orderProducts";
            this.orderProducts.Size = new System.Drawing.Size(334, 260);
            this.orderProducts.TabIndex = 0;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(21, 306);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 17);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total: ";
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel.Location = new System.Drawing.Point(24, 395);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(149, 34);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SendOrder
            // 
            this.SendOrder.Location = new System.Drawing.Point(209, 395);
            this.SendOrder.Name = "SendOrder";
            this.SendOrder.Size = new System.Drawing.Size(149, 34);
            this.SendOrder.TabIndex = 3;
            this.SendOrder.Text = "send order";
            this.SendOrder.UseVisualStyleBackColor = true;
            this.SendOrder.Click += new System.EventHandler(this.SendOrder_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(21, 347);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(104, 17);
            this.balanceLabel.TabIndex = 4;
            this.balanceLabel.Text = "Your balance:  ";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.alertLabel.Location = new System.Drawing.Point(21, 445);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(66, 17);
            this.alertLabel.TabIndex = 5;
            this.alertLabel.Text = "***alert***";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 482);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.SendOrder);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderProducts);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderProducts;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button SendOrder;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label alertLabel;
    }
}