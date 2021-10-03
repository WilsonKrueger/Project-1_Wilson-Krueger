using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
	public GameObject directionsTextObject;
	public float timeRemaining = 5;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
		
		else
		{
			directionsTextObject.SetActive(false);
		}
    }
}
