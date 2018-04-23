# How to change the GridColumn cell background for the focused column


<p>This sample illustrates how to change the focused column appearance. Create the attached property for the GridColumn that determines whether the row is focused or not. Iterate via columns in the FocusedColumnChanged event, to keep this attached property up-to-date for every column. In the CellStyle event, change the Background property only for columns for which the custom attached property is True.</p><p>Starting with version 2013 vol 1 the GridControl.FocusedColumnChanged event is marked as obsolete. The GridControl.CurrentColumnChanged event should be used instead.</p>

<br/>


