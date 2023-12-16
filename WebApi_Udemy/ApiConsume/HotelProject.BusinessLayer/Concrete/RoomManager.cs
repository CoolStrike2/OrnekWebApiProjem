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

    public class RoomManager : IRoomService
    {
        private readonly IroomDal _roomDal;

        public RoomManager(IroomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room TGetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
