using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsapiDataLibrary.Models
{
  /// <summary>
  /// dummy data model to allow debugging, etc. and not having to run in eclipse -> for demos only
  /// </summary>
  public class StructureSet
  {
    public string Id { get; set; }
    public List<Structure> Structures { get; set; }
    public StructureSet()
    {
      Id = string.Empty;
      Structures = new List<Structure>();
    }
    public StructureSet(string id, List<Structure> structures)
    {
      Id = id;
      Structures = structures; 
    }
  }
}
