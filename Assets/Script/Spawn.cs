using System;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject[] benda;
	
	private int i;
	
	private float y;
	
	private void Start()
	{
		i = -1;
		Invoke("spawn", 3f);
	}
	
	private void Update()
	{
	}
	
	private void spawn()
	{
		float time = UnityEngine.Random.Range(0.5f, 1f);
		float value = UnityEngine.Random.value;
		if (value < 0.7f)
		{
			time = 0.5f;
			i = UnityEngine.Random.Range(2, 6);
			y = -3.1f;
		}
		else if (value < 0.95f)
		{
			if (i != 0 && i != 1 && i != 6)
			{
				i = UnityEngine.Random.Range(0, 2);
				y = -3.69f;
			}
			else
			{
				i = UnityEngine.Random.Range(2, 6);
				y = -3.1f;
			}
		}
		else if (i != 0 && i != 1 && i != 6)
		{
			i = 6;
			y = -3.88f;
		}
		else
		{
			i = UnityEngine.Random.Range(2, 6);
			y = -3.1f;
		}
		if (i == 5)
		{
			y = -3.322f;
		}
		UnityEngine.Object.Instantiate(this.benda[this.i], new Vector3(base.transform.localPosition.x, this.y, base.transform.localPosition.z), base.transform.localRotation);
		base.Invoke("spawn", time);
	}
}
