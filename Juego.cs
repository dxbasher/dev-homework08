using System;
using System.Threading;

namespace dev_homework08{

    class Juego{

        public string[,] Tablero {get;set;}
        public int Puntuacion {get;set;}
        public string ColorTablero {get;set;}
        public string Dificultad {get;set;}
        public int _tamañoX {get;set;}
        public int _tamañoY { get; set; }


        public void Iniciar(){
            Console.Clear();
            Console.WriteLine("Bienvenido a mis pininos");
            _tamañoX  = 50;
            _tamañoY  = 20;
            Console.WriteLine($"Voy a dibunar el tablero de {_tamañoX} {_tamañoY}");
            Thread.Sleep(2000);
            Console.Clear();
            DibujaTablero();
       
            
           
         
            
            /*
               0 1 2 3 4
            0  * * * * * 
            1  * * * * * 
            2  * * * * * 
            3  * * * - * 
            */

        }

        public void EscribeEn(string texto, int x, int y){
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1);
            Console.SetCursorPosition(x,y);
            Console.Write(texto);
        }

        public void DibujaTablero (){
                         string titulo = "Mi Sanake v0,1";
           
           for(int x=0; x < _tamañoX; x ++){
                    for(int y=0; y < _tamañoY; y ++){
                        EscribeEn(" ",x,y);
                    }
            }
           
           EscribeEn(titulo,(_tamañoX/2)- (titulo.Length/2) ,0);
            for(int x=0; x < _tamañoX; x++ ){
                EscribeEn("=",x,1);
                EscribeEn("=",x,_tamañoY-1);
            }

            for(int y=0; y < _tamañoY; y ++){
                    EscribeEn("|",0,y);
                    EscribeEn("|",_tamañoX-1,y);
            }
   
            

        }

    } 

}
