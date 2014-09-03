using UnityEngine;
using System.Collections;
using Fungus;

public class FirstScene : Room {

	public Page GoodGuy;
	public Page BadGuy;
	public string levelToLoad;

	// Use this for initialization
	void OnEnter ()
	{
		SetPage(GoodGuy);
		Say("Uh...ugh. Where am I?");
		SetPage(BadGuy);
		Say("Don't worry, you're safe.");
		SetPage(GoodGuy);
		Say("Why can't I see anything? Agh, I can't move!");
		SetPage(BadGuy);
		Say("Your hands are tied and I put a hood over your head.");
		Wait(2);
		SetPage(GoodGuy);
		Say("Wait. Did you say I'm safe?");
		SetPage(BadGuy);
		Say("Yes.");
		SetPage(GoodGuy);
		Say ("I don't feel safe.");
		SetPage(BadGuy);
		Say ("You're not. I lied.");
		Wait (1);
		Say ("There's going to be a lot of that.");
		SetPage(GoodGuy);
		Say ("Please, I'm a father. You have to let me go.");
		SetPage(BadGuy);
		Say ("Wah wah wah, I'm a father! Who cares?");
		// Fade down here?
		Call(LoadLevel);
	}

	private void LoadLevel()
	{
		Application.LoadLevel(levelToLoad);
	}
}