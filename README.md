# Parcels (C# Console Application)

#### A web-based application to simulate a package shipping company where the user can calculate shipping costs for various sizes of parcel, hosted on [GitHub](https://github.com/KristaRutz/parcels). _Last Updated 03.03.2020._

#### By _**Krista Rutz, Steven Fleming**_

## Description

This application lets the user input dimensions and weight and does calculations for volume and shipping cost.
It might even be hosted on hosted on [GitHub](https://github.com/KristaRutz/parcels). It does so using an MVC framework and multiple controllers.

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/parcels) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'Parcels'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/parcels`
    - The new directory will be created as 'Desktop/Parcels'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd Parcels/Parcels`
  - `dotnet build`
  - `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- C#
- .NET Core 2.2

## Specs

<details>
  <summary>Expand specs for this project</summary>

```Following the guidelines below, create a website for a fictional shipping company that helps users calculate shipping estimates:

Create a Parcel class. It should contain a constructor, and getters and setters for each property. All properties should be set to private. You should be able to create a new parcel and specify the dimensions and weight in the arguments.

Create a website where the user can submit a form with the dimensions and weight of a Parcel, and you can use the data in the form to instantiate a Parcel object and display its dimensions and weight.

When you call a method called Volume() on a Parcel instance, it should return the product of the sides.

When you call a CostToShip() method on your parcel, return a cost based on a formula you make up.

Display the cost to ship and the volume of a Parcel with its dimensions in your site.

Bonus: Add validation and make sure the Parcel object is not created if any of the form fields are blank. Display an error message instead. Also make sure your user can only enter numbers into the form.
```

</details>

## Known Bugs

- Cannot display the price of most recent parcel since last commit.

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. Krista can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz, Steven Fleming_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
