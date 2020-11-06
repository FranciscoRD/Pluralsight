using System;
using Xunit;
// using GradeBook;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointMethod()
        {
            // WriteLogDelegate log;
            // log = new WriteLogDelegate(ReturnMessage);
            // log = ReturnMessage;

            WriteLogDelegate log = ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            // Assert.Equal("Hello!", result);
            Assert.Equal(2, count);
        }

        public string ReturnMessage(string message)
        {
            // return message;

            count++;
            return message.ToLower();
        }

        public string IncrementCount(string message)
        {
            count++;
            return message;
        }
        

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            int x = GetInt();
            Assert.Equal(3, x);
            
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            // Falla
            // Assert.Equal("New Name", book1.Name);
            // Pasa
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            InMemoryBook book1 = new InMemoryBook("Book 1");
            SetName(book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            // Assert.Equal(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            InMemoryBook book1 = GetBook("Book 1");
            InMemoryBook book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
            // Assert.Equal(book1, book2);
        }

        public InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }        
    }
}
