using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	private float startTime;
	private float restSeconds;
	private int roundedRestSeconds;
	private float displaySeconds;
	private float displayMinutes;
	public int CountDownSeconds=120;
	public Vector2 labelLocation;
	public Vector2 labelSize;
	public string LevelToLoad;
	private float Timeleft;
	string timetext;
	public GUIStyle style;
	
	
	// Use this for initialization
	
	void Start () 
	{
		startTime=Time.time;
		
	}
	
	void OnGUI()
	{
		
		Timeleft= Time.time-startTime;
		
		restSeconds = CountDownSeconds-(Timeleft);
		
		roundedRestSeconds=Mathf.CeilToInt(restSeconds);
		displaySeconds = roundedRestSeconds % 60;
		displayMinutes = (roundedRestSeconds / 60)%60;
		
		timetext = (displayMinutes.ToString()+":");
		if (displaySeconds > 9)
		{
			timetext = timetext + displaySeconds.ToString();
		}
		else 
		{
			timetext = timetext + "0" + displaySeconds.ToString();
			if (displaySeconds == 0 && displayMinutes == 0)
			{Application.LoadLevel(LevelToLoad);} 
		}
		GUI.Label(new Rect(labelLocation.x, labelLocation.y, labelSize.x, labelSize.y), timetext, style);
	}}

