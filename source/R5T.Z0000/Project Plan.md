#R5T.Z0000
Common values of .NET C# built-in types, like characters, strings, integers, etc.

Note: not for System namespace types and related types, like predicate, regular expression patter, index, etc. Those belong in R5T.Z0001.

* Without all System namespace types
* Without contextual meanings (e.g. regular expression pattern, which is a string, but contextually more than a string).
* Without renamings (e.g. Index.First).

Only built-in types. See MS documentation on built-in types:

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types



Questions:

? Should regular expression patterns be included?
A: No, because they don't match the mission of the library since, if they were their own type, would not be in the list of built-in types. They should instead go in a library with the mission of containing constants of System namespace functionality (R5T.Z0001).

For Yes:

* Regular expression patterns are strings, and string is a built in type.
* To lower functionality dependency counts, regular expression patterns would be included in the same library as strings (since they are both related to System namespace functionality).

For No:

* Regular expression patterns, if they were their own type, would not be included in the list of built-in types.
* These patterns are a separate enough functionality that you may want them without wanting strings, characters, ints.


? Should predicates be included?
A: No, because they don't match the mission of the library since, if Predicate was its own type, it would not be in the list of built-in types.


? Should renamings of built-in type values (like FirstIndex for Integer.Zero) be included?
A: No, because they don't match the mission of the library since, if Index was its own type, it would not be in the list of built-in types.
