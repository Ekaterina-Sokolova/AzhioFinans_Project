namespace AzhioFinans_Project
{
    partial class FormSellAction
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
            this.labelDateSell = new System.Windows.Forms.Label();
            this.labelPriceSell = new System.Windows.Forms.Label();
            this.comboBoxNameUser = new System.Windows.Forms.ComboBox();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.textBoxDateSell = new System.Windows.Forms.TextBox();
            this.textBoxPriceSell = new System.Windows.Forms.TextBox();
            this.listViewSell = new System.Windows.Forms.ListView();
            this.IdUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateSell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceSell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelInfo = new System.Windows.Forms.Button();
            this.buttonEditInfo = new System.Windows.Forms.Button();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDateSell
            // 
            this.labelDateSell.AutoSize = true;
            this.labelDateSell.Location = new System.Drawing.Point(14, 142);
            this.labelDateSell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDateSell.Name = "labelDateSell";
            this.labelDateSell.Size = new System.Drawing.Size(180, 21);
            this.labelDateSell.TabIndex = 0;
            this.labelDateSell.Text = "Дата покупки акции";
            // 
            // labelPriceSell
            // 
            this.labelPriceSell.AutoSize = true;
            this.labelPriceSell.Location = new System.Drawing.Point(14, 248);
            this.labelPriceSell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPriceSell.Name = "labelPriceSell";
            this.labelPriceSell.Size = new System.Drawing.Size(105, 21);
            this.labelPriceSell.TabIndex = 1;
            this.labelPriceSell.Text = "Цена акции";
            // 
            // comboBoxNameUser
            // 
            this.comboBoxNameUser.FormattingEnabled = true;
            this.comboBoxNameUser.Location = new System.Drawing.Point(12, 65);
            this.comboBoxNameUser.Name = "comboBoxNameUser";
            this.comboBoxNameUser.Size = new System.Drawing.Size(254, 29);
            this.comboBoxNameUser.TabIndex = 8;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Location = new System.Drawing.Point(8, 41);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(258, 21);
            this.labelNameUser.TabIndex = 7;
            this.labelNameUser.Text = "Имя и отчество пользователя";
            // 
            // textBoxDateSell
            // 
            this.textBoxDateSell.Location = new System.Drawing.Point(18, 166);
            this.textBoxDateSell.Name = "textBoxDateSell";
            this.textBoxDateSell.Size = new System.Drawing.Size(248, 29);
            this.textBoxDateSell.TabIndex = 9;
            // 
            // textBoxPriceSell
            // 
            this.textBoxPriceSell.Location = new System.Drawing.Point(18, 272);
            this.textBoxPriceSell.Name = "textBoxPriceSell";
            this.textBoxPriceSell.Size = new System.Drawing.Size(248, 29);
            this.textBoxPriceSell.TabIndex = 10;
            // 
            // listViewSell
            // 
            this.listViewSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUser,
            this.NameUser,
            this.DateSell,
            this.PriceSell});
            this.listViewSell.FullRowSelect = true;
            this.listViewSell.GridLines = true;
            this.listViewSell.HideSelection = false;
            this.listViewSell.Location = new System.Drawing.Point(292, 41);
            this.listViewSell.MultiSelect = false;
            this.listViewSell.Name = "listViewSell";
            this.listViewSell.Size = new System.Drawing.Size(741, 401);
            this.listViewSell.TabIndex = 11;
            this.listViewSell.UseCompatibleStateImageBehavior = false;
            this.listViewSell.View = System.Windows.Forms.View.Details;
            this.listViewSell.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IdUser
            // 
            this.IdUser.Text = "Id пользователя";
            this.IdUser.Width = 153;
            // 
            // NameUser
            // 
            this.NameUser.Text = "Имя и отчество пользователя";
            this.NameUser.Width = 272;
            // 
            // DateSell
            // 
            this.DateSell.Text = "Дата покупки акции";
            this.DateSell.Width = 197;
            // 
            // PriceSell
            // 
            this.PriceSell.Text = "Цена акции";
            this.PriceSell.Width = 115;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(831, 488);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(202, 52);
            this.buttonClose.TabIndex = 37;
            this.buttonClose.Text = "Выйти из программы";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelInfo
            // 
            this.buttonDelInfo.Location = new System.Drawing.Point(518, 488);
            this.buttonDelInfo.Name = "buttonDelInfo";
            this.buttonDelInfo.Size = new System.Drawing.Size(208, 52);
            this.buttonDelInfo.TabIndex = 36;
            this.buttonDelInfo.Text = "Удалить информацию";
            this.buttonDelInfo.UseVisualStyleBackColor = true;
            this.buttonDelInfo.Click += new System.EventHandler(this.buttonDelInfo_Click);
            // 
            // buttonEditInfo
            // 
            this.buttonEditInfo.Location = new System.Drawing.Point(242, 488);
            this.buttonEditInfo.Name = "buttonEditInfo";
            this.buttonEditInfo.Size = new System.Drawing.Size(270, 52);
            this.buttonEditInfo.TabIndex = 35;
            this.buttonEditInfo.Text = "Редактировать информацию";
            this.buttonEditInfo.UseVisualStyleBackColor = true;
            this.buttonEditInfo.Click += new System.EventHandler(this.buttonEditInfo_Click);
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.Location = new System.Drawing.Point(12, 488);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(224, 52);
            this.buttonAddInfo.TabIndex = 34;
            this.buttonAddInfo.Text = "Добавить информацию";
            this.buttonAddInfo.UseVisualStyleBackColor = true;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // FormSellAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 552);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelInfo);
            this.Controls.Add(this.buttonEditInfo);
            this.Controls.Add(this.buttonAddInfo);
            this.Controls.Add(this.listViewSell);
            this.Controls.Add(this.textBoxPriceSell);
            this.Controls.Add(this.textBoxDateSell);
            this.Controls.Add(this.comboBoxNameUser);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.labelPriceSell);
            this.Controls.Add(this.labelDateSell);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormSellAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSellAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateSell;
        private System.Windows.Forms.Label labelPriceSell;
        private System.Windows.Forms.ComboBox comboBoxNameUser;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.TextBox textBoxDateSell;
        private System.Windows.Forms.TextBox textBoxPriceSell;
        private System.Windows.Forms.ListView listViewSell;
        private System.Windows.Forms.ColumnHeader IdUser;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.ColumnHeader DateSell;
        private System.Windows.Forms.ColumnHeader PriceSell;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelInfo;
        private System.Windows.Forms.Button buttonEditInfo;
        private System.Windows.Forms.Button buttonAddInfo;
    }
}