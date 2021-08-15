using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Services
{
    public interface IReportService
    {
        int GetTotalPower();
        IDictionary<string,int> GetByColour();
    }
}
