using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DXWebApplication1.PredefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["TestReport"] = () => new TestReport(),
            ["ParametersPanelReport"] = () => new ParametersPanelReport(),
            ["ParametersPanelReportSample"] = () => new ParametersPanelReportSample()
        };
    }
}