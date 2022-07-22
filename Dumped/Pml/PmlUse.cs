using System.Runtime.CompilerServices;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Pml;

public class PmlUse
{
	private static PmlUse s_Instance;

	private static readonly string[] AB_PERSONALS;

	public bool isAutoLoad;

	private PersonalTable personalTotal;

	private GrowTable growTableTotal;

	private EvolveTable evolveTableTotal;

	private WazaOboeTable wazaOboeTotal;

	private WazaTable wazaDataTotal;

	private ItemTable itemPrmTotal;

	private TamagoWazaTable tamagoWazaTotal;

	private AddPersonalTable addPersonalTotal;

	private SealTable sealTotal;

	private UgItemTable ugItemPrmTotal;

	private TamaTable tamaTableTotal;

	private PedestalTable pedestalTableTotal;

	private StoneStatuEeffect stoneStatuEeffectTotal;

	private UgFatherPos ugfPosTotal;

	private UgFatherExpansion ugfExpansionTotal;

	private UgFatherShopTable ugfShopTotal;

	private EvolveManager evolveManager;

	private bool isABAppended;

	private bool isInitialized;

	public static PmlUse Instance => null;

	public TamagoWazaTable TamagoWazaTable => null;

	public AddPersonalTable AddPersonalTable => null;

	public SealTable SealTable => null;

	public bool IsInitialized => default(bool);

	public bool IsPersistentTiming
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

	private bool IsLoaded => default(bool);

	public int LangId => default(int);

	public byte CassetVersion => default(byte);

	private bool IsPmlAssetBundleName(string name)
	{
		return default(bool);
	}

	public bool AppendAssetBundleRequests()
	{
		return default(bool);
	}

	public bool OnDispatchRequests(RequestEventType eventType, string name, Object asset)
	{
		return default(bool);
	}

	public void OnAfterLoadAll()
	{
	}

	public EvolveManager GetEvolveManager()
	{
		return null;
	}

	public uint RandFunc()
	{
		return default(uint);
	}

	public uint LimitRandFunc(uint max_range)
	{
		return default(uint);
	}
}
