using EsapiDataLibrary.Interfaces;
using EsapiDataLibrary.Models;
using EsapiDataLibrary.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsapiDataLibrary.Helpers
{
  public class Beams
  {
    public static List<IBeam> GetFromCsv(string pathToCsv)
    {
      List<IBeam> beams = new List<IBeam>();

      string[] lines = File.ReadAllLines(pathToCsv);
      foreach (string line in lines)
      {
        // get the column data
        var data = line.Split(',');

        // TODO: get machine parameters from column data
        //    -> or can assign that later after the basic data is defined from the csv
        // need to write a sample csv to determine columns, etc. 


        // the first column will be beam type
        switch (GetBeamType(data[0]))
        {
          case BeamType.MlcBeam:
            MlcBeamModel mlcBeam = new MlcBeamModel();
            beams.Add(mlcBeam);
            break;
          case BeamType.MlcArcBeam:
            MlcArcBeamModel arcBeam = new MlcArcBeamModel();
            beams.Add(arcBeam);
            break;
          case BeamType.StaticBeam:
            StaticBeamModel staticBeam = new StaticBeamModel();
            beams.Add(staticBeam);
            break;
          case BeamType.SetupBeam:
            SetupBeamModel setupBeam = new SetupBeamModel();
            beams.Add(setupBeam);
            break;
          default:
            MlcBeamModel defaultMlcBeam = new MlcBeamModel();
            beams.Add(defaultMlcBeam);
            break;
        }

      }

      return beams;
    }

    /// <summary>
    /// Get the beam type based on the information from the csv (column 1)
    /// </summary>
    /// <param name="beamTypeId"></param>
    /// <returns></returns>
    private static BeamType GetBeamType(string beamTypeId)
    {

      switch (beamTypeId.ToUpper())
      {
        case "STATICMLC":
          return BeamType.MlcBeam;
        case "ARCMLC":
          return BeamType.MlcArcBeam;
        case "STATIC":
          return BeamType.StaticBeam;
        case "SETUP":
          return BeamType.SetupBeam;
        default:
          return BeamType.MlcBeam;
      }

    }


  }
}
