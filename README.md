# Student Attendance Manager — C# WinForms

A Windows desktop application for managing students, attendance, schedules and grades, built with **C#**, **Windows Forms** (.NET Framework 4.8) and **SQL Server**.

![C#](https://img.shields.io/badge/C%23-.NET_Framework_4.8-512BD4?logo=dotnet)
![SQL Server](https://img.shields.io/badge/SQL_Server-ADO.NET-CC2927?logo=microsoftsqlserver&logoColor=white)

## Features

| Screen              | Purpose                                   |
|---------------------|-------------------------------------------|
| **Login**           | Account creation and sign-in              |
| **Menu**            | Navigation hub                            |
| **Add student**     | Register new students                     |
| **Mark presence**   | Record attendance for a session           |
| **Consult presence**| Review a student's attendance history     |
| **Schedule**        | View the class timetable                  |
| **Update grades**   | Edit students' grades                     |

## Tech stack

- C# / Windows Forms (.NET Framework 4.8)
- SQL Server through ADO.NET (`SqlConnection`)

## Getting started

**Requirements:** Windows, Visual Studio 2019+ and SQL Server (Express is enough).

1. Clone the repository and open `Student management.csproj` in Visual Studio.
2. Create a `student_management` database in SQL Server.
3. Update the connection string in the forms (`connectionString`) to point to your SQL Server instance.
4. Build and run (F5).

## Related projects

- [Web version (Next.js + MongoDB)](https://github.com/charif6102/Student-Attendance-Manager-React)
- [Java RMI version](https://github.com/charif6102/Student-Attendance-Manager-Java)
