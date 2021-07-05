using System;
using System.Threading;

namespace dev_homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Juego game = new Juego();
            game.Iniciar();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n");
            Console.WriteLine("Presiona ENTER para iniciar o ESC para salir.");    
            ConsoleKeyInfo teclado = Console.ReadKey(true);

            if(teclado.Key == ConsoleKey.Enter){
                Console.WriteLine("\n");
                Console.WriteLine("Iniciando.");
                for(int i=0;i<50;i++){
                    Thread.Sleep(5);
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
                                 game.EscribeMensaje("\nPresionó Escape. Saliedo");
                                break;
                            case ConsoleKey.UpArrow:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                game.EscribeMensaje("Arriba ⬆️");
                                game.snake.Direccion = 'A';
                                break;
                            case ConsoleKey.DownArrow:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                 game.EscribeMensaje("Abajo ⬇️");
                                game.snake.Direccion = 'B';
                                break;
                            case ConsoleKey.LeftArrow:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                 game.EscribeMensaje("Izquierda  ⬅️ ");
                                game.snake.Direccion = 'I';
                                break;
                            case ConsoleKey.RightArrow:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                 game.EscribeMensaje("Derecha ➡️");
                                game.snake.Direccion = 'D';
                                break;
                            default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                 game.EscribeMensaje(" ** Tecla invalida **  Si quiere salir presione ESC");
                                break;                              
                        }
                        
                    }
                    
                   
                        game.Avanzar();
                }

                
            }
            else if(teclado.Key == ConsoleKey.Escape){
                Console.WriteLine("\nAdios.");    
            }

           
           
        }
     

       
    }
}
