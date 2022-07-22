using System;

namespace Dpr.SequenceEditor;

[Serializable]
public sealed class Command
{
	public static Command Default;

	public int StartFrame;

	public int EndFrame;

	public byte ColR;

	public byte ColG;

	public byte ColB;

	public string Comment;

	public int IsActive;

	public Macro Macro;
}
