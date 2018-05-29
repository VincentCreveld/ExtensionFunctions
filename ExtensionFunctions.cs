namespace ExtensionFunctions {
	public static class ArrayFunctions {
		///<summary>
		/// The CleanupList function runs through a list and removes all NULL elements. 
		/// The remaining elements get moved towards the front of the list.
		/// </summary>
		public static System.Collections.Generic.List<T> CleanupList<T>(System.Collections.Generic.List<T> list) {
			System.Collections.Generic.List<T> temp = new System.Collections.Generic.List<T>();
			foreach(T l in list) {
				if(l != null)
					temp.Add(l);
			}
			return temp;
		}

		public static T[] CleanupArray<T>(T[] array) {
			int n;
			System.Collections.Generic.List<int> referenceList = new System.Collections.Generic.List<int>();
			for(var i = 0; i < array.Length; i++) {
				if(array[i] != null) {
					referenceList.Add(i);
					n++;
				}
			}
			T[] temp = T[n];
			for(int i = 0; i < temp.Length; i++) {
				temp[i] = array(referenceList[i]);
			}
			return temp;
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