namespace Dpr.Message;

public static class MessageEnumData
{
	public enum MsgLangId
	{
		JPN = 1,
		USA = 2,
		FRA = 3,
		ITA = 4,
		DEU = 5,
		ESP = 7,
		KOR = 8,
		SCH = 9,
		TCH = 10,
		Num = 11
	}

	public enum NXLangId
	{
		Japanese = 0,
		English = 1,
		French = 2,
		German = 3,
		Italian = 4,
		Spanish = 5,
		Korean = 7,
		NetherLands = 8,
		Portuguese = 9,
		Russian = 10,
		SimpChinese = 15,
		TradChinese = 16
	}

	public enum TagPatternID
	{
		Word,
		Digit,
		Conversion,
		RichText,
		Grammar,
		GrammarWord,
		ControlDesign,
		ControlMessage,
		SpriteFont
	}

	public enum InitialSoundID
	{
		Vowel,
		VowelA,
		VowelE,
		Vowel2,
		Vowel3,
		Consonant2,
		Consonant
	}

	public enum AttributeID
	{
		EnglishInitialSound = 3,
		EnglishCountability = 4,
		EnglishArticlePresence = 5,
		FrenchGender = 7,
		FrenchInitialSound = 8,
		FrenchCountability = 9,
		FrenchExtraAttribute = 10,
		FrenchArticlePresence = 11,
		ItalianGender = 12,
		ItalianInitialSound = 13,
		ItalianCountability = 14,
		ItalianArticlePresence = 16,
		GermanGender = 17,
		GermanCountability = 18,
		GermanExtraAttribute = 19,
		GermanArticlePresence = 20,
		SpanishGender = 21,
		SpanishInitialSound = 22,
		SpanishCountability = 23,
		SpanishExtraAttribute = 24,
		SpanishArticlePresence = 25,
		LabelIndex = 65,
		Version = 67
	}

	public enum AttriCountabilityID
	{
		Countable,
		Uncontable,
		AlwaysPlural
	}

	public enum AttriArticleID
	{
		Article,
		NoArticle
	}

	public enum ENInitialSoundID
	{
		AutoDetected,
		Consonant,
		Vowel
	}

	public enum FRInitialSoundID
	{
		AutoDetected,
		NoElision,
		YesElision
	}

	public enum ITInitialSoundID
	{
		AutoDetected,
		ConsonantOthers,
		S_Consonant,
		Vowel
	}

	public enum ESInitialSoundID
	{
		AutoDetected,
		Consonant,
		Cacophony_y,
		TonicaA,
		Cacophony_o
	}

	public enum StyleID
	{
		keywait_text_18_big,
		keywait_text_23_big,
		keywait_text_28_big,
		std_1_N_big,
		std_4_N_big,
		std_6_N_big,
		std_7_N_big,
		std_8_N_big,
		std_10_N_big,
		std_10_N2_big,
		std_11_N_big,
		std_11_N2_big,
		std_12_N_big,
		std_12_N2_big,
		std_14_N_big,
		std_15_N_big,
		std_15_N4_big,
		std_16_N_big,
		std_17_N_big,
		std_18_N_big,
		std_18_N2_big,
		std_18_N3_big,
		std_18_N4_big,
		std_18_N5_big,
		std_18_N6_big,
		std_18_N7_big,
		std_18_N10_big,
		std_20_N4_big,
		std_23_N_big,
		std_23_N2_big,
		keywait_text_18,
		keywait_text_23,
		std_01_N,
		std_02_N,
		std_03_N,
		std_04_N,
		std_05_N,
		std_06_N,
		std_07_N,
		std_08_N,
		std_08_N2,
		std_09_N,
		std_10_N,
		std_10_N2,
		std_11_N,
		std_11_N2,
		std_12_N,
		std_13_N,
		std_14_N,
		std_15_N,
		std_16_N,
		std_16_N2,
		std_16_N4,
		std_16_N5,
		std_16_N7,
		std_17_N,
		std_18_N,
		std_18_N2,
		std_18_N3,
		std_18_N4,
		std_18_N5,
		std_18_N6,
		std_18_N7,
		std_18_N8,
		std_18_N10,
		std_20_N,
		std_20_N6,
		std_20_N12,
		std_21_N,
		std_21_N3,
		std_22_N2,
		std_23_N,
		std_23_N2,
		std_24_N,
		std_30_N,
		std_43_N,
		std_01_N_small,
		std_02_N_small,
		std_03_N_small,
		std_04_N_small,
		std_05_N_small,
		std_06_N_small,
		std_07_N_small,
		std_08_N_small,
		std_08_N2_small,
		std_08_N3_small,
		std_09_N_small,
		std_10_N_small,
		std_10_N2_small,
		std_10_N3_small,
		std_11_N_small,
		std_12_N_small,
		std_13_N_small,
		std_14_N_small,
		std_15_N_small,
		std_16_N_small,
		std_16_N2_small,
		std_16_N4_small,
		std_16_N5_small,
		std_16_N7_small,
		std_16_N8_small,
		std_16_N14_small,
		std_18_N_small,
		std_18_N2_small,
		std_18_N3_small,
		std_18_N5_small,
		std_20_N2_small,
		std_20_N3_small,
		std_21_N_small,
		std_21_N3_small,
		std_22_N_small,
		std_22_N3_small,
		std_23_N_small,
		std_23_N2_small,
		std_23_N5_small,
		std_32_N_small,
		std_46_N_small,
		std_10_G_big,
		std_14_G_big,
		std_05_G,
		std_06_G,
		std_08_G,
		std_08_G_P,
		std_08_G_C,
		std_09_G,
		std_10_G,
		std_10_G_P,
		std_10_G_C,
		std_12_G,
		std_12_G_P,
		std_12_G_C,
		std_14_G,
		std_15_G,
		std_16_G,
		std_05_G_small,
		std_06_G_small,
		std_08_G_P_small,
		std_08_G_small,
		std_10_G_small,
		std_14_G_small,
		std_01_S_big,
		std_02_S_big,
		std_03_S_big,
		std_04_S_big,
		std_05_S_big,
		std_06_S_big,
		std_01_S,
		std_02_S,
		std_03_S,
		std_04_S,
		std_05_S,
		std_06_S,
		std_07_S,
		std_08_S,
		std_09_S,
		std_10_S,
		std_11_S,
		std_12_S,
		std_14_S,
		std_16_S,
		std_17_S,
		std_18_S,
		std_19_S,
		std_24_S,
		std_01_S_small,
		std_02_S_small,
		std_03_S_small,
		std_04_S_small,
		std_05_S_small,
		std_06_S_small,
		std_07_S_small,
		std_08_S_small,
		std_09_S_small,
		std_10_S_small,
		std_11_S_small,
		std_12_S_small,
		std_14_S_small,
		std_16_S_small,
		std_17_S_small,
		std_19_S_small,
		std_24_S_small,
		std_6_N_huge,
		std_10_N_huge,
		keywait_text_18_big_white,
		keywait_text_18_big_1,
		keywait_text_18_big_2,
		keywait_text_18_big_3,
		keywait_text_14_big_white,
		Max
	}

	public enum FontID
	{
		Switch_Std = 1,
		Switch_Small,
		Switch_Big,
		Switch_Std_efigs,
		Switch_Small_efigs,
		Switch_Big_efigs,
		Switch_Std_kor,
		Switch_Small_kor,
		Switch_Big_kor,
		Switch_Std_simp,
		Switch_Small_simp,
		Switch_Big_simp,
		Switch_Std_trad,
		Switch_Small_trad,
		Switch_Big_trad,
		Switch_Huge,
		Switch_Huge_efigs,
		Switch_Huge_kor,
		Switch_Huge_simp,
		Switch_Huge_trad
	}

	public enum FontSizeID
	{
		Small,
		Std,
		Big,
		Huge
	}

	public enum GroupTagID
	{
		System = 0,
		Name = 1,
		Digit = 2,
		Grm = 16,
		EN = 19,
		FR = 20,
		IT = 21,
		DE = 22,
		ES = 23,
		Kor = 25,
		SC = 26,
		Character1 = 50,
		Character2 = 51,
		Ctrl1 = 189,
		Ctrl2 = 190
	}

	public enum SystemID
	{
		Font = 1,
		Size,
		Color
	}

	public enum NameID
	{
		TrainerName,
		PokemonName,
		PokemonNickname,
		Type,
		PokedexType,
		Place,
		Ability,
		Move,
		Nature,
		Item,
		ItemClassified,
		ItemAcc,
		PokemonNicknameTwo,
		Status,
		TrainerType,
		Poffin,
		ItemAccClassified,
		GoodsName,
		Pocket,
		ItemText,
		TrainerNameField,
		Poketch,
		UgItem,
		BagPocketIcon,
		PocketIcon,
		Word,
		Question,
		Answer,
		Accessory,
		Gym,
		TimeZone,
		Contest,
		ContestRank,
		PokeGender,
		PokeLevel,
		GroupName,
		Location,
		Area,
		Ribbon,
		UndergroundItemDefArt,
		UndergroundItemIndefArt,
		Taste,
		SerialNumber,
		FreeWord,
		Undefined,
		PlayerNickname,
		PlayerNicknamePrefix,
		TrimmianFormName,
		TrainerTypeAndName,
		HairStyle_Name,
		Bangs_Name,
		HairColor_Name,
		TournamentName,
		FullPowerMove,
		BattleState,
		FlySpotName,
		Record_Name,
		BattleTeam,
		BoxName,
		KisekaeItem,
		KisekaeItemColor,
		BGM,
		Uniformnumber,
		BirthdayM,
		BirthdayD,
		TrainerNameUpperCase,
		PokemonNicknameUpperCase,
		CookName,
		Classname,
		AnotherName,
		CompanyName,
		PlaceIndirect,
		FormName,
		RegurationName,
		Memory_Place,
		Memory_Feeling,
		Memory_Rank,
		Sticker,
		ParkItem,
		Kinomi,
		UgItemAcc,
		UgItemClassified,
		UgItemAccClassified,
		PoffinAcc,
		StyleName,
		BattleRule
	}

	public enum DigitID
	{
		OneDigit,
		TwoDigits,
		ThreeDigits,
		FourDigits,
		FiveDigits,
		SixDigits,
		SevenDigits,
		EightDigits,
		NineDigits,
		TenDigits
	}

	public enum GrmID
	{
		ForceSingular,
		ForcePlural,
		ForceMasculine,
		ForceInitialCap
	}

	public enum ENID
	{
		Gen,
		Qty,
		GenQty,
		DefArt,
		DefArtCap,
		IndArt,
		IndArtCap,
		ForceSingular,
		ForcePlural,
		ForceInitialCap,
		QtyZero
	}

	public enum FRID
	{
		Gen,
		Qty,
		GenQty,
		DefArt,
		DefArtCap,
		IndArt,
		IndArtCap,
		A_DefArt,
		A_DefArtCap,
		De_DefArt,
		De_DefArtCap,
		De,
		DeCap,
		ForceSingular,
		ForcePlural,
		Que,
		QueCap,
		Elision,
		ForceInitialCap,
		QtyZero
	}

	public enum ITID
	{
		Gen,
		Qty,
		GenQty,
		DefArt,
		DefArtCap,
		IndArt,
		IndArtCap,
		Di_DefArt,
		Di_DefArtCap,
		Su_DefArt,
		Su_DefArtCap,
		A_DefArt,
		A_DefArtCap,
		ForceSingular,
		ForcePlural,
		ForceMasculine,
		In_DefArt,
		In_DefArtCap,
		Ed,
		EdCap,
		Ad,
		AdCap,
		ForceInitialCap,
		QtyZero,
		DateIT
	}

	public enum DEID
	{
		Gen,
		Qty,
		GenQty,
		DefArtNom,
		DefArtNomCap,
		IndArtNom,
		IndArtNomCap,
		DefArtAcc,
		DefArtAccCap,
		IndArtAcc,
		IndArtAccCap,
		ForceSingular,
		ForcePlural,
		ForceInitialCap,
		QtyZero,
		ItemAcc,
		ItemAccClassified
	}

	public enum ESID
	{
		Gen,
		Qty,
		GenQty,
		DefArt,
		DefArtCap,
		IndArt,
		IndArtCap,
		De_DefArt,
		De_DefArtCap,
		A_DefArt,
		A_DefArtCap,
		DefArt_TrTypeAndName,
		DefArtCap_TrTypeAndName,
		A_DefArt_TrTypeAndName,
		De_DefArt_TrTypeAndName,
		ForceSingular,
		ForcePlural,
		ForceInitialCap,
		QtyZero,
		y_e,
		Y_E,
		o_u,
		O_U
	}

	public enum KorID
	{
		Particle,
		Gen,
		Qty,
		GenQty,
		QtyZero
	}

	public enum SCID
	{
		Gen
	}

	public enum Character1ID
	{
		heart,
		music,
		male,
		female,
		PokeDollar,
		Left,
		Up,
		Right,
		Down,
		PocketIcon,
		Item,
		KeyItem,
		Machine,
		Seal,
		Medicine,
		Nut,
		Ball,
		Battle,
		Staff,
		LeftDirection,
		UpDirection,
		RightDirection,
		DownDirection,
		Sparkles
	}

	public enum Character2ID
	{
		L_SingleQuot_,
		R_SingleQuot_,
		L_DoubleQuot_,
		R_DoubleQuot_,
		DE_L_DoubleQuot_,
		DE_R_DoubleQuot_,
		StraightSingleQuot_,
		StraightDoubleQuot_,
		HalfSpace,
		QuarterSpace,
		Upper_er,
		Upper_re,
		Upper_r,
		Upper_e,
		Upper_a,
		Abbrev_,
		Center_dot,
		PKMN,
		NULL,
		ModifierLetterCapitalO,
		SixPerEmSpace
	}

	public enum Ctrl1ID
	{
		xright = 3,
		xadd,
		xset,
		battle_oneline,
		unknown_message
	}

	public enum Ctrl2ID
	{
		LineFeed = 0,
		PageClear = 1,
		WaitOne = 2,
		CallBackOne = 5,
		GuidIcon = 10
	}

	public enum DigitTagParamID
	{
		None,
		Default,
		Comma,
		Period,
		HalfSpace,
		QuaterSpace,
		Max
	}

	public enum QtyID
	{
		Singular,
		Plural,
		Zero
	}

	public enum GenderQtyID
	{
		MasculineSingular,
		FeminineSingular,
		MasculinePlural,
		FemininePlural
	}

	public enum DEGenderQtyID
	{
		MasculineSingular,
		FeminineSingular,
		NeuterSingular,
		Plural
	}

	public enum ForceGrmID
	{
		None,
		Singular,
		Plural,
		Masculine,
		InitialCap
	}

	public enum MsgEventID
	{
		None,
		NewLine,
		Wait,
		ScrollPage,
		ScrollLine,
		CallBack,
		GuidIcon,
		End
	}

	public enum WordDataPatternID
	{
		Str,
		FontTag,
		ColorTag,
		SizeTag,
		CtrlTag,
		WordTag,
		SpriteFont,
		Event
	}

	public enum MsgControlID
	{
		None,
		BattleOneline,
		UnknownMessage
	}

	public enum UIFontSizeID
	{
		SSS = 0,
		SS = 1,
		S = 2,
		M = 3,
		L = 4,
		LL = 5,
		LLL = 6,
		XL = 7,
		WazaKouka = 10
	}

	public enum GenderID
	{
		Masculine,
		Feminine,
		Neuter
	}
}
