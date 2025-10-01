# C# Case Study - Programming Questions & Solutions

Bu proje, C# programlama dili ile ilgili çeşitli konuları kapsayan 5 soru ve bunların tam çözümlerini içermektedir. Her soru farklı bir C# konseptini (Exception Handling, OOP, Async Programming, LINQ, Polymorphism) göstermektedir.

## 📋 Sorular ve Çözümler

### 1. ✅ Try-Catch Yapısı (Exception Handling)
**Soru:** Aşağıdaki kod bloğunda oluşabilecek bir hatayı yakalayacak şekilde try-catch yapısını yazınız:
```csharp
int[] numbers = {1, 2, 3}; 
Console.WriteLine(numbers[5]);
```

**Çözüm:** IndexOutOfRangeException yakalanır ve kullanıcı dostu hata mesajı gösterilir.

### 2. ✅ Person Sınıfı (OOP Basics)
**Soru:** Person adında bir sınıf oluşturun:
- **Özellikler:** Name (string), Age (int)
- **Constructor** ile bu özellikleri atayın
- **Introduce** adında bir metod ekleyin ve "Merhaba, benim adım {Name} ve {Age} yaşındayım." mesajını döndürsün.

**Çözüm:** Model/Person.cs dosyasında tam implementasyon. Kullanıcıdan isim ve yaş alınır, Person objesi oluşturulur.

### 3. ✅ Asenkron Programlama (Parallel Tasks)
**Soru:** Aşağıdaki üç asenkron metodu tek seferde çalıştırmak ve tüm sonuçlar tamamlandığında ekrana yazdırmak için kodu yazın:
```csharp
Task<int> GetUserCountAsync();    // kullanıcı sayılarını döndüren metod
Task<int> GetOrderCountAsync();   // sipariş sayılarını döndüren metod
Task<int> GetProductCountAsync(); // ürün sayılarını döndüren metod
```

**Çözüm:** Service/CountService.cs ile async metodlar, Task.WhenAll() ile paralel çalıştırma.

### 4. ✅ LINQ GetMax Metodu (LINQ & Generics)
**Soru:** Bir listedeki tam sayı değerlerinden en büyüğünü döndüren metodu tamamlayınız:
```csharp
int? GetMax(List<int> list) { //… }
```

**Çözüm:** LINQ Max() metodu kullanılarak null-safe implementasyon.

### 5. ✅ OOP Polimorfizm (Interface-based Design)
**Soru:** Aşağıdaki kodda OOP hatası var. Düzeltilmiş ve polimorfik bir yapı yazınız:
```csharp
public class Animal { 
    public void MakeSound(string type) { 
        if(type == "Dog") Console.WriteLine("Hav"); 
        else if(type == "Cat") Console.WriteLine("Miyav"); 
    } 
}
```

**Çözüm:** IAnimal interface ile Dog ve Cat sınıfları. If-else yerine polimorfik yapı.

## 📁 Proje Yapısı

```
CaseStudy/
├── Program.cs              # Ana program ve menü sistemi
├── Model/
│   └── Person.cs          # Person sınıfı (Soru 2)
├── Service/
│   └── CountService.cs    # Async servis metodları (Soru 3)
├── Animals/
│   ├── Animal.cs          # IAnimal interface (Soru 5)
│   ├── Dog.cs            # Dog sınıfı
│   └── Cat.cs            # Cat sınıfı
├── README.md             # Bu dosya
└── .gitignore           # Git ignore kuralları
```

## 🚀 Kullanım

Projeyi çalıştırdığınızda interaktif bir menü sistemi açılır:

```
=== Question Selection Menu ===
1. First Question - Try-Catch Structure
2. Second Question - Person Class  
3. Third Question - Async Methods
4. Fourth Question - LINQ GetMax Method
5. Fifth Question - Polymorphic Structure
0. Exit
```

Her soru seçildiğinde:
- **Soru 1:** Try-catch örneği çalışır
- **Soru 2:** İsim/yaş girişi alır, Person objesi oluşturur
- **Soru 3:** 3 async metodu paralel çalıştırır
- **Soru 4:** Liste maksimum değerini LINQ ile bulur
- **Soru 5:** Polimorfik animal sesleri gösterir

## 🛠️ Teknik Detaylar

### Kullanılan C# Konseptleri:
- **Exception Handling:** try-catch-finally
- **OOP:** Classes, Interfaces, Inheritance
- **Async Programming:** Task, async/await, Task.WhenAll()
- **LINQ:** Max(), Any() metodları
- **Polymorphism:** Interface-based design
- **Generics:** List<T>, nullable types


## ⚙️ Gereksinimler

- .NET 8.0 veya üzeri
- C# 12.0

## 🏃‍♂️ Çalıştırma

```bash
# Projeyi çalıştır
dotnet run

# Build et
dotnet build

# Restore packages
dotnet restore
```
