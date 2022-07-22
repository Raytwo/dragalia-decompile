using System.Text;
using Nintendo.MessageStudio.Lib;

namespace Dpr.Message;

public class MessageTagAnalyzer
{
	private const int SYSTEM_TAG_SIZE = 20;

	private StringBuilder systemTagStrBuilder;

	private const int MAX_WORD_SIZE = 30;

	private const int BYTE_SIZE = 2;

	private const int MIN_BYTE_LENGTH = 4;

	private StringBuilder wordStrBuilder;

	private byte[] byteArray;

	public LabelTagDataModel CustomTagAnalysis(ushort tagGroup, ushort tag, byte[] tagParams)
	{
		return null;
	}

	private void NameTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void DigitTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void GrmTagProcess(LabelTagDataModel tagDataModel)
	{
	}

	private void ENTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void FRTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void ITTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void DETagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void ESTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void KorTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void SCTagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void Character1TagProcess(LabelTagDataModel tagDataModel)
	{
	}

	private void Character2TagProcess(LabelTagDataModel tagDataModel)
	{
	}

	private void Ctrl1TagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private string ConvertCtrl1TagToRichText(MessageEnumData.Ctrl1ID ctrl1ID, float value)
	{
		return null;
	}

	private void Ctrl2TagProcess(LabelTagDataModel tagDataModel, byte[] tagParams)
	{
	}

	private void EmitErrorLog(MessageEnumData.GroupTagID groupTagId)
	{
	}

	public LabelTagDataModel ColorTagAnalysis(ColorTagInfo colorTagInfo)
	{
		return null;
	}

	public LabelTagDataModel FontTagAnalysis(FontTagInfo fontTagInfo)
	{
		return null;
	}

	private string GetFontFileName(int fontFileIndex)
	{
		return null;
	}

	public LabelTagDataModel SizeTagAnalysis(SizeTagInfo sizeTagInfo)
	{
		return null;
	}

	private string[] ExtractGrmWords(byte[] tagParams)
	{
		return null;
	}

	private int GetWordByteLength(byte[] tagParams, int startIndex)
	{
		return default(int);
	}
}
