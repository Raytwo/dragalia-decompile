namespace Pml.PokePara;

public class Accessor
{
	private struct AccessState
	{
		public bool isEncoded;

		public bool isFastMode;
	}

	private const uint CORE_DATA_SIZE = 328u;

	private const uint CALC_DATA_SIZE = 16u;

	public const uint FULL_SERIALIZE_DATA_SIZE = 344u;

	public const uint CORE_SERIALIZE_DATA_SIZE = 328u;

	private const uint MAX_RIBBON_NUM_ON_RIBBON_FIELD_1 = 32u;

	private const uint MAX_RIBBON_NUM_ON_RIBBON_FIELD_2 = 32u;

	private const uint MAX_RIBBON_NUM_ON_RIBBON_FIELD_3 = 32u;

	private const uint MAX_RIBBON_NUM_ON_RIBBON_FIELD_4 = 32u;

	private const uint MIN_RIBBON_NO_ON_RIBBON_FIELD_1 = 0u;

	private const uint MIN_RIBBON_NO_ON_RIBBON_FIELD_2 = 32u;

	private const uint MIN_RIBBON_NO_ON_RIBBON_FIELD_3 = 64u;

	private const uint MIN_RIBBON_NO_ON_RIBBON_FIELD_4 = 96u;

	private const uint MAX_RIBBON_NO_ON_RIBBON_FIELD_1 = 31u;

	private const uint MAX_RIBBON_NO_ON_RIBBON_FIELD_2 = 63u;

	private const uint MAX_RIBBON_NO_ON_RIBBON_FIELD_3 = 95u;

	private const uint MAX_RIBBON_NO_ON_RIBBON_FIELD_4 = 127u;

	private unsafe static byte* IllegalCoreData;

	private unsafe static byte* DummyWriteCoreData;

	private unsafe static byte* IllegalCalcData;

	private unsafe static byte* DummyWriteCalcData;

	private byte[] m_pCalcData;

	private byte[] m_pCoreData;

	private AccessState m_accessState;

	private const byte POS1 = 0;

	private const byte POS2 = 1;

	private const byte POS3 = 2;

	private const byte POS4 = 3;

	private static readonly byte[][] BLOCK_POS_TABLE;

	public static void Initialize()
	{
	}

	public void AttachDecodedData(byte[] coreData, byte[] calcData)
	{
	}

	public void AttachEncodedData(byte[] coreData, byte[] calcData)
	{
	}

	public bool HaveCalcData()
	{
		return default(bool);
	}

	public void ClearData()
	{
	}

	public void ClearCalcData()
	{
	}

	public void StartFastMode()
	{
	}

	public void EndFastMode()
	{
	}

	public bool IsFastMode()
	{
		return default(bool);
	}

	public bool IsEncoded()
	{
		return default(bool);
	}

	public void Serialize_FullData(byte[] buffer)
	{
	}

	public void Serialize_CoreData(byte[] buffer)
	{
	}

	public void Deserialize_FullData(byte[] serializedData)
	{
	}

	public void Deserialize_CoreData(byte[] serializedData)
	{
	}

	public unsafe void Serialize_FullData(void* buffer)
	{
	}

	public unsafe void Serialize_CoreData(void* buffer)
	{
	}

	public unsafe void Deserialize_FullData(void* serializedData)
	{
	}

	public unsafe void Deserialize_CoreData(void* serializedData)
	{
	}

	public uint GetPersonalRnd()
	{
		return default(uint);
	}

	public uint GetColorRnd()
	{
		return default(uint);
	}

	public uint GetCheckSum()
	{
		return default(uint);
	}

	public bool IsFuseiTamago()
	{
		return default(bool);
	}

	public uint GetSick()
	{
		return default(uint);
	}

	public MonsNo GetMonsNo()
	{
		return default(MonsNo);
	}

	public uint GetItemNo()
	{
		return default(uint);
	}

	public uint GetID()
	{
		return default(uint);
	}

	public uint GetExp()
	{
		return default(uint);
	}

	public uint GetFriendship()
	{
		return default(uint);
	}

	public TokuseiNo GetTokuseiNo()
	{
		return default(TokuseiNo);
	}

	public ushort GetBoxMark()
	{
		return default(ushort);
	}

	public uint GetLangId()
	{
		return default(uint);
	}

	public uint GetEffortHp()
	{
		return default(uint);
	}

	public uint GetEffortAtk()
	{
		return default(uint);
	}

	public uint GetEffortDef()
	{
		return default(uint);
	}

	public uint GetEffortSpAtk()
	{
		return default(uint);
	}

	public uint GetEffortSpDef()
	{
		return default(uint);
	}

	public uint GetEffortAgi()
	{
		return default(uint);
	}

	public byte GetStyle()
	{
		return default(byte);
	}

	public byte GetBeautiful()
	{
		return default(byte);
	}

	public byte GetCute()
	{
		return default(byte);
	}

	public byte GetClever()
	{
		return default(byte);
	}

	public byte GetStrong()
	{
		return default(byte);
	}

	public byte GetFur()
	{
		return default(byte);
	}

	public bool HaveRibbon(uint ribbonNo)
	{
		return default(bool);
	}

	public uint GetLumpingRibbon(LumpingRibbon ribbonId)
	{
		return default(uint);
	}

	public byte GetEquipRibbonNo()
	{
		return default(byte);
	}

	public WazaNo GetWazaNo(byte wazaIndex)
	{
		return default(WazaNo);
	}

	public byte GetPP(byte wazaIndex)
	{
		return default(byte);
	}

	public byte GetWazaPPUpCount(byte wazaIndex)
	{
		return default(byte);
	}

	public WazaNo GetTamagoWazaNo(byte index)
	{
		return default(WazaNo);
	}

	public uint GetTalentHp()
	{
		return default(uint);
	}

	public uint GetTalentAtk()
	{
		return default(uint);
	}

	public uint GetTalentDef()
	{
		return default(uint);
	}

	public uint GetTalentSpAtk()
	{
		return default(uint);
	}

	public uint GetTalentSpDef()
	{
		return default(uint);
	}

	public uint GetTalentAgi()
	{
		return default(uint);
	}

	public uint GetEffortG()
	{
		return default(uint);
	}

	public bool IsEventPokemon()
	{
		return default(bool);
	}

	public bool GetOfficialBattleEnableFlag()
	{
		return default(bool);
	}

	public Sex GetSex()
	{
		return default(Sex);
	}

	public ushort GetFormNo()
	{
		return default(ushort);
	}

	public uint GetSeikaku()
	{
		return default(uint);
	}

	public uint GetSeikakuHosei()
	{
		return default(uint);
	}

	public bool IsTokusei1()
	{
		return default(bool);
	}

	public bool IsTokusei2()
	{
		return default(bool);
	}

	public bool IsTokusei3()
	{
		return default(bool);
	}

	public bool IsFavorite()
	{
		return default(bool);
	}

	public bool IsSpecialGEnable()
	{
		return default(bool);
	}

	public bool IsTamago()
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

	public uint GetCassetteVersion()
	{
		return default(uint);
	}

	public string GetOyaName()
	{
		return null;
	}

	public uint GetTamagoGetYear()
	{
		return default(uint);
	}

	public uint GetTamagoGetMonth()
	{
		return default(uint);
	}

	public uint GetTamagoGetDay()
	{
		return default(uint);
	}

	public uint GetBirthYear()
	{
		return default(uint);
	}

	public uint GetBirthMonth()
	{
		return default(uint);
	}

	public uint GetBirthDay()
	{
		return default(uint);
	}

	public uint GetGetPlace()
	{
		return default(uint);
	}

	public uint GetBirthPlace()
	{
		return default(uint);
	}

	public uint GetPokerus()
	{
		return default(uint);
	}

	public uint GetGetBall()
	{
		return default(uint);
	}

	public uint GetGetLevel()
	{
		return default(uint);
	}

	public Sex GetOyasex()
	{
		return default(Sex);
	}

	public uint GetLevel()
	{
		return default(uint);
	}

	public uint GetHp()
	{
		return default(uint);
	}

	public uint GetMaxHp()
	{
		return default(uint);
	}

	public uint GetAtk()
	{
		return default(uint);
	}

	public uint GetDef()
	{
		return default(uint);
	}

	public uint GetSpAtk()
	{
		return default(uint);
	}

	public uint GetSpDef()
	{
		return default(uint);
	}

	public uint GetAgi()
	{
		return default(uint);
	}

	public GState GetGState()
	{
		return default(GState);
	}

	public byte GetEnjoy()
	{
		return default(byte);
	}

	public byte GetNadenadeValue()
	{
		return default(byte);
	}

	public ushort GetOthersFriendshipTrainerID()
	{
		return default(ushort);
	}

	public bool GetOwnedOthersFlag()
	{
		return default(bool);
	}

	public byte GetOriginalFriendship()
	{
		return default(byte);
	}

	public byte GetOthersFriendship()
	{
		return default(byte);
	}

	public byte GetMemoriesLevel()
	{
		return default(byte);
	}

	public byte GetMemoriesCode()
	{
		return default(byte);
	}

	public ushort GetMemoriesData()
	{
		return default(ushort);
	}

	public byte GetMemoriesFeel()
	{
		return default(byte);
	}

	public byte GetOthersMemoriesLevel()
	{
		return default(byte);
	}

	public byte GetOthersMemoriesCode()
	{
		return default(byte);
	}

	public ushort GetOthersMemoriesData()
	{
		return default(ushort);
	}

	public byte GetOthersMemoriesFeel()
	{
		return default(byte);
	}

	public string GetPastParentsName()
	{
		return null;
	}

	public Sex GetPastParentsSex()
	{
		return default(Sex);
	}

	public byte GetPastParentsLangID()
	{
		return default(byte);
	}

	public bool CompareOyaName(string cmpName)
	{
		return default(bool);
	}

	public uint GetMultiPurposeWork()
	{
		return default(uint);
	}

	public byte GetTrainingFlag()
	{
		return default(byte);
	}

	public bool GetWazaRecordFlag(byte recordIndex)
	{
		return default(bool);
	}

	public bool GetPokeJobFlag(byte jobIndex)
	{
		return default(bool);
	}

	public byte GetCampFriendship()
	{
		return default(byte);
	}

	public uint GetPalma()
	{
		return default(uint);
	}

	public byte GetTalentHeight()
	{
		return default(byte);
	}

	public byte GetTalentWeight()
	{
		return default(byte);
	}

	public byte GetBattleRomMark()
	{
		return default(byte);
	}

	public void SetPersonalRnd(uint rnd)
	{
	}

	public void SetColorRnd(uint rnd)
	{
	}

	public void SetSick(uint sick)
	{
	}

	public void SetFuseiTamagoFlag(bool flag)
	{
	}

	public void SetCheckSum(ushort checksum)
	{
	}

	public void SetMonsNo(uint monsno)
	{
	}

	public void SetItemNo(ushort itemno)
	{
	}

	public void SetID(uint id)
	{
	}

	public void SetExp(uint exp)
	{
	}

	public void SetFriendship(byte friendship)
	{
	}

	public void SetTokuseiNo(uint tokusei)
	{
	}

	public void SetBoxMark(ushort mark)
	{
	}

	public void SetLangId(byte langId)
	{
	}

	public void SetEffortHp(byte value)
	{
	}

	public void SetEffortAtk(byte value)
	{
	}

	public void SetEffortDef(byte value)
	{
	}

	public void SetEffortSpAtk(byte value)
	{
	}

	public void SetEffortSpDef(byte value)
	{
	}

	public void SetEffortAgi(byte value)
	{
	}

	public void SetStyle(byte style)
	{
	}

	public void SetBeautiful(byte beautiful)
	{
	}

	public void SetCute(byte cute)
	{
	}

	public void SetClever(byte clever)
	{
	}

	public void SetStrong(byte strong)
	{
	}

	public void SetFur(byte fur)
	{
	}

	public void SetRibbon(uint ribbonNo)
	{
	}

	public void RemoveRibbon(uint ribbonNo)
	{
	}

	public void SetLumpingRibbon(LumpingRibbon ribbonId, uint num)
	{
	}

	public void SetEquipRibbonNo(byte ribbonNo)
	{
	}

	public void SetWazaNo(byte wazaIndex, uint wazano)
	{
	}

	public void SetPP(byte wazaIndex, byte pp)
	{
	}

	public void SetWazaPPUpCount(byte wazaIndex, byte count)
	{
	}

	public void SetTamagoWazaNo(byte index, uint wazano)
	{
	}

	public void SetTalentHp(byte value)
	{
	}

	public void SetTalentAtk(byte value)
	{
	}

	public void SetTalentDef(byte value)
	{
	}

	public void SetTalentSpAtk(byte value)
	{
	}

	public void SetTalentSpDef(byte value)
	{
	}

	public void SetTalentAgi(byte value)
	{
	}

	public void SetEffortG(byte value)
	{
	}

	public void SetEventPokemonFlag(bool flag)
	{
	}

	public void SetOfficialBattleEnableFlag(bool flag)
	{
	}

	public void SetSex(Sex sex)
	{
	}

	public void SetFormNo(ushort formno)
	{
	}

	public void SetSeikaku(uint seikaku)
	{
	}

	public void SetSeikakuHosei(uint seikaku)
	{
	}

	public void SetTamagoFlag(bool flag)
	{
	}

	public void SetTokusei1Flag(bool flag)
	{
	}

	public void SetTokusei2Flag(bool flag)
	{
	}

	public void SetTokusei3Flag(bool flag)
	{
	}

	public void SetFavoriteFlag(bool flag)
	{
	}

	public void SetSpecialGFlag(bool flag)
	{
	}

	private unsafe void copyString(char* dst, string _src, int dst_len)
	{
	}

	public void SetNickName(string nickName)
	{
	}

	public void SetNickNameFlag(bool flag)
	{
	}

	public void SetCassetteVersion(uint version)
	{
	}

	public void SetOyaName(string oyaName)
	{
	}

	public void SetTamagoGetYear(byte year)
	{
	}

	public void SetTamagoGetMonth(byte month)
	{
	}

	public void SetTamagoGetDay(byte day)
	{
	}

	public void SetBirthYear(byte year)
	{
	}

	public void SetBirthMonth(byte month)
	{
	}

	public void SetBirthDay(byte day)
	{
	}

	public void SetGetPlace(ushort place)
	{
	}

	public void SetBirthPlace(ushort place)
	{
	}

	public void SetPokerus(byte pokerus)
	{
	}

	public void SetGetBall(byte ball)
	{
	}

	public void SetGetLevel(byte level)
	{
	}

	public void SetOyasex(Sex sex)
	{
	}

	public void SetLevel(byte level)
	{
	}

	public void SetMaxHp(ushort maxHp)
	{
	}

	public void SetHp(ushort hp)
	{
	}

	public void SetAtk(ushort atk)
	{
	}

	public void SetDef(ushort def)
	{
	}

	public void SetSpAtk(ushort spatk)
	{
	}

	public void SetSpDef(ushort spdef)
	{
	}

	public void SetAgi(ushort agi)
	{
	}

	public void SetGState(GState state)
	{
	}

	public void SetEnjoy(byte enjoy)
	{
	}

	public void SetNadenadeValue(byte value)
	{
	}

	public void SetOthersFriendshipTrainerID(ushort trainerId)
	{
	}

	public void SetOwnedOthersFlag(bool flag)
	{
	}

	public void SetOriginalFriendship(byte friendship)
	{
	}

	public void SetOthersFriendship(byte friendship)
	{
	}

	public void SetMemoriesLevel(byte level)
	{
	}

	public void SetMemoriesCode(byte code)
	{
	}

	public void SetMemoriesData(ushort data)
	{
	}

	public void SetMemoriesFeel(byte feel)
	{
	}

	public void SetOthersMemoriesLevel(byte level)
	{
	}

	public void SetOthersMemoriesCode(byte code)
	{
	}

	public void SetOthersMemoriesData(ushort data)
	{
	}

	public void SetOthersMemoriesFeel(byte feel)
	{
	}

	public void SetPastParentsName(string name)
	{
	}

	public void SetPastParentsSex(Sex sex)
	{
	}

	public void SetPastParentsLangID(byte langID)
	{
	}

	public void SetMultiPurposeWork(uint value)
	{
	}

	public void SetTrainingFlag(byte value)
	{
	}

	public void SetWazaRecordFlag(byte recordIndex, bool set)
	{
	}

	public void ClearWazaRecordFlag()
	{
	}

	public void SetPokeJobFlag(byte jobIndex, bool set)
	{
	}

	public void ClearPokeJobFlag()
	{
	}

	public void SetCampFriendship(byte value)
	{
	}

	public void SetPalma(uint value)
	{
	}

	public void SetTalentHeight(byte value)
	{
	}

	public void SetTalentWeight(byte value)
	{
	}

	public void SetBattleRomMark(byte value)
	{
	}

	public void RemoveAllRibbon()
	{
	}

	private unsafe CalcData* GetCalcData(byte* _addr, bool forWrite)
	{
		//IL_0002: Expected I, but got O
		return (CalcData*)unchecked((nint)null);
	}

	private unsafe CoreDataBlockA* GetCoreDataBlockA(byte* _addr, bool forWrite)
	{
		//IL_0002: Expected I, but got O
		return (CoreDataBlockA*)unchecked((nint)null);
	}

	private unsafe CoreDataBlockB* GetCoreDataBlockB(byte* _addr, bool forWrite)
	{
		//IL_0002: Expected I, but got O
		return (CoreDataBlockB*)unchecked((nint)null);
	}

	private unsafe CoreDataBlockC* GetCoreDataBlockC(byte* _addr, bool forWrite)
	{
		//IL_0002: Expected I, but got O
		return (CoreDataBlockC*)unchecked((nint)null);
	}

	private unsafe CoreDataBlockD* GetCoreDataBlockD(byte* _addr, bool forWrite)
	{
		//IL_0002: Expected I, but got O
		return (CoreDataBlockD*)unchecked((nint)null);
	}

	protected unsafe static CoreDataHeader* GetCoreDataHeader(byte* addr)
	{
		//IL_0002: Expected I, but got O
		return (CoreDataHeader*)unchecked((nint)null);
	}

	private static byte GetCoreDataBlockPos(uint key, CoreDataBlockId blockId)
	{
		return default(byte);
	}

	private void UpdateChecksumAndEncode()
	{
	}

	public static void updateChecksumAndEncode_Core(byte[] pCoreData)
	{
	}

	private static void updateChecksumAndEncode_Calc(byte[] pCoreData, byte[] pCalcData)
	{
	}

	private void DecodeAndCheckIllegalWrite()
	{
	}

	private unsafe void Serialize(void* bufferForCore, void* bufferForCalc)
	{
	}

	private unsafe void Deserialize(void* serializedCoreData, void* serializedCalcData)
	{
	}

	private static void CalcWazaRecordBitPos(out byte arrayIndex, out byte bitFlag, byte recordIndex)
	{
	}

	private static void CalcPokeJobBitPos(out byte arrayIndex, out byte bitFlag, byte jobIndex)
	{
	}
}
