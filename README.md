# Level-Tabanl-3D-Parkur-Oyunu-
Unity ile geliştirilmiştir 3D Masaüstü sürümler için geçerlidir
[README.md](https://github.com/user-attachments/files/26632035/README.md)
# 🏃‍♂️ Level Tabanlı Parkur Oyunu (Unity)

## Proje Hakkında
Bu proje, Unity kullanılarak geliştirilmiş level tabanlı bir 3D parkur oyunudur. Oyuncu engellerden kaçarak, coin toplayarak ve seviyeyi tamamlayarak ilerler.

## Oynanış
- Oyuncu sürekli ileri hareket eder.
- Sağ-sol hareket yapılabilir.
- Zıplama mekaniği vardır.
- Engellere çarpınca can azalır.
- Coin toplayarak puan kazanılır.
- Seviyeyi bitirince sonraki levele geçilir.
- Ölünce Retry ekranı açılır.

## Klasör Yapısı
```
Assets/
└── Scripts/
    ├── Camera/
    │   └── CameraController.cs
    ├── Managers/
    │   ├── GameManager.cs
    │   ├── LevelCompleteManager.cs
    │   └── RetryManager.cs
    ├── Player/
    │   └── PlayerScript.cs
    ├── Systems/
    │   ├── CoinManager.cs
    │   ├── EngelManager.cs
    │   ├── FinishTrigger.cs
    │   └── HealthController.cs
    └── World/
        ├── RotateController.cs
        └── SpawnEnemy.cs
```

## Unity Kurulum Notları
- Player objesine `Player` tag'i ver.
- Zemin objelerine `Zemin` tag'i ver.
- Finish objesinin collider'ında `Is Trigger` açık olsun.
- Sahnede `RetryPanel` ve `LevelCompletePanel` oluşturup ilgili manager scriptlerine bağla.
- Build Settings içine sahneleri sırayla ekle: `MainMenu`, `Level1`, `Level2`, `Level3`.

## GitHub'a Yükleme
```bash
git init
git add .
git commit -m "Add core gameplay scripts for level based parkour game"
git branch -M main
git remote add origin https://github.com/kullaniciadi/parkur-oyunu.git
git push -u origin main
```

## Geliştirici
Enes Argama
Bilgisayar Mühendisliği Öğrencisi
