using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tabla
{
    public class cEquipo
    {
        public DataTable EquipoGetbyId(int IdEquipo)
        {
            string sql = "";
            sql = "select * from equipo where idequipo=" + IdEquipo.ToString();
            DataTable tb = cDb.GetDatatable(sql);
            return tb;
           
        }
    }
}
