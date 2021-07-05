using System;
using System.Threading;

namespace dev_homework08
{
    public class Snake{

        public int Tamaño { get; set; } 
        public Punto [] Cuerpo {get;set;}
        
        public char Forma {get;set;}
        public char Direccion {get;set;} //I,D,A,B

        public Snake(int tamaño, char forma, int posicionX, int posicionY)
        {
            Tamaño = tamaño;
            Forma = forma;
            Cuerpo = new Punto[tamaño];
            Direccion = 'D';
            Cuerpo[0] = new Punto{X = posicionX,Y=posicionY};

            for (int i = 1; i< tamaño; i++){
                Cuerpo[i] = new Punto{ X = posicionX+i, Y=posicionY};
            }

        }


        public void PintarCuerpo(int velocidad){
            Thread.Sleep(velocidad);

            for(int i = 0; i< Cuerpo.Length; i ++){            
                var punto = Cuerpo[i];
                Console.SetCursorPosition(punto.X, punto.Y);
                Console.Write(Forma);
            }
        }

        public void Avanzar(int velocidad){
           
            var posicionAnterior = Cuerpo;
            var cuerpoNuevo = new Punto[Cuerpo.Length];

            var puntoBorrar = Cuerpo[0];
            Console.SetCursorPosition(puntoBorrar.X, puntoBorrar.Y);
            Console.Write(' ');
            
            for (int i = 0; i < Cuerpo.Length - 1; i++){
                cuerpoNuevo[i] = posicionAnterior[i+1];
            }

            var ultimoPunto = posicionAnterior[Cuerpo.Length - 1];
            var nuevoPunto = new Punto { X = ultimoPunto.X, Y = ultimoPunto.Y };
            switch(Direccion){
                case 'I':                                 
                nuevoPunto.X --;
                break;
                case 'D':
                nuevoPunto.X ++;
                break;
                case 'A':
                nuevoPunto.Y --;
                break;
                case 'B':
                nuevoPunto.Y ++;
                break;                
            }
            cuerpoNuevo[Cuerpo.Length - 1] = nuevoPunto;
            Cuerpo = cuerpoNuevo;
            PintarCuerpo(velocidad);
        }

    }

    public class Punto {
        public int X {get;set;}
        public int Y {get;set;}
       
    }

    

}