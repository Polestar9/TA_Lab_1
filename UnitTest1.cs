using System;
namespace Lab_1_Test
{
    [TestClass]
    public class figure_calculator
    {
        [TestMethod]
        public void volume_calculator()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int volume_result = Lab_1.lab_program.V(a, b, c);
            Assert.AreEqual(6, volume_result);
        }

        [TestMethod]
        public void area_calculator()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int area_result = Lab_1.lab_program.S(a, b, c);
            Assert.AreEqual(22, area_result);
        }
    }
}
