Console.Write("Введите имя пользователя:");
String UserName = Console.ReadLine();

if(UserName.ToLower() == "маша")
{
    Console.WriteLine("Ура это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(UserName);
}