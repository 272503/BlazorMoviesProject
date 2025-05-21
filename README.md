# BlazorMoviesProject

Prosta aplikacja Blazor Server umożliwiająca rejestrację, logowanie oraz ocenianie filmów.  
Zbudowana z użyciem **.NET 8**, **Blazor Server**, **Entity Framework Core** oraz **Bootstrap 5**.

---

## Funkcje

- Rejestracja i logowanie użytkowników (w tym przez Google)
- Dodawanie, edycja i usuwanie filmów
- Wgrywanie okładek filmów
- Wystawianie ocen i recenzji (0–5 gwiazdek)
- Ochrona widoków przy użyciu `[Authorize]` i dynamiczne menu
- Automatyczne przeliczanie średnich ocen filmów
- Responsywny interfejs użytkownika oparty o Bootstrap 5

---

## Wymagania

- [Visual Studio 2022+](https://visualstudio.microsoft.com/vs/)
- .NET 8 SDK  
- LocalDB (domyślnie) lub SQL Server  
- Dostęp do Internetu (logowanie przez Google / CDN Bootstrap)

---

## Uruchamianie lokalnie

1. Sklonuj repozytorium:

    git clone https://github.com/272503/BlazorMoviesProject.git  
    cd BlazorMoviesProject

2. Otwórz plik `BlazorMoviesProject.sln` w Visual Studio

3. Przywróć pakiety NuGet

4. W konsoli `Package Manager Console` uruchom:

       Update-Database

5. Uruchom aplikację

---

## Logowanie Google

1. Zarejestruj aplikację w [Google Cloud Console](https://console.cloud.google.com/apis/credentials)

2. Ustaw redirect URI (np.):

       https://localhost:PORT/signin-google

3. W `Program.cs` dodaj:

       builder.Services.AddAuthentication()
           .AddGoogle(options =>
           {
               options.ClientId = "TWÓJ_CLIENT_ID";
               options.ClientSecret = "TWÓJ_CLIENT_SECRET";
           });

---

## Struktura projektu

    BlazorMoviesProject/
    ├── Components/Movies/       # Komponenty widoków CRUD
    ├── Data/                    # Modele EF + DbContext
    ├── Pages/                   # Layout i strony główne
    ├── wwwroot/images/          # Przesłane okładki filmów
    ├── Migrations/              # Migracje EF Core
    └── appsettings.json         # Ustawienia bazy i kluczy

---

## Przydatne

- Aby wyczyścić bazę – usuń ją w **SQL Server Object Explorer**, potem uruchom:

       Update-Database

- Obrazy zapisywane są w `/wwwroot/images/`

---

## Autor

Autor: **Piotr Kosior**  
Praca na zaliczenie przedmiotu *Platformy programistyczne .NET i Java*
