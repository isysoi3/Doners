namespace UI_Example.Controls
{
    partial class OrderPaymentControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbMakeOrder = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCashBack = new System.Windows.Forms.RadioButton();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.tbGiven = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMakeOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMakeOrder
            // 
            this.gbMakeOrder.Controls.Add(this.groupBox1);
            this.gbMakeOrder.Controls.Add(this.button1);
            this.gbMakeOrder.Controls.Add(this.cbId);
            this.gbMakeOrder.Controls.Add(this.label1);
            this.gbMakeOrder.Controls.Add(this.rbCashBack);
            this.gbMakeOrder.Controls.Add(this.tbNumber);
            this.gbMakeOrder.Controls.Add(this.label3);
            this.gbMakeOrder.Controls.Add(this.btClose);
            this.gbMakeOrder.Controls.Add(this.btPrint);
            this.gbMakeOrder.Controls.Add(this.tbGiven);
            this.gbMakeOrder.Controls.Add(this.label10);
            this.gbMakeOrder.Controls.Add(this.lbChange);
            this.gbMakeOrder.Controls.Add(this.lbTotal);
            this.gbMakeOrder.Controls.Add(this.tbDiscount);
            this.gbMakeOrder.Controls.Add(this.label7);
            this.gbMakeOrder.Controls.Add(this.rbCard);
            this.gbMakeOrder.Controls.Add(this.rbCash);
            this.gbMakeOrder.Controls.Add(this.label6);
            this.gbMakeOrder.Location = new System.Drawing.Point(0, 0);
            this.gbMakeOrder.Name = "gbMakeOrder";
            this.gbMakeOrder.Size = new System.Drawing.Size(356, 551);
            this.gbMakeOrder.TabIndex = 1;
            this.gbMakeOrder.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 76);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о клиенте";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Остаток:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Имя:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Добавить клиента";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(84, 46);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(86, 21);
            this.cbId.TabIndex = 67;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Id:   +375";
            // 
            // rbCashBack
            // 
            this.rbCashBack.AutoSize = true;
            this.rbCashBack.Enabled = false;
            this.rbCashBack.Location = new System.Drawing.Point(268, 187);
            this.rbCashBack.Name = "rbCashBack";
            this.rbCashBack.Size = new System.Drawing.Size(58, 17);
            this.rbCashBack.TabIndex = 63;
            this.rbCashBack.TabStop = true;
            this.rbCashBack.Text = "Баллы";
            this.rbCashBack.UseVisualStyleBackColor = true;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(175, 430);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNumber.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Номер заказа:";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(183, 488);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(143, 23);
            this.btClose.TabIndex = 52;
            this.btClose.Text = "Закочнить заказ";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(34, 488);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(143, 23);
            this.btPrint.TabIndex = 51;
            this.btPrint.Text = "Напечатать чек";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // tbGiven
            // 
            this.tbGiven.Location = new System.Drawing.Point(150, 273);
            this.tbGiven.Name = "tbGiven";
            this.tbGiven.Size = new System.Drawing.Size(125, 20);
            this.tbGiven.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Внесено:";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChange.Location = new System.Drawing.Point(70, 379);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(62, 20);
            this.lbChange.TabIndex = 48;
            this.lbChange.Text = "Сдача:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(70, 336);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(58, 20);
            this.lbTotal.TabIndex = 47;
            this.lbTotal.Text = "Итого:";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(150, 230);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(125, 20);
            this.tbDiscount.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Скидка:";
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(207, 187);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(55, 17);
            this.rbCard.TabIndex = 44;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Карта";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(125, 187);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(76, 17);
            this.rbCash.TabIndex = 43;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Наличные";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Способ оплаты:";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // OrderPaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMakeOrder);
            this.Name = "OrderPaymentControl";
            this.Size = new System.Drawing.Size(356, 551);
            this.gbMakeOrder.ResumeLayout(false);
            this.gbMakeOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMakeOrder;
        private System.Windows.Forms.RadioButton rbCashBack;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox tbGiven;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}
