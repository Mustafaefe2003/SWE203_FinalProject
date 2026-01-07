# SWE203 Araç Kiralama Projesi

Bu proje benim Nesneye Yönelik Programlama dersi için hazırladığım final ödevim. C# kullanarak basit ama mantıklı bir araç kiralama sistemi kurmaya çalıştım.

## Projeyi Nasıl Tasarladım?

Kodları yazarken derste gördüğümüz şu mevzulara dikkat ettim:
- **Kapsülleme (Encapsulation):** Mesela araba fiyatını veya ehliyet yılını herkes kafasına göre değiştiremesin diye `set` bloklarına kontroller koydum. Eksi fiyat girilirse sistem hata vermesin diye taban fiyat atadım.
- **Otomatik Hesaplamalar:** Arabanın yaşını veya adamın kaç yıllık şoför olduğunu elle girmekle uğraşmadım; sistemin yılından üretim yılını çıkarıp otomatik hesaplattım.
- **Kiralama Mantığı:** Kiralama işini direkt sınıfların içine gömmek yerine `KiralamaServisi` diye bir yer yaptım. Bütün kontrolü orası yapıyor (ehliyet süresi yetiyor mu, araba boş mu vb.).

## Dürüstlük Köşesi: Yapay Zeka (AI) Kullanımı

Hocam, bu projeyi geliştirirken takıldığım yerlerde ve bazı hataları çözmekte Gemini gibi yapay zeka araçlarından destek aldım. Bunu belirtmek istedim çünkü:

1. Kendi yazdığım kodlarda bazen "syntax" hataları aldım, bunları nasıl düzelteceğimi AI sayesinde hızlıca öğrendim.
2. Yazdığım mantığın (mesela ehliyet yılı kontrolü) daha sağlam olması için "Şöyle bir senaryoda bu kod patlar mı?" diye yapay zekaya danıştım ve hatalarımı düzelttim.
3. Bazı yerlerde kodun daha temiz görünmesi için tavsiyeler aldım.

Kısacası; kodun temelini ve mantığını ben kurdum, yapay zekayı ise yanımda duran bir asistan veya hata ayıklayıcı gibi kullandım. Bu sayede takıldığım yerleri başkasına sormak yerine araştırarak ve sorarak kendim çözmüş oldum. Şu an kodun neresinde ne dönüyor hepsine hakimim.

## Nasıl Çalıştırılır?
`Program.cs` dosyasını açıp F5'e basmanız yeterli. İçeride örnek bir müşteri ve araba tanımladım, sistem otomatik olarak kiralama yapıp yapamayacağınızı ekrana yazıyor.
