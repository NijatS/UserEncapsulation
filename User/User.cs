
internal class User
{
    private string _username;
    private string _password;
    public string UserName
    {
        get
        {
            return _username;
        }
        set
        {
            if (!value.Contains(" "))
            {
                _username = value;
            }
        }

    }
    public string Password
    {
        get => _password; set
        {
            if (CheckPassword(value))
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("Password must contain digit and upper case");

            }
        }

    }
    public User(string userName, string password)
    {
        if (CheckPassword(password))
        {
            UserName = userName;
            Password = password;
        }

    }
    public bool CheckPassword(string password)
    {
        if (password.Contains(" "))
        {
            return false;
        }
        if (password.Length >= 8)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i <= 9; i++)
            {
                string letter = i.ToString();

                if (password.Contains(letter))
                {
                    count1++;
                }
            }
            if (count1 == 0)
            {
                return false;
            }

            for (int i = 65; i <= 90; i++)
            {
                char c = (char)i;
                string letter = c.ToString();
                if (password.Contains(letter))
                {
                    count2++;
                }
            }
            if (count2 == 0)
            {
                return false;
            }
            return true;
        }
        return false;

    }
}