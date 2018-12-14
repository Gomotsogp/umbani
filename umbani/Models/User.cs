using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Net;
using umbani.Data_Access_Layer;

namespace umbani.Models
{
    public class User
    {
        private int id;
        private string fullname;
        private string email;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }

        public User()
        {
                
        }

        public User(int id, string name, string email,string username,string password)
        {
            this.id = id;
            this.fullname = name;
            this.email = email;
            this.username = username;
            this.password = password;
        }

        DataHandler dh = new DataHandler();

        public List<User> GetUsers()
        {
            return dh.GetUsers();
        }

        public bool SaveUser(string name, string email, string username, string password)
        {
            return dh.SaveUser(name, email, username, password);
        }

        public bool UpdateUser(string name, string email, string username, string password, int id)
        {
            return dh.UpdateUser(name, email, username, password, id);
        }

        public bool DeleteUser(int id)
        {
            return dh.DeleteUser(id);
        }
    }
}