
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Jarat_Kezelo.Teszt
{


    // NUnit letöltése men sikertült!
    [TestFixture]
    public class JaratTeszt
    {
        Jarat_Kezelo j;
        [SetUp]
        public void Setup()
        {
            j = new Jarat_Kezelo();
        }
        [Test]
        public void UjJaratTestLetrehoz()
        {

            j.UjJarat("vaj", "c", "c", DateTime.Now);
            Assert.IsNotEmpty(j.jaratok);
        }

    }
}