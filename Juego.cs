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
            _tamañoY  = 25;
            Console.WriteLine($"Voy a dibunar el tablero de {_tamañoX} {_tamañoY}");
            Thread.Sleep(2000);
            Console.Clear();
            DibujaTablero(80,40);
       
            
           
         
            
            /*
               0 1 2 3 4
            0  * * * * * 
            1  * * * * * 
            2  * * * * * 
            3  * * * - * 
            */

        }

        public void EscribeEn(string texto, int x, int y){
            Thread.Sleep(5);
            Console.SetCursorPosition(x,y);
            Console.Write(texto);
        }

        public void DibujaTablero (int tamX, int tamY){
            for(int x=0; x < tamX; x++ ){
                EscribeEn("=",x,0);
                EscribeEn("=",x,tamY-1);
            }

            for(int y=0; y < tamY; y ++){
                    EscribeEn("|",0,y);
                    EscribeEn("|",tamX-1,y);
            }

        }

    } 

}
