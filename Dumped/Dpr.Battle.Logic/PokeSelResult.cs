namespace Dpr.Battle.Logic;

public sealed class PokeSelResult
{
	private BTL_CLIENT_ID m_myClientID;

	private BTL_CLIENT_ID[] m_selClientID;

	public byte[] m_selIdx;

	public byte[] m_outPokeIdx;

	private ushort[] m_useItem;

	private byte[] m_wazaIdx;

	public byte m_cnt;

	private byte m_max;

	private bool m_fCancel;

	public byte GetSelectMax()
	{
		return default(byte);
	}

	public void Init(PokeSelParam param)
	{
	}

	public void Push(byte outPokeIdx, byte selPokeIdx)
	{
	}

	public void Pop()
	{
	}

	public void SetCancel(bool flg)
	{
	}

	public bool IsCancel()
	{
		return default(bool);
	}

	public bool IsDone()
	{
		return default(bool);
	}

	public byte GetCount()
	{
		return default(byte);
	}

	public byte GetLast()
	{
		return default(byte);
	}

	public byte Get(byte idx)
	{
		return default(byte);
	}

	public void SetItemUse(BTL_CLIENT_ID clientID, byte pokeIdx, ushort itemNo, byte wazaIdx = 0)
	{
	}

	public bool IsItemUse(out BTL_CLIENT_ID clientID, out byte pokeIdx, out ushort itemNo, out byte wazaIdx)
	{
		return default(bool);
	}
}
