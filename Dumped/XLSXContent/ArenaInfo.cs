using System;
using Dpr.Battle.View;
using Pml;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class ArenaInfo : ScriptableObject
{
	[Serializable]
	public class SheetArenaData
	{
		public string Caption;

		public ArenaID ArenaID;

		public string GroundAssetBundleName;

		public string SkyAssetBundleName;

		public EnvironmentSettings RenderSettings;

		public bool EnableDarkBall;

		public byte MinomuttiFormNo;

		public WazaNo SizennotikaraWazaNo;

		public EffectBattleID FootEffectID;

		public JointName AttachJoint;

		public int ReflectionResolution;

		public int ShadowResolution;

		public bool IsIndoor;
	}

	public SheetArenaData[] ArenaData;

	public SheetArenaData this[int index] => null;
}
