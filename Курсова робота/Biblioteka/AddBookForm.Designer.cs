namespace Biblioteka
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(3, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Заповніть анкету для того щоб додати книгу";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(30, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Назва:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(30, 110);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(100, 23);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Автор:";
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(30, 150);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(100, 23);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Жанр:";
            // 
            // lblPages
            // 
            this.lblPages.Location = new System.Drawing.Point(30, 190);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(100, 23);
            this.lblPages.TabIndex = 7;
            this.lblPages.Text = "Сторінок:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(130, 110);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(130, 150);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 6;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(130, 190);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 22);
            this.txtPages.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Додати";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(250, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Назад";
            // 
            // AddBookForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Name = "AddBookForm";
            this.Text = "Додавання книги";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
