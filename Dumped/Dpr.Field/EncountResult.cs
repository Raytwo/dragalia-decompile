using Dpr.Trainer;
using Pml;
using Pml.PokePara;

namespace Dpr.Field;

public class EncountResult
{
	public enum BtlType
	{
		Single,
		Double,
		Safari,
		MovePoke
	}

	public BtlType Type;

	public MonsNo[] Enemy;

	public int[] Level;

	public Sex[] FixSex;

	public Seikaku[] FixSeikaku;

	public bool IsRare;

	public TrainerID Partner;

	public TokuseiNo HatudouTokusei;

	public ArenaID BattleBG;

	public int MP_SaveIndex;

	public bool IsKakure;

	public int karanaForm;

	public int annoForm;
}
