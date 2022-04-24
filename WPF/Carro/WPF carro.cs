using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Carro
{
          public class CARRO

          {
            public string Marca { get; }
            public int Modelo { get; }
            public string Color { get; set; }
            public int VMaxima { get; }

            private int Encendido = 0;
            private int velocidad_actual = 0;
            private const int MAXVELOCIDAD = 150;

            public CARRO(string _marca, int _modelo, string _color, int _vmaxima)
            {
                Marca = _marca;
                Modelo = _modelo;
                Color = _color;
                VMaxima = _vmaxima;
                Encendido = 0;
                this.velocidad_actual = 0;
            }
            public string GetVelocidadActual()
            {
                return $"vamos a {velocidad_actual} KM/H";
            }

           public string EncendidoMotor()
            {
                if (Encendido == 0)
                {
                Encendido = 1;
                return "Tu carro esta listo para correr";
                    this.velocidad_actual = 0;
                }
                else
                {
                    return"Ya esta encendido tu carro!!!";
                }
            }

            public string acelerar()
            {
                string mensaje = "";
                if (Encendido == 0)
                {
                    mensaje = $"no puedo acelerar con el carro apagado";
                    return mensaje;
                }

                velocidad_actual += 20;
                if (velocidad_actual <= VMaxima)
                {
                    mensaje = $"Vas a {velocidad_actual} KPH";
                }
                else
                {
                    velocidad_actual = VMaxima;
                    mensaje = $"{velocidad_actual}KPH Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
                }

                Console.WriteLine(mensaje);
                return mensaje;

            }

            public string acelerar(int CuantosKPH)
            {
                string mensaje = "";
                if (Encendido == 0)
                {
                    mensaje = $"No puedo acelerar con el carro apagado";
                    return mensaje;

                }

                velocidad_actual += CuantosKPH;
                if (velocidad_actual <= MAXVELOCIDAD)
                {
                    mensaje = $"Vas a {velocidad_actual} KM/H";
                }
                else
                {
                    velocidad_actual = MAXVELOCIDAD;
                    mensaje = $"{velocidad_actual} KM/H Aguas toreto, Vas muy rapido y ya llegaste a; tope";
                }
                Console.WriteLine(mensaje);
                return mensaje;
            }

            public string desacelerar()
            {
                string mensaje = "";
                if (Encendido == 0)
                {
                    mensaje = $"No puedes desacelerar si el carro esta apagado!!";
                    return mensaje;
                }
                else
                {
                    velocidad_actual -= 5;
                    mensaje = $"Tu carro va desacelerando, tu velocidad actual es {velocidad_actual}";

                }
                Console.WriteLine(mensaje);
                return mensaje;

            }

            public string frenar()
            {
                string mensaje = "";
                if (Encendido == 0)
                {
                    mensaje = "El carro esta apagado, no puedes frenar";
                }
                else
                {
                    velocidad_actual -= 10;
                    if (velocidad_actual >= 0)
                    {
                        mensaje = $"Tu carro va frenando, tu velocidad es {velocidad_actual}KM/H";

                    }
                    else
                    {
                        mensaje = $"Ya no puedes seguir frenando, vamos a 0KM/H";
                    }
                }


                Console.WriteLine(mensaje);
                return mensaje;
            }

            public string apagarmotor()
            {
                if (Encendido == 1)
                {
                    return"Tu Carro esta siendo apagado";
                    return"Tu carro ya está apagado";
                    Encendido = 0;
                }
                else
                {
                    return"Weii! el carro ya estaba apagado";
                }
            }

            public string Bocinar()
            {
                string mensaje = "tututu!!! tu carro esta bocinando!";
                Console.WriteLine(mensaje);
                return mensaje;
            }
        }
    }


