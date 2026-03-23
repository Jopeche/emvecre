using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emvecre
{
    internal class crearVistas
    {
            public static void crearVistas1()
            {
                ConexSQL objMiconexion = new ConexSQL();
            string[] vistas = new string[]
                {
                    "CREATE OR ALTER VIEW [dbo].[View] AS SELECT * FROM [dbo].[ventas]",
                    "CREATE OR ALTER VIEW [dbo].[View2] AS SELECT * FROM [dbo].[CierreCaja]",
                    "CREATE OR ALTER VIEW [dbo].[View3] AS SELECT * FROM [dbo].[Retiros]"
                };
    
                foreach (string vista in vistas)
                {
                    objMiconexion.ejecutarSentenciaSql(vista);
            }
        }
    }
}
