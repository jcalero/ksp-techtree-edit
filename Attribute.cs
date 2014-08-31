using System;

namespace KSPTechTreeEditor
{
    /// <summary>
    /// An attribute class representing a name-value pair of attributes in a tree node
    /// </summary>
    public class Attribute
    {
        public string Item { get; set; }
        public object Value { get; set; }

        /// <summary>
        /// Instantiates an empty attribute
        /// </summary>
        public Attribute() {}

        /// <summary>
        /// Instantiates an attribute with the item name and value
        /// </summary>
        /// <param name="item">Attribute name</param>
        /// <param name="value">Attribute value</param>
        public Attribute(string item, string value)
        {
            Item = item.Trim();
            Value = value.Trim();
        }

        /// <summary>
        /// Instantiates an attribute with the item name and value
        /// given by the string with the format "name = value".
        /// Useful for directly creating attributes from file parsing.
        /// </summary>
        /// <param name="line">The "name = value" string to parse into attribute name and value</param>
        public Attribute(string line)
        {
            Item = line.Trim().Remove(line.LastIndexOf(char.Parse("=")) - 1).Trim();
            Value = line.Trim().Remove(0, line.LastIndexOf(char.Parse("=")) + 1).Trim();
        }

        /// <summary>
        /// Checks for equality between attributes
        /// </summary>
        /// <param name="other">The other attribute to compare with</param>
        /// <returns>True if both attribues have the same name and value pair. False otherwise.</returns>
        protected bool Equals(Attribute other)
        {
            return string.Equals(Item, other.Item) && Equals(Value, other.Value);
        }

        /// <summary>
        /// Default object equality method for object type comparison.
        /// </summary>
        /// <param name="obj">The uncast object to compare with</param>
        /// <returns>True if the object is an Attribute and has the same name and value pair as this attribute.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Attribute) obj);
        }

        /// <summary>
        /// Returns the hashcode of this attribute
        /// </summary>
        /// <returns>Returns the hashcode of this attribute</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Item != null ? Item.GetHashCode() : 0) * 397) ^ (Value != null ? Value.GetHashCode() : 0);
            }
        }

        /// <summary>
        /// To string overloaded operator
        /// </summary>
        /// <param name="a">The attribute to convert</param>
        /// <returns>Returns the value of the attribute</returns>
        public static implicit operator string(Attribute a)
        {
            return a.Value.ToString();
        }

        /// <summary>
        /// Overloaded equality operator between two attributes
        /// </summary>
        /// <param name="param1">The first attribute</param>
        /// <param name="param2">The second attribute</param>
        /// <returns>True if both attributes have the same name and value pair.</returns>
        public static Boolean operator ==(Attribute param1, Attribute param2)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(param1, param2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            // ReSharper disable RedundantCast.0
            if (((object) param1 == null) || ((object) param2 == null))
                // ReSharper restore RedundantCast.0
            {
                return false;
            }
            return (param1.Item == param2.Item) & (param1.Value == param2.Value);
        }

        /// <summary>
        /// Overloaded inequality operator between two attributes
        /// </summary>
        /// <param name="param1">The first attribute</param>
        /// <param name="param2">The second attribute</param>
        /// <returns>False if both attributes have the same name and value pair.</returns>
        public static Boolean operator !=(Attribute param1, Attribute param2)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(param1, param2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            // ReSharper disable RedundantCast.0
            if (((object) param1 == null) || ((object) param2 == null))
                // ReSharper restore RedundantCast.0
            {
                return false;
            }
            return !((param1.Item == param2.Item) & (param1.Value == param2.Value));
        }
    }
}
