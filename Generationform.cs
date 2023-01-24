using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Generationform : Form
    {
        public Generationform()
        {
            InitializeComponent();
        }

        private void выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void N_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xнулевое_TextChanged(object sender, EventArgs e)
        {

        }
        static Generation _generation;
        private void ButGen_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(N.Text);
            int x0 = Convert.ToInt32(Xнулевое.Text);

            //пример правильной инициализации объекта класса
            _generation = new Generation()
            {
                N = n,
                X0 = x0
            };

            _generation.GenerationPrimeNumber();
            Вывод_Дан.Text = string.Join(" ", _generation.PrimeNumber);
            //Console.WriteLine(string.Join(" ", _generation.PrimeNumber));
            _generation.GenerationNumber();
            //Console.WriteLine(string.Join(" ", _generation.Numbers));
            //Console.Read();
            Вывод_Дан.Text = Вывод_Дан.Text +"\n"+ string.Join(" ", _generation.Numbers);
        }

        private void Вывод_Дан_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
