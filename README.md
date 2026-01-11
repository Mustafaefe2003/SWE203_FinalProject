# SWE203 Araç Kiralama Projesi - Mustafa Efe Cebel

Hocam merhaba, bu proje benim Nesneye Yönelik Programlama dersi için hazırladığım final çalışmasıdır. Projenin amacı, bir araç kiralama sürecini kod üzerinden simüle etmektir.

## Kod Yapısını Nasıl Kurdum?

Projeyi 4 ana dosya üzerinden kurguladım:
* **Araba.cs:** Araçların model, marka ve fiyat bilgilerini tuttuğum yer. Burada fiyatların hatalı girilmemesi için basit bir kontrol mekanizması (Kapsülleme) kullandım.
* **Musteri.cs:** Müşterinin ehliyet tecrübesini tutuyor. Tecrübe yılını elle girmek yerine, sistemin yılından ehliyet alış yılını çıkararak hesaplattım.
* **KiralamaServisi.cs:** Burası işin mutfağı. Aracın uygun olup olmadığını ve müşterinin tecrübesinin yetip yetmediğini kontrol eden sınıf burasıdır.
* **Program.cs:** Yazdığım bu sınıfları test ettiğim ana ekran.

## Geliştirme Sürecim Hakkında

Ödevi yaparken özellikle tarih hesaplamaları ve sınıflar arası bağlantı kurma kısımlarında bazı hatalar aldım. Bu hataları çözmek ve mantığı daha iyi oturtmak için yapay zekadan (Gemini) yardım aldım. 

Aldığım bu yardımı; kodun mantığını anlamak, syntax (yazım) hatalarımı düzeltmek ve daha temiz bir kod yapısı oluşturmak için bir "öğrenme asistanı" gibi kullandım. Bu sayede takıldığım noktaları nasıl çözeceğimi öğrenmiş oldum.

---
**Çalıştırma Notu:** `Program.cs` dosyası üzerinden projeyi başlatabilirsiniz. Örnek bir kiralama senaryosu konsol ekranında görünecektir.
## Nasıl Çalıştırılır?
`Program.cs` dosyasını açıp F5'e basmanız yeterli. İçeride örnek bir müşteri ve araba tanımladım, sistem otomatik olarak kiralama yapıp yapamayacağınızı ekrana yazıyor.
