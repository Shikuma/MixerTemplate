using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer_Control {

	string controlID, kind, text, toolTip;
	int keyCode, cost, coolDown, gamePadButton;
	bool disabled;
	Position position;

	public Mixer_Control(Position position, string controlID, string kind, string text, string toolTip, int keyCode, int cost, int coolDown, int gamePadButton, bool disabled) {
		this.position = position;
		this.controlID = controlID;
		this.kind = kind;
		this.text = text;
		this.toolTip = toolTip;
		this.keyCode = keyCode;
		this.cost = cost;
		this.coolDown = coolDown;
		this.gamePadButton = gamePadButton;
		this.disabled = disabled;
	}

	//Less cluttered constructor, only the necessities
	public Mixer_Control(Position position, string controlID, string kind, int gamePadButton, bool disabled) {
		this.position = position;
		this.controlID = controlID;
		this.kind = kind;
		this.gamePadButton = gamePadButton;
		this.disabled = disabled;
	}

	public Position GetPosition() {
		return position;
	}
}
