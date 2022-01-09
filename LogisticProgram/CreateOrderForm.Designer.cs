
namespace LogisticProgram
{
    partial class CreateOrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heigthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.myOrdersButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.createOrderButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.widthTextBox);
            this.panel1.Controls.Add(this.heigthTextBox);
            this.panel1.Controls.Add(this.lengthTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.weightTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(273, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 709);
            this.panel1.TabIndex = 0;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrderButton.Location = new System.Drawing.Point(347, 574);
            this.createOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(303, 49);
            this.createOrderButton.TabIndex = 13;
            this.createOrderButton.Text = "Сделать заказ";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(799, 450);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Высота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(447, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(113, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Длина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(879, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "Укажите длину (не более 80 см), ширину (не более 80 см), высоту (не более 60 см)." +
    "\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Напишите ваш адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Укажите вес товара (в килограммах):";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(27, 121);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(952, 37);
            this.nameTextBox.TabIndex = 1;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(368, 479);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthTextBox.Multiline = true;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(260, 37);
            this.widthTextBox.TabIndex = 6;
            // 
            // heigthTextBox
            // 
            this.heigthTextBox.Location = new System.Drawing.Point(719, 479);
            this.heigthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heigthTextBox.Multiline = true;
            this.heigthTextBox.Name = "heigthTextBox";
            this.heigthTextBox.Size = new System.Drawing.Size(260, 37);
            this.heigthTextBox.TabIndex = 5;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(32, 479);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthTextBox.Multiline = true;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(260, 37);
            this.lengthTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(27, 331);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(952, 37);
            this.addressTextBox.TabIndex = 3;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(27, 222);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(952, 37);
            this.weightTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название товара:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(16, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Создать заказ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.myOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myOrdersButton.Location = new System.Drawing.Point(16, 71);
            this.myOrdersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(249, 49);
            this.myOrdersButton.TabIndex = 2;
            this.myOrdersButton.Text = "Мои заказы";
            this.myOrdersButton.UseVisualStyleBackColor = false;
            this.myOrdersButton.Click += new System.EventHandler(this.myOrdersButton_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 738);
            this.Controls.Add(this.myOrdersButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateOrderForm";
            this.Text = "CreateOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heigthTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button myOrdersButton;
    }
}