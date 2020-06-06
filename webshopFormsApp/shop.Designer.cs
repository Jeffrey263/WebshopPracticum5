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
            this.yeet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yeet
            // 
            this.yeet.AutoSize = true;
            this.yeet.Location = new System.Drawing.Point(367, 201);
            this.yeet.Name = "yeet";
            this.yeet.Size = new System.Drawing.Size(56, 17);
            this.yeet.TabIndex = 0;
            this.yeet.Text = "Y E E T";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yeet);
            this.Name = "Shop";
            this.Text = "shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yeet;
    }
}