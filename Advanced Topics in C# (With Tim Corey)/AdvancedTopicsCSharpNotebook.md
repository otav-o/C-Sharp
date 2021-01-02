# this notebook is a mess and should be taken as a draft

## 1. C# Access Modifiers for methods

16 December 2020, Otávio

- Give less permissions to your objects as possible...
- and do not repeat yourself!

> check the code to practice this lesson

### public

- Accessible everywhere

### private

- Only accessible to in the area it was declared (curly braces)
- Only the owner class can access the property/variable/method

### internal

- Visible to all classes of the assembly (project)
  - Anywhere inside the assembly

### protected

- Like private, but also visible to inheriting classes

### private protected

- It's only available to classes that inherit AND are in the same assembly

### protected internal

- Accessible to classes that inherit (everywhere) OR are in the same assembly (does not have to exist an inheritance)

---

## Handling Exceptions in C# - When to catch them, where to catch them, and how to catch them

```c#
Console.WriteLine($"The value at the given position is {result}");
```

unhandled exception: crashes the application

select some code, right click and select snippet to generate blocks fast

```c#
int output = 0;
try
{
    int[] numbers = new int[] { 1, 4, 7, 2 };
    output = numbers[position];
}
catch (Exception ex) // put the exception into ex
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace); // says where the problem is (offending line)

}

return output;
```

In general, putting try-catch as high as possible is valuable because you receive more information from `Console.WriteLine(ex.StackTrace);` (all methods there was a problem) 

full history from the root call all the way through actual exception. You know how it was called.

```c#
int output = 0;

Console.WriteLine("Open Database Connection");

try
{
    output = ParentMethod(position);
}
catch (Exception ex)
{
    throw; // catch the exception and immediately pass it up the chain
}
finally // runs with exception or not before passing exception
{
    Console.WriteLine("Close Database Connection");
    // don't put code here that might an exception
}


return output;
```

finally runs first

it keeps going up the caller list looking for a catch block of if it does not find one it's called an unhandled exception and blows your application up and shuts it down.

It is possible to have an global exception handler

```c#
catch (Exception ex)
{
	// Do some logging
	throw new ArgumentException("You passed in bad data", ex);
}
```

inner exception

gives us full stack  for the original exception but also allows us to have a custom message and maybe even a different exception type (e.g. argument exception)

it runs the first catch block that matches (so order blocks from most specific to the least)

your library should just go ahead and throw exceptions, use catch only in UI. Let the caller deal with the exception

### Performance considerations (.NET doc)

Throwing or handling an exception consumes a significant amount of system resources and execution time. Throw exceptions only to handle truly extraordinary conditions, not to handle predictable events or flow control. For example, in some cases, such as when you're developing a class library, it's reasonable to throw an exception if a method argument is invalid, because you expect your method to be called with valid parameters. An invalid method argument, if it is not the result of a usage error, means that something extraordinary has occurred. Conversely, do not throw an exception if user input is invalid, because you can expect users to occasionally enter invalid data. Instead, provide a retry mechanism so users can enter valid input. Nor should you use exceptions to handle usage errors. Instead, use [assertions](https://docs.microsoft.com/en-us/visualstudio/debugger/assertions-in-managed-code) to identify and correct usage errors.

In addition, do not throw an exception when a return code is sufficient; do not convert a return code to an exception; and do not routinely catch an exception, ignore it, and then continue processing.

---

## Random numbers in C#

> 30/12/2020

```c#
class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // if you don't pass any value it will take the current tick of the clock as starter number - and that is awesome
            // only creates a Random object once and for everything else call .Next() method. Exception: thread safe
            // if you use a seed number (in the constructor) the results will be known and you can recreate random number
            // if you need something that has to be absolutely random then use the cryptographic library


            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next(5, 11));
            //    // pass 11 to generate from 0 to 10
            //    // pass 5, 11 to generate from 5 to 10

            //    Console.WriteLine(random.NextDouble()*10);

            //    SimpleMethod(random);
            //}

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel {FirstName = "Tim"},
                new PersonModel {FirstName = "Sue"},
                new PersonModel {FirstName = "Mary"},
                new PersonModel {FirstName = "George"},
                new PersonModel {FirstName = "Jane"},
                new PersonModel {FirstName = "Nancy"},
                new PersonModel {FirstName = "Bob"}
            };

            // var sortedPeople = people.OrderBy(x => x.FirstName);
            var sortedPeople = people.OrderBy(x => random.Next()); // lambda
            // good for moderate-sized lists. Very close to totally random

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            // do not create a new Random object!
            Console.WriteLine(random.Next());


        }
    }
```

## Interfaces in C#

Sometimes inheritance does not solve the problem

Shortcut for creating a interface: ctrl + . with cursor in a class and "extract interface"

```c#
foreach (IProductModel prod in cart)
{
    prod.ShipItem(customer);
    // here we can only access properties and methods from IProductModel

    if (prod is IDigitalProductModel digital)
    {
        Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left");
        // Title would not be visible if both interfaces were signed separatelly in DigitalProductModel class and the type were IDigitalProductModel
    }
}
```

```c#
public interface IDigitalProductModel : IProductModel
{
    // an interface that implements another interface
    // you can use only the more specific (see DigitalProductModel implements IDigitalProductModel and is implicity that IProductModel was signed too)
    int TotalDownloadsLeft { get; }

    // IDigitalProductModel receives all stuff form IProductModel
}
```

```c#
public class CourseProductModel : IProductModel
{
}
```

### Abstract classes

```c#
List<IDataAccess> databases = new List<IDataAccess>()
{
    new SqlDataAccess(),
    new SqliteDataAccess()
};
```

// 12 minutes