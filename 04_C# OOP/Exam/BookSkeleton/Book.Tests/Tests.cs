namespace Book.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        private const string bookName = "Test";
        private const string author = "SoftUni";
        private Dictionary<int, string> footnote;
        private Book book;

        [SetUp]
        public void TestUnit()
        {
            footnote = new Dictionary<int, string>();
            book = new Book(bookName, author);
        }

        [Test]
        public void CreateBook()
        {
            Assert.AreEqual(book.BookName, bookName);
            Assert.AreEqual(book.Author, author);
            Assert.AreEqual(footnote.Count, 0);
        }

        [Test]
        public void EmptyForBookName()
        {
            string BookName = string.Empty;
            var ex = Assert.Throws<ArgumentException>(() => new Book(BookName, author));
            Assert.That(ex.Message, Is.EqualTo($"Invalid {nameof(BookName)}!"));
        }

        [Test]
        public void NullForBookName()
        {
            string BookName = null;
            var ex = Assert.Throws<ArgumentException>(() => new Book(BookName, author));
            Assert.That(ex.Message, Is.EqualTo($"Invalid {nameof(BookName)}!"));
        }

        [Test]
        public void NullForAuthor()
        {
            string Author = null;
            var ex = Assert.Throws<ArgumentException>(() => new Book(bookName, Author));
            Assert.That(ex.Message, Is.EqualTo($"Invalid {nameof(Author)}!"));
        }

        [Test]
        public void EmptyStringForAuthor()
        {
            string AuthorName = string.Empty;
            var ex = Assert.Throws<ArgumentException>(() => new Book(bookName, AuthorName));
            Assert.That(ex.Message, Is.EqualTo($"Invalid Author!"));
        }

        [Test]
        public void AddFootNote()
        {
            int footNotePage = 1;
            string note = "CheckThis";
            book.AddFootnote(footNotePage, note);
            Assert.AreEqual(book.FindFootnote(footNotePage), $"Footnote #{footNotePage}: {note}");
        }

        [Test]
        public void ThrowExForExistingFootnote()
        {
            int footNotePage = 1;
            string note = "CheckThis";
            book.AddFootnote(footNotePage, note);
            var ex = Assert.Throws<InvalidOperationException>(() => book.AddFootnote(footNotePage, note));
            Assert.That(ex.Message == "Footnote already exists!");
        }

        [Test]
        public void ThrowExForMissingFootnote()
        {
            int footNotePage = 1;
            var ex = Assert.Throws<InvalidOperationException>(() => book.FindFootnote(footNotePage));

            Assert.That(ex.Message == "Footnote doesn't exists!");
        }

        [Test]
        public void AlterFootnote()
        {
            int footNumber = 1;
            string text = "text";
            string newText = "new text";
            book.AddFootnote(footNumber, text);
            book.AlterFootnote(footNumber, newText);
            Assert.That(book.FindFootnote(footNumber) == $"Footnote #{footNumber}: {newText}");
        }

        [Test]
        public void AlterTextIntoMissingKey()
        {
            int missingKey = 4;
            string textToAlter = "Test";
            var ex = Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(missingKey, textToAlter));
            Assert.AreEqual(ex.Message, "Footnote does not exists!");
        }
    }
}