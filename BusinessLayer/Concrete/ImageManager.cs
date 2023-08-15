using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _ımageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public void Delete(Image t)
        {
            _ımageDal.Delete(t);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            return _ımageDal.GetById(id);
        }

        public List<Image> GetListAll()
        {
            
            return _ımageDal.GetListAll();
        }

        public void Insert(Image t)
        {
            _ımageDal.Insert(t);
        }

        public void Update(Image t)
        {
            _ımageDal.Update(t);
        }
    }
}
