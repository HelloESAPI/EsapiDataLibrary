using EsapiDataLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsapiDataLibrary.Models
{
  public class PlanSetup
  {
    public string Id { get; set; }
    public StructureSet StructureSet { get; set; }
    public List<GenericBeam> Beams { get; set; } = new List<GenericBeam>();

    public PlanSetup(string id, StructureSet structureSet, List<GenericBeam> beams)
    {
      Id = id;
      StructureSet = structureSet;
      Beams = beams;
    }
  }
}
