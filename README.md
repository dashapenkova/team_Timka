# team_Timka
Repository of the team project for __*OOA &amp; Software design*__ course

# Software Requirements Specification
## Purpose
The purpose of this document is to build a WEB application to help students manage their subjects at LNU. The app will allow the user to register, manage their courses, see list of teachers, courses and departments.

## Document conventions

|      |                             |
| ---- | --------------------------- |
| DB   | Database                    |
| UML  | Unified Modelling Language  |
| ER   | Entity Relationship         |

## Intended audience and reading suggestions
This document describes an application for managing some different things at LNU such as departments, courses, students, teachers. It will be useful for university students who want to manage studying well. Overall, the application will make you disciplined and help you to manage your studyings.

## Project scope

The application is a ASP.NET MVC with EF Core application, based on one DB:
- Relational database which stores data of users, teachers, students, departments.
The purpose of the application is to help students with ther studying stuff. That's why it must be easy to use with nice UX and modern UI.

## Product features

- An unregistered user can sign-up in the application. During this process, the user has to choose a username and password. 
  - When the user chooses an existing username he will be notified about it and will be asked to choose another username. 
  - The user enters a new username and chooses a password he has successfully registered in the system.
- The registered user can log in. To do this, the user has to enter a username and password.
  - In case of entering a wrong password, the user will be notified about it and will be asked to try to enter the correct username/password.
  - In case of entering the correct username and password, the user is created and logged in.
- The registered user can log-out.
- The registered user can see the list of students, courses, departments, teachers
- Admin can create/edit/delete/view details of students, courses, departments, teachers

## Nonfunctional Requirements
- The new product shall be easy to use by any members (age 15 to 80) of the public who may only have one hand free.
- The product shall be able to be used by adult members of the public without training.
- The product shall not use picture icons that could be considered offensive in any country where the product is used.
- Supported systems: Windows 7-11.
- Language: English
- Each window must load within 0.5 seconds.
