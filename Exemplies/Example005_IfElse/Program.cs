Console.Write("Напиши своё имя ");
string name = Console.ReadLine();

if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это Маша!!!");
}
else
{
    Console.WriteLine("Привет, " + name);
}
