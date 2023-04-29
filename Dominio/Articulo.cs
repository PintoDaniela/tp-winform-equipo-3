﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {

        public int Id { set; get; }
        public string Codigo { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public float Precio { set; get; }
        public Marca Marca { set; get; }
        public Categoria Categoria { set; get; }       
        public List<Imagen> Imagenes { set; get; }

    }
}
