using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class TitleSearchForm : Form
    {
        public TitleSearchForm()
        {
            InitializeComponent();
            txtTitle.Text = "Введіть назву книги";
            txtTitle.ForeColor = Color.Gray;
            txtTitle.GotFocus += RemoveText;
            txtTitle.LostFocus += AddText;
            btnSearch.Click += btnSearch_Click;
            btnBack.Click += btnBack_Click;
            this.Load += TitleSearchForm_Load;
        }

        private void TitleSearchForm_Load(object sender, EventArgs e)
        {

        }
        private void RemoveText(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Введіть назву книги")
            {
                txtTitle.Text = "";
                txtTitle.ForeColor = Color.Black;
            }
        }
        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.Text = "Введіть назву книги";
                txtTitle.ForeColor = Color.Gray;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string titleQuery = txtTitle.Text.Trim().ToLower();
            if (titleQuery == "" || titleQuery == "введіть назву книги")
            {
                MessageBox.Show("Будь ласка, введіть назву книги для пошуку.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var matchingBooks = BookStorage.Books
                .Where(b => b.Title.ToLower().Contains(titleQuery))
                .ToList();
            if (matchingBooks.Count == 0)
            {
                MessageBox.Show("Книгу не знайдено!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dataGridViewResults.DataSource = table;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void TitleSearchForm_Load_1(object sender, EventArgs e)
        {

        }

    }
}
