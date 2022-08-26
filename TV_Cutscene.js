#pragma strict

var movTex : MovieTexture;

function OnTriggerEnter (Obj : Collider) 
{
   if(Obj.gameObject.tag=="Player")
   {
   renderer.material.mainTexture = movTex;
   movTex.Play();
   yield WaitForSeconds (3);
   Debug.Log("Test");
   }
}

function Update ()
{
	if(Input.GetKeyDown(KeyCode.E))
	{
		renderer.material.mainTexture = movTex;
   		movTex.Play();
	}
	
	if(Input.GetKeyDown(KeyCode.Q))
	{
		movTex.Pause();
	}
}
