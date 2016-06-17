using System;

namespace SimpleService
{
    public class SimpleService : ISimpleService
    {
        public int MultiplyByTen(string number)
        {
            var convertedNumber = Int32.Parse(number);
            return 10 * convertedNumber;
        }
    }
}
