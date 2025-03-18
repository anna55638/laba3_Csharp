using System;
using System.Windows.Forms;

namespace laba3_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов, созданных в дизайнере
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                int numerator1 = int.Parse(txtNumerator1.Text);
                int denominator1 = int.Parse(txtDenominator1.Text);
                int numerator2 = int.Parse(txtNumerator2.Text);
                int denominator2 = int.Parse(txtDenominator2.Text);

                // Создаем объекты Fraction
                Fraction f1 = new Fraction(numerator1, denominator1);
                Fraction f2 = new Fraction(numerator2, denominator2);

                Fraction result = null;

                // Выполняем операцию в зависимости от выбора в ComboBox
                switch (cmbOperation.SelectedItem?.ToString())
                {
                    case "+":
                        result = f1.Add(f2);
                        break;
                    case "-":
                        result = f1.Subtract(f2);
                        break;
                    case "*":
                        result = f1.Multiply(f2);
                        break;
                    case "/":
                        result = f1.Divide(f2);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation selected.");
                }

                // Выводим результат в Label
                lblResult.Text = result?.ToString() ?? "Error: No result";
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение
                lblResult.Text = "Error: " + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}





    

