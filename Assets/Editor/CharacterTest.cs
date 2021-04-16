using NUnit.Framework;

public class CharacterTest
{
    [Test]
    public void hearthOfAWizardA()
    {
        //Arrange - Arreglos o preparativos
        Enemy theMagician = new Enemy();
        var level = 17;


        // Act - La función o proceso a probar
        theMagician.createMagicEnemy(level);

        // Assert - Afirmación
        Assert.That(theMagician.LifePoints, Is.LessThan(21));
    }

    [Test]
    public void hearthOfAWizardB()
    {
        //Arrange - Arreglos o preparativos
        Enemy theMagician = new Enemy();
        var level = 17;


        // Act - La función o proceso a probar
        theMagician.createMagicEnemy(level);

        // Assert - Afirmación
        Assert.That(theMagician.LifePoints, Is.GreaterThan(16));
    }

    [Test]
    public void WizardGreatPowers()
    {
        //Arrange - Arreglos o preparativos
        Enemy theMagician = new Enemy();
        var level = 17;


        // Act - La función o proceso a probar
        theMagician.createMagicEnemy(level);

        // Assert - Afirmación
        Assert.That(theMagician.MagicPoints, Is.GreaterThan(33));
    }

    [Test]
    public void WizardMehPowers()
    {
        //Arrange - Arreglos o preparativos
        Enemy theMagician = new Enemy();
        var level = 17;


        // Act - La función o proceso a probar
        theMagician.createMagicEnemy(level);

        // Assert - Afirmación
        Assert.That(theMagician.MagicPoints, Is.LessThan(60));
    }


    [Test]
    public void FitWizard()
    {
        //Arrange - Arreglos o preparativos
        Enemy theMagician = new Enemy();
        var level = 17;


        // Act - La función o proceso a probar
        theMagician.createMagicEnemy(level);

        // Assert - Afirmación
        Assert.That(theMagician.Stamina, Is.GreaterThan(3));
    }

    [Test]
    public void FatWizard()
    {
        //Arrange - Arreglos o preparativos
        Enemy theMagician = new Enemy();
        var level = 17;


        // Act - La función o proceso a probar
        theMagician.createMagicEnemy(level);

        // Assert - Afirmación
        Assert.That(theMagician.Stamina, Is.LessThan(21));
    }

    [Test]
    public void MagicFlash()
    {
        //arrange
        Enemy theMagician = new Enemy();
        var level = 17;

        //act
        theMagician.createMagicEnemy(level);

        //Assert
        Assert.That(theMagician.Speed, Is.GreaterThan(-18));
    }

    [Test]
    public void MagicReverseFlash()
    {
        //arrange
        Enemy theMagician = new Enemy();
        var level = 17;

        //act
        theMagician.createMagicEnemy(level);

        //Assert
        Assert.That(theMagician.Speed, Is.LessThan(18));
    }

    [Test]
    public void EpicMagicShild()
    {
        //Arrange
        Enemy TheMagician = new Enemy();
        var level = 17;

        //act
        TheMagician.createMagicEnemy(level);

        //Assert
        Assert.That(TheMagician.Defense, Is.LessThan(18));
    }

    [Test]
    public void IronMagicShild()
    {
        //Arrange
        Enemy TheMagician = new Enemy();
        var level = 17;

        //act
        TheMagician.createMagicEnemy(level);

        //Assert
        Assert.That(TheMagician.Defense, Is.GreaterThan(-6));
    }

    [Test]
    public void EpicMagicSword()
    {
        //Arrange
        Enemy TheMagician = new Enemy();
        var level = 17;

        //act
        TheMagician.createMagicEnemy(level);

        //Assert
        Assert.That(TheMagician.Attack, Is.LessThan(18));
    }

    [Test]
    public void IronMagicSword()
    {
        //Arrange
        Enemy TheMagician = new Enemy();
        var level = 17;

        //act
        TheMagician.createMagicEnemy(level);

        //Assert
        Assert.That(TheMagician.Attack, Is.GreaterThan(-18));
    }

    [Test]
    public void GoodLuck()
    {
        //Arrange
        Enemy TheMagician = new Enemy();
        var level = 17;

        //act
        TheMagician.createMagicEnemy(level);

        //Assert
        Assert.That(TheMagician.Lucky, Is.LessThan(18));
    }

    [Test]
    public void BadLuck()
    {
        //Arrange
        Enemy TheMagician = new Enemy();
        var level = 17;

        //act
        TheMagician.createMagicEnemy(level);

        //Assert
        Assert.That(TheMagician.Lucky, Is.GreaterThan(-6));
    }
}
