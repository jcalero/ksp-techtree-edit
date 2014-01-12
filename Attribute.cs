using System;

namespace AVTTLoaderStandalone
{
    public class Attribute
    {
        public Attribute()
        {
        }

        public Attribute(string value)
        {
            Item = value.Trim().Remove(value.LastIndexOf(char.Parse("=")) - 1).Trim();
            Value = value.Trim().Remove(0, value.LastIndexOf(char.Parse("=")) + 1).Trim();
        }
        protected bool Equals(Attribute other)
        {
            return string.Equals(Item, other.Item) && Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Attribute)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Item != null ? Item.GetHashCode() : 0) * 397) ^ (Value != null ? Value.GetHashCode() : 0);
            }
        }

        public string Item { get; set; }
        public object Value { get; set; }
        public static implicit operator string(Attribute value)
        {
            return value.Value.ToString();
        }
        //public static explicit operator Attribute(string value)
        //{
        //    var s = new Attribute
        //                {
        //                    Item = value.Trim().Remove(value.LastIndexOf(char.Parse("=")) - 1).Trim(),
        //                    Value = value.Trim().Remove(0, value.LastIndexOf(char.Parse("=")) + 1).Trim()
        //                };
        //    return s;
        //}
        public static String operator +(string param1, Attribute param2)
        {
            return param1 + Convert.ToString(param2.ToString());
        }
        public static String operator +(Attribute param1, string param2)
        {
            return Convert.ToString(param1) + param2;
        }
        public static Boolean operator ==(Attribute param1, Attribute param2)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(param1, param2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            // ReSharper disable RedundantCast.0
            if (((object)param1 == null) || ((object)param2 == null))
            // ReSharper restore RedundantCast.0
            {
                return false;
            }
            return (param1.Item == param2.Item) & (param1.Value == param2.Value);
        }

        public static Boolean operator !=(Attribute param1, Attribute param2)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(param1, param2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            // ReSharper disable RedundantCast.0
            if (((object)param1 == null) || ((object)param2 == null))
            // ReSharper restore RedundantCast.0
            {
                return false;
            }
            return !((param1.Item == param2.Item) & (param1.Value == param2.Value));
        }
    }
}
