namespace MVC_Nachgebaut.View
{
    internal class Browser
    {
        public Controller.Controller_01 Controller { get; set; }
        public View.Ausgabe Ausgabe { get; set; }
        public void Startseite()
        {
            string ans;
            bool w = true;
            while (w)
            {
                Console.WriteLine("Willkommen im Minibrowser! Geben sie folgend Ihren Text ein: ");
                string ant = Console.ReadLine();
                Controller.Stringverarbeitung(ant);
                Console.WriteLine("Weiter eingabe? [Y]|[N]: ");
                ans = Console.ReadLine().ToLower();
                if (ans == "y")
                {
                    w = true;
                }
                else
                {
                    w = false;
                }
            }
            Console.WriteLine("Wollen sie Ihr eiggegebenes auslesen?");
            ans= Console.ReadLine().ToLower();
            if (ans == "y")
            {
                Ausgabe.Ausgeben();
            }

        }
        
    }
}
