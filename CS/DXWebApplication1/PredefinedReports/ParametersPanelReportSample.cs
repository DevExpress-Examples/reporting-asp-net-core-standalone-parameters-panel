using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DXWebApplication1.PredefinedReports {
    public partial class ParametersPanelReportSample : DevExpress.XtraReports.UI.XtraReport {
        public ParametersPanelReportSample() {
            InitializeComponent();
            CustomizeParametersPanel(this);
        }

        private void CustomizeParametersPanel(XtraReport report) {
            ParameterPanelFluentBuilder.Begin(report)
            .AddGroupItem(g0 => g0
                .WithTitle("Select dates")
                .WithBorderVisible(true)
                .AddParameterItem(report.Parameters["orderDates"], p0 => p0
                    .WithLabelOrientation(Orientation.Vertical)))
            .AddGroupItem(g1 => g1
                .WithTitle("Select a customer")
                .WithOrientation(Orientation.Horizontal)
                .WithShowExpandButton(true)
                .AddParameterItem(report.Parameters[1], p1 => p1
                    .WithLabelOrientation(Orientation.Vertical))
                .AddSeparatorItem()
                .AddGroupItem(g2 => g2
                    .WithTitle("Inner Group")
                    .AddParameterItem(report.Parameters[2])
                    .AddGroupItem(g3 => g3
                        .WithTitle("Inner Group")
                        .WithOrientation(Orientation.Vertical)
                        .AddParameterItem(report.Parameters[3], p3 => p3.WithLabelOrientation(Orientation.Vertical))
                        .AddSeparatorItem()
                        .AddParameterItem(report.Parameters[4], p3 => p3.WithLabelOrientation(Orientation.Vertical))
                    )
                ))
           .AddGroupItem(g4 => g4
                .WithTitle("Select dates")
                .WithBorderVisible(true)
                .WithOrientation(Orientation.Vertical)
                .AddParameterItem(report.Parameters[5], p0 => p0
                    .WithLabelOrientation(Orientation.Horizontal))
                .AddSeparatorItem()
                .AddParameterItem(report.Parameters[6], p1 => p1
                    .WithLabelOrientation(Orientation.Horizontal))
           )
           .AddGroupItem(g5 => g5
                .WithTitle("Select dates")
                .WithTitleVisible(false)
                .WithOrientation(Orientation.Horizontal)
                .AddParameterItem(report.Parameters[7], p0 => p0
                    .WithLabelOrientation(Orientation.Vertical))
                .AddSeparatorItem()
                .AddParameterItem(report.Parameters[8], p1 => p1
                    .WithLabelOrientation(Orientation.Vertical))
           ).AddParameterItem(report.Parameters[9], parameter => parameter
                .WithLabelOrientation(Orientation.Vertical))
            .End();
        }
    }
}
