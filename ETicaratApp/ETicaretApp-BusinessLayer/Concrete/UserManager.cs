using ETicaretApp_BusinessLayer.Abstract;
using ETicaretApp_DataAccess.Abstract;
using ETicaretApp_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp_BusinessLayer.Concrete
{
    public class UserManager: IUserService
    {
        IUserDal userDal;

        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }

        public void AddWriter(User user)
        {
            userDal.Create(user);
        }

        public List<User> GetList()
        {
            return userDal.GetAll();
        }
    }
}
