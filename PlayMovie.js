#pragma strict

var movTex : MovieTexture;
var loop : boolean;

function OnTriggerEnter (other : Collider)
{
	if(other.tag == "Player")
	{
	renderer.material.mainTexture = movTex;
	movTex.Play();
	yield WaitForSeconds (3);
	Application.LoadLevel("NewScene");
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