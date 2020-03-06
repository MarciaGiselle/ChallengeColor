using Modelo;
using System;
using System.Collections.Generic;

namespace Servicio
{
    public class ColorServicio
    {
        private Random random = new Random();
        
        public List<Color> ObtenerColores(int nivel)
        {
            List<Color> listaColores = new List<Color>();
            Color color = new Color(String.Format("#{0:X6}", random.Next(0x1000000)));
            listaColores.Add(color);
            Color colorSimilar;
            int cantidadColores = 5;
            if (nivel == 1)
                cantidadColores = 3;
                
            for (int i = 0; listaColores.Count < cantidadColores; i++)
            {
                if (nivel == 1)
                    colorSimilar = new Color(String.Format("#{0:X6}", random.Next(0x1000000)));
                else
                    colorSimilar = CrearColorSimilar(color);
                
                if (!listaColores.Contains(colorSimilar))
                    listaColores.Add(colorSimilar);
            }
                        
            listaColores[random.Next(0,cantidadColores)].estaSeleccionado = true;
            return listaColores;
        }

        private Color CrearColorSimilar(Color color)
        {
            int parametroLimite = 70;
            int red = color.colorR + random.Next(- parametroLimite, parametroLimite);
            int green = color.colorG + random.Next(- parametroLimite, parametroLimite);
            int blue = color.colorB + random.Next(- parametroLimite, parametroLimite);

            return new Color(red, green,blue);
        }

       
    }
}
