using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using regApp.Gateway;

namespace studConsole
{
    public class Menu
    {
        public  async void MainMenu()
        {
            var av = await StudentGateway.GetAll();
            foreach (var item in av)
            {
                System.Console.WriteLine(item.Email);
            }
        }
    }
}