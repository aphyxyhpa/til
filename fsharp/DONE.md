# Done

## Create remote container for F#

Use remote container of VSCode.

## F# tutorial

https://dotnet.microsoft.com/learn/languages/fsharp-hello-world-tutorial/intro

## F# tour

https://docs.microsoft.com/en-us/dotnet/fsharp/tour

### variables

Any variables is immutable by deafult. A keyword `mutable` makes variables mutable.

#### Assign new value to variable

Use `<-`.

### string placeholder

%d ... integer
%s ... string
%b ... boolean

### ignore escape character

Use `@`.

### substring

Substrings use the indexer notation.

### struct and tuple

It's important to note that because struct tuples are value types, they cannot be implicitly converted to reference tuples, or vice versa. You must explicitly convert between a reference and struct tuple.

### Pipe

Use `|>`.

### List and Array

`[ ]` is list. `[| |]` is array.

### data structure

- List
- Array
- Tuple
- Struct
- Record
- Union
- 

### pattern matching

### class and interface

## Functional Programming

### Expressions

### Pure functions (Mathmatical functions)

As previously mentioned, pure functions are functions that:
Always evaluate to the same value for the same input.
Have no side effects.

A mathematical function does not do any calculation – it is purely a mapping from input to output.

I can be sure that the answer will be the same whether I evaluate it now or later.

### Immutability

I can be sure that the answer will be the same whether I evaluate it now or later.

“add1” is called a function value.


## Tools

- Runtime
- Editor
- Package manager
  - https://fsprojects.github.io/Paket/
- Unit Testing
- Build
- CI/CD
  - GitHub Actions
- Deploy
- 

### Package Manager

https://docs.microsoft.com/en-us/dotnet/fsharp/using-fsharp-on-azure/package-management


```
dotnet new tool-manifest
dotnet tool install paket
```

### Web frameworks


