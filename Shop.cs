using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {
	public GameObject a1;
	public GameObject a2;
	public GameObject a3;
	public GameObject a4;

	public int Status;

	public GUISkin Air;
	//=========
	public float x;
	public float y;
	public float z;
	public float w;
	public float h;
	private float ScH;
	private float ScW;
	//=========
	void Start () {
		Status = 1;
	}
	
	void Update () {
		ScW = Screen.width;
		ScH = Screen.height;

		if (Status > 4) {
			Status = 1;		
		}
		if (Status < 1) {
			Status = 4;		
		}

		if (Status == 1) {
			a1.SetActive(true);		
		}
		else
			a1.SetActive(false);


		if (Status == 2) {
			a2.SetActive(true);		
		}
		else
			a2.SetActive(false);


		if (Status == 3) {
			a3.SetActive(true);		
		}
		else
			a3.SetActive(false);


		if (Status == 4) {
			a4.SetActive(true);		
		}
		else
			a4.SetActive(false);

		//===========

	}

	void OnGUI(){
		GUI.skin = Air;
		if (GUI.Button (new Rect (ScW / 1.24f, ScH / 2.5f, ScW / 5.95f, ScH / 6.84f),">>>>>")) {
			Status += 1;
		}
		if (GUI.Button (new Rect (ScW / 12.51f, ScH / 2.5f, ScW / 5.95f, ScH / 6.84f),"<<<<<")) {
			Status -= 1;
		}

		//=====


		if (Status == 2 && Game.Lvl >= 2 && Game.aa2 == 0) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "500 Золота");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Купить")) {
				if(Game.Gold >= 500){
				Game.Gold -= 500;
					Game.aa2 = 1;

				}
			}
		}
		if (Status == 3 && Game.Lvl >= 3 && Game.aa3 == 0) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "2500 Золота");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Купить")) {
				if(Game.Gold >= 2500){
					Game.Gold -= 2500;
					Game.aa3 = 1;

				}
		}
		}
		if (Status == 4 && Game.Lvl >= 8 && Game.aa4 == 0) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "4000 Золота");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Купить")) {
					if(Game.Gold >= 4000){
						Game.Gold -= 4000;
					Game.aa4 = 1;
					}
		}
	}

		//=======
		if (Status == 1 ) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "Куплено");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Установить")) {

				Game.NomerMashini = 1;
				
			}
		}
		if (Status == 2 && Game.aa2 == 1) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "Куплено");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Установить")) {
				Game.NomerMashini = 2;

			}
		}
		if (Status == 3 && Game.aa3 == 1) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "Куплено");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Установить")) {
				Game.NomerMashini = 3;

			}
		}
		if (Status == 4 && Game.aa4 == 1) {
			GUI.Label (new Rect (ScW / 2.37f, ScH / 8.41f, ScW / 1.97f, ScH / 1.53f), "Куплено");
			if (GUI.Button (new Rect (ScW / 2.62f, ScH / 1.75f, ScW / 3.4f, ScH / 8.44f),"Установить")) {
				Game.NomerMashini = 4;

			}
		}
		//======
}
}
