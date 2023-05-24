using ApplicationServices.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Models;

namespace ApplicationServices.Tests.Mapping.Validators
{
    internal static class InnerEntityDbValidator
    {
        public static void AssertAreEqual(InnerEntityDb expected, InnerEntityDto actual)
        {
            if (expected == null || actual == null)
            {
                Assert.IsNull(expected);
                Assert.IsNull(actual);

                return;
            }

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
            InnerEntityTypeValidator.AssertAreEqual(expected.InnerEntityType, actual.InnerEntityType);
        }
    }
}
