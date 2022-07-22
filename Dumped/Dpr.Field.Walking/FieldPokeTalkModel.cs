using System.Collections.Generic;
using Dpr.SubContents;
using Pml;
using Pml.PokePara;
using XLSXContent;

namespace Dpr.Field.Walking;

public sealed class FieldPokeTalkModel
{
	public class MonohiroiLottery : IHaveWeight
	{
		private float rate;

		public int MstID;

		public float lotteryWeight => default(float);

		public MonohiroiLottery(int Rate, int MstID)
		{
		}
	}

	private PokemonParam param;

	private List<FieldWalkingPokeTalk.SheetSheet1> talkList;

	private int MonohiroiItemID;

	private float walkDistance_nakayoshi;

	private float walkDistance_monohiroi;

	private uint friendship;

	private float HPRate;

	private Sick sick;

	private PokeType type;

	private uint walkCount;

	private WalkingCharacterController Controller;

	private FieldWalkingPokeTalk.SheetSheet1 SelectedAction;

	public FieldWalkingPokeTalk.SheetSheet1 PrevTalk;

	public bool isBadStateTalk;

	public static readonly PokeType[] PokeTypeArray;

	public static readonly int[] MonohiroiKakuritu;

	private List<FieldWalkingKinomiTable.SheetA> kinomiTableA;

	private List<FieldWalkingKinomiTable.SheetB> kinomiTableB;

	private List<FieldWalkingKinomiTable.SheetC> kinomiTableC;

	private List<FieldWalkingKinomiSeikakuTable.SheetSheet1> seikakuTable;

	public int button002;

	public int DebugTime;

	public int button001;

	public FieldPokeTalkModel(WalkingCharacterController Controller, PokemonParam param, List<FieldWalkingPokeTalk.SheetSheet1> talkList, FieldWalkingKinomiTable kinomiTable, List<FieldWalkingKinomiSeikakuTable.SheetSheet1> seikakuTable)
	{
	}

	public void WalkUpdate(float deltaDistance)
	{
	}

	private void DebugTimeSave()
	{
	}

	private int GetTimeAndCount()
	{
		return default(int);
	}

	private int GetMonohiroiCount()
	{
		return default(int);
	}

	private void AddMonohiroiCount()
	{
	}

	private int[] GetTimeAndCountArray()
	{
		return null;
	}

	private bool Check4Hour()
	{
		return default(bool);
	}

	private int GetHourDiff(int prevHour, int nowHour)
	{
		return default(int);
	}

	private int GetMinutesDiff(int prevMinutes, int nowMinutes)
	{
		return default(int);
	}

	public void StartTalk()
	{
	}

	private int AnimNameToID(string animName)
	{
		return default(int);
	}

	private void CheckState()
	{
	}

	private int GetVoiceID()
	{
		return default(int);
	}

	private int GetAnimID()
	{
		return default(int);
	}

	public bool IsMonohiroi()
	{
		return default(bool);
	}

	private bool LotteryMonohiroi()
	{
		return default(bool);
	}

	private int GetTableID()
	{
		return default(int);
	}

	private int LotteryItem(int tableID)
	{
		return default(int);
	}

	public void ResetItem()
	{
	}

	private void LotteryTalkMessage()
	{
	}

	public int GetItemID()
	{
		return default(int);
	}
}
