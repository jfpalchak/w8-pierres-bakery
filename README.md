# _Pierre's Bakery_

#### By _Joey Palchak_

#### _A C# console application for a bakery, calculating total costs for a user's order._

## Technologies Used

* C#
* .NET 6
* NuGet Package Manager
* MSTest

## Description

@@@@@

## Setup/Installation Requirements

1. Copy the **[URL](<[#link](https://github.com/jfpalchak/w8-pierres-bakery.git)>)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:

```bash
$ git clone https://github.com/jfpalchak/w8-pierres-bakery.git
```
2. Open your terminal and navigate to this project's production directory called `PierresBakery`.
3. In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
   1. Optionally, you can run `dotnet build` to compile this console app without running it.
4. To run tests on the project's models, navigate to test directory, `PierresBakery.Tests`.
5. In the command line, run the command `dotnet test` to execute tests.

## Known Bugs

* If the user continues to enter additional purchases to their order, an item's discount will *not* be applied if that item is purchased _individually_.

## License

MIT License

Copyright (c) _9/22/2023_ _Joey Palchak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.