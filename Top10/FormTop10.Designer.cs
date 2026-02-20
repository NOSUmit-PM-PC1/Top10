namespace Top10
{
    partial class FormTop10
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
            this.listViewTop10 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewTop10
            // 
            this.listViewTop10.HideSelection = false;
            this.listViewTop10.Location = new System.Drawing.Point(83, 52);
            this.listViewTop10.Name = "listViewTop10";
            this.listViewTop10.Size = new System.Drawing.Size(317, 417);
            this.listViewTop10.TabIndex = 0;
            this.listViewTop10.TabStop = false;
            this.listViewTop10.UseCompatibleStateImageBehavior = false;
            this.listViewTop10.View = System.Windows.Forms.View.List;
            // 
            // FormTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 533);
            this.Controls.Add(this.listViewTop10);
            this.Name = "FormTop10";
            this.Text = "FormTop10";
            this.Load += new System.EventHandler(this.FormTop10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTop10;
    }
}