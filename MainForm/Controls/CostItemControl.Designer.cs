namespace UI_Example.Controls
{
    partial class CostItemControl
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
            this.lbComment = new System.Windows.Forms.Label();
            this.lbPaymentType = new System.Windows.Forms.Label();
            this.lbToPay = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.White;
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComment.Location = new System.Drawing.Point(734, 0);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(324, 33);
            this.lbComment.TabIndex = 99;
            this.lbComment.Text = "Комментарий";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.BackColor = System.Drawing.Color.White;
            this.lbPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPaymentType.Location = new System.Drawing.Point(635, 0);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.Size = new System.Drawing.Size(100, 33);
            this.lbPaymentType.TabIndex = 98;
            this.lbPaymentType.Text = "Тип оплаты";
            this.lbPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbToPay
            // 
            this.lbToPay.BackColor = System.Drawing.Color.White;
            this.lbToPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbToPay.Location = new System.Drawing.Point(555, 0);
            this.lbToPay.Name = "lbToPay";
            this.lbToPay.Size = new System.Drawing.Size(81, 33);
            this.lbToPay.TabIndex = 97;
            this.lbToPay.Text = "К оплате";
            this.lbToPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.White;
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(113, 33);
            this.lbDate.TabIndex = 96;
            this.lbDate.Text = "Дата";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(204, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(124, 33);
            this.lbName.TabIndex = 92;
            this.lbName.Text = "Наименование";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCost
            // 
            this.lbCost.BackColor = System.Drawing.Color.White;
            this.lbCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCost.Location = new System.Drawing.Point(389, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(100, 33);
            this.lbCost.TabIndex = 91;
            this.lbCost.Text = "Цена за ед.";
            this.lbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiscount
            // 
            this.lbDiscount.BackColor = System.Drawing.Color.White;
            this.lbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDiscount.Location = new System.Drawing.Point(488, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(68, 33);
            this.lbDiscount.TabIndex = 93;
            this.lbDiscount.Text = "Скидка";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategory
            // 
            this.lbCategory.BackColor = System.Drawing.Color.White;
            this.lbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCategory.Location = new System.Drawing.Point(112, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(93, 33);
            this.lbCategory.TabIndex = 95;
            this.lbCategory.Text = "Категория";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCount
            // 
            this.lbCount.BackColor = System.Drawing.Color.White;
            this.lbCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(327, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(63, 33);
            this.lbCount.TabIndex = 94;
            this.lbCount.Text = "Кол-во";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbPaymentType);
            this.Controls.Add(this.lbToPay);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbCount);
            this.Name = "CostItemControl";
            this.Size = new System.Drawing.Size(1059, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbPaymentType;
        private System.Windows.Forms.Label lbToPay;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbCount;
    }
}
