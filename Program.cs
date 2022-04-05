// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначально массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  

//Примеры:

//["Hello", "2", "world", ":-)"] -> ["2", ":-)"]

//["1234", "1567", "-2", "computer science"] -> ["-2"]

//["Russia", "Denmark", "Kazan"] -> []


string[] array = new string[8] {"Russia", "way", "Ufa", "aim", "USA", "Mexica", "UK", "key"};
string[] secondarray = new string[array.Length];
void SortArray(string[] array, string[] secondarray)
{
    int count = 0;
    for (int ind = 0; ind < array.Length; ind++)
    {
    if(array[ind].Length <= 3)
        {
        secondarray[count] = array[ind];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        Console.Write($"{array[ind]}  ");
    }
}
SortArray(array, secondarray);
PrintArray(secondarray);