using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    private string _cityName;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName)
    {
      _cityName = cityName;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }

    public static List<Place> GetPlacesVisited()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int GetId()
    {
      return _id;
    }
  }
}
