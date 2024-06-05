<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/810740390/24.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1236501)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for ASP.NET Core - Standalone Report Parameters Panel

This example shows how to use the Standalone Report Parameters panel in an ASP.NET Core application.

![Standalone Report Parameters Panel](images/screenshot.png)

The application includes two pages: one with the standalone report options panel and the other with the document viewer. Both pages load the same sample report.

The report is a list of invoices from the Northwind database. It includes parameters created in Visual Studio Report Designer that are used to filter the report data.

The parameter panel layout is created in code in the report class constructor using the [ParameterPanelFluentBuilder](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Parameters.ParameterPanelFluentBuilder) class . 

A model for the Standalone Report Parameters Panel component is created in the **ParametersPanel** controller action on the server. The model contains a report instance with the layout information that the Standalone Report Parameters Panel retrieves. The parameter panel layout information is stored  in the [XtraReport.ParameterPanelLayoutItems](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ParameterPanelLayoutItems) collection.

The client-side JavaScript code adds an Export button to the Standalone Report Parameter Panel component. When the user clicks the button, a request to the **ExportReport** controller action is executed, and the resulting PDF file is sent to the client.

## Files to Review

- [ParametersPanelReport.cs](CS\DXWebApplication1\PredefinedReports\ParametersPanelReport.cs)
- [HomeController.cs](CS\DXWebApplication1\Controllers\HomeController.cs)
- [ParametersPanel.cshtml](CS\DXWebApplication1\Views\Home\ParametersPanel.cshtml)

## Documentation

- [Standalone Report Parameters Panel](https://docs.devexpress.com/XtraReports/404883/web-reporting/standalone-parameters-panel)
- [Standalone Report Parameters Panel in ASP.NET Core Applications](https://docs.devexpress.com/XtraReports/404888/web-reporting/asp-net-core-reporting/standalone-parameters-panel-asp-net-application/add-the-standalone-parameters-panel-to-asp-net-core-application)
- [How to Use Parameter Values from the Standalone Report Parameters Panel (ASP.NET Core App)](https://docs.devexpress.com/XtraReports/404889/web-reporting/asp-net-core-reporting/standalone-parameters-panel-asp-net-application/send-parameters-from-panel-to-server)
