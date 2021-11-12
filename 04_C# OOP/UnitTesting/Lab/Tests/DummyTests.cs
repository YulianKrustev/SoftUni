using NUnit.Framework;
using System;

[TestFixture]


public class DummyTests
{
    private Dummy dummy;

    [SetUp]
    public void TestInit()
    {
        dummy = new Dummy(0, 10);
    }

    [Test]
    public void DummyLosesHealthAfterAttack()
    {
        // Arrange
        Dummy dummy = new Dummy(20, 10);

        // Act
        dummy.TakeAttack(5);

        // Assert
        Assert.IsTrue(dummy.Health == 15);
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        // Assert
        Assert.That(() => dummy.TakeAttack(10), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        Assert.That(() => dummy.GiveExperience() == 10);
    }

    [Test]
    public void AliveDummyCantGiveXP()
    {
        Dummy dummy = new Dummy(1, 10);

        Assert.That(() => dummy.GiveExperience() == 0, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}

