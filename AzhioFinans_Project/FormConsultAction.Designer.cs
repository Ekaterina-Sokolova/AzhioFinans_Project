namespace AzhioFinans_Project
{
    partial class FormConsultAction
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
            this.labelSotr = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelQwen = new System.Windows.Forms.Label();
            this.labelActual = new System.Windows.Forms.Label();
            this.comboBoxSotr = new System.Windows.Forms.ComboBox();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.comboBoxActual = new System.Windows.Forms.ComboBox();
            this.textBoxQwen = new System.Windows.Forms.TextBox();
            this.listViewConsAction = new System.Windows.Forms.ListView();
            this.IdSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdAct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qwen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelInfo = new System.Windows.Forms.Button();
            this.buttonEditInfo = new System.Windows.Forms.Button();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSotr
            // 
            this.labelSotr.AutoSize = true;
            this.labelSotr.Location = new System.Drawing.Point(8, 32);
            this.labelSotr.Name = "labelSotr";
            this.labelSotr.Size = new System.Drawing.Size(102, 21);
            this.labelSotr.TabIndex = 0;
            this.labelSotr.Text = "Сотрудник";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(8, 122);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(86, 21);
            this.labelAction.TabIndex = 1;
            this.labelAction.Text = "Акционер";
            // 
            // labelQwen
            // 
            this.labelQwen.AutoSize = true;
            this.labelQwen.Location = new System.Drawing.Point(8, 212);
            this.labelQwen.Name = "labelQwen";
            this.labelQwen.Size = new System.Drawing.Size(156, 21);
            this.labelQwen.TabIndex = 2;
            this.labelQwen.Text = "Вопрос акционеру";
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Location = new System.Drawing.Point(12, 288);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(197, 42);
            this.labelActual.TabIndex = 3;
            this.labelActual.Text = "Актуальность вопроса\r\n(От 0 до 3)";
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(12, 56);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(223, 29);
            this.comboBoxSotr.TabIndex = 4;
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(12, 146);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(223, 29);
            this.comboBoxAction.TabIndex = 5;
            // 
            // comboBoxActual
            // 
            this.comboBoxActual.FormattingEnabled = true;
            this.comboBoxActual.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxActual.Location = new System.Drawing.Point(12, 333);
            this.comboBoxActual.Name = "comboBoxActual";
            this.comboBoxActual.Size = new System.Drawing.Size(223, 29);
            this.comboBoxActual.TabIndex = 6;
            // 
            // textBoxQwen
            // 
            this.textBoxQwen.Location = new System.Drawing.Point(12, 236);
            this.textBoxQwen.Name = "textBoxQwen";
            this.textBoxQwen.Size = new System.Drawing.Size(223, 29);
            this.textBoxQwen.TabIndex = 7;
            // 
            // listViewConsAction
            // 
            this.listViewConsAction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdSotr,
            this.Sotr,
            this.IdAct,
            this.Action,
            this.qwen,
            this.Actual});
            this.listViewConsAction.FullRowSelect = true;
            this.listViewConsAction.GridLines = true;
            this.listViewConsAction.HideSelection = false;
            this.listViewConsAction.Location = new System.Drawing.Point(254, 32);
            this.listViewConsAction.MultiSelect = false;
            this.listViewConsAction.Name = "listViewConsAction";
            this.listViewConsAction.Size = new System.Drawing.Size(922, 408);
            this.listViewConsAction.TabIndex = 8;
            this.listViewConsAction.UseCompatibleStateImageBehavior = false;
            this.listViewConsAction.View = System.Windows.Forms.View.Details;
            this.listViewConsAction.SelectedIndexChanged += new System.EventHandler(this.listViewConsAction_SelectedIndexChanged);
            // 
            // IdSotr
            // 
            this.IdSotr.Text = "Id сотрудника";
            this.IdSotr.Width = 133;
            // 
            // Sotr
            // 
            this.Sotr.Text = "Сотрудник";
            this.Sotr.Width = 112;
            // 
            // IdAct
            // 
            this.IdAct.Text = "Id акционера";
            this.IdAct.Width = 130;
            // 
            // Action
            // 
            this.Action.Text = "Акционер";
            this.Action.Width = 100;
            // 
            // qwen
            // 
            this.qwen.Text = "Вопрос акционеру";
            this.qwen.Width = 238;
            // 
            // Actual
            // 
            this.Actual.Text = "Актуальность вопроса";
            this.Actual.Width = 202;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(974, 451);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(202, 52);
            this.buttonClose.TabIndex = 37;
            this.buttonClose.Text = "Выйти из программы";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelInfo
            // 
            this.buttonDelInfo.Location = new System.Drawing.Point(760, 451);
            this.buttonDelInfo.Name = "buttonDelInfo";
            this.buttonDelInfo.Size = new System.Drawing.Size(208, 52);
            this.buttonDelInfo.TabIndex = 36;
            this.buttonDelInfo.Text = "Удалить информацию";
            this.buttonDelInfo.UseVisualStyleBackColor = true;
            this.buttonDelInfo.Click += new System.EventHandler(this.buttonDelInfo_Click);
            // 
            // buttonEditInfo
            // 
            this.buttonEditInfo.Location = new System.Drawing.Point(484, 451);
            this.buttonEditInfo.Name = "buttonEditInfo";
            this.buttonEditInfo.Size = new System.Drawing.Size(270, 52);
            this.buttonEditInfo.TabIndex = 35;
            this.buttonEditInfo.Text = "Редактировать информацию";
            this.buttonEditInfo.UseVisualStyleBackColor = true;
            this.buttonEditInfo.Click += new System.EventHandler(this.buttonEditInfo_Click);
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.Location = new System.Drawing.Point(254, 451);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(224, 52);
            this.buttonAddInfo.TabIndex = 34;
            this.buttonAddInfo.Text = "Добавить информацию";
            this.buttonAddInfo.UseVisualStyleBackColor = true;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // FormConsultAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 515);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelInfo);
            this.Controls.Add(this.buttonEditInfo);
            this.Controls.Add(this.buttonAddInfo);
            this.Controls.Add(this.listViewConsAction);
            this.Controls.Add(this.textBoxQwen);
            this.Controls.Add(this.comboBoxActual);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.comboBoxSotr);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.labelQwen);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.labelSotr);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormConsultAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSotr;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelQwen;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.ComboBox comboBoxSotr;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.ComboBox comboBoxActual;
        private System.Windows.Forms.TextBox textBoxQwen;
        private System.Windows.Forms.ListView listViewConsAction;
        private System.Windows.Forms.ColumnHeader IdSotr;
        private System.Windows.Forms.ColumnHeader Sotr;
        private System.Windows.Forms.ColumnHeader IdAct;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.ColumnHeader qwen;
        private System.Windows.Forms.ColumnHeader Actual;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelInfo;
        private System.Windows.Forms.Button buttonEditInfo;
        private System.Windows.Forms.Button buttonAddInfo;
    }
}