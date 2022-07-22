using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigBoard : MonoBehaviour, IDigBoard
{
	[SerializeField]
	private int boxRatio;

	[SerializeField]
	private GridLayoutGroup grid;

	[SerializeField]
	private DigMasterDataManager masterData;

	[SerializeField]
	private DigAudioManager audioManager;

	[SerializeField]
	private DigEffectManager effectManager;

	[SerializeField]
	private DigVibration vibration;

	public const int DIGMAP_SIZE = 130;

	private const int DIGMAP_WIDTH = 13;

	private const int DIGMAP_HEIGHT = 10;

	private const int PARTS_NUM_MAX = 8;

	private const int PARTS_TREASURE_NUM_MAX = 4;

	private const int DEPOSIT_EMPTY = -1;

	private int dugOutOrder;

	private bool isInitialized;

	public Vector2 GridSize
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector2 FieldSize
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector2 FieldOffset
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int[,] BuildupMap
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int[,] DepositMap
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public List<DigDepositViewManager.PlacementInfo> DepositPlacementInfos
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public DigMasterDataManager.RatioId RatioId
	{
		[CompilerGenerated]
		get
		{
			return default(DigMasterDataManager.RatioId);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize()
	{
	}

	public int CalcMapColumnIndex(float x)
	{
		return default(int);
	}

	public int CalcMapRowIndex(float y)
	{
		return default(int);
	}

	public int GetDepositCount()
	{
		return default(int);
	}

	public int GetDigOutItemCount()
	{
		return default(int);
	}

	public bool IsCheckDigOutAll()
	{
		return default(bool);
	}

	public bool IsCheckDigOut()
	{
		return default(bool);
	}

	public uint[] GetDigItemNumbers()
	{
		return null;
	}

	public void Dig(Vector2 pos, bool bIsPickaxe, bool bIsAdjacent = true, int cursorNum = -1)
	{
	}

	public void RandomDig(bool bIsPickaxe)
	{
	}

	private void Dig(int mapX, int mapY, bool bIsPickaxe, bool bIsAdjacent = true)
	{
	}

	private void DigWithAnimation(Vector2 position, int cursorNum, bool bIsPickaxe, bool bIsAdjacent = true)
	{
	}

	private bool DigMap(int mapX, int mapY, int digNum)
	{
		return default(bool);
	}

	private bool DigHumerOrPickaxe(int mapX, int mapY, bool bIsPickaxe)
	{
		return default(bool);
	}

	private void PlayDigEffect(int cursorNum, bool bIsPickaxe, bool bIsBuildupBroken)
	{
	}

	private void CheckDigOut()
	{
	}

	private bool IsCheckDigOut(DigDepositViewManager.PlacementInfo info)
	{
		return default(bool);
	}

	private DigDepositViewManager.PlacementInfo GetDeposit(int x, int y)
	{
		return null;
	}

	private void RandomDeposit()
	{
	}

	private int GetTreasurePartsRandomMax<T>([In] ref List<T> inList, DigMasterDataManager.RatioId id) where T : DigMasterDataManager.IDeposit
	{
		return default(int);
	}

	private int GetTreasurePartsRandom<T>([In] ref List<T> inList, DigMasterDataManager.RatioId id, int random) where T : DigMasterDataManager.IDeposit
	{
		return default(int);
	}

	private bool PartsDeposit<T>([In] ref List<T> inList, int partsIndex, int x, int y) where T : DigMasterDataManager.IDeposit
	{
		return default(bool);
	}

	private bool IsAttribute([In] ref DigMasterDataManager.IDeposit inDeposit, int x, int y)
	{
		return default(bool);
	}

	private bool IsFreeDiposit()
	{
		return default(bool);
	}

	private void RandomBuildUp()
	{
	}
}
