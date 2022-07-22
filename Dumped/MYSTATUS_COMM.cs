using System.Runtime.InteropServices;

[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 36)]
public struct MYSTATUS_COMM
{
	public uint id;

	public string name;

	public bool sex;

	public byte lang;

	public byte fashion;

	public byte body_type;

	public byte hat;

	public byte shoes;

	public void SetupFromPlayerWork()
	{
	}
}
