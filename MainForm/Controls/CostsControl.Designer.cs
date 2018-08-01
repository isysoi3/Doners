namespace UI_Example.Controls
{
    partial class CostsControl
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
            this.gbCashBook = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbComment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbSizeCommon = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.gbCashBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCashBook
            // 
            this.gbCashBook.Controls.Add(this.btAdd);
            this.gbCashBook.Controls.Add(this.lbComment);
            this.gbCashBook.Controls.Add(this.label3);
            this.gbCashBook.Controls.Add(this.label1);
            this.gbCashBook.Controls.Add(this.lbDate);
            this.gbCashBook.Controls.Add(this.panel);
            this.gbCashBook.Controls.Add(this.label27);
            this.gbCashBook.Controls.Add(this.label29);
            this.gbCashBook.Controls.Add(this.label25);
            this.gbCashBook.Controls.Add(this.lbSizeCommon);
            this.gbCashBook.Controls.Add(this.label);
            this.gbCashBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbCashBook.Location = new System.Drawing.Point(0, 0);
            this.gbCashBook.Name = "gbCashBook";
            this.gbCashBook.Size = new System.Drawing.Size(1120, 510);
            this.gbCashBook.TabIndex = 87;
            this.gbCashBook.TabStop = false;
            this.gbCashBook.Text = "Книга расходов";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(505, 480);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(110, 23);
            this.btAdd.TabIndex = 91;
            this.btAdd.Text = "Добавить расход";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComment.Location = new System.Drawing.Point(769, 16);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(315, 33);
            this.lbComment.TabIndex = 90;
            this.lbComment.Text = "Комментарий";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(670, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 89;
            this.label3.Text = "Тип оплаты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(590, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 88;
            this.label1.Text = "К оплате";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(6, 16);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(113, 33);
            this.lbDate.TabIndex = 82;
            this.lbDate.Text = "Дата";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(6, 52);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1110, 425);
            this.panel.TabIndex = 81;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(239, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 33);
            this.label27.TabIndex = 75;
            this.label27.Text = "Наименование";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(424, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 33);
            this.label29.TabIndex = 74;
            this.label29.Text = "Цена за ед.";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(523, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 33);
            this.label25.TabIndex = 76;
            this.label25.Text = "Скидка";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSizeCommon
            // 
            this.lbSizeCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSizeCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSizeCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSizeCommon.Location = new System.Drawing.Point(118, 16);
            this.lbSizeCommon.Name = "lbSizeCommon";
            this.lbSizeCommon.Size = new System.Drawing.Size(122, 33);
            this.lbSizeCommon.TabIndex = 79;
            this.lbSizeCommon.Text = "Категория";
            this.lbSizeCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(362, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 33);
            this.label.TabIndex = 77;
            this.label.Text = "Кол-во";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCashBook);
            this.Name = "CostsControl";
            this.Size = new System.Drawing.Size(1120, 510);
            this.gbCashBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCashBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbSizeCommon;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Button btAdd;
    }
}
