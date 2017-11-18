using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Cap._4_List4_28
{
    class Program
    {
        public static string connectionString =
            ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

        static void Main(string[] args)
        {
            /* not do that. Look app.config or web.config
             * 
             * 
            var sqlconnectionstringbuilder = new SqlConnectionStringBuilder();

            sqlconnectionstringbuilder.DataSource = @"(localdb)\v11.0";
            sqlconnectionstringbuilder.InitialCatalog = "ProgrammingInCSharp";

            string conectionString = sqlconnectionstringbuilder.ToString();

                O CODIGO COMENTADO NÃO É VÁLIDO
    */

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                Console.WriteLine(conexao.State);

                conexao.Open();

                Console.WriteLine(conexao.State);
            }//here connecion is closed

            string comandoSelect = @"SELECT * FROM PESSOA"; //task
            string task2comando = @"SELECT TOP 1 * FROM PESSOA ORDER BY LASTNAME";
            string task3cmd = @"UPDATE PESSOA SET FIRSTNAME= 'John'";
            string task4cmd = @"INSERT INTO PESSOA([FIRSTNAME], [LASTNAME], [MIDDLENAME]) VALUES (@firstname, @lastname, @middlename)";

            string task5cmd1 = @"INSERT INTO PESSOA ([FIRSTNAME], [LASTNAME], [MIDDLENAME]) VALUES ('JOHN', 'DOE', NULL)";
            string task5cmd2 = @"INSERT INTO PESSOA([FIRSTNAME], [LASTNAME], [MIDDLENAME]) VALUES ('JANE', 'DOE', NULL)";


            Task task = SelectDataFromTable(comandoSelect);
            Task task2 = SelectMultipleResultSets(task2comando);
            Task task3 = UpdateRows(task3cmd);
            Task task4 = InsertRowWithParameterizedQuery(task4cmd);
            Task task5 = TransactionScopeInserte(task5cmd1, task5cmd2);
            Task.WaitAll(task, task2, task3, task4, task5);
        }

        public static async Task SelectDataFromTable(string comando)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(comando, conexao);
                    await conexao.OpenAsync();

                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        string formaStringWithMiddleName = "Person ({0} is named {1} {2} {3}";
                        string formatStringWithoutMiddleName = "Person ({0} is named {1} {3}";

                        if ((reader["middlename"] == null))
                        {
                            Console.WriteLine(formatStringWithoutMiddleName, reader["id"], reader["firstname"], reader["lastname"]);
                        }
                        else
                        {
                            Console.WriteLine(formaStringWithMiddleName, reader["id"], reader["firstname"], reader["middlename"],
                                reader["lastname"]);
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadLine();
                }
            }
        }

        public static async Task SelectMultipleResultSets(string comando)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(comando, conexao);

                await conexao.OpenAsync();
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                await ReadQueryResults(reader);
                await reader.NextResultAsync(); //move to the next result set
                await ReadQueryResults(reader);
                reader.Close();
            }
        }

        private static async Task ReadQueryResults(SqlDataReader dataReader)
        {
            while (await dataReader.ReadAsync())
            {
                string formatStringWithMiddleName = "Person ({0}) is named {1} {2} {3}";
                string formatStringWithoutMiddleName = "Person ({0}) is named {1} {3}";

                if ((dataReader["middlename"] == null))
                {
                    Console.WriteLine(formatStringWithoutMiddleName,
                    dataReader["id"], dataReader["firstname"], dataReader["lastname"]);
                }
                else
                {
                    Console.WriteLine(formatStringWithMiddleName, dataReader["id"], dataReader["firstname"],
                        dataReader["middlename"], dataReader["lastname"]);
                }
            }
        }

        public static async Task UpdateRows(string comando)
        {
            using(SqlConnection conexao = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(comando, conexao);

                await conexao.OpenAsync();
                int numberOfUpdateRows = await cmd.ExecuteNonQueryAsync();
                Console.WriteLine("Update {0} rows", numberOfUpdateRows);
            }
        }

        public static async Task InsertRowWithParameterizedQuery(string cmdParam)
        {
            /*
             * to preserv SQL Injection
             * more on > http://msdn.microsoft.com/en-us/library/ms161953(v=sql.105).aspx
             * 
             * These parameterized queries can be used when running select, update, insert, and delete queries.
             * Besides being much more secure, they also offer better performance.
             * Because the database gets a more generic query, it can more easily find a precompiled execution plan to execute your query.
             * 
             * more info about plans >> http://msdn.microsoft.com/en-us/library/ms175580.aspx
             * */

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(cmdParam, conexao);
                await conexao.OpenAsync();

                cmd.Parameters.AddWithValue("@firstname", "John");
                cmd.Parameters.AddWithValue("@lastname", "Doe");
                cmd.Parameters.AddWithValue("@middlename", "Little");

                int numberOfRow = await cmd.ExecuteNonQueryAsync();
                Console.WriteLine("Inserted {0} rows", numberOfRow);
            }
        }

        public static async Task TransactionScopeInserte(string comando1, string comando2)
        {
            /*
                 * using System.Transaction
                 * 
                 * If an exception occurs inside the TransactionScope, the whole transaction is rolled back.
                 * If nothing goes wrong, you use TransactionScope.Complete to commplete the transaction.
                 * */

            using (TransactionScope transactionScope = new TransactionScope())
            {
                using(SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    SqlCommand cmd1 = new SqlCommand(comando1, conexao);
                    SqlCommand cmd2 = new SqlCommand(comando2, conexao);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }

                transactionScope.Complete();
            }
        }
    }

    /*
     * 
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PeopleContext: DbContext
    {
        public IDbSet<Person> People { get; set; }
    }

    // Gerando erro Context pag 281
    */
}
