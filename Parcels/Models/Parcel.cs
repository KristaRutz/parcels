using System;

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

    public Parcel(int height, int length, int width, int weight)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
    }

    public int GetVolume()
    {
      return Height * Width * Length;
    }

    public int GetCostToShip()
    {
      return GetVolume() + Weight * 2;
    }
  }
}