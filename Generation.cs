using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Generation
    {
        private int _n;
        private double _x0;
        private double[] _numbers;
        List<int> _primeNumber = new List<int>();

        #region Field
        public int N
        {
            get => _n;
            set => _n = value;
        }
        public double X0
        {
            get => _x0;
            set => _x0 = value;
        }
        public double[] Numbers
        {
            get => _numbers;
        }
        public List<int> PrimeNumber
        {
            get => _primeNumber;
            set => _primeNumber = value;
        }
        #endregion

        /// <summary>
        /// Тест ферма
        /// </summary>
        /// <param name="a">рандомно сгенерирванное число</param>
        /// <param name="n">для какого числа проводим тест Ферма</param>
        /// <returns></returns>
        private bool TestFerma(double a, int n)
        {
            var p = BigInteger.ModPow((BigInteger)a, n - 1, n);
            if (p != 1) //Если нечетное, то точно непростое.
            {
                return false;
            }

            return true;
        }

        public bool CheckNumber(int p)
        {
            //Объект класса Random
            Random r = new Random();

            //Проверяем P на простоту
            for (int i = 0; i < 10; i++)
            {
                //Генерируем случайное число
                double a = r.Next(2, p - 1);
                //Проводим тест Ферма
                if (!TestFerma(a, p))
                {
                    //Console.WriteLine("P cоставное число");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Метод генерации простых чисел удовлетворяющих условию p mod 4 = 3
        /// </summary>
        public void GenerationPrimeNumber()
        {
            //начинаем с тройки
            int i = 2;
            //до тех пор пока количесво простых чисел не равно 50
            while (_primeNumber.Count < _n)
            {
                //проверяем остаток от деления
                if (i % 4 == 3)
                    if (CheckNumber(i))
                        _primeNumber.Add(i);
                //увеличиваем переменную на 1
                i++;
            }
        }

        /// <summary>
        /// Метод для генерации чисел по условию
        /// </summary>
        public void GenerationNumber()
        {
            Random r = new Random();
            //инициализируем новые массив 
            _numbers = new double[_n];
            //приваиваем 0 элементу переданное значение
            _numbers[0] = _x0;
            //заполняем оставльной массив от 1 до n-1
            for (int i = 1; i < _n; i++)
            {
                _numbers[i] = (Math.Pow(_numbers[i - 1], 2) * _primeNumber[r.Next(0, _primeNumber.Count() - 1)]) % (_primeNumber[r.Next(0, _primeNumber.Count() - 1)] * _primeNumber[r.Next(0, _primeNumber.Count() - 1)]);
            }
        }
    }
}
