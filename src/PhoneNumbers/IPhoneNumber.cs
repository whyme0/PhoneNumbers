using System;

namespace PhoneNumbers
{
    public interface IPhoneNumber
    {
        public int PN { get; init; }

        public string ToString();
    }
}
