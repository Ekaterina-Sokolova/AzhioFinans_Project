namespace AzhioFinans_Project
{
    partial class FormConsultInvest
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
            this.labelNameSotr = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelPlaceInvest = new System.Windows.Forms.Label();
            this.labelActualInvest = new System.Windows.Forms.Label();
            this.labelColInvest = new System.Windows.Forms.Label();
            this.textBoxNameSotr = new System.Windows.Forms.TextBox();
            this.comboBoxNameUser = new System.Windows.Forms.ComboBox();
            this.textBoxPlaceInvest = new System.Windows.Forms.TextBox();
            this.comboBoxActualInvest = new System.Windows.Forms.ComboBox();
            this.textBoxColInvest = new System.Windows.Forms.TextBox();
            this.listViewConsultInvest = new System.Windows.Forms.ListView();
            this.айди = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namesurnamesotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namesurnameuser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceInvest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActualInvest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColInvest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelInfo = new System.Windows.Forms.Button();
            this.buttonEditInfo = new System.Windows.Forms.Button();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameSotr
            // 
            this.labelNameSotr.AutoSize = true;
            this.labelNameSotr.Location = new System.Drawing.Point(8, 29);
            this.labelNameSotr.Name = "labelNameSotr";
            this.labelNameSotr.Size = new System.Drawing.Size(246, 21);
            this.labelNameSotr.TabIndex = 0;
            this.labelNameSotr.Text = "Имя и отчество сотрудника";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Location = new System.Drawing.Point(8, 134);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(258, 21);
            this.labelNameUser.TabIndex = 1;
            this.labelNameUser.Text = "Имя и отчество пользователя";
            // 
            // labelPlaceInvest
            // 
            this.labelPlaceInvest.AutoSize = true;
            this.labelPlaceInvest.Location = new System.Drawing.Point(8, 245);
            this.labelPlaceInvest.Name = "labelPlaceInvest";
            this.labelPlaceInvest.Size = new System.Drawing.Size(202, 21);
            this.labelPlaceInvest.TabIndex = 2;
            this.labelPlaceInvest.Text = "Место инвестирования";
            // 
            // labelActualInvest
            // 
            this.labelActualInvest.AutoSize = true;
            this.labelActualInvest.Location = new System.Drawing.Point(8, 359);
            this.labelActualInvest.Name = "labelActualInvest";
            this.labelActualInvest.Size = new System.Drawing.Size(265, 42);
            this.labelActualInvest.TabIndex = 3;
            this.labelActualInvest.Text = "Актуальность инвестирования\r\n(От 0 до 3)";
            this.labelActualInvest.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelColInvest
            // 
            this.labelColInvest.AutoSize = true;
            this.labelColInvest.Location = new System.Drawing.Point(8, 496);
            this.labelColInvest.Name = "labelColInvest";
            this.labelColInvest.Size = new System.Drawing.Size(207, 21);
            this.labelColInvest.TabIndex = 4;
            this.labelColInvest.Text = "Количество инвестиций";
            // 
            // textBoxNameSotr
            // 
            this.textBoxNameSotr.Location = new System.Drawing.Point(12, 54);
            this.textBoxNameSotr.Name = "textBoxNameSotr";
            this.textBoxNameSotr.Size = new System.Drawing.Size(254, 29);
            this.textBoxNameSotr.TabIndex = 5;
            // 
            // comboBoxNameUser
            // 
            this.comboBoxNameUser.FormattingEnabled = true;
            this.comboBoxNameUser.Location = new System.Drawing.Point(12, 159);
            this.comboBoxNameUser.Name = "comboBoxNameUser";
            this.comboBoxNameUser.Size = new System.Drawing.Size(254, 29);
            this.comboBoxNameUser.TabIndex = 6;
            // 
            // textBoxPlaceInvest
            // 
            this.textBoxPlaceInvest.Location = new System.Drawing.Point(12, 270);
            this.textBoxPlaceInvest.Name = "textBoxPlaceInvest";
            this.textBoxPlaceInvest.Size = new System.Drawing.Size(254, 29);
            this.textBoxPlaceInvest.TabIndex = 7;
            // 
            // comboBoxActualInvest
            // 
            this.comboBoxActualInvest.FormattingEnabled = true;
            this.comboBoxActualInvest.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxActualInvest.Location = new System.Drawing.Point(12, 404);
            this.comboBoxActualInvest.Name = "comboBoxActualInvest";
            this.comboBoxActualInvest.Size = new System.Drawing.Size(254, 29);
            this.comboBoxActualInvest.TabIndex = 8;
            this.comboBoxActualInvest.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxColInvest
            // 
            this.textBoxColInvest.Location = new System.Drawing.Point(12, 521);
            this.textBoxColInvest.Name = "textBoxColInvest";
            this.textBoxColInvest.Size = new System.Drawing.Size(254, 29);
            this.textBoxColInvest.TabIndex = 9;
            // 
            // listViewConsultInvest
            // 
            this.listViewConsultInvest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.айди,
            this.Namesurnamesotr,
            this.ID,
            this.Namesurnameuser,
            this.PlaceInvest,
            this.ActualInvest,
            this.ColInvest});
            this.listViewConsultInvest.FullRowSelect = true;
            this.listViewConsultInvest.GridLines = true;
            this.listViewConsultInvest.HideSelection = false;
            this.listViewConsultInvest.Location = new System.Drawing.Point(289, 29);
            this.listViewConsultInvest.MultiSelect = false;
            this.listViewConsultInvest.Name = "listViewConsultInvest";
            this.listViewConsultInvest.Size = new System.Drawing.Size(1497, 521);
            this.listViewConsultInvest.TabIndex = 10;
            this.listViewConsultInvest.UseCompatibleStateImageBehavior = false;
            this.listViewConsultInvest.View = System.Windows.Forms.View.Details;
            this.listViewConsultInvest.SelectedIndexChanged += new System.EventHandler(this.listViewConsultInvest_SelectedIndexChanged);
            // 
            // айди
            // 
            this.айди.Text = "Id сотрудника";
            this.айди.Width = 134;
            // 
            // Namesurnamesotr
            // 
            this.Namesurnamesotr.Text = "Имя и отчество сотрудника";
            this.Namesurnamesotr.Width = 252;
            // 
            // ID
            // 
            this.ID.Text = "Id пользователя";
            this.ID.Width = 147;
            // 
            // Namesurnameuser
            // 
            this.Namesurnameuser.Text = "Имя и отчество пользователя";
            this.Namesurnameuser.Width = 261;
            // 
            // PlaceInvest
            // 
            this.PlaceInvest.Text = "Место инвестирования";
            this.PlaceInvest.Width = 208;
            // 
            // ActualInvest
            // 
            this.ActualInvest.Text = "Актуальность инвестирования";
            this.ActualInvest.Width = 283;
            // 
            // ColInvest
            // 
            this.ColInvest.Text = "Количество инвестиций";
            this.ColInvest.Width = 219;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1584, 600);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(202, 52);
            this.buttonClose.TabIndex = 33;
            this.buttonClose.Text = "Выйти из программы";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelInfo
            // 
            this.buttonDelInfo.Location = new System.Drawing.Point(1370, 600);
            this.buttonDelInfo.Name = "buttonDelInfo";
            this.buttonDelInfo.Size = new System.Drawing.Size(208, 52);
            this.buttonDelInfo.TabIndex = 32;
            this.buttonDelInfo.Text = "Удалить информацию";
            this.buttonDelInfo.UseVisualStyleBackColor = true;
            this.buttonDelInfo.Click += new System.EventHandler(this.buttonDelInfo_Click);
            // 
            // buttonEditInfo
            // 
            this.buttonEditInfo.Location = new System.Drawing.Point(1094, 600);
            this.buttonEditInfo.Name = "buttonEditInfo";
            this.buttonEditInfo.Size = new System.Drawing.Size(270, 52);
            this.buttonEditInfo.TabIndex = 31;
            this.buttonEditInfo.Text = "Редактировать информацию";
            this.buttonEditInfo.UseVisualStyleBackColor = true;
            this.buttonEditInfo.Click += new System.EventHandler(this.buttonEditInfo_Click);
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.Location = new System.Drawing.Point(864, 600);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(224, 52);
            this.buttonAddInfo.TabIndex = 30;
            this.buttonAddInfo.Text = "Добавить информацию";
            this.buttonAddInfo.UseVisualStyleBackColor = true;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // FormConsultInvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 663);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelInfo);
            this.Controls.Add(this.buttonEditInfo);
            this.Controls.Add(this.buttonAddInfo);
            this.Controls.Add(this.listViewConsultInvest);
            this.Controls.Add(this.textBoxColInvest);
            this.Controls.Add(this.comboBoxActualInvest);
            this.Controls.Add(this.textBoxPlaceInvest);
            this.Controls.Add(this.comboBoxNameUser);
            this.Controls.Add(this.textBoxNameSotr);
            this.Controls.Add(this.labelColInvest);
            this.Controls.Add(this.labelActualInvest);
            this.Controls.Add(this.labelPlaceInvest);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.labelNameSotr);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormConsultInvest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultInvest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameSotr;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelPlaceInvest;
        private System.Windows.Forms.Label labelActualInvest;
        private System.Windows.Forms.Label labelColInvest;
        private System.Windows.Forms.TextBox textBoxNameSotr;
        private System.Windows.Forms.ComboBox comboBoxNameUser;
        private System.Windows.Forms.TextBox textBoxPlaceInvest;
        private System.Windows.Forms.ComboBox comboBoxActualInvest;
        private System.Windows.Forms.TextBox textBoxColInvest;
        private System.Windows.Forms.ListView listViewConsultInvest;
        private System.Windows.Forms.ColumnHeader айди;
        private System.Windows.Forms.ColumnHeader Namesurnamesotr;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Namesurnameuser;
        private System.Windows.Forms.ColumnHeader PlaceInvest;
        private System.Windows.Forms.ColumnHeader ActualInvest;
        private System.Windows.Forms.ColumnHeader ColInvest;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelInfo;
        private System.Windows.Forms.Button buttonEditInfo;
        private System.Windows.Forms.Button buttonAddInfo;
    }
}