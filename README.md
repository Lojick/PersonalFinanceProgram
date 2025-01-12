# Personal Finance Program

Programmet är delat i två delar:
- **PersonalFinanceGUI**: Den grafiska användargränssnittet (GUI).
- **PersonalFinanceProgram**: Backend-koden som hanterar all affärslogik.

## Hur man kör programmet

1. **Navigera till PersonalFinanceGUI-projektet**  
   Programmet är byggt för att köras via **PersonalFinanceGUI**-projektet.  
   Alternativt kan du köra den kompilerade `PersonalFinanceGUI.exe` som finns i projektets mapp.

2. **Bygg och starta projektet**
   - Öppna lösningen i Visual Studio eller Visual Studio Code.
   - Navigera till **PersonalFinanceGUI**-projektet.
   - Kör projektet genom att trycka på `F5` eller välja **Starta**.

---

## Databaskonfiguration

För att programmet ska fungera med en databas behöver du endast skapa en tom databas i PostgreSQL. Programmet skapar automatiskt tabellerna åt dig.

1. **Skapa `appsettings.json`**
   Anpassa Username, Password och Database efter dina PostgreSQL-inställningar:
   Skapa en fil med namnet `appsettings.json` i samma katalog som den körbara filen för projektet (där `.exe`-filen finns).

3. **Klistra in följande innehåll i filen**:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Username=yourname;Password=yourpassword;Database=personalfinanceprogram"
     }
   }
