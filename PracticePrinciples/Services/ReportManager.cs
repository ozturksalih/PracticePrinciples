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
