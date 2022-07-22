using System.Collections.Generic;
using System.Runtime.InteropServices;
using Pml.Personal;

namespace Pml.PokePara;

public class CoreParam
{
	public class WazaLearnWork
	{
		private WazaNo[] m_checkedWazaArray;

		private uint m_checkedWazaNum;

		public void Clear()
		{
		}

		public void AddCheckedWaza(WazaNo waza)
		{
		}

		public bool IsCheckedWaza(WazaNo waza)
		{
			return default(bool);
		}
	}

	public class FormChangeResult
	{
		private WazaNo[] m_addedWaza;

		private WazaNo[] m_removedWaza;

		private WazaNo[] m_addFailedWaza;

		public byte GetAddedWazaNum()
		{
			return default(byte);
		}

		public WazaNo GetAddedWaza(byte idx)
		{
			return default(WazaNo);
		}

		public byte GetRemovedWazaNum()
		{
			return default(byte);
		}

		public WazaNo GetRemovedWaza(byte idx)
		{
			return default(WazaNo);
		}

		public byte GetAddFailedWazaNum()
		{
			return default(byte);
		}

		public WazaNo GetAddFaildedWaza(byte idx)
		{
			return default(WazaNo);
		}

		public void Clear()
		{
		}

		public void SetAddedWaza(WazaNo wazano)
		{
		}

		public void SetRemovedWaza(WazaNo wazano)
		{
		}

		public void SetAddFailedWaza(WazaNo wazano)
		{
		}

		private void add(WazaNo[] pArray, WazaNo wazano)
		{
		}

		private void set(WazaNo[] pArray, WazaNo wazano)
		{
		}

		private WazaNo get(WazaNo[] pArray, byte idx)
		{
			return default(WazaNo);
		}

		private byte getCount(WazaNo[] pArray)
		{
			return default(byte);
		}
	}

	public const int DATASIZE = 328;

	private static byte[] sCoreSerializeBuffer;

	private const byte TOKUSEI_INDEX_ERROR = byte.MaxValue;

	public const byte BIRTH_FRIENDSHIP = 100;

	protected byte[] m_coreData;

	protected byte[] m_calcData;

	protected Accessor m_accessor;

	public byte[] GetCoreData()
	{
		return null;
	}

	public byte[] GetCalcData()
	{
		return null;
	}

	public Accessor GetAccessor()
	{
		return null;
	}

	public static sbyte GetPowerTransformBySeikaku(ushort seikaku, PowerID powerId)
	{
		return default(sbyte);
	}

	public static void CheckPublicDataSize()
	{
	}

	public static bool IsRareFromValue(uint id, uint colorRnd)
	{
		return default(bool);
	}

	public uint GetPower(PowerID powerId)
	{
		return default(uint);
	}

	public uint GetMaxHp()
	{
		return default(uint);
	}

	public uint GetHp()
	{
		return default(uint);
	}

	public void SetHp(uint value)
	{
	}

	public void ReduceHp(uint value)
	{
	}

	public void ReduceNowHp(uint value)
	{
	}

	public void RecoverHp(uint value)
	{
	}

	public void RecoverHpFull()
	{
	}

	public bool IsHpFull()
	{
		return default(bool);
	}

	public bool IsHpZero()
	{
		return default(bool);
	}

	public void RecoverAll()
	{
	}

	public void SetMaxHp(uint value)
	{
	}

	protected void SetAtk(ushort value)
	{
	}

	protected void SetDef(ushort value)
	{
	}

	protected void SetSpAtk(ushort value)
	{
	}

	protected void SetSpDef(ushort value)
	{
	}

	protected void SetAgi(ushort value)
	{
	}

	public bool HaveSick()
	{
		return default(bool);
	}

	public Sick GetSick()
	{
		return default(Sick);
	}

	public void SetSick(Sick sick)
	{
	}

	public void RecoverSick()
	{
	}

	public uint GetLevel()
	{
		return default(uint);
	}

	public uint GetExp()
	{
		return default(uint);
	}

	public void SetExp(uint value)
	{
	}

	public void AddExp(uint value)
	{
	}

	public uint GetExpForCurrentLevel()
	{
		return default(uint);
	}

	public uint GetExpForNextLevel()
	{
		return default(uint);
	}

	public void LevelUp(byte upVal)
	{
	}

	public uint GetBasicPower(PowerID powerID)
	{
		return default(uint);
	}

	public uint GetNativeTalentPower(PowerID powerId)
	{
		return default(uint);
	}

	public uint GetTalentPower(PowerID powerId)
	{
		return default(uint);
	}

	public void ChangeTalentPower(PowerID powerId, uint value)
	{
	}

	public uint GetTalentPowerMaxNum()
	{
		return default(uint);
	}

	public bool IsTrainingDone(PowerID powerId)
	{
		return default(bool);
	}

	public void SetTrainingDone(PowerID powerId)
	{
	}

	public uint GetEffortPower(PowerID powerId)
	{
		return default(uint);
	}

	public uint GetTotalEffortPower()
	{
		return default(uint);
	}

	public void ChangeEffortPower(PowerID powerId, uint value)
	{
	}

	public void AddEffortPower(PowerID powerId, uint value)
	{
	}

	public void SubEffortPower(PowerID powerId, uint value)
	{
	}

	public GState GetGState()
	{
		return default(GState);
	}

	public void SetGState(GState state)
	{
	}

	public bool IsG()
	{
		return default(bool);
	}

	public void ChangeEffortG(byte value)
	{
	}

	public byte GetEffortG()
	{
		return default(byte);
	}

	public void AddEffortG(uint value)
	{
	}

	public void SubEffortG(uint value)
	{
	}

	public uint GetPower_G(PowerID powerID)
	{
		return default(uint);
	}

	public uint GetPower_NotG(PowerID powerID)
	{
		return default(uint);
	}

	public bool IsSpecialGEnable()
	{
		return default(bool);
	}

	public void SetSpecialGEnable()
	{
	}

	public void SetSpecialGDisable()
	{
	}

	public MonsNo GetMonsNo()
	{
		return default(MonsNo);
	}

	public ushort GetFormNo()
	{
		return default(ushort);
	}

	public void ChangeMonsNo(MonsNo newMonsno, ushort newFormno)
	{
	}

	public WazaNo GetWazaNo(byte index)
	{
		return default(WazaNo);
	}

	public byte GetWazaCount()
	{
		return default(byte);
	}

	public bool HaveWaza(WazaNo wazano)
	{
		return default(bool);
	}

	public byte GetWazaIndex(WazaNo wazano)
	{
		return default(byte);
	}

	public void SetDefaultWaza()
	{
	}

	public void PushWaza(WazaNo wazano)
	{
	}

	public void SetWaza(byte wazaIndex, WazaNo wazano)
	{
	}

	public void RemoveWaza(byte wazaIndex)
	{
	}

	public void RemoveDuplicatedWaza()
	{
	}

	public void ExchangeWazaPos(byte pos1, byte pos2)
	{
	}

	public void CloseUpWazaPos()
	{
	}

	public bool CheckWazaMachine(uint machineNo)
	{
		return default(bool);
	}

	public bool CheckWazaRecord(uint recordNo)
	{
		return default(bool);
	}

	public bool CheckWazaOshie(uint oshieNo)
	{
		return default(bool);
	}

	public bool CheckWazaOshie(WazaNo wazano)
	{
		return default(bool);
	}

	public WazaNo GetTamagoWazaNo(byte index)
	{
		return default(WazaNo);
	}

	public void SetTamagoWazaNo(byte index, WazaNo wazano)
	{
	}

	public void ClearTamagoWaza()
	{
	}

	public void InheriteTamagoWaza(CoreParam teacher)
	{
	}

	public WazaLearningResult AddWazaIfEmptyExist(WazaNo wazano)
	{
		return default(WazaLearningResult);
	}

	public WazaLearningResult LearnNewWazaOnCurrentLevel(ref uint sameLevelIndex, ref WazaNo newWazano, [Optional] WazaLearnWork work)
	{
		return default(WazaLearningResult);
	}

	public WazaLearningResult LearnNewWazaOnLevel(byte level, ref uint sameLevelIndex, ref WazaNo newWazano, [Optional] WazaLearnWork work)
	{
		return default(WazaLearningResult);
	}

	public WazaLearningResult LearnNewWazaOnEvolution(ref uint learnIndex, ref WazaNo newWazano, [Optional] WazaLearnWork work)
	{
		return default(WazaLearningResult);
	}

	public HashSet<WazaNo> CollectRemindableWaza()
	{
		return null;
	}

	public uint GetWazaPP(byte wazaIndex)
	{
		return default(uint);
	}

	public uint GetWazaMaxPP(byte index)
	{
		return default(uint);
	}

	public void SetWazaPP(byte wazaIndex, byte value)
	{
	}

	public void ReduceWazaPP(byte wazaIndex, byte value)
	{
	}

	public void RecoverWazaPP(byte wazaIndex)
	{
	}

	public void RecoverWazaPP(byte wazaIndex, byte recvValue)
	{
	}

	public void RecoverWazaPPAll()
	{
	}

	public bool CanUsePointUp(byte wazaIndex)
	{
		return default(bool);
	}

	public void UsePointUp(byte wazaIndex)
	{
	}

	public uint GetWazaPPUpCount(byte wazaIndex)
	{
		return default(uint);
	}

	public void SetWazaPPUpCount(byte wazaIndex, byte value)
	{
	}

	public void IncWazaPPUpCount(byte wazaIndex)
	{
	}

	public bool GetWazaRecordFlag(byte recordIndex)
	{
		return default(bool);
	}

	public void SetWazaRecordFlag(byte recordIndex)
	{
	}

	public void RemoveWazaRecordFlag(byte recordIndex)
	{
	}

	public void ClearWazaRecordFlag()
	{
	}

	public Sex GetSex()
	{
		return default(Sex);
	}

	public byte GetSexVector()
	{
		return default(byte);
	}

	public SexType GetSexType()
	{
		return default(SexType);
	}

	public void ChangeSex(Sex newSex)
	{
	}

	public Seikaku GetSeikaku()
	{
		return default(Seikaku);
	}

	public void ChangeSeikaku(Seikaku seikaku)
	{
	}

	public bool IsSeikakuHigh()
	{
		return default(bool);
	}

	public bool IsSeikakuLow()
	{
		return default(bool);
	}

	public Seikaku GetSeikakuHosei()
	{
		return default(Seikaku);
	}

	public void ChangeSeikakuHosei(Seikaku seikaku)
	{
	}

	public TokuseiNo GetTokuseiNo()
	{
		return default(TokuseiNo);
	}

	public byte GetTokuseiIndex()
	{
		return default(byte);
	}

	public byte GetTokuseiIndexStrict()
	{
		return default(byte);
	}

	public void FlipTokuseiIndex()
	{
	}

	public void SetTokusei3rd()
	{
	}

	public void SetTokuseiIndex(byte tokuseiIndex)
	{
	}

	public void SetFavoriteFlag(bool flag)
	{
	}

	public bool GetFavoriteFlag()
	{
		return default(bool);
	}

	public bool CompareOwnerInfo(OwnerInfo ownerInfo)
	{
		return default(bool);
	}

	public bool UpdateOwnerInfo(OwnerInfo ownerInfo)
	{
		return default(bool);
	}

	public bool IsOwnedOriginalParent()
	{
		return default(bool);
	}

	public bool HaveNickName()
	{
		return default(bool);
	}

	public string GetNickName()
	{
		return null;
	}

	public void SetNickName(string nickName)
	{
	}

	public void SetDefaultNickName()
	{
	}

	public bool IsDefaultNickName()
	{
		return default(bool);
	}

	public uint GetFriendship()
	{
		return default(uint);
	}

	public void SetFriendship(uint value)
	{
	}

	public void AddFriendship(uint value)
	{
	}

	public void SubFriendship(uint value)
	{
	}

	public uint GetOriginalFriendship()
	{
		return default(uint);
	}

	public void SetOriginalFriendship(uint value)
	{
	}

	public void AddOriginalFriendship(uint value)
	{
	}

	public void SubOriginalFriendship(uint value)
	{
	}

	public ushort GetOthersFriendshipTrainerID()
	{
		return default(ushort);
	}

	public uint GetOthersFriendship()
	{
		return default(uint);
	}

	public void SetOthersFriendship(uint value)
	{
	}

	public void AddOthersFriendship(uint value)
	{
	}

	public void SubOthersFriendship(uint value)
	{
	}

	public bool IsEgg(EggCheckType type)
	{
		return default(bool);
	}

	public void SetEggFlag()
	{
	}

	public void ChangeEgg()
	{
	}

	public void Birth()
	{
	}

	public ushort GetItem()
	{
		return default(ushort);
	}

	public void SetItem(ushort itemno)
	{
	}

	public void RemoveItem()
	{
	}

	public void Evolve(MonsNo nextMonsno, uint routeIndex)
	{
	}

	public bool CanEvolve(EvolveSituation situation, PokeParty party, ref MonsNo nextMonsno, ref uint rootNum)
	{
		return default(bool);
	}

	public bool CanEvolveByItem(EvolveSituation situation, ushort itemno, ref MonsNo nextMonsno, ref uint rootNum)
	{
		return default(bool);
	}

	public bool CanEvolveByTrade(CoreParam pairPoke, ref MonsNo nextMonsno, ref uint rootNum)
	{
		return default(bool);
	}

	public bool CanEvolveByEvent(EvolveSituation situation, PokeParty party, ref MonsNo nextMonsno, ref uint rootNum)
	{
		return default(bool);
	}

	public bool HaveEvolutionRoot()
	{
		return default(bool);
	}

	public void ChangeFormNo(ushort nextFormno, [Optional] FormChangeResult pResult)
	{
	}

	public ushort GetNextFormNoFromHoldItem(ushort holdItemno)
	{
		return default(ushort);
	}

	public bool RegulateFormParams()
	{
		return default(bool);
	}

	public bool IsRare()
	{
		return default(bool);
	}

	public uint GetRareRnd()
	{
		return default(uint);
	}

	public RareType GetRareType()
	{
		return default(RareType);
	}

	public uint GetID()
	{
		return default(uint);
	}

	public uint GetPersonalRnd()
	{
		return default(uint);
	}

	public uint GetCheckSum()
	{
		return default(uint);
	}

	public void SetID(uint id)
	{
	}

	public void SetRare()
	{
	}

	public void SetNotRare()
	{
	}

	public void SetRareType(RareType type)
	{
	}

	public PokeType GetType1()
	{
		return default(PokeType);
	}

	public PokeType GetType2()
	{
		return default(PokeType);
	}

	public string GetParentName()
	{
		return null;
	}

	public void SetParentName(string name)
	{
	}

	public Sex GetParentSex()
	{
		return default(Sex);
	}

	public void SetParentSex(Sex sex)
	{
	}

	public uint GetMemories(Memories memoriesKind)
	{
		return default(uint);
	}

	public void SetMemories(Memories memoriesKind, uint value)
	{
	}

	public string GetPastParentsName()
	{
		return null;
	}

	public void SetPastParentsName(string name)
	{
	}

	public Sex GetPastParentsSex()
	{
		return default(Sex);
	}

	public void SetPastParentsSex(Sex sex)
	{
	}

	public byte GetPastParentsLangID()
	{
		return default(byte);
	}

	public void SetPastParentsLangID(byte langID)
	{
	}

	public byte GetCondition(Condition cond)
	{
		return default(byte);
	}

	public void SetCondition(Condition cond, byte value)
	{
	}

	public bool IsBoxMarkSet()
	{
		return default(bool);
	}

	public bool IsBoxMarkSet(BoxMark mark)
	{
		return default(bool);
	}

	public void SetBoxMark(BoxMark mark, BoxMarkColor color)
	{
	}

	public void RemoveBoxMark(BoxMark mark)
	{
	}

	public BoxMarkColor GetBoxMark(BoxMark mark)
	{
		return default(BoxMarkColor);
	}

	public void RemoveAllBoxMark()
	{
	}

	public void SetAllBoxMark(BoxMarkContainer markContainer)
	{
	}

	public void GetAllBoxMark(BoxMarkContainer markContainer)
	{
	}

	public uint GetLangId()
	{
		return default(uint);
	}

	public void SetLangId(uint langId)
	{
	}

	public uint GetCassetteVersion()
	{
		return default(uint);
	}

	public void SetCassetteVersion(uint version)
	{
	}

	public uint GetGetBall()
	{
		return default(uint);
	}

	public void SetGetBall(uint value)
	{
	}

	public byte GetBattleRomMark()
	{
		return default(byte);
	}

	public void SetBattleRomMark(byte battleRomMark)
	{
	}

	public byte GetNadenadeValue()
	{
		return default(byte);
	}

	public void SetNadenadeValue(byte value)
	{
	}

	public void AddNadenadeValue(byte value)
	{
	}

	public void SubNadenadeValue(byte value)
	{
	}

	public PokeType GetMezapaType()
	{
		return default(PokeType);
	}

	public uint GetMezapaPower()
	{
		return default(uint);
	}

	public TasteJudge JudgeTaste(Taste taste)
	{
		return default(TasteJudge);
	}

	public bool HaveRibbon(uint ribbonNo)
	{
		return default(bool);
	}

	public void SetRibbon(uint ribbonNo)
	{
	}

	public void RemoveRibbon(uint ribbonNo)
	{
	}

	public void RemoveAllRibbon()
	{
	}

	public void SetLumpingRibbon(LumpingRibbon ribbonId, uint num)
	{
	}

	public void SetLumpingRibbon(uint ribbonNo, uint num)
	{
	}

	public uint GetLumpingRibbon(LumpingRibbon ribbonId)
	{
		return default(uint);
	}

	public uint GetLumpingRibbon(uint ribbonNo)
	{
		return default(uint);
	}

	public bool IsEquipRibbonExist()
	{
		return default(bool);
	}

	public byte GetEquipRibbonNo()
	{
		return default(byte);
	}

	public void SetEquipRibbonNo(byte ribbonNo)
	{
	}

	public bool HavePokerusJustNow()
	{
		return default(bool);
	}

	public bool HavePokerusUntilNow()
	{
		return default(bool);
	}

	public bool HavePokerusPast()
	{
		return default(bool);
	}

	public void CatchPokerus()
	{
	}

	public void InfectPokerusWith(CoreParam target)
	{
	}

	public void DecreasePokerusDayCount(int passedDayCount)
	{
	}

	public uint GetPokerus()
	{
		return default(uint);
	}

	public void SetPokerus(uint pokerus)
	{
	}

	public bool GetEventPokeFlag()
	{
		return default(bool);
	}

	public void SetEventPokeFlag(bool flag)
	{
	}

	public bool HaveOfficialBattleRights()
	{
		return default(bool);
	}

	public void GrantOfficialBattleRights()
	{
	}

	public void RemoveAllRotomWaza()
	{
	}

	public void SetRotomWaza(byte wazaIndex)
	{
	}

	public LoveLevel CheckLoveLevel(CoreParam partner)
	{
		return default(LoveLevel);
	}

	public bool GetPokeJobFlag(byte jobIndex)
	{
		return default(bool);
	}

	public void SetPokeJobFlag(byte jobIndex)
	{
	}

	public void RemovePokeJobFlag(byte jobIndex)
	{
	}

	public void ClearPokeJobFlag()
	{
	}

	public byte GetCampFriendship()
	{
		return default(byte);
	}

	public void SetCampFriendship(uint value)
	{
	}

	public void AddCampFriendship(uint value)
	{
	}

	public void SubCampFriendship(uint value)
	{
	}

	public byte GetEnjoy()
	{
		return default(byte);
	}

	public void SetEnjoy(uint value)
	{
	}

	public void AddEnjoy(byte value)
	{
	}

	public void SubEnjoy(byte value)
	{
	}

	public uint GetPalma()
	{
		return default(uint);
	}

	public void SetPalma(uint value)
	{
	}

	public bool StartFastMode()
	{
		return default(bool);
	}

	public bool EndFastMode(bool validFlag)
	{
		return default(bool);
	}

	public bool IsFastMode()
	{
		return default(bool);
	}

	public void Clear()
	{
	}

	public bool IsNull()
	{
		return default(bool);
	}

	public bool HaveCalcParam()
	{
		return default(bool);
	}

	public void CopyFrom(CoreParam pSrcParam)
	{
	}

	public void RecalculateCalcData()
	{
	}

	public unsafe virtual void Serialize_Core(void* buffer)
	{
	}

	public virtual void Serialize_Core(byte[] buffer)
	{
	}

	public unsafe virtual void Deserialize_Core(void* serializedData)
	{
	}

	public virtual void Deserialize_Core(byte[] serializedData)
	{
	}

	public CoreParam()
	{
	}

	public CoreParam(MonsNo monsno, ushort level, ulong id)
	{
	}

	public CoreParam(InitialSpec spec)
	{
	}

	protected void InitCoreData()
	{
	}

	protected void SetIllegalParam()
	{
	}

	protected void CheckIllegalParam()
	{
	}

	protected void UpdateCalcDatas(bool keepDead = true)
	{
	}

	protected void UpdateLevel()
	{
	}

	protected void UpdateMaxHP()
	{
	}

	protected void UpdateMaxHpAndCorrectHp(bool keepDead = true)
	{
	}

	protected void UpdateAtk()
	{
	}

	protected void UpdateDef()
	{
	}

	protected void UpdateSpAtk()
	{
	}

	protected void UpdateSpDef()
	{
	}

	protected void UpdateAgi()
	{
	}

	protected uint GetAtk()
	{
		return default(uint);
	}

	protected uint GetDef()
	{
		return default(uint);
	}

	protected uint GetSpAtk()
	{
		return default(uint);
	}

	protected uint GetSpDef()
	{
		return default(uint);
	}

	protected uint GetAgi()
	{
		return default(uint);
	}

	protected byte CalcLevel()
	{
		return default(byte);
	}

	protected ushort CalcMaxHp()
	{
		return default(ushort);
	}

	protected ushort CalcAtk()
	{
		return default(ushort);
	}

	protected ushort CalcDef()
	{
		return default(ushort);
	}

	protected ushort CalcSpAtk()
	{
		return default(ushort);
	}

	protected ushort CalcSpDef()
	{
		return default(ushort);
	}

	protected ushort CalcAgi()
	{
		return default(ushort);
	}

	protected ushort CalcMaxHp_G()
	{
		return default(ushort);
	}

	protected ushort CalcAtk_G()
	{
		return default(ushort);
	}

	protected ushort CalcDef_G()
	{
		return default(ushort);
	}

	protected ushort CalcSpAtk_G()
	{
		return default(ushort);
	}

	protected ushort CalcSpDef_G()
	{
		return default(ushort);
	}

	protected ushort CalcAgi_G()
	{
		return default(ushort);
	}

	protected ushort CalcMaxHp_NotG()
	{
		return default(ushort);
	}

	protected ushort CalcAtk_NotG()
	{
		return default(ushort);
	}

	protected ushort CalcDef_NotG()
	{
		return default(ushort);
	}

	protected ushort CalcSpAtk_NotG()
	{
		return default(ushort);
	}

	protected ushort CalcSpDef_NotG()
	{
		return default(ushort);
	}

	protected ushort CalcAgi_NotG()
	{
		return default(ushort);
	}

	protected void changeWazaByFormChange(ushort nextFormno, [Optional] FormChangeResult pResult)
	{
	}

	protected void changeWazaByFormChange_Learn(WazaNo learnWaza, [Optional] FormChangeResult pResult)
	{
	}

	protected void changeWazaByFormChange_Forget(WazaNo forgetWaza, WazaNo supplyWaza, [Optional] FormChangeResult pResult)
	{
	}

	protected void changeWazaByFormChange_Replace(WazaNo forgetWaza, WazaNo learnWaza, [Optional] FormChangeResult pResult)
	{
	}

	protected uint AdjustEffortPower(uint beforeValue, uint afterValue)
	{
		return default(uint);
	}
}
