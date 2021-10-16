using NUnit.Framework;
using System;

namespace Bank.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void TestInit()
        {
            this.account = new BankAccount(2000M);
        }

        [Test]
        public void AcountInitializeWithPositiveValue()
        {
            Assert.AreEqual(2000M, account.Amount);
        }
    }
}
