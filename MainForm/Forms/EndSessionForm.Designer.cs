namespace UI_Example.Forms
{
    partial class EndSessionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.btEndSession = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Касса:";
            // 
            // tbCash
            // 
            this.tbCash.Location = new System.Drawing.Point(116, 15);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(100, 20);
            this.tbCash.TabIndex = 8;
            // 
            // btEndSession
            // 
            this.btEndSession.Location = new System.Drawing.Point(81, 42);
            this.btEndSession.Name = "btEndSession";
            this.btEndSession.Size = new System.Drawing.Size(135, 23);
            this.btEndSession.TabIndex = 7;
            this.btEndSession.Text = "Закрыть смену";
            this.btEndSession.UseVisualStyleBackColor = true;
            this.btEndSession.Click += new System.EventHandler(this.btEndSession_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EndSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 78);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.btEndSession);
            this.MaximumSize = new System.Drawing.Size(295, 117);
            this.MinimumSize = new System.Drawing.Size(295, 117);
            this.Name = "EndSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закрытие смены";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.Button btEndSession;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}