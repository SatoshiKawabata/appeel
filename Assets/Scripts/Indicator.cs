using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {
	private TextOutput textOutput;
	// Use this for initialization
	void Start () {
		textOutput = GameObject.Find ("TextFiled").GetComponent<TextOutput> ();
	}
	
	// Update is called once per frame
	void Update () {
//		transform.rotation = AccelerationManager.instance ().getGyroRaw ();
		Quaternion q = AccelerationManager.instance ().getAttitude ();
		textOutput.addData ("raw x", q.eulerAngles.x.ToString ());
		textOutput.addData ("raw y", q.eulerAngles.y.ToString ());
		textOutput.addData ("raw z", q.eulerAngles.z.ToString ());

		Vector3 g = AccelerationManager.instance().getGravityRaw();
		textOutput.addData ("g x", g.x.ToString ());
		textOutput.addData ("g y", g.y.ToString ());
		textOutput.addData ("g z", g.z.ToString ());
	}
}
