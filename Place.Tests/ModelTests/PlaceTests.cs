using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System.Collections.Generic;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_ConstructorCreates_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_GetsCityNameFromClass_String()
    {
      string cityName = "Lima";
      Place newPlace = new Place(cityName);

      string result = newPlace.GetCityName();

      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetsACityNameFromClass_String()
    {
      string cityName ="London";
      Place newPlace = new Place(cityName);

      newPlace.SetCityName("Paris");
      string result = newPlace.GetCityName();

      Assert.AreEqual("Paris", result);
    }

    [TestMethod]
    public void GetPlacesVisited_GathersCitiesCreated_Place()
    {
      Place newPlace1 = new Place("Chicago");
      Place newPlace2 = new Place ("Seattle");
      List<Place> newList = new List<Place> {newPlace1, newPlace2};

      List<Place> result = Place.GetPlacesVisited();

      CollectionAssert.AreEqual(result, newList);
    }
    [TestMethod]
    public void GetId_TellsUsWhatIdIs_Int()
    {
      Place newPlace1 = new Place("Chicago");
      Place newPlace2 = new Place("butts");
      Place newPlace3 = new Place("stank");
      Place newPlace4 = new Place("whatevs");

      int testId = newPlace3.GetId();

      Assert.AreEqual(3, testId);
    }
  }
}
