using System;

namespace Nintendo.MessageStudio.Lib;

public class BinPrjFile : BinLibmsFileBase
{
	protected override IntPtr InitObject(IntPtr resourcePtr)
	{
		return default(IntPtr);
	}

	protected override void CloseObject(IntPtr objectPtr)
	{
	}

	public int SearchProjectBlock(string name)
	{
		return default(int);
	}

	public int GetColorIndex(string name)
	{
		return default(int);
	}

	public LMSColor GetColor(int index)
	{
		return default(LMSColor);
	}

	public LMSColor GetColor(string name)
	{
		return default(LMSColor);
	}

	public int GetColorNum()
	{
		return default(int);
	}

	public int GetContentsNum()
	{
		return default(int);
	}

	public string GetContentPath(int index)
	{
		return null;
	}

	public int GetAttrInfoIndex(string name)
	{
		return default(int);
	}

	public LibmsType GetAttrType(int index)
	{
		return default(LibmsType);
	}

	public LibmsType GetAttrType(string name)
	{
		return default(LibmsType);
	}

	public int GetAttrOffset(int index)
	{
		return default(int);
	}

	public int GetAttrOffset(string name)
	{
		return default(int);
	}

	public string GetAttrListItemName(int attrIndex, int itemIndex)
	{
		return null;
	}

	public string GetAttrListItemName(string attrName, int itemIndex)
	{
		return null;
	}

	public int GetAttrNum()
	{
		return default(int);
	}

	public int GetAttrListItemNum(int attrIndex)
	{
		return default(int);
	}

	public string GetTagGroupName(ushort groupId)
	{
		return null;
	}

	public string GetTagName(ushort groupId, ushort tagId)
	{
		return null;
	}

	public string GetTagParamName(ushort groupId, ushort tagId, ushort paramId)
	{
		return null;
	}

	public LibmsType GetTagParamType(ushort groupId, ushort tagId, ushort paramId)
	{
		return default(LibmsType);
	}

	public string GetTagListItemName(ushort groupId, ushort tagId, ushort paramId, ushort itemIndex)
	{
		return null;
	}

	public int GetTagGroupNum()
	{
		return default(int);
	}

	public int GetTagNum(ushort groupId)
	{
		return default(int);
	}

	public int GetTagParamNum(ushort groupId, ushort tagId)
	{
		return default(int);
	}

	public int GetTagListItemNum(ushort groupId, ushort tagId, ushort paramId)
	{
		return default(int);
	}

	public int GetStyleIndex(string name)
	{
		return default(int);
	}

	public int GetRegionWidth(int index)
	{
		return default(int);
	}

	public int GetRegionWidth(string name)
	{
		return default(int);
	}

	public int GetLineNum(int index)
	{
		return default(int);
	}

	public int GetLineNum(string name)
	{
		return default(int);
	}

	public int GetFontIndex(int index)
	{
		return default(int);
	}

	public int GetFontIndex(string name)
	{
		return default(int);
	}

	public int GetBaseColorIndex(int index)
	{
		return default(int);
	}

	public int GetBaseColorIndex(string name)
	{
		return default(int);
	}

	public int GetStyleNum()
	{
		return default(int);
	}
}
