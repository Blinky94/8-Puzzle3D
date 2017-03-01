using UnityEngine;

public static class Counter
{
    private static float timer;
    private static Font font;

    private static void UpdateTimerUI()
    {
        timer = +Time.time;
        int minutes = (int)((timer / 60) % 60);
        int seconds = (int)(timer % 60);
        int milliseconds = (int)(timer * 100) % 100;
      
        ObjType.Timer.GetComponent<TextMesh>().text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);      
    }

	public static void Initialize () 
    {
	    timer = Time.deltaTime;  
	}
	
    public static void UpdateTimer()
    {
        UpdateTimerUI();
    }
}
