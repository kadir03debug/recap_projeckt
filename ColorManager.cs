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
   public class ColorManager:IColorService
    {
        İColorDal _colordal;
        public ColorManager(İColorDal cod )
        {
            _colordal = cod;
        }
        public void Add(Color co) { _colordal.Add(co); }
        public void Delete(int İd) { _colordal.Delete(İd); }
        public List<Color> Getbayİd(int İd) {return _colordal.Getbayİd(İd); }
        public void Update(Color co) { _colordal.Update(co); }
       public List<Color>  GetAll() {return _colordal.GetAll(); }
    }
}
