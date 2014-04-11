#pragma strict

public var fadeRate : float = 0.01;
private var fadeUp : boolean = false;
private var fadeDown : boolean = false;

function Start () {
	
	fadeUp = true;
	
}

function Update () {

	if (fadeUp)
	{FadeUp();}
	if (fadeDown)
	{FadeDown();}
}

function FadeUp() {
	

	if (renderer.material.color.a > 0)
	{renderer.material.color.a = renderer.material.color.a - fadeRate;}
	else
	{
	renderer.material.color.a = 0;
	fadeUp = false;
	}	
}

function FadeDown() {
	

	if (renderer.material.color.a < 254.5)
	{renderer.material.color.a = renderer.material.color.a + fadeRate;}
	else
	{
	renderer.material.color.a = 255;
	fadeDown = false;
	}
	
}


function OnTriggerEnter()
{
 	fadeDown = true;
}