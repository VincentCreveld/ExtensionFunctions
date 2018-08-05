﻿using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ExtensionFunctions {
	public static class ArrayFunctions {
		///<summary>
		/// The CleanupList function runs through a list and removes all NULL elements. 
		/// The remaining elements get moved towards the front of the list.
		/// </summary>
		public static List<T> CleanupList<T>(List<T> list) {
			List<T> temp = new List<T>();
			foreach(T l in list) {
				if(l != null)
					temp.Add(l);
			}
			return temp;
		}

		public static T[] CleanupArray<T>(T[] array) {
			return array.Where(x => x != null).ToArray();
		}

		/// <summary>
		/// Returns a value from an array.
		/// </summary>
		public static T GetValueFromArray<T>(T[] array, int index) {
			try {
				return array[index];
			}
			catch(System.IndexOutOfRangeException ex) {
				Console.WriteLine("Index is out of range: {0}", index);
				throw;
			}
		}
	}

	public static class MathFunctions {
		/// <summary>
		/// A map function to move a given number from scope A to scope B.
		/// </summary>
		public static decimal Map(this decimal value, decimal fromSource, decimal toSource, decimal fromTarget, decimal toTarget) {
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}
		/// <summary>
		/// A map function to move a given number from scope A to scope B.
		/// </summary>
		public static int Map(this int value, int fromSource, int toSource, int fromTarget, int toTarget) {
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}
		/// <summary>
		/// A map function to move a given number from scope A to scope B.
		/// </summary>
		public static float Map(this float value, float fromSource, float toSource, float fromTarget, float toTarget) {
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}
		/// <summary>
		/// A map function to move a given number from scope A to scope B.
		/// </summary>
		public static double Map(this double value, double fromSource, double toSource, double fromTarget, double toTarget) {
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}
	}
}
