using BLL;
using System;
using System.Collections.Generic;

namespace UI_Voladores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal unAnimal = new Animal(); No se puede porque Animal es clase abstracta

            Paloma unaPaloma = new Paloma( "Blanquita" );
            Tigre unTigre = new Tigre("Tiger");
            Aguila unAguila = new Aguila("Mágica");
            Mariposa unaMariposa = new Mariposa("una mariposa");

            List<Animal> animales = new List<Animal>();
            animales.Add(unaPaloma);
            animales.Add(unTigre); 
            animales.Add(unAguila);
            animales.Add(unaMariposa);

            // unaPaloma.Desplazarse();
            // unTigre.Desplazarse();
            // unAguila.Desplazarse();
            foreach (Animal cadaAnimal in animales)
            {
                Console.WriteLine( cadaAnimal.GetType().ToString() );
                cadaAnimal.Desplazarse();
            }

            Console.WriteLine("\n===========================================================\n\n");

            Avion unAvion = new Avion();

            List<IObjVolador> voladores = new List<IObjVolador>();
            voladores.Add(unAvion);
            voladores.Add(unaPaloma);
            // voladores.Add(unTigre); un Tigre no implementa la interfaz IObjVolador por lo tanto no puede ser refereciando por ella
            voladores.Add(unAguila);
            voladores.Add(unaMariposa);

            foreach (IObjVolador cadaVolador in voladores)
            {
                Console.WriteLine(cadaVolador.GetType().ToString());
                cadaVolador.Volar();
            }



            Console.ReadKey();
        }
    }
}
