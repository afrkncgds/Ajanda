CREATE DATABASE Ajanda
GO

use Ajanda
GO

CREATE TABLE Kullanicilar (
  KullaniciId int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  KullaniciAd nvarchar(50) UNIQUE NOT NULL,
  Sifre nvarchar(50) NOT NULL,
  AdSoyad nvarchar(50),
  DogumTarihi datetime,
  Email nvarchar(50),
  Gsm nvarchar(50)
  )
  GO

CREATE TABLE Randevular ( 
  RandevuId int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  KullaniciAd nvarchar(50),
  RandevuTarih date,
  RandevuSaat time,
  Baslik nvarchar(50),
  Aciklama nvarchar(MAX)
  )
  GO

CREATE TABLE YapilacaklarListesi (
   ListeId int PRIMARY KEY NOT NULL IDENTITY(1, 1),
   KullaniciAd nvarchar(50),
   YapilacaklarTarih date,
   YapilacaklarSaat time,
   Baslik nvarchar(50),
   Aciklama nvarchar(MAX)
   )
   GO

ALTER TABLE Randevular ADD FOREIGN KEY (KullaniciAd) REFERENCES Kullanicilar (KullaniciAd)
GO

ALTER TABLE YapilacaklarListesi ADD FOREIGN KEY (KullaniciAd) REFERENCES Kullanicilar (KullaniciAd)
GO


INSERT INTO [dbo].[Kullanicilar]
           ([KullaniciAd]
           ,[Sifre]
           ,[AdSoyad]
           ,[DogumTarihi]
           ,[Email]
           ,[Gsm])
     VALUES
           ('morbulut'
           ,'123'
           ,'Eylem SAAT'
           ,'01-08-1995'
           ,'eylemsaat@gmail.com'
           ,'05521356242')
GO

