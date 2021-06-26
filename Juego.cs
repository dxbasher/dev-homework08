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
        public int _tamañoX { get; set; }
        public int _tamañoY { get; set; }

        public string _vivora { get; set; }
        public int _velociad { get; set; }

        public int _x { get; set; }
        public int _y { get; set; }

         string _caracter = "🐌 ";

        public Juego()
        {
            
            _vivora = _caracter;
            _velociad = 1000;
            _tamañoX = 50;
            _tamañoY = 20;
            _x = (_tamañoX / 2) - 1;
            _y = (_tamañoY / 2) - 1;
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


            Comer();
            Comer();
            PintarSnake();
            _x = 3;
            _velociad = 300;
           
           
           
            while (_x < (_tamañoX - 2)-(_vivora.Length))
            {
                 PintarComida(_x +_vivora.Length, _y);
                MoverDerecha();
                MoverDerecha();
                MoverDerecha();                
                Comer();
            }

            Console.SetCursorPosition(_tamañoX - 1, _tamañoY - 1);
        }

        public void EscribeEn(string texto, int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            // Thread.Sleep(_velociad);
            Console.SetCursorPosition(x, y);
            Console.Write(texto);
        }
        public void PintarSnake()
        {
            Thread.Sleep(_velociad);
            LimpiarTablero();
            EscribeEn(_vivora, _x, _y);
        }

        public void PintarComida(int x , int y)
        {
            
            EscribeEn("🍕",x , y);
             Thread.Sleep(_velociad);
        }



        public void Comer()
        {
            _vivora += _caracter;
        }
        public void MoverDerecha()
        {
            _x += 1;
            PintarSnake();
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
        }

    }

}
