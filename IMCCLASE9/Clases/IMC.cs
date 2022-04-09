using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCCLASE9.Clases
{
    internal class IMC
    {
        private const double KG = 2.2046;
        public int edad = 0;
        public String nombre { get; set; }
        public int altura { get; set; } 
        public char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }

        public string prueba()
        {

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Ingrese su sexo: 'F' o 'M'");
                sexo = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            }
            else {}
            Console.WriteLine("Ingrese su peso en Libras: ");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su altura en CM: ");
            altura = Convert.ToInt32(Console.ReadLine());

            double PesoKG = peso / KG;
            double estaturaMts = (double)altura / 100;
            double altu = (Math.Pow(estaturaMts, 2));
            imc = PesoKG / altu;
            return imc.ToString();
        }
        public string resultado()
        {
            string mensaje = "";
            if (edad >= 18)
            {

                if (imc < 18.5)
                {
                    mensaje = $"{nombre}, se encuentra en peso bajo. El niño debería mejorar su alimentación.";
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    mensaje = $"{nombre}, está en un peso normal. Excelente";
                }
                else if (imc >= 25 && imc < 30)
                {
                    mensaje = $"{nombre}, está en sobrepeso. Debería considerar reducir ciertas comidas al niño.";
                }
                else if (imc >= 30)
                {
                    mensaje = $"{nombre}, usted se encuentra en obesidad. Visiten a un nutriólogo, por la salud del niño.";
                }
                return mensaje;
            }
            else if (edad < 18 && sexo == 'F')
            {
                if (imc < 17.8)
                {
                    mensaje = $"{nombre}, usted está baja de peso. Debería subir un poco por salud.";
                }
                else if (imc >= 17.8 && imc < 25.5)
                {
                    mensaje = $"{nombre}, usted está en un peso normal. Excelente.";
                }
                else if (imc >= 25.5 && imc < 30)
                {
                    mensaje = $"{nombre}, usted está en sobrepeso. Debería reconsiderar una dieta.";
                }
                else if (imc >= 30)
                {
                    mensaje = $"{nombre}, usted se encuentra en obesidad. Debería visitar a un nutriólogo por su salud.";
                }
                
            }
            else if (edad < 18 && sexo == 'M')
            {
                if (imc < 18.2)
                {
                    mensaje = $"{nombre}, usted está bajo de peso. Necesitaría subir un poco.";
                }
                else if (imc >= 18.3 && imc < 25.5)
                {
                    mensaje = $"{nombre}, usted está en un peso normal. Excelente.";
                }
                else if (imc >= 25.5 && imc < 29)
                {
                    mensaje = $"{nombre}, usted está en sobrepeso. Debería reconsiderar una dieta.";
                }
                else if (imc >= 29)
                {
                    mensaje = $"{nombre}, usted se encuentra en obesidad. Visite a un nutriólogo, por su salud.";
                }
                return mensaje;
            }
            return mensaje;
        }
    }
}
