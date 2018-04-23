Imports Microsoft.VisualBasic
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
Imports DevExpress.Wpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Wpf.Editors.Settings
Imports System.Threading
Imports DevExpress.Data
Imports System.Windows.Markup

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
	   Private coll As List(Of ContactItem)


		Public Shared Function GetIsColumnFocused(ByVal obj As DependencyObject) As Boolean
			Return CBool(obj.GetValue(IsColumnFocusedProperty))
		End Function

		Public Shared Sub SetIsColumnFocused(ByVal obj As DependencyObject, ByVal value As Boolean)
			obj.SetValue(IsColumnFocusedProperty, value)
		End Sub

		' Using a DependencyProperty as the backing store for IsColFocused.  This enables animation, styling, binding, etc...
		Public Shared ReadOnly IsColumnFocusedProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsColumnFocused", GetType(Boolean), GetType(MainWindow), New UIPropertyMetadata(False))




		Private Sub View_FocusedColumnChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim view As TableView = TryCast(sender, TableView)
			For Each gc As GridColumn In gridControl1.Columns
                If gc Is view.FocusedColumn Then
                    SetIsColumnFocused(gc, True)
                Else
                    SetIsColumnFocused(gc, False)
                End If
			Next gc
		End Sub

		Public Sub New()
			InitializeComponent()
			Dim focusedColumnPropertyDescriptor As DependencyPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(GridViewBase.FocusedColumnProperty, GetType(GridViewBase))
			focusedColumnPropertyDescriptor.AddValueChanged(gridControl1.View, AddressOf View_FocusedColumnChanged)

			coll = New List(Of ContactItem)()
			Dim f1 As New ContactItem()
			f1.Name = "Abcd"
			f1.Salary = 13.40D
			f1.MyDate = DateTime.Now
			coll.Add(f1)
			Dim f2 As New ContactItem()
			f2.Name = "bla1"
			f2.MyDate = DateTime.Now
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

			gridControl1.DataSource = coll



		End Sub

	End Class


End Namespace
