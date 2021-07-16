using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {

            Books = books.ToList();
        }
        public List<Book> Books { get; private set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();

        public class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex = -1;

            private readonly List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = new List<Book>(books);
            }
            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;

            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }

    }
}
