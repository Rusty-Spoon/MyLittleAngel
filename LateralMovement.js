#pragma strict
public var lateralMovement : float;
var leftButton : String = "a";
var rightButton : String = "d";

var forward : Vector3;
var dt : double;

var leftRotation : float;
var rightRotation : float;

var suspended : boolean;
var moveSpeed : double;

function Start () 
{

	forward = new Vector3(0, 0, 1);
	dt = Time.deltaTime;
	
	leftRotation = -0.7071069;
	rightRotation = 0.7071069;
	
	suspended = false;
	moveSpeed = 3.0;
}

function Update () 
{
	if (suspended)
	{	
		return;
	}
	if (Input.GetButton(leftButton))
	{
		transform.rotation.y = leftRotation;
		transform.Translate(forward * moveSpeed * dt);
		animation.Play("walk");
	}
	else if (Input.GetButton(rightButton))
	{
		transform.rotation.y = rightRotation;
		transform.Translate(forward * moveSpeed * dt);
		animation.Play("walk");	
	}

}
function SetSuspension(setting : boolean)
{
	suspended = setting;
}