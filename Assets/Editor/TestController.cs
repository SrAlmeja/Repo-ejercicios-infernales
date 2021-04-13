using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TestController
{
    [Test]
    public void rectangleTest()
    {
        //Arrange - Arreglos o preparativos
        Circle circle = new Circle();
        circle.Radius = 10f;
        var areaExpected = 314.16f;

        // Act - La función o proceso a probar
       
        circle.GetArea();

        // Assert - Afirmación
        Assert.That(circle, Is.EqualTo(areaExpected));

    }

    [Test]
    public void rectangleTest1()
    {
        //Arrange - Arreglos o preparativos
        Circle circle = new Circle();
        circle.Radius = 15f;
        var areaExpected = 706.86f;

        // Act - La función o proceso a probar

        circle.GetArea();

        // Assert - Afirmación
        Assert.That(circle, Is.EqualTo(areaExpected));

    }
}
