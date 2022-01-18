namespace PhoneNumbers.Handlers
{
    /// <summary>
    /// Extract information from object which implement IPhoneNumber interface.
    /// </summary>
    interface IPhoneNumberHandler
    {
        /// <summary>
        /// Return country name based on phone number
        /// </summary>
        public string GetCountry(IPhoneNumber phoneNumber);
        /// <summary>
        /// Return country code based on phone number
        /// </summary>
        public int GetCountryCode(IPhoneNumber phoneNumber);
    }
}
