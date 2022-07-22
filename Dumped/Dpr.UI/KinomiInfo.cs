using System.Runtime.CompilerServices;
using Dpr.Item;
using XLSXContent;

namespace Dpr.UI;

public class KinomiInfo
{
	private const float ParameterMaxValue = 50f;

	private const float RaderChartMinValue = 0.1f;

	private const float RaderChartMaxValue = 1f;

	private const string IconAssetNameFormat = "img_berry_{0:000}";

	private const string DescriptionMessageFileName = "dp_berries_info";

	private static readonly string[] HardnessTextLabels;

	private KinomiData.SheetData data;

	public int Id => default(int);

	public int ItemId
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

	public int Index
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

	public string DescriptionText => null;

	public string HardnessTextLabel => null;

	public float GetSize => default(float);

	public KinomiInfo(ItemInfo info)
	{
	}

	public string GetIconAssetName()
	{
		return null;
	}

	public float[] GetRaderChartValues()
	{
		return null;
	}
}
