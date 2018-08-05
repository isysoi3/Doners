namespace UI_Example.Controls
{
    partial class SellsBookControl
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
            this.gbSellsBook = new System.Windows.Forms.GroupBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbSizeCommon = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.gbSellsBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSellsBook
            // 
            this.gbSellsBook.Controls.Add(this.lbDate);
            this.gbSellsBook.Controls.Add(this.panel);
            this.gbSellsBook.Controls.Add(this.label27);
            this.gbSellsBook.Controls.Add(this.label29);
            this.gbSellsBook.Controls.Add(this.label1);
            this.gbSellsBook.Controls.Add(this.label25);
            this.gbSellsBook.Controls.Add(this.lbSizeCommon);
            this.gbSellsBook.Controls.Add(this.lbComment);
            this.gbSellsBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbSellsBook.Location = new System.Drawing.Point(0, 0);
            this.gbSellsBook.Name = "gbSellsBook";
            this.gbSellsBook.Size = new System.Drawing.Size(1120, 510);
            this.gbSellsBook.TabIndex = 84;
            this.gbSellsBook.TabStop = false;
            this.gbSellsBook.Text = "Книга продаж";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(6, 29);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(130, 33);
            this.lbDate.TabIndex = 82;
            this.lbDate.Text = "Дата";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(6, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1111, 440);
            this.panel.TabIndex = 81;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(383, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(140, 33);
            this.label27.TabIndex = 75;
            this.label27.Text = "Соус/Тип";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(522, 29);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 33);
            this.label29.TabIndex = 74;
            this.label29.Text = "Лаваш";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 80;
            this.label1.Text = "Время";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(661, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 33);
            this.label25.TabIndex = 76;
            this.label25.Text = "Кол";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSizeCommon
            // 
            this.lbSizeCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSizeCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSizeCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSizeCommon.Location = new System.Drawing.Point(234, 29);
            this.lbSizeCommon.Name = "lbSizeCommon";
            this.lbSizeCommon.Size = new System.Drawing.Size(150, 33);
            this.lbSizeCommon.TabIndex = 79;
            this.lbSizeCommon.Text = "Размер";
            this.lbSizeCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComment.Location = new System.Drawing.Point(710, 29);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(375, 33);
            this.lbComment.TabIndex = 77;
            this.lbComment.Text = "Комментарий";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellsBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSellsBook);
            this.Name = "SellsBookControl";
            this.Size = new System.Drawing.Size(1120, 510);
            this.Load += new System.EventHandler(this.SellsBookControl_Load);
            this.gbSellsBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSellsBook;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbSizeCommon;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbDate;
    }
}
