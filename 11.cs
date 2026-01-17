{
    int [] array = { 1, 3, 5, 8, 12, 2, -2, 25 };
    int maxElement = int.MinValue;

    for(int i = 0; i < array.Length; i++)
    {
        if(maxElement < array[i])
        {
            maxElement = array[i];
        }
    }

    Console.WriteLine(maxElement);
}