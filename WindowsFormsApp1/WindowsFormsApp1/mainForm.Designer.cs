namespace WindowsFormsApp1
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Catalog_Prod_button = new System.Windows.Forms.Button();
            this.Add_Del_button = new System.Windows.Forms.Button();
            this.Hat = new System.Windows.Forms.Panel();
            this.Electro_Store = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.emeil = new System.Windows.Forms.Label();
            this.Nomber = new System.Windows.Forms.Label();
            this.Hat.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Catalog_Prod_button
            // 
            this.Catalog_Prod_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Catalog_Prod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Catalog_Prod_button.Location = new System.Drawing.Point(136, 171);
            this.Catalog_Prod_button.Name = "Catalog_Prod_button";
            this.Catalog_Prod_button.Size = new System.Drawing.Size(200, 100);
            this.Catalog_Prod_button.TabIndex = 0;
            this.Catalog_Prod_button.Text = "Каталог товаров";
            this.Catalog_Prod_button.UseVisualStyleBackColor = false;
            this.Catalog_Prod_button.Click += new System.EventHandler(this.Catalog_Prod_button_Click);
            // 
            // Add_Del_button
            // 
            this.Add_Del_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Add_Del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Del_button.Location = new System.Drawing.Point(440, 171);
            this.Add_Del_button.Name = "Add_Del_button";
            this.Add_Del_button.Size = new System.Drawing.Size(200, 100);
            this.Add_Del_button.TabIndex = 1;
            this.Add_Del_button.Text = "Добавить/Удалить товар";
            this.Add_Del_button.UseVisualStyleBackColor = false;
            this.Add_Del_button.Click += new System.EventHandler(this.Add_Delete_Click);
            // 
            // Hat
            // 
            this.Hat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.Hat.Controls.Add(this.Electro_Store);
            this.Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hat.Location = new System.Drawing.Point(0, 0);
            this.Hat.Name = "Hat";
            this.Hat.Size = new System.Drawing.Size(800, 69);
            this.Hat.TabIndex = 2;
            // 
            // Electro_Store
            // 
            this.Electro_Store.AllowDrop = true;
            this.Electro_Store.AutoSize = true;
            this.Electro_Store.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Electro_Store.Location = new System.Drawing.Point(287, 9);
            this.Electro_Store.Name = "Electro_Store";
            this.Electro_Store.Size = new System.Drawing.Size(183, 37);
            this.Electro_Store.TabIndex = 0;
            this.Electro_Store.Text = "ЭлектроStore";
            this.Electro_Store.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.Footer.Controls.Add(this.emeil);
            this.Footer.Controls.Add(this.Nomber);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 373);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(800, 77);
            this.Footer.TabIndex = 3;
            // 
            // emeil
            // 
            this.emeil.AutoSize = true;
            this.emeil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emeil.Location = new System.Drawing.Point(12, 50);
            this.emeil.Name = "emeil";
            this.emeil.Size = new System.Drawing.Size(388, 18);
            this.emeil.TabIndex = 5;
            this.emeil.Text = "Адресс электронной почты : vitanecaev373@gmail.com";
            // 
            // Nomber
            // 
            this.Nomber.AutoSize = true;
            this.Nomber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nomber.Location = new System.Drawing.Point(12, 21);
            this.Nomber.Name = "Nomber";
            this.Nomber.Size = new System.Drawing.Size(280, 17);
            this.Nomber.TabIndex = 4;
            this.Nomber.Text = "Телефон тех поддержки : +89677156781";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Hat);
            this.Controls.Add(this.Add_Del_button);
            this.Controls.Add(this.Catalog_Prod_button);
            this.Name = "mainForm";
            this.Text = "ЭлектроStore";
            this.Hat.ResumeLayout(false);
            this.Hat.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Catalog_Prod_button;
        private System.Windows.Forms.Button Add_Del_button;
        private System.Windows.Forms.Panel Hat;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Label Electro_Store;
        private System.Windows.Forms.Label Nomber;
        private System.Windows.Forms.Label emeil;
    }
}

