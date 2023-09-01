# UNIVERSITY REGISTRAR

#### By Alex Johnson
Based on code developed in collaboration with: Aitana Shough, Anton Ch, and Daniel Yakovlev

An application to track students and courses for a fictional university.

## Technologies Used

* C#
* .Net 6
* ASP.Net EF Core 6
* SQL
* LINQ

### Objectives 

The initial goal for this project was to create a fully functional CRUD MVC web application that utilizes a many-to-many MySQL database. EF Core was used for communication with the database.

Now, I am splitting the project into a dotnet backend with a react SPA front

## Setup/Installation Requirements

#### To run this project, you will need:
* .NET 6.0
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* .NET Core CLI
```
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. Clone this repo to your workspace.

2. Navigate to the `Registrar` directory.

3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=university_registrar;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```

4. Install dependencies within the `Registrar` directory
```
$ dotnet restore
````

5. Build and run the program 
 ```
 $ dotnet run
 ```

6. Enjoy!


## Known Bugs
09/01/23
* adding a course throws a 'foreign key constraint' error: *MySqlConnector.Core.ResultSet.ReadResultSetHeaderAsync(IOBehavior ioBehavior) in ResultSet.cs, line 44*
error occurs on trying to save new dbObject, other create routes seem fine


## License

**MIT License**

Copyright (c) 2022 Aitana Shough, Anton Ch, Alex Johnson, Daniel Yakovlev

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
