using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class DataAccessBase
    {
        protected int GenerateId(IEnumerable<int> ids)
        {
            if (!ids.Any())
            {
                return 1;
            }
            return ids.Max() + 1;
        }
    }
}
