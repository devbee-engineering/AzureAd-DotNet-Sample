# Azure AD Authentication with .NET Core and Swagger UI

## Introduction

This sample project demonstrates how to configure Azure Active Directory (Azure AD) authentication for a .NET Core application. It also includes Swagger UI for easy interaction with single sign-on (SSO).

## Prerequisites

Before you begin, make sure you have the following:

- [Azure AD](https://azure.microsoft.com/en-us/services/active-directory/) account and application registered.
- [.NET Core SDK](https://dotnet.microsoft.com/download) installed.
- [Visual Studio Code](https://code.visualstudio.com/) or your preferred code editor.
- [Postman](https://www.postman.com/) or a similar tool for testing.

## Project Setup

1. Clone this repository:

   ```shell
   git clone https://github.com/yourusername/azure-ad-dotnet-core-swagger.git
   cd azure-ad-dotnet-core-swagger
2. Open the project in your code editor.
3. Update the `appsettings.json` file with your Azure AD application details:
```json
"AzureAd": {
    "Instance": "https://login.microsoftonline.com/",
    "Domain": "yourtenant.onmicrosoft.com",
    "TenantId": "your-tenant-id",
    "ClientId": "your-client-id",
    "CallbackPath": "/signin-oidc"
}
```
4. Build and run the application:
```shell
dotnet build
dotnet run
```

## Azure AD Configuration

Follow these steps to configure Azure AD for the application:

1. Sign in to the Azure portal.
2. Create a new Azure AD application.
3. Configure the application with the appropriate redirect URIs.
4. Note the Client Id and Tenant Id and update the appsettings.json file in your project.

## Swagger UI

1. refer [LaunchSettings.json](./AdTest/Properties/launchSettings.json) for multiple launch options.
2. with IIS Express swagger ui is accessible at https://localhost:44303/swagger/index.html

## Demo

![Demo](./media/Demo.gif)