using System.Runtime.InteropServices;
using DPData;
using Dpr.Message;
using Pml;
using Pml.PokePara;

namespace Dpr.Battle.Logic;

public class MyStatus
{
	public string name;

	public bool sex;

	public MessageEnumData.MsgLangId lang;

	public uint id;

	public byte fashion;

	public byte body_type;

	public byte hat;

	public byte shoes;

	private Sex _sex => default(Sex);

	public void Deserialize([In] ref MYSTATUS status)
	{
	}

	public void Deserialize([In] ref MYSTATUS_COMM status)
	{
	}

	public void CopyFrom(MyStatus src)
	{
	}

	public string GetNameString()
	{
		return null;
	}

	public Sex GetSex()
	{
		return default(Sex);
	}

	public int GetHatVariation()
	{
		return default(int);
	}

	public int GetShoesVariation()
	{
		return default(int);
	}

	public MessageEnumData.MsgLangId GetPokeLanguageId()
	{
		return default(MessageEnumData.MsgLangId);
	}

	public bool IsMyPokemon(CoreParam poke)
	{
		return default(bool);
	}

	public string GetModelID()
	{
		return null;
	}

	public int GetColorID()
	{
		return default(int);
	}

	public bool HasGBand()
	{
		return default(bool);
	}

	public void SetCyclingRoad()
	{
	}

	public static void GetParamFromSysFlag(out byte hat, out byte shoes)
	{
	}
}
