namespace MegaDesk_Poe1
{
    partial class MainMenu
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
            this.ViewAllQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.AddQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewAllQuotes
            // 
            this.ViewAllQuotes.Location = new System.Drawing.Point(12, 12);
            this.ViewAllQuotes.Name = "ViewAllQuotes";
            this.ViewAllQuotes.Size = new System.Drawing.Size(106, 23);
            this.ViewAllQuotes.TabIndex = 0;
            this.ViewAllQuotes.Text = "View All Quotes";
            this.ViewAllQuotes.UseVisualStyleBackColor = true;
            this.ViewAllQuotes.Click += new System.EventHandler(this.ViewAllQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Location = new System.Drawing.Point(12, 41);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(106, 23);
            this.SearchQuotes.TabIndex = 1;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // AddQuote
            // 
            this.AddQuote.Location = new System.Drawing.Point(12, 70);
            this.AddQuote.Name = "AddQuote";
            this.AddQuote.Size = new System.Drawing.Size(106, 23);
            this.AddQuote.TabIndex = 2;
            this.AddQuote.Text = "Add Quote";
            this.AddQuote.UseVisualStyleBackColor = true;
            this.AddQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddQuote);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewAllQuotes);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewAllQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button AddQuote;
    }
}

