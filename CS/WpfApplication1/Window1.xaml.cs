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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Xpf.Grid;
using System.Windows.Threading;
using DevExpress.Xpf.Editors.Settings;
using System.Threading;
using DevExpress.Data;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            LoadData();
        }

        void LoadData() {
            List<ContactItem> coll = new List<ContactItem>();
            ContactItem f1 = new ContactItem();
            f1.Name = "Abcd";
            f1.Salary = 13.40m;
            f1.MyDate = DateTime.Now;
            coll.Add(f1);
            ContactItem f2 = new ContactItem();
            f2.Name = "bla1";
            f2.MyDate = DateTime.Now;
            f2.Salary = 13;

            coll.Add(f2);

            ContactItem f3 = new ContactItem();
            f3.Name = "la";
            f3.Salary = 13;

            coll.Add(f3);

            ContactItem f4 = new ContactItem();
            f4.Name = " bla";
            f4.Salary = 13;

            coll.Add(f4);

            gridControl1.ItemsSource = coll;
        }
    }
}
