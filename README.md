# String Utilities .NET Library

A .NET library that provides convenient utilities to work with most common string-related operations.

Current capabilities:

* Password Validaton

## Password Validator

Validates if the string

- contains **at least one uppercase letter, one lowercase letter, one digit, and one special character**: *!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~.*
- **does not contain** any **whitespace** **characters** (**spaces, tabs, or
  newlines** ).
- **length** is within the acceptable **range**.

### How to use

1. Add a reference to the StringUtilities DLL to your project:

```xml
<Reference Include="../lib/path/To/StringUtilities.dll" />
```

2. Write some code:

```csharp
using StringUtilities;

// here you use your imagination and create a namespace, a class, a method...
// get a password from somewhere, or create on your own...
// so now you are in an excellent place to use the PasswordValidator:
bool isPasswordValid = PasswordValidator.Validate(password, minLength: 8, maxLength: 16);
```

> **The minimum length cannot be lower than 4!** If the validator receives a lower value, it is overriden to 4.
