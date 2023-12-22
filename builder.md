# Builder Design Pattern

Bu örnek C# kullanarak Builder tasarım desenini basit bir log oluşturma senaryosunda göstermektedir.

## Genel Bakış

![builder](https://github.com/ozlematayy/design-patterns/assets/77455910/2cc83692-94c2-4b1e-8531-8d6fb2e27bc0)

Builder tasarım deseni, karmaşık bir nesne oluşturulurken adım adım bir yaklaşım sağlar. Bu desen, bir nesne oluşturma sürecini parçalara böler ve farklı adımların farklı özellikleri atamasına izin verir. 

## Yapı

- `Log` (Product): Oluşturulan logların temsil edildiği bir yapıdır. Bu sınıf, log mesajını ve log seviyesini içerir.
- `ILogBuilder` (Builder Interface): Log oluşturma işlemlerini yönetmek için kullanılır. Bu arayüz, log mesajı, log seviyesi ve log nesnesinin oluşturulması için metotları içerir.
- `FileLogBuilder`,`EmailLogBuilder` (Concrete Builder): `ILogBuilder` arayüzünü uygulayan bir sınıftır. Dosyaya loglama işlemini gerçekleştirir. 
- `LogManager` (Director Class): Log oluşturma işlemlerini yönetir. `ILogBuilder` tipinde bir builder örneği alır ve `BuildLog` metoduyla log oluşturma işlemini gerçekleştirir.
- `Program`: Builder tasarım deseninin kullanımını gösterir. Önce `FileLogBuilder` ve `EmailLogBuilder` ile log oluşturma işlemleri gerçekleştirilir. Her bir builder için farklı loglar oluşturulur ve oluşturulan loglar ekrana yazdırılır.

## Nasıl Kullanılır

Kodun çalıştırılması şu adımları içerir:

1. İlgili builder sınıfının örneği oluşturulur.
2. LogManager sınıfı, oluşturulan builder sınıfı ile log oluşturma işlemini gerçekleştirir.
3. Oluşturulan loglar ekrana yazdırılır.

## Nasıl Çalıştırılır

1. Proje dosyalarını indirin/klonlayın.
2. Çalıştırmak için bir C# derleyici kullanarak veya bir C# IDE'sinde projeyi açarak `Program.cs` dosyasını çalıştırın.
