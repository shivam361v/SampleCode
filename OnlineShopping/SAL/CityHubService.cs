namespace SAL;
using BOL;
using BLL;

public class CityHubService
{
    public List<City> GetAllCitys()
    {
        CityManager theCity = CityManager.GetCityManager();
        List<City> allCitys = theCity.GetAll();
        return allCitys;
    }
}