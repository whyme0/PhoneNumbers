using System;

namespace PhoneNumbers
{
    /// <summary>
    /// Represent basic phone number properties.
    /// </summary>
    public interface IPhoneNumber
    {
        /// <summary>
        /// Primary representation of <c>PhoneNumber</c>.
        /// </summary>
        public int PN { get; init; }
        
        /// <returns>Return human readable phone number from <c>PN</c> field.</returns>
        public string ToString();
    }
}
