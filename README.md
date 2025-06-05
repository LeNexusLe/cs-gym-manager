# GymManagement

Aplikacja do zarządzania siłownią: rejestracja członków, przypisywanie karnetów, ewidencja obecności oraz planów treningowych.

## Technologie

- .NET 8
- Windows Forms
- Entity Framework Core
- PostgreSQL

## Uruchomienie aplikacji

1. Zainstaluj PostgreSQL i skonfiguruj `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=gymdb;Username=postgres;Password=yourpassword"
     }
   }
2. Wykonaj migracje i seedowanie bazy danych:
```dotnet ef database update```
3. Uruchom aplikację:
```dotnet run```

## Struktura bazy danych

- Member – imię, nazwisko, kontakt
- Membership – data początkowa i końcowa, przypisany do członka
- Attendance – obecności z datą i członkiem
- WorkoutPlan – plan treningowy przypisany do osoby

## Funkcje aplikacji
- Rejestracja nowych członków
- Tworzenie i przypisywanie karnetów
- Rejestrowanie obecności
- Zarządzanie planami treningowymi
- Obsługa CRUD przez Windows Forms
