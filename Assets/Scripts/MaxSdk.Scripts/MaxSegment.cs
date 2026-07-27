using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MaxSegment
{
	[SerializeField]
	private int key;

	[SerializeField]
	private List<int> values;

	public MaxSegment(int key, List<int> values)
	{
	}

	public int GetKey()
	{
		return 0;
	}

	public List<int> GetValues()
	{
		return null;
	}
}
