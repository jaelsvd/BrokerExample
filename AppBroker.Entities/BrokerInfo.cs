using System.ComponentModel.DataAnnotations;

namespace AppBroker.Entities
{
    /// <summary>
    /// This class defines the brokers (user) basic information
    /// </summary>
    public class BrokerInfo
    {
        #region Model
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string DOB { get; set; }
        public string Nationality { get; set; }
        public string Relationship { get; set; }
        public string AdressType { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string ZipCode { get; set; }
        public string Population { get; set; }
        public string Country { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string PhonePriority { get; set; }
        public string PhoneCountry { get; set; }
        public string Emailadress { get; set; }
        public string EmailType { get; set; }
        public string EmailPriority { get; set; }


        #endregion

    }
}
