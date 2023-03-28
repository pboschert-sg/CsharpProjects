
// Part 1
bool parsed = false;
int parsedValue = -1;
Console.WriteLine("Enter an integer value between 5 and 10:");
do {
    string? input = Console.ReadLine();
    parsed = int.TryParse(input, out parsedValue);
    if(!parsed) {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    } else if(parsedValue < 5 || parsedValue > 10) {
        Console.WriteLine($"You entered {parsedValue}. Please enter a number between 5 and 10.");
    }
} while (!parsed || parsedValue < 5 || parsedValue > 10);

Console.WriteLine($"Your input value ({parsedValue}) has been accepted.");





// Part 2
Console.WriteLine("Enter a role name:");
string? unparsedRoleName = null;
string? parsedRoleName = unparsedRoleName;

do {
    unparsedRoleName = Console.ReadLine();

    if(!String.IsNullOrEmpty(unparsedRoleName))
        parsedRoleName = unparsedRoleName.Trim().ToLower();

    if (parsedRoleName != "administrator" && parsedRoleName != "manager" && parsedRoleName != "user")
        Console.WriteLine($"The role name that you entered, \"{unparsedRoleName}\", is not valid. Enter your role name (Administrator, Manager, or User)");

} while (parsedRoleName != "administrator" &&
      parsedRoleName != "manager" &&
      parsedRoleName != "user");
Console.WriteLine($"Your input value ({unparsedRoleName}) has been accepted.");





// Part 3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
char[] charsToTrim = {'.', ' '};
foreach (string myString in myStrings) {
    int periodLocation = -1, substringStart = 0;
    do {
        periodLocation = myString.IndexOf(".", substringStart + 1);
        if (periodLocation != -1) {
            Console.WriteLine(myString.Substring(substringStart, periodLocation - substringStart).Trim(charsToTrim));
            substringStart = periodLocation;
        } else {
            Console.WriteLine(myString.Substring(substringStart, myString.Length - substringStart).Trim(charsToTrim));
        }
    } while (periodLocation != -1);
}
