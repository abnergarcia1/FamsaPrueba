﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Famsa.Modelos
{
    public class Pendiente
    {
        public int IdPendiente;
        public string Descripcion{get; set; }
        public string Estatus { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int IdUsuario { get; set; }
    }
}
