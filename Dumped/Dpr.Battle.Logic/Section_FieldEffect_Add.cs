using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FieldEffect_Add : Section
{
	public class Description
	{
		public byte pokeID;

		public EffectType effect;

		public BtlGround ground;

		public ChangeGroundCause ground_cause;

		public BTL_SICKCONT cont;

		public ushort successEffectNo;

		public StrParam successMessage;

		public bool isAddDependPoke;

		public bool isDisplayTokuseiWindow;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	private struct getDefaultSuccessMessage_GroundTableElem
	{
		public BtlGround ground;

		public int strID_others;

		public int strID_onBattleStart;

		public getDefaultSuccessMessage_GroundTableElem(BtlGround ground, int strID_others, int strID_onBattleStart)
		{
		}
	}

	private static readonly getDefaultSuccessMessage_GroundTableElem[] STR_TABLE;

	public Section_FieldEffect_Add([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	public bool changeGround(byte pokeID, byte ground, [In] ref BTL_SICKCONT contParam, ChangeGroundCause cause)
	{
		return default(bool);
	}

	public void getDefaultSuccessMessage_Ground(StrParam pStrParam, byte ground, ChangeGroundCause cause)
	{
	}

	private bool addFieldEffect(EffectType effect, [In] ref BTL_SICKCONT contParam, bool isAddDependTry)
	{
		return default(bool);
	}

	private void afterFieldEffectAdd(byte pokeID, EffectType effect)
	{
	}

	private void afterFieldEffectAdd_KagakuhenkaGas(byte pokeID)
	{
	}

	private bool getFrontPokes(PokeSet targets)
	{
		return default(bool);
	}

	private void sortByAgility(PokeSet targets)
	{
	}

	private void juryokuCheck(byte pokeID)
	{
	}
}
