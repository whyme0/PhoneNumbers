using System;

namespace PhoneNumbers
{
    /// <summary>
    /// Represent basic phone number properties.
    /// </summary>
    public interface IPhoneNumber
    {
        /// <summary>
        /// Phone number represented in <c>int</c> type format
        /// </summary>
        public int PN { get; init; }
        
        /// <returns>Return human readable phone number from <c>PN</c> field</returns>
        public string ToString();
    }
}
