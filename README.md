# Bethany-Pie-Shop
PieShoop"

This source codes are learning outcome of PluralSight, Asp.Net Core Web Application and instruct by Gill Cleeren.

The codes are written with VisualStudio 2017, and built with ASP.Net Core 2.0 on Oct 6, 2017. 


This codes is finished product so if you are deployoing on Azure, make sure you insert your database connection string in appsettings.production.json file. If you are working locally, it should be fine.

The author is very good at explaination. His explaination are clear and concise.

If you are interesed this course, please go to www.pluralsight.com. Unfortunately, it's not free.

===========================================================================

## To Update PieShop .Net Core 1.1 to .Net Core 2.0 

### 1. Start your visual studio 2017. (You may also created in command prompt by using DOTNET commandline tool). 
Click "New Project" then Select "ASP.Net Core Web Application"
![newproj_1](https://user-images.githubusercontent.com/15990617/31258857-c33fa746-aa9e-11e7-9afe-edb4ec707d62.JPG)


### 2. Select "Web Application (Model-View-Controller). Make sure you select .NET Core and ASP.NET Core 2.0 

![mvc](https://user-images.githubusercontent.com/15990617/31258946-774fbb54-aa9f-11e7-906b-60870c653333.JPG)


### Change the followings.

### 4. Migration Issues: 

I was struggling with Migration at "Adding Data with EF Core" module in ASP.Net Core 2.0

#### 1. Packages has to be same in your .csproj : To edit ".csproj" => Right Click on your Project Solution in VisualStudio => Select "Edit <projectName>.csproj"

![csproj](https://user-images.githubusercontent.com/15990617/31258132-87caaf8a-aa99-11e7-8475-b986966677bc.JPG)


#### 2. Both hilighted names has to be same some home (This might not be an issue for you)

![appsettings](https://user-images.githubusercontent.com/15990617/31258043-ca7f2dca-aa98-11e7-9ac1-3b271933936c.JPG)


#### 3. See the changes in DbInitializer.cs, Startup.cs and Program.cs  files. Some of the codes must change in order to work with .Net Core 2.0. 

#### 4. $ "Add-Migration <Name> " and $ "Update-Database" inside the "Package Manager Console"
![migration](https://user-images.githubusercontent.com/15990617/31258398-706806c4-aa9b-11e7-9db0-3537afa76f02.JPG)

===========================================================================

## To Run the Project in Command Prompt (Terminal)
1. Go to the Solution where you store this project (E. cd E:\Programing\ASP .Net\PieShop_MVC_Core_2\PieShop_MVC_Core_2).
   Note: The file path may different on location of your project. 
   
   Run the following ### Commands (You need to set the Environment Path to run DOTNET COMMANDS  : 
      
   1. $ dotnet restore
   2. $ dotnet watch run 
      is a middleware that you don't have to recompile when you make changes in your code. You may need to run ### "dotnet restore" 
      when you added the new C# files. 
      
![dotnet](https://user-images.githubusercontent.com/15990617/31258682-688fff04-aa9d-11e7-8c7f-96597378dff9.JPG)
      



