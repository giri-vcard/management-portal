# MANAGEMENT-PORTAL

### Run
Before running an instance, configure `ConnectionStrings` in appsettings.Development.json first. The following is an example configuration 
```
{
  "ConnectionStrings": {
    "DatabaseConnection": "User ID = postgres; Password=postgres;Server=localhost;Port=5432;Database=dbname;Integrated Security=true; Pooling=true;"
  },
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  }
}
```