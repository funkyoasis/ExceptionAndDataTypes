using NUnit.Framework;
using System;
using ExceptionsApp;

namespace ExceptionDatatypeTests
{
	public class GradeTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(-34)]
		[TestCase(-1)]
		[TestCase(-100)]
		public void WhenMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
		{
			Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
				.With.Message.Contains("Allowed range 0-100"));
		}

		[TestCase(101)]
		[TestCase(6996)]
		public void WhenMarkIsMoreThan100_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
		{
			Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
				.With.Message.Contains("Allowed range 0-100"));
		} 
	}
}