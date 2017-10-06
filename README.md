# Bethany-Pie-Shop
PieShoop"

This source codes are learning outcome of PluralSight, Asp.Net Core Web Application and instruct by Gill Cleeren.

The codes are written with VisualStudio 2017, and built with ASP.Net Core 2.0 on Oct 6, 2017. 


This codes is finished product so if you are deployoing on Azure, make sure you insert your database connection string in appsettings.production.json file. If you are working locally, it should be fine.

The author is very good at explaination. His explaination are clear and concise.

If you are interesed this course, please go to www.pluralsight.com. Unfortunately, it's not free.

===========================================================================

### Migration Issues: 

I was struggling with Migration at "Adding Data with EF Core" module in ASP.Net Core 2.0

### 1. Packages has to be same in your .csproj : To edit ".csproj" => Right Click on your Project Solution in VisualStudio => Select "Edit <projectName>.csproj"

![csproj](https://user-images.githubusercontent.com/15990617/31258132-87caaf8a-aa99-11e7-8475-b986966677bc.JPG)


### 2. Both hilighted names has to be same some home (This might not be an issue for you)

![appsettings](https://user-images.githubusercontent.com/15990617/31258043-ca7f2dca-aa98-11e7-9ac1-3b271933936c.JPG)


### 3. See the changes in DbInitializer.cs, Startup.cs and Program.cs  files.

### 4. $ "Add-Migration <Name> " and $ "Update-Database" inside the "Package Manager Console"
![migration](https://user-images.githubusercontent.com/15990617/31258398-706806c4-aa9b-11e7-9db0-3537afa76f02.JPG)

===========================================================================




