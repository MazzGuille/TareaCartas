using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCartas.Clases
{
    internal class Baraja : Cartas
    {
        public void Barajar()
        {
            int lastIndex = MazoTotal.Count - 1;
            while (lastIndex > 0)
            {
                string tempVal = MazoTotal[lastIndex];
                int rndIndex = new Random().Next(0, lastIndex);
                MazoTotal[lastIndex] = MazoTotal[rndIndex];
                MazoTotal[rndIndex] = tempVal;
                lastIndex--;
            }
            WriteLine("Se ha barajeado el mazo:\n");
            WriteLine(String.Join("\n", MazoTotal));
        }

        public List<string> Mazo2 = new List<string>();
        public void SiguienteCarta()
        {
            Mazo2.Add(MazoTotal[0]);
            WriteLine(MazoTotal[0]);
            MazoTotal.RemoveAt(0);

            if (MazoTotal.Count == 0)
            {
                WriteLine("No hay mas cartas disponibles en el mazo.");
            }

        }

        public void CartasDisponibles()
        {

            int Restan = MazoTotal.Count;

            if (Restan > 1)
            {
                WriteLine($"Quedan {Restan} cartas disponibles en el mazo.");
            }
            else if (Restan == 1)
            {
                WriteLine($"Queda {Restan} carta disponible en el mazo.");
            }

        }

        public void DarCartas()
        {
            WriteLine("Cuantas cartas desea retirar del mazo?");
            int X = int.Parse(ReadLine());

            for (int i = 0; i < X; i++)
            {
                Mazo2.Add(MazoTotal[0]);
                WriteLine(MazoTotal[0]);
                MazoTotal.RemoveAt(0);
            }
        }


        public void CartasMonton()
        {
            WriteLine($"Se han retirado {Mazo2.Count} cartas del mazo:");
            WriteLine(String.Join("\n", Mazo2));

        }

        public void MostrarBaraja()
        {
            WriteLine("Cartas disponibles:\n");
            WriteLine(String.Join("\n", MazoTotal));
            if (MazoTotal.Count == 0)
            {
                WriteLine("No quedan cartas disponibles.");
            }
        }
    }
}
