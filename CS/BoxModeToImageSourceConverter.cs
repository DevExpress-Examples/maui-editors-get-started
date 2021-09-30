using DevExpress.Maui.Editors;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorsGetStarted {
    public class BoxModeToImageSourceConverter : IValueConverter, IMarkupExtension<BoxModeToImageSourceConverter> {
        public ImageSource Filled { get; set; }
        public ImageSource Outlined { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (!(value is BoxMode boxMode) || targetType != typeof(ImageSource)) return null;
            switch (boxMode) {
                case BoxMode.Filled:
                    return Filled;
                case BoxMode.Outlined:
                    return Outlined;
                default:
                    throw new NotSupportedException();
            }

        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }

        public BoxModeToImageSourceConverter ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }

}
