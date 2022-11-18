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

## UML: Use Case Diagram
![UseCase_Diagram](https://user-images.githubusercontent.com/47561280/202564997-e10b2914-b429-4508-a2fa-92c71c4d5ebb.png)
[UseCase_Diagram.pdf](https://github.com/dashapenkova/team_Timka/files/10035851/UseCase_Diagram.pdf)

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

## Used Concurency Patterns
The alternative to pessimistic concurrency is optimistic concurrency. Optimistic concurrency means allowing concurrency conflicts to happen, and then reacting appropriately if they do. For example, Jane visits the Department Edit page and changes the Budget amount for the English department from $350,000.00 to $0.00.

![image](https://user-images.githubusercontent.com/47561214/202406314-52c07d9d-5c18-4961-8587-39fdceed7233.png)

Before Jane clicks Save, John visits the same page and changes the Start Date field from 14-Nov-2022 to 14-Nov-2013.

![image](https://user-images.githubusercontent.com/47561214/202407538-59237b63-fd0e-4210-9888-989489048309.png)

Jane clicks Save first and sees her change when the browser returns to the Index page.

![image](https://user-images.githubusercontent.com/47561214/202406874-7b9cf159-9e35-4481-a414-894a4edf48b3.png)

Then John clicks Save on an Edit page that still shows a budget of $350,000.00. What happens next is determined by how you handle concurrency conflicts.

Some of the options include the following:

- You can keep track of which property a user has modified and update only the corresponding columns in the database.
  In the example scenario, no data would be lost, because different properties were updated by the two users. The next time someone browses the English department, they will see both Jane's and John's changes -- a start date of 9/1/2013 and a budget of zero dollars. This method of updating can reduce the number of conflicts that could result in data loss, but it can't avoid data loss if competing changes are made to the same property of an entity. Whether the Entity Framework works this way depends on how you implement your update code. It's often not practical in a web application, because it can require that you maintain large amounts of state in order to keep track of all original property values for an entity as well as new values. Maintaining large amounts of state can affect application performance because it either requires server resources or must be included in the web page itself (for example, in hidden fields) or in a cookie.

- You can let John's change overwrite Jane's change.
  The next time someone browses the English department, they will see 9/1/2013 and the restored $350,000.00 value. This is called a Client Wins or Last in Wins scenario. (All values from the client take precedence over what's in the data store.) As noted in the introduction to this section, if you don't do any coding for concurrency handling, this will happen automatically.

- You can prevent John's change from being updated in the database.
  Typically, you would display an error message, show him the current state of the data, and allow him to reapply his changes if he still wants to make them. This is called a Store Wins scenario. (The data-store values take precedence over the values submitted by the client.) You'll implement the Store Wins scenario in this tutorial. This method ensures that no changes are overwritten without a user being alerted to what's happening.

![image](https://user-images.githubusercontent.com/47561214/202407265-04a945db-f9f6-40dc-874a-e4399a1b507e.png)


# Detecting concurrency conflicts

You can resolve conflicts by handling DbConcurrencyException exceptions that the Entity Framework throws. In order to know when to throw these exceptions, the Entity Framework must be able to detect conflicts. Therefore, you must configure the database and the data model appropriately. Some options for enabling conflict detection include the following:

- In the database table, include a tracking column that can be used to determine when a row has been changed. You can then configure the Entity Framework to include that column in the Where clause of SQL Update or Delete commands.
  The data type of the tracking column is typically rowversion. The rowversion value is a sequential number that's incremented each time the row is updated. In an Update or Delete command, the Where clause includes the original value of the tracking column (the original row version) . If the row being updated has been changed by another user, the value in the rowversion column is different than the original value, so the Update or Delete statement can't find the row to update because of the Where clause. When the Entity Framework finds that no rows have been updated by the Update or Delete command (that is, when the number of affected rows is zero), it interprets that as a concurrency conflict.

- Configure the Entity Framework to include the original values of every column in the table in the Where clause of Update and Delete commands.
  As in the first option, if anything in the row has changed since the row was first read, the Where clause won't return a row to update, which the Entity Framework interprets as a concurrency conflict. For database tables that have many columns, this approach can result in very large Where clauses, and can require that you maintain large amounts of state. As noted earlier, maintaining large amounts of state can affect application performance. Therefore this approach is generally not recommended, and it isn't the method used in this project.

# Database diagram

![image](https://user-images.githubusercontent.com/47561143/202743079-d38fe884-c1d8-4769-9f48-8212aa8c2526.png)
