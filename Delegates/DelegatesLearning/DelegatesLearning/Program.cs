// See https://aka.ms/new-console-template for more information
using DelegatesLearning.CustomDelegtes;

CustomDelegate customDelegate = new CustomDelegate();
GreetDelegate greetDelegate = new GreetDelegate();

//Assiging in delegate
MessageDelegate messageDelegate = customDelegate.CustomDelegateMethod;

//Invocation of Delegate
messageDelegate("Hello from single Delegate");

// below is the multicast delegate example
messageDelegate += Console.WriteLine;
messageDelegate("Hello from Multicast Delegate");

// There is a Difference between Assigning directly  or through creating instance of delegate

// Assigning directly
MessageDelegate messageDelegate1 = customDelegate.CustomDelegateMethod;
messageDelegate1("Hello from Assigning directly");

// Creating instance of delegate
MessageDelegate messageDelegate2 = new MessageDelegate(customDelegate.CustomDelegateMethod);
messageDelegate2("Hello from Creating instance of delegate");

// The need for creating instance of delegate is have different delegate points to different methods of same signature

// See below example
MessageDelegate greet = new MessageDelegate(greetDelegate.GreetDelegateMethod);
MessageDelegate message = new MessageDelegate(customDelegate.CustomDelegateMethod);

greet("Hello from Greet Delegate");
message("Hello from Message Delegate");


// Prebuilt C# delegates
// Action

   Action<string> action = Console.WriteLine;
   action("Hello from Action");

// Func

    Func<string, string> func = (string message) => { return message; };
    string funcResult = func("Hello from Func");
    Console.WriteLine($"Func Result : {funcResult}");

// Predicate
    //Take one parameter and return bool
    Predicate<int> predicate = (int number) => { return (number % 2 == 0); };
    bool predicateResult = predicate(10);
    Console.WriteLine($"Predicate output : {predicateResult}");

//Comparison
//Take two parameters and return int
    Comparison<int> comparison = (int number1, int number2) => { return number1.CompareTo(number2); };
    int comparisonResult = comparison(10, 10);
    Console.WriteLine($"Comparison output : {comparisonResult}");