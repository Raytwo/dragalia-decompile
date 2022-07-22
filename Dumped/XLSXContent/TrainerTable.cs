using System;
using Dpr.Trainer;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TrainerTable : ScriptableObject
{
	[Serializable]
	public class SheetTrainerType
	{
		public TrainerType TrainerID;

		public string LabelTrType;

		public byte Sex;

		public byte Group;

		public BallId BallId;

		public string[] FieldEncount;

		public BattleSetupEffectId[] BtlEffId;

		public string EyeBgm;

		public string ModelID;

		public HandDominance Hand;

		public HandDominance HoldBallHand;

		public HandDominance HelpHand;

		public HandDominance HelpHoldBallHand;

		public float ThrowTime;

		public float CaptureThrowTime;

		public float LoseLoopTime;

		public string TrainerEffect;

		public TrainerAge Age;
	}

	[Serializable]
	public class SheetTrainerData
	{
		public TrainerType TypeID;

		public byte ColorID;

		public byte FightType;

		public ArenaID ArenaID;

		public EffectBattleID EffectID;

		public byte Gold;

		public ushort UseItem1;

		public ushort UseItem2;

		public ushort UseItem3;

		public ushort UseItem4;

		public bool HpRecoverFlag;

		public ushort GiftItem;

		public string NameLabel;

		public string MsgFieldPokeOne;

		public string MsgFieldBefore;

		public string MsgFieldRevenge;

		public string MsgFieldAfter;

		public string[] MsgBattle;

		public string[] SeqBattle;

		public uint AIBit;
	}

	[Serializable]
	public class SheetTrainerPoke
	{
		public TrainerID ID;

		public ushort P1MonsNo;

		public ushort P1FormNo;

		public bool P1IsRare;

		public byte P1Level;

		public Sex P1Sex;

		public byte P1Seikaku;

		public ushort P1Tokusei;

		public ushort P1Waza1;

		public ushort P1Waza2;

		public ushort P1Waza3;

		public ushort P1Waza4;

		public ushort P1Item;

		public BallId P1Ball;

		public SealTemplateID P1Seal;

		public byte P1TalentHp;

		public byte P1TalentAtk;

		public byte P1TalentDef;

		public byte P1TalentSpAtk;

		public byte P1TalentSpDef;

		public byte P1TalentAgi;

		public byte P1EffortHp;

		public byte P1EffortAtk;

		public byte P1EffortDef;

		public byte P1EffortSpAtk;

		public byte P1EffortSpDef;

		public byte P1EffortAgi;

		public ushort P2MonsNo;

		public ushort P2FormNo;

		public bool P2IsRare;

		public byte P2Level;

		public Sex P2Sex;

		public byte P2Seikaku;

		public ushort P2Tokusei;

		public ushort P2Waza1;

		public ushort P2Waza2;

		public ushort P2Waza3;

		public ushort P2Waza4;

		public ushort P2Item;

		public BallId P2Ball;

		public SealTemplateID P2Seal;

		public byte P2TalentHp;

		public byte P2TalentAtk;

		public byte P2TalentDef;

		public byte P2TalentSpAtk;

		public byte P2TalentSpDef;

		public byte P2TalentAgi;

		public byte P2EffortHp;

		public byte P2EffortAtk;

		public byte P2EffortDef;

		public byte P2EffortSpAtk;

		public byte P2EffortSpDef;

		public byte P2EffortAgi;

		public ushort P3MonsNo;

		public ushort P3FormNo;

		public bool P3IsRare;

		public byte P3Level;

		public Sex P3Sex;

		public byte P3Seikaku;

		public ushort P3Tokusei;

		public ushort P3Waza1;

		public ushort P3Waza2;

		public ushort P3Waza3;

		public ushort P3Waza4;

		public ushort P3Item;

		public BallId P3Ball;

		public SealTemplateID P3Seal;

		public byte P3TalentHp;

		public byte P3TalentAtk;

		public byte P3TalentDef;

		public byte P3TalentSpAtk;

		public byte P3TalentSpDef;

		public byte P3TalentAgi;

		public byte P3EffortHp;

		public byte P3EffortAtk;

		public byte P3EffortDef;

		public byte P3EffortSpAtk;

		public byte P3EffortSpDef;

		public byte P3EffortAgi;

		public ushort P4MonsNo;

		public ushort P4FormNo;

		public bool P4IsRare;

		public byte P4Level;

		public Sex P4Sex;

		public byte P4Seikaku;

		public ushort P4Tokusei;

		public ushort P4Waza1;

		public ushort P4Waza2;

		public ushort P4Waza3;

		public ushort P4Waza4;

		public ushort P4Item;

		public BallId P4Ball;

		public SealTemplateID P4Seal;

		public byte P4TalentHp;

		public byte P4TalentAtk;

		public byte P4TalentDef;

		public byte P4TalentSpAtk;

		public byte P4TalentSpDef;

		public byte P4TalentAgi;

		public byte P4EffortHp;

		public byte P4EffortAtk;

		public byte P4EffortDef;

		public byte P4EffortSpAtk;

		public byte P4EffortSpDef;

		public byte P4EffortAgi;

		public ushort P5MonsNo;

		public ushort P5FormNo;

		public bool P5IsRare;

		public byte P5Level;

		public Sex P5Sex;

		public byte P5Seikaku;

		public ushort P5Tokusei;

		public ushort P5Waza1;

		public ushort P5Waza2;

		public ushort P5Waza3;

		public ushort P5Waza4;

		public ushort P5Item;

		public BallId P5Ball;

		public SealTemplateID P5Seal;

		public byte P5TalentHp;

		public byte P5TalentAtk;

		public byte P5TalentDef;

		public byte P5TalentSpAtk;

		public byte P5TalentSpDef;

		public byte P5TalentAgi;

		public byte P5EffortHp;

		public byte P5EffortAtk;

		public byte P5EffortDef;

		public byte P5EffortSpAtk;

		public byte P5EffortSpDef;

		public byte P5EffortAgi;

		public ushort P6MonsNo;

		public ushort P6FormNo;

		public bool P6IsRare;

		public byte P6Level;

		public Sex P6Sex;

		public byte P6Seikaku;

		public ushort P6Tokusei;

		public ushort P6Waza1;

		public ushort P6Waza2;

		public ushort P6Waza3;

		public ushort P6Waza4;

		public ushort P6Item;

		public BallId P6Ball;

		public SealTemplateID P6Seal;

		public byte P6TalentHp;

		public byte P6TalentAtk;

		public byte P6TalentDef;

		public byte P6TalentSpAtk;

		public byte P6TalentSpDef;

		public byte P6TalentAgi;

		public byte P6EffortHp;

		public byte P6EffortAtk;

		public byte P6EffortDef;

		public byte P6EffortSpAtk;

		public byte P6EffortSpDef;

		public byte P6EffortAgi;
	}

	[Serializable]
	public class SheetTrainerRematch
	{
		public TrainerID BaseTrainerID;

		public TrainerID Rematch_01;

		public TrainerID Rematch_02;

		public TrainerID Rematch_03;

		public TrainerID Rematch_04;

		public TrainerID Rematch_05;
	}

	[Serializable]
	public class SheetSealTemplate
	{
		public SealID SealID1;

		public Vector3 Pos1;

		public SealID SealID2;

		public Vector3 Pos2;

		public SealID SealID3;

		public Vector3 Pos3;

		public SealID SealID4;

		public Vector3 Pos4;

		public SealID SealID5;

		public Vector3 Pos5;

		public SealID SealID6;

		public Vector3 Pos6;

		public SealID SealID7;

		public Vector3 Pos7;

		public SealID SealID8;

		public Vector3 Pos8;

		public SealID SealID9;

		public Vector3 Pos9;

		public SealID SealID10;

		public Vector3 Pos10;

		public SealID SealID11;

		public Vector3 Pos11;

		public SealID SealID12;

		public Vector3 Pos12;

		public SealID SealID13;

		public Vector3 Pos13;

		public SealID SealID14;

		public Vector3 Pos14;

		public SealID SealID15;

		public Vector3 Pos15;

		public SealID SealID16;

		public Vector3 Pos16;

		public SealID SealID17;

		public Vector3 Pos17;

		public SealID SealID18;

		public Vector3 Pos18;

		public SealID SealID19;

		public Vector3 Pos19;

		public SealID SealID20;

		public Vector3 Pos20;
	}

	[Serializable]
	public class SheetSkirtGraphicsChara
	{
		public string SkirtGraphicsID;
	}

	public SheetTrainerType[] TrainerType;

	public SheetTrainerData[] TrainerData;

	public SheetTrainerPoke[] TrainerPoke;

	public SheetTrainerRematch[] TrainerRematch;

	public SheetSealTemplate[] SealTemplate;

	public SheetSkirtGraphicsChara[] SkirtGraphicsChara;

	public SheetTrainerType this[int index] => null;
}
