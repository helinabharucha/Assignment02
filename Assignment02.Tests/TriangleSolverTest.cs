using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace Assignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void Test_triangle_solver_inputs110_output_failed()
        {
            string answer = TriangleSolver.Analyze(1, 1, 0);
            Assert.AreEqual("Sorry the sides do not form a triangle", answer);
        }
        [Test]
        public void Test_triangle_solver_inputs000_output_failed()
        {
            string answer = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual("Sorry the sides do not form a triangle", answer);
        }

        [Test]
        public void Test_triangle_solver_inputs555_output_pass_equilateral()
        {
            string answer = TriangleSolver.Analyze(5, 5, 5);
            Assert.AreEqual("Triangle is Equilateral Triangle", answer);
        }
        [Test]
        public void Test_triangle_solver_inputs777_output_pass_equilateral()
        {
            string answer = TriangleSolver.Analyze(7, 7, 7);
            Assert.AreEqual("Triangle is Equilateral Triangle", answer);
        }
        [Test]
        public void Test_triangle_solver_inputs774_output_pass_isosceles()
        {
            string answer = TriangleSolver.Analyze(7,7,4);
            Assert.AreEqual("Triangle is isosceles", answer);
        }
        [Test]
        public void Test_triangle_solver_inputs744_output_pass_isosceles()
        {
            string answer = TriangleSolver.Analyze(7, 4, 4);
            Assert.AreEqual("Triangle is isosceles", answer);
        }
        [Test]
        public void Test_triangle_solver_inputs357_output_pass_scalene()
        {
            string answer = TriangleSolver.Analyze(3,5,7);
            Assert.AreEqual("Triangle is Scalene Triangle", answer);
        }
        [Test]
        public void Test_triangle_solver_inputs1048_output_pass_scalene()
        {
            string answer = TriangleSolver.Analyze(10, 4, 8);
            Assert.AreEqual("Triangle is Scalene Triangle", answer);
        }

    }
}
