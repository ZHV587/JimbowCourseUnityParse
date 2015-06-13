﻿using UnityEngine;
using System.Collections;

public class JCRescouceManager : MonoBehaviour {
	static public JCRescouceManager instance;

	[SerializeField] Sprite Background;
	[SerializeField] Sprite CheckMark;
	[SerializeField] Sprite Knob;

	public Sprite spriteByName(string name){
		switch(name){
		case"Background":return Background;
		case"CheckMark":return CheckMark;
		case"Knob":return Knob;
		default:return Knob;
		}
	}
	void Awake(){
		instance=this;
	}
}
