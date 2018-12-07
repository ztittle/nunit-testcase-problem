using System;
using NUnit.Framework;

namespace Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(1)]
		[TestCase(2)]
		[TestCase(3)]
		[TestCase(4)]
		public void Test1(int number)
		{
			Console.Write($"{DateTime.Now}: {number}");
			Assert.IsTrue(number > 0);
		}
	}
}