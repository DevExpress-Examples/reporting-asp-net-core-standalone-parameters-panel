# Reporting for ASP.NET Core - Standalone Report Parameters Panel

This example shows how to use the standalone report options panel in an ASP.NET Core application.

The application includes two pages: one with the standalone report options panel and the other with the document viewer. Both pages load the same sample report.
The report is a list of invoices from the Northwind database. It includes parameters created in Visual Studio Report Designer that are used to filter the report data.
The parameter panel layout is created in code in the report class constructor using the [ParameterPanelFluentBuilder] class (https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Parameters.ParameterPanelFluentBuilder). 

A model for the Standalone Report Parameters Panel component is created in the ParametersPanel controller action on the server. The model contains a report instance with the layout information that the Standalone Report Parameters Panel retrieves. The parameter panel layout information is stored  in the [XtraReport.ParameterPanelLayoutItems](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ParameterPanelLayoutItems) collection.

The client-side JavaScript code adds an Export button to the Standalone Report Parameter Panel component. When the user clicks the button, a request to the ExportReport controller action is executed, and the resulting PDF file is sent to the client.