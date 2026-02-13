namespace dependance.services
{
    public class Myservice : Imyservice
    {
        public string GetMessage()
        {
            return "Hello from Myservice using dependance injection";
        }

    }
}
