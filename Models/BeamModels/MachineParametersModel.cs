namespace EsapiDataLibrary.Models
{
  public class MachineParametersModel
  {
    /// <summary>
    /// The treatment unit identifier.
    /// </summary>
    public string MachineId { get; set; }
    /// <summary>
    /// The energy mode identifier. For example, "6X", or "18X".
    /// </summary>
    public string EnergyModeId { get; set; }
    /// <summary>
    /// Dose rate value.
    /// </summary>
    public int DoseRate { get; set; }
    /// <summary>
    /// Primary Fluence Mode ID. Acceptable values are: null, empty string, "SRS","FFF".
    /// </summary>
    public string PrimaryFluenceModel { get; set; }
    /// <summary>
    /// Technique identifier. Typically "STATIC" or "ARC".
    /// </summary>
    public string TechniqueId { get; set; }

    public MachineParametersModel(string machineId, string energyModeId, int doseRate, string primaryFluenceModel, string techniqueId)
    {
      MachineId = machineId;
      EnergyModeId = energyModeId;
      DoseRate = doseRate;
      PrimaryFluenceModel = primaryFluenceModel;
      TechniqueId = techniqueId;
    }
  }
}
