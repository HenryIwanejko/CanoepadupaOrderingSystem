using NUnit.Framework;
using CanoepadupaOrderingSystem.Models;
using CanoepadupaOrderingSystem.Controllers;
using System.Collections.Generic;
using CanoepadupaOrderingSystem.Exceptions;
using System;

namespace CanoepadupaOrderingSystem.Tests
{
    public class DatabaseExceptionsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestExceptionReturnedCorrectErrorMessage()
        { 
            try
            {
                throw new DatabaseException("expected error message");
            } 
            catch (Exception ex)
            {
                Assert.That(ex is DatabaseException);
                DatabaseException dataEx = ex as DatabaseException;
                Assert.AreEqual(dataEx.Message, "Database Error: expected error message");
            }
        }
    }
}