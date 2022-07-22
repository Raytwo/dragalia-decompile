using Dpr.Message;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class TypePanel : MonoBehaviour
{
	private const string TypeNameMessageFileName = "ss_typename";

	[SerializeField]
	private Image iconImage;

	public void Set(int typeNo)
	{
	}

	public void SetZukan(int typeNo, MessageEnumData.MsgLangId langId = MessageEnumData.MsgLangId.Num)
	{
	}

	public void Deactive()
	{
	}
}
