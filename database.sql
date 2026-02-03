USE [HastaneDB2]
GO

IF OBJECT_ID('[dbo].[Hastalar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hastalar];
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hastalar](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [TC] [nvarchar](11) NOT NULL,
    [Ad] [nvarchar](50) NOT NULL,
    [Soyad] [nvarchar](50) NOT NULL,
    [Cinsiyet] [nvarchar](10) NOT NULL,
    [KanGrubu] [nvarchar](10) NOT NULL,
    [Yas] [int] NOT NULL,
    [HastalikTanisi] [nvarchar](100) NOT NULL,
    [YatisTarihi] [date] NOT NULL,
    [SaglikSigortasi] [bit] NOT NULL,
    [TaburcuEdildi] [bit] NOT NULL DEFAULT ((0)),
    [TaburcuTarihi] [date] NULL,
    CONSTRAINT [PK_Hastalar] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CHK_HastaYas] CHECK ([Yas] >= 0 AND [Yas] <= 135)
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Hastalar] ON 
GO

INSERT [dbo].[Hastalar] ([Id], [TC], [Ad], [Soyad], [Cinsiyet], [KanGrubu], [Yas], [HastalikTanisi], [YatisTarihi], [SaglikSigortasi], [TaburcuEdildi], [TaburcuTarihi]) VALUES 
(1, N'12345678901', N'Ali', N'Yılmaz', N'Erkek', N'A Rh+', 24, N'Grip', CAST(N'2026-01-25' AS Date), 1, 0, NULL),
(2, N'10000000001', N'Ahmet', N'Yılmaz', N'Erkek', N'A Rh+', 36, N'Grip', CAST(N'2025-01-10' AS Date), 1, 1, CAST(N'2026-01-26' AS Date)),
(3, N'10000000002', N'Ayşe', N'Demir', N'Kadın', N'0 Rh+', 28, N'Migren', CAST(N'2025-01-12' AS Date), 1, 0, NULL),
(4, N'10000000003', N'Mehmet', N'Kaya', N'Erkek', N'B Rh+', 52, N'Hipertansiyon', CAST(N'2025-01-08' AS Date), 1, 0, NULL),
(5, N'10000000004', N'Fatma', N'Çelik', N'Kadın', N'A Rh-', 41, N'Astım', CAST(N'2025-01-15' AS Date), 0, 0, NULL),
(6, N'10000000005', N'Ali', N'Şahin', N'Erkek', N'AB Rh+', 60, N'Diyabet', CAST(N'2025-01-05' AS Date), 1, 0, NULL),
(7, N'10000000006', N'Zeynep', N'Arslan', N'Kadın', N'0 Rh-', 19, N'Anemi', CAST(N'2025-01-18' AS Date), 1, 0, NULL),
(8, N'10000000007', N'Mustafa', N'Koç', N'Erkek', N'B Rh-', 47, N'Böbrek Taşı', CAST(N'2025-01-03' AS Date), 0, 0, NULL),
(9, N'10000000008', N'Elif', N'Aydın', N'Kadın', N'A Rh+', 33, N'Sinüzit', CAST(N'2025-01-20' AS Date), 1, 0, NULL),
(10, N'10000000009', N'Hüseyin', N'Öztürk', N'Erkek', N'0 Rh+', 55, N'Kalp Yetmezliği', CAST(N'2025-01-02' AS Date), 1, 0, NULL),
(11, N'10000000010', N'Merve', N'Polat', N'Kadın', N'AB Rh-', 26, N'Gastrit', CAST(N'2025-01-22' AS Date), 1, 0, NULL),
(13, N'10000000017', N'Derya', N'Taş', N'Kadın', N'0 Rh+', 42, N'Romatizma', CAST(N'2025-01-11' AS Date), 1, 0, NULL),
(14, N'10000000018', N'Okan', N'Bulut', N'Erkek', N'B Rh+', 24, N'Tonsillit', CAST(N'2025-01-23' AS Date), 1, 0, NULL),
(16, N'10000000020', N'İsmail', N'Karaca', N'Erkek', N'A Rh-', 63, N'Prostat', CAST(N'2025-01-06' AS Date), 1, 0, NULL),
(17, N'10000000021', N'Pınar', N'Uslu', N'Kadın', N'0 Rh-', 35, N'Alerji', CAST(N'2025-01-17' AS Date), 1, 0, NULL),
(18, N'10000000022', N'Volkan', N'Sezer', N'Erkek', N'B Rh-', 49, N'Safra Taşı', CAST(N'2025-01-09' AS Date), 0, 0, NULL),
(19, N'10000000023', N'Gül', N'Yalçın', N'Kadın', N'A Rh+', 27, N'İdrar Yolu Enfeksiyonu', CAST(N'2025-01-24' AS Date), 1, 0, NULL),
(21, N'10000000025', N'Esra', N'Doğan', N'Kadın', N'AB Rh-', 31, N'Tiroid', CAST(N'2025-01-18' AS Date), 1, 0, NULL),
(22, N'10000000028', N'Nurat', N'Tekin', N'Erkek', N'0 Rh-', 46, N'Fıtık', CAST(N'2026-01-09' AS Date), 1, 0, NULL),
(23, N'12312312', N'Ali', N'Deniz', N'Erkek', N'B Rh-', 89, N'Grip', CAST(N'2026-01-25' AS Date), 1, 0, NULL),
(24, N'10000000031', N'Onur', N'Korkmaz', N'Erkek', N'A Rh+', 37, N'Soğuk Algınlığı', CAST(N'2025-01-26' AS Date), 1, 0, NULL),
(25, N'10000000032', N'Sibel', N'Ergin', N'Kadın', N'0 Rh+', 48, N'Bel Ağrısı', CAST(N'2025-01-14' AS Date), 1, 0, NULL),
(26, N'10000000033', N'Hakan', N'Bayram', N'Erkek', N'B Rh-', 56, N'Kolesterol', CAST(N'2025-01-05' AS Date), 1, 0, NULL),
(27, N'10000000034', N'Nermin', N'Şimşek', N'Kadın', N'AB Rh+', 62, N'Diz Kireçlenmesi', CAST(N'2025-01-03' AS Date), 1, 0, NULL),
(28, N'10000000035', N'Tolga', N'Akın', N'Erkek', N'A Rh-', 29, N'Üst Solunum Yolu Enfeksiyonu', CAST(N'2025-01-27' AS Date), 1, 0, NULL),
(30, N'10000000037', N'Serhat', N'Demirtaş', N'Erkek', N'B Rh+', 50, N'Karaciğer Yağlanması', CAST(N'2025-01-06' AS Date), 0, 0, NULL),
(31, N'10000000038', N'Aslı', N'Karadeniz', N'Kadın', N'A Rh+', 23, N'Demir Eksikliği', CAST(N'2025-01-28' AS Date), 1, 0, NULL),
(32, N'10000000039', N'Levent', N'Bozkurt', N'Erkek', N'0 Rh+', 64, N'Parkinson', CAST(N'2025-01-01' AS Date), 1, 0, NULL),
(33, N'10000000040', N'İlayda', N'Koşar', N'Kadın', N'AB Rh-', 27, N'Cilt Enfeksiyonu', CAST(N'2025-01-29' AS Date), 1, 1, CAST(N'2026-01-27' AS Date)),
(34, N'10000000041', N'Orhan', N'Mutlu', N'Erkek', N'A Rh+', 45, N'Omuz Çıkığı', CAST(N'2025-01-11' AS Date), 0, 0, NULL),
(35, N'10000000042', N'Tuğçe', N'Önal', N'Kadın', N'B Rh+', 34, N'Sinir Sıkışması', CAST(N'2025-01-18' AS Date), 1, 0, NULL),
(36, N'10000000043', N'Halil', N'Yıldırım', N'Erkek', N'0 Rh-', 58, N'İnme', CAST(N'2025-01-04' AS Date), 1, 0, NULL),
(37, N'10000000044', N'Pelin', N'Efe', N'Kadın', N'A Rh+', 31, N'Uyku Bozukluğu', CAST(N'2025-01-22' AS Date), 1, 0, NULL),
(38, N'10000000045', N'Barış', N'Alkan', N'Erkek', N'B Rh+', 39, N'Kas Yırtığı', CAST(N'2025-01-16' AS Date), 0, 0, NULL),
(41, N'10000000100', N'Fesun', N'Deniz', N'Kadın', N'B Rh+', 123, N'Grip', CAST(N'2025-12-03' AS Date), 1, 0, NULL),
(42, N'10000000299', N'ahmet', N'Selim', N'Kadın', N'B Rh+', 12, N'Nezle', CAST(N'2026-01-26' AS Date), 1, 0, NULL);
GO

SET IDENTITY_INSERT [dbo].[Hastalar] OFF
GO