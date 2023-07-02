# Planer budżetu domowego/wydatków

## Opis

Aplikacja "Planer budżetu domowego/wydatków" jest prostym narzędziem konsolowym napisanym w języku C#, które umożliwia zarządzanie wydatkami i śledzenie budżetu domowego. Aplikacja umożliwia dodawanie, usuwanie i przeglądanie wydatków w różnych kategoriach, a także obliczanie sumy wydatków.

## Funkcjonalności

- Dodawanie wydatków w określonej kategorii (np. jedzenie, mieszkanie, transport) z podaniem kwoty i daty.
- Usuwanie wydatków.
- Wyświetlanie listy wydatków z podziałem na kategorie.
- Obliczanie sumy wydatków.
- Obliczanie sumy wydatków dla określonej kategorii.

## Użycie

Po uruchomieniu aplikacji użytkownik będzie mógł korzystać z następujących poleceń:

1. Dodawanie wydatku:
   ```
   add <kwota> <kategoria> <data>
   ```
   Przykład:
   ```
   add 50.00 jedzenie 2023-07-01
   ```

2. Usuwanie wydatku:
   ```
   remove <numer>
   ```
   Przykład:
   ```
   remove 1
   ```

3. Wyświetlanie wydatków:
   ```
   list
   ```

4. Obliczanie sumy wszystkich wydatków:
   ```
   total
   ```

5. Obliczanie sumy wydatków dla określonej kategorii:
   ```
   total <kategoria>
   ```
   Przykład:
   ```
   total jedzenie
   ```

## Technologie i zagadnienia

Aplikacja została napisana w języku C# i wykorzystuje następujące zagadnienia programowania:

- Zmienne i stałe
- Typy wartościowe i referencyjne
- Warunki i operatory
- Pętle i instrukcje skoku
- Tablice i listy
- Enum
- Klasy i obiekty
- Metody i parametry metod
- Pola i właściwości
- Zakresy widoczności
- Programowanie obiektowe
- Konstruktory i przeciążenia
- Dziedziczenie i polimorfizm
- Hermetyzacja
- Klasy abstrakcyjne i interfejsy
- Typy generyczne
- Refaktoryzacja
- Testowanie
- Projekt z testami
- Testy jednostkowe z wykorzystaniem Moq i FluentAssertions
- Pokrycie kodu testami
- TDD (Test-Driven Development)
- Testy integracyjne
