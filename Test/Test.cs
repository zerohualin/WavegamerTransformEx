using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wavegamer.TransformEx;

public class Test : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Debug.LogError(this.transform.TranslocationToString());
	}

	// Update is called once per frame
	void Update()
	{

	}
}
