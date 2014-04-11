#pragma strict

public var fadeRate : double = 0.01;

function Start () {

}

function Update () {

	if (renderer.material.color.a > 0)
	{renderer.material.color.a = renderer.material.color.a + fadeRate;}
	else
	{renderer.material.color.a = 0;}

}