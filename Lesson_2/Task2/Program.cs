int n = 10;
int[] arr = new int[n];
int i = 0;

//while (i < n)
// Можно заменить переменную n в строке выше на свойство массива, которое описывает 
// количестов элементов массива, и получить (см.строку ниже):
while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.WriteLine(arr[i]);
    //Console.WriteLine(' ');
    // Строка ниже объединяет две верхние команды в одну
    Console.Write($"{arr[i]} ");
    i = i + 1;
}