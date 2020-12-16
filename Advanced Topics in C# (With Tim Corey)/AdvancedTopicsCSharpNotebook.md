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





