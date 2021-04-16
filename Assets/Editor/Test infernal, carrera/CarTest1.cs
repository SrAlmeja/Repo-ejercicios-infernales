using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class CarTest1
{
    [Test]
    public void VochoVSAveo()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        int indexvocho = 0;
        int indexaveo = 1;
        var expectedVictory = 1;

        // Act - La función o proceso a probar

        vocho.theRice(indexvocho, indexaveo);

        // Assert - Afirmación
        Assert.That(vocho.winner, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSCapuchino()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 130;
        var expectedVictory = "yes";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSChariot()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 180;

        var expectedVictory = "no";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSSpectre()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 186;

        var expectedVictory = "no";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSSolaris()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 190;

        var expectedVictory = "no";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSViper()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 306;

        var expectedVictory = "no";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSAvalón()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 127;

        var expectedVictory = "yes";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSFuegoTurbo()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 130;

        var expectedVictory = "yes";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

    [Test]
    public void VochoVSAudiTTRSRoadster()
    {
        //Arrange - Arreglos o preparativos
        Lakitu vocho = new Lakitu();
        var speedCar1 = 140;
        var speedCar2 = 130;

        var expectedVictory = "yes";


        // Act - La función o proceso a probar
        vocho.theRice(speedCar1, speedCar2);

        // Assert - Afirmación
        Assert.That(vocho, Is.EqualTo(expectedVictory));
    }

}
