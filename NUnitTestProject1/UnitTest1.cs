using NUnit.Framework;
using Lab6.entity;
using System.Reflection;
using static Lab6.entity.Mobile;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Mobile mobile = new Mobile("Nokia", new MobileInfo("3310", new List<string>() { "Can't kill", "Almost eternal"}));
            Assert.AreEqual("Mobile: manufacturer - Nokia, Mobile Info: model - 3310, properties - Can't kill, Almost eternal, ", mobile.ToString());
        }
    }
}