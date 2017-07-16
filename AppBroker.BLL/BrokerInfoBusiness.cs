using AppBroker.DAL;
using AppBroker.Entities;
using System.Collections.Generic;

namespace AppBroker.BLL
{
    public class BrokerInfoBusiness
    {
        #region Instance Members
        /// <summary>
        /// Broker repository instance to interact with data layer
        /// </summary>
        private BrokerRepository _brokerRepo;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialize BrokerRepository repository instances
        /// </summary>
        public BrokerInfoBusiness()
        {
            _brokerRepo = new BrokerRepository();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Sends a brokerI object to data layer to insert into the DB
        /// </summary>
        /// <param name="brokerI">brokerI object to insert in the DB</param>
        public void AddBroker(BrokerInfo brokerI)
        {
            //if (NewsExists(brokerI))
            //{
            //    throw new NewsAlreadyExistException();
            //}

            _brokerRepo.InsertBrokerInfo(brokerI);
        }
        /// <summary>
        /// Sends news object to data layer to delete from DB
        /// </summary>
        /// <param name="id">Id of news to delete from the DB</param>
        public void RemoveBroker(int id)
        {
            BrokerInfo broker = _brokerRepo.GetById(id);
            if (BrokerExistsById(broker))
            {
                _brokerRepo.DeleteBrokerInfo(broker);

            }
        }
        /// <summary>
        /// Sends news object to data layer to update in the DB
        /// </summary>
        /// <param name="brokerI">news object to update in the DB</param>
        public void EditBroker(BrokerInfo brokerI)
        {
            if (BrokerExistsById(brokerI))
            {
                _brokerRepo.UpdateBrokerInfo(brokerI);
            }
        }

        /// <summary>
        /// Sends a request to data layer to consult all BrokerInfo
        /// </summary>
        /// <returns>BrokerInfo list object</returns>
        public List<BrokerInfo> GetAll()
        {
            return _brokerRepo.GetAll();
        }

        /// <summary>
        /// Validate if BrokerInfo exists in the DB searched by Id
        /// </summary>
        /// <param name="brokerI">BrokerInfo object to consult if exists</param>
        /// <returns>Returns true or false to request if exists or not</returns>
        private bool BrokerExistsById(BrokerInfo brokerI)
        {
            var brokerbLA = _brokerRepo.GetById(brokerI.Id);
            return brokerbLA != null;
        }

        /// <summary>
        /// Sends request to data layer to consult a news item
        /// </summary>
        /// <param name="id">Id of news to consult</param>
        /// <returns>A news object</returns>
        public BrokerInfo GetBroker(int id)
        {
            BrokerInfo brokerI = _brokerRepo.GetById(id);
            return brokerI;
        }
        
        #endregion
    }
}
