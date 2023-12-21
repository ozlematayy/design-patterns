# Factory Method Design Pattern

Bu örnek, Factory Method tasarım desenine benzer bir yapıyı gösterir. Kod, loglama işlevselliğini yaratmak için bir fabrika sınıfı kullanır.

## Genel Bakış

![Factory Method Design Pattern](https://github.com/ozlematayy/design-patterns/assets/77455910/6cec253b-3503-4b1d-864c-76e7b2dc1741)
Bu proje, loglama işlevselliğini yönetmek ve farklı logger türlerini kullanmak için bir yapı sunar. Factory Method tasarım desenine benzer bir yapı kullanılarak, `ILogger` arayüzü loglama işlevselliğini tanımlar ve bu arayüzü implemente eden `ConsoleLogger` ve `DatabaseLogger` sınıfları bulunur.

## Yapı

- `ILogger`: Loglama işlevselliğini tanımlayan arayüz.
- `ConsoleLogger`, `DatabaseLogger`: `ILogger` arayüzünü uygulayan farklı logger sınıfları.
- `LoggerFactory`:  Loglama işlevselliğini yaratan somut bir sınıf. `ILogger` nesnelerini döndüren bir metot içerir.
- `LoggingClient`: `LoggerFactory`'den gelen fabrika sınıfını kullanarak logger nesnelerini yaratır ve kullanır. Loglama işlemini gerçekleştirir.

## Nasıl Kullanılır

1. `LoggerFactory` sınıfını kullanarak `ILogger` nesneleri oluşturabilirsiniz.
2. `LoggingClient`, `LoggerFactory`'den gelen fabrika sınıflarını kullanarak logger nesnelerini oluşturur ve kullanır.
3. `Main` fonksiyonu içinde, farklı logger türlerini kullanarak loglama işlemi örneklenir.

## Nasıl Çalıştırılır

1. Proje dosyalarını indirin/klonlayın.
2. Çalıştırmak için bir C# derleyici kullanarak veya bir C# IDE'sinde projeyi açarak `Program.cs` dosyasını çalıştırın.
