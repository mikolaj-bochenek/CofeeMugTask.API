## Getting Started

Hello! 👋 This is a job interview task written in C# and ASP.NET Core 3.0

### Running Application

1. Clone this repository
2. Update database (sqlserver) using dotnet CLI in project folder - dotnet ef database update
3. Then run the application - dotnet run
4. API will start up on http://localhost:5000
5. Use an HTTP client like Postman to test API 💰

## Running the tests

Add One Product - [POST] http://localhost:500/api/v1/product
![jeden](https://user-images.githubusercontent.com/60287968/74372514-0e38c700-4ddb-11ea-9162-da61f1546856.png)

Get One Product - [GET] http://localhost:500/api/v1/product/{productId}
![trzy](https://user-images.githubusercontent.com/60287968/74372624-450edd00-4ddb-11ea-9e4b-08144cc591a2.png)

Get All Products - [GET] http://localhost:500/api/v1/product
![cztery](https://user-images.githubusercontent.com/60287968/74372756-7c7d8980-4ddb-11ea-9c8a-cf948653ed8f.png)

or [GET] http://localhost:500/api/v1/productPageNumber=1&PageSize=10&OrderBy=Expensive
(product can also be ordered by Id(default), alphabetically, from the cheapest)
![piec](https://user-images.githubusercontent.com/60287968/74372844-a9ca3780-4ddb-11ea-8455-d9ba155c2b84.png)

Update One Product - [PUT] http://localhost:500/api/v1/product
![szesc](https://user-images.githubusercontent.com/60287968/74372940-cf574100-4ddb-11ea-998e-2adb46793547.png)

Delete One Product - [DELETE] http://localhost:500/api/v1/product/{productId}
![siedem](https://user-images.githubusercontent.com/60287968/74373000-ea29b580-4ddb-11ea-8aba-f7a51c44f83d.png)


## Deployment

Add additional notes about how to deploy this on a live system

## Authors

* [**Mikołaj Bochenek**](https://github.com/Mikolaj-Bochenek)

## License

No license
