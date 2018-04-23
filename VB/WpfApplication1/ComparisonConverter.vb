Imports System
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace WpfApplication1
    Public Class ComparisonConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Public Sub New()
        End Sub

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            Return ReferenceEquals(values(0), values(1))
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
