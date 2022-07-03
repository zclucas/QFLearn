using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEndEvent.Register(OnGameEnd);
    }

	private void OnGameEnd()
	{
        transform.Find("Canvas/GameEndPanle").gameObject.SetActive(true);
	}
	public void OnDestroy()
	{
		GameEndEvent.UnRegister(OnGameEnd);
	}

	// Update is called once per frame
}
