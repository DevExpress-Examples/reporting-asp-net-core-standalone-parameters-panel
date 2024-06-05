using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace DXWebApplication1.PredefinedReports {
    public partial class ParametersPanelReport : DevExpress.XtraReports.UI.XtraReport {
        public ParametersPanelReport() {
            InitializeComponent();
            CustomizeParametersPanel(this);
        }

        private void CustomizeParametersPanel(XtraReport report) {
            ParameterPanelFluentBuilder.Begin(report)
                .ClearItems()
                .AddGroupItem(g0 => g0
                    .WithTitle("Select dates")
                    .WithBorderVisible(true)
                    .AddParameterItem(report.Parameters["pOrderDates"], p0 => p0
                        .WithLabelOrientation(Orientation.Vertical)
                        )
                    )
             .AddGroupItem(g1 => g1
                 .WithTitle("Select a customer")
                 .WithOrientation(Orientation.Horizontal)
                 .WithShowExpandButton(true)
                 .AddParameterItem(report.Parameters["pCustomer"], p1 => p1
                     .WithLabelOrientation(Orientation.Vertical))
                 .AddSeparatorItem()
                 .AddGroupItem(g2 => g2
                     .WithTitle("Customer order details")
                     .AddParameterItem(report.Parameters["pCountry"])
                     )
                 )
            .End();
        }
    }
}
