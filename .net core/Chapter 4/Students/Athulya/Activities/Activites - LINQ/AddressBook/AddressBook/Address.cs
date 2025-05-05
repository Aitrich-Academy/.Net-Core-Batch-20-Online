using System.IO;

namespace AddressBook
{
    public class Address:Person
    {
        public int RoomNumber {  get; set; }
        public string Building {  get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address() { }
        public Address (string firstName,string lastName,int age, string homeAddress, string workAddress,int roomNumber,string building,string street,string phone,string email):base(firstName,lastName,age,homeAddress,workAddress)
       
        {
            this.RoomNumber = roomNumber;
           this. Building = building;
           this. Street = street;
          this.  Phone = phone;
           this. Email = email;
        }
    }
}