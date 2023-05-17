void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10, 100); // [0; 100]
}


int SortQuick(int[] array, int start, int end)
{
    int temp;
    int marker = start;
    System.Console.WriteLine($"   диапазон от {start} до {end}, метка на #{marker}: ");
    for (int i = start; i < end; i++)
    {
        if (array[i] < array[end])
        {
            System.Console.WriteLine($"      цикл: {array[i]} ({i}) меньше {array[end]} ({end}) => МЕНЯЕМ {array[marker]} (меченый {marker}) и {array[i]} (текущий {i}):");
            temp = array[marker];
            array[marker] = array[i];
            array[i] = temp;
            marker += 1;
            Console.WriteLine($"                [{string.Join(", ", array)}], НОВАЯ метка на #{marker}");
        }
        else
        {
            Console.WriteLine($"      цикл: {array[i]} ({i}) НЕ меньше {array[end]} ({end}) => НЕТ обмена #{marker} = {array[marker]} c #{i} = {array[i]}");
        }
    }
    temp = array[marker];
    array[marker] = array[end];
    array[end] = temp;
    System.Console.WriteLine($"   ОБМЕН ВНЕ ЦИКЛА: {array[marker]} (меченый {marker}) и {array[end]} (последний {end}):");
    System.Console.WriteLine($"                [{string.Join(", ", array)}],  возврат метки #{marker}");
    return marker;
}


void recSsort(int[] array, int start, int end)
{
    Console.WriteLine($"start = {start}, end = {end}, [{string.Join(", ", array)}]");
    if (start >= end)
        return ;
    int pivot = SortQuick(array, start, end);
    System.Console.WriteLine(" ВХОД в рекурсию recSsort(array, start, pivot - 1)");
    recSsort(array, start, pivot - 1);
    System.Console.WriteLine(" ВХОД в рекурсию recSsort(array, pivot + 1, end)");
    recSsort(array, pivot + 1, end);
}


Console.Clear();
int n = 7;
//int[] array = {2, 3, 5, 1, 4};
int[] array = new int[n];
InputArray(array);
System.Console.WriteLine("-------===================== Q U I C K    S O R T =====================--------");

recSsort(array, 0, array.Length - 1);
//Console.WriteLine($"отсортированный массив: [{string.Join(", ", array)}]");
