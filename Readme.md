<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/WpfApplication1/Customer.cs) (VB: [Customer.vb](./VB/WpfApplication1/Customer.vb))
* [Window1.xaml](./CS/WpfApplication1/Window1.xaml) (VB: [Window1.xaml](./VB/WpfApplication1/Window1.xaml))
* [Window1.xaml.cs](./CS/WpfApplication1/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication1/Window1.xaml.vb))
<!-- default file list end -->
# How to change the GridColumn cell background for the focused column


<p>This sample illustrates how to change the focused column appearance. Create the attached property for the GridColumn that determines whether the row is focused or not. Iterate via columns in the FocusedColumnChanged event, to keep this attached property up-to-date for every column. In the CellStyle event, change the Background property only for columns for which the custom attached property is True.</p><p>Starting with version 2013 vol 1 the GridControl.FocusedColumnChanged event is marked as obsolete. The GridControl.CurrentColumnChanged event should be used instead.</p>

<br/>


