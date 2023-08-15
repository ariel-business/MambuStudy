using System.Security.Cryptography;

namespace MambuStudy.Application.Unit.Tests
{
    public class ClientServiceXUnitTests
    {
        [Theory]
        [InlineData(CipherMode.CBC)]
        [InlineData(CipherMode.ECB)]
        public void Test1(CipherMode mode)
        {

        }
    }
}