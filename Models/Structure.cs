using Newtonsoft.Json;
using System;
using System.Windows.Media;

namespace EsapiDataLibrary.Models
{
  /// <summary>
  /// dummy data model to allow debugging, etc. and not having to run in eclipse -> for demos only
  /// </summary>
  public class Structure
  {
    public string Id { get; set; }
    public string DicomType { get; set; }
    public double Volume { get; set; }
    public double MaxDose { get; set; }
    public double MeanDose { get; set; }
    public SolidColorBrush Color { get; set; }
    public string RGBString { get; set; }

    [JsonConstructor]
    public Structure(string id, string dicomType, double volume, double maxDose, double meanDose, string rGBString)
    {
      string[] rgb = rGBString.Split(',');
      Id = id;
      DicomType = dicomType;
      Volume = volume;
      MaxDose = maxDose;
      MeanDose = meanDose;
      Color = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)Int32.Parse(rgb[0]), (byte)Int32.Parse(rgb[1]), (byte)Int32.Parse(rgb[2])));
      RGBString = rGBString;
    }

    public Structure(string id, string dicomType, Random random)
    {
      Id = id;
      DicomType = dicomType;
      Volume = Math.Round(random.NextDouble() * 1000, 3);
      MaxDose = Math.Round(random.NextDouble() * 45, 3);
      MeanDose = Math.Round(random.NextDouble() * 45, 3);
      Color = new SolidColorBrush(System.Windows.Media.Color.FromArgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));
    }
  }
}
