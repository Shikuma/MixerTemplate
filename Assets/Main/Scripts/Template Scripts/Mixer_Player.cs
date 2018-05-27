using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer_Player {

	public string playerName;
	public int currentScore;
	public int overallScore;

	public Mixer_Player(string playerName) {
		this.playerName = playerName;
		currentScore = 0;
		overallScore = 0;
	}
}
