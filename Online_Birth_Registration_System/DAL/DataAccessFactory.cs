using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Admin, int, bool> AdminDataAccess(){
            return new AdminRepo();
            }
        public static IRepo<City_corporation,int,bool> CityCorporatioDataAccess()
        {
            return new CityCorporationRepo();
        }
        public static IRepo<Parent,int,bool> ParentDataAcesss()
        {
            return new ParentRepo();
        }
    }
}
