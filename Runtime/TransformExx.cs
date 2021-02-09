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

		public static string TranslocalScaleToString(this Transform tra)
		{
			return tra.localScale.ToString();
		}

		public static string TranslocalScaleToString2(this Transform tra)
		{
			return tra.localScale.ToString();
		}
	}
}
