using System;
using System.Threading;

namespace dev_homework08
{

    class Juego
    {

        public string[,] Tablero { get; set; }
        public int Puntuacion { get; set; }
        public string ColorTablero { get; set; }
        public string Dificultad { get; set; }
        private int _tamañoX { get; set; }
        private int _tamañoY { get; set; }


        public Snake snake { get; set; }
        public int _velociad { get; set; }

        public int _x { get; set; }
        public int _y { get; set; }



        public Juego()
        {

            _velociad = 500;
            _tamañoX = 100;
            _tamañoY = 40;
            _x = (_tamañoX / 2) - 1;
            _y = (_tamañoY / 2) - 1;
            Puntuacion = 0;
            snake = new Snake(6, 'o', 2, _y);
        }

        public void Iniciar()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("Bienvenido a mis pininos");

            Console.WriteLine($"Voy a dibunar el tablero de {_tamañoX} {_tamañoY}, persiona enter para continuar.");
            Console.ReadLine();
            Console.Clear();
            DibujaTablero();
            PintarSnake();
            snake.MostrarComida(10, 5, 3);

            Console.SetCursorPosition(_tamañoX - 1, _tamañoY - 1);
        }

        public void Avanzar()
        {

            snake.Avanzar(_velociad);
        }

        public void EscribeMensaje(string mensaje)
        {
            EscribeEn(mensaje, 2, _tamañoY + 3);
        }

        public void EscribeEn(string texto, int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.Write(texto);
        }
        public void PintarSnake()
        {
            Thread.Sleep(_velociad);
            LimpiarTablero();
            snake.PintarCuerpo(_velociad);

        }

        public void MostrarComida()
        {
            Random random = new Random();
            int num = random.Next(0, 30);
            int xRan = random.Next(1, _tamañoX - 1);
            int yRan = random.Next(2, _tamañoY - 1);

            if (num == 7)
            {
                snake.MostrarComida(xRan, yRan, random.Next(1, 3));
            }

        }


        public void LimpiarTablero()
        {

            for (int x = 1; x < _tamañoX - 1; x++)
            {
                for (int y = 2; y < _tamañoY - 1; y++)
                {
                    EscribeEn(" ", x, y);
                }
            }
        }

        public void DibujaTablero()
        {
            string titulo = "Mi Sanake v0.1";

            EscribeEn(titulo, (_tamañoX / 2) - (titulo.Length / 2), 0);
            for (int x = 0; x < _tamañoX; x++)
            {
                EscribeEn("=", x, 1);
                EscribeEn("=", x, _tamañoY - 1);
            }

            for (int y = 0; y < _tamañoY; y++)
            {
                EscribeEn("|", 0, y);
                EscribeEn("|", _tamañoX - 1, y);
            }

            MostrarPuntaje();
        }

        public void MostrarPuntaje()
        {
            EscribeEn($"Puntos: {Puntuacion.ToString("000000")}", _tamañoX - 18, 0);
        }

    }

}
