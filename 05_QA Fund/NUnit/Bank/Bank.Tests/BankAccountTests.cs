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
        public void AcountInitializeWithNegativeValue()
        {
            TestDelegate invalidAccount = () => new BankAccount(-500);
            Assert.Throws<ArgumentException>(invalidAccount);
        }

        [Test]
        public void WithdrowWithAmountLessThan1000()
        {
            account.Withdraw(500);
            Assert.AreEqual(1475, account.Amount);
        }

        [Test]
        public void WithdrowWithAmountMoreThan1000()
        {
            account.Withdraw(1500);
            Assert.AreEqual(470, account.Amount);
        }

        [Test]
        public void WithdrowWithZeroAmount()
        {
            TestDelegate invalidWithdrow = () => account.Withdraw(0);
            Assert.Throws<ArgumentException>(invalidWithdrow);
        }

        [Test]
        public void WithdrowWithNegativeAmount()
        {
            TestDelegate invalidWithdrow = () => account.Withdraw(-500);
            Assert.Throws<ArgumentException>(invalidWithdrow);
        }

        [Test]
        public void WithdrowWith1000()
        {
            account.Withdraw(1000);
            Assert.AreEqual(980, account.Amount);
        }

        [Test]
        public void WithdrowWith0()
        {
            TestDelegate invalidWithdrow = () => account.Withdraw(0);
            Assert.Throws<ArgumentException>(invalidWithdrow);
        }

        [Test]
        public void WithdrowWithInvalidAmaount()
        {
            TestDelegate invalidWithdrow = () => account.Withdraw(3000);
            Assert.Throws<ArgumentException>(invalidWithdrow);
        }
    }
}
