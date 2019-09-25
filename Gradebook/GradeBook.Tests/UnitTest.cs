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

        [Test]
        public void ReferenceTesting()
        {
            var sut1 = new Book("Sourav");
            var sut2 = new Book("Sourav");
            var sut3 = sut1;

            Assert.That(sut1, Is.Not.EqualTo(sut2));
            Assert.That(sut1, Is.SameAs(sut3));
        }

        [Test]
        public void ReturnsAvgGrade()
        {
            var sut = new Book("Sourav");
            sut.AddGrade(1);
            sut.AddGrade(2);
            sut.AddGrade(2);

            Assert.That(sut.AvgGrade(), Is.EqualTo(1.67).Within(10).Percent);
        }

         
    }
}
