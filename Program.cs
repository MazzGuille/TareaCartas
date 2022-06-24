global using static System.Console;
using TareaCartas.Clases;

WriteLine("¡Bienvenido al mazo de cartas de MazzGames!");

var Mazo = new Cartas();

bool Loop = true;
while (Loop)
{
    WriteLine(@"
Por favor, elige una de las siguientes opciones:
1- Barajar.
2- Mostrar siguiente carta.
3- Mostrar cartas disponibles.
4- Dar cartas.
5- Mostrar cartas del monton.
6- Mostrar baraja.
7- Salir.");
    int numero = int.Parse(ReadLine());
    if (numero == 1)
    {
        Mazo.Barajar();
        Loop = true;
    }
    else if (numero == 2)
    {
        Mazo.SiguienteCarta();
        Loop = true;
    }
    else if (numero == 3)
    {
        Mazo.CartasDisponibles();
        Loop = true;
    }
    else if (numero == 4)
    {
        Mazo.DarCartas();
        Loop = true;
    }
    else if (numero == 5)
    {
        Mazo.CartasMonton();
        Loop = true;
    }
    else if (numero == 6)
    {
        Mazo.MostrarBaraja();
        Loop = true;
    }
    else if (numero == 7)
    {
        WriteLine("¡Gracias por participar, hasta la proxima!");
        Loop = false;
    }
    else { WriteLine("Has ingresado un valor invalido. Por favor, intentar nuevamente."); Loop = true; }
}

