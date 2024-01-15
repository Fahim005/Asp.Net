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
    public class ParentService
    {


        public static List<ParentDTO> GetParent()
        {
            var data = DataAccessFactory.ParentDataAcesss().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Parent, AdminDTO>());
            var mapper = new Mapper(config);
            var parents = mapper.Map<List<ParentDTO>>(data);
            return parents;



        }
        public static ParentDTO Get(int id)
        {
            var data = DataAccessFactory.ParentDataAcesss().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Parent, AdminDTO>());
            var mapper = new Mapper(config);
            var parents = mapper.Map<ParentDTO>(data);
            return parents;


        }
        public static ParentDTO Add(ParentDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ParentDTO, Parent>();
                cfg.CreateMap<Parent, ParentDTO>();
            });
            var mapper = new Mapper(config);
            var parent = mapper.Map<Parent>(dto);
            var result = DataAccessFactory.ParentDataAcesss().Add(parent);
            return mapper.Map<ParentDTO>(result);
        }
        public static bool Update(ParentDTO dto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ParentDTO, Parent>();
                cfg.CreateMap<Parent, ParentDTO>();
            });
            var mapper = new Mapper(config);
            var parent = mapper.Map<Parent>(dto);
            var result = DataAccessFactory.ParentDataAcesss().Update(parent);
            return result;

        }
        public static bool Delete(int id)
        {
            var result = DataAccessFactory.ParentDataAcesss().Delete(id);
            return result;


        }
    }
}
