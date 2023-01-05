# UNIVERSITY REGISTRAR

#### By Aitana Shough, Anton Ch, Alex Johnson, Daniel Yakovlev

An application to track students and courses for a fictional university.

## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* MySQL Workbench
* LINQ

### Objectives 

The goal for this project was to create a fully functional CRUD MVC web application that utilizes a many-to-many MySQL database. EF Core was used for communication with the database.

## Setup/Installation Requirements

#### Get copy of MySQL database
1. Clone this repo to your workspace.
2. Open MySQLWorkbench, log in, and connect to your local server
3. Under the Administration tab, select Data Import/Restore
  * Select `Import from Self Contained File`
  * Select **../university_registrar.sql** from the top level of the directory, `UniversityRegistrar`.
  * Select "New..." and set new schema name to **university_registrar**
  * Select 'Start Import'
4. You should now have a copy of the project database on your machine.

#### Open project

1. Navigate to the `Registrar` directory.

2. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=university_registrar;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```

3. Install dependencies within the `Registrar` directory
```
$ dotnet restore
````

4. Build and run the program 
 ```
 $ dotnet run
 ```

5. Enjoy!

## Known Bugs

* No known bugs.


## License

**MIT License**

Copyright (c) 2022 Aitana Shough, Anton Ch, Alex Johnson, Daniel Yakovlev

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
