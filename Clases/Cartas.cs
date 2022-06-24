namespace TareaCartas.Clases
{
    public class Cartas
    {
        public List<string> MazoTotal = new List<string>
        {
            "1 de Espada\n", "2 de Espada\n", "3 de Espada\n", "4 de Espada\n", "5 de Espada\n", "6 de Espada\n", "7 de Espada\n", "10 de Espada\n", "11 de Espada\n", "12 de Espada\n",
            "1 de Bastos\n", "2 de Bastos\n", "3 de Bastos\n", "4 de Bastos\n", "5 de Bastos\n", "6 de Bastos\n", "7 de Bastos\n", "10 de Bastos\n", "11 de Bastos\n", "12 de Bastos\n",
            "1 de Oro\n", "2 de Oro\n", "3 de Oro\n", "4 de Oro\n", "5 de Oro\n", "6 de Oro\n", "7 de Oro\n", "10 de Oro\n", "11 de Oro\n", "12 de Oro\n",
            "1 de Copas\n", "2 de Copas\n", "3 de Copas\n", "4 de Copas\n", "5 de Copas\n", "6 de Copas\n", "7 de Copas\n", "10 de Copas\n", "11 de Copas\n", "12 de Copas\n"
        };

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
};