using Pml;

namespace Dpr.Battle.Logic;

public class BtlAIBaseScript
{
	protected const byte LOSS_CALC_OFF = 0;

	protected const byte LOSS_CALC_ON = 1;

	protected const byte AI_STATUSFLAG_END = 1;

	protected const byte AI_STATUSFLAG_ESCAPE = 2;

	protected const byte AI_STATUSFLAG_SAFARI = 4;

	protected const byte AI_STATUSFLAG_FINISH = 8;

	protected const byte AI_STATUSFLAG_CONTINUE = 16;

	protected const byte AI_STATUSFLAG_END_OFF = 254;

	protected const byte AI_STATUSFLAG_ESCAPE_OFF = 254;

	protected const byte AI_STATUSFLAG_SAFARI_OFF = 251;

	protected const byte AI_STATUSFLAG_CONTINUE_OFF = 239;

	protected const byte AI_ENEMY_ESCAPE = 4;

	protected const byte AI_ENEMY_SAFARI = 5;

	protected const byte AI_ENEMY_RESHUFFLE = 6;

	protected const byte CHECK_DEFENCE = 0;

	protected const byte CHECK_ATTACK = 1;

	protected const byte CHECK_DEFENCE_FRIEND = 2;

	protected const byte CHECK_ATTACK_FRIEND = 3;

	protected const byte CHECK_BENCH = 4;

	protected const byte CHECK_RAID_FRIEND1 = 5;

	protected const byte CHECK_RAID_FRIEND2 = 6;

	protected const byte CHECK_RAID_FRIEND3 = 7;

	protected const byte CHECK_DEFENCE_TYPE1 = 0;

	protected const byte CHECK_ATTACK_TYPE1 = 1;

	protected const byte CHECK_DEFENCE_TYPE2 = 2;

	protected const byte CHECK_ATTACK_TYPE2 = 3;

	protected const byte CHECK_WAZA = 4;

	protected const byte CHECK_DEFENCE_FRIEND_TYPE1 = 5;

	protected const byte CHECK_ATTACK_FRIEND_TYPE1 = 6;

	protected const byte CHECK_DEFENCE_FRIEND_TYPE2 = 7;

	protected const byte CHECK_ATTACK_FRIEND_TYPE2 = 8;

	protected const byte CHECK_RAID_FRIEND1_TYPE1 = 9;

	protected const byte CHECK_RAID_FRIEND1_TYPE2 = 10;

	protected const byte CHECK_RAID_FRIEND2_TYPE1 = 11;

	protected const byte CHECK_RAID_FRIEND2_TYPE2 = 12;

	protected const byte CHECK_RAID_FRIEND3_TYPE1 = 13;

	protected const byte CHECK_RAID_FRIEND3_TYPE2 = 14;

	protected const byte COMP_POWER_NONE = 0;

	protected const byte COMP_POWER_NOTOP = 1;

	protected const byte COMP_POWER_TOP = 2;

	protected const byte IF_FIRST_ATTACK = 0;

	protected const byte IF_FIRST_DEFENCE = 1;

	protected const byte IF_FIRST_EQUAL = 2;

	protected const byte AISYOU_0BAI = 0;

	protected const byte AISYOU_1_64BAI = 1;

	protected const byte AISYOU_1_32BAI = 2;

	protected const byte AISYOU_1_16BAI = 3;

	protected const byte AISYOU_1_8BAI = 4;

	protected const byte AISYOU_1_4BAI = 5;

	protected const byte AISYOU_1_2BAI = 6;

	protected const byte AISYOU_1BAI = 7;

	protected const byte AISYOU_2BAI = 8;

	protected const byte AISYOU_4BAI = 9;

	protected const byte AISYOU_8BAI = 10;

	protected const byte AISYOU_16BAI = 11;

	protected const byte AISYOU_32BAI = 12;

	protected const byte AISYOU_64BAI = 13;

	protected const byte PARA_HP = 0;

	protected const byte PARA_POW = 1;

	protected const byte PARA_DEF = 2;

	protected const byte PARA_SPEPOW = 3;

	protected const byte PARA_SPEDEF = 4;

	protected const byte PARA_AGI = 5;

	protected const byte PARA_HIT = 6;

	protected const byte PARA_AVOID = 7;

	protected const byte STATE_KANASIBARI = 0;

	protected const byte STATE_ENCORE = 1;

	protected const byte WEATHER_NONE = 0;

	protected const byte WEATHER_HARE = 1;

	protected const byte WEATHER_AME = 2;

	protected const byte WEATHER_ARARE = 3;

	protected const byte WEATHER_SUNAARASHI = 4;

	protected const byte WEATHER_OOAME = 5;

	protected const byte WEATHER_OOHIDERI = 6;

	protected const byte WEATHER_RANKIRYUU = 7;

	protected const byte WEATHER_HUKAIKIRI = 0;

	protected const byte LEVEL_ATTACK = 0;

	protected const byte LEVEL_DEFENCE = 1;

	protected const byte LEVEL_EQUAL = 2;

	protected const byte HAVE_NO = 0;

	protected const byte HAVE_YES = 1;

	protected const byte HAVE_UNKNOWN = 2;

	protected const uint TR_AI_TABLE_END = uint.MaxValue;

	protected const byte TABLE_JUMP_WAZASEQNO = 0;

	protected const byte WAZADATA_DMG_PHYSIC = 1;

	protected const byte WAZADATA_DMG_SPECIAL = 2;

	protected const ushort WAZASICK_NONE = 0;

	protected const ushort WAZASICK_MAHI = 1;

	protected const ushort WAZASICK_NEMURI = 2;

	protected const ushort WAZASICK_KOORI = 3;

	protected const ushort WAZASICK_YAKEDO = 4;

	protected const ushort WAZASICK_DOKU = 5;

	protected const ushort WAZASICK_KONRAN = 6;

	protected const ushort WAZASICK_MEROMERO = 7;

	protected const ushort WAZASICK_BIND = 8;

	protected const ushort WAZASICK_AKUMU = 9;

	protected const ushort WAZASICK_NOROI = 10;

	protected const ushort WAZASICK_TYOUHATSU = 11;

	protected const ushort WAZASICK_ICHAMON = 12;

	protected const ushort WAZASICK_KANASIBARI = 13;

	protected const ushort WAZASICK_AKUBI = 14;

	protected const ushort WAZASICK_KAIHUKUHUUJI = 15;

	protected const ushort WAZASICK_IEKI = 16;

	protected const ushort WAZASICK_MIYABURU = 17;

	protected const ushort WAZASICK_YADORIGI = 18;

	protected const ushort WAZASICK_SASIOSAE = 19;

	protected const ushort WAZASICK_HOROBINOUTA = 20;

	protected const ushort WAZASICK_NEWOHARU = 21;

	protected const ushort WAZASICK_TOOSENBOU = 22;

	protected const ushort WAZASICK_ENCORE = 23;

	protected const ushort WAZASICK_ZIGOKUDUKI = 24;

	protected const ushort WAZASICK_HANEYASUME = 25;

	protected const ushort WAZASICK_WAZALOCK = 26;

	protected const ushort WAZASICK_TAMELOCK = 27;

	protected const ushort WAZASICK_KODAWARI = 28;

	protected const ushort WAZASICK_MUSTHIT = 29;

	protected const ushort WAZASICK_MUSTHIT_TARGET = 30;

	protected const ushort WAZASICK_FLYING = 31;

	protected const ushort WAZASICK_FLYING_CANCEL = 32;

	protected const ushort WAZASICK_TELEKINESIS = 33;

	protected const ushort WAZASICK_FREEFALL = 34;

	protected const ushort WAZASICK_HITRATIO_UP = 35;

	protected const ushort WAZASICK_AQUARING = 36;

	protected const ushort WAZASICK_FORCE_WAZATYPE = 37;

	protected const ushort WAZASICK_FUNJIN = 38;

	protected const ushort WAZASICK_SAWAGU = 39;

	protected const ushort WAZASICK_ABARERU = 40;

	protected const ushort WAZASICK_TOGISUMASU = 41;

	protected const ushort WAZASICK_TAR = 42;

	protected const ushort WAZASICK_TAKOGATAME = 43;

	protected const ushort WAZASICK_KURAITUKU = 44;

	protected const ushort WAZASICK_MAX = 45;

	protected const ushort WAZASICK_STD_MAX = 8;

	protected const ushort WAZASICK_SPECIAL_CODE = ushort.MaxValue;

	protected const byte BTL_RULE_SINGLE = 0;

	protected const byte BTL_RULE_DOUBLE = 1;

	protected const byte BTL_RULE_RAID = 2;

	protected const byte POKETYPE_ORIGIN = 0;

	protected const byte POKETYPE_NORMAL = 0;

	protected const byte POKETYPE_KAKUTOU = 1;

	protected const byte POKETYPE_HIKOU = 2;

	protected const byte POKETYPE_DOKU = 3;

	protected const byte POKETYPE_JIMEN = 4;

	protected const byte POKETYPE_IWA = 5;

	protected const byte POKETYPE_MUSHI = 6;

	protected const byte POKETYPE_GHOST = 7;

	protected const byte POKETYPE_HAGANE = 8;

	protected const byte POKETYPE_HONOO = 9;

	protected const byte POKETYPE_MIZU = 10;

	protected const byte POKETYPE_KUSA = 11;

	protected const byte POKETYPE_DENKI = 12;

	protected const byte POKETYPE_ESPER = 13;

	protected const byte POKETYPE_KOORI = 14;

	protected const byte POKETYPE_DRAGON = 15;

	protected const byte POKETYPE_AKU = 16;

	protected const byte POKETYPE_FAIRY = 17;

	protected const byte BTL_GROUND_NONE = 0;

	protected const byte BTL_GROUND_GRASS = 1;

	protected const byte BTL_GROUND_MIST = 2;

	protected const byte BTL_GROUND_ELEKI = 3;

	protected const byte BTL_GROUND_PHYCHO = 4;

	protected const byte BTL_GROUND_MAX = 5;

	protected const byte TARGET_OTHER_SELECT = 0;

	protected const byte TARGET_FRIEND_USER_SELECT = 1;

	protected const byte TARGET_FRIEND_SELECT = 2;

	protected const byte TARGET_ENEMY_SELECT = 3;

	protected const byte TARGET_OTHER_ALL = 4;

	protected const byte TARGET_ENEMY_ALL = 5;

	protected const byte TARGET_FRIEND_ALL = 6;

	protected const byte TARGET_USER = 7;

	protected const byte TARGET_ALL = 8;

	protected const byte TARGET_ENEMY_RANDOM = 9;

	protected const byte TARGET_FIELD = 10;

	protected const byte TARGET_SIDE_ENEMY = 11;

	protected const byte TARGET_SIDE_FRIEND = 12;

	protected const byte TARGET_UNKNOWN = 13;

	protected const byte TARGET_MAX = 14;

	protected const byte PTL_SEX_MALE = 0;

	protected const byte PTL_SEX_FEMALE = 1;

	protected const byte PTL_SEX_UNKNOWN = 2;

	protected const byte SOUBI_HPKAIHUKU = 1;

	protected const byte SOUBI_DORAGONGHOSTUP = 2;

	protected const byte SOUBI_DORAGONHAGANEUP = 3;

	protected const byte SOUBI_DORAGONMIZUUP = 4;

	protected const byte SOUBI_MAHINAOSI = 5;

	protected const byte SOUBI_NEMUKEZAMASI = 6;

	protected const byte SOUBI_DOKUKESI = 7;

	protected const byte SOUBI_YAKEDONAOSI = 8;

	protected const byte SOUBI_KOORINAOSI = 9;

	protected const byte SOUBI_PPKAIHUKU = 10;

	protected const byte SOUBI_KONRANNAOSI = 11;

	protected const byte SOUBI_ZYOUTAIIZYOUNAOSI = 12;

	protected const byte SOUBI_HPKAIHUKUHIRITU = 13;

	protected const byte SOUBI_KARAIKONRAN = 14;

	protected const byte SOUBI_SIBUIKONRAN = 15;

	protected const byte SOUBI_AMAIKONRAN = 16;

	protected const byte SOUBI_NIGAIKONRAN = 17;

	protected const byte SOUBI_SUPPAIKONRAN = 18;

	protected const byte SOUBI_HONOWOBATUGUNGUARD = 19;

	protected const byte SOUBI_MIZUBATUGUNGUARD = 20;

	protected const byte SOUBI_DENKIBATUGUNGUARD = 21;

	protected const byte SOUBI_KUSABATUGUNGUARD = 22;

	protected const byte SOUBI_KOORIBATUGUNGUARD = 23;

	protected const byte SOUBI_KAKUTOUBATUGUNGUARD = 24;

	protected const byte SOUBI_DOKUBATUGUNGUARD = 25;

	protected const byte SOUBI_ZIMENBATUGUNGUARD = 26;

	protected const byte SOUBI_HIKOUBATUGUNGUARD = 27;

	protected const byte SOUBI_ESUPAABATUGUNGUARD = 28;

	protected const byte SOUBI_MUSIGUARD = 29;

	protected const byte SOUBI_IWAGUARD = 30;

	protected const byte SOUBI_GOOSUTOGUARD = 31;

	protected const byte SOUBI_DORAGONGUARD = 32;

	protected const byte SOUBI_AKUGUARD = 33;

	protected const byte SOUBI_HAGANEGUARD = 34;

	protected const byte SOUBI_NOOMARUHANGEN = 35;

	protected const byte SOUBI_KOUGEKIUP = 36;

	protected const byte SOUBI_BOUGYOUP = 37;

	protected const byte SOUBI_SUBAYASAUP = 38;

	protected const byte SOUBI_TOKUKOUUP = 39;

	protected const byte SOUBI_TOKUBOUUP = 40;

	protected const byte SOUBI_KURITHIKARUUP = 41;

	protected const byte SOUBI_NOURYOKURNDUP = 42;

	protected const byte SOUBI_BATUGUNKAIHUKU = 43;

	protected const byte SOUBI_ITIDODAKEMEITYUUUP = 44;

	protected const byte SOUBI_ITIDODAKESENSEI = 45;

	protected const byte SOUBI_BUTURIDEKOUGEKI = 46;

	protected const byte SOUBI_TOKUSYUDEKOUGEKI = 47;

	protected const byte SOUBI_MEITYUURITUDOWN = 48;

	protected const byte SOUBI_NOURYOKUKAIHUKU = 49;

	protected const byte SOUBI_DORYOKUTINIBAI = 50;

	protected const byte SOUBI_SENSEIKOUGEKI = 51;

	protected const byte SOUBI_NATUKIDOUP = 52;

	protected const byte SOUBI_MEROMERONAOSI = 53;

	protected const byte SOUBI_ONAZIWAZAONLY = 54;

	protected const byte SOUBI_HIRUMASERU = 55;

	protected const byte SOUBI_MUSIIRYOKUUP = 56;

	protected const byte SOUBI_OKANENIBAI = 57;

	protected const byte SOUBI_ENCOUNTRITUDOWN = 58;

	protected const byte SOUBI_TOKUKOUTOKUBOUUP = 59;

	protected const byte SOUBI_PAARURUTOKUKOUNIBAI = 60;

	protected const byte SOUBI_PAARURUTOKUBOUNIBAI = 61;

	protected const byte SOUBI_KANARAZUNIGERARERU = 62;

	protected const byte SOUBI_SINKASINAI = 63;

	protected const byte SOUBI_HPITIDETAERU = 64;

	protected const byte SOUBI_KEIKENTIHUERU = 65;

	protected const byte SOUBI_KYUUSYONIATARIYASUI = 66;

	protected const byte SOUBI_HAGANEIRYOKUUP = 67;

	protected const byte SOUBI_HPKAIHUKUMAITURN = 68;

	protected const byte SOUBI_DORAGONTUUSINSINKA = 69;

	protected const byte SOUBI_PIKATYUUTOKUKOUNIBAI = 70;

	protected const byte SOUBI_ZIMENUP = 71;

	protected const byte SOUBI_IWAUP = 72;

	protected const byte SOUBI_KUSAUP = 73;

	protected const byte SOUBI_AKUUP = 74;

	protected const byte SOUBI_KAKUTOUUP = 75;

	protected const byte SOUBI_DENKIUP = 76;

	protected const byte SOUBI_MIZUUP = 77;

	protected const byte SOUBI_TORIUP = 78;

	protected const byte SOUBI_DOKUBARIUP = 79;

	protected const byte SOUBI_KOORIUP = 80;

	protected const byte SOUBI_GOOSUTOUP = 81;

	protected const byte SOUBI_ESUPAAUP = 82;

	protected const byte SOUBI_HONOOUP = 83;

	protected const byte SOUBI_DORAGONUP = 84;

	protected const byte SOUBI_NOOMARUUP = 85;

	protected const byte SOUBI_PORIGONSINKA = 86;

	protected const byte SOUBI_HPKAIHUKUDAMEEZIRITU = 87;

	protected const byte SOUBI_RAKKIIDATOKYUUSYONIATARIYASUI = 88;

	protected const byte SOUBI_METAMONDATOBOUGYORYOKUUP = 89;

	protected const byte SOUBI_KARAGARADATOKOUGEKINIBAI = 90;

	protected const byte SOUBI_KAMONEGIKYUUSYOATARIYASUI = 91;

	protected const byte SOUBI_MEITYUUUP = 92;

	protected const byte SOUBI_BUTURIIRYOKUUP = 93;

	protected const byte SOUBI_TOKUSYUIRYOKUUP = 94;

	protected const byte SOUBI_BATUGUNIRYOKUUP = 95;

	protected const byte SOUBI_KABENOZIKANHUERU = 96;

	protected const byte SOUBI_WAZAIRYOKUUPHPMAINASU = 97;

	protected const byte SOUBI_2TURNWAZAWO1TURN = 98;

	protected const byte SOUBI_TEKINIMOTASERUTOMOUDOKU = 99;

	protected const byte SOUBI_TTEKINIMOTASERUTOYAKEDO = 100;

	protected const byte SOUBI_METAMONSUBAYASAUP = 101;

	protected const byte SOUBI_HPMAXDEITIGEKISISINAI = 102;

	protected const byte SOUBI_KOUKOUNOTOKIMEITYUUUP = 103;

	protected const byte SOUBI_ONAZIWAZANOIRYOKUUP = 104;

	protected const byte SOUBI_SUBAYASADOWN = 105;

	protected const byte SOUBI_KOUKOUNINARU = 106;

	protected const byte SOUBI_MEROMERODETEKIMOMEROMERO = 107;

	protected const byte SOUBI_DOKUKAIHUKU = 108;

	protected const byte SOUBI_ARAREUP = 109;

	protected const byte SOUBI_SUNAARASIUP = 110;

	protected const byte SOUBI_HAREUPAMEDOWN = 111;

	protected const byte SOUBI_AMEUPHAREDOWN = 112;

	protected const byte SOUBI_MAKITUKUKEIUP = 113;

	protected const byte SOUBI_ONAZIWAZAONLYSUBAYASAUP = 114;

	protected const byte SOUBI_TEKINIMOTASETEDAMEEZI = 115;

	protected const byte SOUBI_KOUGEKIDORYOKUTIUP = 116;

	protected const byte SOUBI_BOUGYODORYOKUTIUP = 117;

	protected const byte SOUBI_TOKUKOUDORYOKUTIUP = 118;

	protected const byte SOUBI_TOKUBOUDORYOKUTIUP = 119;

	protected const byte SOUBI_SUBAYASADORYOKUTIUP = 120;

	protected const byte SOUBI_HPDORYOKUTIUP = 121;

	protected const byte SOUBI_KANARAZUIREKAWARERU = 122;

	protected const byte SOUBI_KYUSYUURYOKUUP = 123;

	protected const byte SOUBI_ONAZIAWZAONLYTOKUSYUUP = 124;

	protected const byte SOUBI_AUSUHONOOUP = 125;

	protected const byte SOUBI_AUSUMIZUUP = 126;

	protected const byte SOUBI_AUSUDENKIUP = 127;

	protected const byte SOUBI_AUSUKUSAUP = 128;

	protected const byte SOUBI_AUSUKOORIUP = 129;

	protected const byte SOUBI_AUSUKAKUTOUUP = 130;

	protected const byte SOUBI_AUSUDOKUBARIUP = 131;

	protected const byte SOUBI_AUSUZIMENUP = 132;

	protected const byte SOUBI_AUSUTORIUP = 133;

	protected const byte SOUBI_AUSUESUPAAUP = 134;

	protected const byte SOUBI_AUSUMUSIIRYOKUUP = 135;

	protected const byte SOUBI_AUSUIWAUP = 136;

	protected const byte SOUBI_AUSUGOOSUTOUP = 137;

	protected const byte SOUBI_AUSUDORAGONUP = 138;

	protected const byte SOUBI_AUSUAKUUP = 139;

	protected const byte SOUBI_AUSUHAGANEIRYOKUUP = 140;

	protected const byte SOUBI_SAIDONSINKA = 141;

	protected const byte SOUBI_EREBUSINKA = 142;

	protected const byte SOUBI_BUBASINKA = 143;

	protected const byte SOUBI_PORIGON2SINKA = 144;

	protected const byte SOUBI_SAMAYORUSINKA = 145;

	protected const byte SOUBI_SINKANOKISEKI = 146;

	protected const byte SOUBI_KARUISI = 147;

	protected const byte SOUBI_GOTUGOTUMETTO = 148;

	protected const byte SOUBI_HUUSEN = 149;

	protected const byte SOUBI_REDDOKAADO = 150;

	protected const byte SOUBI_NERAINOMATO = 151;

	protected const byte SOUBI_SIMETUKEBANDO = 152;

	protected const byte SOUBI_KYUUKON = 153;

	protected const byte SOUBI_ZYUUDENTI = 154;

	protected const byte SOUBI_DAASYUTUBOTAN = 155;

	protected const byte SOUBI_HONOONOZYUERU = 156;

	protected const byte SOUBI_MIZUNONOZYUERU = 157;

	protected const byte SOUBI_DENKINOZYUERU = 158;

	protected const byte SOUBI_KUSANOZYUERU = 159;

	protected const byte SOUBI_KOORINOZYUERU = 160;

	protected const byte SOUBI_KAKUTOUZYUERU = 161;

	protected const byte SOUBI_DOKUNOZYUERU = 162;

	protected const byte SOUBI_ZIMENNOZYUERU = 163;

	protected const byte SOUBI_HIKOUNOZYUERU = 164;

	protected const byte SOUBI_ESUPAAZYUERU = 165;

	protected const byte SOUBI_MUSINOZYUERU = 166;

	protected const byte SOUBI_IWANOZYUERU = 167;

	protected const byte SOUBI_GOOSUTOZYUERU = 168;

	protected const byte SOUBI_DORAGONZYUERU = 169;

	protected const byte SOUBI_AKUNOZYUERU = 170;

	protected const byte SOUBI_HAGANENOZYUERU = 171;

	protected const byte SOUBI_NOOMARUZYUERU = 172;

	protected const byte SOUBI_ZYAKUTENHOKEN = 173;

	protected const byte SOUBI_TOTUGEKITYOKKI = 174;

	protected const byte SOUBI_AUSUFEARIIUP = 175;

	protected const byte SOUBI_HIKARIGOKE = 176;

	protected const byte SOUBI_YUKIDAMA = 177;

	protected const byte SOUBI_BOOZINGOOGURU = 178;

	protected const byte SOUBI_FEARIIGUARD = 179;

	protected const byte SOUBI_BUTURIBOUGYOUP = 180;

	protected const byte SOUBI_TOKUSYUTOKUBOUUP = 181;

	protected const byte SOUBI_FEARIIZYUERU = 182;

	protected const byte SOUBI_BIBIRIDAMA = 183;

	protected const byte SOUBI_GURANDOKOOTO = 184;

	protected const byte SOUBI_BOUGOPATTO = 185;

	protected const byte SOUBI_EREKISIIDO = 186;

	protected const byte SOUBI_SAIKOSIIDO = 187;

	protected const byte SOUBI_MISUTOSIIDO = 188;

	protected const byte SOUBI_GURASUSIIDO = 189;

	protected const byte SOUBI_CASSETTE = 190;

	protected const byte TUIBAMU_MAHINAOSI = 1;

	protected const byte TUIBAMU_NEMUKEZAMASI = 2;

	protected const byte TUIBAMU_DOKUKESI = 3;

	protected const byte TUIBAMU_YAKEDONAOSI = 4;

	protected const byte TUIBAMU_KOORINAOSI = 5;

	protected const byte TUIBAMU_PPKAIHUKU = 6;

	protected const byte TUIBAMU_HPKAIHUKU = 7;

	protected const byte TUIBAMU_KONRANNAOSI = 8;

	protected const byte TUIBAMU_ZYOUTAIIZYOUNAOSI = 9;

	protected const byte TUIBAMU_HPKAIHUKUHIRITU = 10;

	protected const byte TUIBAMU_KARAIKONRAN = 11;

	protected const byte TUIBAMU_SIBUIKONRAN = 12;

	protected const byte TUIBAMU_AMAIKONRAN = 13;

	protected const byte TUIBAMU_NIGAIKONRAN = 14;

	protected const byte TUIBAMU_SUPPAIKONRAN = 15;

	protected const byte TUIBAMU_KOUGEKIUP = 16;

	protected const byte TUIBAMU_BOUGYOUP = 17;

	protected const byte TUIBAMU_SUBAYASAUP = 18;

	protected const byte TUIBAMU_TOKUKOUUP = 19;

	protected const byte TUIBAMU_TOKUBOUUP = 20;

	protected const byte TUIBAMU_KURITHIKARUUP = 21;

	protected const byte TUIBAMU_NOURYOKURNDUP = 22;

	protected const byte TUIBAMU_ITIDODAKEMEITYUUUP = 23;

	protected const byte EFF_WEATHER = 0;

	protected const byte EFF_TRICKROOM = 1;

	protected const byte EFF_JURYOKU = 2;

	protected const byte EFF_FUIN = 3;

	protected const byte EFF_WONDERROOM = 4;

	protected const byte EFF_MAGICROOM = 5;

	protected const byte EFF_PLASMASHOWER = 6;

	protected const byte EFF_FAIRY_LOCK = 7;

	protected const byte EFF_GROUND = 8;

	protected const byte EFF_KAGAKUHENKAGAS = 9;

	protected const byte EFF_MAX = 10;

	protected const byte EFF_NULL = 10;

	protected const byte BTL_SIDEEFF_REFLECTOR = 0;

	protected const byte BTL_SIDEEFF_HIKARINOKABE = 1;

	protected const byte BTL_SIDEEFF_SINPINOMAMORI = 2;

	protected const byte BTL_SIDEEFF_SIROIKIRI = 3;

	protected const byte BTL_SIDEEFF_OIKAZE = 4;

	protected const byte BTL_SIDEEFF_OMAJINAI = 5;

	protected const byte BTL_SIDEEFF_MAKIBISI = 6;

	protected const byte BTL_SIDEEFF_DOKUBISI = 7;

	protected const byte BTL_SIDEEFF_STEALTHROCK = 8;

	protected const byte BTL_SIDEEFF_WIDEGUARD = 9;

	protected const byte BTL_SIDEEFF_FASTGUARD = 10;

	protected const byte BTL_SIDEEFF_RAINBOW = 11;

	protected const byte BTL_SIDEEFF_BURNING = 12;

	protected const byte BTL_SIDEEFF_MOOR = 13;

	protected const byte BTL_SIDEEFF_NEBANEBANET = 14;

	protected const byte BTL_SIDEEFF_TATAMIGAESHI = 15;

	protected const byte BTL_SIDEEFF_TRICKGUARD = 16;

	protected const byte BTL_SIDEEFF_AURORAVEIL = 17;

	protected const byte BTL_SIDEEFF_SPOTLIGHT = 18;

	protected const byte BTL_SIDEEFF_STEALTHROCK_HAGANE = 19;

	protected const byte BTL_SIDEEFF_GSHOCK_HONOO = 20;

	protected const byte BTL_SIDEEFF_GSHOCK_IWA = 21;

	protected const byte BTL_SIDEEFF_MAX = 22;

	protected const byte BTL_SIDEEFF_NULL = 22;

	protected const byte CONTFLG_ACTION_DONE = 0;

	protected const byte CONTFLG_CANT_CHANGE = 1;

	protected const byte CONTFLG_TAME = 2;

	protected const byte CONTFLG_SORAWOTOBU = 3;

	protected const byte CONTFLG_DIVING = 4;

	protected const byte CONTFLG_ANAWOHORU = 5;

	protected const byte CONTFLG_SHADOWDIVE = 6;

	protected const byte CONTFLG_MARUKUNARU = 7;

	protected const byte CONTFLG_TIISAKUNARU = 8;

	protected const byte CONTFLG_KIAIDAME = 9;

	protected const byte CONTFLG_POWERTRICK = 10;

	protected const byte CONTFLG_MIKURUNOMI = 11;

	protected const byte CONTFLG_CANT_ACTION = 12;

	protected const byte CONTFLG_MORAIBI = 13;

	protected const byte CONTFLG_BATONTOUCH = 14;

	protected const byte CONTFLG_ITEM_LOSE = 15;

	protected const byte CONTFLG_ELECFIELD_GUARD = 16;

	protected const byte CONTFLG_MISTFIELD_GUARD = 17;

	protected const byte CONTFLG_ONNEN = 18;

	protected const byte CONTFLG_MITIDURE = 19;

	protected const byte CONTFLG_JUDEN = 20;

	protected const byte CONTFLG_GAMAN = 21;

	protected const byte CONTFLG_BODYPURGE = 22;

	protected const byte CONTFLG_MOETUKIRU = 23;

	protected const byte CONTFLG_HAISUINOZIN = 24;

	protected const byte CONTFLG_MAX = 25;

	protected const byte CONTFLG_NULL = 25;

	protected const byte CMD_IF_RND_UNDER = 0;

	protected const byte CMD_IF_RND_OVER = 1;

	protected const byte CMD_IF_RND_EQUAL = 2;

	protected const byte CMD_IFN_RND_EQUAL = 3;

	protected const byte CMD_IF_HP_UNDER = 4;

	protected const byte CMD_IF_HP_OVER = 5;

	protected const byte CMD_IF_HP_EQUAL = 6;

	protected const byte CMD_IFN_HP_EQUAL = 7;

	protected const byte CMD_IF_POKESICK = 8;

	protected const byte CMD_IFN_POKESICK = 9;

	protected const byte CMD_IF_WAZASICK = 10;

	protected const byte CMD_IFN_WAZASICK = 11;

	protected const byte CMD_IF_DOKUDOKU = 12;

	protected const byte CMD_IFN_DOKUDOKU = 13;

	protected const byte CMD_IF_CONTFLG = 14;

	protected const byte CMD_IFN_CONTFLG = 15;

	protected const byte CMD_IF_SIDEEFF = 16;

	protected const byte CMD_IFN_SIDEEFF = 17;

	protected const byte CMD_GET_HOROBINOUTA_TURN_MAX = 18;

	protected const byte CMD_GET_HOROBINOUTA_TURN_NOW = 19;

	protected const byte CMD_GET_KODAWARI_WAZA = 20;

	protected const byte CMD_IF_HAVE_DAMAGE_WAZA = 21;

	protected const byte CMD_IFN_HAVE_DAMAGE_WAZA = 22;

	protected const byte CMD_CHECK_TURN = 23;

	protected const byte CMD_CHECK_TYPE = 24;

	protected const byte CMD_CHECK_WAZA_USABLE = 25;

	protected const byte CMD_CHECK_DAMAGE_WAZA = 26;

	protected const byte CMD_CHECK_IRYOKU = 27;

	protected const byte CMD_COMP_POWER = 28;

	protected const byte CMD_CHECK_LAST_WAZA = 29;

	protected const byte CMD_IF_FIRST = 30;

	protected const byte CMD_CHECK_BENCH_COUNT = 31;

	protected const byte CMD_CHECK_WAZASEQNO = 32;

	protected const byte CMD_CHECK_TOKUSEI = 33;

	protected const byte CMD_CHECK_WAZA_AISYOU = 34;

	protected const byte CMD_GET_WAZA_AISYOU = 35;

	protected const byte CMD_IF_HAVE_WAZA_AISYOU_OVER = 36;

	protected const byte CMD_IF_HAVE_WAZA_AISYOU_EQUAL = 37;

	protected const byte CMD_IF_BENCH_COND = 38;

	protected const byte CMD_IFN_BENCH_COND = 39;

	protected const byte CMD_CHECK_WEATHER = 40;

	protected const byte CMD_IF_PARA_UNDER = 41;

	protected const byte CMD_IF_PARA_OVER = 42;

	protected const byte CMD_IF_PARA_EQUAL = 43;

	protected const byte CMD_IFN_PARA_EQUAL = 44;

	protected const byte CMD_IF_WAZA_HINSHI = 45;

	protected const byte CMD_IFN_WAZA_HINSHI = 46;

	protected const byte CMD_IF_HAVE_WAZA = 47;

	protected const byte CMD_IFN_HAVE_WAZA = 48;

	protected const byte CMD_IF_HAVE_WAZA_SEQNO = 49;

	protected const byte CMD_IFN_HAVE_WAZA_SEQNO = 50;

	protected const byte CMD_ESCAPE = 51;

	protected const byte CMD_CHECK_SOUBI_ITEM = 52;

	protected const byte CMD_CHECK_SOUBI_EQUIP = 53;

	protected const byte CMD_CHECK_POKESEX = 54;

	protected const byte CMD_CHECK_NEKODAMASI = 55;

	protected const byte CMD_CHECK_TAKUWAERU = 56;

	protected const byte CMD_CHECK_BTL_RULE = 57;

	protected const byte CMD_CHECK_BTL_COMPETITOR = 58;

	protected const byte CMD_CHECK_RECYCLE_ITEM = 59;

	protected const byte CMD_CHECK_WORKWAZA_TYPE = 60;

	protected const byte CMD_CHECK_WORKWAZA_POW = 61;

	protected const byte CMD_CHECK_WORKWAZA_SEQNO = 62;

	protected const byte CMD_CHECK_MAMORU_COUNT = 63;

	protected const byte CMD_IF_LEVEL = 64;

	protected const byte CMD_IF_CHOUHATSU = 65;

	protected const byte CMD_IFN_CHOUHATSU = 66;

	protected const byte CMD_IF_MIKATA_ATTACK = 67;

	protected const byte CMD_CHECK_HAVE_TYPE = 68;

	protected const byte CMD_CHECK_HAVE_TOKUSEI = 69;

	protected const byte CMD_IF_ALREADY_MORAIBI = 70;

	protected const byte CMD_IF_HAVE_ITEM = 71;

	protected const byte CMD_FLDEFF_CHECK = 72;

	protected const byte CMD_CHECK_SIDEEFF_COUNT = 73;

	protected const byte CMD_IF_BENCH_HPDEC = 74;

	protected const byte CMD_IF_BENCH_PPDEC = 75;

	protected const byte CMD_CHECK_NAGETSUKERU_IRYOKU = 76;

	protected const byte CMD_CHECK_PP_REMAIN = 77;

	protected const byte CMD_IF_TOTTEOKI = 78;

	protected const byte CMD_CHECK_WAZA_KIND = 79;

	protected const byte CMD_CHECK_LAST_WAZA_KIND = 80;

	protected const byte CMD_CHECK_AGI_RANK = 81;

	protected const byte CMD_CHECK_SLOWSTART_TURN = 82;

	protected const byte CMD_IF_BENCH_DAMAGE_MAX = 83;

	protected const byte CMD_IF_HAVE_BATSUGUN = 84;

	protected const byte CMD_IF_LAST_WAZA_DAMAGE_CHECK = 85;

	protected const byte CMD_CHECK_STATUS_UP = 86;

	protected const byte CMD_CHECK_STATUS_DIFF = 87;

	protected const byte CMD_CHECK_STATUS = 88;

	protected const byte CMD_COMP_POWER_WITH_PARTNER = 89;

	protected const byte CMD_IF_HINSHI = 90;

	protected const byte CMD_IFN_HINSHI = 91;

	protected const byte CMD_GET_TOKUSEI = 92;

	protected const byte CMD_IF_MIGAWARI = 93;

	protected const byte CMD_CHECK_MONSNO = 94;

	protected const byte CMD_CHECK_FORMNO = 95;

	protected const byte CMD_IF_COMMONRND_UNDER = 96;

	protected const byte CMD_IF_COMMONRND_OVER = 97;

	protected const byte CMD_IF_COMMONRND_EQUAL = 98;

	protected const byte CMD_IFN_COMMONRND_EQUAL = 99;

	protected const byte CMD_IF_MIRAIYOCHI = 100;

	protected const byte CMD_IF_DMG_PHYSIC_UNDER = 101;

	protected const byte CMD_IF_DMG_PHYSIC_OVER = 102;

	protected const byte CMD_IF_DMG_PHYSIC_EQUAL = 103;

	protected const byte CMD_IF_ATE_KINOMI = 104;

	protected const byte CMD_IF_TYPE_EX = 105;

	protected const byte CMD_IF_EXIST_GROUND = 106;

	protected const byte CMD_GET_WEIGHT = 107;

	protected const byte CMD_IF_MULTI = 108;

	protected const byte CMD_IF_MEGAEVOLVED = 109;

	protected const byte CMD_IF_CAN_MEGAEVOLVE = 110;

	protected const byte CMD_IF_WAZAHIDE = 111;

	protected const byte CMD_GET_MEZAME_TYPE = 112;

	protected const byte CMD_IF_I_AM_SENARIO_TRAINER = 113;

	protected const byte CMD_GET_MAX_WAZA_POWER_INCLUDE_AFFINITY = 114;

	protected const byte CMD_CHECK_WAZA_NO_EFFECT_BY_TOKUSEI = 115;

	protected const byte CMD_GET_LAST_DAMAGED_WAZA_AT_PREV_TURN = 116;

	protected const byte CMD_GET_CURRENT_WAZANO = 117;

	protected const byte CMD_GET_CURRENT_ITEMNO = 118;

	protected const byte CMD_IF_ZIDANDA_POWERUP = 119;

	protected const byte CMD_GET_CLIENT_KILL_COUNT = 120;

	protected const byte CMD_GET_WAZA_TARGET = 121;

	protected const byte CMD_IF_HAVE_BATSUGUN_CAN_BENCH = 122;

	protected const byte CMD_IF_G = 123;

	protected const byte CMD_IF_HAVE_KINOMI = 124;

	protected const byte CMD_IF_GWALL_EXIST = 125;

	protected const byte CMD_IF_JK3_LEGEND = 126;

	protected const byte CMD_IF_CAN_G = 127;

	protected const byte CMD_IF_GWAZA_USE_TURN = 128;

	protected const byte CMD_IF_CAN_CHANGE_POKE = 129;

	protected const byte NUM_AI_CMD = 130;

	protected int p_PokeChangeEnable;

	protected int p_Score;

	protected int MyClientID;

	protected long Call(byte cmd, long[] args)
	{
		return default(long);
	}

	protected void ScoreCtrl(int value)
	{
	}

	protected void SetPokeChangeEnable()
	{
	}

	protected WazaNo CurrentWazaNo()
	{
		return default(WazaNo);
	}

	protected void PRINTF(string s)
	{
	}

	public void SetGlobalParameters(int clientID, int score, int pokeChangeEnable)
	{
	}

	protected virtual void main()
	{
	}

	public void Execute()
	{
	}

	public void GetResult(AiScript.Result result)
	{
	}
}
