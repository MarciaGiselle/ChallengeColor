using System;

namespace Modelo
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private string v;

        public String colorHex { get; set; }
        public int colorR { get; set; }
        public int colorG { get; set; }
        public int colorB { get; set; }
        public String nombre { get; set; }
        public bool estaSeleccionado { get; set; }
        public Color() { }

        public Color(String hex)
        {
            this.colorHex = hex;
            this.colorR = Convert.ToInt32(hex.Substring(1, 2), 16);
            this.colorG = Convert.ToInt32(hex.Substring(3, 2), 16);
            this.colorB = Convert.ToInt32(hex.Substring(5, 2), 16);

        }

        public Color(int red, int green, int blue)
        {
            this.colorR = red < 0 ? red * -1 : (red > 255 ? 255 : red);
            this.colorG = green < 0 ? green * -1 : (green > 255 ? 255 : green) ;
            this.colorB = blue < 0 ? blue * -1 : (blue > 255 ? 255 : blue);
            
            String hexR = String.Format("#{0:X2}", this.colorR);
            String hexG = String.Format("{0:X2}", this.colorG);
            String hexB = String.Format("{0:X2}", this.colorB);

            this.colorHex = String.Concat(hexR, hexG, hexB);
        }
    }
}
