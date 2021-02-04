using System;
using System.Collections.Generic;
using CanvasModel;
using CanvasModel.Colors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanvasTests
{
    [TestClass]
    public class TypeFinderGetNames
    {
        [TestMethod]
        public void GetNames_PassIColor_ReturnCorrectType()
        {
            //Arrange
            ColorsInstanceList colorsInstanceList = new ColorsInstanceList();
            List<string> expected;

            //Act
            colorsInstanceList.Instances = TypeFinder.CreateInstances<IColor>();

            expected = TypeFinder.GetNames<IColor>(colorsInstanceList.Instances);
            //Assert
            Assert.AreEqual(typeof(List<string>), expected.GetType());
        }

        [TestMethod]
        public void GetNames_PassIColor_ReturnCorrectListElement()
        {
            //Arrange
            ColorsInstanceList colorsInstanceList = new ColorsInstanceList();
            List<string> expected;

            //Act
            colorsInstanceList.Instances = TypeFinder.CreateInstances<IColor>();
            expected = TypeFinder.GetNames<IColor>(colorsInstanceList.Instances);

            //Assert
            Assert.IsTrue(expected.Contains("Red") == true);
            Assert.IsTrue(expected.Contains("Square") == false);
        }
    }
}
