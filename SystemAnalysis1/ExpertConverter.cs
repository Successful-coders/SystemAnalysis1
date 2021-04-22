using System;
using System.ComponentModel;
using System.Globalization;
using Newtonsoft.Json;

namespace SystemAnalysis1
{
    [TypeConverter(typeof(ExpertConverter))]
    public class ExpertConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string stringValue = value as string;
                return new Expert(stringValue.Substring(0, stringValue.IndexOf(';')), double.Parse(stringValue.Substring(stringValue.IndexOf(';') + 1)));
            }
            return base.ConvertFrom(context, culture, value);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return value.ToString();
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}