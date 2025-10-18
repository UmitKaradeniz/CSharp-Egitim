# C# Eğitim Projesi 

Bu proje, C# ve Entity Framework öğrenirken yaptığım çalışmaları içermektedir.

##  Proje Hakkında

Bu projede bir seyahat yönetim sistemi geliştirilmiştir. Lokasyon, rehber, müşteri ve admin yönetimi yapılabilmektedir.

##  Kullanılan Teknolojiler

- **C# .NET Framework 4.7.2**
- **Entity Framework 6** (Database First)
- **Windows Forms** (WinForms)
- **SQL Server**

##  Proje Yapısı

Proje N-Katmanlı mimari (N-Tier Architecture) yaklaşımı ile geliştirilmiştir:

- **C#Egitim.EntityLayer**: Veritabanı entity sınıfları
- **C#Egitim.DataAccessLayer**: Veritabanı erişim katmanı
- **C#Egitim.BusinessLayer**: İş mantığı katmanı
- **C#Egitim.PresentationLayer**: Sunum katmanı
- **C#Egitim.EFProject**: Entity Framework ile örnek projeler

##  Veritabanı

Proje `C#EgitimTravelDb` adında bir SQL Server veritabanı kullanır.

### Tablolar:
- **Guide**: Rehber bilgileri
- **Location**: Lokasyon bilgileri (şehir, ülke, kapasite, fiyat vb.)
- **Customer**: Müşteri bilgileri
- **Admin**: Yönetici bilgileri

##  Kurulum

1. Projeyi klonlayın

2. SQL Server'da veritabanını oluşturun

3. Tabloları oluşturmak için aşağıdaki komutları çalıştırın

4. `App.config` dosyasındaki connection string'i kendi SQL Server bilgilerinize göre düzenleyin

5. Visual Studio'da solution'ı açın ve projeyi çalıştırın.

##  Kullanım

Proje başlatıldığında lokasyon yönetim formu açılır. Bu formda:
- Lokasyon listesi görüntülenebilir
- Yeni lokasyon eklenebilir
- Mevcut lokasyonlar güncellenebilir
- Lokasyonlar silinebilir


##  Geliştirici

Bu proje, C# öğrenim sürecim boyunca oluşturulmuştur.
