using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masskontr4
{
class Program
{
static void Main(string[] args)
{
string[] surname = new string[2];

inPrint(surname);

while (true)
{
Console.WriteLine("Выберите команду от 1 до 7.");
Console.WriteLine("1. Вывод всех фамилий.");
Console.WriteLine("2. Вывод одной фамилии по индексу.");
Console.WriteLine("3. Поиск по заданной фамилии.");
Console.WriteLine("4. Показать одинаковые фамилии.");
Console.WriteLine("5. Вывод фамилий по первой букве.");
Console.WriteLine("6. Показать список фамилий в одну строку.");
Console.WriteLine("7. Сортировка по алфавиту.");

int a = int.Parse(Console.ReadLine());
switch (a)
{
case 1:
Console.WriteLine("1. Вывод всех фамилий.");
outPrint(surname);
break;
case 2:
Console.WriteLine("2. Введите индекс фамилии от 0 до 9.");
outPrint(surname, int.Parse(Console.ReadLine()));
break;
case 3:
Console.WriteLine("3. Введите фамилию, чтобы узнать ее индекс.");
searchSnameIndex(surname, Console.ReadLine());
break;
case 4:
Console.WriteLine("4. Введите фамилию.");
searchSName(surname, Console.ReadLine());
break;
case 5:
Console.WriteLine("5. Введите первый символ массива.");
outPrint(surname, Console.ReadLine()[0]);
break;
case 6:
Console.WriteLine("6. Показать список фамилий в одну строку.");
arrayToLine(surname);
break;
case 7:
Console.WriteLine("7. Сортировка по алфавиту.");
sortMass(surname);
break;
}
Console.WriteLine("Повторить? Y/N");
char u = Console.ReadLine()[0];
if ('n' == u || 'N' == u) {
break;
}
}


}

//1.заполнение массива
static void inPrint(string[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.WriteLine("Введи {0} свою фамилию; ", i);
string sname = Console.ReadLine();
arr[i] = sname;
}
}

//2.вывод изобр на экр
static void outPrint(string[] arr)
{
foreach (string print in arr)
{
Console.WriteLine(print);
}
}

//3.вывод одной фамилии по индексу ПЕРЕГРУЗК
static void outPrint(string[] arr, int index)
{

Console.WriteLine("{0}-ая фамилия списка - {1}", index, arr[index]);

}


//4.поиск задан фамилии
static int searchSnameIndex(string[] arr, string a)
{

for (int i = 0; i < arr.Length; i++)
{

if (a == arr[i])
{
return i;
}
}
return -1;
}

//5.поиск зад фамил в масс возвращающий индекс или 0 если нет фамилии
static int searchSName(string[] arr, string a)
{
int k = 0;
for (int i = 0; i < arr.Length; i++)
{

if (a == arr[i])
{
k++;
}
}
return k;
}



//6.поиск задан фамил ПЕРЕГРУЗК
static void outPrint(string[] arr, char sname)
{
foreach (string a in arr) {

if (a[0] == sname) {
Console.WriteLine(a);
}
}
}

//7. возвращ весь список в одну строку
static string arrayToLine(string[] arr) {
string line = "";
foreach (string a in arr) {

line += a + " ";
}
return line;
}

//8 в main
//9.сортировка
static void sortMass(string [] arr){

for (int i =0; i for (int j = i+1;j char istring = arr[i][0];
char jstring = arr[j][0];
if (istring > jstring) {
string temp = arr[i];
arr[i]= arr[j];
arr[j] = temp;
}

}

}

}


}
}
