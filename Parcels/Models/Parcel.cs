using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    // private int _height { get; set; }
    // private int _length { get; set; }
    // private int _width { get; set; }
    // private int _weight { get; set; }

    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }

    private static List<Parcel> _parcels { get; set; } = new List<Parcel> { };

    public Parcel(int height, int length, int width, int weight)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
      _parcels.Add(this);
    }

    public int GetVolume()
    {
      return Height * Width * Length;
    }

    public int GetCostToShip()
    {
      return GetVolume() + Weight * 2;
    }

    public static List<Parcel> GetParcelList()
    {
      return _parcels;
    }

    public void ClearParcels()
    {
      _parcels.Clear();
    }
  }
}