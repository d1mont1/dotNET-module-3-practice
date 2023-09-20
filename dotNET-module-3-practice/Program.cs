using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            zadacha_1();
            zadacha_2();
            zadacha_3();
            zadacha_4();
            zadacha_5();
            zadacha_6();
            zadacha_7();
            zadacha_8();
            zadacha_9();
            zadacha_10();

            string_zadacha_1();
            string_zadacha_2();
            string_zadacha_3();
            string_zadacha_4();
            string_zadacha_5();
            string_zadacha_6();
            string_zadacha_7();
            string_zadacha_8();
            string_zadacha_9();
            string_zadacha_10a();
            string_zadacha_10b(5);
            string_zadacha_11();
            string_zadacha_12();
            string_zadacha_13();

            Console.ReadLine();
        }

        static void zadacha_1()
        {
            Console.WriteLine("Задача №1");

            // Объявление одномерного и двумерного массивов
            double[] A = new double[5];
            double[,] B = new double[3, 4];

            // Заполнение одномерного массива A данными, введенными с клавиатуры
            Console.WriteLine("Введите 5 чисел для массива A:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"A[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            // Заполнение двумерного массива B случайными числами
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble() * 100;
                }
            }

            // Вывод значений массива A
            Console.WriteLine("\nМассив A:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }

            // Вывод значений массива B в виде матрицы
            Console.WriteLine("\n\nМассив B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Найти общий максимальный элемент
            double maxA = A[0];
            double maxB = B[0, 0];
            foreach (double element in A)
            {
                if (element > maxA)
                {
                    maxA = element;
                }
            }
            foreach (double element in B)
            {
                if (element > maxB)
                {
                    maxB = element;
                }
            }
            double maxCommon = Math.Max(maxA, maxB);

            // Найти общий минимальный элемент
            double minA = A[0];
            double minB = B[0, 0];
            foreach (double element in A)
            {
                if (element < minA)
                {
                    minA = element;
                }
            }
            foreach (double element in B)
            {
                if (element < minB)
                {
                    minB = element;
                }
            }
            double minCommon = Math.Min(minA, minB);

            // Найти общую сумму всех элементов
            double sumCommon = 0;
            foreach (double element in A)
            {
                sumCommon += element;
            }
            foreach (double element in B)
            {
                sumCommon += element;
            }

            // Найти общее произведение всех элементов
            double productCommon = 1;
            foreach (double element in A)
            {
                productCommon *= element;
            }
            foreach (double element in B)
            {
                productCommon *= element;
            }

            // Найти сумму четных элементов массива A
            double sumEvenA = 0;
            foreach (double element in A)
            {
                if (element % 2 == 0)
                {
                    sumEvenA += element;
                }
            }

            // Найти сумму нечетных столбцов массива B
            double sumOddColumnsB = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }
            }

            // Вывод результатов
            Console.WriteLine($"\nОбщий максимальный элемент: {maxCommon}");
            Console.WriteLine($"Общий минимальный элемент: {minCommon}");
            Console.WriteLine($"Общая сумма всех элементов: {sumCommon}");
            Console.WriteLine($"Общее произведение всех элементов: {productCommon}");
            Console.WriteLine($"Сумма четных элементов массива A: {sumEvenA}");
            Console.WriteLine($"Сумма нечетных столбцов массива B: {sumOddColumnsB}");
        }
        static void zadacha_2()
        {
            Console.WriteLine("Задача №2");

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            // Создаем пустой массив для хранения общих элементов
            int[] commonElements = new int[Math.Min(array1.Length, array2.Length)];
            int commonCount = 0;

            // Перебираем элементы первого массива
            foreach (int element1 in array1)
            {
                // Проверяем, есть ли элемент во втором массиве и нет ли его уже в commonElements
                if (Array.IndexOf(array2, element1) != -1 && Array.IndexOf(commonElements, element1) == -1)
                {
                    commonElements[commonCount] = element1;
                    commonCount++;
                }
            }

            // Выводим результат
            Console.WriteLine("Общие элементы без повторений:");
            for (int i = 0; i < commonCount; i++)
            {
                Console.WriteLine(commonElements[i]);
            }
        }
        static void zadacha_3()
        {
            Console.WriteLine("Задача №3");

            Console.WriteLine("Введите строку для проверки на палиндром:");
            string input = Console.ReadLine();
            string reversedInput = new string(input.ToCharArray().Reverse().ToArray());

            if (input.Equals(reversedInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом.");
            }
        }
        static void zadacha_4()
        {
            Console.WriteLine("Задача №4");

            Console.WriteLine("Введите предложение для подсчета слов:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            Console.WriteLine($"Количество слов в предложении: {wordCount}");
        }
        static void zadacha_5()
        {
            Console.WriteLine("Задача №5");

            int[,] array = new int[5, 5];
            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            Console.WriteLine("Значения внутри массива: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("   " + array[i, j]);
                }
                Console.WriteLine();
            }

            // Находим минимальный и максимальный элементы
            int min = array[0, 0];
            int max = array[0, 0];

            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
                if (element > max)
                {
                    max = element;
                }
            }

            // Находим сумму элементов между минимальным и максимальным
            int sum = 0;
            bool betweenMinMax = false;

            foreach (int element in array)
            {
                if (element == min)
                {
                    betweenMinMax = !betweenMinMax;
                }
                else if (element == max)
                {
                    betweenMinMax = !betweenMinMax;
                }
                else if (betweenMinMax)
                {
                    sum += element;
                }
            }

            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Сумма элементов между минимальным и максимальным: {sum}");
        }
        static void zadacha_6()
        {
            Console.WriteLine("Задача №6");

            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            int currentCount = 1;
            int maxCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов: {maxCount}");
        }
        static void zadacha_7()
        {
            Console.WriteLine("Задача №7");

            Console.WriteLine("Введите строку длиной 20 символов и более:");
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.WriteLine("Строка должна быть длиной 20 символов и более.");
                return;
            }

            int digitCount = 0;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }

            Console.WriteLine($"Количество цифр в строке: {digitCount}");
        }
        static void zadacha_8()
        {
            Console.WriteLine("Задача №8");

            Console.WriteLine("Введите последовательность символов (20 букв и более):");
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.WriteLine("Строка должна быть длиной 20 символов и более.");
                return;
            }

            string name = "Димаш";

            foreach (char ch in name)
            {
                if (!input.Contains(ch))
                {
                    Console.WriteLine("Нет имени");
                    return;
                }
            }

            Console.WriteLine($"Имя: {name}");
        }
        static void zadacha_9()
        {
            Console.WriteLine("Задача №9");

            Console.WriteLine("Введите строку символов, разделенных пробелами:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            foreach (string word in words)
            {
                if (word.Length > 1 && word[0] == word[word.Length - 1])
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество слов с совпадающими первым и последним символами: {count}");
        }
        static void zadacha_10()
        {
            Console.WriteLine("Задача №10");

            Console.WriteLine("Введите малую русскую букву:");
            char lowercaseLetter = Console.ReadLine()[0];

            if (char.IsLower(lowercaseLetter) && char.IsLetter(lowercaseLetter))
            {
                char uppercaseLetter = char.ToUpper(lowercaseLetter);
                Console.WriteLine($"Соответствующая большая буква: {uppercaseLetter}");
            }
            else
            {
                Console.WriteLine("Это не малая русская буква.");
            }
        }

        static void string_zadacha_1()
        {
            Console.WriteLine("Задача со строками №1");

            string word = "программирование";
            int length = word.Length;

            string part1 = word.Substring(0, length / 3);
            string part2 = word.Substring(length / 3, length / 3);
            string part3 = word.Substring(2 * (length / 3), length / 3);

            string result = part2 + part3 + part1;

            Console.WriteLine($"Исходное слово: {word}");
            Console.WriteLine($"Результат (а): {result}");
        }

        static void string_zadacha_2()
        {
            Console.WriteLine("Задача со строками №2");

            string text = "Это текст с символами + и - и еще - и +.";
            int plusCount = 0;
            int minusCount = 0;

            foreach (char ch in text)
            {
                if (ch == '+')
                {
                    plusCount++;
                }
                else if (ch == '-')
                {
                    minusCount++;
                }
            }

            Console.WriteLine($"Число символов '+': {plusCount}");
            Console.WriteLine($"Число символов '-': {minusCount}");
        }

        static void string_zadacha_3()
        {
            Console.WriteLine("Задача со строками №3");

            string text = "Это предложение №1. А это предложение №2. И вот еще одно предложение №3.";
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int sentenceCount = sentences.Length;

            Console.WriteLine($"Количество предложений: {sentenceCount}");
        }

        static void string_zadacha_4()
        {
            Console.WriteLine("Задача со строками №4");

            string sentence = "В этом предложении больше букв 'м' чем букв 'н'.";
            int mCount = 0;
            int nCount = 0;

            foreach (char ch in sentence)
            {
                if (ch == 'м' || ch == 'М')
                {
                    mCount++;
                }
                else if (ch == 'н' || ch == 'Н')
                {
                    nCount++;
                }
            }

            if (mCount > nCount)
            {
                Console.WriteLine("Больше букв 'м'.");
            }
            else if (nCount > mCount)
            {
                Console.WriteLine("Больше букв 'н'.");
            }
            else
            {
                Console.WriteLine("Количество букв 'м' и 'н' одинаково.");
            }
        }

        static void string_zadacha_5()
        {
            Console.WriteLine("Задача со строками №5");

            string sentence = "Текст с буквами С и Т. Последняя буква будет 'с'.";
            int lastIndexS = sentence.LastIndexOf('с');
            int lastIndexT = sentence.LastIndexOf('Т');

            if (lastIndexS > lastIndexT)
            {
                Console.WriteLine("Буква 'с' встречается позже.");
            }
            else if (lastIndexT > lastIndexS)
            {
                Console.WriteLine("Буква 'Т' встречается позже.");
            }
            else
            {
                Console.WriteLine("Буквы 'с' и 'Т' встречаются в одной позиции.");
            }
        }

        static void string_zadacha_6()
        {
            Console.WriteLine("Задача со строками №6");

            string text = "Это текст с буквой 'а'. Первая 'а' будет найдена.";
            int index = text.IndexOf('а');

            if (index != -1)
            {
                Console.WriteLine($"Первая буква 'а' найдена в позиции {index}.");
            }
            else
            {
                Console.WriteLine("Буквы 'а' не найдено.");
            }
        }

        static void string_zadacha_7()
        {
            Console.WriteLine("Задача со строками №7");

            string sentence = "В этом предложении все буквы 'е' заменятся на букву 'и'.";
            string replacedSentence = sentence.Replace('е', 'и');

            Console.WriteLine($"Исходное предложение: {sentence}");
            Console.WriteLine($"Результат замены: {replacedSentence}");
        }

        static void string_zadacha_8()
        {
            Console.WriteLine("Задача со строками №8");

            string sentence = "Эта строка будет изменена.";
            char[] charArray = sentence.ToCharArray();

            for (int i = 2; i < charArray.Length; i += 3)
            {
                charArray[i] = 'а';
            }

            string replacedSentence = new string(charArray);

            Console.WriteLine($"Исходная строка: {sentence}");
            Console.WriteLine($"Результат замены: {replacedSentence}");
        }

        static void string_zadacha_9()
        {
            Console.WriteLine("Задача со строками №9");

            string word = "программа";
            char[] charArray = word.ToCharArray();

            if (word.Length >= 5)
            {
                char temp = charArray[1];
                charArray[1] = charArray[4];
                charArray[4] = temp;

                string result = new string(charArray);
                Console.WriteLine($"Исходное слово: {word}");
                Console.WriteLine($"Результат замены: {result}");
            }
            else
            {
                Console.WriteLine("Слово слишком короткое для замены.");
            }
        }

        static void string_zadacha_10a()
        {
            Console.WriteLine("Задача со строками №10а");

            string word = "программа";

            if (word.Length >= 3)
            {
                string result = word.Remove(2, 1); // Удалить третью букву (индекс 2)
                Console.WriteLine($"Исходное слово: {word}");
                Console.WriteLine($"Результат удаления: {result}");
            }
            else
            {
                Console.WriteLine("Слово слишком короткое для удаления третьей буквы.");
            }
        }

        static void string_zadacha_10b(int k)
        {
            Console.WriteLine("Задача со строками №10b");

            string word = "программа";

            if (word.Length >= k)
            {
                string result = word.Remove(k - 1, 1); // Удалить k-ю букву (индекс k-1)
                Console.WriteLine($"Исходное слово: {word}");
                Console.WriteLine($"Результат удаления буквы {k}: {result}");
            }
            else
            {
                Console.WriteLine("Слово слишком короткое для удаления выбранной буквы.");
            }
        }

        static void string_zadacha_11()
        {
            Console.WriteLine("Задача со строками №11");

            string text = "В этом тексте 12345 цифр.";
            int digitCount = 0;

            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }

            Console.WriteLine($"Количество цифр в тексте: {digitCount}");
        }

        static void string_zadacha_12()
        {
            Console.WriteLine("Задача со строками №12");

            string text = "В тексте есть числа 123 и 456. Сумма этих чисел: 579.";
            int sum = 0;
            string currentNumber = "";

            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    currentNumber += ch;
                }
                else if (!string.IsNullOrEmpty(currentNumber))
                {
                    sum += int.Parse(currentNumber);
                    currentNumber = "";
                }
            }

            Console.WriteLine($"Сумма чисел в тексте: {sum}");
        }

        static void string_zadacha_13()
        {
            Console.WriteLine("Задача со строками №13");

            string text = "Это текст с 10 словами для заполнения массива.";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length >= 10)
            {
                Console.WriteLine("Массив слов:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(words[i]);
                }
            }
            else
            {
                Console.WriteLine("Недостаточно слов для заполнения массива.");
            }
        }
    }
}
