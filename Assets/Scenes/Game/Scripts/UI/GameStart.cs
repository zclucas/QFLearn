using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Button").GetComponent<Button>().onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            GameStartEvent.OnTrigger();

        });
    }
}
