using System;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApplication1 {
    public class ComparisonConverter : MarkupExtension, IMultiValueConverter {
        public ComparisonConverter() { }

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return ReferenceEquals(values[0], values[1]);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
