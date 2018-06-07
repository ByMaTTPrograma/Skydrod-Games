using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {
	
	public GameObject Mario;
	public GameObject Bowser;
	
	void OnMouseDown(){
		
		if(Input.GetMouseButtonDown(0)){
			if(Mario.activeSelf){
				
				Mario.SetActive (false);
				Bowser.SetActive (true);
				
			}else if(Bowser.activeSelf){
				
				Mario.SetActive (true);
				Bowser.SetActive (false);
				
			}
			
			
		}
		
	}
	
}
