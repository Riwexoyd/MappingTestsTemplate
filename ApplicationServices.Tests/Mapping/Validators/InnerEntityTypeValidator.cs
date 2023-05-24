using ApplicationServices.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Models;

namespace ApplicationServices.Tests.Mapping.Validators
{
    internal static class InnerEntityTypeValidator
    {
        public static void AssertAreEqual(InnerEntityType expected, InnerEntityDtoType actual)
        {
            switch (expected)
            {
                case InnerEntityType.Type1:
                    Assert.AreEqual(InnerEntityDtoType.Type1, actual);
                    break;
                case InnerEntityType.Type2:
                    Assert.AreEqual(InnerEntityDtoType.Type2, actual);
                    break;
                default: Assert.Fail();
                    break;
            }
        }
    }
}
