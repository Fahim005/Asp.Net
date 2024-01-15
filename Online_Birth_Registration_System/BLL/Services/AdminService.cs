using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> GetAdmins()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminDTO>());
            var mapper = new Mapper(config);
            var admins = mapper.Map<List<AdminDTO>>(data);
            return admins;


        }
        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminDTO>());
            var mapper = new Mapper(config);
            var admin = mapper.Map<AdminDTO>(data);
            return admin;

        }
        public static bool Add(AdminDTO dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var admin = mapper.Map<Admin>(dto);
            var result = DataAccessFactory.AdminDataAccess().Add(admin);
            return result;
        }
        public static bool Update(AdminDTO dto)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var admin = mapper.Map<Admin>(dto);
            var result = DataAccessFactory.AdminDataAccess().Update(admin);
            return result;

        }
        public static bool Delete(int id)
        {
            var result = DataAccessFactory.AdminDataAccess().Delete(id);
            return result;
        }
    }
}
