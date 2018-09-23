using System;
using System.Linq;

namespace Parking.Common
{
    public static class AlphaNumericCode
    {
        public static string GenerateRandomNumber(int ticketNumberLength)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var ticketNumber = new string(Enumerable.Repeat(chars, ticketNumberLength)
                                              .Select(s => s[random.Next(s.Length)]).ToArray());
            return ticketNumber;
        }
    }
}
