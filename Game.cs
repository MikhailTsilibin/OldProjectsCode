using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public bool Games;
	public bool Shops;

	public static int Lvl;
	public static int Gold;
	public static int NomerMashini;
	public static int aa1 = 1;
	public static int aa2 = 0;
	public static int aa3 = 0;
	public static int aa4 = 0;

	public GameObject a1;
	public GameObject a2;
	public GameObject a3;
	public GameObject a4;

	public float x;
	public float y;
	public float z;
	public float w;
	public float h;
	private float ScH;
	private float ScW;

	public int zahod;
	public bool Save;
	// Use this for initialization
	void Start () {
		zahod = PlayerPrefs.GetInt ("zahod");
		if (zahod == 0) {
			Gold = 100;
			aa1 = 1;
			PlayerPrefs.SetInt ("zahod", 1);
		}
		if (zahod == 1) {
			aa1 = PlayerPrefs.GetInt("aa1");
			aa2 = PlayerPrefs.GetInt("aa2");
			aa3 = PlayerPrefs.GetInt("aa3");
			aa4 = PlayerPrefs.GetInt("aa4");

			Gold = PlayerPrefs.GetInt ("Gold");
			NomerMashini = PlayerPrefs.GetInt ("Car");
			Lvl = PlayerPrefs.GetInt ("Lvl");

		}
	}
	
	// Update is called once per frame
	void Update () {
		Save = true;

		if (Save == true) {
			PlayerPrefs.SetInt("Gold",Gold);
			PlayerPrefs.SetInt("Lvl",Lvl);
			PlayerPrefs.SetInt("aa1",aa1);
			PlayerPrefs.SetInt("aa2",aa2);
			PlayerPrefs.SetInt("aa3",aa3);
			PlayerPrefs.SetInt("aa4",aa4);

			PlayerPrefs.SetInt("Car",NomerMashini);

			PlayerPrefs.Save ();
			Save = false;
			Save = true;
		}

		ScW = Screen.width;
		ScH = Screen.height;
		
		if (NomerMashini > 4) {
			NomerMashini = 1;		
		}
		if (NomerMashini < 1) {
			NomerMashini = 4;		
		}

		if (NomerMashini == 1) {
			a1.SetActive(true);		
		}
		else
			a1.SetActive(false);
		
		
		if (NomerMashini == 2) {
			a2.SetActive(true);		
		}
		else
			a2.SetActive(false);
		
		
		if (NomerMashini == 3) {
			a3.SetActive(true);		
		}
		else
			a3.SetActive(false);
		
		
		if (NomerMashini == 4) {
			a4.SetActive(true);		
		}
		else
			a4.SetActive(false);
	}
	void OnGUI(){
		GUI.Label (new Rect (ScW / 30.94f, ScH / 41.38f, ScW / 1.58f, ScH / 2.65f), "Золото: "+ Gold);
		GUI.Label (new Rect (ScW / 4.79f, ScH / 41.38f, ScW / 1.58f, ScH / 2.65f), "LvL "+ Lvl);

		if (GUI.Button (new Rect (ScW / 1.93f, ScH / 16.06f, ScW / 18.36f, ScH / 11.28f),">")) {
			NomerMashini += 1;
		}
		if (GUI.Button (new Rect (ScW / 2.4f, ScH / 16.06f, ScW / 18.36f, ScH / 11.28f),"<")) {
			NomerMashini -= 1;
		}

		if (GUI.Button (new Rect (ScW / 1.3f, ScH / 16.06f, ScW / 18.36f, ScH / 11.28f),">")) {
			Lvl += 1;
		}
		if (GUI.Button (new Rect (ScW / 1.49f, ScH / 16.06f, ScW / 18.36f, ScH / 11.28f),"<")) {
			Lvl -= 1;
		}


	}
}
