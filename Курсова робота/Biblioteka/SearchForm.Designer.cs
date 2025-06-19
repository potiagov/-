namespace Biblioteka
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Бібліотека";
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(100, 80);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(220, 23);
            this.btnSearchAuthor.TabIndex = 1;
            this.btnSearchAuthor.Text = "Пошук за автором";
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click_1);
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.Location = new System.Drawing.Point(100, 130);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(223, 23);
            this.btnSearchTitle.TabIndex = 2;
            this.btnSearchTitle.Text = "Пошук за назвою";
            this.btnSearchTitle.Click += new System.EventHandler(this.btnSearchTitle_Click_1);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(100, 229);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(223, 23);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "Перегляд усіх книг";
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(100, 180);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(223, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Додати книги";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchForm";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);

        }
    }
}
