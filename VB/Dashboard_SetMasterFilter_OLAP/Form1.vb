Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Collections

Namespace Dashboard_SetMasterFilter_OLAP
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			' Loads a dashboard from an XML file.
			dashboardViewer1.LoadDashboard("..\..\Data\Dashboard.xml")

			' Creates two sets of OLAP members' unique names to select corresponding cards 
			' in the Card dashboard item.
			Dim cardValues1 As New List(Of Object)()
            cardValues1.AddRange(New String() {"[Date].[Calendar Year].&[2001]", _
                                               "[Date].[Calendar Quarter of Year].&[CY Q4]"})
			Dim cardValues2 As New List(Of Object)()
            cardValues2.AddRange(New String() {"[Date].[Calendar Year].&[2002]", _
                                               "[Date].[Calendar Quarter of Year].&[CY Q1]"})
            Dim selectedCards As New List(Of IList)(New IList() {cardValues1, cardValues2})

			' Selects specified cards in the Card dashboard item.
			dashboardViewer1.SetMasterFilter("cardDashboardItem1", selectedCards)
		End Sub
	End Class
End Namespace
