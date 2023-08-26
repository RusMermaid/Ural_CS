Copyright 2021 Ruslan Golov

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


# UralMathFsharpLib.Units

This is an F# functional first units library  It provides an API based on core units concepts and is built around the concepts of functional first design and type safety. From this philosophy, this library provides a way of maintaining unit conversions and manipulations which allows you to focus on the hard work without being burdened with the though of having a unit discrepancy.

### :closed_book: 

# Overview

This library provides access to a variety of units to work with.


# Development

To generate the API documentation you need to run the following commands.

```bash
dotnet tool install fsdocs-tool
dotnet fsdocs build --input Docs --eval
dotnet fsdocs watch --input Docs --eval

dotnet fsdocs watch --projects Math.Units --input Docs --eval --properties Configuration=Release
dotnet build --configuration Release && dotnet fsdocs watch --projects Math.Units --input Docs eval --properties Configuration=Release --clean
```

