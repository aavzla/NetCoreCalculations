using System;
using System.IO;

namespace NetCoreCalculations.Tests.Fixtures
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator { get; set; }

        //We use this memory stream as an example on how use the IDisposable in order to manage create/instance and cleanup/close resources.
        private readonly MemoryStream _memoryStream;

        public CalculatorFixture()
        {
            Calculator = new Calculator();
            //We instance the memory stream. And it should be used in any method in this class.
            _memoryStream = new MemoryStream();
        }

        public void Dispose()
        {
            //Do cleaning.
            _memoryStream.Close();
        }
    }
}
