﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInvoicePeru.FirmadoSunat.Models
{
#if TESTING
    [Serializable]
#endif
    public class DatoAdicional
    {
        public string Codigo { get; set; }
        public string Contenido { get; set; }
    }
}
