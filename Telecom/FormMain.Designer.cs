namespace TelecomView
{
    partial class FormMain
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
            this.button_client = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.button_service = new System.Windows.Forms.Button();
            this.button_tariff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_client
            // 
            this.button_client.Location = new System.Drawing.Point(12, 12);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(185, 40);
            this.button_client.TabIndex = 0;
            this.button_client.Text = "Клиенты";
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // button_order
            // 
            this.button_order.Location = new System.Drawing.Point(12, 58);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(185, 40);
            this.button_order.TabIndex = 1;
            this.button_order.Text = "Заказы";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // button_service
            // 
            this.button_service.Location = new System.Drawing.Point(12, 104);
            this.button_service.Name = "button_service";
            this.button_service.Size = new System.Drawing.Size(185, 40);
            this.button_service.TabIndex = 2;
            this.button_service.Text = "Услуги";
            this.button_service.UseVisualStyleBackColor = true;
            this.button_service.Click += new System.EventHandler(this.button_service_Click);
            // 
            // button_tariff
            // 
            this.button_tariff.Location = new System.Drawing.Point(12, 150);
            this.button_tariff.Name = "button_tariff";
            this.button_tariff.Size = new System.Drawing.Size(185, 40);
            this.button_tariff.TabIndex = 3;
            this.button_tariff.Text = "Тарифы";
            this.button_tariff.UseVisualStyleBackColor = true;
            this.button_tariff.Click += new System.EventHandler(this.button_tariff_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 244);
            this.Controls.Add(this.button_tariff);
            this.Controls.Add(this.button_service);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_client);
            this.Name = "FormMain";
            this.Text = "Телекоммуникационная фирма";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_client;
        private Button button_order;
        private Button button_service;
        private Button button_tariff;
    }
}