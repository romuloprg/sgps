using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGPS.Models
{
    public class RelatoriosModel
    {
        private DateTime dtmDataInicio;

        public DateTime DtmDataInicio
        {
            get { return dtmDataInicio; }
            set { dtmDataInicio = value; }
        }
        private DateTime dtmDataFim;

        public DateTime DtmDataFim
        {
            get { return dtmDataFim; }
            set { dtmDataFim = value; }
        }
    }
}