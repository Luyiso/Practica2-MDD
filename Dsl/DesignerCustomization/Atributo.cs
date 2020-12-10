using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPM_IPS.DCMLRACPGProyectoIPS
{
    public partial class Atributo
    {
        public string GetNameTipoValue()
        {
            return string.Format("{0}: {1}", this.Name, this.Type);
        }

        public void SetNameTipoValue (string newValue) { }
    }
}
