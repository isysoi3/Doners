namespace UI_Example.Controls
{
    partial class HistoryControl
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
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.btShow = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbSizeCommon = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this.gbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.btShow);
            this.gbHistory.Controls.Add(this.dtpTo);
            this.gbHistory.Controls.Add(this.label4);
            this.gbHistory.Controls.Add(this.dtpFrom);
            this.gbHistory.Controls.Add(this.label3);
            this.gbHistory.Controls.Add(this.label2);
            this.gbHistory.Controls.Add(this.panel);
            this.gbHistory.Controls.Add(this.label27);
            this.gbHistory.Controls.Add(this.label29);
            this.gbHistory.Controls.Add(this.label1);
            this.gbHistory.Controls.Add(this.label25);
            this.gbHistory.Controls.Add(this.lbSizeCommon);
            this.gbHistory.Controls.Add(this.lbComment);
            this.gbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbHistory.Location = new System.Drawing.Point(0, 0);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(1070, 513);
            this.gbHistory.TabIndex = 85;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "История заказов";
            this.gbHistory.Enter += new System.EventHandler(this.gbHistory_Enter);
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShow.Location = new System.Drawing.Point(960, 23);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(85, 23);
            this.btShow.TabIndex = 87;
            this.btShow.Text = "Вывести";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Location = new System.Drawing.Point(419, 22);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(174, 24);
            this.dtpTo.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Заказы по:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Location = new System.Drawing.Point(115, 22);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(174, 24);
            this.dtpFrom.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Заказы с:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 82;
            this.label2.Text = "Дата";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(6, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1058, 412);
            this.panel.TabIndex = 81;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(383, 59);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(140, 33);
            this.label27.TabIndex = 75;
            this.label27.Text = "Соус";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(522, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 33);
            this.label29.TabIndex = 74;
            this.label29.Text = "Лаваш";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 80;
            this.label1.Text = "Время";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(661, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 33);
            this.label25.TabIndex = 76;
            this.label25.Text = "Кол";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // lbSizeCommon
            // 
            this.lbSizeCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbSizeCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSizeCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSizeCommon.Location = new System.Drawing.Point(234, 59);
            this.lbSizeCommon.Name = "lbSizeCommon";
            this.lbSizeCommon.Size = new System.Drawing.Size(150, 33);
            this.lbSizeCommon.TabIndex = 79;
            this.lbSizeCommon.Text = "Размер";
            this.lbSizeCommon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSizeCommon.Click += new System.EventHandler(this.lbSizeCommon_Click);
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComment.Location = new System.Drawing.Point(710, 59);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(335, 33);
            this.lbComment.TabIndex = 77;
            this.lbComment.Text = "Комментарий";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbComment.Click += new System.EventHandler(this.lbComment_Click);
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbHistory);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(1070, 513);
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbSizeCommon;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
    }
}
