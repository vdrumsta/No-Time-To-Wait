using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public float time = 25.0f;               //Time in seconds
    private float originalTime;
    public bool done = false;
    public Transform imageToEdit;
    public float firstTime;
    public bool firstTimeShorter;

    void Start()
    {
        originalTime = time;
        if (firstTimeShorter)
        {
            time = firstTime;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(time > 0 && !done)
        {
            time -= Time.deltaTime;
            imageToEdit.GetComponent<Image>().fillAmount = (time / originalTime);
        }
        else
        {
            done = true;
            time = originalTime;
        }
    }
}
