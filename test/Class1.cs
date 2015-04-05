using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestMethod1()
        {
            double BMI, Value = 0;
            BMI = float.Parse(txtWeight.Text) / ((float.Parse(txtHeight.Text) / 100) * (float.Parse(txtHeight.Text) / 100));
            Value = Math.Round(BMI, 3);
            Debug.WriteLine(Value);
        }
    }
}
