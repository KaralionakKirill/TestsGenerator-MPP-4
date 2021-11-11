using Core.TestGenerator.Implementations;

namespace ConsoleApp
{
    static class TestProgram
    {
        static void Main()
        {
            var generator = NUnitTestGenerator.CreateGenerator(builder =>
            {
                builder.MaxGenerateFiles = 10;
                builder.MaxReadFiles = 10;
                builder.MaxWriteFiles = 10;
            });
            generator.GenerateTestsAsync(@"D:\Labs\MPP\4\mpp-lab4-master\ConsoleApp\input",
                @"D:\Labs\MPP\4\mpp-lab4-master\ConsoleApp\output").Wait();
        }
    }
}