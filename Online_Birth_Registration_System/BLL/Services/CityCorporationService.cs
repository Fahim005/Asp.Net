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
    public class CityCorporationService
    {
        public static List<CityCorporationDTO> GetCityCorporation()
        {
            var data = DataAccessFactory.CityCorporatioDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<City_corporation, CityCorporationDTO>());
            var mapper = new Mapper(config);
            var citycorporations = mapper.Map<List<CityCorporationDTO>>(data);
            return citycorporations;


        }
        public static CityCorporationDTO Get(int id)
        {
            var data = DataAccessFactory.CityCorporatioDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<City_corporation, CityCorporationDTO>());
            var mapper = new Mapper(config);
            var citycorporations = mapper.Map<CityCorporationDTO>(data);
            return citycorporations;


        }
        public static bool Add(CityCorporationDTO dto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CityCorporationDTO, City_corporation>();
                cfg.CreateMap<City_corporation, CityCorporationDTO>();
            });
            var mapper = new Mapper(config);
            var city_corporation = mapper.Map<City_corporation>(dto);
            var result = DataAccessFactory.CityCorporatioDataAccess().Add(city_corporation);
            return result;
        }
        public static bool Update(CityCorporationDTO dto)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CityCorporationDTO, City_corporation>();
                cfg.CreateMap<City_corporation, CityCorporationDTO>();
            });
            var mapper = new Mapper(config);
            var citycorporations = mapper.Map<City_corporation>(dto);
            var result = DataAccessFactory.CityCorporatioDataAccess().Update(citycorporations);
            return result;

        }
        public static bool Delete(int id)
        {
            var result = DataAccessFactory.CityCorporatioDataAccess().Delete(id);
            return result;
        }
    }
}
