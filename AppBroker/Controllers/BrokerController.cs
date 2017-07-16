using AppBroker.BLL;
using AppBroker.Entities;
using AppBroker.Models;
using System.Web.Mvc;

namespace AppBroker.Controllers
{
    public class BrokerController : Controller
    {

        #region Instances
        /// <summary>
        /// LinkBusiness instance to interact to link business layer
        /// </summary>
        private BrokerInfoBusiness _brokerBLL;
        #endregion

        public BrokerController()
        {
            _brokerBLL = new BrokerInfoBusiness();
        }

        // GET: Broker
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateBroker(BrokerViewModels model)
        {
            if(model.BrokerInfo.Name != null)
            {
                BrokerInfo broker = new BrokerInfo();

                broker = model.BrokerInfo;
                _brokerBLL.AddBroker(broker);
            }

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var brokers = _brokerBLL.GetAll();
            return View(brokers);
        }

        public ActionResult Delete(int id)
        {
            if (id != 0)
            {
                var link = _brokerBLL.GetBroker(id);

                _brokerBLL.RemoveBroker(id);
            }
            return RedirectToAction("List");
        }
        public ActionResult Update(int id)
        {
            if (id != 0)
            {
                BrokerInfo broker = _brokerBLL.GetBroker(id);
                var brokerVM = new BrokerViewModels();
                brokerVM.BrokerInfo = broker;
                return View(brokerVM);
            }
            else
            {
                return RedirectToAction("List");
            }
        }
    }
}