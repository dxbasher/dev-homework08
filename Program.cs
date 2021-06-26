using System;
using System.Threading;

namespace dev_homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Juego snake = new Juego();
            snake.Iniciar();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n");
            Console.WriteLine("Presiona ENTER para iniciar o ESC para salir.");    
            ConsoleKeyInfo teclado = Console.ReadKey(true);

            if(teclado.Key == ConsoleKey.Enter){
                Console.WriteLine("\n");
                Console.WriteLine("Iniciando.");
                for(int i=0;i<50;i++){
                    Thread.Sleep(50);
                    Console.Write(".");
                }
               
                Console.WriteLine("\n");
                Console.WriteLine("Debes presionar las teclas   ⬅️   ⬆️   ⬇️   ➡️  para moverte"); 
                bool seguir = true;

                while(seguir){
                    if (Console.KeyAvailable)//Verifica que se haya presionado una tecal.
                    {
                        teclado = Console.ReadKey(true);//lee teclado
                        ConsoleKey tecla = teclado.Key; //obtiene la tecla presionada
                        switch(tecla){
                            case ConsoleKey.Escape:
                                seguir = false;
                                ImprimirMensaje("\nPresionó Escape. Saliedo");
                                break;
                            case ConsoleKey.UpArrow:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                ImprimirMensaje("Arriba ⬆️");
                                break;
                            case ConsoleKey.DownArrow:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                ImprimirMensaje("Abajo ⬇️");
                                break;
                            case ConsoleKey.LeftArrow:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                ImprimirMensaje("Izquierda  ⬅️ ");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                            case ConsoleKey.RightArrow:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                ImprimirMensaje("Derecha ➡️");
                                break;
                            default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                ImprimirMensaje(" ** Tecla invalida **  Si quiere salir presione ESC");
                                break;                              
                        }
                        
                    }
                }

                
            }
            else if(teclado.Key == ConsoleKey.Escape){
                Console.WriteLine("\nAdios.");    
            }

           
           
        }
        public static void ImprimirMensaje(string msj){
            Console.WriteLine(msj);    
        }

       
    }
}
