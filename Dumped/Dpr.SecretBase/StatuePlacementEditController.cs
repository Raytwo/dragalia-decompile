using System.Collections;
using System.Collections.Generic;
using Dpr.Message;
using Dpr.UI;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.SecretBase;

public class StatuePlacementEditController : MonoBehaviour
{
	public delegate void OnExit();

	public enum State
	{
		StatueWindow,
		SelectFromStatueWindow,
		Field,
		ConfirmReset,
		SelectFromField,
		WaitStatueWindow,
		Placement,
		PedestalWindow,
		FillterWindow,
		None,
		ViewMode
	}

	public const string PedestalListAssetBundleName = "pedestallist";

	[SerializeField]
	private StatueSelectWindow statueSelectWindow;

	[SerializeField]
	private FieldCursor impossible;

	[SerializeField]
	private int statueMax;

	[SerializeField]
	private UIText statueNumLabel;

	[SerializeField]
	private UIText statueNum;

	public static GameObject[] PedestalModels;

	private Coroutine statueItemCoroutine;

	[SerializeField]
	private Pedestal pedestals;

	public static Dictionary<int, int> statueItemNum;

	public static Dictionary<int, int> pedestalsNum;

	[SerializeField]
	private PedestalWindow pedestalWindow;

	[SerializeField]
	private RawImage fieldView;

	[SerializeField]
	private StatuePlacementFilterWindow fillterWindow;

	private MessageMsgFile msgFile;

	[SerializeField]
	private Color[] pokeTypeColor;

	[SerializeField]
	private SecretBaseMasterDataManager masterData;

	[SerializeField]
	private SecretBaseCamera secretBaseCamera;

	[SerializeField]
	private StatuePlacementManger placementManager;

	[SerializeField]
	private Transform keyGuideRoot;

	[SerializeField]
	private StatueModelLoader statueModelLoader;

	[SerializeField]
	private SecretBaseAudioManager audioManager;

	[SerializeField]
	private GameObject statueNumView;

	public OnExit onExitCallback;

	private StateMachine<State, StatuePlacementEditController> stateMachine;

	private StateStatueWindow stateStatueWindow;

	private StateSelectFromStatueWindow stateSelectFromStatueWindow;

	private StateField stateField;

	private StateConfirmReset stateConfirmReset;

	private StateSelectFromField stateSelectFromField;

	private StateWaitStatueWindow stateWaitStatueWindow;

	private StatePlacement statePlacement;

	private StatePedestalWindow statePedestalWindow;

	private StateFillterWindow stateFillterWindow;

	private StateNone stateNone;

	private StateViewMode stateViewMode;

	public StatueSelectWindow StatueSelectWindow => null;

	public int StatueMax => default(int);

	public PedestalWindow PedestalWindow => null;

	public StatuePlacementFilterWindow FillterWindow => null;

	public MessageMsgFile MsgFile => null;

	public SecretBaseAudioManager AudioManager => null;

	public StatuePlacementManger PlacementManager => null;

	public StatueModelLoader StatueModelLoader => null;

	private void OnDestroy()
	{
	}

	public IEnumerator Load()
	{
		return null;
	}

	public bool IsLoadCompleted()
	{
		return default(bool);
	}

	public void OnUpdate()
	{
	}

	public IEnumerator ApplyRoom(AssetRequestOperation pedestalLoadOperation)
	{
		return null;
	}

	public bool OpenEnable()
	{
		return default(bool);
	}

	public void Show()
	{
	}

	public void Close()
	{
	}

	private void StatueAndPedestalSetup()
	{
	}

	public IEnumerator StatueItemOperation(List<StatueEffectData> effectDatas)
	{
		return null;
	}

	public IEnumerator Initialize()
	{
		return null;
	}

	private void OpenKeyguide()
	{
	}

	public bool IsStatueMax()
	{
		return default(bool);
	}

	public bool IsStatueZero()
	{
		return default(bool);
	}

	public void AddStatue(PlacementData info)
	{
	}

	public PlacementData GetPlacementData(RectInt rect)
	{
		return null;
	}

	public int GetPlacementNum(RectInt rect)
	{
		return default(int);
	}

	public void RemoveStatue(PlacementData remove)
	{
	}

	public void RemoveStatuesAll()
	{
	}

	public void OperationTopView(int mask)
	{
	}

	public void ResetLookAt()
	{
	}

	public void TargetLookAt(PlacementData target)
	{
	}

	private void SetDisplayStatueCursor(bool isActive)
	{
	}

	public void OperationTopView(int mask, PlacementData target)
	{
	}

	private void IconListUpdate()
	{
	}

	private void UpdatePlacementNum()
	{
	}

	public void Enter_StatueWindow()
	{
	}

	public void Enter_SelectFromStatueWindow(PlacementData statue)
	{
	}

	public void Enter_Field()
	{
	}

	public void Enter_ConfirmReset()
	{
	}

	public void Enter_SelectFromField()
	{
	}

	public void Enter_WaitStatueWindow(PlacementData statue)
	{
	}

	public void Enter_Placement(PlacementData statue, bool isField)
	{
	}

	public void Enter_PedestalWindow(PlacementData placement)
	{
	}

	public void ChangePrevState()
	{
	}

	public void Enter_FillterWindow()
	{
	}

	public void Exit_StatuePlacementEdit()
	{
	}

	private void AddStatueWindowItem(StatueEffectData data)
	{
	}
}
