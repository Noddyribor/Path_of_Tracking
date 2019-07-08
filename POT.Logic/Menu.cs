using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    public class Menu
    {
        private string titulo;
        private string[] opcs;
        private string opc0;
        private string bar;

        public Menu(string titulo, string[] opcs, string opc0)
        {
            this.titulo = titulo;
            this.opcs = opcs;
            this.opc0 = opc0;
            this.bar = String.Empty.PadRight(79, '*');
        }

        public int ShowFullMenu()
        {
            ShowTitle();
            return ShowOptions();
        }

        public void ShowTitle()
        {
            int space = this.bar.Length - this.titulo.Length - 10;
            int space_r = space / 2;
            int space_l = space - space_r;
            titulo = String.Empty.PadRight(space_r, ' ') + titulo + String.Empty.PadLeft(space_l, ' ');
            Console.Clear();
            Console.WriteLine(bar);
            Console.WriteLine("*****" + titulo + "*****");
            Console.WriteLine(bar);
        }

        public int ShowOptions()
        {
            int i = 1;
            Console.WriteLine(bar);
            foreach (string opcao in this.opcs)
            {
                Console.WriteLine(i + " - " + opcao);
                i += 1;
            }
            Console.WriteLine("0 - " + opc0);
            Console.WriteLine(bar);
            return Terminal.ReadInteger("=> ");
        }
    }
}
