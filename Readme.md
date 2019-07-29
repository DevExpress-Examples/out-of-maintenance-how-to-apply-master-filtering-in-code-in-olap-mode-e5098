<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_SetMasterFilter_OLAP/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_SetMasterFilter_OLAP/Form1.vb))
<!-- default file list end -->
# How to: Apply Master Filter in OLAP Mode


Tihs example demonstrates how to specify the dashboard item selection as  master filter at runtime. 

The dashboard is bound to an [OLAP data source](https://docs.devexpress.com/Dashboard/15707). The [Card](https://docs.devexpress.com/Dashboard/15263) dashboard item acts as master filter item.

The [DashboardViewer.SetMasterFilter](https://docs.devexpress.com/Dashboard/devexpress.dashboardwin.dashboardviewer.setmasterfilter.overloads) sets the data in selected cards as the master filter. Note that the filter  uses unique OLAP member names instead of values.

![](/images/screenshot.png)


