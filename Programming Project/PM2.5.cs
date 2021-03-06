﻿//============================================================
    // Student Number	: S10198319, S10196678
    // Student Name	: Tan Yuan Ming, Gladys
    // Module  Group	: P08
//============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project
{
	public class LabelLocation
	{
		public double latitude { get; set; }
		public double longitude { get; set; }
	}

	public class RegionMetadata
	{
		public string name { get; set; }
		public LabelLocation label_location { get; set; }
	}

	public class Pm25OneHourly
	{
		public int west { get; set; }
		public int east { get; set; }
		public int central { get; set; }
		public int south { get; set; }
		public int north { get; set; }
	}

	public class Readings
	{
		public Pm25OneHourly pm25_one_hourly { get; set; }
	}

	public class Item
	{
		public DateTime timestamp { get; set; }
		public DateTime update_timestamp { get; set; }
		public Readings readings { get; set; }
	}

	public class ApiInfo
	{
		public string status { get; set; }
	}

	public class RootObject
	{
		public List<RegionMetadata> region_metadata { get; set; }
		public List<Item> items { get; set; }
		public ApiInfo api_info { get; set; }
	}
}