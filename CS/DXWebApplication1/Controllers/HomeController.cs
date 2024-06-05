using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.Web.ParametersPanel;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Error() {
            Models.ErrorModel model = new Models.ErrorModel();
            return View(model);
        }
        

        public IActionResult DocumentViewer(
            [FromServices] IWebDocumentViewerClientSideModelGenerator viewerModelGenerator,
            [FromQuery] string reportName) {
            reportName = string.IsNullOrEmpty(reportName) ? "ParametersPanelReport001" : reportName;
            var viewerModel = viewerModelGenerator.GetModel(reportName, CustomWebDocumentViewerController.DefaultUri);
            return View(viewerModel);
        }

        public async Task<IActionResult> ExportReport(
            [FromServices] IReportParametersSerializer reportParametersSerializer,
            [FromForm] string serializedParameters,
            [FromForm] string reportUrl) {
            var report = await reportParametersSerializer.ApplyParametersStateAsync(reportUrl, serializedParameters);
            using var stream = new MemoryStream();
            report.ExportToPdf(stream);
            return File(stream.ToArray(), "application/pdf");
        }

        public IActionResult ParametersPanel(
            [FromQuery] string reportName,
            [FromServices] IReportParametersPanelClientSideModelGenerator clientSideModelGenerator) {
            var reportNameToOpen = reportName ?? "ParametersPanelReport001";
            ReportParametersPanelModel parametersPanelModel = clientSideModelGenerator.GetModel(reportNameToOpen, WebDocumentViewerController.DefaultUri);
            return View("ParametersPanel", parametersPanelModel);
        }
    }
}