using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorSearchForm authorSearchForm = new AuthorSearchForm();
            authorSearchForm.Show();
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitleSearchForm titleSearchForm = new TitleSearchForm();
            titleSearchForm.Show();
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBooksForm viewBooksForm = new ViewBooksForm();
            viewBooksForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchAuthor_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AuthorSearchForm form = new AuthorSearchForm(); 
            form.Show();
        }

        private void btnSearchTitle_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TitleSearchForm form = new TitleSearchForm();
            form.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBooksForm form = new ViewBooksForm();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm form = new AddBookForm();
            form.Show();
        }
    }
}