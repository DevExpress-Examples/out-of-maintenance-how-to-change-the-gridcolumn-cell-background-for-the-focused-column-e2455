' Developer Express Code Central Example:
' How to change the GridColumn cell background for the focused column
' 
' This sample illustrates how to change the focused column appearance. Create the
' attached property for the GridColumn that determines whether the row is focused
' or not. Iterate via columns in the FocusedColumnChanged event, to keep this
' attached property up-to-date for every column. In the CellStyle event, change
' the Background property only for columns for which the custom attached property
' is True.
' Starting with version 2013 vol 1 the GridControl.FocusedColumnChanged
' event is marked as obsolete. The GridControl.CurrentColumnChanged event should
' be used instead.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2455
Imports System.ComponentModel

Namespace WpfApplication1

    Public Class ContactItem

        Public Property Name As String

        Public Property Salary As Decimal

        Public Property MyDate As Date
    End Class
End Namespace
