// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

/*
 * Conectarse a la base de datos
 * Genera para cada uno de los clientes numeroVentas, numeroTotalDeVentas
 */

try
{
    SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Northwind;Integrated Security=True;TrustServerCertificate=True");
    conn.Open();
    String query = $"SELECT  c.CustomerID, (SELECT COUNT(*) FROM Orders as o WHERE o.CustomerID=c.CustomerID) as ventas FROM Customers as c ";
    SqlCommand cmd = new SqlCommand(query, conn);
    SqlDataReader reader = cmd.ExecuteReader();


    if (reader.HasRows)
    {
        // Crear el fichero donde se guardará los datos
        


        
        while (reader.Read()) {
            string nombre = Convert.ToString(reader["CustomerID"]);
            int numeroVentas = Convert.ToInt16(reader["ventas"]);
            Console.WriteLine($"{nombre} - {numeroVentas}");
        }

    }
}   
catch ( Exception e) {  
    Console.WriteLine(e.ToString()); 
}