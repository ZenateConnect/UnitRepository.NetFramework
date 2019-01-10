using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitRepository.Model.Constant;

namespace UnitRepository.Model.Core
{
    public class SampleClass : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(ConstantEntity.LengthFirstName)]
        public string FirstName { get; set; }

        [StringLength(ConstantEntity.LengthLastName)]
        public string LastName { get; set; }

        [NotMapped]
        [StringLength(ConstantEntity.LengthFullName)]
        public string FullName
        {
            get
            {
                return string.Concat(FirstName, " ", LastName);
            }
        }
    }
}
