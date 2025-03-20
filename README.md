# FashionStore

FashionStore is an e-commerce website designed to provide users with a seamless online shopping experience for fashion products. Built using C# and HTML, this project showcases a responsive and user-friendly interface for browsing and purchasing clothing items.

## Features

- **User Registration and Authentication**: Users can create accounts and securely log in to access personalized features.
- **Product Catalog**: Browse a wide range of fashion products categorized for easy navigation.
- **Product Search**: Search functionality to quickly find desired items.
- **Shopping Cart**: Add products to the cart and manage quantities before proceeding to checkout.
- **Order Management**: Users can view their order history and track current orders.

## Technologies Used

- **Backend**: C#
- **Frontend**: HTML,CSS, Razor Pages, Bootstrap
- **Framework**: ASP.NET Core MVC
- **Database**: SQL Server
- **ORM**: Entity Framework Core

## Installation

To set up the project locally:

1. **Clone the repository**:

   ```bash
   git clone https://github.com/Sowmyak059/FashionStore.git
   ```

2. **Navigate to the project directory**:

   ```bash
   cd FashionStore
   ```

3. **Open the solution file**: Use Visual Studio to open `FashionStore.sln`.

4. **Set up**:
   - Configure the database connection string in `appsettings.json`.
   - Apply migrations using Entity Framework Core:
     ```bash
     Install-Package Microsoft.EntityFrameworkCore
     Install-Package Microsoft.EntityFrameworkCore.SqlServer
     Install-Package Microsoft.EntityFrameworkCore.Tools
     Install-Package Microsoft.EntityFrameworkCore.Design
     Install-Package Microsoft.AspNetCore.Mvc
     Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
     add-migration AddMigrationName
     update-database
     ```

5. **Build and run the project**: Use Visual Studio's build and run features to start the application.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is purely for learning purpose.

## Acknowledgements

- **Inspiration**: This project was inspired by the need for a simple yet functional fashion e-commerce platform.
- **Resources**: Special thanks to the open-source community for providing valuable resources and tools.

