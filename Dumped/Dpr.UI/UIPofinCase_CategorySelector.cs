using UnityEngine;

namespace Dpr.UI;

public class UIPofinCase_CategorySelector : MonoBehaviour
{
	public enum Category
	{
		All,
		Spicy,
		Dry,
		Sweet,
		Bitter,
		Sour
	}

	[SerializeField]
	private UIPofinCase_CategoryButton[] categoryBtns;

	private Category nowCategory;

	public void Initialize()
	{
	}

	public void ChangeCategoryNext()
	{
	}

	public Category GetCurrentCategory()
	{
		return default(Category);
	}

	private void ChangeCategory(Category category)
	{
	}
}
