// Developer Express Code Central Example:
// How to change the GridColumn cell background for the focused column
// 
// This sample illustrates how to change the focused column appearance. Create the
// attached property for the GridColumn that determines whether the row is focused
// or not. Iterate via columns in the FocusedColumnChanged event, to keep this
// attached property up-to-date for every column. In the CellStyle event, change
// the Background property only for columns for which the custom attached property
// is True.
// Starting with version 2013 vol 1 the GridControl.FocusedColumnChanged
// event is marked as obsolete. The GridControl.CurrentColumnChanged event should
// be used instead.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2455

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Windows;
using System.ComponentModel;

namespace WpfApplication1 {
    public class ContactItem {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime MyDate { get; set; }
    }

}
