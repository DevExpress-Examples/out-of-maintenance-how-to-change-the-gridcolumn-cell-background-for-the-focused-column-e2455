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

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Xpf.Editors.Settings
Imports System.Threading
Imports DevExpress.Data

Namespace WpfApplication1
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim coll As New List(Of ContactItem)()
            Dim f1 As New ContactItem()
            f1.Name = "Abcd"
            f1.Salary = 13.40D
            f1.MyDate = Date.Now
            coll.Add(f1)
            Dim f2 As New ContactItem()
            f2.Name = "bla1"
            f2.MyDate = Date.Now
            f2.Salary = 13

            coll.Add(f2)

            Dim f3 As New ContactItem()
            f3.Name = "la"
            f3.Salary = 13

            coll.Add(f3)

            Dim f4 As New ContactItem()
            f4.Name = " bla"
            f4.Salary = 13

            coll.Add(f4)

            gridControl1.ItemsSource = coll
        End Sub
    End Class
End Namespace
