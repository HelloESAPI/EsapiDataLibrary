using EsapiDataLibrary.Models;
using System;
using System.Collections.Generic;

namespace EsapiDataLibrary.Data
{
  /// <summary>
  /// dummy data to allow debugging, etc. and not having to run in eclipse -> for demos only
  /// </summary>
  public static class Structures
  {
    /// <summary>
    /// Creates a sample structure set based on an id and list of structures
    /// </summary>
    /// <param name="structureSetId"></param>
    /// <param name="structureSet"></param>
    /// <returns></returns>
    public static StructureSet GetSampleStructureSet(string structureSetId, List<Tuple<string, string>> structureSet, Random random)
    {
      List<Structure> structureList = new List<Structure>();
      foreach (var structureItem in structureSet)
      {
        structureList.Add(new Structure(structureItem.Item1, structureItem.Item2, random));
      }
      return new StructureSet(structureSetId, structureList);
    }

    /// <summary>
    /// Returns a list of structure item pairs (id and dicom type) based on the requested structure set type
    /// <para>Currently available Structure Sets -> Prostate, ProstateSIB, LungSimple, and a default sample list</para>
    /// </summary>
    /// <param name="structureSetType"></param>
    /// <returns></returns>
    public static List<Tuple<string, string>> GetStructureSet(string structureSetType)
    {
      switch (structureSetType)
      {
        case "Prostate":
          return new List<Tuple<string, string>> {
                        new Tuple<string, string>("CTV_4500", "CTV"),
                        new Tuple<string, string>("PTV_4500", "PTV"),
                        new Tuple<string, string>("Rectum", "ORGAN"),
                        new Tuple<string, string>("Bladder", "ORGAN"),
                        new Tuple<string, string>("PenileBulb", "ORGAN"),
                        new Tuple<string, string>("Bowel_Bag", "ORGAN"),
                        new Tuple<string, string>("CaudaEquina", "ORGAN"),
                        new Tuple<string, string>("Sigmoid", "ORGAN"),
                        new Tuple<string, string>("FemoralHead_L", "ORGAN"),
                        new Tuple<string, string>("FemoralHead_R", "ORGAN")
                        };
        case "ProstateSIB":
          return new List<Tuple<string, string>> {
                        new Tuple<string, string>("CTV_5040", "CTV"),
                        new Tuple<string, string>("CTV_7000", "CTV"),
                        new Tuple<string, string>("PTV_5040", "PTV"),
                        new Tuple<string, string>("PTV_7000", "PTV"),
                        new Tuple<string, string>("Rectum", "ORGAN"),
                        new Tuple<string, string>("Bladder", "ORGAN"),
                        new Tuple<string, string>("PenileBulb", "ORGAN"),
                        new Tuple<string, string>("Bowel_Bag", "ORGAN"),
                        new Tuple<string, string>("CaudaEquina", "ORGAN"),
                        new Tuple<string, string>("Sigmoid", "ORGAN"),
                        new Tuple<string, string>("FemoralHead_L", "ORGAN"),
                        new Tuple<string, string>("FemoralHead_R", "ORGAN")
                        };
        case "LungSimple":
          return new List<Tuple<string, string>> {
                        new Tuple<string, string>("CTV_6000", "CTV"),
                        new Tuple<string, string>("PTV_6000", "PTV"),
                        new Tuple<string, string>("Heart", "ORGAN"),
                        new Tuple<string, string>("SpinalCord", "ORGAN"),
                        new Tuple<string, string>("Lung_L", "ORGAN"),
                        new Tuple<string, string>("Lung_R", "ORGAN"),
                        new Tuple<string, string>("Carina", "ORGAN"),
                        new Tuple<string, string>("Lungs", "ORGAN"),
                        new Tuple<string, string>("A_Aorta", "ORGAN"),
                        new Tuple<string, string>("Esophagus", "ORGAN"),
                        };
        default:
          return new List<Tuple<string, string>> {
                        new Tuple<string, string>("CTV1", "CTV"),
                        new Tuple<string, string>("PTV1", "PTV"),
                        new Tuple<string, string>("Structure 1", "ORGAN"),
                        new Tuple<string, string>("Structure 2", "ORGAN"),
                        new Tuple<string, string>("Structure 3", "ORGAN"),
                        };
      }
    }

    public static List<string> GetAvailableStructureSetIds()
    {
      return new List<string>
      {
        "Prostate",
        "ProstateSIB",
        "LungSimple",
        "Default Sample",
      };
    }
  }
}
