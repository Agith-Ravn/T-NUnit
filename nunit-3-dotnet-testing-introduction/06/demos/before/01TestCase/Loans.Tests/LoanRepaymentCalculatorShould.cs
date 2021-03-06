using Loans.Domain.Applications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    public class LoanRepaymentCalculatorShould
    {
        [Test]
        public void CalculateCorrectMonthlyRepayment()
        {
            //Arrange
            var sut = new LoanRepaymentCalculator();

            //Act
            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("USD", 200_000), 6.5m, new LoanTerm(30));

            //Assert
            Assert.That(monthlyPayment, Is.EqualTo(1264.14));
        }
    }
}
