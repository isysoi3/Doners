﻿namespace UI_Example.Controls
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
            this.lbTime = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.BackColor = System.Drawing.Color.White;
            this.lbOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderId.Location = new System.Drawing.Point(5, 5);
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
            this.btRemove.Location = new System.Drawing.Point(1020, 0);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(26, 22);
            this.btRemove.TabIndex = 66;
            this.btRemove.Text = "Х";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.White;
            this.lbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(46, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(100, 33);
            this.lbTime.TabIndex = 77;
            this.lbTime.Text = "14:22:22";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbState
            // 
            this.lbState.BackColor = System.Drawing.Color.White;
            this.lbState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbState.Location = new System.Drawing.Point(0, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(1020, 43);
            this.lbState.TabIndex = 78;
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.lbState);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(1046, 43);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbState;
    }
}
