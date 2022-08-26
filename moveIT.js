internal var animator;
var vertical : float;
var horizontal : float;
var jump : float;

function Start(){
	animator = GetComponent(Animator);
}

function FixedUpdate(){
	animator.SetFloat("Speed", vertical, 0.1f, Time.deltaTime);
	animator.SetFloat("Direction", vertical, 0.1f, Time.deltaTime);	
	animator.SetFloat("Jump", jump);	
	Jumping();
}

function Update(){
	vertical = Input.GetAxis("Vertical");
	horizontal = Input.GetAxis("Horizontal");
}

function Jumping(){
	if(Input.GetKey(KeyCode.Space)){
		jump = 1.0;
}
	else{
		jump = 0.0;
	}		
}