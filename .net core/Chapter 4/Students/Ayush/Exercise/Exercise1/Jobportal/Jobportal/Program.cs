using System.Security.Cryptography.X509Certificates;
using Jobportal.Interfaces;
using Jobportal.Manager;

public class Program
{
    public static void Main(string[] args)
    {
        Imenu menu = new Publicmanager();
        menu.Displaymenu();
    }
}