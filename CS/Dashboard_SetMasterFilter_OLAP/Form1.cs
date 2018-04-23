using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;

namespace Dashboard_SetMasterFilter_OLAP {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // Loads a dashboard from an XML file.
            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");

            // Creates two sets of OLAP members' unique names to select corresponding cards 
            // in the Card dashboard item.
            List<object> cardValues1 = new List<object>();
            cardValues1.AddRange(new[] { "[Date].[Calendar Year].&[2001]",
                "[Date].[Calendar Quarter of Year].&[CY Q4]" });
            List<object> cardValues2 = new List<object>();
            cardValues2.AddRange(new[] { "[Date].[Calendar Year].&[2002]",
                "[Date].[Calendar Quarter of Year].&[CY Q1]" });
            List<IList> selectedCards = new List<IList>(new[] { cardValues1, cardValues2 } );

            // Selects specified cards in the Card dashboard item.
            dashboardViewer1.SetMasterFilter("cardDashboardItem1", selectedCards);
        }      
    }
}
