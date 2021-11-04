Console.Write("Введите имя:");
string userName = Console.ReadLine();
if(userName.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}