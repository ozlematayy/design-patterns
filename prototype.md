# Prototype Design Pattern

Bu örnek, Prototype tasarım desenini kullanarak bir loglama sistemi oluşturur. Bu desen, bir nesnenin prototipini kullanarak yeni nesneler oluşturmak için bir mekanizma sağlar.

## Genel Bakış

![prototype](https://github.com/ozlematayy/design-patterns/assets/77455910/7423f6d2-dd00-47e6-8e2c-d71c1afcf77a)

## Yapı
- `Logger` soyut sınıfı, klonlama işlemi ve loglama metodunu içerir.
- `FileLogger` sınıfı, bu soyut sınıftan türetilir ve kendi loglama işlemini gerçekleştirir.
- `Client` sınıfı, prototip desenini kullanarak `FileLogger` örneğini oluşturur ve klonlama yoluyla bu örneği çoğaltır.
- Kodu çalıştırdığınızda, `FileLogger` örneğinin bir kopyasını oluşturur ve her iki örneğin log dosya yollarını gösterir.

## Nasıl Çalıştırılır
1. Proje dosyalarını indirin/klonlayın.
2. Çalıştırmak için bir C# derleyici kullanarak veya bir C# IDE'sinde projeyi açarak `Program.cs` dosyasını çalıştırın.
