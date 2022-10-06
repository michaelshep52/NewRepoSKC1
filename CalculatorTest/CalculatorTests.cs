using System;
using KnowledgeCheck1_Calculator;
using Microsoft.VisualStudio.TestPlatform;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest;

public class CalfunxTests
{
    readonly Calculator calculator = new Calculator();

    [SetUp]
    public void AddNumberTest()
    {
        Assert.AreEqual(11, calculator.Add(5, 6));
           
    }

    [Test]
    public void SubtractNumberTest()
    {
        Assert.AreEqual(5, calculator.Subtract(10, 5));
    }

    [Test]
    public void MultiplyNumberTest()
    {
        Assert.AreEqual(30, calculator.Multiply(6, 5));
    }

    [Test]
    public void DivideNumberTest()
    {
        Assert.AreEqual(10, calculator.Divide(50, 5));
    }
}

