using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinq
{
    public class Shool
    {
        // Класс назвал так потому что не заметил. а потом решил что так должно быть везде

        public int id { get; set; }
        public string NameClass { get; set; }
        public int quantity { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
