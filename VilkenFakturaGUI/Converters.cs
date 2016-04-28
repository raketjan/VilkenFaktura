﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace VilkenFakturaGUI
{
    
        public class WidthCalculationMultiConverter : IMultiValueConverter
        {
            public object Convert(object[] values, Type targetType,
                                  object parameter, CultureInfo culture)
            {
                // do some sort of calculation
                double totalWindowWidth;
                double otherColumnsTotalWidth = 0;
                double.TryParse(values[0].ToString(), out totalWindowWidth);
                var arrayOfColumns = values[1] as IList<GridViewColumn>;

                for (int i = 0; i < arrayOfColumns.Count - 1; i++)
                {
                    otherColumnsTotalWidth += arrayOfColumns[i].Width;
                }

                return (totalWindowWidth - otherColumnsTotalWidth) < 0 ?
                             0 : (totalWindowWidth - otherColumnsTotalWidth);
            }

            public object[] ConvertBack(object value, Type[] targetTypes,
                                        object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
   
}
