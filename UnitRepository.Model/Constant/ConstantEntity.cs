using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitRepository.Model.Constant
{
    public class ConstantEntity
    {
        public const int LengthPrefix = 50;
        public const int LengthFirstName = 255;
        public const int LengthLastName = 255;
        public const int LengthFullName = LengthFirstName + LengthLastName;
    }
}
