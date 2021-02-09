using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wavegamer.TransformEx
{
	public static class TransformExx
	{
		public static string TranslocationToString(this Transform tra)
		{
			return tra.localPosition.ToString();
		}
	}
}
