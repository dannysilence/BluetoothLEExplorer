using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace SortedObservableCollection
{
    public class BoolToNullableConverter : IValueConverter
    {

        #region IValueConverter Members

        // Define the Convert method to convert between bool and bool? object
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {
            if (targetType == typeof(bool))
            {
                // The value parameter is the data from the source object.
                var thisbool = (bool)value;
                return thisbool;
            }

            if (targetType == typeof(bool?))
            {
                // The value parameter is the data from the source object.
                var thisbool = (bool)value;
                return thisbool;
            }

            return false;
        }

        // ConvertBack is not implemented for a OneWay binding.
        public object ConvertBack(object value, Type targetType,
            object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class DeviceToObjectConverter : IValueConverter
    {

        #region IValueConverter Members

        // Define the Convert method to convert between bool and bool? object
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {
            return value;
        }

        // ConvertBack is not implemented for a OneWay binding.
        public object ConvertBack(object value, Type targetType,
            object parameter, string language)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
