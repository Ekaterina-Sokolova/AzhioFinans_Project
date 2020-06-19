namespace AzhioFinans_Project
{
    partial class FormMenu
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
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonRentProper = new System.Windows.Forms.Button();
            this.buttonPropManage = new System.Windows.Forms.Button();
            this.buttonConsultInvest = new System.Windows.Forms.Button();
            this.buttonConsultCorp = new System.Windows.Forms.Button();
            this.buttonBuyBussinesOrAction = new System.Windows.Forms.Button();
            this.buttonSellBussinesOrAction = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(143, 9);
            this.labelHello.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(108, 15);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Приветствую вас, ";
            // 
            // buttonRentProper
            // 
            this.buttonRentProper.Location = new System.Drawing.Point(30, 186);
            this.buttonRentProper.Name = "buttonRentProper";
            this.buttonRentProper.Size = new System.Drawing.Size(400, 56);
            this.buttonRentProper.TabIndex = 1;
            this.buttonRentProper.Text = "Аренда недвижимости";
            this.buttonRentProper.UseVisualStyleBackColor = true;
            this.buttonRentProper.Click += new System.EventHandler(this.buttonRentProper_Click);
            // 
            // buttonPropManage
            // 
            this.buttonPropManage.Location = new System.Drawing.Point(31, 266);
            this.buttonPropManage.Name = "buttonPropManage";
            this.buttonPropManage.Size = new System.Drawing.Size(400, 56);
            this.buttonPropManage.TabIndex = 2;
            this.buttonPropManage.Text = "Управление собственной или арендованной недвижимостью";
            this.buttonPropManage.UseVisualStyleBackColor = true;
            this.buttonPropManage.Click += new System.EventHandler(this.buttonPropManage_Click);
            // 
            // buttonConsultInvest
            // 
            this.buttonConsultInvest.Location = new System.Drawing.Point(31, 350);
            this.buttonConsultInvest.Name = "buttonConsultInvest";
            this.buttonConsultInvest.Size = new System.Drawing.Size(400, 56);
            this.buttonConsultInvest.TabIndex = 3;
            this.buttonConsultInvest.Text = "Консультация по инвестициям";
            this.buttonConsultInvest.UseVisualStyleBackColor = true;
            this.buttonConsultInvest.Click += new System.EventHandler(this.buttonConsultInvest_Click);
            // 
            // buttonConsultCorp
            // 
            this.buttonConsultCorp.Location = new System.Drawing.Point(30, 430);
            this.buttonConsultCorp.Name = "buttonConsultCorp";
            this.buttonConsultCorp.Size = new System.Drawing.Size(400, 56);
            this.buttonConsultCorp.TabIndex = 4;
            this.buttonConsultCorp.Text = "Консультация акционеров по корпоративным вопросам";
            this.buttonConsultCorp.UseVisualStyleBackColor = true;
            this.buttonConsultCorp.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonBuyBussinesOrAction
            // 
            this.buttonBuyBussinesOrAction.Location = new System.Drawing.Point(30, 507);
            this.buttonBuyBussinesOrAction.Name = "buttonBuyBussinesOrAction";
            this.buttonBuyBussinesOrAction.Size = new System.Drawing.Size(400, 56);
            this.buttonBuyBussinesOrAction.TabIndex = 5;
            this.buttonBuyBussinesOrAction.Text = "Покупка акций или бизнеса";
            this.buttonBuyBussinesOrAction.UseVisualStyleBackColor = true;
            this.buttonBuyBussinesOrAction.Click += new System.EventHandler(this.buttonBuyBussinesOrAction_Click);
            // 
            // buttonSellBussinesOrAction
            // 
            this.buttonSellBussinesOrAction.Location = new System.Drawing.Point(30, 588);
            this.buttonSellBussinesOrAction.Name = "buttonSellBussinesOrAction";
            this.buttonSellBussinesOrAction.Size = new System.Drawing.Size(400, 56);
            this.buttonSellBussinesOrAction.TabIndex = 6;
            this.buttonSellBussinesOrAction.Text = "Продажа акций или бизнеса";
            this.buttonSellBussinesOrAction.UseVisualStyleBackColor = true;
            this.buttonSellBussinesOrAction.Click += new System.EventHandler(this.buttonSellBussinesOrAction_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AzhioFinans_Project.Properties.Resources.w4c4x66uKdI_1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 38);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(438, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 676);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonSellBussinesOrAction);
            this.Controls.Add(this.buttonBuyBussinesOrAction);
            this.Controls.Add(this.buttonConsultCorp);
            this.Controls.Add(this.buttonConsultInvest);
            this.Controls.Add(this.buttonPropManage);
            this.Controls.Add(this.buttonRentProper);
            this.Controls.Add(this.labelHello);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonRentProper;
        private System.Windows.Forms.Button buttonPropManage;
        private System.Windows.Forms.Button buttonConsultInvest;
        private System.Windows.Forms.Button buttonConsultCorp;
        private System.Windows.Forms.Button buttonBuyBussinesOrAction;
        private System.Windows.Forms.Button buttonSellBussinesOrAction;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

