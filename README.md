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

För att aktivera anslutning till en databas behöver du skapa en `appsettings.json`-fil. Följ stegen nedan:

1. **Skapa `appsettings.json`**  
   Skapa en fil med namnet `appsettings.json` i samma katalog som den körbara filen för projektet (där `.exe`-filen finns).

2. **Klistra in följande innehåll i filen**:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Username=yourname;Password=yourpassword;Database=personalfinanceprogram"
     }
   }
