using System;
using FizzWare.NBuilder;

namespace Sphinx.CodeGenerator.Application.Tests.TestHelperMethods
{
    public static class GenerateTestData
    {
        public static T GenerateTypedTestData<T>()
        {
            var testData = Builder<T>.CreateNew();
            return testData.Build();
        }
    }
}