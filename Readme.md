<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580717/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5098)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to apply Master Filter in OLAP Mode


This example demonstrates how to specify the dashboard item selection as  master filter at runtime. 

The dashboard is bound to an [OLAP data source](https://docs.devexpress.com/Dashboard/15707). The [Card](https://docs.devexpress.com/Dashboard/15263) dashboard item acts as master filter item.

The [DashboardViewer.SetMasterFilter](https://docs.devexpress.com/Dashboard/devexpress.dashboardwin.dashboardviewer.setmasterfilter.overloads) sets the data in selected cards as the master filter. Note that the filter  uses unique OLAP member names instead of values.

![](/images/screenshot.png)


## Files to Look At

* [Form1.cs](./CS/Dashboard_SetMasterFilter_OLAP/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_SetMasterFilter_OLAP/Form1.vb))


## Documentation

- [Master Filtering](https://docs.devexpress.com/Dashboard/116912)

## More Examples

- [How to Apply Default Filtering to Master Filter Items that Affect Each Other](https://github.com/DevExpress-Examples/win-viewer-how-to-apply-default-filtering-to-master-filter-items-that-affect-each-other-t474844) 
- [How to Initialize Master Filters in Dashboard Viewer](https://github.com/DevExpress-Examples/how-to-apply-default-filtering-to-master-filters-in-dashboardviewer-t329583)
