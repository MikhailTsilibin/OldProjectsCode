#pragma strict

var score : int = 0;

function OnGUI()
{
	GUI.Box(Rect(10, 10, 100, 20), "" + score);
}