using System.Collections;
using Effect;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Demo;

public class Demo_Hakase : DemoBase
{
	private const string HAKASE_ASSET_PATH = "persons/battle/tr2003_01";

	private const string RIVAL_ASSET_PATH = "persons/battle/tr0002_00";

	private const string GONBE_ASSET_PATH = "pm0446_00_00_gonbe";

	private Object Rival3DModel;

	private static readonly string[] RIVAL_NAMES_D;

	private static readonly string[] RIVAL_NAMES_P;

	private RuntimeAnimatorController animController;

	public OpeningController openingController;

	private BattleCharacterEntity hakaseEntity;

	private EffectInstance bgEffect;

	private EffectData bgEffectData;

	private bool isSkip;

	public override AssetRequestOperation PreloadAssetBundles()
	{
		return null;
	}

	public override void ReleasePreloadedAssetBundles()
	{
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	public override IEnumerator Main()
	{
		return null;
	}

	private IEnumerator PlayerSelect(GameObject gonbe, Image bgImage)
	{
		return null;
	}

	private IEnumerator RivalSelect()
	{
		return null;
	}

	public override void LightUpdate()
	{
	}

	public override IEnumerator Exit()
	{
		return null;
	}
}
