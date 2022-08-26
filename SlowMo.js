#pragma strict

var currentSlowMo : float = 0;
var slowTimeAllowed : float = 2.0;

function Update()
{
	if(Input.GetButtonDown ("Fire2"))
	{
		if(Time.timeScale == 1.0)
		Time.timeScale = 0.3;
		
	else
	
		Time.timeScale = 1.0;
		Time.fixedDeltaTime = 0.02 * Time.timeScale;
	}
	
	if(Time.timeScale == 0.3)
	{
		currentSlowMo += Time.deltaTime;
	}
	
	if(currentSlowMo > slowTimeAllowed)
	{
		currentSlowMo = 0;
		Time.timeScale = 1.0;
	}
}