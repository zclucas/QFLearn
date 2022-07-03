using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emery : MonoBehaviour
{
    // Start is called before the first frame update
	public void OnMouseDown()
	{
        KillOneEvent.OnTrigger();
        Destroy(gameObject);
	}
}
