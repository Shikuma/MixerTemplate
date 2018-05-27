using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer_Button : MonoBehaviour {

	
	public int scene;
	public Mixer_Player player;

	public Mixer_Button(Mixer_Player player, int width, int height) {
		this.player = player;
		
	}

	public Mixer_Button(Mixer_Player player) {
		this.player = player;
	}
}
