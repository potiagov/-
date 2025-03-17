using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лаболаторна_робота__15
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtIn1.Text);
            double y = Convert.ToDouble(txtIn2.Text);
            double result = (Math.Exp(x) - Math.Pow(y, 2) + 12 * x * y - 3 * Math.Pow(x, 2)) / (18 * y - 1);
            lblOut.Text = result.ToString();
        }

        private void txtIn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtIn1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnOK.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtIn2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtIn3.Text);
            double y = Convert.ToDouble(txtIn4.Text);
            double result = x + y;
            lblOut2.Text = result.ToString();
            double result1 = x - y;
            lblOut3.Text = result1.ToString();
            double result3 = x * y;
            lblOut4.Text = result3.ToString();
            double result4 = x / y;
            lblOut5.Text = result4.ToString();

        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(txtIn5.Text);
            if (N < 100 || N > 999)
            {
                MessageBox.Show("Введи тризначне число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int a = N / 100;
            int b = (N / 10) % 10;
            int c = N % 10;
            bool isGeometric = (b * b == a * c);
            lblOut6.Text = isGeometric.ToString();

        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            // Отримуємо введені числа
            double a = Convert.ToDouble(txtIn6.Text);
            double b = Convert.ToDouble(txtIn7.Text);
            double c = Convert.ToDouble(txtIn8.Text);

            // Перевіряємо умову
            if (a >= b && b >= c)
            {
                // Подвоюємо числа
                double result = a * 2;
                lblOut7.Text = result.ToString();
                double result1 = b * 2; ;
                lblOut8.Text = result1.ToString();
                double result2 = c * 2;
                lblOut9.Text = result2.ToString();
            }
            else
            {
                // Замінюємо на абсолютні значення
                a = Math.Abs(a);
                b = Math.Abs(b);
                c = Math.Abs(c);
            }

            // Виводимо результати
            lblOut7.Text = a.ToString("F2");
            lblOut8.Text = b.ToString("F2");
            lblOut9.Text = c.ToString("F2");

        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            string input = txtIn9.Text;
            if (!long.TryParse(input, out _))
            {
                MessageBox.Show("Введи ціле число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = new string(input.Where(c => c != '1').ToArray());
            if (string.IsNullOrEmpty(result))
            {
                result = "0";
            }
            lblOut10.Text = "Результат: " + result;
        }

        private void btnOK6_Click(object sender, EventArgs e)
        {
            string input = txtIn10.Text;
            string[] numbers = input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            var integers = numbers.Select(n => int.TryParse(n, out int num) ? num : -1)
                                  .Where(n => n > 0)
                                  .ToArray();

            if (integers.Length == 0)
            {
                MessageBox.Show("Введи хоча б одне додатне число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var perfectSquares = integers.Where(n => Math.Sqrt(n) % 1 == 0).ToArray();
            lblOut11.Text = perfectSquares.Length > 0
                ? "Квадрати чисел: " + string.Join(", ", perfectSquares)
                : "Немає чисел, які є повними квадратами.";

        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            string input = txtIn11.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введи текст!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = Regex.Replace(input, @"\s+", ", ");

            lblOut12.Text = result;

        }
    }
        }

