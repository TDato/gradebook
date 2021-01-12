using System;

using Xunit;


namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CSharpCanPassByReference()
        {
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.GetName());


        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book 1", book1.GetName());


        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.GetName());


        }

        private void SetName(Book book, string name)
        {
            book.SetName(name);
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Assert.Equal("Book 1", book1.GetName());
            Assert.Equal("Book 2", book2.GetName());
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            // assert
            Assert.Same(book1, book2);
            
        }

       Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
