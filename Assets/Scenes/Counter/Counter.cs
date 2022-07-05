using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CounterModel.count.OnValueChange += UpdataText;
        transform.Find("Add").GetComponent<Button>().onClick.AddListener(() =>
        {
            CounterModel.count.Value++;
        });
        transform.Find("Rec").GetComponent<Button>().onClick.AddListener(() =>
        {
            CounterModel.count.Value--;
        });
        UpdataText(CounterModel.count.Value);
    }
	public void OnDestroy()
	{
        CounterModel.count.OnValueChange -= UpdataText;
    }
	public void UpdataText(int count)
	{
        transform.Find("Counter").GetComponent<Text>().text = count.ToString();
    }
}

public class CounterModel
{
    public static BindableProperty<int> count = new BindableProperty<int>()
    {
        Value = 0
    };

}
public class OnCountChangeEvent : Event<OnCountChangeEvent>
{
    
}
