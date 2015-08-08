using UnityEngine;
using System.Collections;

public class GravityRotation : MonoBehaviour {
//	public bool enableX = true;
	public Vector2 map = new Vector2(0f, 360f);
//	public bool enableY = true;
//	public Vector2 mapY = new Vector2(0f, 360f);
//	public bool enableZ = true;
//	public Vector2 mapZ = new Vector2(0f, 360f);
	public bool isLocal = false;

	void Start () {
	
	}

	void Update () {
		Vector3 eulerAngles = new Vector3 ();
		
		Vector3 gravity = AccelerationManager.instance ().getGravityRaw ();
//		
//		if (enableX)
//			eulerAngles.x = Util.map(gravity.x, -1f, 1f, mapX.x, mapX.y);
//		
//		if (enableY)
//			eulerAngles.x = Util.map(gravity.y, -1f, 1f, mapY.x, mapY.y);
//		
//		if (enableZ)
//			eulerAngles.z = Util.map(gravity.z, -1f, 1f, mapZ.x, mapZ.y);

//		float intermediateValue = (map.x + map.y) * 0.5f;

		float gy = (gravity.z > 0) ? gravity.y + 1 : Util.map(gravity.y, -1f, 0f, 0f, -1f);
		eulerAngles.x = Util.map(gy, -1f, 1f, map.x, map.y);


		if (isLocal)
			transform.localRotation = Quaternion.Slerp (transform.localRotation, Quaternion.Euler (eulerAngles), 0.1f);
		else
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (eulerAngles), 0.1f);
	}
}
