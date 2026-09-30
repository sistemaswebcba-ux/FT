using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
// aca apunta la dll D:\PROGRAMACION\ft\TablaDLL\TablaDLL\
namespace Tabla
{
    public class cTabla
    {
        public void TablaGral(int idTorneoSeleccionado)
        {
            DataTable tl = cDb.GetDatatable("TablaLocalGet");
            DataTable tv = cDb.GetDatatable("TablaVisitanteGet");

        }
    }
}
