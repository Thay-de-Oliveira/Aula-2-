using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att___1.Ordenacao
{
    public class Ordenar
    {
            public List<string> Ordem(List<string>w)
            {
            return w.OrderBy(c=>c).ToList();
            }
            
     
    }
}
