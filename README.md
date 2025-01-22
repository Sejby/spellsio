# Spellsio - Avalonia Application

## Popis

Spellsio je desktopová aplikace vytvořená pomocí AvaloniaUI, která zobrazuje seznam kouzel ("Spells") z externího API. Aplikace využívá architektonický vzor **MVVM (Model-View-ViewModel)** a návrhový vzor **Factory** pro vytváření instancí modelů kouzel.

Data o kouzlech jsou načítána z veřejné API a následně zpracována a zobrazena ve View pomocí ViewModelu. Soubory jsou zobrazeny ve View šabloně s horizontálním scrollováním pro lepší přehlednost a interakci.

Účel projektu -> nabýt základní praktické znalosti s Avalonia UI a C#

## Požadavky

Tato aplikace vyžaduje **.NET 9.0** nebo novější pro správné spuštění a kompilaci projektu.

- .NET 9.0 (nebo vyšší) – [Instalace .NET](https://dotnet.microsoft.com/download)

## Instalace

### 1. Klonování repozitáře

Nejprve naklonujte repozitář do svého lokálního počítače pomocí příkazu:

```bash
git clone https://github.com/Sejby/spellsio.git
```
```bash
cd wetherio/
```
```bash
dotnet build
```
```bash
dotnet run
```


