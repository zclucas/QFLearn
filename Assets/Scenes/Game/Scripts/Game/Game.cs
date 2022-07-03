using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameStartEvent.Register(OnRegister);
		KillOneEvent.Register(OnKillOne);
    }

	private void OnKillOne()
	{
		GameMedol.KillCount++;
		if (GameMedol.KillCount == 10)
			GameEndEvent.OnTrigger();
	}

	private void OnRegister()
	{
        transform.Find("GameEmery").gameObject.SetActive(true);
	}
	public void OnDestroy()
	{
		GameStartEvent.UnRegister(OnRegister);
		KillOneEvent.UnRegister(OnRegister);
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
