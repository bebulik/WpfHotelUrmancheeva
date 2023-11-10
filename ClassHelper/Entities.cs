using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfHotel1.DB;

namespace WpfHotel1.ClassHelper
{
    public class Entities
    {
        public static DBEntities Context { get; } = new DBEntities();
    }
}
