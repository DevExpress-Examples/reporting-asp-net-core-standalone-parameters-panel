
namespace DXWebApplication1.PredefinedReports {
    partial class ParametersPanelReportSample {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.orderDates = new DevExpress.XtraReports.Parameters.Parameter();
            this.orderDates_Start = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.orderDates_End = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.company = new DevExpress.XtraReports.Parameters.Parameter();
            this.customer = new DevExpress.XtraReports.Parameters.Parameter();
            this.boolParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dateRangeParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dateRangeParameter_Start = new DevExpress.XtraReports.Parameters.RangeStartParameter();
            this.dateRangeParameter_End = new DevExpress.XtraReports.Parameters.RangeEndParameter();
            this.parameter3 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter4 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter5 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter6 = new DevExpress.XtraReports.Parameters.Parameter();
            this.parameter7 = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 101F;
            this.TopMargin.Name = "TopMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.Name = "Detail";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 45.99997F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(650F, 23F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Customer: [?customer]";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(650F, 23F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Company: [?company]";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Order dates: [?orderDates_Start] - [?orderDates_End]";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(122.917F, 23.958F);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.label1.Text = "label1";
            // 
            // orderDates
            // 
            this.orderDates.Description = "Order Dates:";
            this.orderDates.Name = "orderDates";
            this.orderDates.Type = typeof(global::System.DateTime);
            this.orderDates.ValueSourceSettings = new DevExpress.XtraReports.Parameters.RangeParametersSettings(this.orderDates_Start, this.orderDates_End);
            // 
            // orderDates_Start
            // 
            this.orderDates_Start.Name = "orderDates_Start";
            this.orderDates_Start.ValueInfo = "2021-11-03";
            // 
            // orderDates_End
            // 
            this.orderDates_End.Name = "orderDates_End";
            this.orderDates_End.ValueInfo = "2021-11-03";
            // 
            // company
            // 
            this.company.Description = "Company Name:";
            this.company.Name = "company";
            // 
            // customer
            // 
            this.customer.Description = "Customer Name:";
            this.customer.Name = "customer";
            // 
            // boolParameter
            // 
            this.boolParameter.Description = "Boolean Parameter";
            this.boolParameter.Name = "boolParameter";
            this.boolParameter.Type = typeof(bool);
            this.boolParameter.ValueInfo = "False";
            // 
            // dateRangeParameter
            // 
            this.dateRangeParameter.Description = "Date Range";
            this.dateRangeParameter.Name = "dateRangeParameter";
            this.dateRangeParameter.Type = typeof(global::System.DateTime);
            this.dateRangeParameter.ValueSourceSettings = new DevExpress.XtraReports.Parameters.RangeParametersSettings(this.dateRangeParameter_Start, this.dateRangeParameter_End);
            // 
            // dateRangeParameter_Start
            // 
            this.dateRangeParameter_Start.Name = "dateRangeParameter_Start";
            this.dateRangeParameter_Start.ValueInfo = "2021-12-15";
            // 
            // dateRangeParameter_End
            // 
            this.dateRangeParameter_End.Name = "dateRangeParameter_End";
            this.dateRangeParameter_End.ValueInfo = "2021-12-15";
            // 
            // parameter3
            // 
            this.parameter3.Description = "Parameter3";
            this.parameter3.MultiValue = true;
            this.parameter3.Name = "parameter3";
            this.parameter3.Type = typeof(short);
            this.parameter3.ValueInfo = "0";
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(((short)(1)), "1"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(((short)(2)), "2"));
            this.parameter3.ValueSourceSettings = staticListLookUpSettings1;
            // 
            // parameter4
            // 
            this.parameter4.Description = "Date Multivalue";
            this.parameter4.MultiValue = true;
            this.parameter4.Name = "parameter4";
            this.parameter4.Type = typeof(global::System.DateTime);
            // 
            // parameter5
            // 
            this.parameter5.Description = "Parameter5";
            this.parameter5.Name = "parameter5";
            // 
            // parameter6
            // 
            this.parameter6.Description = "Parameter6";
            this.parameter6.Name = "parameter6";
            // 
            // parameter7
            // 
            this.parameter7.Description = "Parameter7";
            this.parameter7.Name = "parameter7";
            this.parameter7.Type = typeof(global::System.DateTime);
            // 
            // ParametersPanelReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
            this.DisplayName = "AA";
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 101F, 100F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.orderDates,
            this.company,
            this.customer,
            this.boolParameter,
            this.dateRangeParameter,
            this.parameter3,
            this.parameter4,
            this.parameter5,
            this.parameter6,
            this.parameter7});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.Parameters.Parameter orderDates;
        private DevExpress.XtraReports.Parameters.RangeStartParameter orderDates_Start;
        private DevExpress.XtraReports.Parameters.RangeEndParameter orderDates_End;
        private DevExpress.XtraReports.Parameters.Parameter company;
        private DevExpress.XtraReports.Parameters.Parameter customer;
        private DevExpress.XtraReports.Parameters.Parameter boolParameter;
        private DevExpress.XtraReports.Parameters.Parameter dateRangeParameter;
        private DevExpress.XtraReports.Parameters.RangeStartParameter dateRangeParameter_Start;
        private DevExpress.XtraReports.Parameters.RangeEndParameter dateRangeParameter_End;
        private DevExpress.XtraReports.Parameters.Parameter parameter3;
        private DevExpress.XtraReports.Parameters.Parameter parameter4;
        private DevExpress.XtraReports.Parameters.Parameter parameter5;
        private DevExpress.XtraReports.Parameters.Parameter parameter6;
        private DevExpress.XtraReports.Parameters.Parameter parameter7;
    }
}
