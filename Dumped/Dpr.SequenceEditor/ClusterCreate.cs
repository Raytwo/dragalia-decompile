using UnityEngine;

namespace Dpr.SequenceEditor;

public class ClusterCreate : Macro
{
	public string file;

	public string fileAnm;

	public bool useAnm;

	public SEQ_DEF_DRAWTYPE drawType;

	public SEQ_DEF_ROTATE_ORDER rotOrder;

	public int spawnMax;

	public int spawnTime;

	public int spawnInterval;

	public int spawnNum;

	public int spawnRate;

	public int spawnLife;

	public CLUSTER_SPAWN spawnType;

	public CLUSTER_POS_AXIS spawnAxis;

	public Vector3 spawnSize;

	public int spawnDegS;

	public int spawnDegE;

	public int spawnLen;

	public bool isMulti;

	public ClusterCreate(Macro macro)
	{
	}
}
