## ⚠️ Important Note Before Running the Project

After executing the `git clone` command,  
you must restore the database using the provided SQL script `KarataClamb.sql`.

---

### 📌 Steps to Restore the Database:

1. Open **SQL Server Management Studio (SSMS)**.

2. Open the script file `KarataClamb.sql`:
   - Click **File > Open > File…**
   - Locate `KarataClamb.sql` in the project folder.

3. Execute the script:
   - Make sure to select the **master** database first (or any existing database).
   - Click **Execute**.

4. This will:
   - Create the database **Karate Club** (or your desired name).
   - Create all necessary tables and insert the required data.

---

### ⚙️ Update the Connection String

By default, the connection string is located here:  
`DataAccsess\clsConnintionKarate.cs`

```csharp
public static string ConntionSring = $"Server =.;Database = KarateClub;User Id = sa;Password = 123456";
