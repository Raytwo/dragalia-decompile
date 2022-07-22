using System;

namespace Nintendo.MessageStudio.Lib;

public class BinMsgFile : BinLibmsFileBase
{
	public void SetMSBTFileData(byte[] byteDataArray)
	{
	}

	protected override IntPtr InitObject(IntPtr resourcePtr)
	{
		return default(IntPtr);
	}

	protected override void CloseObject(IntPtr objectPtr)
	{
	}

	public int SearchMessageBlock(string block)
	{
		return default(int);
	}

	public BlockInfo GetBlockInfo(string block)
	{
		return default(BlockInfo);
	}

	public byte[] GetAttributes(string label)
	{
		return null;
	}

	public byte[] GetAttributes(int index)
	{
		return null;
	}

	public sbyte GetInt8Attribute(byte[] attr, int index)
	{
		return default(sbyte);
	}

	public byte GetUInt8Attribute(byte[] attr, int index)
	{
		return default(byte);
	}

	public short GetInt16Attribute(byte[] attr, int index)
	{
		return default(short);
	}

	public ushort GetUInt16Attribute(byte[] attr, int index)
	{
		return default(ushort);
	}

	public int GetInt32Attribute(byte[] attr, int index)
	{
		return default(int);
	}

	public uint GetUInt32Attribute(byte[] attr, int index)
	{
		return default(uint);
	}

	public float GetFloatAttribute(byte[] attr, int index)
	{
		return default(float);
	}

	public double GetDoubleAttribute(byte[] attr, int index)
	{
		return default(double);
	}

	public string GetStringAttribute(byte[] attr, int index)
	{
		return null;
	}

	public int GetListAttribute(byte[] attr, int index)
	{
		return default(int);
	}

	public int GetIndexAttribute(int labelIndex, int attributeID)
	{
		return default(int);
	}

	public int GetIndexAttribute(byte[] attr, int index)
	{
		return default(int);
	}

	public int GetStyle(string label)
	{
		return default(int);
	}

	public int GetStyle(int index)
	{
		return default(int);
	}

	public string GetLabel(int index)
	{
		return null;
	}

	public int GetTextNum()
	{
		return default(int);
	}

	public int GetTextIndex(string label)
	{
		return default(int);
	}

	public int GetTextSize(int index)
	{
		return default(int);
	}

	public IntPtr GetText(string strLabel)
	{
		return default(IntPtr);
	}

	public IntPtr GetText(int index)
	{
		return default(IntPtr);
	}
}
