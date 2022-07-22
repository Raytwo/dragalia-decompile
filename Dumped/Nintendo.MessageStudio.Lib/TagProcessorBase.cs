using System;

namespace Nintendo.MessageStudio.Lib;

public abstract class TagProcessorBase
{
	private const char ShiftIn = '\u000f';

	private const char ShiftOut = '\u000e';

	public void Process(IntPtr p)
	{
	}

	private void ProcessTag(ushort group, ushort tag, byte[] param)
	{
	}

	private void ProcessSystemTag(ushort tag, byte[] param)
	{
	}

	protected abstract void ProcessChar(char c);

	protected abstract void ProcessRubyTag(RubyTagInfo rubyTagInfo);

	protected abstract void ProcessFontTag(FontTagInfo fontTagInfo);

	protected abstract void ProcessSizeTag(SizeTagInfo sizeTagInfo);

	protected abstract void ProcessColorTag(ColorTagInfo colorTagInfo);

	protected abstract void ProcessPageBreakTag(PageBreakTagInfo pageBreakTagInfo);

	protected abstract void ProcessCustomTag(CustomTagInfo tagInfo);

	protected abstract void ProcessEnd();

	private char ReadChar(IntPtr p, int offset)
	{
		return default(char);
	}
}
