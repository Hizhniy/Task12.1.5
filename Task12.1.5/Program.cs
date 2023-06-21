//Для списка пользователей добавьте приветствие по имени. Если пользователь не имеет премиум-подписки, то ему нужно показать рекламу.

class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }

    public User(string login, string name, bool isPremium)
    {
        Login = login;
        Name = name;
        IsPremium = isPremium;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var users = new List<User>() { new User("vasya", "Вася", false), new User("masha", "Маша", true), new User("lena", "Лена", false) };
        Random rnd = new Random();
        var i = rnd.Next(0, 2);
        Console.WriteLine($"Привет, {users[i].Name}!");
        if (!users[i].IsPremium) ShowAds();
        Console.ReadKey();
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}