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

- AddProduct
    
    ![addproduct](https://user-images.githubusercontent.com/44196434/163218894-f8abe643-b28c-488b-ba3e-fcb71164a2b3.png)

- GetProducts
    
    ![getproducts](https://user-images.githubusercontent.com/44196434/163218989-96e5b16f-989d-4078-ba38-9fb3d9e68461.png)

- GetProductById

    ![getbyid](https://user-images.githubusercontent.com/44196434/163219053-100826a3-cff8-46a5-931f-978f2526e50c.png)

- GetProductByName

    ![getbyname](https://user-images.githubusercontent.com/44196434/163219107-0749925d-3b7b-433a-a5f7-df516a236203.png)

- UpdateProduct

    ![updateproduct](https://user-images.githubusercontent.com/44196434/163219176-2f6dd1c3-338c-4fd2-900c-5af4b318bd0e.png)

- DeleteProduct

    ![deleteproduct](https://user-images.githubusercontent.com/44196434/163219210-48e3d5be-7235-47f0-bfdd-c28006dfdf24.png)

    
