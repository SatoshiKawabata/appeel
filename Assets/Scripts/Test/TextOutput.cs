using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TextOutput : MonoBehaviour {

	private Text text;
	private Dictionary<string, string> dataList;

	void Awake () {
		text = GetComponent<Text> ();
		text.horizontalOverflow = HorizontalWrapMode.Overflow;
		text.verticalOverflow = VerticalWrapMode.Overflow;
		dataList = new Dictionary<string, string> ();
	}

	void OnGUI () {
		string output = "";
		foreach (KeyValuePair<string, string> pair in dataList) {
			output += pair.Key + " : " + pair.Value + "\n";
		}
		text.text = output;
	}

	public void addData(string key, string value) {

		if (dataList.ContainsKey(key))
			dataList [key] = value;
		else
			dataList.Add (key, value);
	}

	public void removeData(string key) {
		if (dataList.ContainsKey (key))
			dataList.Remove (key);
	}
}