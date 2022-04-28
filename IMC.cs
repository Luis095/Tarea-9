using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_de_nutricion_IMC
{
    public class Imc
    {
        private const double KG = 2.2046;
        public int edad { get; set; }
        public string nombre { get; set; }
        public int altura { get; set; }
        public Char sexo { get; set; }
        public int peso { get; set; }
        public double imc { get; set; }

        public string prueba()
        {
            this.nombre = "Luis Raymundo";//ingreso de datos
            this.edad = 19;
            this.sexo = 'H';
            this.altura = 179;
            this.peso = 180;


            //Inicio de calculo IMC
            double pesoKG = this.peso / KG;
            double estaturaMTS = (double)this.altura / 100;
            double altu = (Math.Pow(estaturaMTS, 2));
            this.imc = pesoKG / altu;
            //fin del calculo de IMC
            Console.WriteLine("su IMC es de:" + imc);
            if (edad >= 19)//funcion if principal para las edades
            {
                if (imc >= 40)//comparacion de peso de adutlo
                {
    return "tiene un grado medio de obesidad y se le recomienda visitar a unmedico especialista";
}
if ((imc >= 30) && (imc < 40))
{
    return "La persona correcta para tratar su caso seria un medico nutricionista";
}
if ((imc >= 26) && (imc < 30))
{
    return "Se le recomienda entrar a un deficit calorico";
}
else if ((imc >= 18) && (imc < 25))
{
    return "Su nivel de grasa en el cuerpo a bajado";
}

else
{
    return "Su peso esta en un estado critico por que sus nivles de grasa en el cuerpo son muy bajos";
}
            }
            //fin del primer if
            else//funcion else principal
{
    if (imc >= 40)//comparacion de peso para niños
    {
        return "Su peso entra en la categoria de sobrepeso";
    }
    if ((imc >= 30) && (imc < 40))
    {
        return "El niño tiene sobre peso y se recomienda empesar una dieta receta por un pediatra y nutriologo ";
    }
    if ((imc >= 26) && (imc < 30))
    {
                    return "El niño esta con sobre peso y debria entrar en deficit calorico";
    }
    else if ((imc >= 18) && (imc < 25))
    {
        return " su peso es normal para un niño de su edad y altura";
    }
    else
    {
        return "El peso del niño es critico por falta de peso y se recomienda subir sus niveles de masa musculk ";
    }

}//fin de la funcion if else

        }

    }
}