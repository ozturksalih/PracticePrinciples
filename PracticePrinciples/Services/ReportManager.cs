using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Services
{
    using DataAccess;
    public class ReportManager : IReportService
    {
        private readonly IEnumerable<IReportDao> _reportDaos;
        public ReportManager(IEnumerable<IReportDao> reportDaos)
        {
            _reportDaos = reportDaos;
        }

        public IDictionary<string, int> GetByColour()
        {
            var result = new Dictionary<string, int>();
            foreach (var dao in _reportDaos)
            {
                var colourNumbers = dao.GetByColours();
                if(colourNumbers == null || colourNumbers.Count == 0)
                {
                    continue;
                }
                foreach (var item in colourNumbers)
                {
                    if (result.TryGetValue(item.Key, out var value))
                    {
                        result[item.Key] += item.Value;
                    }
                    else
                    {
                        result.Add(item.Key, item.Value);
                    }
                }
            }
            return result;
        }

        public int GetTotalPower()
        {
            var totalPower = 0;
            foreach (var daos in _reportDaos)
            {
                totalPower += daos.GetTotalPower();
            }
            return totalPower;
        }
    }
}
