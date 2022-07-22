using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;
using Pml.Item;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic.Handler;

public static class Item
{
	public delegate EventFactor.EventHandlerTable[] HandlerGetFunc();

	private struct GET_FUNC_TABLE_ELEM
	{
		public ItemNo itemno;

		public HandlerGetFunc func;

		public GET_FUNC_TABLE_ELEM(ItemNo itemno, HandlerGetFunc func)
		{
		}
	}

	private struct GuardTargetElem
	{
		public DamageCause damageCause;

		public bool messageEnable;

		public GuardTargetElem(DamageCause damageCause, bool messageEnable)
		{
		}
	}

	private struct GuardTargetRankElem
	{
		public RankEffectCause effectCause;

		public bool messageEnable;

		public GuardTargetRankElem(RankEffectCause effectCause, bool messageEnable)
		{
		}
	}

	private const int FALSE = 0;

	private const int TRUE = 1;

	public const int WORKIDX_TMP_FLAG = 6;

	private static readonly GET_FUNC_TABLE_ELEM[] GET_FUNC_TABLE;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KuraboNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KagoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ChigoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NanasiNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MomonNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KiiNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RamNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HimeriNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OrenNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KinomiJuice;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ObonNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TarapuNoMi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FiraNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UiNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BanziNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TiiraNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RyugaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KamuraNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YatapiNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ZuaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SanNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SutaaNomi;

	private static readonly WazaRankEffect[] rankTypeTbl;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NazoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OkkaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ItokeNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SokunoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RindoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YacheNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YopuNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BiarNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SyukaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BakouNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UtanNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TangaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YorogiNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KasibuNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HabanNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NamoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RiribaNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HozuNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RozeruNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IbanNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MikuruNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_JapoNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RenbuNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TotugekiChokki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_JyakutenHoken;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SiroiHerb;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MentalHerb;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KaraburiHoken;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HikarinoKona;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KyouseiGipusu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SenseiNoTume;

	private const int WIDX_SENSEINOTUME_RAND_CHECK_DONE = 0;

	private const int WIDX_SENSEINOTUME_RAND_CHECK_CLEAR = 1;

	private const int WIDX_SENSEINOTUME_USE_DONE = 2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KoukouNoSippo;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OujaNoSirusi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SurudoiKiba;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KoukakuLens;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PintLens;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_LuckyPunch;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Naganegi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FocusLens;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NonkiNoOkou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ChikaraNoHachimaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MonosiriMegane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SinkaiNoKiba;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SinkaiNoUroko;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MetalPowder;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SpeedPowder;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FutoiHone;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KodawariHachimaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KodawariMegane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KodawariScarf;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KiaiNoTasuki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KiaiNoHachimaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TatsujinNoObi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_InochiNoTama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MetroNome;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NebariNoKagidume;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KaigaraNoSuzu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HikariNoNendo;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowefulHarb;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tabenokosi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KuroiHedoro;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AkaiIto;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KuttukiBari;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerWrist;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerBelt;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerLens;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerBand;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerAnkle;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerWeight;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HinotamaPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SizukuPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IkazutiPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MirodinoPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TuraranoPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KobusinoPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MoudokuPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DaitinoPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AozoraPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HusiginoPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TamamusiPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GansekiPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MononokePlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RyuunoPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KowamotePlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KoutetsuPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SeireiPlate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OokinaNekko;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kemuridama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OmamoriKoban;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HakkinDama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TumetaiIwa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SarasaraIwa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AtuiIwa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SimettaIwa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DenkiDama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DokudokuDama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KaenDama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GinNoKona;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YawarakaiSuna;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KataiIsi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KisekiNoTane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KuroiMegane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kuroobi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Zisyaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MetalCoat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SinpiNoSizuku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SurudoiKutibasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dokubari;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TokenaiKoori;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NoroiNoOfuda;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagattaSupuun;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Mokutan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RyuunoKiba;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SirukuNoSukaafu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AyasiiOkou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GansekiOkou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SazanamiNoOkou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UsioNoOkou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OhanaNoOkou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KokoroNoSizuku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Siratama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kongoudama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KuroiTekkyuu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Karuisi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SinkanoKiseki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GotugotuMet;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Huusen;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RedCard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NerainoMato;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SimetukeBand;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kyuukon;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AkkiNomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HikariGoke;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yukidama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Juudenti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NodoAme;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DassyutuButton;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DassyutuPack;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BoujinGoggle;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BannouGasa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HonooNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MizuNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DenkiNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KusaNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KooriNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KakutouJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DokuNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_JimenNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HikouNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_EsperJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MusiNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IwaNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GhostJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DragonJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AkuNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HaganeNoJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NormalJuel;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YouseiJuel;

	private const int JUEL_SEQ_NULL = 0;

	private const int JUEL_SEQ_STANDBY = 1;

	private const int JUEL_SEQ_END = 2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Aiironotama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Beniironotama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GroundCoat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Bibiridama;

	private const int BIBIRIDAMA_STAT_NONE = 0;

	private const int BIBIRIDAMA_STAT_READY = 1;

	private const int BIBIRIDAMA_STAT_DONE = 2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ElecSeed;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PhychoSeed;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MistSeed;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GrassSeed;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RoomService;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BougoPad;

	private static readonly GuardTargetElem[] handler_BougoPad_SimpleDamageEnable_GUARD_TARGETS;

	private static readonly GuardTargetRankElem[] handler_BougoPad_RankEffect_LastCheck_GUARD_TARGETS;

	private const int BOUGOPAD_WORK_INDEX_GUARD = 0;

	private const int BOUGOPAD_WORK_INDEX_MESSAGE = 1;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AtuzokoBoots;

	public static HandlerGetFunc getHandlerGetFunc(ItemNo itemNo)
	{
		return null;
	}

	public static EventFactor addHandler(EventSystem pEventSystem, BTL_POKEPARAM bpp, ushort itemNo)
	{
		return null;
	}

	public static void Add(EventSystem pEventSystem, BTL_POKEPARAM bpp)
	{
	}

	public static void Remove(EventSystem pEventSystem, BTL_POKEPARAM bpp)
	{
	}

	public static EventFactor TMP_Add(EventSystem pEventSystem, BTL_POKEPARAM bpp, ushort itemNo)
	{
		return null;
	}

	public static void TMP_Remove(EventSystem pEventSystem, EventFactor factor)
	{
	}

	public static bool isOccurPer([In] ref EventFactor.EventHandlerArgs args, byte per)
	{
		return default(bool);
	}

	public static int common_GetItemParam(EventFactor factor, Pml.Item.ItemData.PrmID paramID)
	{
		return default(int);
	}

	public static int item_AttackValue_to_Ratio(EventFactor factor)
	{
		return default(int);
	}

	public static void itemPushRun([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool isPOKEID([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool isPOKEID_ATK([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool isPOKEID_DEF([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static byte getPOKEID_ATK([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(byte);
	}

	public static byte getWAZA_TYPE([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(byte);
	}

	public static bool getMIGAWARI_FLAG([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}

	public static TypeAffinity.AffinityID getTYPEAFF([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(TypeAffinity.AffinityID);
	}

	public static BTL_SICKCONTOBJ getSickContAddress([In] ref EventFactor.EventHandlerArgs args)
	{
		return null;
	}

	public static bool isMonsNo([In] ref EventFactor.EventHandlerArgs args, byte pokeID, ushort MonsNo)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_KuraboNomi()
	{
		return null;
	}

	public static void handler_KuraboNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KuraboNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KagoNomi()
	{
		return null;
	}

	public static void handler_KagoNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KagoNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ChigoNomi()
	{
		return null;
	}

	public static void handler_ChigoNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ChigoNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NanasiNomi()
	{
		return null;
	}

	public static void handler_NanasiNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NanasiNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MomonNomi()
	{
		return null;
	}

	public static void handler_MomonNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MomonNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KiiNomi()
	{
		return null;
	}

	public static void handler_KiiNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KiiNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RamNomi()
	{
		return null;
	}

	public static void handler_RamNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_RamNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_sickReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSickEx sickCode)
	{
	}

	public static bool common_useForSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSickEx sickCode, ushort itemID)
	{
		return default(bool);
	}

	public static bool common_sickcode_match([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSickEx sickCode)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_HimeriNomi()
	{
		return null;
	}

	public static void handler_HimeriNomi_wazaEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HimeriNomi_reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HimeriNomi_get([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HimeriNomi_ppDec([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HimeriNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HimeriNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static byte common_Himeri_LastWazaIdx([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(byte);
	}

	public static byte common_Himeri_EnableWazaIdx([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(byte);
	}

	public static bool handler_HimeriNomi_common([In] ref EventFactor.EventHandlerArgs args, byte pokeID, bool fDouble, bool fUseTmp)
	{
		return default(bool);
	}

	public static byte handler_HimeriNomi_GetTargetWazaIndex([In] ref EventFactor.EventHandlerArgs args, byte pokeID, bool fUseTmp)
	{
		return default(byte);
	}

	public static EventFactor.EventHandlerTable[] ADD_OrenNomi()
	{
		return null;
	}

	public static void handler_OrenNomi_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_OrenNomi_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_OrenNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_OrenUse([In] ref EventFactor.EventHandlerArgs args, byte pokeID, bool fDuble)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KinomiJuice()
	{
		return null;
	}

	public static void handler_KinomiJuce_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ObonNomi()
	{
		return null;
	}

	public static void handler_ObonNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TarapuNoMi()
	{
		return null;
	}

	public static void handler_TarapuNoMi_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TarapuNoMi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FiraNomi()
	{
		return null;
	}

	public static void handler_FiraNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FiraNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UiNomi()
	{
		return null;
	}

	public static void handler_UiNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_UiNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagoNomi()
	{
		return null;
	}

	public static void handler_MagoNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagoNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BanziNomi()
	{
		return null;
	}

	public static void handler_BanjiNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BanjiNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IaNomi()
	{
		return null;
	}

	public static void handler_IaNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_IaNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_KaifukuKonran_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_KaifukuKonran_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_KaifukuKonran([In] ref EventFactor.EventHandlerArgs args, byte pokeID, Taste taste, ushort itemID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TiiraNomi()
	{
		return null;
	}

	public static void handler_TiiraNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TiiraNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RyugaNomi()
	{
		return null;
	}

	public static void handler_RyugaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_RyugaNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KamuraNomi()
	{
		return null;
	}

	public static void handler_KamuraNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KamuraNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YatapiNomi()
	{
		return null;
	}

	public static void handler_YatapiNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_YatapiNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ZuaNomi()
	{
		return null;
	}

	public static void handler_ZuaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ZuaNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SanNomi()
	{
		return null;
	}

	public static void handler_SanNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SanNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SutaaNomi()
	{
		return null;
	}

	public static void handler_SutaaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SutaaNomi_Tmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_PinchRankup([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaRankEffect rankType, byte volume, ushort itemID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NazoNomi()
	{
		return null;
	}

	public static void handler_NazoNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NazoNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OkkaNomi()
	{
		return null;
	}

	public static void handler_OkkaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ItokeNomi()
	{
		return null;
	}

	public static void handler_ItokeNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SokunoNomi()
	{
		return null;
	}

	public static void handler_SokunoNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RindoNomi()
	{
		return null;
	}

	public static void handler_RindoNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YacheNomi()
	{
		return null;
	}

	public static void handler_YacheNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YopuNomi()
	{
		return null;
	}

	public static void handler_YopuNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BiarNomi()
	{
		return null;
	}

	public static void handler_BiarNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SyukaNomi()
	{
		return null;
	}

	public static void handler_SyukaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BakouNomi()
	{
		return null;
	}

	public static void handler_BakouNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UtanNomi()
	{
		return null;
	}

	public static void handler_UtanNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TangaNomi()
	{
		return null;
	}

	public static void handler_TangaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YorogiNomi()
	{
		return null;
	}

	public static void handler_YorogiNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KasibuNomi()
	{
		return null;
	}

	public static void handler_KasibuNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HabanNomi()
	{
		return null;
	}

	public static void handler_HabanNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NamoNomi()
	{
		return null;
	}

	public static void handler_NamoNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RiribaNomi()
	{
		return null;
	}

	public static void handler_RiribaNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HozuNomi()
	{
		return null;
	}

	public static void handler_HozuNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RozeruNomi()
	{
		return null;
	}

	public static void handler_RozeruNomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_WeakAff_Relieve([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte type, bool fIgnoreAffine)
	{
		return default(bool);
	}

	public static void handler_common_WeakAff_DmgAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PinchReactCommon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PinchReactMemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_DamageReact([In] ref EventFactor.EventHandlerArgs args, byte pokeID, uint n, bool fCheckReactionType)
	{
	}

	public static bool common_DamageReactCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID, uint n)
	{
		return default(bool);
	}

	public static bool common_DamageReactCheckCore([In] ref EventFactor.EventHandlerArgs args, byte pokeID, uint n)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_IbanNomi()
	{
		return null;
	}

	public static void handler_IbanNomi_SpPriorityCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_IbanNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_Kinomi_UseTmp_OnlyConsume([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MikuruNomi()
	{
		return null;
	}

	public static void handler_MikuruNomi_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MikuruNomi_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MikuruNomi_ActProcEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MikuruNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MikuruNomi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_JapoNomi()
	{
		return null;
	}

	public static void handler_JapoNomi_Damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_JapoNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_JapoRenbu_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaDamageType dmgType)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RenbuNomi()
	{
		return null;
	}

	public static void handler_RenbuNomi_Damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TotugekiChokki()
	{
		return null;
	}

	public static void handler_totugekiChokki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_JyakutenHoken()
	{
		return null;
	}

	public static void handler_JyakutenHoken_Damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_JyakutenHoken_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SiroiHerb()
	{
		return null;
	}

	public static void handler_SiroiHerb_ActCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SiroiHerb_MemberInComp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SiroiHerb_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SiroiHerb_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SiroiHerb_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SiroiHerb_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SiroiHerb_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MentalHerb()
	{
		return null;
	}

	public static void handler_MentalHerb_React([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MentalHerb_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MentalHerb_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KaraburiHoken()
	{
		return null;
	}

	public static void handler_KaraburiHoken_Avoid([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KaraburiHoken_Done([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KaraburiHoken_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HikarinoKona()
	{
		return null;
	}

	public static void handler_HikarinoKona([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KyouseiGipusu()
	{
		return null;
	}

	public static void handler_KyouseiGipusu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SenseiNoTume()
	{
		return null;
	}

	public static void handler_SenseiNoTume_SpPriorityCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SenseiNoTume_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SenseiNoTume_TurnCheckDone([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KoukouNoSippo()
	{
		return null;
	}

	public static void handler_KoukouNoSippo([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OujaNoSirusi()
	{
		return null;
	}

	public static void handler_OujaNoSirusi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_OujaNoSirusi_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SurudoiKiba()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_KoukakuLens()
	{
		return null;
	}

	public static void handler_KoukakuLens([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PintLens()
	{
		return null;
	}

	public static void handler_PintLens([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_LuckyPunch()
	{
		return null;
	}

	public static void handler_LuckyPunch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Naganegi()
	{
		return null;
	}

	public static void handler_Naganegi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FocusLens()
	{
		return null;
	}

	public static void handler_FocusLens([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NonkiNoOkou()
	{
		return null;
	}

	public static void handler_NonkiNoOkou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ChikaraNoHachimaki()
	{
		return null;
	}

	public static void handler_ChikaraNoHachimaki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MonosiriMegane()
	{
		return null;
	}

	public static void handler_MonosiriMegane([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SinkaiNoKiba()
	{
		return null;
	}

	public static void handler_SinkaiNoKiba([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SinkaiNoUroko()
	{
		return null;
	}

	public static void handler_SinkaiNoUroko([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MetalPowder()
	{
		return null;
	}

	public static void handler_MetalPowder([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SpeedPowder()
	{
		return null;
	}

	public static void handler_SpeedPowder([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FutoiHone()
	{
		return null;
	}

	public static void handler_FutoiHone([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KodawariHachimaki()
	{
		return null;
	}

	public static void handler_KodawariHachimaki_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KodawariMegane()
	{
		return null;
	}

	public static void handler_KodawariMegane_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KodawariScarf()
	{
		return null;
	}

	public static void handler_KodawariScarf([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kodawari_Common_WazaExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kodawari_Common_ItemChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kodawari_Common_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KiaiNoTasuki()
	{
		return null;
	}

	public static void handler_KiaiNoTasuki_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KiaiNoTasuki_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KiaiNoHachimaki()
	{
		return null;
	}

	public static void handler_KiaiNoHachimaki_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KiaiNoHachimaki_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KiaiNoHachimaki_UseItem([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TatsujinNoObi()
	{
		return null;
	}

	public static void handler_TatsujinNoObi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_InochiNoTama()
	{
		return null;
	}

	public static void handler_InochiNoTama_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_InochiNoTama_Damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MetroNome()
	{
		return null;
	}

	public static void handler_MetroNome([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NebariNoKagidume()
	{
		return null;
	}

	public static void handler_NebariNoKagidume([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KaigaraNoSuzu()
	{
		return null;
	}

	public static void handler_KaigaraNoSuzu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HikariNoNendo()
	{
		return null;
	}

	public static void handler_HikariNoNendo([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PowefulHarb()
	{
		return null;
	}

	public static void handler_PowefulHarb_CheckTameSkip([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PowefulHarb_FixTameSkip([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PowefulHarb_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tabenokosi()
	{
		return null;
	}

	public static void handler_Tabenokosi_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tabenokosi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KuroiHedoro()
	{
		return null;
	}

	public static void handler_KuroiHedoro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AkaiIto()
	{
		return null;
	}

	public static void handler_AkaiIto([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KuttukiBari()
	{
		return null;
	}

	public static void handler_KuttukiBari_DamageReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KuttukiBari_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerWrist()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerBelt()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerLens()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerBand()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerAnkle()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerWeight()
	{
		return null;
	}

	public static void handler_PowerXXX_CalcAgility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HinotamaPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_SizukuPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_IkazutiPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_MirodinoPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_TuraranoPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_KobusinoPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_MoudokuPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_DaitinoPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_AozoraPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_HusiginoPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_TamamusiPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_GansekiPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_MononokePlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_RyuunoPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_KowamotePlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_KoutetsuPlate()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_SeireiPlate()
	{
		return null;
	}

	public static void handler_SeireiPlate([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OokinaNekko()
	{
		return null;
	}

	public static void handler_OokinaNekko([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kemuridama()
	{
		return null;
	}

	public static void handler_Kemuridama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kemuridama_Msg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OmamoriKoban()
	{
		return null;
	}

	public static void handler_OmamoriKoban([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HakkinDama()
	{
		return null;
	}

	public static void handler_HakkinDama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TumetaiIwa()
	{
		return null;
	}

	public static void handler_TumetaiIwa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SarasaraIwa()
	{
		return null;
	}

	public static void handler_SarasaraIwa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AtuiIwa()
	{
		return null;
	}

	public static void handler_AtuiIwa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SimettaIwa()
	{
		return null;
	}

	public static void handler_SimettaIwa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_WazaWeatherTurnUp([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlWeather weather)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DenkiDama()
	{
		return null;
	}

	public static void handler_DenkiDama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DenkiDama_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DokudokuDama()
	{
		return null;
	}

	public static void handler_DokudokuDama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DokudokuDama_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KaenDama()
	{
		return null;
	}

	public static void handler_KaenDama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KaenDama_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GinNoKona()
	{
		return null;
	}

	public static void handler_GinNoKona([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YawarakaiSuna()
	{
		return null;
	}

	public static void handler_YawarakaiSuna([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KataiIsi()
	{
		return null;
	}

	public static void handler_KataiIsi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KisekiNoTane()
	{
		return null;
	}

	public static void handler_KisekiNoTane([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KuroiMegane()
	{
		return null;
	}

	public static void handler_KuroiMegane([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kuroobi()
	{
		return null;
	}

	public static void handler_Kuroobi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Zisyaku()
	{
		return null;
	}

	public static void handler_Zisyaku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MetalCoat()
	{
		return null;
	}

	public static void handler_MetalCoat([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SinpiNoSizuku()
	{
		return null;
	}

	public static void handler_SinpiNoSizuku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SurudoiKutibasi()
	{
		return null;
	}

	public static void handler_SurudoiKutibasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dokubari()
	{
		return null;
	}

	public static void handler_Dokubari([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Dokubari_UseTmp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TokenaiKoori()
	{
		return null;
	}

	public static void handler_TokenaiKoori([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NoroiNoOfuda()
	{
		return null;
	}

	public static void handler_NoroiNoOfuda([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagattaSupuun()
	{
		return null;
	}

	public static void handler_MagattaSupuun([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Mokutan()
	{
		return null;
	}

	public static void handler_Mokutan([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RyuunoKiba()
	{
		return null;
	}

	public static void handler_RyuunoKiba([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SirukuNoSukaafu()
	{
		return null;
	}

	public static void handler_SirukuNoSukaafu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AyasiiOkou()
	{
		return null;
	}

	public static void handler_AyasiiOkou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GansekiOkou()
	{
		return null;
	}

	public static void handler_GansekiOkou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SazanamiNoOkou()
	{
		return null;
	}

	public static void handler_SazanamiNoOkou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UsioNoOkou()
	{
		return null;
	}

	public static void handler_UsioNoOkou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OhanaNoOkou()
	{
		return null;
	}

	public static void handler_OhanaNoOkou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_PowerUpSpecificType([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte type)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KokoroNoSizuku()
	{
		return null;
	}

	public static void handler_KokoroNoSizuku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Siratama()
	{
		return null;
	}

	public static void handler_Siratama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kongoudama()
	{
		return null;
	}

	public static void handler_Kongoudama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KuroiTekkyuu()
	{
		return null;
	}

	public static void handler_KuroiTekkyuu_Agility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KuroiTekkyuu_CheckFly([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Karuisi()
	{
		return null;
	}

	public static void handler_Karuisi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SinkanoKiseki()
	{
		return null;
	}

	public static void handler_SinkanoKiseki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GotugotuMet()
	{
		return null;
	}

	public static void handler_GotugotuMet([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Huusen()
	{
		return null;
	}

	public static void handler_Huusen_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Huusen_CheckFlying([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Huusen_DamageReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Huusen_ItemSetFixed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RedCard()
	{
		return null;
	}

	public static void handler_RedCard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NerainoMato()
	{
		return null;
	}

	public static void handler_NerainoMato([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SimetukeBand()
	{
		return null;
	}

	public static void handler_SimetukeBand([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kyuukon()
	{
		return null;
	}

	public static void handler_Kyuukon_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kyuukon_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AkkiNomi()
	{
		return null;
	}

	public static void handler_AkkiNomi_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AkkiNomi_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HikariGoke()
	{
		return null;
	}

	public static void handler_HikariGoke_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HikariGoke_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yukidama()
	{
		return null;
	}

	public static void handler_Yukidama_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Juudenti()
	{
		return null;
	}

	public static void handler_Juudenti_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void hand_common_TypeDamageRankUp_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte wazaType, BTL_POKEPARAM.ValueID rankValue)
	{
	}

	public static void handler_Juudenti_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NodoAme()
	{
		return null;
	}

	public static void handler_NodoAme_Waza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NodoAme_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DassyutuButton()
	{
		return null;
	}

	public static void handler_DassyutuButton_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DassyutuButton_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DassyutuPack()
	{
		return null;
	}

	public static void handler_DassyutuPack_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DassyutuPack_Launch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DassyutuPack_TurnCheckDone([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DassyutuPack_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BoujinGoggle()
	{
		return null;
	}

	public static void handler_BoujinGoggle_CalcDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BoujinGoggle_WazaNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BannouGasa()
	{
		return null;
	}

	public static void handler_BannouGasa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HonooNoJuel()
	{
		return null;
	}

	public static void handler_HonooNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HonooNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MizuNoJuel()
	{
		return null;
	}

	public static void handler_MizuNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MizuNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DenkiNoJuel()
	{
		return null;
	}

	public static void handler_DenkiNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DenkiNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KusaNoJuel()
	{
		return null;
	}

	public static void handler_KusaNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KusaNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KooriNoJuel()
	{
		return null;
	}

	public static void handler_KooriNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KooriNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KakutouJuel()
	{
		return null;
	}

	public static void handler_KakutouJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KakutouJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DokuNoJuel()
	{
		return null;
	}

	public static void handler_DokuNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DokuNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_JimenNoJuel()
	{
		return null;
	}

	public static void handler_JimenNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_JimenNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HikouNoJuel()
	{
		return null;
	}

	public static void handler_HikouNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HikouNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_EsperJuel()
	{
		return null;
	}

	public static void handler_EsperJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_EsperJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MusiNoJuel()
	{
		return null;
	}

	public static void handler_MusiNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MusiNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IwaNoJuel()
	{
		return null;
	}

	public static void handler_IwaNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_IwaNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GhostJuel()
	{
		return null;
	}

	public static void handler_GhostJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_GhostJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DragonJuel()
	{
		return null;
	}

	public static void handler_DragonNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DragonNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AkuNoJuel()
	{
		return null;
	}

	public static void handler_AkuNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AkuNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HaganeNoJuel()
	{
		return null;
	}

	public static void handler_HaganeNoJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HaganeNoJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NormalJuel()
	{
		return null;
	}

	public static void handler_NormalJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NormalJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YouseiJuel()
	{
		return null;
	}

	public static void handler_YouseiJuel_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_YouseiJuel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_Juel_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte type)
	{
	}

	public static void common_Juel_Power([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte type)
	{
	}

	public static void handler_Juel_EndDmgSeq([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Aiironotama()
	{
		return null;
	}

	public static void handler_Aiironotama_Shinka([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Beniironotama()
	{
		return null;
	}

	public static void handler_Beniironotama_Shinka([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GroundCoat()
	{
		return null;
	}

	public static void handler_GroundCoat([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Bibiridama()
	{
		return null;
	}

	public static void handler_Bibiridama_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bibiridama_RankEffectFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bibiridama_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ElecSeed()
	{
		return null;
	}

	public static void handler_ElecSeed_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ElecSeed_ChangeGroundAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ElecSeed_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PhychoSeed()
	{
		return null;
	}

	public static void handler_PhychoSeed_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PhychoSeed_ChangeGroundAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PhychoSeed_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MistSeed()
	{
		return null;
	}

	public static void handler_MistSeed_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MistSeed_ChangeGroundAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MistSeed_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GrassSeed()
	{
		return null;
	}

	public static void handler_GrassSeed_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_GrassSeed_ChangeGroundAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_GrassSeed_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_Seed_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlGround ground)
	{
	}

	public static void common_Seed_ChangeGroundAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlGround ground)
	{
	}

	public static void common_Seed_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaRankEffect rankType)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RoomService()
	{
		return null;
	}

	public static void handler_RoomService_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_RoomService_ChangeFieldAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_RoomService_Use([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BougoPad()
	{
		return null;
	}

	public static void handler_BougoPad_SimpleDamageEnable([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BougoPad_SimpleDamageFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BougoPad_AddSick_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BougoPad_RankEffect_LastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BougoPad_RankEffect_Failed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BougoPad_TokuseiChangeCheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_BougoPad_TokuseiChangeFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void BougoPad_Guard([In] ref EventFactor.EventHandlerArgs args, bool isGuardMessageEnable)
	{
	}

	public static void BougoPad_GuardMessage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AtuzokoBoots()
	{
		return null;
	}

	public static void handler_AtuzokoBoots_SimpleDamageEnable([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AtuzokoBoots_AddSickCheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AtuzokoBoots_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}
}
