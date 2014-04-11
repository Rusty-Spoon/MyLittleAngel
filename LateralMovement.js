#pragma strict
public var lateralMovement : float;
var leftButton : String;
var rightButton : String;

var forward : Vector3;
var dt : double;

var leftRotation : float;
var rightRotation : float;

var suspended : boolean;
var moveSpeed : double;

function Start () 
{
	leftButton = "a";
	rightButton = "d";
	
	forward = new Vector3(0, 0, 1);
	dt = Time.deltaTime;
	
	leftRotation = -0.7071069;
	rightRotation = 0.7071069;
	
	suspended = false;
	moveSpeed = 3.0;
}

function Update () {

}