# _Pierre's Bakery_

#### By _Joey Palchak_

#### _A C# console application for a bakery, calculating total costs for a user's order._

## Technologies Used

* C#
* .NET 6
* NuGet Package Manager
* MSTest

## Description

Welcome to "Pierre's Bakery" Console Application! This C# project provides a simple command-line interface for ordering baked goods from Pierre's Bakery, where user's can take advantage of the bakery's special deals: "Buy 2 loaves of bread, get 1 free", and "Buy 3 pastries, get 1 free"! 

Upon starting the application, the user is prompted with entering their desired amount of bread loaves and pastries. After submitting their order, the application calculates their order's total, including any applicable discounts. Should the user wish to continue adding items, or otherwise exit the application, they will then be prompted to do so.

The user's order is calculated like so:

```
Order Cost = (Number of Items * Price of Item) - Discount
```
where
```
Discount = Price of Item * (Number of Items / nth Item that is Free)
```
and
```
nth Item that is Free = 3 for Bread, or, 4 for Pastries
```


## Setup/Installation Requirements

1. Copy the **[URL](https://github.com/jfpalchak/w8-pierres-bakery.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/jfpalchak/w8-pierres-bakery.git
```
5. Open your terminal and navigate to this project's production directory called `PierresBakery`.
6. In the command line, run the following command to compile and execute the console application:
   
```bash
$ dotnet run
```
Since this is a console application, you'll interact with it through text commands in your terminal.
   1. Optionally, you can run `dotnet build` to compile this console app without running it.
7. To run tests on the project's models, navigate to test directory, `PierresBakery.Tests`.
8. In the command line, run the following command to execute tests:
```bash
$ dotnet test
```

## Known Bugs

* If the user continues to enter additional purchases to their order, an item's discount will **not** be applied if that item is purchased _individually_.
* The total number of Bread or Pastry items ordered is not listed in the receipt.
* If additional bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) _9/22/2023_ _Joey Palchak_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.