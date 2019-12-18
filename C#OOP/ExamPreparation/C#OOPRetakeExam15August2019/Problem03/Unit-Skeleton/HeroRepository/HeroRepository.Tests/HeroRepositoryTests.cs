using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    private HeroRepository heroRepository;

    [Test]
    public void CreateShouldThrowExceptionIfHeroIsNull()
    {
        heroRepository = new HeroRepository();
        Hero hero = null;

        if (hero == null)
        {
            Assert.That(() => heroRepository.Create(hero), Throws.ArgumentNullException);
        }
    }

    [Test]
    public void CreateShouldThrowIfCreateBothAreTheSameNames()
    {
        heroRepository = new HeroRepository();

        Hero hero = new Hero("Gosho", 11);
        Hero hero2 = new Hero("Gosho", 11);

        heroRepository.Create(hero);

        Assert.That(() => heroRepository.Create(hero2), Throws.InvalidOperationException);
    }

    [Test]
    public void CreateCountTest()
    {
        heroRepository = new HeroRepository();

        Hero hero = new Hero("Gosho", 11);
        Hero hero2 = new Hero("Pesho", 11);

        heroRepository.Create(hero);
        heroRepository.Create(hero2);

        Assert.AreEqual(2, heroRepository.Heroes.Count);
    }

    [TestCase(" ")]
    [TestCase(null)]
    public void RemoveTests(string name)
    {
        heroRepository = new HeroRepository();

        Hero hero = new Hero("Gosho", 11);
        Hero hero2 = new Hero("Pesho", 11);

        heroRepository.Create(hero);
        heroRepository.Create(hero2);

        if (string.IsNullOrWhiteSpace(name))
        {
            Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(name));
        }

        Assert.AreEqual(false, heroRepository.Remove("Kiro"));
        Assert.AreEqual(true, heroRepository.Remove("Gosho"));

    }

    [Test]
    public void GetHeroWithHighestLevelTest()
    {
        heroRepository = new HeroRepository();

        Hero hero = new Hero("Gosho", 11);
        Hero hero2 = new Hero("Pesho", 12);

        heroRepository.Create(hero);
        heroRepository.Create(hero2);

        Hero HLH = heroRepository.GetHeroWithHighestLevel();

        Assert.AreEqual("Pesho", HLH.Name);
    }

    [Test]
    public void GetHeroTest()
    {
        heroRepository = new HeroRepository();

        Hero hero = new Hero("Gosho", 11);
        Hero hero2 = new Hero("Pesho", 12);

        heroRepository.Create(hero);
        heroRepository.Create(hero2);

        Hero HLH = heroRepository.GetHero("Gosho");

        Assert.AreEqual("Gosho", HLH.Name);
    }
}