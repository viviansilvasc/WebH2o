using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebH2O.Models
{
    public class LeituraTotal
    {
        public Int32 cod_leitura { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_final { get; set; }
        public Int32 cod_dispositivo { get; set; }
    }
}