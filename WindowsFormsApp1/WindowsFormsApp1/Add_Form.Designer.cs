namespace WindowsFormsApp1
{
    partial class Add_Form
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Type_comboBox1 = new System.Windows.Forms.ComboBox();
            this.name_textBox3 = new System.Windows.Forms.TextBox();
            this.id_textBox2 = new System.Windows.Forms.TextBox();
            this.price_textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_seller_textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(3, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Type_comboBox1
            // 
            this.Type_comboBox1.FormattingEnabled = true;
            this.Type_comboBox1.Items.AddRange(new object[] {
            "Микрофон",
            "Монитор ",
            "Ноутбук ",
            "Телефон"});
            this.Type_comboBox1.Location = new System.Drawing.Point(251, 173);
            this.Type_comboBox1.Name = "Type_comboBox1";
            this.Type_comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Type_comboBox1.Size = new System.Drawing.Size(139, 21);
            this.Type_comboBox1.Sorted = true;
            this.Type_comboBox1.TabIndex = 9;
            // 
            // name_textBox3
            // 
            this.name_textBox3.Location = new System.Drawing.Point(251, 274);
            this.name_textBox3.Multiline = true;
            this.name_textBox3.Name = "name_textBox3";
            this.name_textBox3.Size = new System.Drawing.Size(139, 20);
            this.name_textBox3.TabIndex = 10;
            // 
            // id_textBox2
            // 
            this.id_textBox2.Location = new System.Drawing.Point(251, 224);
            this.id_textBox2.Multiline = true;
            this.id_textBox2.Name = "id_textBox2";
            this.id_textBox2.Size = new System.Drawing.Size(139, 20);
            this.id_textBox2.TabIndex = 11;
            // 
            // price_textBox4
            // 
            this.price_textBox4.Location = new System.Drawing.Point(251, 331);
            this.price_textBox4.Multiline = true;
            this.price_textBox4.Name = "price_textBox4";
            this.price_textBox4.Size = new System.Drawing.Size(139, 20);
            this.price_textBox4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Тип товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "id товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(164, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Цена";
            // 
            // id_seller_textBox4
            // 
            this.id_seller_textBox4.Location = new System.Drawing.Point(267, 108);
            this.id_seller_textBox4.Name = "id_seller_textBox4";
            this.id_seller_textBox4.Size = new System.Drawing.Size(100, 20);
            this.id_seller_textBox4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(154, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID Продавца";
            // 
            // Add_button2
            // 
            this.Add_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button2.Location = new System.Drawing.Point(489, 253);
            this.Add_button2.Name = "Add_button2";
            this.Add_button2.Size = new System.Drawing.Size(157, 41);
            this.Add_button2.TabIndex = 22;
            this.Add_button2.Text = "Добавить товар";
            this.Add_button2.UseVisualStyleBackColor = true;
            this.Add_button2.Click += new System.EventHandler(this.Add_button2_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_seller_textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_textBox4);
            this.Controls.Add(this.id_textBox2);
            this.Controls.Add(this.name_textBox3);
            this.Controls.Add(this.Type_comboBox1);
            this.Controls.Add(this.Back_button);
            this.Name = "Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ComboBox Type_comboBox1;
        private System.Windows.Forms.TextBox name_textBox3;
        private System.Windows.Forms.TextBox id_textBox2;
        private System.Windows.Forms.TextBox price_textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_seller_textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_button2;
    }
}