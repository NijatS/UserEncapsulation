
while (true)
{
    Console.Write("Please enter Username : ");
    string username = Console.ReadLine();
    Console.Write("Password : ");
    string password = Console.ReadLine();
    User user1 = new User(username, password);
    if (user1.Password != null && user1.UserName != null)
    {
        Console.WriteLine("Successfull Access!");
        break;
    }
    else
    {
        Console.WriteLine("Password must contain upper case,min 8 car. and digit.\nUsername and Password don`t contain spaces");
    }
}

