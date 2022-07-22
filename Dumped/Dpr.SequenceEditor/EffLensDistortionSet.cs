namespace Dpr.SequenceEditor;

public class EffLensDistortionSet : Macro
{
	public SEQ_DEF_MODETYPE mode;

	public float power;

	public float Ufov;

	public float Afov;

	public float ScaleW;

	public float ScaleH;

	public float OffsetX;

	public float OffsetY;

	public SEQ_DEF_MOVETYPE move;

	public bool subCamera;

	public EffLensDistortionSet(Macro macro)
	{
	}
}
