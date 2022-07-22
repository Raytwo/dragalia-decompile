using System.Runtime.CompilerServices;
using XLSXContent;

namespace Dpr.UI;

public class SealInfo
{
	private const string InfoMessageFileName = "dp_stickers_info";

	private SealTable.SheetSealData sealData;

	public int SealId
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

	public int CategoryId => default(int);

	public int SortNumber => default(int);

	public string IconAssetName => null;

	public static string GetIconAssetName(int sealId)
	{
		return null;
	}

	public static SealTable.SheetSealData GetData(int sealId)
	{
		return null;
	}

	public SealInfo(int id)
	{
	}

	public int GetCount()
	{
		return default(int);
	}

	public string GetInfoText()
	{
		return null;
	}
}
