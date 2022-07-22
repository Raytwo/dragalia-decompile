using System.Runtime.InteropServices;
using Pml;
using Pml.PokePara;

namespace Dpr.GMS;

public class SendMonsDataModel : ATradeMonsData
{
	public PokemonParam selectPokeParam;

	public PokemonParam demoPokeParam;

	public MonsNo sendMonsNo;

	public uint sendMonsFormNo;

	public Sex sendMonsSex;

	public int trayIndex;

	public int indexInTray;

	public void Clear()
	{
	}

	public void CreateDemoPokeParam([In] ref byte[] coreData)
	{
	}

	public void CopySendCoreData([In] ref byte[] coreData)
	{
	}
}
