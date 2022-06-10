# WeatherApp

This is a weather app created using .NET Core 6.0 as Web API with user authentication system based on JWT (Json Web Token), Microsoft Identity, Entity Framework Core, SQL Serve and Angular 12 with HTML, CSS and Boostrap. Weather data is provided by free open API: https://openweathermap.org/. You can create a new account, reset your password, sign in and sign out. After signing in, you can check weather data for any city you enter in the search engine.

# Angular

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 12.2.11.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.



# ASP.NET Core Web API 

Run `dotnet restore` after getting the project on your machine

Run `dotnet run` to start the web API. Navigate to `https://localhost:5001/`.

Download ASP.NET Core SDK 6 

Make sure you have downloaded SQL Server express & SQL Server Management Studio
You also need to:
1. Provide e-mail address and password that will be used to send e-mails. Follow this instruction: 
 a) Go to Gmail account settings , and click on security tab
 b) add 2 step verification (if you don't have)
 c) click on "App Password"
 d) select application device or add new one
 e) you will get new password to use in your app
 f) Go to EmailService.cs and in "_client.Credentials" add your e-mail address and generated password
2. Run in package manager console:
 a)'enable-migrations'
 b) add-migration "comment"
 c) update-database

