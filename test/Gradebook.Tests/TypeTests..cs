using System;

using Xunit;


namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;
            
            // long version
            // log = new WriteLogDelegate(ReturnMessage);

            // short hand version
            log = ReturnMessage;

            var result = log("Hello!");
            Assert.Equal("Hello!", result);

        }
        private string ReturnMessage(string message)
        {
            return message;
        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            
            Assert.Equal(42, x);
        }

        private void SetInt(ref Int32 z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }


        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Tommy";
            var upper = MakeUpperCase(name);

            Assert.Equal("Tommy", name);
            Assert.Equal("TOMMY", upper);
        }

        private string MakeUpperCase(string parameter)
        {
           return parameter.ToUpper();
        }

        [Fact]
        public void CSharpCanPassByReference()
        {
            // arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);


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
            Assert.Equal("Book 1", book1.Name);


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
            Assert.Equal("New Name", book1.Name);


        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
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
