# Product API

1.Hafta ödevimiz bir API oluşturmak ve burada CRUD işlemlerini yapmak.

Ekstra olarak Validasyon işlemleri ve ürün ismi ile ürün arama işlemi eklenecek.

# Paketler

    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.InMemory
    dotnet add package Microsoft.Extensions.DependencyInjection
    dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
    dotnet add package AutoMapper
    dotnet add package FluentValidation.AspNetCore
    dotnet add package Newtonsoft.Json

# Endpoints

|HTTP|URL|METOT|
|---|---|---|
|GET| https://localhost:44303/api/products |GetProducts|
|GET| https://localhost:44303/api/products/id |GetProductById|
|GET| https://localhost:44303/api/products/name?value=deneme |GetProductByName|
|PUT| https://localhost:44303/api/products/id |UpdateProduct|
|POST| https://localhost:44303/api/products |AddProduct|
|DELETE| https://localhost:44303/api/products/id |DeleteProduct|

# Ekran Görüntüleri

