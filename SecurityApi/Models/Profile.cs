using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApi.Models
{
    public class Profile : BaseEntity
    {
        public Profile()
        {

        }

        public int? AccountId { get; set; }

        public string Name { get; set; }

        public Account Account { get; set; }
    }
}
