﻿using System;
using System.Collections.Generic;

namespace CUS_Mostrar_Resultados.Models
{
    public partial class TModalidadCon
    {
        public TModalidadCon()
        {
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
            TUsuarioModalidadTanda = new HashSet<TUsuarioModalidadTanda>();
        }

        public int PkImIdModalidad { get; set; }
        public string VmNombreMod { get; set; }

        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
        public ICollection<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }
    }
}
