namespace MVC_Nachgebaut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, MVC!");
            //Model.Persistenz.SpeicherErstellen();
            Controller.Controller_01 c1 = new Controller.Controller_01();
            View.Browser browser = new View.Browser();
            View.Ausgabe ausgabe = new View.Ausgabe();
            browser.Ausgabe = ausgabe;
            browser.Controller = c1;
            browser.Startseite();
        }
    }
}