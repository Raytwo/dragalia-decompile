using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic.Handler;

public static class Tokusei
{
	public delegate EventFactor.EventHandlerTable[] HandlerGetFunc(ref EventPriority prio);

	private struct GET_FUNC_TABLE_ELEM
	{
		public TokuseiNo tokusei;

		public HandlerGetFunc func;

		public GET_FUNC_TABLE_ELEM(TokuseiNo tokusei, HandlerGetFunc func)
		{
		}
	}

	private class MAX_PRIORITY_PARAM
	{
		public byte pokeID;

		public WazaNo wazaID;
	}

	private struct ultraForce_GetEffectRankTypeTableElem
	{
		public WazaRankEffect rankType;

		public BTL_POKEPARAM.ValueID pokeValueID;

		public ultraForce_GetEffectRankTypeTableElem(WazaRankEffect rankType, BTL_POKEPARAM.ValueID pokeValueID)
		{
		}
	}

	private const int TRUE = 1;

	private const int FALSE = 0;

	private const int WIDX0 = 0;

	private const int WIDX1 = 1;

	private const int WIDX2 = 2;

	private const int WIDX3 = 3;

	private const int WIDX_REMOVE_GUARD = 4;

	private const int NUM_WIDX = 5;

	private static readonly GET_FUNC_TABLE_ELEM[] GET_FUNC_TABLE;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ikaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Seisinryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fukutsuno;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AtuiSibou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tikaramoti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Suisui;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Youryokuso;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hayaasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tidoriasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Harikiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Atodasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SlowStart;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fukugan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sunagakure;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yukigakure;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Iromegane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HardRock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sniper;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kasoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tekiouryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Mouka;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Gekiryu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sinryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MusinoSirase;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Konjou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Plus;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FlowerGift;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tousousin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Technician;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TetunoKobusi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Stemi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FusiginaUroko;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SkillLink;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KairikiBasami;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Surudoime;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ClearBody;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tanjun;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_LeafGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Juunan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fumin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagumaNoYoroi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Meneki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MizuNoBale;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MyPace;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Donkan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PastelVeil;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Amefurasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hideri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sunaokosi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sunahaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yukifurasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hajimarinoumi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Owarinodaiti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DeltaStream;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AirLock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IcoBody;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AmeukeZara;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SunPower;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Rinpun;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TennoMegumi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UruoiBody;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dappi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PoisonHeal;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KabutoArmor;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kyouun;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IkarinoTubo;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DokunoToge;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Seidenki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HonoNoKarada;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MeromeroBody;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Housi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Samehada;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yuubaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HorobiNoSango;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hensyoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Syncro;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Isiatama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NormalSkin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Trace;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SizenKaifuku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DownLoad;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yotimu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KikenYoti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Omitoosi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ganjou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tennen;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tainetu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kansouhada;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PunkRock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tyosui;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tikuden;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DenkiEngine;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kimottama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Bouon;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fuyuu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FusiginaMamori;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Namake;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Simerike;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Moraibi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nightmare;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nigeasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Katayaburi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tenkiya;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yobimizu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hiraisin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kyuuban;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HedoroEki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Bukiyou;

	private static readonly ushort[] IgnoreItems_Bukiyou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nenchaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Pressure;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagicGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Akusyuu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kagefumi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Arijigoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Jiryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Karuwaza;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Monohiroi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TamaHiroi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_WaruiTeguse;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NorowareBody;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KudakeruYoroi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tikarazuku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Makenki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Katiki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yowaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MultiScale;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FriendGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IyasiNoKokoro;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dokubousou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Netubousou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Telepassy;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Murakke;

	private const int MURAKKE_RANK_MAX = 5;

	private const int MURAKKE_PATTERN_MAX = 20;

	private static readonly WazaRankEffect[] handler_MurakkeTable;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Boujin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dokusyu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SaiseiRyoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hatomune;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sunakaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MilacreSkin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Analyze;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SunanoTikara;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Surinuke;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BarrierFree;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_JisinKajou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UltraForce;

	private static readonly ultraForce_GetEffectRankTypeTableElem[] RANK_VALUE_TABLE;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SeiginoKokoro;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Bibiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_JyoukiKikan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Watage;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Miira;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SamayouTamasii;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sousyoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ItazuraGokoro;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagicMirror;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Syuukaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HeavyMetal;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_LightMetal;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Amanojaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kinchoukan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KagakuHenkaGas;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Jukusei;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kawarimono;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Illusion;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GoodLuck;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MentalVeil;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FlowerVeil;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SweetVeil;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MirrorArmor;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HooBukuro;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HengenZizai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DarkAura;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FairyAura;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AuraBreak;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GanjouAgo;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Gorimuchu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FurCoat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KusaNoKegawa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NumeNume;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KataiTume;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SkySkin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FairySkin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FreezSkin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MegaLauncher;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HayateNoTsubasa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Boudan;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OyakoAi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Magician;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kyousei;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Zikyuuryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Mizugatame;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Suihou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yukikaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Haganetukai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HaganeNoSeisin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UruoiVoice;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HealingShift;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ElecSkin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SurfTail;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hitodenasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Enkaku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Zyoounoigen;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MohuMohu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KooriNoRinpun;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Battery;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerSpot;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Receiver;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TobidasuNakami;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Gyakuzyou;

	private const int WIDX_NIGEGOSI_FULFILL_ENOUGH_HP = 0;

	private const int WIDX_NIGEGOSI_ATTACKER_DMG_STATUS = 1;

	private const int NIGEGOSI_ATTACKER_DMG_STATUS_NONE = 0;

	private const int NIGEGOSI_ATTACKER_DMG_STATUS_MYATTACK = 1;

	private const int NIGEGOSI_ATTACKER_DMG_STATUS_FULFILL_ITEM_EFFECT = 2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nigegosi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SoulHeart;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Odoriko;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Husyoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ElecMaker;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PhychoMaker;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MistMaker;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GrassMaker;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Gitai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Harikomi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ZettaiNemuri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BrainPrism;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HutouNoTurugi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HukutuNoTate;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ScrewObire;

	public static uint numHandlersWithHandlerPri(ushort pri, ushort numHandlers)
	{
		return default(uint);
	}

	public static ushort calcTokHandlerSubPriority(BTL_POKEPARAM bpp)
	{
		return default(ushort);
	}

	public static bool isOccurPer(EventFactor.EventHandlerArgs args, byte per)
	{
		return default(bool);
	}

	public static HandlerGetFunc getHandlerGetFunc(TokuseiNo tokusei)
	{
		return null;
	}

	public static void Add(EventSystem pEventSystem, BTL_POKEPARAM bpp)
	{
	}

	public static void Remove(EventSystem pEventSystem, BTL_POKEPARAM bpp)
	{
	}

	public static void Swap(EventSystem pEventSystem, BTL_POKEPARAM pp1, BTL_POKEPARAM pp2)
	{
	}

	public static bool common_IsShineLocalWeather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void common_IkakuNoEffect_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte workIdx)
	{
	}

	public static void common_IkakuNoEffect_RankEffectFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte workIdx)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ikaku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Ikaku_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Seisinryoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Seisinryoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Seisinryoku_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Seisinryoku_RankEffectFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fukutsuno(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FukutsunoKokoro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AtuiSibou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_AtuiSibou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tikaramoti(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tikaramoti([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Suisui(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Suisui([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Youryokuso(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Youryokuso([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hayaasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hayaasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tidoriasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tidoriasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Harikiri(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Harikiri_HitRatio([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Harikiri_AtkPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Atodasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Atodasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SlowStart(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SlowStart_Agility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SlowStart_AtkPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SlowStart_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_SlowStart_Declare([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SlowStart_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fukugan(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Fukugan([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sunagakure(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sunagakure([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Sunagakure_Weather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yukigakure(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yukigakure([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Yukigakure_Weather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_weather_guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlWeather weather)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Iromegane(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Iromegane([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HardRock(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HardRock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sniper(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sniper([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kasoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kasoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tekiouryoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tekiouryoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Mouka(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Mouka([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Gekiryu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Gekiryu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sinryoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sinryoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MusinoSirase(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MusinoSirase([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_hpborder_powerup([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID, [In] ref byte wazaType)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Konjou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Konjou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Plus(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_PlusMinus([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool checkExistTokuseiFriend([In] ref EventFactor.EventHandlerArgs args, byte pokeID, TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_FlowerGift(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FlowerGift_MemberInComp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_GotTok([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_Weather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_TokOff([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_AirLock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_TokChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_Power([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGift_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool checkFlowerGiftEnablePokemon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void common_FlowerGift_FormChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte nextForm, byte fTokWin)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tousousin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tousousin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Technician(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Technician([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TetunoKobusi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_TetunoKobusi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sutemi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sutemi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FusiginaUroko(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FusiginaUroko([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SkillLink(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SkillLink([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KairikiBasami(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KairikiBasami_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KairikiBasami_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Surudoime(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Surudoime_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Surudoime_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Surudoime_HitRank([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ClearBody(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_ClearBody_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ClearBody_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_RankDownGuard_Check([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID, [In] ref WazaRankEffect rankType)
	{
	}

	public static void common_RankDownGuard_Fixed([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID, [In] ref byte tokwin_pokeID, [In] ref ushort strID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tanjun(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tanjun([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_LeafGuard(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_LeafGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_LeafGuard_InemuriCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Juunan(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Juunan_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Juunan_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Juunan_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fumin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Fumin_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fumin_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fumin_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fumin_InemuriCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagumaNoYoroi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MagumaNoYoroi_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagumaNoYoroi_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagumaNoYoroi_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Meneki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Meneki_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Meneki_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Meneki_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MizuNoBale(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MizuNoBale_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MizuNoBale_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MizuNoBale_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MyPace(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MyPace_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MyPace_AddSickFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MyPace_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MyPace_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MyPace_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MyPace_RankEffectFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Donkan(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Donkan([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Donkan_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Donkan_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Donkan_NoEffCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_AddSickFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID, ushort strID)
	{
	}

	public static void handler_AddSickFailCommon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_TokuseiWake_CureSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSick sick)
	{
	}

	public static void common_TokuseiWake_CureSickCore([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSick sick)
	{
	}

	public static void handler_Donkan_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Donkan_RankEffectFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PastelVeil(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Pastelveil_SickFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Pastelveil_SickFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PastelVeil_Wake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PastelVeil_ActEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_FriendCureSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSick cureSick)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Amefurasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Amefurasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hideri(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hideri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sunaokosi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sunaokosi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sunahaki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sunahaki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yukifurasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yukifurasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hajimarinoumi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hajimarinoumi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hajimarinoumi_stop([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Owarinodaiti(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Owarinodaichi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Owarinodaichi_stop([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DeltaStream(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_DeltaStream([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DeltaStream_stop([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_weather_change([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlWeather weather, ushort boostItem, bool isPermanent)
	{
	}

	public static void common_weather_stop([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlWeather weather)
	{
	}

	public static bool common_check_tokusei([In] ref EventFactor.EventHandlerArgs args, byte selfPokeId, ushort tokusei)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_AirLock(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_AirLock_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AirLock_ChangeWeather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IcoBody(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_IceBody([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AmeukeZara(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_AmeukeZara([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_weather_recover([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlWeather weather)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SunPower(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SunPower_Weather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SunPower_AtkPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Rinpun(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Rinpun_Sick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Rinpun_Rank([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Rinpun_Shrink([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Rinpun_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Rinpun_GuardHitEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TennoMegumi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_TennoMegumi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TennoMegumi_Shrink([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UruoiBody(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_UruoiBody([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dappi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Dappi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PoisonHeal(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_PoisonHeal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KabutoArmor(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KabutoArmor([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kyouun(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kyouun([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IkarinoTubo(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_IkarinoTubo([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DokunoToge(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_DokunoToge([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Seidenki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Seidenki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HonoNoKarada(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HonoNoKarada([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MeromeroBody(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MeromeroBody([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Housi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Housi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_touchAddSick(EventFactor.EventHandlerArgs args, byte pokeID, WazaSick sick, [In] ref BTL_SICKCONT sickCont, byte per)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Samehada(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Samehada([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yuubaku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yuubaku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HorobiNoSango(ref EventPriority prio)
	{
		return null;
	}

	public static bool common_Horobinouta([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	public static void handler_HorobiNoSango([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hensyoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hensyoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Syncro(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Syncro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Isiatama(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Isiatama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NormalSkin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_NormalSkin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NormalSkin_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NormalSkin_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Trace(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Trace([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SizenKaifuku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SizenKaifuku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DownLoad(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Download([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yotimu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yotimu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static byte get_yotimu_wazapri(WazaNo waza)
	{
		return default(byte);
	}

	public static EventFactor.EventHandlerTable[] ADD_KikenYoti(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KikenYoti([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool check_kikenyoti_enemys([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static bool check_kikenyoti_poke([In] ref EventFactor.EventHandlerArgs args, BTL_POKEPARAM bppUser, BTL_POKEPARAM bppEnemy)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Omitoosi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Omitoosi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ganjou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Ganjou_Ichigeki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Ganjou_KoraeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Ganjou_KoraeExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tennen(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tennen_hitRank([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tennen_AtkRank([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tennen_DefRank([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tainetu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tainetsu_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tainetsu_SickDmg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_TypeNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte wazaType)
	{
		return default(bool);
	}

	public static void common_TypeRecoverHP([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte denomHP)
	{
	}

	public static void common_TypeNoEffect_Rankup([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaRankEffect rankType, byte volume)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kansouhada(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kansouhada_Weather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kansouhada_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kansouhada_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PunkRock(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_PunkRock_power([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_PunkRock_damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tyosui(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tyosui_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tikuden(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tikuden_CheckEx([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DenkiEngine(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_DenkiEngine_CheckEx([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kimottama(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kimottama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kimottama_kill([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kimottama_check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kimottama_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kimottama_RankEffectFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Bouon(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Bouon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fuyuu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Fuyuu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fuyuu_Disp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fuyuu_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FusiginaMamori(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FusiginaMamori([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Namake(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Namake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Namake_Get([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nameke_Failed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nameke_EndAct([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nameke_Reset([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Simerike(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Simerike([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Simerike_Effective([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Simerike_StartSeq([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Simerike_EndSeq([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Simerike_Ieki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool handler_Simerike_SkipCheck([In] ref EventFactor.SkipCheckHandlerArgs args)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Moraibi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Moraibi_CheckNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Moraibi_AtkPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Moraibi_Remove([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nightmare(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Nightmare([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nigeasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Nigeasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nigeasi_Msg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Katayaburi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Katayaburi_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Katayaburi_Start([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Katayaburi_End([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Katayaburi_Ieki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tenkiya(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tenkiya_MemberInComp([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tenkiya_GetTok([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tenkiya_Weather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tenkiya_AirLock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tenkiya_ChangeTok([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tenkiya_TokOff([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_Tenkiya_Off([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_TenkiFormChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yobimizu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yobimizu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Yobimizu_TemptTargetEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Yobimizu_CheckNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hiraisin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hiraisin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hiraisin_TemptTargetEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hiraisin_WazaExeStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hiraisin_CheckNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_WazaTargetChangeToMe([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte wazaType, TemptTargetPriority temptPriority, TemptTargetCause temptCause)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kyuuban(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kyuuban([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HedoroEki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HedoroEki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HedoroEki_Dead([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Bukiyou(ref EventPriority prio)
	{
		return null;
	}

	public static bool handler_Bukiyou_SkipCheck([In] ref EventFactor.SkipCheckHandlerArgs args)
	{
		return default(bool);
	}

	public static void handler_Bukiyou_MemberInPrev([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bukiyou_PreChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bukiyou_IekiFixed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bukiyou_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bukiyou_ExeFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nenchaku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Nenchaku_NoEff([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nenchaku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nenchaku_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Pressure(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Pressure_MemberIN([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Pressure([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_MemberInTokMessage([In] ref EventFactor.EventHandlerArgs args, byte pokeID, ushort strID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagicGuard(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MagicGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Akusyuu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Akusyuu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kagefumi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kagefumi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Arijigoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Arijigoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Jiryoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Jiryoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Karuwaza(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Karuwaza_BeforeItemSet([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Karuwaza_Agility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Monohiroi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Monohiroi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool monohiroi_search([In] ref EventFactor.EventHandlerArgs args, byte pokeID, out byte targetPokeID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_TamaHiroi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_TamaHiroi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_WaruiTeguse(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_WaruiTeguse([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NorowareBody(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_NorowareBody([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KudakeruYoroi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KudakeruYoroi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tikarazuku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Tikarazuku_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tikarazuku_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tikarazuku_ShrinkCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tikarazuku_HitChk([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool IsTikarazukuEffecive(WazaNo waza)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Makenki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Makenki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Katiki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Katiki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yowaki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yowaki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MultiScale(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MultiScale([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FriendGuard(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_NakamaIsiki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IyasiNoKokoro(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_IyasiNoKokoro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dokubousou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Dokubousou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Netubousou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Netubousou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Telepassy(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_AunNoIki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Murakke(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Murakke([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Boujin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Boujin_CalcDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Boujin_WazaNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dokusyu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Dokusyu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SaiseiRyoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SaiseiRyoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hatomune(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hatomune_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hatomune_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sunakaki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sunakaki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MilacreSkin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MilacreSkin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Analyze(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sinuti([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SunanoTikara(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SunanoTikara([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Surinuke(ref EventPriority prio)
	{
		return null;
	}

	public static bool handler_Surinuke_SkipCheck([In] ref EventFactor.SkipCheckHandlerArgs args)
	{
		return default(bool);
	}

	public static void handler_Surinuke_Start([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Surinuke_End([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Surinuke_MigawariThrew([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BarrierFree(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_BarrierFree([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_JisinKajou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_JisinKajou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UltraForce(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_UltraForce([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static WazaRankEffect ultraForce_GetEffectRankType([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(WazaRankEffect);
	}

	public static EventFactor.EventHandlerTable[] ADD_SeiginoKokoro(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SeiginoKokoro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Bibiri(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Bibiri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bibiri_RankEffectLastCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Bibiri_RankEffectFixed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_JyoukiKikan(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_JyoukiKikan([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Watage(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Watage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Miira(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Miira([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SamayouTamasii(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SamayouTamasii([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sousyoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Sousyoku_CheckNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ItazuraGokoro(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_ItazuraGokoro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ItazuraGokoro_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ItazuraGokoro_Reset([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicMirror_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicMirror_Wait([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicMirror_Reflect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagicMirror(ref EventPriority prio)
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_Syuukaku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Syuukaku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HeavyMetal(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HeavyMetal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_LightMetal(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_LightMetal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Amanojaku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Amanojaku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kinchoukan(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Kinchoukan_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool handler_Kinchoukan_SkipCheck([In] ref EventFactor.SkipCheckHandlerArgs args)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_KagakuHenkaGas(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KagakuHenkaGas_Start([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KagakuHenkaGas_End([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Jukusei(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Jukusei_KinomiCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kawarimono(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hensin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Illusion(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Illusion_Damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Illusion_Ieki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Illusion_ChangeTok([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_IllusionBreak([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GoodLuck(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_GoodLuck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MentalVeil(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MentalVeil_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MentalVeil_Failed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_FriendSickFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID, ushort strID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FlowerVeil(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FlowerVeil_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerVeil_Guard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerVeil_SickCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerVeil_SickFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerVeil_CheckInemuri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_IsFlowerVeilTarget([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte targetPokeID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_SweetVeil(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SweetVeil_PokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SweetVeil_PokeSickFailed([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SweetVeil_Inemuri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MirrorArmor(ref EventPriority prio)
	{
		return null;
	}

	public static bool checkMirrorArmorCause(RankEffectCause cause)
	{
		return default(bool);
	}

	public static void handler_MirroArmor_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MirroArmor_Reflect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HooBukuro(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hoobukuro([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HengenZizai(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HengenZizai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DarkAura(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_DarkAura_MemberIN([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DarkAura([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FairyAura(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FairyAura_MemberIN([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FairyAura([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AuraBreak(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_AuraBreak_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AuraBreak([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GanjouAgo(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_GanjouAgo([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Gorimuchu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Gorimuchu_Waza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Gorimuchu_Power([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Gorimuchu_Change([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Gorimuchu_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FurCoat(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FurCoat([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KusaNoKegawa(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KusaNoKegawa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NumeNume(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_NumeNume([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KataiTume(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KataiTume([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_Skin_ChangeType([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte type)
	{
	}

	public static void common_Skin_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte type)
	{
	}

	public static void common_Skin_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaNo waza)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SkySkin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SkySkin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SkySkin_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SkySkin_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FairySkin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FairySkin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FairySkin_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fairykin_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FreezSkin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_FreezSkin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FreezSkin_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FreezSkin_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SkinEndCommon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MegaLauncher(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MegaLauncher_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MegaLauncher_Recover([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HayateNoTsubasa(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HayateNoTsubasa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Boudan(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Boudan([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OyakoAi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_OyakoAi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Magician(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_magician_Start([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_magician([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool magician_swapitem([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte targetPokeID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Kyousei(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_kyousei_wazaSeqStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_kyousei_wazaSeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_kyousei([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void kyousei_commonProc([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte targetPokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Zikyuuryoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Zikyuuryoku_WazaDamageReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Mizugatame(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Mizugatame_WazaDamageReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Suihou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Suihou_AttackerPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yukikaki(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Yukikaki_CalcAgility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Haganetukai(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Haganetukai_AttackerPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HaganeNoSeisin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HaganeNoSeisin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UruoiVoice(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_UruoiVoice_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HealingShift(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HealingShift_GetWazaPriority([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ElecSkin(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_ElecSkinWazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ElecSkin_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ElecSkin_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SurfTail(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SurfTail_CalcAgility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hitodenasi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Hitodenasi_CriticalCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Enkaku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Enkaku_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Zyoounoigen(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Zyoounoigen_WazaExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MohuMohu(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MohuMohu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KooriNoRinpun(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_KooriNoRinpun([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Battery(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Battery_WazaPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerSpot(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_PowerSpot([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Receiver(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Receiver_DeadAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TobidasuNakami(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_TobidasuNakami_DamageProcStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TobidasuNakami_IchigekiGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void tobidasuNakami_RegisterDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TobidasuNakami_WazaDamageReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Gyakuzyou(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Gyakuzyou_DamegeProcStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Gyakuzyou_IchigekiCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool gyakuzyou_isEnoughHP([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void handler_Gyakuzyou_EndHitReal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_CheckTarget([In] ref EventFactor.EventHandlerArgs args, byte checkPokeID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Nigegosi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Nigegosi_DamegeProcStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nigegosi_BeforeIchigeki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nigegosi_DamegeProcEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nigegosi_EndHit([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nigegosi_SimpleDamageBefore([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nigegosi_SimpleDamageAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void nigegosi_CheckBeforeDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void nigegosi_AfterDamage_Full([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool nigegosi_AfterDamage_shouldEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void nigegosi_AfterDamage_Effect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool nigegosi_isQuitBattle([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_SoulHeart(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_SoulHeart_DeadAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Odoriko(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Odoriko_WazaSeqStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Odoriko_ExecuteEffective([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Odoriko_WazaSeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static BtlPokePos odoriko_GetTargetPos([In] ref EventFactor.EventHandlerArgs args, byte odorikoPokeID, byte attackPokeID)
	{
		return default(BtlPokePos);
	}

	public static EventFactor.EventHandlerTable[] ADD_Husyoku(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Husyoku_CheckAddSickFailStdSkip([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ElecMaker(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_ElecMaker_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PhychoMaker(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_PhychoMaker_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MistMaker(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_MistMaker_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GrassMaker(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_GrassMaker_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_GroundMaker([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlGround ground)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Gitai(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Gitai_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Gitai_Change([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Harikomi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_Harikomi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ZettaiNemuri(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_ZettaiNemuri_MemberIn([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ZettaiNemuri_AddSickCheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BrainPrism(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_BrainPrism([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HutouNoTurugi(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HutouNoTurugi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HukutuNoTate(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_HukutuNoTate([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ScrewObire(ref EventPriority prio)
	{
		return null;
	}

	public static void handler_ScrewObire_Tempt([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ScrewObire_Aim([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}
}
