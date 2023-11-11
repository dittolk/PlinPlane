using System;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	private void Start()
	{
	}
	
	private void Update()
	{
	}
	
	private void DestroyFX()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
