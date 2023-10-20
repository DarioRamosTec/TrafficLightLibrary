using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLightLibrary
{
    public class Semaforo
    {
        string color;
        public string Color { get => color; set => color = value; }
        
        bool estado = false;
        public bool Estado { get => estado; set => estado = value; }

        int indiceColor;
        public int IndiceColor { get => indiceColor; set => indiceColor = value; }

        public Semaforo ()
        {

        }

        public void SetLight (char color, char state)
        {
            switch (color)
            {
                default:
                    indiceColor = 0;
                    this.color = "Ninguno";
                    break;

                case 'V':
                    indiceColor = 1;
                    this.color = "Verde";
                    break;

                case 'A':
                    indiceColor = 2;
                    this.color = "Amarillo";
                    break;

                case 'R':
                    indiceColor = 3;
                    this.color = "Rojo";
                    break;
            }

            estado = state == '1';
        }
    }
}
