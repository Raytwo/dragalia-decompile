using System.Collections.Generic;
using UnityEngine;

public class PetrifyUpdater : MonoBehaviour
{
	private static readonly int _noiseFactorID;

	private static readonly int _triPlanarScaleID;

	private static readonly int _textureOffsetID;

	private static readonly int _disributionID;

	private static readonly int _edgeDetectionID;

	private static readonly int _colorWeightID;

	private static readonly int _bumpScaleID;

	private static readonly int _cosinePowerID;

	private static readonly int _specularScaleID;

	private static readonly int _glossyID;

	private static readonly int _reflecivityID;

	private static readonly int _colorMapID;

	private static readonly int _bumpMapID;

	private static readonly int _specularMapID;

	private static readonly int _ambientMapID;

	public PetrifyData.MaterialData materialData;

	public List<Material> materials;

	public void LateUpdate()
	{
	}

	public static void SetParameters(PetrifyData.MaterialData materialData, List<Material> materials)
	{
	}
}
