using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            if (username == null || firstName == null || lastName == null || password == null || role == null)
                { throw new ArgumentNullException(); }
            if (username.Length < 2 || username.Length > 20)
                { throw new ArgumentException("Username must be between 2 and 20 characters long!"); }
            if (!Regex.IsMatch(username, "^[A-Za-z0-9]+$"))
                { throw new ArgumentException("Username contains invalid symbols!"); }
            if (firstName.Length < 2 || firstName.Length > 20)
                { throw new ArgumentException("Firstname must be between 2 and 20 characters long!"); }
            if (lastName.Length < 2 || lastName.Length > 20)
                { throw new ArgumentException("Lastname must be between 2 and 20 characters long!"); }
            if (password.Length < 5 || username.Length > 30)
                { throw new ArgumentException("Password must be between 5 and 30 characters long!"); }
            if (!Regex.IsMatch(password, "^[A-Za-z0-9@*_-]+$"))
            { throw new ArgumentException("Password contains invalid symbols!"); }


            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.role = (Role)Enum.Parse(typeof(Role), role);
            this.vehicles = new List<IVehicle>();
        }

        public string Username => this.username;

        public string FirstName => this.firstName;

        public string LastName => this.lastName;

        public string Password => this.password;

        public Role Role => this.role;

        public IList<IVehicle> Vehicles => this.vehicles;

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.role == Role.Admin)
                { throw new ArgumentException("You are an admin and therefore cannot add vehicles!"); }
            if (this.vehicles.Count >= 5 && this.role != Role.VIP)
                { throw new ArgumentException("You are not VIP and cannot add more than 5 vehicles!"); }

            this.vehicles.Add(vehicle);
            Console.WriteLine($"{this.username} added a vehicle successfully");
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();

            StringBuilder result = new StringBuilder();

        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            return $"Username: {this.username}, FullName: {this.firstName} {this.lastName}, Role: {this.role}";
        }
    }
}
