# Abstract Factory Design Pattern

Bu örnek, Abstract Factory tasarım deseni kullanarak farklı logger türlerinin yaratılmasını ve kullanılmasını gösterir.

## Genel Bakış

![Abstract Factory Design Pattern](https://github.com/ozlematayy/design-patterns/assets/77455910/2f1cdefe-fc99-49f1-9d99-def45070be13)

Bu kod örneği, logger (günlük kayıt) işlevselliği sağlayan bir Abstract Factory tasarım desenini içerir. `ILogger` arayüzü, loglama işlevlerini tanımlar ve bu arayüzü implemente eden farklı logger sınıfları bulunur. `ILoggerFactory` arayüzü ise `ILogger` nesnelerinin yaratılmasını sağlayan bir yöntem içerir.

## Yapı

- `ILogger`: Loglama işlevselliğini tanımlayan arayüz.
- `FileLogger`, `NetworkLogger`: `ILogger` arayüzünü uygulayan farklı logger sınıfları.
- `ILoggerFactory`: `ILogger` nesnelerini yaratmayı tanımlayan arayüz.
- `FileLoggerFactory`, `NetworkLoggerFactory`: `ILoggerFactory` arayüzünü implemente eden fabrika sınıfları, farklı logger türlerini yaratır.

## Nasıl Kullanılır

1. `LoggingClient` sınıfı, `ILoggerFactory`'den gelen fabrika sınıflarını kullanarak logger nesnelerini oluşturur.
2. `LogMessage` metodu üzerinden loglama işlemini gerçekleştirir.
3. `Main` fonksiyonunda, farklı logger türlerini kullanarak loglama işlemi örneklenir.

## Nasıl Çalıştırılır

1. Proje dosyalarını indirin/klonlayın.
2. Çalıştırmak için bir C# derleyici kullanarak veya bir C# IDE'sinde projeyi açarak `Program.cs` dosyasını çalıştırın.

