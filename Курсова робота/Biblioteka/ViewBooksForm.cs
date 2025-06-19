using System;
using System.Data;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class ViewBooksForm : Form
    {
        public ViewBooksForm()
        {
            InitializeComponent();
            LoadBooks();
        }
        private void LoadBooks()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Назва");
            table.Columns.Add("Автор");
            table.Columns.Add("Жанр");
            table.Columns.Add("Кількість сторінок");
            foreach (var book in BookStorage.Books)
            {
                table.Rows.Add(book.Title, book.Author, book.Genre, book.Pages);
            }
            dataGridViewBooks.DataSource = table;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
        }

        private void ViewBooksForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}
