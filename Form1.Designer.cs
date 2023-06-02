namespace lbl11
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_CN = new System.Windows.Forms.TextBox();
            this.tb_CC = new System.Windows.Forms.TextBox();
            this.rt_CI = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(12, 39);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 22);
            this.tb_Id.TabIndex = 1;
            // 
            // tb_CN
            // 
            this.tb_CN.Location = new System.Drawing.Point(12, 93);
            this.tb_CN.Name = "tb_CN";
            this.tb_CN.Size = new System.Drawing.Size(100, 22);
            this.tb_CN.TabIndex = 2;
            // 
            // tb_CC
            // 
            this.tb_CC.Location = new System.Drawing.Point(15, 154);
            this.tb_CC.Name = "tb_CC";
            this.tb_CC.Size = new System.Drawing.Size(100, 22);
            this.tb_CC.TabIndex = 3;
            // 
            // rt_CI
            // 
            this.rt_CI.Location = new System.Drawing.Point(12, 279);
            this.rt_CI.Name = "rt_CI";
            this.rt_CI.Size = new System.Drawing.Size(257, 96);
            this.rt_CI.TabIndex = 4;
            this.rt_CI.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отобразить таблицу Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название машины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "В каком году была создана машина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Описание ";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(465, 335);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(203, 23);
            this.btn_Del.TabIndex = 10;
            this.btn_Del.Text = "Удалить строку в таблице";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(465, 364);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(203, 23);
            this.btn_Change.TabIndex = 11;
            this.btn_Change.Text = "Изменить данные";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(465, 393);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(203, 23);
            this.btn_Create.TabIndex = 12;
            this.btn_Create.Text = "Добавить строку в таблицу";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rt_CI);
            this.Controls.Add(this.tb_CC);
            this.Controls.Add(this.tb_CN);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Таблица Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_CN;
        private System.Windows.Forms.TextBox tb_CC;
        private System.Windows.Forms.RichTextBox rt_CI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Create;
    }
}

