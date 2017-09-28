using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDelivery.Pages.Menu
{

    public class PaginaMasterMenuItem
    {
        public PaginaMasterMenuItem()
        {
            TargetType = typeof(PaginaMasterDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}