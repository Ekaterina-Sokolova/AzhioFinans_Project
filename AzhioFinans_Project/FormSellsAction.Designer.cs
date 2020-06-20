namespace AzhioFinans_Project
{
    partial class FormSellsAction
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelInfo = new System.Windows.Forms.Button();
            this.buttonEditInfo = new System.Windows.Forms.Button();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.listViewSell = new System.Windows.Forms.ListView();
            this.IdUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateSells = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceSells = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPriceSells = new System.Windows.Forms.TextBox();
            this.textBoxDateSells = new System.Windows.Forms.TextBox();
            this.comboBoxNameAction = new System.Windows.Forms.ComboBox();
            this.labelNameAction = new System.Windows.Forms.Label();
            this.labelPriceSells = new System.Windows.Forms.Label();
            this.labelDateSells = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(891, 497);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(202, 52);
            this.buttonClose.TabIndex = 48;
            this.buttonClose.Text = "Выйти из программы";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelInfo
            // 
            this.buttonDelInfo.Location = new System.Drawing.Point(518, 497);
            this.buttonDelInfo.Name = "buttonDelInfo";
            this.buttonDelInfo.Size = new System.Drawing.Size(208, 52);
            this.buttonDelInfo.TabIndex = 47;
            this.buttonDelInfo.Text = "Удалить информацию";
            this.buttonDelInfo.UseVisualStyleBackColor = true;
            this.buttonDelInfo.Click += new System.EventHandler(this.buttonDelInfo_Click);
            // 
            // buttonEditInfo
            // 
            this.buttonEditInfo.Location = new System.Drawing.Point(242, 497);
            this.buttonEditInfo.Name = "buttonEditInfo";
            this.buttonEditInfo.Size = new System.Drawing.Size(270, 52);
            this.buttonEditInfo.TabIndex = 46;
            this.buttonEditInfo.Text = "Редактировать информацию";
            this.buttonEditInfo.UseVisualStyleBackColor = true;
            this.buttonEditInfo.Click += new System.EventHandler(this.buttonEditInfo_Click);
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.Location = new System.Drawing.Point(12, 497);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(224, 52);
            this.buttonAddInfo.TabIndex = 45;
            this.buttonAddInfo.Text = "Добавить информацию";
            this.buttonAddInfo.UseVisualStyleBackColor = true;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // listViewSell
            // 
            this.listViewSell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUser,
            this.NameUser,
            this.DateSells,
            this.PriceSells});
            this.listViewSell.FullRowSelect = true;
            this.listViewSell.GridLines = true;
            this.listViewSell.HideSelection = false;
            this.listViewSell.Location = new System.Drawing.Point(302, 40);
            this.listViewSell.MultiSelect = false;
            this.listViewSell.Name = "listViewSell";
            this.listViewSell.Size = new System.Drawing.Size(791, 434);
            this.listViewSell.TabIndex = 44;
            this.listViewSell.UseCompatibleStateImageBehavior = false;
            this.listViewSell.View = System.Windows.Forms.View.Details;
            this.listViewSell.SelectedIndexChanged += new System.EventHandler(this.listViewSell_SelectedIndexChanged);
            // 
            // IdUser
            // 
            this.IdUser.Text = "Id пользователя";
            this.IdUser.Width = 153;
            // 
            // NameUser
            // 
            this.NameUser.Text = "Дата покупки акции";
            this.NameUser.Width = 272;
            // 
            // DateSells
            // 
            this.DateSells.Text = "Дата продажи акции";
            this.DateSells.Width = 197;
            // 
            // PriceSells
            // 
            this.PriceSells.Text = "Цена продажи акции";
            this.PriceSells.Width = 160;
            // 
            // textBoxPriceSells
            // 
            this.textBoxPriceSells.Location = new System.Drawing.Point(18, 271);
            this.textBoxPriceSells.Name = "textBoxPriceSells";
            this.textBoxPriceSells.Size = new System.Drawing.Size(248, 29);
            this.textBoxPriceSells.TabIndex = 43;
            // 
            // textBoxDateSells
            // 
            this.textBoxDateSells.Location = new System.Drawing.Point(18, 165);
            this.textBoxDateSells.Name = "textBoxDateSells";
            this.textBoxDateSells.Size = new System.Drawing.Size(248, 29);
            this.textBoxDateSells.TabIndex = 42;
            // 
            // comboBoxNameAction
            // 
            this.comboBoxNameAction.FormattingEnabled = true;
            this.comboBoxNameAction.Location = new System.Drawing.Point(12, 64);
            this.comboBoxNameAction.Name = "comboBoxNameAction";
            this.comboBoxNameAction.Size = new System.Drawing.Size(254, 29);
            this.comboBoxNameAction.TabIndex = 41;
            // 
            // labelNameAction
            // 
            this.labelNameAction.AutoSize = true;
            this.labelNameAction.Location = new System.Drawing.Point(8, 40);
            this.labelNameAction.Name = "labelNameAction";
            this.labelNameAction.Size = new System.Drawing.Size(180, 21);
            this.labelNameAction.TabIndex = 40;
            this.labelNameAction.Text = "Дата покупки акции";
            // 
            // labelPriceSells
            // 
            this.labelPriceSells.AutoSize = true;
            this.labelPriceSells.Location = new System.Drawing.Point(14, 247);
            this.labelPriceSells.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPriceSells.Name = "labelPriceSells";
            this.labelPriceSells.Size = new System.Drawing.Size(105, 21);
            this.labelPriceSells.TabIndex = 39;
            this.labelPriceSells.Text = "Цена акции";
            // 
            // labelDateSells
            // 
            this.labelDateSells.AutoSize = true;
            this.labelDateSells.Location = new System.Drawing.Point(14, 141);
            this.labelDateSells.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDateSells.Name = "labelDateSells";
            this.labelDateSells.Size = new System.Drawing.Size(192, 21);
            this.labelDateSells.TabIndex = 38;
            this.labelDateSells.Text = "Дата продажи акции";
            // 
            // FormSellsAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 561);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelInfo);
            this.Controls.Add(this.buttonEditInfo);
            this.Controls.Add(this.buttonAddInfo);
            this.Controls.Add(this.listViewSell);
            this.Controls.Add(this.textBoxPriceSells);
            this.Controls.Add(this.textBoxDateSells);
            this.Controls.Add(this.comboBoxNameAction);
            this.Controls.Add(this.labelNameAction);
            this.Controls.Add(this.labelPriceSells);
            this.Controls.Add(this.labelDateSells);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormSellsAction";
            this.Text = "FormSellsAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelInfo;
        private System.Windows.Forms.Button buttonEditInfo;
        private System.Windows.Forms.Button buttonAddInfo;
        private System.Windows.Forms.ListView listViewSell;
        private System.Windows.Forms.ColumnHeader IdUser;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.ColumnHeader DateSells;
        private System.Windows.Forms.ColumnHeader PriceSells;
        private System.Windows.Forms.TextBox textBoxPriceSells;
        private System.Windows.Forms.TextBox textBoxDateSells;
        private System.Windows.Forms.ComboBox comboBoxNameAction;
        private System.Windows.Forms.Label labelNameAction;
        private System.Windows.Forms.Label labelPriceSells;
        private System.Windows.Forms.Label labelDateSells;
    }
}