# C# Case Study - Programming Questions

Bu proje, C# programlama dili ile ilgili çeşitli konuları kapsayan sorular ve çözümlerini içermektedir.

## Sorular

### 1. Try-Catch Yapısı
Aşağıdaki kod bloğunda oluşabilecek bir hatayı yakalayacak şekilde try-catch yapısını yazınız:
```csharp
int[] numbers = {1, 2, 3}; 
Console.WriteLine(numbers[5]);
```

### 2. Person Sınıfı
Person adında bir sınıf oluşturun:
- **Özellikler:** Name (string), Age (int)
- **Constructor** ile bu özellikleri atayın
- **Introduce** adında bir metod ekleyin ve "Merhaba, benim adım {Name} ve {Age} yaşındayım." mesajını döndürsün.

### 3. Asenkron Programlama
Aşağıdaki üç asenkron metodu tek seferde çalıştırmak ve tüm sonuçlar tamamlandığında ekrana yazdırmak için kodu yazın:
```csharp
Task<int> GetUserCountAsync();    // kullanıcı sayılarını döndüren metod
Task<int> GetOrderCountAsync();   // sipariş sayılarını döndüren metod
Task<int> GetProductCountAsync(); // ürün sayılarını döndüren metod
```

### 4. LINQ ve Generics
Bir listedeki tam sayı değerlerinden en büyüğünü döndüren aşağıdaki metodu tamamlayınız:
```csharp
int? GetMax(List<int> list) 
{ 
    //… 
}
```

### 5. OOP ve Polimorfizm
Aşağıdaki kodda OOP hatası var. Düzeltilmiş ve polimorfik bir yapı yazınız:
```csharp
public class Animal 
{ 
    public void MakeSound(string type) 
    { 
        if(type == "Dog") 
            Console.WriteLine("Hav"); 
        else if(type == "Cat") 
            Console.WriteLine("Miyav"); 
    } 
}
```

## Proje Yapısı

- `Program.cs` - Ana program dosyası, menü sistemi ve tüm soruların çözümlerini içerir
- `README.md` - Bu dosya, proje açıklaması ve sorular
- `.gitignore` - Git için ignore edilecek dosyalar

## Kullanım

Projeyi çalıştırdığınızda bir menü sistemi karşınıza çıkacak. 1-5 arası sayılar ile soruları seçebilir, 0 ile programdan çıkabilirsiniz.

```
=== Soru Seçim Menüsü ===
1. Birinci Soru - Try-Catch Yapısı
2. İkinci Soru
3. Üçüncü Soru
4. Dördüncü Soru
5. Beşinci Soru
0. Çıkış
```

## Gereksinimler

- .NET 8.0 veya üzeri
- C# 12.0

## Çalıştırma

```bash
dotnet run
```