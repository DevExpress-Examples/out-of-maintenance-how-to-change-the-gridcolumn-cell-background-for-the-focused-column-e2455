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
using DevExpress.Wpf.Grid;
using System.Windows.Threading;
using DevExpress.Wpf.Editors.Settings;
using System.Threading;
using DevExpress.Data;
using System.Windows.Markup;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window {
       List<ContactItem> coll;


        public static bool GetIsColumnFocused(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsColumnFocusedProperty);
        }

        public static void SetIsColumnFocused(DependencyObject obj, bool value)
        {
            obj.SetValue(IsColumnFocusedProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsColFocused.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsColumnFocusedProperty =
            DependencyProperty.RegisterAttached("IsColumnFocused", typeof(bool), typeof(MainWindow), new UIPropertyMetadata(false));




        private void View_FocusedColumnChanged(object sender, EventArgs e)
        {
            TableView view = sender as TableView;
            foreach (GridColumn gc in gridControl1.Columns)
            {
                if (gc == view.FocusedColumn)
                {
                    SetIsColumnFocused(gc, true);
                }
                else
                {
                    SetIsColumnFocused(gc, false);
                }
            }
        }

        public MainWindow() {
            InitializeComponent();
            DependencyPropertyDescriptor focusedColumnPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(GridViewBase.FocusedColumnProperty, typeof(GridViewBase));
            focusedColumnPropertyDescriptor.AddValueChanged(gridControl1.View, View_FocusedColumnChanged);

            coll = new List<ContactItem>();
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

            gridControl1.DataSource = coll;



        }

    }


}
