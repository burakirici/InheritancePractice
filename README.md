
# OgrenciOgretmenBilgiSistemi

Bu proje, `Ogrenci` ve `Ogretmen` sınıflarının miras aldığı `BaseKisi` adlı soyut bir sınıf kullanarak basit bir bilgi sistemi oluşturmayı amaçlamaktadır. `Ogrenci` ve `Ogretmen` sınıfları, `BaseKisi` sınıfından türetilmiş olup kendi benzersiz özelliklerini ve davranışlarını içerirler.

## İçindekiler

- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Sınıflar ve Özellikler](#sınıflar-ve-özellikler)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Kurulum

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. Bu projeyi klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/OgrenciOgretmenBilgiSistemi.git
   ```
2. Proje dizinine gidin:
   ```bash
   cd OgrenciOgretmenBilgiSistemi
   ```
3. Projeyi Visual Studio veya tercih ettiğiniz bir IDE'de açın.

## Kullanım

Projeyi çalıştırmak için `Program.cs` dosyasını çalıştırın. Bu dosya, `Ogrenci` ve `Ogretmen` nesnelerinin oluşturulması ve bilgilerin yazdırılması işlemlerini içerir.

Örnek çıktı:
```plaintext
Salary:  129 Teacher Name:  Burak Teacher Surname:  DahaKırıcı
Student Name:  Burak Surname:  Kırıcı Student ID Number:  1017
```

## Sınıflar ve Özellikler

### BaseKisi
- `Name`: Kişinin adı.
- `SurName`: Kişinin soyadı.
- `WriteInfo()`: Soyut metod, türetilen sınıflarda uygulanır.

### Ogrenci (BaseKisi'den türetilmiştir)
- `Id`: Öğrenci kimlik numarası.
- `WriteInfo()`: Öğrenci bilgilerini yazdıran metod.

### Ogretmen (BaseKisi'den türetilmiştir)
- `Earnings`: Öğretmenin maaşı.
- `WriteInfo()`: Öğretmen bilgilerini yazdıran metod.

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request oluşturun veya bir sorun bildirerek projenin gelişmesine yardımcı olun.


