using ApplicationServices.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Models;

namespace ApplicationServices.Tests.Mapping.Validators
{
    internal static class EntityDbValidator
    {
        public static void AssertAreEqual(EntityDb expected, EntityDto actual)
        {
            if (expected == null || actual == null)
            {
                Assert.IsNull(expected);
                Assert.IsNull(actual);

                return;
            }

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
            InnerEntityDbValidator.AssertAreEqual(expected.InnerEntity, actual.InnerEntity);
        }
    }
}
