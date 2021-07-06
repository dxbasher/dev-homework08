using System;
using System.Threading;

namespace dev_homework08
{
    public class Snake
    {

        public int Tamaño { get; set; }
        public Posicion[] Cuerpo { get; set; }

        private Comida _comida { get; set; }

        public char Forma { get; set; }
        public char Direccion { get; set; } //I,D,A,B

        public Snake(int tamaño, char forma, int posicionX, int posicionY)
        {
            Tamaño = tamaño;
            Forma = forma;
            Cuerpo = new Posicion[tamaño];
            Direccion = 'D';
            Cuerpo[0] = new Posicion { X = posicionX, Y = posicionY };
            for (int i = 1; i < tamaño; i++)
            {
                Cuerpo[i] = new Posicion { X = posicionX + i, Y = posicionY };
            }
            _comida = new Comida();


        }


        public void PintarCuerpo(int velocidad)
        {
            Thread.Sleep(velocidad);

            for (int i = 0; i < Cuerpo.Length; i++)
            {
                var punto = Cuerpo[i];
                Console.SetCursorPosition(punto.X, punto.Y);
                Console.Write(Forma);
            }
        }

        public void Avanzar(int velocidad)
        {

            var posicionAnterior = Cuerpo;
            var cuerpoNuevo = new Posicion[Cuerpo.Length];

            var puntoBorrar = Cuerpo[0];
            Console.SetCursorPosition(puntoBorrar.X, puntoBorrar.Y);
            Console.Write(' ');

            for (int i = 0; i < Cuerpo.Length - 1; i++)
            {
                cuerpoNuevo[i] = posicionAnterior[i + 1];
            }

            var ultimoPunto = posicionAnterior[Cuerpo.Length - 1];
            var nuevoPunto = new Posicion { X = ultimoPunto.X, Y = ultimoPunto.Y };
            switch (Direccion)
            {
                case 'I':
                    nuevoPunto.X--;
                    break;
                case 'D':
                    nuevoPunto.X++;
                    break;
                case 'A':
                    nuevoPunto.Y--;
                    break;
                case 'B':
                    nuevoPunto.Y++;
                    break;
            }
            cuerpoNuevo[Cuerpo.Length - 1] = nuevoPunto;
            Cuerpo = cuerpoNuevo;
            PintarCuerpo(velocidad);
        }

        public void MostrarComida(int x, int y, int tipo)
        {

            OcultarComida();

            _comida.X = x;
            _comida.Y = y;
            switch (tipo)
            {
                case 1:
                    _comida.Valor = 5;
                    break;
                case 2:
                    _comida.Valor = 10;
                    break;
                case 3:
                    _comida.Valor = 15;
                    break;
            }


            _comida.Visible = true;
        }

        public void OcultarComida()
        {
            _comida.Valor = 0;
            _comida.Visible = false;
        }


    }

    public class Posicion
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    public class Comida : Posicion
    {
        private bool _visible;
        public int Valor { get; set; }
        public bool Visible
        {
            get
            {
                return _visible;
            }

            set
            {
                _visible = value;
                if (_visible == true)
                {
                    Console.SetCursorPosition(X, Y);

                    switch (Valor)
                    {
                        case 5:
                            Console.Write("🍿");
                            break;
                        case 10:
                            Console.Write("🍕");
                            break;
                        case 15:
                            Console.Write("🍔");
                            break;
                    }


                }
                else
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write(" ");
                }
            }
        }

        public Comida(int x, int y, int valor, bool visible)
        {
            X = x;
            Y = y;
            Valor = valor;
            Visible = true;
        }

        public Comida()
        {
            X = 1;
            Y = 2;
            Valor = 0;
            Visible = false;
        }

    }




}