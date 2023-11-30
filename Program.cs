using UnitTestFrameworksTask;

if (args.Length == 0)
{
    Console.WriteLine("Please provide a sequence of symbols as command-line arguments");
    return;
}

foreach (string input in args)
{
    int maxUnequalConsecutiveChars = StringUtil.MaxUnequalConsecutiveChars(input);
    Console.WriteLine($"For input: {input}, max consecutive count: {maxUnequalConsecutiveChars}");

    int maxConsecuntiveLatinLetters = StringUtil.MaxConsecuntiveLatinLetters(input);
    Console.WriteLine($"For input: {input}, max consecutive count: {maxConsecuntiveLatinLetters}");

    int maxConsecuntiveDigits = StringUtil.MaxConsecuntiveDigits(input);
    Console.WriteLine($"For input: {input}, max consecutive count: {maxConsecuntiveDigits}");
}