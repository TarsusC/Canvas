using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanvasModel;
using CanvasModel.Colors;
using CanvasModel.Figures;
using System.Collections.Generic;

namespace CanvasTests
{
    [TestClass]
    public class TypeFinderCreateInstance
    {
        [TestMethod]
        public void CreateInstance_PassIColorType_ListReturnSuccess()
        {
            //Arrange
            ColorsInstanceList colorsInstanceList = new ColorsInstanceList();
            List<IColor> expected;
            //Act
            colorsInstanceList.Instances = TypeFinder.CreateInstances<IColor>();
            expected = colorsInstanceList.Instances;
            //Assert
            Assert.AreEqual(typeof(List<IColor>), expected.GetType());
        }

        [TestMethod]
        public void CreateInstance_PassIFigureType_ListReturnSuccess()
        {
            //Arrange
            FigureInstanceList figureInstanceList = new FigureInstanceList();
            List<IFigure> expected;
            //Act
            figureInstanceList.Instances = TypeFinder.CreateInstances<IFigure>();
            expected = figureInstanceList.Instances;
            //Assert
            Assert.AreEqual(typeof(List<IFigure>), expected.GetType());
        }
    }
}
