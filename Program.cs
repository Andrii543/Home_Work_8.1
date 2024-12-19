using System.Text;

namespace Home_Work_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            #region 1 Завдання 
            //var rnd = new Random();


            //int[] randomArray = new int[10];

            //for (int i = 1; i < randomArray.Length; i++)
            //{
            //    randomArray[i] = rnd.Next(-10, 10);
            //}

            //За домомогою foreach

            //int index = 0;
            //foreach (int item in randomArray)
            //{
            //    if (index % 2 == 0)
            //    {
            //        Console.WriteLine($"Парні індекси {index}: випадкове число {item}");
            //    }
            //    index++;
            //}

            //за допомогою for

            //for (int i = 1; i < randomArray.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"Парні індекси {i}: випадкове число {randomArray[i]}");
            //    }
            //}

            #endregion


            #region 2 Завдання

            //int sum = 0;

            //Console.WriteLine("Всі індекси з числами");

            //for (int i = 1; i < randomArray.Length; i++)
            //{
            //    Console.WriteLine($"Індекс {i}: число {randomArray[i]}   ");

            //    sum += randomArray[i];


            //}
            //if (sum >= 0)
            //{
            //    Console.Write($"Сума елементів масиву є невід'ємною: {sum}");
            //}
            //else
            //{
            //    Console.Write($"Сума елементів масиву є від'ємною: {sum}");
            //}






            #endregion


            #region 3 Завдання

            //const int size = 9;

            //int[,] arrayNumber = new int[size, size];

            //int sum = 0;

            //for (int i = 1; i <= size; i++)
            //{
            //    for (int j = 1; j <= size; j++)
            //    {
            //        sum = i * j;

            //        Console.Write($"{sum}  ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region 4 Завдання

            var rnd = new Random();

            const int size = 5;

            int[,] array = new int[size, size];

            int maxValue = 0, minValue = 0;
            int maxRow = 0, maxCol = 0, minRow = 0, minCol = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = rnd.Next(0, 100);

                    if (i == 0 && j == 0)
                    {
                        maxValue = minValue = array[i, j];
                        maxRow = minRow = i + 1;
                        maxCol = minCol = j + 1;
                    }
                    else
                    {

                        if (array[i, j] > maxValue)
                        {
                            maxValue = array[i, j];
                            maxRow = i + 1; maxCol = j + 1;
                        }

                        if (array[i, j] < minValue)
                        {
                            minValue = array[i, j];
                            minRow = i + 1; minCol = j + 1;
                        }
                    }

                    Console.Write($"{array[i, j]}  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Максимальне число {maxValue} координати: Стовпчик {maxRow} Рядок {maxCol}");
            Console.WriteLine($"Мінімальне число {minValue} координати: Стовпчик {minRow} Рядок {minCol}");


            #endregion


            #region 5 Завдання 

            //Console.Write("Введіть число дня для відображення ");

            //int userInput = Convert.ToInt32(Console.ReadLine());

            //// Понеділок починається від 1, 0 немає
            //if (userInput == 0)
            //{
            //    Console.WriteLine("Дні тижня задаються від 1");
            //}
            //else
            //{
            //    int offset = userInput % 7;
            //    Days resultDays = (Days)((int)Days.Monday + offset - 1); // (Days)((int)Days.Monday + offset) для зміщення днів, -1 для коректного виводу

            //    Console.WriteLine($"{resultDays}");
            //}



            #endregion

        }


        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
