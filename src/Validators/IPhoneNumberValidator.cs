namespace PhoneNumbers.Validators
{
    /// <summary>
    /// Validate phone numbers which implement <c>IPhoneNumber</c> interface.
    /// </summary>
    interface IPhoneNumberValidator
    {
        /// <summary>
        /// Validate passed phone number in string, int or any other type which implement IPhoneNumber interface.
        /// </summary>
        /// <param name="phoneNumber">Can retrieve string, int and any other type which implement IPhoneNumber interface</param>
        /// <returns>If format is correct returns <c>true</c>, otherwise <c>false</c>.</returns>
        bool ValidatePhoneNumber(object phoneNumber);
    }
}
