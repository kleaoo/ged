using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

// uhfduf
/* hbdjd 
 bfnvxuvnx
 */
int myNumber = 5;
int a = 4, b = 5;

int sum = a + b;
int raz = a - b;

int proiz = b * a;
double chast = a / b;

int ost = a % b;

Console.ForegroundColor = ConsoleColor.Gray;
Console.BackgroundColor = ConsoleColor.Magenta;

Console.Write("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine("Имя: " + name);

string stroka = "Тут могла быть ваша реклама";
char symbol = 'А';
Console.WriteLine(stroka);

string info = "ало ало ало ало ало алo";

info = info.ToUpper();
info = info.ToLower();
info = info.Replace("ало", "прием");
Console.WriteLine(info);

string strokainfo = stroka + info;

Console.Write(strokainfo);

Console.WriteLine("Символов в строке:" + strokainfo.Length);

string new_strokainfo = strokainfo.Replace(' ', '_');
Console.WriteLine(new_strokainfo);

Console.Write("Введите ваш текст: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Вам " + age + "лет");

Console.Write("Введите ваше ФИO:");
string fio = Console.ReadLine();
Console.WriteLine("ФИО: " + fio);

Console.Write("Введите вашу дату рождения: ");
int god = int.Parse(Console.ReadLine());
Console.WriteLine("Вы родились " + god);

Console.Write("Где вы живете: ");
int mesto = int.Parse(Console.ReadLine());
Console.WriteLine("Вы живете " + mesto);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\t\t\tНевероятный диалог:\n");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\t-А ты научился использовать \"Управляющие символы\"?\n\t-Да");
Console.WriteLine("Невероятный звук");

