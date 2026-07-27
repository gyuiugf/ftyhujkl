using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MaxSegmentCollection
{
	public class MaxSegmentCollectionBuilder
	{
		internal readonly List<MaxSegment> segments;

		internal MaxSegmentCollectionBuilder()
		{
		}

		public MaxSegmentCollectionBuilder AddSegment(MaxSegment segment)
		{
			return null;
		}

		public MaxSegmentCollection Build()
		{
			return null;
		}
	}

	[SerializeField]
	private List<MaxSegment> segments;

	private MaxSegmentCollection(MaxSegmentCollectionBuilder maxSegmentCollectionBuilder)
	{
	}

	public List<MaxSegment> GetSegments()
	{
		return null;
	}

	public static MaxSegmentCollectionBuilder Builder()
	{
		return null;
	}
}
