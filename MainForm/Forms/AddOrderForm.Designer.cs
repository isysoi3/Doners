namespace AddOrder
{
    partial class AddOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.lbSause = new System.Windows.Forms.Label();
            this.rbStandart = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.cbGarlic = new System.Windows.Forms.CheckBox();
            this.cbSalsa = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbCaesar = new System.Windows.Forms.CheckBox();
            this.cbMustard = new System.Windows.Forms.CheckBox();
            this.cbBigMac = new System.Windows.Forms.CheckBox();
            this.cbBigTasty = new System.Windows.Forms.CheckBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGiven = new System.Windows.Forms.TextBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbPita = new System.Windows.Forms.GroupBox();
            this.rbWheat = new System.Windows.Forms.RadioButton();
            this.rbCheese = new System.Windows.Forms.RadioButton();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbPita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSause
            // 
            this.lbSause.AutoSize = true;
            this.lbSause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSause.Location = new System.Drawing.Point(12, 124);
            this.lbSause.Name = "lbSause";
            this.lbSause.Size = new System.Drawing.Size(48, 20);
            this.lbSause.TabIndex = 2;
            this.lbSause.Text = "Соус:";
            // 
            // rbStandart
            // 
            this.rbStandart.AutoSize = true;
            this.rbStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbStandart.Location = new System.Drawing.Point(31, 30);
            this.rbStandart.Name = "rbStandart";
            this.rbStandart.Size = new System.Drawing.Size(72, 17);
            this.rbStandart.TabIndex = 3;
            this.rbStandart.TabStop = true;
            this.rbStandart.Text = "Стандарт";
            this.rbStandart.UseVisualStyleBackColor = true;
            this.rbStandart.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBig.Location = new System.Drawing.Point(153, 30);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(70, 17);
            this.rbBig.TabIndex = 4;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Большая";
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbGarlic
            // 
            this.cbGarlic.AutoSize = true;
            this.cbGarlic.Location = new System.Drawing.Point(39, 194);
            this.cbGarlic.Name = "cbGarlic";
            this.cbGarlic.Size = new System.Drawing.Size(83, 17);
            this.cbGarlic.TabIndex = 7;
            this.cbGarlic.Text = "Чесночный";
            this.cbGarlic.UseVisualStyleBackColor = true;
            this.cbGarlic.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbSalsa
            // 
            this.cbSalsa.AutoSize = true;
            this.cbSalsa.Location = new System.Drawing.Point(161, 194);
            this.cbSalsa.Name = "cbSalsa";
            this.cbSalsa.Size = new System.Drawing.Size(63, 17);
            this.cbSalsa.TabIndex = 8;
            this.cbSalsa.Text = "Сальса";
            this.cbSalsa.UseVisualStyleBackColor = true;
            this.cbSalsa.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(39, 224);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(67, 17);
            this.cbCheese.TabIndex = 9;
            this.cbCheese.Text = "Сырный";
            this.cbCheese.UseVisualStyleBackColor = true;
            this.cbCheese.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbCaesar
            // 
            this.cbCaesar.AutoSize = true;
            this.cbCaesar.Location = new System.Drawing.Point(161, 224);
            this.cbCaesar.Name = "cbCaesar";
            this.cbCaesar.Size = new System.Drawing.Size(64, 17);
            this.cbCaesar.TabIndex = 10;
            this.cbCaesar.Text = "Цезарь";
            this.cbCaesar.UseVisualStyleBackColor = true;
            this.cbCaesar.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbMustard
            // 
            this.cbMustard.AutoSize = true;
            this.cbMustard.Location = new System.Drawing.Point(39, 259);
            this.cbMustard.Name = "cbMustard";
            this.cbMustard.Size = new System.Drawing.Size(80, 17);
            this.cbMustard.TabIndex = 11;
            this.cbMustard.Text = "Горчичный";
            this.cbMustard.UseVisualStyleBackColor = true;
            this.cbMustard.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbBigMac
            // 
            this.cbBigMac.AutoSize = true;
            this.cbBigMac.Location = new System.Drawing.Point(39, 312);
            this.cbBigMac.Name = "cbBigMac";
            this.cbBigMac.Size = new System.Drawing.Size(68, 17);
            this.cbBigMac.TabIndex = 12;
            this.cbBigMac.Text = "Биг Мак";
            this.cbBigMac.UseVisualStyleBackColor = true;
            this.cbBigMac.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // cbBigTasty
            // 
            this.cbBigTasty.AutoSize = true;
            this.cbBigTasty.Location = new System.Drawing.Point(161, 312);
            this.cbBigTasty.Name = "cbBigTasty";
            this.cbBigTasty.Size = new System.Drawing.Size(83, 17);
            this.cbBigTasty.TabIndex = 13;
            this.cbBigTasty.Text = "Биг Тейсти";
            this.cbBigTasty.UseVisualStyleBackColor = true;
            this.cbBigTasty.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(39, 531);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(126, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Добавить к заказу";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Стандартный:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Премиум:";
            // 
            // gbOrder
            // 
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOrder.Location = new System.Drawing.Point(359, 12);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(632, 364);
            this.gbOrder.TabIndex = 17;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Заказ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Способ оплаты:";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(551, 405);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(76, 17);
            this.rbCash.TabIndex = 19;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Наличные";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.paymentChanged);
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(633, 405);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(55, 17);
            this.rbCard.TabIndex = 20;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Карта";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.paymentChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Скидка:";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(551, 434);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(100, 20);
            this.tbDiscount.TabIndex = 22;
            this.tbDiscount.TextChanged += new System.EventHandler(this.recountTotalAndChange);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(735, 398);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(58, 20);
            this.lbTotal.TabIndex = 23;
            this.lbTotal.Text = "Итого:";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChange.Location = new System.Drawing.Point(735, 434);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(62, 20);
            this.lbChange.TabIndex = 24;
            this.lbChange.Text = "Сдача:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Внесено:";
            // 
            // tbGiven
            // 
            this.tbGiven.Location = new System.Drawing.Point(551, 475);
            this.tbGiven.Name = "tbGiven";
            this.tbGiven.Size = new System.Drawing.Size(100, 20);
            this.tbGiven.TabIndex = 26;
            this.tbGiven.TextChanged += new System.EventHandler(this.recountTotalAndChange);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(603, 531);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(143, 23);
            this.btPrint.TabIndex = 27;
            this.btPrint.Text = "Напечатать чек";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.printCkeckButtonClicked);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(773, 531);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(143, 23);
            this.btClose.TabIndex = 28;
            this.btClose.Text = "Закочнить заказ";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.endOrderButtonClick);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbStandart);
            this.gbSize.Controls.Add(this.rbBig);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSize.Location = new System.Drawing.Point(8, 3);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(268, 58);
            this.gbSize.TabIndex = 29;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Размер:";
            // 
            // gbPita
            // 
            this.gbPita.Controls.Add(this.rbWheat);
            this.gbPita.Controls.Add(this.rbCheese);
            this.gbPita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPita.Location = new System.Drawing.Point(8, 67);
            this.gbPita.Name = "gbPita";
            this.gbPita.Size = new System.Drawing.Size(268, 54);
            this.gbPita.TabIndex = 30;
            this.gbPita.TabStop = false;
            this.gbPita.Text = "Лаваш:";
            // 
            // rbWheat
            // 
            this.rbWheat.AutoSize = true;
            this.rbWheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbWheat.Location = new System.Drawing.Point(31, 30);
            this.rbWheat.Name = "rbWheat";
            this.rbWheat.Size = new System.Drawing.Size(84, 17);
            this.rbWheat.TabIndex = 3;
            this.rbWheat.TabStop = true;
            this.rbWheat.Text = "Пшеничный";
            this.rbWheat.UseVisualStyleBackColor = true;
            this.rbWheat.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // rbCheese
            // 
            this.rbCheese.AutoSize = true;
            this.rbCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCheese.Location = new System.Drawing.Point(153, 30);
            this.rbCheese.Name = "rbCheese";
            this.rbCheese.Size = new System.Drawing.Size(66, 17);
            this.rbCheese.TabIndex = 4;
            this.rbCheese.TabStop = true;
            this.rbCheese.Text = "Сырный";
            this.rbCheese.UseVisualStyleBackColor = true;
            this.rbCheese.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // tbCount
            // 
            this.tbCount.AllowDrop = true;
            this.tbCount.Location = new System.Drawing.Point(108, 356);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 20);
            this.tbCount.TabIndex = 32;
            this.tbCount.Text = "1";
            this.tbCount.TextChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Количество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Комментарий:";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(108, 396);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(211, 104);
            this.rtbComment.TabIndex = 35;
            this.rtbComment.Text = "";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(840, 475);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 37;
            this.tbNumber.TextChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Номер заказа:";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 566);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPita);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.tbGiven);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbBigTasty);
            this.Controls.Add(this.cbBigMac);
            this.Controls.Add(this.cbMustard);
            this.Controls.Add(this.cbCaesar);
            this.Controls.Add(this.cbCheese);
            this.Controls.Add(this.cbSalsa);
            this.Controls.Add(this.cbGarlic);
            this.Controls.Add(this.lbSause);
            this.MaximumSize = new System.Drawing.Size(1028, 605);
            this.MinimumSize = new System.Drawing.Size(1028, 605);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый заказ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWillClose);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbPita.ResumeLayout(false);
            this.gbPita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSause;
        private System.Windows.Forms.RadioButton rbStandart;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.CheckBox cbGarlic;
        private System.Windows.Forms.CheckBox cbSalsa;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbCaesar;
        private System.Windows.Forms.CheckBox cbMustard;
        private System.Windows.Forms.CheckBox cbBigMac;
        private System.Windows.Forms.CheckBox cbBigTasty;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGiven;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbPita;
        private System.Windows.Forms.RadioButton rbWheat;
        private System.Windows.Forms.RadioButton rbCheese;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label3;
    }
}

