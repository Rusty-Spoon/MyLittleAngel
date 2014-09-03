#pragma strict

var targetToChase : Transform;
var moveSpeed = 3;
var rotationSpeed = 3;
public var radius : float = 25;
var myTransform : Transform;

function Awake () 
{
	myTransform = transform;
}
function Start () 
{
}

function Update () 
{
	targetToChase = GameObject.FindWithTag("Player").transform;

	// Check distance
}

function FindPlayer()
{
	myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(targetToChase.position - myTransform.position), rotationSpeed*Time.deltaTime);
	myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

}

function CheckDistance ()
{
		// targetToChase.position.x 
}