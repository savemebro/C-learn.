Console.WriteLine("Введите имя пользователя!");
string username = Console.ReadLine();

if ( username.ToLower() == "маша")
{
    Console.Write ( "я тебя люблю!" );
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
