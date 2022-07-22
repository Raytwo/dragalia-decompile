using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using DPData;
using Dpr.Battle.View.Objects;
using Dpr.Battle.View.Systems;
using Dpr.Contest;
using Effect;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class UIContestPhoto : UIWindow
{
	private const string CNT_PHOTO_FRAME_PATH = "contestphoto/cnt_photo_frame_";

	private const int INIT_CAPACITY = 64;

	private readonly string GRAPHIC_TEXT_NAME;

	[SerializeField]
	private EnvironmentController _envController;

	[SerializeField]
	private BOCamera _boCamera;

	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private Image photoTitleImage;

	private CON_PHOTO_DATA _photoData;

	private CON_PHOTO_EXT_DATA _extData;

	private List<EffectData> _effectDataList;

	private ContestMasterDatas.SheetContestData useContestData;

	private ContestMasterDatas.SheetRankData useRankData;

	private StageEffect _stageFx;

	private BattleSequenceSystem _iPtrSequenceSystem;

	private EnvironmentSettings _currentRenderSettings;

	private ContestSettings _settingData;

	private BattlePokemonEntity _pokeEntity;

	private GameObject migawariObj;

	private GameObject _stageModel;

	private StringBuilder _pathBuilder;

	private Coroutine colSetupMotion;

	private UIText messageTxt;

	private Image photoFrameImage;

	private Sprite loadSprite;

	private Sprite titleSprite;

	private Vector3 _offsetPos;

	private CategoryID _selectCategoryID;

	private string wazaSeqPath;

	private int _loadFxCount;

	private bool _bLoadAssetBundle;

	private string _photoFrameSprPath;

	private string _photoTargetModelPath;

	private string _stageModelPath;

	private bool LoadingFx => default(bool);

	private bool IsMigawari => default(bool);

	public override void OnCreate()
	{
	}

	public void Open(int categoryID, CON_PHOTO_DATA photoData, CON_PHOTO_EXT_DATA extData)
	{
	}

	private IEnumerator OpOpen()
	{
		return null;
	}

	private void AppendContestMasterData()
	{
	}

	private void AppendContestSettings()
	{
	}

	private void AppendPhotoFrameSprite()
	{
	}

	private void AppendLoadSpriteTask(string path, Action<Sprite> onCompleteLoad, [Optional] string[] variants)
	{
	}

	private void AppendStageResource()
	{
	}

	private void AppendPokemonResource()
	{
	}

	private void AppendLoadMigawariModel()
	{
	}

	private void RequestLoadAssetBundle()
	{
	}

	private IEnumerator OpLoadSequence()
	{
		return null;
	}

	private void LoadStageFx()
	{
	}

	private EffectContestID[] CreateMonitorIDs()
	{
		return null;
	}

	private void LoadWazaFx()
	{
	}

	private void CreateEffectByFilePath(CON_PHOTO_FX_DATA fxData, EffectDatabase.SheetBattleEffectData fxParam)
	{
	}

	private string CreatePhotoFrameSprPath()
	{
		return null;
	}

	private string CreatePokeModelPathByCatalog(XLSXContent.PokemonInfo.SheetCatalog catalog)
	{
		return null;
	}

	private void Setup()
	{
	}

	private void SetupUI()
	{
	}

	private void SetupLight()
	{
	}

	private void ActivateCamera()
	{
	}

	private void SetupFx()
	{
	}

	private IEnumerator OpSetupMotion()
	{
		return null;
	}

	private void SetPhotoMessage()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnLateUpdate(float deltaTime)
	{
	}

	private void UpdateInput()
	{
	}

	private void CloseWindow()
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}

	private void Release()
	{
	}

	private void ReleaseCamera()
	{
	}

	private void UnloadResource()
	{
	}
}
