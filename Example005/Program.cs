Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == " алина")
{
    Console.WriteLine("Ура, это же Жабка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}