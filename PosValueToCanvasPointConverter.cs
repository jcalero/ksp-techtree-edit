using System;
using System.Globalization;
using System.Windows.Data;

namespace ksp_techtree_edit
{
	internal class PosXToCanvasPointConverter : IValueConverter
	{
		public object Convert(
			object value,
			Type targetType,
			object parameter,
			CultureInfo culture)
		{
			return ((double) value + 3000) * 0.85;
		}

		public object ConvertBack(
			object value,
			Type targetType,
			object parameter,
			CultureInfo culture)
		{
			return Math.Round(((double) value / 0.85) - 3000, 2);
		}
	}

	internal class PosYToCanvasPointConverter : IValueConverter
	{
		public object Convert(
			object value,
			Type targetType,
			object parameter,
			CultureInfo culture)
		{
			return ((double) value * 0.7);
		}

		public object ConvertBack(
			object value,
			Type targetType,
			object parameter,
			CultureInfo culture)
		{
			return Math.Round((double) value / 0.7, 2);
		}
	}
}
