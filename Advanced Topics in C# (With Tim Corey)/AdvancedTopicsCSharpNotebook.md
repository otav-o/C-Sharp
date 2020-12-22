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

## Handling Exceptions in C# - Whent to catch them, where to catch them, and how to catch them

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

// 40 min