using System;
using System.Windows.Forms;
using Biblioteka;

namespace Biblioteka
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(AddBookForm_Load);
            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnBack.Click += new EventHandler(btnBack_Click);
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string genre = txtGenre.Text.Trim();
            string pagesText = txtPages.Text.Trim();
            int pages;

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(genre) ||
                !int.TryParse(pagesText, out pages) || pages <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані у всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book newBook = new Book
            {
                Title = title,
                Author = author,
                Genre = genre,
                Pages = pages
            };

            BookStorage.Books.Add(newBook);

            MessageBox.Show("Книгу успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtPages.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
