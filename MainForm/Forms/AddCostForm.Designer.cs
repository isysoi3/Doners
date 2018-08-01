namespace UI_Example.Forms
{
    partial class AddCostForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbToPay = new System.Windows.Forms.Label();
            this.rbNonCash = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория:";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Продукты",
            "Хоз. товары",
            "Зарплата",
            "Мед. товары",
            "Оборудование",
            "Ком. расходы",
            "Реклама",
            "Пред. расходы",
            "Другое"});
            this.cbCategory.Location = new System.Drawing.Point(150, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(182, 28);
            this.cbCategory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(150, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(182, 26);
            this.tbName.TabIndex = 3;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCount.Location = new System.Drawing.Point(150, 74);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(182, 26);
            this.tbCount.TabIndex = 5;
            this.tbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCount.TextChanged += new System.EventHandler(this.recountTotalAndToPay);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество:";
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCost.Location = new System.Drawing.Point(150, 106);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(182, 26);
            this.tbCost.TabIndex = 7;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCost.TextChanged += new System.EventHandler(this.recountTotalAndToPay);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена за единицу:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Итого:";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscount.Location = new System.Drawing.Point(150, 170);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(182, 26);
            this.tbDiscount.TabIndex = 15;
            this.tbDiscount.Text = "0";
            this.tbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDiscount.TextChanged += new System.EventHandler(this.recountTotalAndToPay);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Скидка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "К оплате:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Тип оплаты:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Комментарий:";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(150, 266);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(182, 84);
            this.rtbComment.TabIndex = 22;
            this.rtbComment.Text = "";
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(150, 141);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(182, 20);
            this.lbTotal.TabIndex = 23;
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbToPay
            // 
            this.lbToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbToPay.Location = new System.Drawing.Point(150, 205);
            this.lbToPay.Name = "lbToPay";
            this.lbToPay.Size = new System.Drawing.Size(182, 20);
            this.lbToPay.TabIndex = 24;
            this.lbToPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbNonCash
            // 
            this.rbNonCash.AutoSize = true;
            this.rbNonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNonCash.Location = new System.Drawing.Point(231, 235);
            this.rbNonCash.Name = "rbNonCash";
            this.rbNonCash.Size = new System.Drawing.Size(83, 24);
            this.rbNonCash.TabIndex = 25;
            this.rbNonCash.Text = "Безнал";
            this.rbNonCash.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCash.Location = new System.Drawing.Point(167, 235);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(58, 24);
            this.rbCash.TabIndex = 26;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Нал";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(128, 367);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(81, 23);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // AddCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 402);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.rbNonCash);
            this.Controls.Add(this.lbToPay);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Name = "AddCostForm";
            this.Text = "AddCostForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCostForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbToPay;
        private System.Windows.Forms.RadioButton rbNonCash;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Button btAdd;
    }
}