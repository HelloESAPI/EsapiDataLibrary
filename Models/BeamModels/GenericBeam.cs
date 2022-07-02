using EsapiDataLibrary.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsapiDataLibrary.Models
{
  public class GenericBeam
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
    /// The positions of the beam collimator leaf pairs in millimeters, and in the IEC
    /// <para>BEAMLIMITING DEVICE coordinate axis appropriate to the MLC device type. For example,</para>
    /// <para>the X-axis for MLCX and the Y-axis for MLCY. The two-dimensional array is indexed</para>
    /// <para>[bank, leaf] where the bank is either 0 or 1. Bank 0 represents the leaf bank</para>
    /// <para>to the negative MLC X direction, and bank 1 to the positive MLC X direction.</para>
    /// <para></para>Passing null selects the default.</para>
    /// </summary>
    public float[,] LeafPositions { get; set; } = null;
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
    /// The stop angle of the gantry, in degrees.
    /// </summary>
    public double? GantryStop { get; set; }
    /// <summary>
    /// The direction of the arc.
    /// </summary>
    public GantryDirection GantryDirection { get; set; }
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
