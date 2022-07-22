using System;
using System.Runtime.CompilerServices;
using Dpr.Trainer;
using UnityEngine;

public class FieldObjectMoveCode
{
	public enum MV_STATE
	{
		Update,
		Encount,
		Stop,
		TrainerStop
	}

	private struct MV_PARAM
	{
		public int seq_no;

		public float wait;

		public int move_check_type;

		public int acmd_code;

		public int tbl_id;

		public int dir;

		public int spin_dir;

		public int tbl_no;

		public bool turn_flag;

		public int turn_no;

		public int turn_check_no;

		public int turn_check_type;

		public int spin_type;

		public int state;

		public int work_id;

		public float krkr_basedir;

		public bool krkr_start;

		public bool object_hit;

		public int object_hit_move_dir;

		public int loopcnt;

		public Vector3 goalPos;

		public bool walkCountStart;

		public float waitTime;

		public float endWait;

		public DIR goalDir;

		public bool isGoalPos;

		public bool isZeroFrameAngle;

		public string parentname;

		public bool _isForceWalkAnime;
	}

	public struct MoveCache
	{
		public int index;

		public Vector3[] Pos;

		public float[] Angle;
	}

	private class FIELD_OBJ_MOVE_PROC_LIST
	{
		public int MoveCode;

		public Action<float> InitProc;

		public Action<float> UpdateProc;

		public Action<float> DeleteProc;

		public Action<float> ReturnProc;

		public FIELD_OBJ_MOVE_PROC_LIST(int movecode, Action<float> init, Action<float> proc, Action<float> del, Action<float> ret)
		{
		}
	}

	private enum DIRID
	{
		DIRID_MvDirRndDirTbl,
		DIRID_MvDirRndDirTbl_UL,
		DIRID_MvDirRndDirTbl_UR,
		DIRID_MvDirRndDirTbl_DL,
		DIRID_MvDirRndDirTbl_DR,
		DIRID_MvDirRndDirTbl_UDL,
		DIRID_MvDirRndDirTbl_UDR,
		DIRID_MvDirRndDirTbl_ULR,
		DIRID_MvDirRndDirTbl_DLR,
		DIRID_MvDirRndDirTbl_UD,
		DIRID_MvDirRndDirTbl_LR,
		DIRID_MV_RND_DirTbl,
		DIRID_MV_RND_V_DirTbl,
		DIRID_MV_RND_H_DirTbl,
		DIRID_MvRtURLD_DirTbl,
		DIRID_MvRtRLDU_DirTbl,
		DIRID_MvRtDURL_DirTbl,
		DIRID_MvRtLDUR_DirTbl,
		DIRID_MvRtULRD_DirTbl,
		DIRID_MvRtLRDU_DirTbl,
		DIRID_MvRtDULR_DirTbl,
		DIRID_MvRtRDUL_DirTbl,
		DIRID_MvRtLUDR_DirTbl,
		DIRID_MvRtUDRL_DirTbl,
		DIRID_MvRtRLUD_DirTbl,
		DIRID_MvRtDRLU_DirTbl,
		DIRID_MvRtRUDL_DirTbl,
		DIRID_MvRtUDLR_DirTbl,
		DIRID_MvRtLRUD_DirTbl,
		DIRID_MvRtDLRU_DirTbl,
		DIRID_MvRtUL_DirTbl,
		DIRID_MvRtDR_DirTbl,
		DIRID_MvRtLD_DirTbl,
		DIRID_MvRtRU_DirTbl,
		DIRID_MvRtUR_DirTbl,
		DIRID_MvRtDL_DirTbl,
		DIRID_MvRtLU_DirTbl,
		DIRID_MvRtRD_DirTbl,
		DIRID_MvDirSpin_DirTbl,
		DIRID_END,
		DIRID_MAX
	}

	private struct SUBWORK
	{
		public int check_seq_no;

		public int move_seq_no;

		public int walk_count;

		public int max_count;

		public int origin_dir;

		public int dir_type;

		public int dir_no;

		public int dir_count;

		public int wait;
	}

	private struct HitData
	{
		public int seqNo;

		public int dir;

		public Vector2 endpos;
	}

	private FieldPokemonEntity pokeEntity;

	private FieldCharacterEntity charaEntity;

	public int EntityType;

	private Vector3 playerPosition;

	private Vector2Int playerGridPosition;

	private bool isPlayerRun;

	public const int EV_TYPE_NORMAL = 0;

	public const int EV_TYPE_TRAINER = 1;

	public const int EV_TYPE_TRAINER_EYEALL = 2;

	public const int EV_TYPE_ITEM = 3;

	public const int EV_TYPE_TRAINER_KYORO = 4;

	public const int EV_TYPE_TRAINER_SPIN_STOP_L = 5;

	public const int EV_TYPE_TRAINER_SPIN_STOP_R = 6;

	public const int EV_TYPE_TRAINER_SPIN_MOVE_L = 7;

	public const int EV_TYPE_TRAINER_SPIN_MOVE_R = 8;

	public const int EV_TYPE_MSG = 9;

	public int BaseMoveCode;

	public int MoveCode;

	public DIR MoveDirHead;

	public int MoveParam0;

	public int MoveParam1;

	public int MoveParam2;

	public int MoveLimitX;

	public int MoveLimitZ;

	public int Ev_Type;

	public int mv_old_dir;

	public int mv_dir;

	private float _mv_targetYawAngle;

	private float _mv_oldYawAngle;

	private float _mv_YawAngleTime;

	private bool _mv_isMoveStart;

	private Vector3 _mv_StartPos;

	private Vector3 _mv_EndPos;

	private float _mv_Time;

	private float _mv_TimeRate;

	public Vector3Int _mv_defaultPosition;

	private float _mv_WaitWalkTime;

	public MV_STATE MvState;

	public TrainerID TrainerID;

	public bool Param_from_LoadData;

	private MV_PARAM _mvParam;

	private const int FLDOBJ_STA_BIT_NON = 0;

	private const int FLDOBJ_STA_BIT_USE = 1;

	private const int FLDOBJ_STA_BIT_MOVE = 2;

	private const int FLDOBJ_STA_BIT_MOVE_START = 4;

	private const int FLDOBJ_STA_BIT_MOVE_END = 8;

	private int _objectStatus;

	private bool _isSubProc;

	private const int MOVE_LIMIT_NOT = -1;

	private Vector3 _stopPos;

	private const int MAX_MOVE_CACHE = 10;

	public MoveCache moveCache;

	private bool _isEyeHitStop;

	private bool _isMissing;

	private Vector2 _movelimit_Min;

	private Vector2 _movelimit_Max;

	public const int MV_DMY = 0;

	public const int MV_PLAYER = 1;

	public const int MV_DIR_RND = 2;

	public const int MV_RND = 3;

	public const int MV_RND_V = 4;

	public const int MV_RND_H = 5;

	public const int MV_RND_UL = 6;

	public const int MV_RND_UR = 7;

	public const int MV_RND_DL = 8;

	public const int MV_RND_DR = 9;

	public const int MV_RND_UDL = 10;

	public const int MV_RND_UDR = 11;

	public const int MV_RND_ULR = 12;

	public const int MV_RND_DLR = 13;

	public const int MV_UP = 14;

	public const int MV_DOWN = 15;

	public const int MV_LEFT = 16;

	public const int MV_RIGHT = 17;

	public const int MV_SPIN_L = 18;

	public const int MV_SPIN_R = 19;

	public const int MV_RT2 = 20;

	public const int MV_RTURLD = 21;

	public const int MV_RTRLDU = 22;

	public const int MV_RTDURL = 23;

	public const int MV_RTLDUR = 24;

	public const int MV_RTULRD = 25;

	public const int MV_RTLRDU = 26;

	public const int MV_RTDULR = 27;

	public const int MV_RTRDUL = 28;

	public const int MV_RTLUDR = 29;

	public const int MV_RTUDRL = 30;

	public const int MV_RTRLUD = 31;

	public const int MV_RTDRLU = 32;

	public const int MV_RTRUDL = 33;

	public const int MV_RTUDLR = 34;

	public const int MV_RTLRUD = 35;

	public const int MV_RTDLRU = 36;

	public const int MV_RTUL = 37;

	public const int MV_RTDR = 38;

	public const int MV_RTLD = 39;

	public const int MV_RTRU = 40;

	public const int MV_RTUR = 41;

	public const int MV_RTDL = 42;

	public const int MV_RTLU = 43;

	public const int MV_RTRD = 44;

	public const int MV_RND_UD = 45;

	public const int MV_RND_LR = 46;

	public const int MV_SEED = 47;

	public const int MV_PAIR = 48;

	public const int MV_REWAR = 49;

	public const int MV_TR_PAIR = 50;

	public const int MV_HIDE_SNOW = 51;

	public const int MV_HIDE_SAND = 52;

	public const int MV_HIDE_GRND = 53;

	public const int MV_HIDE_KUSA = 54;

	public const int MV_CODE_MAX = 55;

	public const int MV_CODE_NOT = 255;

	public const int MV_RND_MOVE_CHECK_NORMAL = 0;

	public const int MV_RND_MOVE_CHECK_RECT = 1;

	public const int RT_KURU2_L = 0;

	public const int RT_KURU2_R = 1;

	public const int RT_KURU2_MAX = 2;

	public const int FLDOBJ_MOVE_HIT_BIT_NON = 0;

	public const int FLDOBJ_MOVE_HIT_BIT_LIM = 1;

	public const int FLDOBJ_MOVE_HIT_BIT_ATTR = 2;

	public const int FLDOBJ_MOVE_HIT_BIT_OBJ = 4;

	public const int FLDOBJ_MOVE_HIT_BIT_HEIGHT = 8;

	public const int SEQNO_MV_RT3_MOVE_DIR_SET = 0;

	public const int SEQNO_MV_RT3_MOVE = 1;

	public const int MV_RT3_TURN_END_NO = 3;

	public const int MV_RT3_CHECK_TYPE_X = 0;

	public const int MV_RT3_CHECK_TYPE_Z = 1;

	private FIELD_OBJ_MOVE_PROC_LIST _moveProc;

	private static readonly int[] DATA_MvDirRndWaitTbl_Taiki;

	private static readonly int[] DATA_MvDirRndWaitTbl_Move;

	private static readonly int[] DATA_MvDirRndDirTbl;

	private static readonly int[] DATA_MvDirRndDirTbl_UL;

	private static readonly int[] DATA_MvDirRndDirTbl_UR;

	private static readonly int[] DATA_MvDirRndDirTbl_DL;

	private static readonly int[] DATA_MvDirRndDirTbl_DR;

	private static readonly int[] DATA_MvDirRndDirTbl_UDL;

	private static readonly int[] DATA_MvDirRndDirTbl_UDR;

	private static readonly int[] DATA_MvDirRndDirTbl_ULR;

	private static readonly int[] DATA_MvDirRndDirTbl_DLR;

	private static readonly int[] DATA_MvDirRndDirTbl_UD;

	private static readonly int[] DATA_MvDirRndDirTbl_LR;

	private static readonly int[] DATA_MV_RND_DirTbl;

	private static readonly int[] DATA_MV_RND_V_DirTbl;

	private static readonly int[] DATA_MV_RND_H_DirTbl;

	private static readonly int[] DATA_MvRtURLD_DirTbl;

	private static readonly int[] DATA_MvRtRLDU_DirTbl;

	private static readonly int[] DATA_MvRtDURL_DirTbl;

	private static readonly int[] DATA_MvRtLDUR_DirTbl;

	private static readonly int[] DATA_MvRtULRD_DirTbl;

	private static readonly int[] DATA_MvRtLRDU_DirTbl;

	private static readonly int[] DATA_MvRtDULR_DirTbl;

	private static readonly int[] DATA_MvRtRDUL_DirTbl;

	private static readonly int[] DATA_MvRtLUDR_DirTbl;

	private static readonly int[] DATA_MvRtUDRL_DirTbl;

	private static readonly int[] DATA_MvRtRLUD_DirTbl;

	private static readonly int[] DATA_MvRtDRLU_DirTbl;

	private static readonly int[] DATA_MvRtRUDL_DirTbl;

	private static readonly int[] DATA_MvRtUDLR_DirTbl;

	private static readonly int[] DATA_MvRtLRUD_DirTbl;

	private static readonly int[] DATA_MvRtDLRU_DirTbl;

	private static readonly int[] DATA_MvRtUL_DirTbl;

	private static readonly int[] DATA_MvRtDR_DirTbl;

	private static readonly int[] DATA_MvRtLD_DirTbl;

	private static readonly int[] DATA_MvRtRU_DirTbl;

	private static readonly int[] DATA_MvRtUR_DirTbl;

	private static readonly int[] DATA_MvRtDL_DirTbl;

	private static readonly int[] DATA_MvRtLU_DirTbl;

	private static readonly int[] DATA_MvRtRD_DirTbl;

	private static readonly int[] DATA_MvDirSpin_DirTbl;

	private static readonly int[] DATA_MvDirKurukuru;

	private static readonly int[] enable_code;

	private SUBWORK _subWork;

	private const int DIR_H_TYPE = 0;

	private const int DIR_V_TYPE = 1;

	private const int KYORO_WAIT_FRAME = 16;

	private const int KYORO_COUNT_MAX = 4;

	private const int SPIN_STOP_L_TYPE = 0;

	private const int SPIN_STOP_R_TYPE = 1;

	private const int SPIN_STOP_WAIT_FRAME = 16;

	private const int SPIN_STOP_COUNT_MAX = 4;

	private const int DIR_4_MAX = 4;

	public Action<FieldObjectMoveCode> OnEyeAction;

	private HitData _hitData;

	public FieldObjectEntity Entity
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int PlayerGridDistance
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsPlayerHeight
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsForceEyeHit
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 MvParamGoalPos => default(Vector3);

	public void SetEntity(FieldObjectEntity entity)
	{
	}

	public bool IsMissing()
	{
		return default(bool);
	}

	public bool IsNoneStart()
	{
		return default(bool);
	}

	public void MVCodeStart()
	{
	}

	public void MVCodeStop()
	{
	}

	public void MVCodeRestart()
	{
	}

	public void MVCodeChange(int code)
	{
	}

	public void MVCodeEncount()
	{
	}

	public void MVCodeTrainerStop()
	{
	}

	private FIELD_OBJ_MOVE_PROC_LIST GetMoveProc(int movecode)
	{
		return null;
	}

	private void FieldOBJ_MoveInitProcDummy(float time)
	{
	}

	private void FieldOBJ_MoveProcDummy(float time)
	{
	}

	private void FieldOBJ_MoveDeleteProcDummy(float time)
	{
	}

	private void FieldOBJ_MoveReturnProcDummy(float time)
	{
	}

	private void FieldOBJ_MoveDirRnd_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndUL_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndUR_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndDL_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndDR_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndUDL_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndUDR_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndULR_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndDLR_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndUD_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRndLR_Init(float time)
	{
	}

	private void FieldOBJ_MoveDirRnd_Move(float time)
	{
	}

	private void FieldOBJ_MoveDirRnd_Delete(float time)
	{
	}

	private void FieldOBJ_MoveRnd_Init(float time)
	{
	}

	private void FieldOBJ_MoveRndV_Init(float time)
	{
	}

	private void FieldOBJ_MoveRndH_Init(float time)
	{
	}

	private void FieldOBJ_MvRnd_Move(float time)
	{
	}

	private void FieldOBJ_MoveUp_Init(float time)
	{
	}

	private void FieldOBJ_MoveDown_Init(float time)
	{
	}

	private void FieldOBJ_MoveLeft_Init(float time)
	{
	}

	private void FieldOBJ_MoveRight_Init(float time)
	{
	}

	private void FieldOBJ_MoveDir_Move(float time)
	{
	}

	private void FieldOBJ_MoveSpinLeft_Init(float time)
	{
	}

	private void FieldOBJ_MoveSpinRight_Init(float time)
	{
	}

	private void CheckSpinDir()
	{
	}

	private void FieldOBJ_MoveSpin_Move(float time)
	{
	}

	private void FieldOBJ_MoveRewar_Init(float time)
	{
	}

	private void FieldOBJ_MoveRewar_Move(float time)
	{
	}

	private void FieldOBJ_MoveRoute2_Init(float time)
	{
	}

	private void FieldOBJ_MoveRoute2_Move(float time)
	{
	}

	private void FieldOBJ_MoveRouteURLD_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteRLDU_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteDURL_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteLDUR_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteULRD_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteLRDU_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteDULR_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteRDUL_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteLUDR_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteUDRL_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteRLUD_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteDRLU_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteRUDL_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteUDLR_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteLRUD_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteDLRU_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteUL_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteDR_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteLD_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteRU_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteUR_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteDL_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteLU_Init(float time)
	{
	}

	private void FieldOBJ_MoveRouteRD_Init(float time)
	{
	}

	private void FieldOBJ_MoveRoute3_Move(float time)
	{
	}

	private void SetGoalPos()
	{
	}

	private void FieldOBJ_MoveSeed_Init(float time)
	{
	}

	private void FieldOBJ_MoveSeed_Move(float time)
	{
	}

	private void FieldOBJ_MoveSeed_Delete(float time)
	{
	}

	private void FieldOBJ_MovePair_Init(float time)
	{
	}

	private void FieldOBJ_MovePair_Move(float time)
	{
	}

	private void FieldOBJ_MovePair_Delete(float time)
	{
	}

	private void FieldOBJ_MovePairTr_Init(float time)
	{
	}

	private void FieldOBJ_MovePairTr_Move(float time)
	{
	}

	private void FieldOBJ_MovePairTr_Delete(float time)
	{
	}

	private void FieldOBJ_MovePairTr_Return(float time)
	{
	}

	private void FieldOBJ_MoveHideSnow_Init(float time)
	{
	}

	private void FieldOBJ_MoveHide_Move(float time)
	{
	}

	private void FieldOBJ_MoveHide_Delete(float time)
	{
	}

	private void FieldOBJ_MoveHide_Return(float time)
	{
	}

	private void FieldOBJ_MoveHideSand_Init(float time)
	{
	}

	private void FieldOBJ_MoveHideGround_Init(float time)
	{
	}

	private void FieldOBJ_MoveHideKusa_Init(float time)
	{
	}

	private void DirRndWorkInit(int id)
	{
	}

	private int TblRndGet(int[] list)
	{
		return default(int);
	}

	private int TblIDRndGet(int id)
	{
		return default(int);
	}

	private void MvRndWorkInit(int ac, int tbl_id, int check)
	{
	}

	private void FieldOBJ_DirDispCheckSet(int dir)
	{
	}

	private int FieldOBJ_DirMoveGet()
	{
		return default(int);
	}

	private void FieldOBJ_DirMoveSet(int dir)
	{
	}

	private bool MvRndRectMoveLimitCheck(Vector3 pos)
	{
		return default(bool);
	}

	private bool IsInside(Vector3 vA, Rect rect, Vector3 size)
	{
		return default(bool);
	}

	private void MvDirWorkInit(int dir)
	{
	}

	private void MvSpinDirWorkInit(int dir)
	{
	}

	private int FieldOBJTool_DirFlip(int dir)
	{
		return default(int);
	}

	private int FieldOBJ_GoalPosCheck()
	{
		return default(int);
	}

	private bool FieldOBJ_MoveHitCheckLimit(float x, float z)
	{
		return default(bool);
	}

	private bool FieldOBJ_GoalPosHitCheckFellow()
	{
		return default(bool);
	}

	private bool FieldOBJ_MoveHitCheckAttr(float x, float z, int dir)
	{
		return default(bool);
	}

	private bool MoveSub_KuruKuruCheck()
	{
		return default(bool);
	}

	private void MoveSub_KuruKuruInit()
	{
	}

	private void MoveSub_KuruKuruSet()
	{
	}

	private void MoveSub_KuruKuruEnd()
	{
	}

	private void MvRt3WorkInit(int check_no, int check_type, int tbl_id)
	{
	}

	private int TrJikiDashSearch()
	{
		return default(int);
	}

	private int TrJikiDashSearchTbl(int id)
	{
		return default(int);
	}

	private int FieldOBJTool_DirRange(int ax, int az, int bx, int bz)
	{
		return default(int);
	}

	private int[] MoveDirTblIDSearch(int id)
	{
		return null;
	}

	private int[] DATA_MoveDirTbl(DIRID id)
	{
		return null;
	}

	private bool FieldOBJ_StatusBitCheck_Use()
	{
		return default(bool);
	}

	private void FieldOBJ_StatusBitON_Move()
	{
	}

	private void FieldOBJ_StatusBitOFF_Move()
	{
	}

	private bool FieldOBJ_StatusBitCheck_Move()
	{
		return default(bool);
	}

	private void FieldOBJ_StatusBit_ON(int bit)
	{
	}

	private void FieldOBJ_StatusBit_OFF(int bit)
	{
	}

	private bool FieldOBJ_StatusBit_CheckEasy(int bit)
	{
		return default(bool);
	}

	private bool IsSubProcActive()
	{
		return default(bool);
	}

	private void DATA_FldOBJ_EventTypeInitProcTbl()
	{
	}

	private bool DATA_FldOBJ_EventTypeStartCheckProcTbl()
	{
		return default(bool);
	}

	private bool DATA_FldOBJ_EventTypeMoveProcTbl()
	{
		return default(bool);
	}

	private bool FieldOBJ_MoveSub()
	{
		return default(bool);
	}

	private bool SubStart()
	{
		return default(bool);
	}

	private bool SubUpdate()
	{
		return default(bool);
	}

	private void SubMoveNon_Init()
	{
	}

	private bool SubMoveNon_StartCheck()
	{
		return default(bool);
	}

	private bool SubMoveNon_Move()
	{
		return default(bool);
	}

	private void SubMoveKyoro_Init()
	{
	}

	private bool SubMoveKyoro_StartCheck()
	{
		return default(bool);
	}

	private bool SubMoveKyoro_Move()
	{
		return default(bool);
	}

	private void SubMoveSpinStop_Init()
	{
	}

	private bool SubMoveSpinStop_StartCheck()
	{
		return default(bool);
	}

	private bool SubMoveSpinStop_Move()
	{
		return default(bool);
	}

	private int FieldOBJ_DirDispGet()
	{
		return default(int);
	}

	private bool MoveSub_PosUpdateStartCheck()
	{
		return default(bool);
	}

	private bool MoveSub_PosUpdateEndCheck()
	{
		return default(bool);
	}

	public void MoveCodeUpdate(float time, ref Vector3 pWorld, ref Vector2Int pGrid, bool isrun)
	{
	}

	private bool UpdateAngle(float dir, float anglespd, bool zeroframe = false)
	{
		return default(bool);
	}

	private void SetWait(int frame)
	{
	}

	private bool IsWaitEnd()
	{
		return default(bool);
	}

	private int GetDirAngle(DIR dir)
	{
		return default(int);
	}

	private void SetGoalPos(DIR dir)
	{
	}

	private bool IsNowDefaultPosX()
	{
		return default(bool);
	}

	private bool IsNowDefaultPosZ()
	{
		return default(bool);
	}

	private bool IsNowDefaultPosXZ()
	{
		return default(bool);
	}

	private void MoveCodeUpdateAfter(bool move, float time)
	{
	}

	private void AnimeStop()
	{
	}

	public void MoveCodeLateUpdate(float deltatime)
	{
	}

	public bool TrainerEyeUpdate(ref Vector3 moveVector, ref Vector2 hitpos)
	{
		return default(bool);
	}

	private bool IsEyeHit(int dir, ref Vector3 moveVector, out int hitdir, ref Vector2 hitpos)
	{
		return default(bool);
	}

	private bool IsHit(float x, float y, float w, float h, Vector2Int point)
	{
		return default(bool);
	}

	private int EyeObjectCheck(int dir, int length)
	{
		return default(int);
	}

	public bool PlayerApproach(float time)
	{
		return default(bool);
	}

	public bool IsTrainer()
	{
		return default(bool);
	}

	public int EyeType()
	{
		return default(int);
	}

	public void SetPlayerDistance(int gx, int gz, float h)
	{
	}

	private void SetMVCodeLimit()
	{
	}
}
