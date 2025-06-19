using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class AuthorSearchForm : Form
    {
        public AuthorSearchForm()
        {
            InitializeComponent();

            txtAuthor.Text = "Введіть автора";
            txtAuthor.ForeColor = Color.Gray;
            txtAuthor.GotFocus += RemoveText;
            txtAuthor.LostFocus += AddText;

            btnSearch.Click += btnSearch_Click;
            btnBack.Click += btnBack_Click;
            this.Load += AuthorSearchForm_Load;
        }

        private void AuthorSearchForm_Load(object sender, EventArgs e)
        {
          
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Введіть автора")
            {
                txtAuthor.Text = "";
                txtAuthor.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                txtAuthor.Text = "Введіть автора";
                txtAuthor.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string authorQuery = txtAuthor.Text.Trim().ToLower();

            if (authorQuery == "" || authorQuery == "введіть автора")
            {
                MessageBox.Show("Будь ласка, введіть ім’я автора для пошуку.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var matchingBooks = BookStorage.Books
                .Where(b => b.Author.ToLower().Contains(authorQuery))
                .ToList();

            if (matchingBooks.Count == 0)
            {
                MessageBox.Show("Автор не знайдений!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewResults.DataSource = null;
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Назва");
            table.Columns.Add("Автор");
            table.Columns.Add("Жанр");
            table.Columns.Add("Кількість сторінок");

            foreach (var book in matchingBooks)
            {
                table.Rows.Add(book.Title, book.Author, book.Genre, book.Pages);
            }

            dataGridViewResults.DataSource = null;
            dataGridViewResults.DataSource = table;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm form = new SearchForm();
            form.Show();
        }

        private void AuthorSearchForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
