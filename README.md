# Test-Apply

# Order Management System
Let's build a very simple order management system having orders from pending up to completed state.

## Requirements

An order has a control number and a state.

When the order is added to the system, it has a pending state.

I want to be able to start the progress of an order.

I want to be able to complete an order.

I want to filter orders by number control and state.

## Invariants
A pending order can only go to in progress state.

An in progress order can only go to completed.

Completed orders are done and should preserve its state.

## Instructions
Create a github repo to develop your solution.


PS 1: Using a css library/framework is a plus.

PS 2: Tests are needed.

PS 3: We’ll evaluate everything from the git history to the implemented code.


###### ###### ###### ###### ###### ###### ###### ###### ###### ###### ###### ###### 

#### CLI New Project
dotnet new web -o TestApply --framework net6.0

#### CLI Entity Framework Core Reference 
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0

#### CLI MySql Entity Framework Reference 
dotnet add package MySql.EntityFrameworkCore --version 6.0.1

#### CLI Entity Framework Core Tools Reference 
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.0

# MySql Database Scaffolding
dotnet tool install --global dotnet-ef

# Pages
dotnet new page -n Index        -na TestApply.Pages           -o Pages

dotnet new page -n Index        -na TestApply.Pages.Register      -o Pages/Register