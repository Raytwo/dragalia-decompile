using System.Collections.Generic;
using System.Text;
using Nintendo.MessageStudio.Lib;

namespace Dpr.Message;

public class LabelParseProcessor : TagProcessorBase
{
	private List<LabelTagDataModel> tagDataModelList;

	private List<string> strList;

	private MessageTagAnalyzer tagAnalyzer;

	private StringBuilder strBuilder;

	private char charSingleQuotation;

	private char charDoubleQuotation;

	private char charAfterSingleQuotation;

	private char charAfterDoubleQuotation;

	private bool isCallReset;

	public void Initialize()
	{
	}

	public LabelParseDataModel CreateParseDataModel()
	{
		return null;
	}

	public void Reset()
	{
	}

	protected override void ProcessChar(char c)
	{
	}

	protected override void ProcessEnd()
	{
	}

	private bool IsExcludeChar(char c)
	{
		return default(bool);
	}

	private bool IsNewLineChar(char c)
	{
		return default(bool);
	}

	public bool IsReplaceCharacter(char c, out char afterChar)
	{
		return default(bool);
	}

	private void AddCurrentMessage()
	{
	}

	private void AddNewLineCharMark(char c)
	{
	}

	protected override void ProcessCustomTag(CustomTagInfo tagInfo)
	{
	}

	protected override void ProcessColorTag(ColorTagInfo colorTagInfo)
	{
	}

	protected override void ProcessFontTag(FontTagInfo fontTagInfo)
	{
	}

	protected override void ProcessPageBreakTag(PageBreakTagInfo pageBreakTagInfo)
	{
	}

	protected override void ProcessRubyTag(RubyTagInfo rubyTagInfo)
	{
	}

	protected override void ProcessSizeTag(SizeTagInfo sizeTagInfo)
	{
	}
}
