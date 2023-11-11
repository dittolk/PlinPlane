using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class LoadOnClick : MonoBehaviour
{
	private AudioSource naonieu;
	
	public void LoadScene(int level)
	{
		this.naonieu = base.GetComponent<AudioSource>();
		//base.StartCoroutine(this.lieur(level));
	}
	
	public void MainMenu(int menu)
	{
		Application.LoadLevel(menu);
	}
	
	public void end()
	{
		Application.Quit();
	}
	
	[DebuggerHidden]
	/*(private IEnumerator lieur(int gelo)
	{
		LoadOnClick.<lieur>c__Iterator0 <lieur>c__Iterator = new LoadOnClick.<lieur>c__Iterator0();
		<lieur>c__Iterator.gelo = gelo;
		<lieur>c__Iterator.<$>gelo = gelo;
		<lieur>c__Iterator.<>f__this = this;
		return <lieur>c__Iterator;
	}*/
	
	public void link()
	{
		Application.OpenURL("http://www.facebook.com/trois.studio");
	}
}
