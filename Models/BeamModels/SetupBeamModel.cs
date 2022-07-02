using EsapiDataLibrary.Interfaces;
using EsapiDataLibrary.Types;

namespace EsapiDataLibrary.Models
{
  public class SetupBeamModel : IBeam
  {
    /// <summary>
    /// Beam Id
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Beam type
    /// </summary>
    public BeamType BeamType { get; set; }
    /// <summary>
    /// Value to add to the field/beam if inclined
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Configuration of the used treatment unit. See VMS.TPS.Common.Model.Types.ExternalBeamMachineParameters.
    /// </summary>
    public MachineParametersModel MachineParameters { get; set; }
    /// <summary>
    /// The jaw positions of the treatment beam in millimeters, and in IEC BEAM LIMITING DEVICE coordinates.
    /// </summary>
    public VRect<double> JawPositions { get; set; }
    /// <summary>
    /// The orientation of the IEC BEAM LIMITING DEVICE coordinate system with respect
    ///     to the IEC GANTRY coordinate system (in degrees).
    /// </summary>
    public double CollimatorAngle { get; set; }
    /// <summary>
    /// The orientation of the IEC GANTRY coordinate system with respect to the IEC FIXED
    ///     REFERENCE coordinate system (in degrees).
    /// </summary>
    public double GantryAngle { get; set; }
    /// <summary>
    /// The orientation of the IEC PATIENT SUPPORT (turntable) coordinate system with
    ///     respect to the IEC FIXED REFERENCE coordinate system (in degrees).
    /// </summary>
    public double PatientSupportAngle { get; set; }
    /// <summary>
    /// The isocenter position, in millimeters.
    /// </summary>
    public VVector Isocenter { get; set; }
  }
}
