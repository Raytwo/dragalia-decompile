namespace Dpr.GMS;

public class GMSPointDataContainer
{
	private GMSPointDataModel[] pointDataModelArray;

	private int[] refDataIndexArray;

	private int hasDataNum;

	public GMSPointDataModel[] PointDatas => null;

	public int[] RefDataIndexArray => null;

	public int DataNum => default(int);

	public int HasDataNum => default(int);

	public void SetPointDatas(GMSPointDataModel[] pointDataModelArray)
	{
	}

	public void RemapRefDataIndex()
	{
	}
}
