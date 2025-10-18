# C# Eðitim Projesi ??

Bu proje, C# ve Entity Framework öðrenirken yaptýðým çalýþmalarý içermektedir.

## ?? Proje Hakkýnda

Bu projede bir seyahat yönetim sistemi geliþtirilmiþtir. Lokasyon, rehber, müþteri ve admin yönetimi yapýlabilmektedir.

## ??? Kullanýlan Teknolojiler

- **C# .NET Framework 4.7.2**
- **Entity Framework 6** (Database First)
- **Windows Forms** (WinForms)
- **SQL Server**

## ?? Proje Yapýsý

Proje N-Katmanlý mimari (N-Tier Architecture) yaklaþýmý ile geliþtirilmiþtir:

- **C#Egitim.EntityLayer**: Veritabaný entity sýnýflarý
- **C#Egitim.DataAccessLayer**: Veritabaný eriþim katmaný
- **C#Egitim.BusinessLayer**: Ýþ mantýðý katmaný
- **C#Egitim.PresentationLayer**: Sunum katmaný
- **C#Egitim.EFProject**: Entity Framework ile örnek projeler

## ??? Veritabaný

Proje `C#EgitimTravelDb` adýnda bir SQL Server veritabaný kullanýr.

### Tablolar:
- **Guide**: Rehber bilgileri
- **Location**: Lokasyon bilgileri (þehir, ülke, kapasite, fiyat vb.)
- **Customer**: Müþteri bilgileri
- **Admin**: Yönetici bilgileri

## ?? Kurulum

1. Projeyi klonlayýn:
```bash
git clone https://github.com/KULLANICI_ADINIZ/C#Egitim.git
```

2. SQL Server'da veritabanýný oluþturun:
```sql
CREATE DATABASE [C#EgitimTravelDb]
```

3. Tablolarý oluþturmak için aþaðýdaki komutlarý çalýþtýrýn:
```sql
CREATE TABLE Guide (
    GuideId INT PRIMARY KEY IDENTITY(1,1),
    GuideName NVARCHAR(50),
    GuideSurname NVARCHAR(50)
)

CREATE TABLE Location (
    LocationId INT PRIMARY KEY IDENTITY(1,1),
    City NVARCHAR(50),
    Country NVARCHAR(50),
    Capacity TINYINT,
    Price DECIMAL(18,0),
    DayNight NVARCHAR(50),
    GuideId INT,
    FOREIGN KEY (GuideId) REFERENCES Guide(GuideId)
)

CREATE TABLE Customer (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(50),
    CustomerSurname NVARCHAR(50),
    CustomerBalance DECIMAL(18,2)
)

CREATE TABLE Admin (
    AdminId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50),
    Password NVARCHAR(50)
)
```

4. `App.config` dosyasýndaki connection string'i kendi SQL Server bilgilerinize göre düzenleyin:
```xml
<add name="Entities2" 
     connectionString="data source=SUNUCU_ADINIZ;initial catalog=C#EgitimTravelDb;integrated security=True;..."
     providerName="System.Data.EntityClient" />
```

5. Visual Studio'da solution'ý açýn ve projeyi çalýþtýrýn.

## ?? Kullaným

Proje baþlatýldýðýnda lokasyon yönetim formu açýlýr. Bu formda:
- Lokasyon listesi görüntülenebilir
- Yeni lokasyon eklenebilir
- Mevcut lokasyonlar güncellenebilir
- Lokasyonlar silinebilir

## ?? Notlar

Bu proje eðitim amaçlý geliþtirilmiþtir ve sürekli güncellenebilir.

## ?? Geliþtirici

Bu proje, C# öðrenim sürecim boyunca oluþturulmuþtur.

---
? Bu proje faydalý olduysa yýldýz vermeyi unutmayýn!
