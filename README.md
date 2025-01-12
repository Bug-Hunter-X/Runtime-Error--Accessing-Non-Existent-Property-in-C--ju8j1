# Runtime Error: Accessing Non-Existent Property in C#

This example demonstrates a common runtime error in C# that occurs when accessing a non-existent property of a class.  C# doesn't throw a compile-time error in this situation, making it easy to miss during development.

The `bug.cs` file shows the problematic code, where `NonExistentProperty` is accessed within the `MyMethod`.  This will lead to a `System.Runtime.InteropServices.COMException` at runtime.

The solution, shown in `bugSolution.cs`, highlights how to mitigate this issue. While a full solution depends on the context of your application, common strategies involve defensive programming (checking for null values or the existence of properties), using reflection cautiously, or using a more robust property access mechanism.