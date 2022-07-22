using UnityEngine;

namespace Dpr.SecretBase;

public class FieldCursor : MonoBehaviour
{
	[SerializeField]
	private Transform cursorRoot;

	[SerializeField]
	private FieldCursorGrid fieldCursorGrid;

	[SerializeField]
	private Transform field;

	[SerializeField]
	private bool isMove;

	[SerializeField]
	private Transform pointer;

	[SerializeField]
	private Transform node;

	[SerializeField]
	private Transform statueRoot;

	[SerializeField]
	private BoxCollider boxCollider;

	private RectInt rect;

	private Vector3 cursorOffset;

	private Vector3 cursorPosition;

	public int Width => default(int);

	public int Height => default(int);

	public Transform Node => null;

	public Transform StatueRoot => null;

	public BoxCollider BoxCollider => null;

	private void Update()
	{
	}

	public void SetPosition(Vector2Int gridPosition)
	{
	}

	public void SetRect(RectInt value)
	{
	}

	public void SetRect(int x, int y, int width, int height)
	{
	}

	public RectInt GetRect()
	{
		return default(RectInt);
	}

	public void SetActiveField(bool value)
	{
	}

	public void SetActiveCursor(bool value)
	{
	}

	public void SetActivePointer(bool value)
	{
	}

	public void SetPointerHeight(float height)
	{
	}
}
