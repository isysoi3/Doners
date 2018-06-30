namespace UI_Example.Controls
{
    partial class OrderControl
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
            this.lbOrderId = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.BackColor = System.Drawing.Color.White;
            this.lbOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderId.Location = new System.Drawing.Point(8, 13);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(42, 33);
            this.lbOrderId.TabIndex = 71;
            this.lbOrderId.Text = "10";
            this.lbOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.White;
            this.btRemove.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btRemove.Location = new System.Drawing.Point(778, 13);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(26, 22);
            this.btRemove.TabIndex = 66;
            this.btRemove.Text = "Х";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.btRemove);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(813, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Button btRemove;
    }
}
