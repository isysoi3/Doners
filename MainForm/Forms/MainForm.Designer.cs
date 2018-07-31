namespace UI_Example
{
    partial class QueueForm
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
            this.btAdd = new System.Windows.Forms.Button();
            this.lbNumberCommon = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbSizeCommon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btCosts = new System.Windows.Forms.Button();
            this.btCashBook = new System.Windows.Forms.Button();
            this.btSellsBook = new System.Windows.Forms.Button();
            this.btHistory = new System.Windows.Forms.Button();
            this.btMain = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btAdd.Location = new System.Drawing.Point(318, 477);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(134, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить заказ";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.AddNewOrderButtonClick);
            // 
            // lbNumberCommon
            // 
            this.lbNumberCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNumberCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumberCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberCommon.Location = new System.Drawing.Point(5, 29);
            this.lbNumberCommon.Name = "lbNumberCommon";
            this.lbNumberCommon.Size = new System.Drawing.Size(42, 33);
            this.lbNumberCommon.TabIndex = 78;
            this.lbNumberCommon.Text = "№";
            this.lbNumberCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComment.Location = new System.Drawing.Point(623, 29);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(401, 33);
            this.lbComment.TabIndex = 77;
            this.lbComment.Text = "Комментарий";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(572, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 33);
            this.label25.TabIndex = 76;
            this.label25.Text = "Кол";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(294, 29);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(140, 33);
            this.label27.TabIndex = 75;
            this.label27.Text = "Соус";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(433, 29);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 33);
            this.label29.TabIndex = 74;
            this.label29.Text = "Лаваш";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSizeCommon
            // 
            this.lbSizeCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSizeCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSizeCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSizeCommon.Location = new System.Drawing.Point(145, 29);
            this.lbSizeCommon.Name = "lbSizeCommon";
            this.lbSizeCommon.Size = new System.Drawing.Size(150, 33);
            this.lbSizeCommon.TabIndex = 79;
            this.lbSizeCommon.Text = "Размер";
            this.lbSizeCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 80;
            this.label1.Text = "Время";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btCosts);
            this.groupBox1.Controls.Add(this.btCashBook);
            this.groupBox1.Controls.Add(this.btSellsBook);
            this.groupBox1.Controls.Add(this.btHistory);
            this.groupBox1.Controls.Add(this.btMain);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 513);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Навигация";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "График работы";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btCosts
            // 
            this.btCosts.Location = new System.Drawing.Point(6, 190);
            this.btCosts.Name = "btCosts";
            this.btCosts.Size = new System.Drawing.Size(136, 30);
            this.btCosts.TabIndex = 4;
            this.btCosts.Text = "Книга расходов";
            this.btCosts.UseVisualStyleBackColor = true;
            this.btCosts.Click += new System.EventHandler(this.btCosts_Click);
            // 
            // btCashBook
            // 
            this.btCashBook.Location = new System.Drawing.Point(6, 157);
            this.btCashBook.Name = "btCashBook";
            this.btCashBook.Size = new System.Drawing.Size(136, 27);
            this.btCashBook.TabIndex = 3;
            this.btCashBook.Text = "Кассовая книга";
            this.btCashBook.UseVisualStyleBackColor = true;
            this.btCashBook.Click += new System.EventHandler(this.btCashBook_Click);
            // 
            // btSellsBook
            // 
            this.btSellsBook.Location = new System.Drawing.Point(6, 122);
            this.btSellsBook.Name = "btSellsBook";
            this.btSellsBook.Size = new System.Drawing.Size(136, 29);
            this.btSellsBook.TabIndex = 2;
            this.btSellsBook.Text = "Книга продаж";
            this.btSellsBook.UseVisualStyleBackColor = true;
            this.btSellsBook.Click += new System.EventHandler(this.btSellsBook_Click);
            // 
            // btHistory
            // 
            this.btHistory.Location = new System.Drawing.Point(6, 67);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(136, 49);
            this.btHistory.TabIndex = 1;
            this.btHistory.Text = "История заказов";
            this.btHistory.UseVisualStyleBackColor = true;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btMain
            // 
            this.btMain.Location = new System.Drawing.Point(6, 29);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(136, 32);
            this.btMain.TabIndex = 0;
            this.btMain.Text = "Главная";
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.panel);
            this.gbMain.Controls.Add(this.label27);
            this.gbMain.Controls.Add(this.label29);
            this.gbMain.Controls.Add(this.btAdd);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.label25);
            this.gbMain.Controls.Add(this.lbSizeCommon);
            this.gbMain.Controls.Add(this.lbComment);
            this.gbMain.Controls.Add(this.lbNumberCommon);
            this.gbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbMain.Location = new System.Drawing.Point(160, 9);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1070, 504);
            this.gbMain.TabIndex = 83;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Главная";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(5, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1065, 408);
            this.panel.TabIndex = 82;
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 517);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.groupBox1);
            this.Name = "QueueForm";
            this.Text = "*Заголовок открытой страницы*";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueueForm_FormClosing);
            this.Resize += new System.EventHandler(this.QueueForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbNumberCommon;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbSizeCommon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btCosts;
        private System.Windows.Forms.Button btCashBook;
        private System.Windows.Forms.Button btSellsBook;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel panel;
    }
}

