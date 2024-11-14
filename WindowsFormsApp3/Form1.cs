using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            label2.Visible = false; // скрываю надпись при запуске
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверяю заполнение полей
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                label2.Text = "ошибка: заполните все поля"; // пишу проблему
                label2.Visible = true;
                return;
            }
            // проверяю, что все стороны целые значения
            if (!int.TryParse(textBox1.Text, out int sideA) ||
                !int.TryParse(textBox2.Text, out int sideB) ||
                !int.TryParse(textBox3.Text, out int sideC))
            {
                label2.Text = "ошибка: вводите только целые числа"; // пишу проблему
                label2.Visible = true;
                return;
            }
            // проверяю, что все положительные стороны 
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                label2.Text = "ошибка: используйте только положительные числа"; // пишу проблему
                label2.Visible = true;
                return;
            }
            // проверяю на правило треугольника
            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                label2.Text = "ошибка: сумма двух сторон должна быть больше третьей"; // пишу проблему
                label2.Visible = true;
                return;
            }
            // определяю вид треугольника
            if (sideA == sideB && sideB == sideC)
            {
                label2.Text = "треугольник равносторонний"; // вывожу вид треугольника
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                label2.Text = "треугольник равнобедренный"; // вывожу вид треугольника
            }
            else
            {
                label2.Text = "треугольник разносторонний"; // вывожу вид треугольника
            }
            label2.Visible = true;
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  
            textBox2.Text = "";  
            textBox3.Text = "";  
            label2.Text = "";    
        }

       
    }
}
