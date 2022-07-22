using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public class PokeIDRegister
{
	private byte m_count;

	private byte[] m_pokeID;

	public byte this[uint index]
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public void Clear()
	{
	}

	public byte GetCount()
	{
		return default(byte);
	}

	public byte GetID(byte index)
	{
		return default(byte);
	}

	public bool IsRegistered(byte pokeID)
	{
		return default(bool);
	}

	public void Register(byte pokeID)
	{
	}

	public void Merge([In] ref PokeIDRegister src)
	{
	}
}
