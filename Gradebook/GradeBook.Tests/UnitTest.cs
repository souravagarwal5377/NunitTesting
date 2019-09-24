using Gradebook;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Tests
{
    [TestFixture]
    class UnitTest
    {
        [Test]
        public void ReturnsMinGrade()
        {
            var sut = new Book("Sourav");
            sut.AddGrade(68.8);
            sut.AddGrade(88.8);
            sut.AddGrade(78.8);

            Assert.That(sut.MinGrade(), Is.EqualTo(68.8));
        }
        [Test]
        public void ReturnsMaxGrade()
        {
            var sut = new Book("Sourav");
            sut.AddGrade(68.8);
            sut.AddGrade(98.8);
            sut.AddGrade(78.8);

            Assert.That(sut.MaxGrade(), Is.EqualTo(98.8));
        }
    }
}
