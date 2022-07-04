//Ввод массива
Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] mas = new string[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                mas[i] = Console.ReadLine(); 
            }
//Создание нового массива
int count=0;
string[] new_mas=new string[n]; ;
for (int i = 0; i < n; i++)
{
    if (mas[i].Length<=3)
    {new_mas[count]=mas[i];
    count++;}
}
//Вывод нового массива
Console.WriteLine("Новый массив: ");
for (int i = 0; i < count; i++)
            {
                Console.Write($"'{new_mas[i]}'  ");
            }