using System;
using System.Windows.Forms;

namespace laba3_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int numerator1 = int.Parse(txtNumerator1.Text);
                int denominator1 = int.Parse(txtDenominator1.Text);
                int numerator2 = int.Parse(txtNumerator2.Text);
                int denominator2 = int.Parse(txtDenominator2.Text);

                Fraction f1 = new Fraction(numerator1, denominator1);
                Fraction f2 = new Fraction(numerator2, denominator2);

                Fraction result = null;
                string comparisonResult = "";

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
                    case "��������":
                        int comparison = f1.CompareTo(f2);
                        if (comparison == -1)
                            comparisonResult = "����� 1 ������ ����� 2";
                        else if (comparison == 1)
                            comparisonResult = "����� 1 ������ ����� 2";
                        else
                            comparisonResult = "����� �����";
                        break;
                    default:
                        throw new InvalidOperationException("�� ������� ��������.");
                }

                if (cmbOperation.SelectedItem?.ToString() == "��������")
                    lblResult.Text = comparisonResult;
                else
                    lblResult.Text = result?.ToString() ?? "������: ��� ����������";
            }
            catch (FormatException)
            {
                lblResult.Text = "������: ������� ���������� �����.";
            }
            catch (Exception ex)
            {
                // ����� ������
                lblResult.Text = "������: " + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperation.Items.AddRange(new string[] { "+", "-", "*", "/", "��������" });
            cmbOperation.SelectedIndex = 0; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}