
namespace LogisticProgram
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
            this.myOrdersButton = new System.Windows.Forms.Button();
            this.toCreateOrderForm = new System.Windows.Forms.Button();
            this.refreshOrders = new System.Windows.Forms.Button();
            this.myOrdersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.myOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myOrdersButton.Location = new System.Drawing.Point(12, 58);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(187, 40);
            this.myOrdersButton.TabIndex = 4;
            this.myOrdersButton.Text = "Мои заказы";
            this.myOrdersButton.UseVisualStyleBackColor = false;
            // 
            // toCreateOrderForm
            // 
            this.toCreateOrderForm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toCreateOrderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toCreateOrderForm.Location = new System.Drawing.Point(12, 12);
            this.toCreateOrderForm.Name = "toCreateOrderForm";
            this.toCreateOrderForm.Size = new System.Drawing.Size(187, 40);
            this.toCreateOrderForm.TabIndex = 3;
            this.toCreateOrderForm.Text = "Создать заказ";
            this.toCreateOrderForm.UseVisualStyleBackColor = false;
            this.toCreateOrderForm.Click += new System.EventHandler(this.toCreateOrderForm_Click);
            // 
            // refreshOrders
            // 
            this.refreshOrders.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.refreshOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshOrders.Location = new System.Drawing.Point(12, 104);
            this.refreshOrders.Name = "refreshOrders";
            this.refreshOrders.Size = new System.Drawing.Size(187, 40);
            this.refreshOrders.TabIndex = 6;
            this.refreshOrders.Text = "Обновить ленту";
            this.refreshOrders.UseVisualStyleBackColor = false;
            this.refreshOrders.Click += new System.EventHandler(this.refreshOrders_Click);
            // 
            // myOrdersTextBox
            // 
            this.myOrdersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myOrdersTextBox.Location = new System.Drawing.Point(280, 12);
            this.myOrdersTextBox.Multiline = true;
            this.myOrdersTextBox.Name = "myOrdersTextBox";
            this.myOrdersTextBox.ReadOnly = true;
            this.myOrdersTextBox.Size = new System.Drawing.Size(202, 35);
            this.myOrdersTextBox.TabIndex = 0;
            this.myOrdersTextBox.Text = "Ваши заказы:";
            this.myOrdersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 600);
            this.Controls.Add(this.myOrdersTextBox);
            this.Controls.Add(this.refreshOrders);
            this.Controls.Add(this.myOrdersButton);
            this.Controls.Add(this.toCreateOrderForm);
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myOrdersButton;
        private System.Windows.Forms.Button toCreateOrderForm;
        private System.Windows.Forms.Button refreshOrders;
        private System.Windows.Forms.TextBox myOrdersTextBox;
    }
}