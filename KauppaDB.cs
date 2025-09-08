using Microsoft.Data.Sqlite;
public class KauppaDB
{
    private string connectionString = "Data Source = kauppa.db";

    public KauppaDB()
    {
        //luodaan yhteys tietokantaan
        var connection = new SqliteConnection(connectionString);
        connection.Open();
        //luoda taulut, jos niitä ie vielä ole
        //Yksinkertainen tietokanta, jossa on yksi taulu
        //Taulu Tuoteet sarakeet id, nimi, hinta
        var commandForTableCreating = connection.CreateCommand();
        commandForTableCreating.CommandText = "CREATE TABLE IF NOT EXISTS Tuotteet (id INTEGER PRIMATY KEY, nimi TEXT, hinta REAL)";
        commandForTableCreating.ExecuteNonQuery();
        connection.Close();
    }
    public void LisaaTuote(string nimi, int hinta)
    {
        var connection = new SqliteConnection(connectionString);
        connection.Open();
        //Lisätään tuote tietokantaan
        var commandForInsert = connection.CreateCommand();
        commandForInsert.CommandText = "INSERT INTO Tuotteet (nimi, hinta) VALUES (@Nimi, @Hinta)";
        commandForInsert.Parameters.AddWithValue("Nimi", nimi);
        commandForInsert.Parameters.AddWithValue("Hinta", hinta);
        commandForInsert.ExecuteNonQuery();
        connection.Close();
    }
}

