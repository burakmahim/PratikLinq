// Rastgele 10 adet sayıdan oluşan liste
List<int> numbers = new List<int> { -10, 5, 8, -3, 15, 21, 18, 7, -4, 20 };

// Çift olan sayılar
var evenNumbers = numbers.Where(n => n % 2 == 0);
Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));

// Tek olan sayılar
var oddNumbers = numbers.Where(n => n % 2 != 0);
Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

// Negatif sayılar
var negativeNumbers = numbers.Where(n => n < 0);
Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

// Pozitif sayılar
var positiveNumbers = numbers.Where(n => n > 0);
Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

// 15'ten büyük ve 22'den küçük sayılar
var rangeNumbers = numbers.Where(n => n > 15 && n < 22);
Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", rangeNumbers));

// Listedeki her bir sayının karesi
var squaredNumbers = numbers.Select(n => n * n).ToList();
Console.WriteLine("Sayıların Kareleri: " + string.Join(", ", squaredNumbers));