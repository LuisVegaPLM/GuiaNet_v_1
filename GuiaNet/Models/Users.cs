//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuiaNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public partial class Users
    {
        public Users()
        {
            this.ActivitySessions = new HashSet<ActivitySessions>();
            this.ApplicationUsers = new HashSet<ApplicationUsers>();
            this.UserCountries = new HashSet<UserCountries>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        [Required]
        [Display(Name = "Nombre de Usuario:")]
        public string NickName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña:")]
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public bool Active { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<ActivitySessions> ActivitySessions { get; set; }
        public virtual ICollection<ApplicationUsers> ApplicationUsers { get; set; }
        public virtual CountriesUser Countries { get; set; }
        public virtual ICollection<UserCountries> UserCountries { get; set; }

        public ApplicationUsers ApplicationsUsers = new ApplicationUsers();
        public Roles RolesUser = new Roles();
        public Applications Applications = new Applications();
        public CountriesUser Country = new CountriesUser();
        public UserCountries UserCountries1 = new UserCountries();
        private PLMUsers db = new PLMUsers();

        public PLMCryptographyComponent.CryptographyComponent cryptography = new PLMCryptographyComponent.CryptographyComponent();

        public bool IsValid(string _Nname, string _Password)
        {
            _Password = cryptography.encrypt(_Password);
            var login = (from User in db.Users
                         where User.NickName == _Nname
                         && User.Password == _Password
                         select User);
            if (login.LongCount() > 0)
            {
                foreach (Users User in login)
                {
                    User.NickName = _Nname;
                    User.Password = _Password;
                    UserId = User.UserId;
                    Name = User.Name;
                    LastName = User.LastName;
                    SecondLastName = User.SecondLastName;
                    Email = User.Email;
                    Active = User.Active;
                    CountryId = User.CountryId;

                    var Hashkey = System.Configuration.ConfigurationManager.AppSettings["HashKey"];
                    var Applic = from Aplications in db.Applications
                                 where Aplications.HashKey == Hashkey
                                 select Aplications;
                    if (Applic.LongCount() > 0)
                    {
                        foreach (Applications Ap in Applic)
                        {
                            Applications.Active = Ap.Active;
                            Applications.ApplicationId = Ap.ApplicationId;
                            Applications.ApplicationUsers = Ap.ApplicationUsers;
                            Applications.Description = Ap.Description;
                            Applications.DocumentFile = Ap.DocumentFile;
                            Applications.RootUrl = Ap.RootUrl;
                            Applications.URL = Ap.URL;
                            Applications.Version = Ap.Version;
                            //Applications.HashKey = "AgroNet";

                            var AppUser = from ApplicationUser in db.ApplicationUsers
                                          where ApplicationUser.UserId == UserId
                                          && ApplicationUser.ApplicationId == Applications.ApplicationId
                                          select ApplicationUser;
                            if (AppUser.LongCount() > 0)
                            {
                                foreach (ApplicationUsers App in AppUser)
                                {
                                    ApplicationsUsers.ApplicationId = App.ApplicationId;
                                    ApplicationsUsers.RoleId = App.RoleId;
                                    ApplicationsUsers.UserId = App.UserId;

                                    var Roles = from Rol in db.Roles
                                                where Rol.RoleId == App.RoleId
                                                select Rol;
                                    if (Roles.LongCount() > 0)
                                    {
                                        foreach (Roles Rol in Roles)
                                        {
                                            RolesUser.Active = Rol.Active;
                                            RolesUser.Description = Rol.Description;
                                            RolesUser.RoleId = Rol.RoleId;
                                            var Count = from CountryU in db.CountriesUser
                                                        where CountryU.CountryId == User.CountryId
                                                        select CountryU;
                                            if (Count.LongCount() > 0)
                                            {
                                                foreach (CountriesUser C in Count)
                                                {
                                                    Country.CountryId = C.CountryId;
                                                    Country.CountryName = C.CountryName;
                                                    Country.ID = C.ID;

                                                    var UserC = from UserCountries in db.UserCountries
                                                                where UserCountries.UserId == UserId
                                                                //&& UserCountries.UserId == UserId
                                                                select UserCountries;
                                                    if (UserC.LongCount() > 0)
                                                    {
                                                        foreach (UserCountries UC in UserC)
                                                        {
                                                            UserCountries1.CountryId = UC.CountryId;
                                                            UserCountries1.UserId = UC.UserId;
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
