using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace eexamen2
{
    public class pelicula
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }

        public int Año { get; set; }

       

        public pelicula(string titulo, string genero, int Año)
        {
            
            this.Titulo = titulo;
            this.Genero = genero;
            this.Año = Año;

          

        }
    }
}
