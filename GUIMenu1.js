//Script created by Darie Andrei

function OnGUI() {

GUI.Box(Rect(Screen.width /2 - 200,Screen.height /2 - 100,400,200), "Game Menu");		

		
		
		if(GUI.Button(Rect(Screen.width /2 - 200,Screen.height /2 - 50,400,55), "Play")){
			Application.LoadLevel("Game");
		}
		
		
			if(GUI.Button(Rect(Screen.width /2 - 200,Screen.height /2 ,400,55), "Credits")){
			    Application.LoadLevel("Credits");
		}	    
			if (GUI.Button (Rect (Screen.width /2 - 200,Screen.height /2 + 50,400,55), "Quit")){
			Application.Quit();
		}
	}