using System.Runtime.InteropServices;

namespace Dpr.Contest;

[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 40)]
public struct NetPlayerData
{
	public string playerName;

	public int cassetVersion;

	public byte playerFashion;

	public byte colorID;

	public byte sex;

	public byte languageID;

	public bool isDpClear;
}
