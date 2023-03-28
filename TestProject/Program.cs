using System.Xml;

string output = "";
for (int i = 1; i <= 100; ++i) {
    output = i.ToString();
    if (i % 15 == 0)
        output += " FizzBuzz";
    else {
        if (i % 3 == 0)
            output += " Fizz";
        else if (i % 5 == 0)
            output += " Buzz";
    }
    Console.WriteLine(output);
}