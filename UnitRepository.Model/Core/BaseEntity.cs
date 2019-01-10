using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitRepository.Model.Core
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedBy = null;
            CreatedDate = DateTime.Now;
            ModifiedBy = null;
            ModifiedDate = null;
        }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
