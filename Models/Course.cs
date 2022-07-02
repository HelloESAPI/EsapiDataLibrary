using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsapiDataLibrary.Models
{
  public class Course
  {
    public string Id { get; set; }
    public List<PlanSetup> PlanSetups { get; set; }

    public Course(string id, List<PlanSetup> planSetups)
    {
      Id = id;
      PlanSetups = planSetups;
    }
  }
}
