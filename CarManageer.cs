using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccess.Apstract;
using Business.Apstract;
namespace Business.Concrete
{
   public class CarManageer:ICarService
    {
        İCarDal _cardal;
        public CarManageer(İCarDal cd )
        {
            _cardal = cd;
        }
        public void Add(Car c) { _cardal.Add(c); }
        public void Delete(int İd) { _cardal.Delete(İd); }
       public List<Car> Getbayİd(int İd) {return _cardal.Getbayİd(İd); }
        public List<Car> GetbayBrandİd(int Brandİd) {return _cardal.GetbayBrandİd(Brandİd); }
        public void Update(Car c) { _cardal.Update(c); }
        public List<Car> GetAll() {return _cardal.GetAll(); }
    }
}
