# Sprinkle Collection API – ASP.NET Core Project

A lightweight ASP.NET Core Web API that forwards collection requests to an external API service.  

This project was implemented during my full-stack internship (backend part) as part of learning real-world API communication, HTTP client usage, testing, and controller/service architecture.  

## 🚀 Features

### 1. ASP.NET Core Web API
- Uses `[ApiController]` and routing attributes.  
- Organized into Controller → Service → Models layers.  
- Clean separation of concerns.  

### 2. Forwarding External API Requests
- Sends POST requests to an external API endpoint.  
- JSON body sent using `PostAsJsonAsync`.  
- Response returned as raw JSON.  

### 3. Dependency Injection
- `GeocoderClient` injected as `IGeocoderClient`.  
- `HttpClient` managed by DI container.  
- Follows .NET best practices for reusable services.  

### 4. Options Pattern
- `ExternalApiOptions` stores configuration (`BaseUrl`) from `appsettings.json`.  
- Injected into the service via `IOptions<ExternalApiOptions>`.  

### 5. Asynchronous Programming
- `async/await` ensures non-blocking I/O.  
- Scalable API performance.  

### 6. Swagger Support
- Automatic API documentation and testing using Swagger UI.  

### 7. Postman Testing
- API requests were also tested using Postman collections.  
- Tokens and headers were managed in Postman to simulate authentication scenarios.  
- Postman responses were compared with Swagger output to verify correctness.  

### 8. Models
- `ExternalRequest` → request structure.  
- `Filter` / `FilterItem` → filtering rules.  
- `Page` → pagination settings.  
- `ExternalErrorResponse` → error handling structure.  
- `ExternalTokenResponse` → token handling model.  


