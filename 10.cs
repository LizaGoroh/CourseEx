//практика массивов (расчет суммы элементов массива)

using System.Runtime.Serialization.Formatters;

{
    int [] array = { 2, 3, 4, 7, 8 };
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    Console.WriteLine(sum);
}
