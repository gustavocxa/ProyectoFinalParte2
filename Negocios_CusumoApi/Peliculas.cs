﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios_CusumoApi
{
    public class Peliculas
    {
        public int IdPelicula { get; set; }
        public string Nombre { get; set; }
        public string Reseña { get; set; }
        public double Calificación { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Poster { get; set; }
        public byte[] PosterImage { get; set; }
    }
    public class ResponseModel
    {
        public int Codigo { get; set; }
        public List<Peliculas> Mensaje { get; set; }
    }

}