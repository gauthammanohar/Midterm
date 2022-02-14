using NUnit.Framework;

namespace Midterm.Test
{
    public class PixelCalcTest
    {
        [Test]
        public void CalculatePPITest_1_1_1_1dot41()
        {
            //Arrange test
            double result;
            double expected = 1.41;
            int screenWidth = 1;
            int screenHeight = 1;
            int diagonalInPixels = 1;

            //Act test
            result = PixelCalc.CalculatePPI(screenWidth, screenHeight, diagonalInPixels);

            //Assert test
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatePPITest_1800_2880_15_226dot42()
        {
            //Arrange test
            double result;
            double expected = 226.42;
            int screenWidth = 1800;
            int screenHeight = 2880;
            int diagonalInPixels = 15;

            //Act test
            result = PixelCalc.CalculatePPI(screenWidth, screenHeight, diagonalInPixels);

            //Assert test
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateDiagonalInPixelsTest_1_1_1_1dot41()
        {
            //Arrange test
            double result;
            double expected = 1.41;
            int screenWidth = 1;
            int screenHeight = 1;


            //Act test
            result = PixelCalc.CalculateDiagonalInPixels(screenWidth, screenHeight);

            //Assert test
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateDiagonalInPixelsTest_1800_2880_3396dot23()
        {
            //Arrange test
            double result;
            double expected = 3396.23;
            int screenWidth = 1800;
            int screenHeight = 2880;


            //Act test
            result = PixelCalc.CalculateDiagonalInPixels(screenWidth, screenHeight);

            //Assert test
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateDotPitch_1_1_1_17dot9605()
        {
            //Arrange test
            double result;
            double expected = 17.9605;
            int screenWidth = 1;
            int screenHeight = 1;
            int diagonalInPixels = 1;

            //Act test
            result = PixelCalc.CalculateDotPitch(screenWidth, screenHeight, diagonalInPixels);

            //Assert test
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateDotPitch_1800_2880_15_0dot1122()
        {
            //Arrange test
            double result;
            double expected = 0.1122;
            int screenWidth = 1800;
            int screenHeight = 2880;
            int diagonalInPixels = 15;

            //Act test
            result = PixelCalc.CalculateDotPitch(screenWidth, screenHeight, diagonalInPixels);

            //Assert test
            Assert.AreEqual(expected, result);
        }

    }
}
