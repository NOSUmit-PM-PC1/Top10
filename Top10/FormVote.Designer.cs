namespace Top10
{
    partial class FormVote
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
            this.listBoxUniqeSinger = new System.Windows.Forms.ListBox();
            this.textBoxSinger1 = new System.Windows.Forms.TextBox();
            this.textBoxSinger2 = new System.Windows.Forms.TextBox();
            this.textBoxSinger3 = new System.Windows.Forms.TextBox();
            this.buttonVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUniqeSinger
            // 
            this.listBoxUniqeSinger.FormattingEnabled = true;
            this.listBoxUniqeSinger.Location = new System.Drawing.Point(480, 69);
            this.listBoxUniqeSinger.Name = "listBoxUniqeSinger";
            this.listBoxUniqeSinger.Size = new System.Drawing.Size(197, 303);
            this.listBoxUniqeSinger.TabIndex = 0;
            // 
            // textBoxSinger1
            // 
            this.textBoxSinger1.Location = new System.Drawing.Point(108, 92);
            this.textBoxSinger1.Name = "textBoxSinger1";
            this.textBoxSinger1.Size = new System.Drawing.Size(181, 20);
            this.textBoxSinger1.TabIndex = 1;
            // 
            // textBoxSinger2
            // 
            this.textBoxSinger2.Location = new System.Drawing.Point(108, 138);
            this.textBoxSinger2.Name = "textBoxSinger2";
            this.textBoxSinger2.Size = new System.Drawing.Size(181, 20);
            this.textBoxSinger2.TabIndex = 2;
            // 
            // textBoxSinger3
            // 
            this.textBoxSinger3.Location = new System.Drawing.Point(108, 194);
            this.textBoxSinger3.Name = "textBoxSinger3";
            this.textBoxSinger3.Size = new System.Drawing.Size(181, 20);
            this.textBoxSinger3.TabIndex = 3;
            // 
            // buttonVote
            // 
            this.buttonVote.Location = new System.Drawing.Point(108, 283);
            this.buttonVote.Name = "buttonVote";
            this.buttonVote.Size = new System.Drawing.Size(181, 23);
            this.buttonVote.TabIndex = 4;
            this.buttonVote.Text = "Проголосовать";
            this.buttonVote.UseVisualStyleBackColor = true;
            this.buttonVote.Click += new System.EventHandler(this.buttonVote_Click);
            // 
            // FormVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVote);
            this.Controls.Add(this.textBoxSinger3);
            this.Controls.Add(this.textBoxSinger2);
            this.Controls.Add(this.textBoxSinger1);
            this.Controls.Add(this.listBoxUniqeSinger);
            this.Name = "FormVote";
            this.Text = "Голосуй за 3 любимых исполнителей";
            this.Load += new System.EventHandler(this.FormVote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUniqeSinger;
        private System.Windows.Forms.TextBox textBoxSinger1;
        private System.Windows.Forms.TextBox textBoxSinger2;
        private System.Windows.Forms.TextBox textBoxSinger3;
        private System.Windows.Forms.Button buttonVote;
    }
}

