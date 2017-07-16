using AppBroker.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AppBroker.DAL
{
    public class BrokerRepository
    {
        #region Instance Members
        /// <summary>
        /// Instance of BrokerDBContext (Contains methods of entity framework)
        /// </summary>
        private BrokerDBContext _context;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialize _context instance
        /// </summary>
        public BrokerRepository()
        {
            _context = new BrokerDBContext();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Insert BrokerInfo in the DB
        /// </summary>
        /// <param name="brokerI">BrokerInfo object to insert in the DB</param>
        public void InsertBrokerInfo(BrokerInfo brokerI)
        {
            _context.BrokerInfo.Add(brokerI);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update BrokerInfo in the DB
        /// </summary>
        /// <param name="brokerI">BrokerInfo objecto to update</param>
        public void UpdateBrokerInfo(BrokerInfo brokerI)
        {
            BrokerInfo bi = _context.BrokerInfo.FirstOrDefault(x => x.Id == brokerI.Id);

            bi.Name = brokerI.Name;
            bi.MiddleName = brokerI.MiddleName;
            bi.LastName = brokerI.LastName;
            bi.NickName = brokerI.NickName;
            bi.DOB = brokerI.DOB;
            bi.Nationality = brokerI.Nationality;
            bi.Relationship = brokerI.Relationship;
            bi.AdressType = brokerI.AdressType;
            bi.Adress = brokerI.Adress;
            bi.City = brokerI.City;
            bi.State = brokerI.State;
            bi.County = brokerI.County;
            bi.ZipCode = brokerI.ZipCode;
            bi.Population = brokerI.Population;
            bi.Country = brokerI.Country;
            bi.PhoneType = brokerI.PhoneType;
            bi.PhonePriority = brokerI.PhonePriority;
            bi.PhoneCountry = brokerI.PhoneCountry;
            bi.PhoneNumber = brokerI.PhoneNumber;
            bi.EmailType = brokerI.EmailType;
            bi.EmailPriority = brokerI.EmailType;
            bi.Emailadress = brokerI.Emailadress;

            _context.SaveChanges();
        }
        /// <summary>
        /// Delete BrokerInfo
        /// </summary>
        /// <param name="brokerI">BrokerInfo object to delete</param>
        public void DeleteBrokerInfo(BrokerInfo brokerI)
        {
            _context.BrokerInfo.Remove(brokerI);
            _context.SaveChanges();
        }
        /// <summary>
        /// Consult all BrokerInfo at DB
        /// </summary>
        /// <returns>Returns a BrokerInfo list object</returns>
        public List<BrokerInfo> GetAll()
        {
            return _context.BrokerInfo.OrderBy(x => x.Name).ThenBy(x => x.LastName).ToList();
        }
        /// <summary>
        /// Consults BrokerInfo filtered by title
        /// </summary>
        /// <param name="name">Title of news to consult</param>
        /// <returns>Returns a news item object</returns>
        public BrokerInfo GetBrokerByName(string name)
        {
            return _context.BrokerInfo.FirstOrDefault(x => x.Name == name);
        }
        /// <summary>
        /// Consults BrokerInfo filtered by Id
        /// </summary>
        /// <param name="id">Id of BrokerInfo to consult</param>
        /// <returns>Returns a BrokerInfo item object</returns>
        public BrokerInfo GetById(int id)
        {
            return _context.BrokerInfo.FirstOrDefault(x => x.Id == id);
        }
        #endregion
    }
}
