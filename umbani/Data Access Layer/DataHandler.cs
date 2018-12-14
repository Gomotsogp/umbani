using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using umbani.Models;

namespace umbani.Data_Access_Layer
{
    public class DataHandler
    {
        //private global declarations
        private static string _connectionString = ConfigurationManager.ConnectionStrings["umbani"].ToString();
        private SqlConnection connection = new SqlConnection(_connectionString);
        private bool isSuccess;

        //global lists
        List<Contact> Contacts = new  List<Contact>();
        List<Company> Companies = new List<Company>();
        List<Product> Products = new List<Product>();
        List<Subscription> Subscriptions = new List<Subscription>();
        List<User> Users = new List<User>();

        public List<Contact> GetContacts()
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                    DataSet ds = new DataSet();
                    string query = @"select * from contact";
                    SqlCommand cmd = new SqlCommand(query,connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    //iterate through the list and bring back the list of contacts
                    foreach (DataRow item in dt.Rows)
                    {
                        Contacts.Add(new Contact(int.Parse(item[0].ToString()),item[1].ToString(),item[2].ToString(),item[3].ToString()));
                    }

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return Contacts;
        }

        public List<Company> GetCompanies()
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                    DataSet ds = new DataSet();
                    string query = @"select * from company c
inner join contact co
on c.contactid = co.id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    //iterate through the list and bring back the list of contacts
                    foreach (DataRow item in dt.Rows)
                    {
                        Companies.Add(new Company(int.Parse(item[0].ToString()), item[1].ToString(),
                            new Contact(int.Parse(item[3].ToString()), item[4].ToString(), item[5].ToString(),
                                item[6].ToString())));
                    }

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }

            return Companies;
        }

        public List<Product> GetProducts()
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                    DataSet ds = new DataSet();
                    string query = @"select * from product";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    //iterate through the list and bring back the list of contacts
                    foreach (DataRow item in dt.Rows)
                    {
                        Products.Add(new Product(int.Parse(item[0].ToString()),item[1].ToString(),decimal.Parse(item[2].ToString()),decimal.Parse(item[3].ToString())));
                    }

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return Products;
        }

        public bool SaveContact(string name, string phone,string email)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                   
                    string query = @"INSERT into contact
(name,phonenumber,email)
values
(@name,@phone,@email)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));
                    cmd.Parameters.Add(new SqlParameter("@email", email));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool SaveCompany(string name, int contactId)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"insert into company
                                    (name,contactId)
                                    values
                                    (@name,@contact)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@contact", contactId));
                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool SaveProduct(string name, decimal annualcost,decimal monthlycost)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"insert into product
                                    (name,annualcost,monthlycost)
                                    values
                                    (@name,@annual,@monthly)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@annual", annualcost));
                    cmd.Parameters.Add(new SqlParameter("@monthly", monthlycost));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool UpdateCompany(string name, int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"update company
                                    set name = @name
                                    where id = @id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool UpdateContact(string name, string phone, string email, int companyId, int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"update contact
set name =@name, phonenumber = @phone,email=@email,companyid = @companyId
where id=@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@phone", name));
                    cmd.Parameters.Add(new SqlParameter("@email", name));
                    cmd.Parameters.Add(new SqlParameter("@companyId", name));
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool UpdateProduct(string name, decimal annual, decimal monthly, int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"update product
set name =@name,annualcost = @annual, monthlycost = @monthly
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@annual", annual));
                    cmd.Parameters.Add(new SqlParameter("@monthly", monthly));
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool DeleteCompany(int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"delete company 
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool DeleteContact(int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"delete contact 
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"delete product 
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return isSuccess;
        }

        public List<Subscription> GetSubscriptions()
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                    DataSet ds = new DataSet();
                    string query = @"select * from subscription s
inner join company c
on s.companyid = c.id
inner join contact co
on s.contactid = co.id
inner join product p
on s.productid = p.id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    //iterate through the list and bring back the list of contacts
                    foreach (DataRow item in dt.Rows)
                    {
                        Subscriptions.Add(new Subscription(int.Parse(item[0].ToString()),new Company(int.Parse(item[9].ToString()),item[10].ToString(),new Contact()),new Contact(int.Parse(item[11].ToString()),item[12].ToString(),item[13].ToString(),item[14].ToString()),new Product(int.Parse(item[16].ToString()),item[17].ToString(),decimal.Parse(item[18].ToString()),decimal.Parse(item[19].ToString())),int.Parse(item[4].ToString()),DateTime.Parse(item[5].ToString()),bool.Parse(item[6].ToString()),bool.Parse(item[7].ToString()),decimal.Parse(item[8].ToString())));
                    }

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }

            return Subscriptions;
        }
        public List<Subscription> GetSubscription( int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                    DataSet ds = new DataSet();
                    string query = $@"select * from subscription s
inner join company c
on s.companyid = c.id
inner join contact co
on s.contactid = co.id
inner join product p
on s.productid = p.id where s.id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    //iterate through the list and bring back the list of contacts
                    foreach (DataRow item in dt.Rows)
                    {
                        Subscriptions.Add(new Subscription(int.Parse(item[0].ToString()), new Company(int.Parse(item[9].ToString()), item[10].ToString(), new Contact()), new Contact(int.Parse(item[11].ToString()), item[12].ToString(), item[13].ToString(), item[14].ToString()), new Product(int.Parse(item[16].ToString()), item[17].ToString(), decimal.Parse(item[18].ToString()), decimal.Parse(item[19].ToString())), int.Parse(item[4].ToString()), DateTime.Parse(item[5].ToString()), bool.Parse(item[6].ToString()), bool.Parse(item[7].ToString()), decimal.Parse(item[8].ToString())));
                    }

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }

            return Subscriptions;
        }

        public bool SaveSubscription(int companyId, int contactId, int productId, int numberofUsers, DateTime startDate, bool annual, bool monthly, decimal cost)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"insert into subscription
(companyid, contactid, productid, numberofusers,subscriptionstartdate,annual,monthly,cost)
values
(@company,@contact,@product,@users,@startdate,@annual,@monthly,@cost)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@company", companyId));
                    cmd.Parameters.Add(new SqlParameter("@contact", contactId));
                    cmd.Parameters.Add(new SqlParameter("@product", productId));
                    cmd.Parameters.Add(new SqlParameter("@users", numberofUsers));
                    cmd.Parameters.Add(new SqlParameter("@startdate", startDate));
                    cmd.Parameters.Add(new SqlParameter("@annual", annual));
                    cmd.Parameters.Add(new SqlParameter("@monthly", monthly));
                    cmd.Parameters.Add(new SqlParameter("@cost", cost));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isSuccess;
        }

        public bool UpdateSubscription(int companyId,int contactId,int productId,int numberofUsers, DateTime startDate, bool annual,bool monthly, decimal cost, int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"update subscription
set companyid = @company, contactid = @contact, productid = @product, numberofusers= @users,subscriptionstartdate= @startdate,annual=@annual,monthly =@monthly,cost =@cost
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@company", companyId));
                    cmd.Parameters.Add(new SqlParameter("@contact", contactId));
                    cmd.Parameters.Add(new SqlParameter("@product", productId));
                    cmd.Parameters.Add(new SqlParameter("@users", numberofUsers));
                    cmd.Parameters.Add(new SqlParameter("@startdate", startDate));
                    cmd.Parameters.Add(new SqlParameter("@annual", annual));
                    cmd.Parameters.Add(new SqlParameter("@monthly", monthly));
                    cmd.Parameters.Add(new SqlParameter("@cost", cost));
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isSuccess;
        }

        public bool DeleteSubscription(int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"delete subscription 
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isSuccess;
        }

        public List<User> GetUsers()
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 
                    DataSet ds = new DataSet();
                    string query = @"select * from [user]";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);

                    DataTable dt = ds.Tables[0];

                    //iterate through the list and bring back the list of contacts
                    foreach (DataRow item in dt.Rows)
                    {
                        Users.Add(new User(int.Parse(item[0].ToString()),item[1].ToString(),item[2].ToString(),item[3].ToString(),item[4].ToString()));
                    }

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return Users;
        }

        public bool SaveUser(string name, string email, string username, string password)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"  insert into [user]
  (fullname,email,username,password)
  values
  (@name,@email,@username,@pass)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@pass", password));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isSuccess;
        }
        public bool UpdateUser(string name, string email, string username, string password, int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @" update [user]
  set fullname = @name, email =@email, username = @username,password = @pass
  where id = @id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@pass", password));
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isSuccess;
        }

        public bool DeleteUser(int id)
        {
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // run the select query to the database 

                    string query = @"delete [user] 
where id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    //insert the values into the parameters
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    //execute the query and set the isSuccess to true
                    cmd.ExecuteNonQuery();
                    isSuccess = true;

                }
                else
                {
                    throw new Exception("Database connection not established");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return isSuccess;
        }
    }
}