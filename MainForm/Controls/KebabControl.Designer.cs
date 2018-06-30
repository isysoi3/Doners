namespace UI_Example.Controls
{
    partial class KebabControl
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
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbSauces = new System.Windows.Forms.Label();
            this.lbPitaType = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.Color.White;
            this.lbComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbComment.Location = new System.Drawing.Point(545, 13);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(366, 33);
            this.lbComment.TabIndex = 74;
            this.lbComment.Text = "Комментарий";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQuantity
            // 
            this.lbQuantity.BackColor = System.Drawing.Color.White;
            this.lbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuantity.Location = new System.Drawing.Point(495, 13);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(52, 33);
            this.lbQuantity.TabIndex = 73;
            this.lbQuantity.Text = "1";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSauces
            // 
            this.lbSauces.BackColor = System.Drawing.Color.White;
            this.lbSauces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSauces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSauces.Location = new System.Drawing.Point(177, 13);
            this.lbSauces.Name = "lbSauces";
            this.lbSauces.Size = new System.Drawing.Size(164, 33);
            this.lbSauces.TabIndex = 72;
            this.lbSauces.Text = "Сырный";
            this.lbSauces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPitaType
            // 
            this.lbPitaType.BackColor = System.Drawing.Color.White;
            this.lbPitaType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPitaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPitaType.Location = new System.Drawing.Point(340, 13);
            this.lbPitaType.Name = "lbPitaType";
            this.lbPitaType.Size = new System.Drawing.Size(155, 33);
            this.lbPitaType.TabIndex = 71;
            this.lbPitaType.Text = "Пшеничный";
            this.lbPitaType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSize
            // 
            this.lbSize.BackColor = System.Drawing.Color.White;
            this.lbSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSize.Location = new System.Drawing.Point(14, 13);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(164, 33);
            this.lbSize.TabIndex = 75;
            this.lbSize.Text = "Большая";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KebabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbSauces);
            this.Controls.Add(this.lbPitaType);
            this.Name = "KebabControl";
            this.Size = new System.Drawing.Size(912, 63);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbSauces;
        private System.Windows.Forms.Label lbPitaType;
        private System.Windows.Forms.Label lbSize;
    }
}
