//Написать программу которая выбирает из массива строки, где длина <=3.



void Selectstrings(string []array)
{
    for(int i=0; i< array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Console.Write(array[i] + "; ");
        }
    }
}


string []CreateArray(int length)
{ 
    string []array = new string[length];
    for(int i=0; i<length; i++)
    {
        Console.WriteLine("Введите элемент массива размером от 1 до 8 знаков, чисел или символов: ");
        array[i] = Console.ReadLine();
    }
    return array;
}



int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Задать размер изначального массива 
int arraySize = EnterData("Введите размер массива: ");


//Задать массив из случайных строк
string []array = CreateArray(arraySize);
Console.WriteLine(String.Join(",", array));
Console.WriteLine();

//Из массива выбрать строки, чья длина <=3
 Selectstrings(array);
