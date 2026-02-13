namespace customservice.services
{
    public class Grettingservice : IGettingservice
    {
        public string Getmessage(string name)
        {
            return $"Hello {name}, Welcome to ASP.NET Core";
        }

    }
}
