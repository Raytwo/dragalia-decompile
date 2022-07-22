using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dpr.Trainer;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.Field.Walking;

public class FieldWalkingManager : WalkingAIManager
{
	public enum TalkState
	{
		None,
		Talking,
		TalkEnd,
		DontTalk
	}

	public static bool DebugMode;

	public static TalkState talkState;

	public AreaID prevArea;

	public string PartnerNPC_ObjectName;

	public static Dictionary<int, string> PartnerNPC_Dic;

	public static Dictionary<string, string> PartnerNameToLabel;

	private Dictionary<int, Object> PokeAssets;

	private WalkingCharacterController Controller;

	public FieldPokeTalkModel pokeTalkModel;

	private bool isCancel;

	private bool isForceEnter;

	private List<FieldWalkingPokeTalk.SheetSheet1> talkList;

	private FieldWalkingKinomiTable kinomiTable;

	private List<FieldWalkingKinomiSeikakuTable.SheetSheet1> seikakuTable;

	public bool isEvent;

	public Tweener ChangePos;

	public bool isLoaded => default(bool);

	public PokemonParam PartnerPokeParam
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

	public Vector3 EntryPoint
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public WalkingCharacterController GetPartnerPokeController()
	{
		return null;
	}

	public bool IsCanTalk()
	{
		return default(bool);
	}

	public void NPCToPartner()
	{
	}

	public IEnumerator LoadMD()
	{
		return null;
	}

	public void SetPartnerNpcName(string npcName)
	{
	}

	public bool SetPartnerNpcName(TrainerID id)
	{
		return default(bool);
	}

	public void SetPartnerNameToLabel(int index)
	{
	}

	public void TurearukiWarp()
	{
	}

	public void SetPartnerPoke(PokemonParam poke)
	{
	}

	public void UpdatePartnerPokeIndex()
	{
	}

	private int GetTurearukiIndex()
	{
		return default(int);
	}

	public void LoadPartnerPoke()
	{
	}

	public void SetEntryPoint(Vector3 pos)
	{
	}

	public void CreateTurearuki()
	{
	}

	public void DeleteTurearuki()
	{
	}

	public IEnumerator CreatePartner(bool isQuiet = false, bool isFormChange = false)
	{
		return null;
	}

	public override void Destroy(bool isDestroyGameObject = false)
	{
	}

	public void CheckPartnerPokeChange(PokemonParam param, bool isDelete)
	{
	}

	public void PokeUpdate(float deltaTime)
	{
	}

	public void ChangePositionNPC()
	{
	}

	public bool IsCanTurearuki(PokemonParam param)
	{
		return default(bool);
	}

	public bool IsCanTurearukiState()
	{
		return default(bool);
	}

	public bool IsCanTurearukiMap()
	{
		return default(bool);
	}

	public bool IsCanTurearukiPoke(PokemonParam param)
	{
		return default(bool);
	}

	public void Turearuki_Talk()
	{
	}

	public static void ResetMonohiroiTime()
	{
	}
}
