namespace UI_Example.Controls
{
    partial class CashBookItemControl
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
            this.lbDiff = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbBegin = new System.Windows.Forms.Label();
            this.lbIn = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.lbCashier = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbDiff
            // 
            this.lbDiff.BackColor = System.Drawing.Color.White;
            this.lbDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDiff.Location = new System.Drawing.Point(944, 0);
            this.lbDiff.Name = "lbDiff";
            this.lbDiff.Size = new System.Drawing.Size(114, 33);
            this.lbDiff.TabIndex = 97;
            this.lbDiff.Text = "Разница";
            this.lbDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(778, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(168, 33);
            this.lbTotal.TabIndex = 96;
            this.lbTotal.Text = "Итого за смену";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.White;
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(130, 33);
            this.lbDate.TabIndex = 95;
            this.lbDate.Text = "Дата";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBegin
            // 
            this.lbBegin.BackColor = System.Drawing.Color.White;
            this.lbBegin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBegin.Location = new System.Drawing.Point(278, 0);
            this.lbBegin.Name = "lbBegin";
            this.lbBegin.Size = new System.Drawing.Size(160, 33);
            this.lbBegin.TabIndex = 91;
            this.lbBegin.Text = "Начало смены";
            this.lbBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIn
            // 
            this.lbIn.BackColor = System.Drawing.Color.White;
            this.lbIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIn.Location = new System.Drawing.Point(594, 0);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(93, 33);
            this.lbIn.TabIndex = 90;
            this.lbIn.Text = "Приход";
            this.lbIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOut
            // 
            this.lbOut.BackColor = System.Drawing.Color.White;
            this.lbOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOut.Location = new System.Drawing.Point(686, 0);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(93, 33);
            this.lbOut.TabIndex = 92;
            this.lbOut.Text = "Расход";
            this.lbOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCashier
            // 
            this.lbCashier.BackColor = System.Drawing.Color.White;
            this.lbCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCashier.Location = new System.Drawing.Point(129, 0);
            this.lbCashier.Name = "lbCashier";
            this.lbCashier.Size = new System.Drawing.Size(150, 33);
            this.lbCashier.TabIndex = 94;
            this.lbCashier.Text = "Кассир";
            this.lbCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEnd
            // 
            this.lbEnd.BackColor = System.Drawing.Color.White;
            this.lbEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEnd.Location = new System.Drawing.Point(437, 0);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(158, 33);
            this.lbEnd.TabIndex = 93;
            this.lbEnd.Text = "Конец смены";
            this.lbEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 30000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 40;
            // 
            // CashBookItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDiff);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbBegin);
            this.Controls.Add(this.lbIn);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbCashier);
            this.Controls.Add(this.lbEnd);
            this.Name = "CashBookItemControl";
            this.Size = new System.Drawing.Size(1059, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDiff;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbBegin;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.Label lbCashier;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
