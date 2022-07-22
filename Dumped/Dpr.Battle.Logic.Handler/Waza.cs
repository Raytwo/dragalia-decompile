using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic.Handler;

public static class Waza
{
	public enum CombiEffectType
	{
		COMBI_EFFECT_NULL,
		COMBI_EFFECT_RAINBOW,
		COMBI_EFFECT_BURNING,
		COMBI_EFFECT_MOOR
	}

	public delegate EventFactor.EventHandlerTable[] HandlerGetFunc();

	private struct GET_FUNC_TABLE_ELEM
	{
		public WazaNo waza;

		public HandlerGetFunc func;

		public GET_FUNC_TABLE_ELEM(WazaNo waza, HandlerGetFunc func)
		{
		}
	}

	private struct handler_JitabataTableElem
	{
		public ushort dot_ratio;

		public ushort pow;

		public handler_JitabataTableElem(ushort dot_ratio, ushort pow)
		{
		}
	}

	private struct WeatherBallParam
	{
		public PokeType type;

		public byte effIndex;
	}

	private struct GetCombiWazaTypeTableElem
	{
		public WazaNo waza1;

		public WazaNo waza2;

		public CombiEffectType effect;

		public GetCombiWazaTypeTableElem(WazaNo waza1, WazaNo waza2, CombiEffectType effect)
		{
		}
	}

	private const int FALSE = 0;

	private const int TRUE = 1;

	public const byte EVENT_WAZA_STICK_MAX = 8;

	private const int WORKIDX_STICK = 6;

	private static readonly GET_FUNC_TABLE_ELEM[] GET_FUNC_TABLE;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Texture;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TrickRoom;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Juryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kiribarai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kawarawari;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tobigeri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Monomane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sketch;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KonoyubiTomare;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ikarinokona;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KumoNoSu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KuroiKiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Haneru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Oiwai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TeWoTunagu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Noroi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Denjiha;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NayamiNoTane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yumekui;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TriAttack;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nettou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_UtakatanoAria;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Osyaberi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Makituku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Uzusio;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IkariNoMaeba;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Gamusyara;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TikyuuNage;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Takuwaeru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hakidasu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nomikomu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Counter;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MilerCoat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MetalBurst;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Totteoki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ibiki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fuiuti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Daibakuhatsu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kiaidame;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Juden;

	private const int JUDEN_STAT_NONE = 0;

	private const int JUDEN_STAT_START = 1;

	private const int JUDEN_STAT_WAZA = 2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HorobiNoUta;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YadorigiNoTane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NekoNiKoban;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AquaRing;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Abareru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sawagu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Korogaru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TripleKick;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GyroBall;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Revenge;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Jitabata;

	private static readonly handler_JitabataTableElem[] handler_JitabataTable;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Karagenki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sippegaesi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Funka;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Siboritoru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Siomizu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RenzokuGiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dameosi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ketaguri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_WeatherBall;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tatumaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kaminari;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fubuki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ZettaiReido;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Jisin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SabakiNoTubute;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MultiAttack;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TechnoBaster;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MezameruPower;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hatakiotosu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagicCoat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dorobou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Trick;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Naminori;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fumituke;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DaiMaxHou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Mineuti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Koraeru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Mamoru;

	private static readonly ushort[] WazaTable_Mamoru;

	private static readonly ushort[] RandRangeTable_Mamoru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Recycle;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PsycoShift;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Itamiwake;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Haradaiko;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Feint;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IjigenHall;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TuboWoTuku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nemuru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Meromero;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Texture2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Encore;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Chouhatu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kanasibari;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Present;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fuuin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Alomatherapy;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IyasiNoSuzu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Okimiyage;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Urami;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_JikoAnji;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HeartSwap;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerSwap;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GuardSwap;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerTrick;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PowerShare;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GuardShare;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_LockON;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dokudoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Reflector;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HikariNoKabe;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SinpiNoMamori;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SiroiKiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Oikaze;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Makibisi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dokubisi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_StealthRock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NebaNebaNet;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_WideGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TatamiGaeshi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hensin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MikadukiNoMai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IyasiNoNegai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Negaigoto;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Miraiyoti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HametuNoNegai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ieki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Narikiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TonboGaeri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KousokuSpin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BatonTouch;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Teleport;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nagetukeru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DenjiFuyuu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tedasuke;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FukuroDataki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Nekodamasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Deaigasira;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AsaNoHizasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sunaatume;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FlowerHeal;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SoraWoTobu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ShadowDive;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tobihaneru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Diving;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AnaWoHoru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SolarBeam;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GodBird;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_RocketZutuki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tuibamu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hoobaru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Waruagaki;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Michidure;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Onnen;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tiisakunaru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Marukunaru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Haneyasume;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KiaiPunch;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_YubiWoFuru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SizenNoTikara;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Negoto;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Manekko;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GensiNoTikara;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BenomShock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tatarime;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Acrobat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AsistPower;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HeavyBomber;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HeatStamp;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ElectBall;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_EchoVoice;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Katakiuti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ikasama;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BodyPress;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Mizubitasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MahouNoKona;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SimpleBeem;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NakamaDukuri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ClearSmog;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Yakitukusu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TomoeNage;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hoeru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Utiotosu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KarawoYaburu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MirrorType;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BodyPurge;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PsycoShock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NasiKuzusi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_WonderRoom;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MagicRoom;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Inotigake;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_OsakiniDouzo;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sakiokuri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Rinsyou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FastGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SideChange;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_CourtChange;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_InisieNoUta;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Seityou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FreezeBolt;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FlameSoul;

	private static readonly GetCombiWazaTypeTableElem[] CombiTbl;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_CombiWazaCommon;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Halloween;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Morinonoroi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FlowerGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TodomeBari;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KogoeruHadou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hikkurikaesu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NeraiPunch;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SuteZerifu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FlyingPress;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FreezDry;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Souden;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GrassField;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MistField;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ElecField;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PhychoField;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KingShield;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Blocking;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ThousanArrow;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HappyTime;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ZibaSousa;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BenomTrap;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PlasmaFist;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FairyLock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Funjin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GeoControl;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TrickGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NeedleGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SouthernWave;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IjigenRush;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AuraGuruma;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DarkHole;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tootika;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MezameruDance;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kahundango;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_CorePunisher;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kagenui;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Kuraituku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TakoGatame;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Zyouka;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Tikarawosuitoru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Togisumasu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SpeedSwap;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Moetukiru;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_KutibasiCanon;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TrapShell;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Zidanda;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AuroraVeil;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Saihai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MeteorDrive;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_ShadowSteal;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_PhotonGeyser;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hanabisenyou;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DaiWall;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NeraiUti;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_HaisuiNoJin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SoulBeat;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ochakai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DengekiKutibasi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TarShot;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DragonArrow;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_InotiNoSizuku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Newton;

	public static HandlerGetFunc getHandlerGetFunc(WazaNo waza)
	{
		return null;
	}

	public static bool Add(EventSystem pEventSystem, BTL_POKEPARAM poke, WazaNo waza, uint subPri)
	{
		return default(bool);
	}

	public static bool canRegister(EventSystem pEventSystem, byte pokeID, WazaNo waza)
	{
		return default(bool);
	}

	public static void Remove(EventSystem pEventSystem, BTL_POKEPARAM poke, WazaNo waza)
	{
	}

	public static void RemoveForce(EventSystem pEventSystem, BTL_POKEPARAM poke, WazaNo waza)
	{
	}

	public static void removeHandlerForce(EventSystem pEventSystem, byte pokeID, WazaNo waza)
	{
	}

	public static void RemoveForceAll(EventSystem eventSystem, BTL_POKEPARAM poke)
	{
	}

	public static bool common_checkActStart_isMyWaza([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static bool common_IsMyEvent([In] ref EventFactor.EventHandlerArgs args, EventVar.Label pokeIDLabel, byte pokeID)
	{
		return default(bool);
	}

	public static void handler_common_ExeCheck2nd_FailOnRaid([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_ExeCheck2nd_FailOnRaidPlayerSide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_ExeCheck2nd_FailOnRaidBoss([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_ExeCheck3rd_FailToG([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_ExeCheck3rd_FailToGWall([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static byte getEventVarTarget([In] ref EventFactor.EventHandlerArgs args, int n)
	{
		return default(byte);
	}

	public static void common_SetWazaEffectIndex([In] ref EventFactor.EventHandlerArgs args, byte effectIndex)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Texture()
	{
		return null;
	}

	public static void handler_Texture([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TrickRoom()
	{
		return null;
	}

	public static void handler_TrickRoom([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Juryoku()
	{
		return null;
	}

	public static void handler_Juryoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kiribarai()
	{
		return null;
	}

	public static void handler_Kiribarai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kawarawari()
	{
		return null;
	}

	public static void handler_Kawarawari_DmgProc1([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kawarawari_DmgProcEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kawarawari_DmgDetermine([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool handler_Kawarawari_SkipCheck([In] ref EventFactor.SkipCheckHandlerArgs args)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Tobigeri()
	{
		return null;
	}

	public static void handler_Tobigeri_NoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Monomane()
	{
		return null;
	}

	public static void handler_Monomane([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sketch()
	{
		return null;
	}

	public static void handler_Sketch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static WazaNo sketch_GetTargetWaza(BTL_POKEPARAM target)
	{
		return default(WazaNo);
	}

	public static EventFactor.EventHandlerTable[] ADD_KonoyubiTomare()
	{
		return null;
	}

	public static void handler_KonoyubiTomare_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KonoyubiTomare_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KonoyubiTomare_TemptTarget([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KonoyubiTomare_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ikarinokona()
	{
		return null;
	}

	public static void handler_Ikarinokona_TemptTarget([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KumoNoSu()
	{
		return null;
	}

	public static void handler_KumoNoSu_NoEffCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KumoNoSu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KuroiKiri()
	{
		return null;
	}

	public static void handler_KuroiKiri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Haneru()
	{
		return null;
	}

	public static void handler_Haneru_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Haneru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Oiwai()
	{
		return null;
	}

	public static void handler_Oiwai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TeWoTunagu()
	{
		return null;
	}

	public static void handler_TeWoTunagu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Noroi()
	{
		return null;
	}

	public static void handler_Noroi_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Noroi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Noroi_ExeCheck3rd_FailToGWall([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Denjiha()
	{
		return null;
	}

	public static void handler_Denjiha([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NayamiNoTane()
	{
		return null;
	}

	public static void handler_NayamiNoTane_NoEff([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NayamiNoTane([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yumekui()
	{
		return null;
	}

	public static void handler_Yumekui([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TriAttack()
	{
		return null;
	}

	public static void handler_TriAttack([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nettou()
	{
		return null;
	}

	public static void handler_Nettou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_UtakatanoAria()
	{
		return null;
	}

	public static void handler_UtakatanoAria([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Osyaberi()
	{
		return null;
	}

	public static void handler_Osyaberi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Makituku()
	{
		return null;
	}

	public static void handler_Makituku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Makituku_Str([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool makituku_GetStr(out ushort pStrID, WazaNo wazano)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Uzusio()
	{
		return null;
	}

	public static void handler_Uzusio_CheckHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Uzusio_Dmg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IkariNoMaeba()
	{
		return null;
	}

	public static void handler_IkariNoMaeba([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static ushort common_CalcFixDamageByDefenderHp(BTL_POKEPARAM target, byte numerator, byte denominator)
	{
		return default(ushort);
	}

	public static EventFactor.EventHandlerTable[] ADD_Gamusyara()
	{
		return null;
	}

	public static void handler_Gamusyara_CheckNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Gamusyara([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TikyuuNage()
	{
		return null;
	}

	public static void handler_TikyuuNage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Takuwaeru()
	{
		return null;
	}

	public static void handler_Takuwaeru_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Takuwaeru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hakidasu()
	{
		return null;
	}

	public static void handler_Hakidasu_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hakidasu_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hakidasu_Done([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nomikomu()
	{
		return null;
	}

	public static void handler_Nomikomu_Ratio([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Counter()
	{
		return null;
	}

	public static void handler_Counter_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Counter_Target([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Counter_CalcDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MilerCoat()
	{
		return null;
	}

	public static void handler_MilerCoat_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MilerCoat_Target([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MilerCoat_CalcDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MetalBurst()
	{
		return null;
	}

	public static void handler_MetalBurst_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MetalBurst_Target([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MetalBurst_CalcDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_Counter_ExeCheck([In] ref EventFactor.EventHandlerArgs args, [In] ref WazaDamageType dmgType, [In] ref byte pokeID)
	{
	}

	public static void common_Counter_SetTarget([In] ref EventFactor.EventHandlerArgs args, [In] ref WazaDamageType dmgType, [In] ref byte pokeID)
	{
	}

	public static void common_Counter_CalcDamage([In] ref EventFactor.EventHandlerArgs args, [In] ref WazaDamageType dmgType, [In] ref int ratio, [In] ref byte pokeID)
	{
	}

	public static bool common_Counter_GetRec([In] ref EventFactor.EventHandlerArgs args, [In] ref WazaDamageType dmgType, BTL_POKEPARAM.WAZADMG_REC rec, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Totteoki()
	{
		return null;
	}

	public static void handler_Totteoki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ibiki()
	{
		return null;
	}

	public static void handler_Ibiki_CheckFail_1([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Ibiki_CheckFail_2([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fuiuti()
	{
		return null;
	}

	public static void handler_Fuiuti_NoEff([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool handler_Fuiuti_CheckSuccess([In] ref EventFactor.EventHandlerArgs args, byte targetPokeID)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Daibakuhatsu()
	{
		return null;
	}

	public static void handler_Daibakuhatsu_ExeStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Daibakuhatsu_DmgDetermine([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Daibakuhatsu_ExeFix([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kiaidame()
	{
		return null;
	}

	public static void handler_Kiaidame([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Juden()
	{
		return null;
	}

	public static void handler_Juden_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Juden_RemoveAllTarget([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Juden_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Juden_WazaStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Juden_WazaEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HorobiNoUta()
	{
		return null;
	}

	public static void handler_HorobiNoUta_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YadorigiNoTane()
	{
		return null;
	}

	public static void handler_YadorigiNoTane_Param([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NekoNiKoban()
	{
		return null;
	}

	public static void handler_NekoNiKoban([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AquaRing()
	{
		return null;
	}

	public static void handler_AquaRing([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Abareru()
	{
		return null;
	}

	public static void handler_Abareru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void abareru_Unlock([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_Abareru_SeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Abareru_turnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sawagu()
	{
		return null;
	}

	public static void handler_Sawagu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void Sawagu_CureLock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Sawagu_SeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Sawagu_turnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Sawagu_CheckSickFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Sawagu_CheckInemuri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Korogaru()
	{
		return null;
	}

	public static void handler_Korogaru_ExeFix([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Korugaru_Avoid([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Korogaru_NoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Korogaru_SeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_Korogaru_Unlock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Korogaru_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TripleKick()
	{
		return null;
	}

	public static void handler_TripleKick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TripleKick_HitCount([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GyroBall()
	{
		return null;
	}

	public static void handler_GyroBall([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static ushort common_CalcAgility([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(ushort);
	}

	public static EventFactor.EventHandlerTable[] ADD_Revenge()
	{
		return null;
	}

	public static void handler_Revenge([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Jitabata()
	{
		return null;
	}

	public static void handler_Jitabata([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Karagenki()
	{
		return null;
	}

	public static void handler_Karagenki_AtkPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Karagenki_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sippegaesi()
	{
		return null;
	}

	public static void handler_Sippegaesi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Funka()
	{
		return null;
	}

	public static void handler_Funka([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Siboritoru()
	{
		return null;
	}

	public static void handler_Siboritoru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Siomizu()
	{
		return null;
	}

	public static void handler_Siomizu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RenzokuGiri()
	{
		return null;
	}

	public static void handler_RenzokuGiri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dameosi()
	{
		return null;
	}

	public static void handler_Dameosi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ketaguri()
	{
		return null;
	}

	public static void handler_Ketaguri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_WeatherBall()
	{
		return null;
	}

	private static bool get_WeatherBallParam(ref WeatherBallParam param, BtlWeather weather)
	{
		return default(bool);
	}

	public static void handler_WeatherBall_Type([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_WeatherBall_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_WeatherBall_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tatumaki()
	{
		return null;
	}

	public static void handler_Tatumaki_checkHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tatumaki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kaminari()
	{
		return null;
	}

	public static void handler_Kaminari_checkHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kaminari_excuseHitCalc([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kaminari_hitRatio([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fubuki()
	{
		return null;
	}

	public static void handler_Fubuki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ZettaiReido()
	{
		return null;
	}

	public static void handler_ZettaiReido_hitRatio([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Jisin()
	{
		return null;
	}

	public static void handler_Jisin_checkHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Jisin_damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SabakiNoTubute()
	{
		return null;
	}

	public static void handler_SabakiNoTubute([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MultiAttack()
	{
		return null;
	}

	public static PokeType multiAttack_GetType(ItemNo item)
	{
		return default(PokeType);
	}

	public static void handler_MultiAttack([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MultiAttack_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TechnoBaster()
	{
		return null;
	}

	public static void technoBaster_GetParam(ref PokeType pType, ref byte pEffectIdx, ItemNo item)
	{
	}

	public static void handler_TechnoBaster([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TechnoBaster_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MezameruPower()
	{
		return null;
	}

	public static void handler_MezameruPower_Type([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hatakiotosu()
	{
		return null;
	}

	public static void handler_Hatakiotosu_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hatakiotosu_EndHit([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagicCoat()
	{
		return null;
	}

	public static void handler_MagicCoat_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicCoat([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicCoat_Wait([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicCoat_Reflect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MagicCoat_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dorobou()
	{
		return null;
	}

	public static void handler_Dorobou_Start([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Dorobou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Trick()
	{
		return null;
	}

	public static void handler_Trick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Naminori()
	{
		return null;
	}

	public static void handler_Naminori_checkHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Naminori([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fumituke()
	{
		return null;
	}

	public static void handler_Fumituke_DamegeProc([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Fumituke_HitCheckSkip([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DaiMaxHou()
	{
		return null;
	}

	public static void handler_DaiMaxHou_DamegeProc([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Mineuti()
	{
		return null;
	}

	public static void handler_Mineuti([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Koraeru()
	{
		return null;
	}

	public static void handler_Koraeru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Koraeru_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Koraeru_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Mamoru()
	{
		return null;
	}

	public static void handler_Mamoru_StartSeq([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Mamoru_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Mamoru_ExeFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool handler_Mamoru_Core([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static void IncrementMamoruCounter([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_Mamoru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool mamoru_MsgAfterCritical([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static void handler_Mamoru_Dmg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Mamoru_MsgAfterCritical([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Mamoru_Off([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Recycle()
	{
		return null;
	}

	public static void handler_Recycle([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PsycoShift()
	{
		return null;
	}

	public static void handler_PsycoShift([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Itamiwake()
	{
		return null;
	}

	public static void handler_Itamiwake([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void itamiwake_CalcShiftHP(out int pAttackerHP, out int pDefenderHP, BTL_POKEPARAM pAttacker, BTL_POKEPARAM pDefender)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Haradaiko()
	{
		return null;
	}

	public static void handler_Haradaiko([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Feint()
	{
		return null;
	}

	public static void handler_Feint_MamoruBreak([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Feint_NoEffCheckBegin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Feint_NoEffCheckEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void SleepGuardSideEffects([In] ref EventFactor.EventHandlerArgs args, byte pokeID, bool wakeFlag)
	{
	}

	public static void SleepGuardSideEffect([In] ref EventFactor.EventHandlerArgs args, byte attackPokeId, byte targetPokeId, bool wakeFlag)
	{
	}

	public static void handler_Feint_AfterDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_feint_proc([In] ref EventFactor.EventHandlerArgs args, byte pokeID, ushort strID)
	{
	}

	public static void common_mamoruBreakAfter([In] ref EventFactor.EventHandlerArgs args, byte attackPokeID, BTL_POKEPARAM target, ushort strID)
	{
	}

	public static void common_mamoruBreak_RemoveSideEff([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BTL_POKEPARAM target)
	{
	}

	public static bool common_IsExistGuardTypeSideEffect([In] ref EventFactor.EventHandlerArgs args, byte targetPokeID, bool bIncludeNotCountupType)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_IjigenHall()
	{
		return null;
	}

	public static void handler_IjigenHall_AfterDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TuboWoTuku()
	{
		return null;
	}

	public static void handler_TuboWoTuku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nemuru()
	{
		return null;
	}

	public static void handler_Nemuru_exeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nemuru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Meromero()
	{
		return null;
	}

	public static void handler_Meromero_CheckNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Texture2()
	{
		return null;
	}

	public static void handler_Texture2([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Encore()
	{
		return null;
	}

	public static void handler_Encore([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Chouhatu()
	{
		return null;
	}

	public static void handler_Chouhatu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kanasibari()
	{
		return null;
	}

	public static void handler_Kanasibari([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static WazaNo kanashibari_GetTargetWaza(BTL_POKEPARAM target)
	{
		return default(WazaNo);
	}

	public static EventFactor.EventHandlerTable[] ADD_Present()
	{
		return null;
	}

	public static void handler_Present_Check([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Present_Fix([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Present_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fuuin()
	{
		return null;
	}

	public static void handler_Fuuin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Alomatherapy()
	{
		return null;
	}

	public static void handler_Alomatherapy_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Alomatherapy([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IyasiNoSuzu()
	{
		return null;
	}

	public static void handler_IyasiNoSuzu_Exe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_IyasiNoSuzu_RemoveAllTarget([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_IyasiNoSuzu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_CureFriendPokeSick([In] ref EventFactor.EventHandlerArgs args, byte attackerID, bool excludeOutOfWazaTarget, bool canWriteGenFlag)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Okimiyage()
	{
		return null;
	}

	public static void handler_Okimiyage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Urami()
	{
		return null;
	}

	public static void handler_Urami([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_JikoAnji()
	{
		return null;
	}

	public static void handler_JikoAnji([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HeartSwap()
	{
		return null;
	}

	public static void handler_HeartSwap([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerSwap()
	{
		return null;
	}

	public static void handler_PowerSwap([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GuardSwap()
	{
		return null;
	}

	public static void handler_GuardSwap([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerTrick()
	{
		return null;
	}

	public static void handler_PowerTrick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PowerShare()
	{
		return null;
	}

	public static void handler_PowerShare([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GuardShare()
	{
		return null;
	}

	public static void handler_GuardShare([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_LockON()
	{
		return null;
	}

	public static void handler_LockON([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dokudoku()
	{
		return null;
	}

	public static void handler_Dokudoku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Dokudoku_Done([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Reflector()
	{
		return null;
	}

	public static void handler_Reflector([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HikariNoKabe()
	{
		return null;
	}

	public static void handler_HikariNoKabe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SinpiNoMamori()
	{
		return null;
	}

	public static void handler_SinpiNoMamori([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SiroiKiri()
	{
		return null;
	}

	public static void handler_SiroiKiri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Oikaze()
	{
		return null;
	}

	public static void handler_Oikaze([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Makibisi()
	{
		return null;
	}

	public static void handler_Makibisi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Dokubisi()
	{
		return null;
	}

	public static void handler_Dokubisi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_StealthRock()
	{
		return null;
	}

	public static void handler_StealthRock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NebaNebaNet()
	{
		return null;
	}

	public static void handler_NebaNebaNet([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_WideGuard()
	{
		return null;
	}

	public static void handler_WideGuard_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_WideGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TatamiGaeshi()
	{
		return null;
	}

	public static void handler_TatamiGaeshi_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TatamiGaeshi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_SideEffectStdMsg([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID, BtlSide side, BtlSideEffect effect, [In] ref BTL_SICKCONT cont, ushort strID)
	{
		return default(bool);
	}

	public static bool common_SideEffectCore([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlSide side, BtlSideEffect effect, [In] ref BTL_SICKCONT cont, BtlStrType strType, uint strID, int strArg, bool replaceStrArg0ByExpandSide)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_Hensin()
	{
		return null;
	}

	public static void handler_Hensin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MikadukiNoMai()
	{
		return null;
	}

	public static void handler_MikadukiNoMai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IyasiNoNegai()
	{
		return null;
	}

	public static void handler_IyasiNoNegai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Negaigoto()
	{
		return null;
	}

	public static void handler_Negaigoto([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Miraiyoti()
	{
		return null;
	}

	public static void handler_Miraiyoti([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Miraiyoti_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_delayAttack([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlPokePos targetPos)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HametuNoNegai()
	{
		return null;
	}

	public static void handler_HametuNoNegai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HametuNoNegai_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ieki()
	{
		return null;
	}

	public static void handler_Ieki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Narikiri()
	{
		return null;
	}

	public static void handler_Narikiri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TonboGaeri()
	{
		return null;
	}

	public static void handler_TonboGaeri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KousokuSpin()
	{
		return null;
	}

	public static void handler_KousokuSpin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BatonTouch()
	{
		return null;
	}

	public static void handler_BatonTouch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Teleport()
	{
		return null;
	}

	public static bool teleport_isQuitBattle([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static bool teleport_canQuitBattle([In] ref EventFactor.EventHandlerArgs args, ref WazaFailCause pFailCause, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static void handler_Teleport_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Teleport_ExeCheck_QuitBattle([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Teleport_ExeCheck_ChangePokemon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Teleport([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Teleport_QuitBattle([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Teleport_ChangePokemon([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Teleport_ExMsg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Nagetukeru()
	{
		return null;
	}

	public static void handler_Nagetukeru_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nagetukeru_WazaPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nagetukeru_DmgProcStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nagetukeru_DmgAfter([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Nagetukeru_Done([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DenjiFuyuu()
	{
		return null;
	}

	public static void handler_DenjiFuyuu_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DenjiFuyuu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tedasuke()
	{
		return null;
	}

	public static void handler_Tedasuke_SkipAvoid([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tedasuke_CheckHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tedasuke_Ready([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool tedasuke_IsSuccess([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void handler_Tedasuke_WazaPow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tedasuke_TurnCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FukuroDataki()
	{
		return null;
	}

	public static void handler_FukuroDataki([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FukuroDataki_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static BTL_POKEPARAM common_FukuroDataki_GetParam([In] ref EventFactor.EventHandlerArgs args, byte myPokeID, byte idx)
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_Nekodamasi()
	{
		return null;
	}

	public static void handler_Nekodamasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Deaigasira()
	{
		return null;
	}

	public static void handler_Deaigasira([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AsaNoHizasi()
	{
		return null;
	}

	public static void handler_AsaNoHizasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sunaatume()
	{
		return null;
	}

	public static void handler_Sunaatume([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FlowerHeal()
	{
		return null;
	}

	public static void handler_FlowerHeal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SoraWoTobu()
	{
		return null;
	}

	public static void handler_SoraWoTobu_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ShadowDive()
	{
		return null;
	}

	public static void handler_ShadowDive_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ShadowDive_AfterDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tobihaneru()
	{
		return null;
	}

	public static void handler_Tobihaneru_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Diving()
	{
		return null;
	}

	public static void handler_Diving_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AnaWoHoru()
	{
		return null;
	}

	public static void handler_AnaWoHoru_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SolarBeam()
	{
		return null;
	}

	public static void handler_SolarBeam_TameSkip([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SolarBeam_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SolarBeam_Power([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GodBird()
	{
		return null;
	}

	public static void handler_GodBird_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_RocketZutuki()
	{
		return null;
	}

	public static void handler_RocketZutuki_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tuibamu()
	{
		return null;
	}

	public static void handler_Tuibamu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hoobaru()
	{
		return null;
	}

	public static void handler_Hoobaru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hoobaru_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Waruagaki()
	{
		return null;
	}

	public static void handler_Waruagaki_KickBack([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Waruagaki_SeqStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Waruagaki_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Michidure()
	{
		return null;
	}

	public static void handler_Michidure_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void stickMitidureFactor([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_Michidure_Ready([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void removeMitidureFactor([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_Michidure_ActStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Michidure_WazaDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Onnen()
	{
		return null;
	}

	public static void stickOnnenFactor([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void removeOnnenFactor([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Onnen_Ready([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Onnen_WazaDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Onnen_ActStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tiisakunaru()
	{
		return null;
	}

	public static void handler_Tiisakunaru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Marukunaru()
	{
		return null;
	}

	public static void handler_Marukunaru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Haneyasume()
	{
		return null;
	}

	public static void handler_Haneyasume([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KiaiPunch()
	{
		return null;
	}

	public static void handler_KiaiPunch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_YubiWoFuru()
	{
		return null;
	}

	public static void handler_YubiWoFuru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_YubiWoFuru_Msg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SizenNoTikara()
	{
		return null;
	}

	public static void handler_SizenNoTikara([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SizenNoTikara_Msg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Negoto()
	{
		return null;
	}

	public static void handler_Negoto([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Manekko()
	{
		return null;
	}

	public static void handler_Manekko_CheckParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static WazaNo manekko_GetTargetWaza(BattleEnv pBattleEnv)
	{
		return default(WazaNo);
	}

	public static EventFactor.EventHandlerTable[] ADD_GensiNoTikara()
	{
		return null;
	}

	public static void handler_GensiNoTikara([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BenomShock()
	{
		return null;
	}

	public static void handler_BenomShock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tatarime()
	{
		return null;
	}

	public static void handler_Tatarime([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Acrobat()
	{
		return null;
	}

	public static void handler_Acrobat([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AsistPower()
	{
		return null;
	}

	public static void handler_AsistPower([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HeavyBomber()
	{
		return null;
	}

	public static void handler_HeavyBomber([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HeatStamp()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_ElectBall()
	{
		return null;
	}

	public static void handler_ElectBall([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_EchoVoice()
	{
		return null;
	}

	public static void handler_EchoVoice([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Katakiuti()
	{
		return null;
	}

	public static void handler_Katakiuti([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ikasama()
	{
		return null;
	}

	public static void handler_Ikasama([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BodyPress()
	{
		return null;
	}

	public static void handler_BodyPress([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Mizubitasi()
	{
		return null;
	}

	public static void handler_Mizubitasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MahouNoKona()
	{
		return null;
	}

	public static void handler_MahouNoKona([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SimpleBeem()
	{
		return null;
	}

	public static void handler_SimpleBeem([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NakamaDukuri()
	{
		return null;
	}

	public static void handler_NakamaDukuri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ClearSmog()
	{
		return null;
	}

	public static void handler_ClearSmog([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Yakitukusu()
	{
		return null;
	}

	public static void handler_Yakitukusu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TomoeNage()
	{
		return null;
	}

	public static void handler_TomoeNage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hoeru()
	{
		return null;
	}

	public static void handler_Hoeru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Utiotosu()
	{
		return null;
	}

	public static void handler_Utiotosu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_UtiotosuEffect([In] ref EventFactor.EventHandlerArgs args, byte atkPokeID, byte targetPokeID)
	{
		return default(bool);
	}

	public static bool common_UtiotosuEffect_falldown([In] ref EventFactor.EventHandlerArgs args, byte atkPokeID, byte targetPokeID, BTL_POKEPARAM bppTarget)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_KarawoYaburu()
	{
		return null;
	}

	public static void handler_KarawoYaburu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MirrorType()
	{
		return null;
	}

	public static void handler_MirrorType([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BodyPurge()
	{
		return null;
	}

	public static void handler_BodyPurge([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PsycoShock()
	{
		return null;
	}

	public static void handler_PsycoShock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NasiKuzusi()
	{
		return null;
	}

	public static void handler_NasiKuzusi_CalcDmg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NasiKuzusi_HitCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_WonderRoom()
	{
		return null;
	}

	public static void handler_WonderRoom([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MagicRoom()
	{
		return null;
	}

	public static void handler_MagicRoom([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Inotigake()
	{
		return null;
	}

	public static void handler_Inotigake_CalcDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Inotigake_CheckDead([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_OsakiniDouzo()
	{
		return null;
	}

	public static void handler_OsakiniDouzo([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Sakiokuri()
	{
		return null;
	}

	public static void handler_Sakiokuri([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Rinsyou()
	{
		return null;
	}

	public static void handler_Rinsyou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Rinsyou_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FastGuard()
	{
		return null;
	}

	public static void handler_FastGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SideChange()
	{
		return null;
	}

	public static void handler_SideChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_CourtChange()
	{
		return null;
	}

	public static void handler_CourtChange([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_InisieNoUta()
	{
		return null;
	}

	public static void handler_InisieNoUta([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Seityou()
	{
		return null;
	}

	public static void handler_Seityou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FreezeBolt()
	{
		return null;
	}

	public static void handler_FreezeBolt_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FlameSoul()
	{
		return null;
	}

	public static void handler_FlameSoul_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static CombiEffectType GetCombiWazaType(WazaNo waza1, WazaNo waza2)
	{
		return default(CombiEffectType);
	}

	public static EventFactor.EventHandlerTable[] ADD_CombiWazaCommon()
	{
		return null;
	}

	public static void handler_CombiWaza_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_CombiWaza_Decide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_CombiWaza_TypeMatch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_CombiWaza_Pow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_CombiWaza_ChangeEff([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_CombiWaza_AfterDmg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Halloween()
	{
		return null;
	}

	public static void handler_Halloween([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Morinonoroi()
	{
		return null;
	}

	public static void handler_Morinonoroi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FlowerGuard()
	{
		return null;
	}

	public static void handler_Tagayasu_CheckHide([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_FlowerGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool common_GuardUpByPokeType([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte pokeType)
	{
		return default(bool);
	}

	public static EventFactor.EventHandlerTable[] ADD_TodomeBari()
	{
		return null;
	}

	public static void handler_TodomeBari([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KogoeruHadou()
	{
		return null;
	}

	public static void handler_KogoeruHadou([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hikkurikaesu()
	{
		return null;
	}

	public static void handler_Hikkurikaesu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NeraiPunch()
	{
		return null;
	}

	public static void handler_NeraiPunch([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SuteZerifu()
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_FlyingPress()
	{
		return null;
	}

	public static void handler_FlyingPress([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FreezDry()
	{
		return null;
	}

	public static void handler_FreezDry([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Souden()
	{
		return null;
	}

	public static void handler_Souden([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GrassField()
	{
		return null;
	}

	public static void handler_GrassField([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MistField()
	{
		return null;
	}

	public static void handler_MistField([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ElecField()
	{
		return null;
	}

	public static void handler_ElecField([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PhychoField()
	{
		return null;
	}

	public static void handler_PhychoField([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_common_GroundSet([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BtlGround ground)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KingShield()
	{
		return null;
	}

	public static void handler_KingShield([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void kingShield_Success([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_KingShield_Success([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KingShield_MsgAfterCritical([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KingShield_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Blocking()
	{
		return null;
	}

	public static void Blocking_Success([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_Blocking_Success([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Blocking_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ThousanArrow()
	{
		return null;
	}

	public static void handler_ThousanArrow_CancelFloat([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ThousanArrow_AffEnable([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ThousanArrow_CheckAffine([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_ThousanArrow([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HappyTime()
	{
		return null;
	}

	public static void handler_HappyTime([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ZibaSousa()
	{
		return null;
	}

	public static void handler_ZibaSousa([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BenomTrap()
	{
		return null;
	}

	public static void handler_BenomTrap([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PlasmaFist()
	{
		return null;
	}

	public static void handler_PlasmaFist([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_FairyLock()
	{
		return null;
	}

	public static void handler_FairyLock([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Funjin()
	{
		return null;
	}

	public static void handler_Funjin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_GeoControl()
	{
		return null;
	}

	public static void handler_GeoControl_TameStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TrickGuard()
	{
		return null;
	}

	public static void handler_TrickGuard([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NeedleGuard()
	{
		return null;
	}

	public static void needleGuard_Success([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_NeedleGuard_Success([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NeedleGuard_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SouthernWave()
	{
		return null;
	}

	public static void handler_southernWave([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IjigenRush()
	{
		return null;
	}

	public static void handler_IjigenRush([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_IjigenRush_AfterDamage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AuraGuruma()
	{
		return null;
	}

	public static void handler_AuraGuruma([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AuraGuruma_Waza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AuraGuruma_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DarkHole()
	{
		return null;
	}

	public static void handler_DarkHole([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tootika()
	{
		return null;
	}

	public static void tootika_Success([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
	}

	public static void handler_Tootika_Success([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Tootika_DmgReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MezameruDance()
	{
		return null;
	}

	public static void handler_MezameruDance_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kahundango()
	{
		return null;
	}

	public static void handler_Kahundango_ExecuteCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kahundango_RecoverCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kahundango_RecoverFix([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Kahundango_Check_Affinity([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_CorePunisher()
	{
		return null;
	}

	public static void handler_CorePunisher_HitReal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kagenui()
	{
		return null;
	}

	public static void handler_Kagenui_HitReal([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Kuraituku()
	{
		return null;
	}

	public static bool kuraitukuCheck([In] ref EventFactor.EventHandlerArgs args, BTL_POKEPARAM attack, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	public static void kuraitukuSet([In] ref EventFactor.EventHandlerArgs args, byte attackPokeID, byte targetPokeID)
	{
	}

	public static void handler_Kuraituku([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TakoGatame()
	{
		return null;
	}

	public static void handler_TakoGatame_NoEffCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_takoGatame([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Zyouka()
	{
		return null;
	}

	public static void handler_Zyouka([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Tikarawosuitoru()
	{
		return null;
	}

	public static void handler_Tikarawosuitoru([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Togisumasu()
	{
		return null;
	}

	public static void handler_Togisumasu([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SpeedSwap()
	{
		return null;
	}

	public static void handler_SpeedSwap([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Moetukiru()
	{
		return null;
	}

	public static void handler_Moetukiru_WazaMeltCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Moetukiru_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Moetukiru_DamageProcEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_KutibasiCanon()
	{
		return null;
	}

	public static void handler_KutibasiCanon_BeforeFight([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KutibasiCanon_DamageReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KutibasiCanon_WazaSeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KutibasiCanon_ReplaceWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KutibasiCanon_Canceled([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_KutibasiCanon_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TrapShell()
	{
		return null;
	}

	public static void handler_TrapShell_BeforeFight([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TrapShell_DamageProcEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TrapShell_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_TrapShell_WazaEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Zidanda()
	{
		return null;
	}

	public static void handler_Zidanda_Dmg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_AuroraVeil()
	{
		return null;
	}

	public static void handler_AuroraVeil_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_AuroraVeil([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Saihai()
	{
		return null;
	}

	public static void handler_Saihai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MeteorDrive()
	{
		return null;
	}

	public static void handler_MeteorDrive_WazaSeqStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_MeteorDrive_WazaSeqEnd([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_ShadowSteal()
	{
		return null;
	}

	public static void handler_ShadowSteal_DamageProcStart([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_PhotonGeyser()
	{
		return null;
	}

	public static void handler_PhotonGeyser_WazaParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Hanabisenyou()
	{
		return null;
	}

	public static void handler_Hanabisenyou_dmg_determine([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_Hanabisenyou_no_effect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void common_HanabisenyouReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DaiWall()
	{
		return null;
	}

	public static void handler_DaiWall([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DaiWall_NoEffectCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_NeraiUti()
	{
		return null;
	}

	public static void handler_NeraiUti_Tempt([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_NeraiUti_Aim([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_HaisuiNoJin()
	{
		return null;
	}

	public static void handler_HaisuiNoJin_ExeCheck([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_HaisuiNoJin([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SoulBeat()
	{
		return null;
	}

	public static void handler_SoulBeat_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_SoulBeat_Damage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Ochakai()
	{
		return null;
	}

	public static bool ochakai_EatNuts([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void handler_Ochakai([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DengekiKutibasi()
	{
		return null;
	}

	public static void handler_DengekiKutibasi([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_TarShot()
	{
		return null;
	}

	public static void handler_TarShot_Str([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DragonArrow()
	{
		return null;
	}

	public static void handler_DragonArrow_Param([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DragonArrow_Inc([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void handler_DragonArrow_Msg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_InotiNoSizuku()
	{
		return null;
	}

	public static void handler_InotiNoSizuku_Msg([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Newton()
	{
		return null;
	}

	public static void handler_Newton([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}
}
