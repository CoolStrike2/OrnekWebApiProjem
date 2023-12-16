using HotelProject.BusinessLayer.Abstact;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _tetimonialDal;

        public TestimonialManager(ITestimonialDal tetimonialDal)
        {
            _tetimonialDal = tetimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            _tetimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _tetimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _tetimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _tetimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _tetimonialDal.Update(t);
        }
    }
}
