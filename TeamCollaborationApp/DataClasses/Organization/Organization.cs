using System;
namespace TeamCollaborationApp{
        class Organization{
        string oid;
        internal string Name;
        internal string Address;
        internal string phone;
        internal string fax;
        internal string email;
        internal string website;
        internal string description;
        internal string userID;
        public Organization(string Oid, string Name, string Address, string Phone, string Fax, string Email, string Website, string Description, string UserID){
            oid = Oid;
            name = Name;
            address = Address;
            phone = Phone;
            fax =Fax;
            email = Email;
            website = Website;
            description = Description;
            userID = UserID;
        }
    } 
}