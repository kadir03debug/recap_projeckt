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
   public class BrandManager:IBrandService
    {
        İBrandDal _branddal;
        public BrandManager(İBrandDal bd )
        {
            _branddal = bd;
        }
        public void Add(Brand b ) { _branddal.Add(b); }
        public void Delete (int İd) { _branddal.Delete(İd); }
        public List<Brand>  Getbayİd(int İd) {return _branddal.Getbayİd(İd); }
        public void Update(Brand b) { _branddal.Update(b); }
       public List<Brand> GetAll() {return _branddal.GetAll(); }
    }
}
