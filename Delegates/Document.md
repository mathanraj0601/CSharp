# Delegates

<details>
<summary>
    What is Delegate
</summary>

```
    Delegate is a method reference ( It allows us to have methods as object ).So that we can flexibly pass it to any where

    in Simple term, It's like messenger(object) that we can send any where and this messenger know what the message (method) to show (invoke)
```
</details>

<details>
<summary>
    Deletage framework types and Syntax
</summary>

```

    1. Custom or user defined delegate
    2. C# built in delegates 
    <access modifier>  delegate <returntype> DelegateName(parameters)
```
```csharp
    public delegate void MessageDelegate(string message);
```
</details>

<details>
<summary>
    Delegate types (Custom or User defined)
</summary>

```
    1. Single reference
    2. Multiple reference

    Single reference refer to only one function or method at a time
    Multiple reference refer to many method reference
```
</details>

<details>
<summary>
    Single reference
</summary>

```CSharp
    //Declaration of Delegate
    public delegate void MessageDelegate(string message);
    public class CustomDelegate
    {
        public void CustomDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
```

Program.cs

```csharp

    CustomDelegate customDelegate = new CustomDelegate();
    //Assiging in delegate
    MessageDelegate messageDelegate = customDelegate.CustomDelegateMethod;

    //Invocation of Delegate
    messageDelegate("Hello from single Delegate");

```
```
    In the above code a delegate is assigned directly  a single method and invoked
```
</details>

<details>
<summary>
    Multiple reference
</summary>

```CSharp
    public delegate void MessageDelegate(string message);
    public class CustomDelegate
    {
        public void CustomDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class GreetDelegate
    {
        public void GreetDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
```

Program.cs

```csharp
CustomDelegate customDelegate = new CustomDelegate();
GreetDelegate greetDelegate = new GreetDelegate();

//Assiging in delegate
MessageDelegate messageDelegate = customDelegate.CustomDelegateMethod;

// below is the multicast delegate example
messageDelegate += Console.WriteLine;
messageDelegate("Hello from Multicast Delegate");
```

```
    In the above code we assigned two method reference to delegate
```
</details>

<details>
<summary>
    Direct assigned vs Creating delegate and assigning
</summary>

```
    Directly assigning is used so that every method that have same signature (same paramter and return type ) we can assign and invoke

    Creating new instance and assiging enable us to manage same signatures as different sets or group
    
```


```CSharp
    public delegate void MessageDelegate(string message);
    public class CustomDelegate
    {
        public void CustomDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class GreetDelegate
    {
        public void GreetDelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
```

Program.cs

```csharp
CustomDelegate customDelegate = new CustomDelegate();
GreetDelegate greetDelegate = new GreetDelegate();

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
```
</details>

<details>
<summary>
 C# pre bulit delegate Types
</summary>

```
1. Func
2. Predicate
3. Comparison
4. Action
```
</details>

<details>
<summary>
    Func
</summary>

```
    Func used to specify input paramtere types and return type as generic <inputs, returns>
```
```csharp
// Func
    Func<string, string> func = (string message) => { return message; };
    string funcResult = func("Hello from Func");
    Console.WriteLine($"Func Result : {funcResult}");

```
</details>

<details>
<summary>
    Predicate
</summary>

```
    Predicates take two paramter of type mentioned in generics and return boolean
```

```csharp
// Predicate
    //Take one parameter and return bool
    Predicate<int> predicate = (int number) => { return (number % 2 == 0); };
    bool predicateResult = predicate(10);
    Console.WriteLine($"Predicate output : {predicateResult}");
```
</details>


<details>
<summary>
    Comparison
</summary>

```
    Comparioson take two paramter of type mentioned in generics and return the type in generics
```

```csharp
//Comparison
//Take two parameters and return int
    Comparison<int> comparison = (int number1, int number2) => { return number1.CompareTo(number2); };
    int comparisonResult = comparison(10, 10);
    Console.WriteLine($"Comparison output : {comparisonResult}");
```
</details>



<details>
<summary>
    Action
</summary>

```
    Action take number and types of parameters mentioned in generic and return nothing (void ).
```

```csharp
// Action
   Action<string> action = Console.WriteLine;
   action("Hello from Action");
```
</details>
