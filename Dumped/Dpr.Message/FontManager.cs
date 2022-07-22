using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using TMPro;
using UnityEngine;

namespace Dpr.Message;

public class FontManager : SingletonMonoBehaviour<FontManager>
{
	[SerializeField]
	private TextFontData textFontData;

	[SerializeField]
	private FontMaterialData fontMaterialData;

	[SerializeField]
	private TMP_SpriteAsset spriteFontAsset;

	private Dictionary<int, FontAssetInfo> fontInfoTable;

	private Dictionary<int, FontMaterialProperty> materialPropertyTable;

	private Dictionary<int, Material> materialTable;

	private FontAssetLoader fontAssetLoader;

	private int useEFIGSCount;

	public bool IsRunning => default(bool);

	private MessageEnumData.MsgLangId UserLanguageId => default(MessageEnumData.MsgLangId);

	protected override bool Awake()
	{
		return default(bool);
	}

	private void Start()
	{
	}

	private void InitializeMaterialSetting()
	{
	}

	private void Destroy()
	{
	}

	private void DestroyAllFontAsset()
	{
	}

	public void LoadAllFontAsset()
	{
	}

	public void LoadFontAssetByLangId(MessageEnumData.MsgLangId langId)
	{
	}

	private void RegistLoadTask(MessageEnumData.MsgLangId langId)
	{
	}

	public void UnloadFontAssets()
	{
	}

	private void UnloadFontAssetByLanguageId(MessageEnumData.MsgLangId langId)
	{
	}

	public TMP_FontAsset GetFontAsset()
	{
		return null;
	}

	public TMP_FontAsset GetFontAssetByLangId(MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public FontAssetInfo GetFontAssetInfo()
	{
		return null;
	}

	public FontAssetInfo GetFontAssetInfoByLangId(MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public void ClearAllFontAtlas()
	{
	}

	public void ClearFontAtlasByLanugageId(MessageEnumData.MsgLangId langId)
	{
	}

	public void ReloadMaterialTable()
	{
	}

	private void ClearMaterialTable()
	{
	}

	private Material CreateMaterial(Material baseMaterial, FontMaterialProperty fontMaterialProperty)
	{
		return null;
	}

	public void ChangeFontMaterial(TextMeshProUGUI text, int materialIndex = 0)
	{
	}

	private void OnFinishedLoadFontAsset(LoadFontAssetTask loadTask)
	{
	}

	private bool HasFontDataModel(MessageEnumData.MsgLangId langId)
	{
		return default(bool);
	}

	private bool HasFontDataModel(int key)
	{
		return default(bool);
	}

	private int ConvertLangIdToKey(MessageEnumData.MsgLangId langId)
	{
		return default(int);
	}
}
