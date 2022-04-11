
namespace TelecomView
{
    partial class FormOrder
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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameService = new System.Windows.Forms.TextBox();
            this.textBoxNameTariff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(222, 109);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(82, 22);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(310, 109);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(82, 22);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(158, 13);
            this.textBoxNameClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(240, 23);
            this.textBoxNameClient.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Клиент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Услуга:";
            // 
            // textBoxNameService
            // 
            this.textBoxNameService.Location = new System.Drawing.Point(158, 40);
            this.textBoxNameService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameService.Name = "textBoxNameService";
            this.textBoxNameService.Size = new System.Drawing.Size(240, 23);
            this.textBoxNameService.TabIndex = 15;
            // 
            // textBoxNameTariff
            // 
            this.textBoxNameTariff.Location = new System.Drawing.Point(158, 67);
            this.textBoxNameTariff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameTariff.Name = "textBoxNameTariff";
            this.textBoxNameTariff.Size = new System.Drawing.Size(240, 23);
            this.textBoxNameTariff.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Тариф:";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameTariff);
            this.Controls.Add(this.textBoxNameService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private TextBox textBoxNameClient;
        private Label label4;
        private Label label2;
        private TextBox textBoxNameService;
        private TextBox textBoxNameTariff;
        private Label label3;
    }
}