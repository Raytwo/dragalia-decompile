namespace Dpr.SequenceEditor;

public class ParticleCreate : Macro
{
	public string file;

	public bool isBallEffect;

	public bool isCapture;

	public bool isStreamLineEffect;

	public bool isAttrEffect;

	public int index;

	public bool isMulti;

	public SEQ_DEF_EFF_DRAWTYPE drawType;

	public SEQ_DEF_ROTATE_ORDER rotOrder;

	public int forceCalc;

	public bool subCamera;

	public SEQ_DEF_PARTICLE_DELETE deleteType;

	public ParticleCreate(Macro macro)
	{
	}
}
