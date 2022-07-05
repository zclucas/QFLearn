using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BindableProperty<T> where T:IEquatable<T>
{
    public T mValue = default(T);
	public Action<T> OnValueChange;
    public T Value
	{
		get => mValue;
		set
		{
			if (!value.Equals(mValue))
			{
				mValue = value;
				OnValueChange?.Invoke(mValue);
			}
		}
	}
}
