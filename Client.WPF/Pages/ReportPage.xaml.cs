﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UASD;

namespace Client.WPF.Pages
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : UserControl
    {
        public IEnumerable<AcademicPeriod> Periodos {
            get => (IEnumerable<AcademicPeriod>)GetValue(PeriodosProperty);
            set => SetValue(PeriodosProperty, value);
        }
        public static readonly DependencyProperty PeriodosProperty = DependencyProperty.Register(
            "Periodos", typeof(IEnumerable<AcademicPeriod>), typeof(ReportPage), new PropertyMetadata());

        public ReportPage()
        {
            InitializeComponent();
        }
    }

    public class CourseCollectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var collection = (UASD.CourseCollection)value;
            var enumerable = (IEnumerable<UASD.Course>)collection;
            var source = enumerable.Cast<UASD.CourseGrade>();
            return source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
