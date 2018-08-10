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
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAdd = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbStandart = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.gbPita = new System.Windows.Forms.GroupBox();
            this.rbWheat = new System.Windows.Forms.RadioButton();
            this.rbCheese = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDragon = new System.Windows.Forms.RadioButton();
            this.rbCommon = new System.Windows.Forms.RadioButton();
            this.rbBulgarian = new System.Windows.Forms.RadioButton();
            this.gbSauce = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGarlic = new System.Windows.Forms.CheckBox();
            this.cbSalsa = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbCaesar = new System.Windows.Forms.CheckBox();
            this.cbMustard = new System.Windows.Forms.CheckBox();
            this.cbBigMac = new System.Windows.Forms.CheckBox();
            this.cbBigTasty = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMakeOrder = new System.Windows.Forms.GroupBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.gbSize.SuspendLayout();
            this.gbPita.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSauce.SuspendLayout();
            this.gbMakeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(87, 507);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(126, 23);
            this.btAdd.TabIndex = 40;
            this.btAdd.Text = "Добавить к заказу";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbStandart);
            this.gbSize.Controls.Add(this.rbBig);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSize.Location = new System.Drawing.Point(11, 12);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(339, 50);
            this.gbSize.TabIndex = 53;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Размер:";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSmall.Location = new System.Drawing.Point(31, 25);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(82, 17);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Маленькая";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // rbStandart
            // 
            this.rbStandart.AutoSize = true;
            this.rbStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbStandart.Location = new System.Drawing.Point(128, 25);
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
            this.rbBig.Location = new System.Drawing.Point(228, 25);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(70, 17);
            this.rbBig.TabIndex = 4;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Большая";
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // gbPita
            // 
            this.gbPita.Controls.Add(this.rbWheat);
            this.gbPita.Controls.Add(this.rbCheese);
            this.gbPita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPita.Location = new System.Drawing.Point(11, 61);
            this.gbPita.Name = "gbPita";
            this.gbPita.Size = new System.Drawing.Size(339, 50);
            this.gbPita.TabIndex = 54;
            this.gbPita.TabStop = false;
            this.gbPita.Text = "Лаваш:";
            // 
            // rbWheat
            // 
            this.rbWheat.AutoSize = true;
            this.rbWheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbWheat.Location = new System.Drawing.Point(73, 25);
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
            this.rbCheese.Location = new System.Drawing.Point(186, 25);
            this.rbCheese.Name = "rbCheese";
            this.rbCheese.Size = new System.Drawing.Size(66, 17);
            this.rbCheese.TabIndex = 4;
            this.rbCheese.TabStop = true;
            this.rbCheese.Text = "Сырный";
            this.rbCheese.UseVisualStyleBackColor = true;
            this.rbCheese.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Количество:";
            // 
            // tbCount
            // 
            this.tbCount.AllowDrop = true;
            this.tbCount.Location = new System.Drawing.Point(111, 366);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 20);
            this.tbCount.TabIndex = 57;
            this.tbCount.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Комментарий:";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(111, 399);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(211, 96);
            this.rtbComment.TabIndex = 59;
            this.rtbComment.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDragon);
            this.groupBox2.Controls.Add(this.rbCommon);
            this.groupBox2.Controls.Add(this.rbBulgarian);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(11, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 55);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип:";
            // 
            // rbDragon
            // 
            this.rbDragon.AutoSize = true;
            this.rbDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDragon.Location = new System.Drawing.Point(214, 25);
            this.rbDragon.Name = "rbDragon";
            this.rbDragon.Size = new System.Drawing.Size(116, 17);
            this.rbDragon.TabIndex = 5;
            this.rbDragon.Text = "Дыхание дракона";
            this.rbDragon.UseVisualStyleBackColor = true;
            // 
            // rbCommon
            // 
            this.rbCommon.AutoSize = true;
            this.rbCommon.Checked = true;
            this.rbCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCommon.Location = new System.Drawing.Point(31, 25);
            this.rbCommon.Name = "rbCommon";
            this.rbCommon.Size = new System.Drawing.Size(70, 17);
            this.rbCommon.TabIndex = 3;
            this.rbCommon.TabStop = true;
            this.rbCommon.Text = "Обычная";
            this.rbCommon.UseVisualStyleBackColor = true;
            // 
            // rbBulgarian
            // 
            this.rbBulgarian.AutoSize = true;
            this.rbBulgarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBulgarian.Location = new System.Drawing.Point(113, 25);
            this.rbBulgarian.Name = "rbBulgarian";
            this.rbBulgarian.Size = new System.Drawing.Size(95, 17);
            this.rbBulgarian.TabIndex = 4;
            this.rbBulgarian.Text = "По-болгарски";
            this.rbBulgarian.UseVisualStyleBackColor = true;
            // 
            // gbSauce
            // 
            this.gbSauce.Controls.Add(this.label4);
            this.gbSauce.Controls.Add(this.cbGarlic);
            this.gbSauce.Controls.Add(this.cbSalsa);
            this.gbSauce.Controls.Add(this.cbCheese);
            this.gbSauce.Controls.Add(this.cbCaesar);
            this.gbSauce.Controls.Add(this.cbMustard);
            this.gbSauce.Controls.Add(this.cbBigMac);
            this.gbSauce.Controls.Add(this.cbBigTasty);
            this.gbSauce.Controls.Add(this.label5);
            this.gbSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSauce.Location = new System.Drawing.Point(11, 171);
            this.gbSauce.Name = "gbSauce";
            this.gbSauce.Size = new System.Drawing.Size(339, 183);
            this.gbSauce.TabIndex = 62;
            this.gbSauce.TabStop = false;
            this.gbSauce.Text = "Соус:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Стандартный:";
            // 
            // cbGarlic
            // 
            this.cbGarlic.AutoSize = true;
            this.cbGarlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbGarlic.Location = new System.Drawing.Point(31, 57);
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
            this.cbSalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbSalsa.Location = new System.Drawing.Point(153, 57);
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
            this.cbCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCheese.Location = new System.Drawing.Point(31, 81);
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
            this.cbCaesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCaesar.Location = new System.Drawing.Point(153, 81);
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
            this.cbMustard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMustard.Location = new System.Drawing.Point(31, 104);
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
            this.cbBigMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbBigMac.Location = new System.Drawing.Point(31, 154);
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
            this.cbBigTasty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbBigTasty.Location = new System.Drawing.Point(153, 154);
            this.cbBigTasty.Name = "cbBigTasty";
            this.cbBigTasty.Size = new System.Drawing.Size(83, 17);
            this.cbBigTasty.TabIndex = 13;
            this.cbBigTasty.Text = "Биг Тейсти";
            this.cbBigTasty.UseVisualStyleBackColor = true;
            this.cbBigTasty.CheckedChanged += new System.EventHandler(this.clearErrorProvider);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Премиум:";
            // 
            // gbMakeOrder
            // 
            this.gbMakeOrder.Controls.Add(this.gbSauce);
            this.gbMakeOrder.Controls.Add(this.groupBox2);
            this.gbMakeOrder.Controls.Add(this.rtbComment);
            this.gbMakeOrder.Controls.Add(this.label2);
            this.gbMakeOrder.Controls.Add(this.tbCount);
            this.gbMakeOrder.Controls.Add(this.label1);
            this.gbMakeOrder.Controls.Add(this.gbPita);
            this.gbMakeOrder.Controls.Add(this.gbSize);
            this.gbMakeOrder.Controls.Add(this.btAdd);
            this.gbMakeOrder.Location = new System.Drawing.Point(5, 7);
            this.gbMakeOrder.Name = "gbMakeOrder";
            this.gbMakeOrder.Size = new System.Drawing.Size(356, 551);
            this.gbMakeOrder.TabIndex = 0;
            this.gbMakeOrder.TabStop = false;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(899, 570);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 25);
            this.btNext.TabIndex = 52;
            this.btNext.Text = "Далее";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btBack
            // 
            this.btBack.Enabled = false;
            this.btBack.Location = new System.Drawing.Point(12, 570);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 25);
            this.btBack.TabIndex = 53;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOrder.Location = new System.Drawing.Point(367, 7);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(632, 551);
            this.gbOrder.TabIndex = 54;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Заказ";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 611);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.gbMakeOrder);
            this.Controls.Add(this.btNext);
            this.MaximumSize = new System.Drawing.Size(1028, 650);
            this.MinimumSize = new System.Drawing.Size(1028, 650);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWillClose);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbPita.ResumeLayout(false);
            this.gbPita.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSauce.ResumeLayout(false);
            this.gbSauce.PerformLayout();
            this.gbMakeOrder.ResumeLayout(false);
            this.gbMakeOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.GroupBox gbMakeOrder;
        private System.Windows.Forms.GroupBox gbSauce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbGarlic;
        private System.Windows.Forms.CheckBox cbSalsa;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbCaesar;
        private System.Windows.Forms.CheckBox cbMustard;
        private System.Windows.Forms.CheckBox cbBigMac;
        private System.Windows.Forms.CheckBox cbBigTasty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDragon;
        private System.Windows.Forms.RadioButton rbCommon;
        private System.Windows.Forms.RadioButton rbBulgarian;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPita;
        private System.Windows.Forms.RadioButton rbWheat;
        private System.Windows.Forms.RadioButton rbCheese;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbStandart;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.GroupBox gbOrder;
    }
}

