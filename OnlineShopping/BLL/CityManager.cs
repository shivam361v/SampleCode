

namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;

public class CityManager
{
    public static CityManager _ref=null;
    
   
    private CityManager()
    {

    }


    public static CityManager GetCityManager()
    {
        if(_ref==null){
            _ref=new CityManager();
        }
        return _ref;

    }
    public List<City> GetAll()
    {
        List<City> citys = CityRepository.GetAll();
        return citys;
    }
}