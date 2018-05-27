using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer_Scene {

	public List<Mixer_Button> buttons;
	public int id, objectsPerRow, objectsPerColumn, objectWidth, objectHeight, currObjectCount;
	public bool isOn, isFull;

	

	public Mixer_Scene(int id) {
		this.id = id;
		buttons = new List<Mixer_Button>();
		isOn = id == 0 ? true : false;
	}

	//Use this constructor for creating scenes with auto formatting objects
	public Mixer_Scene(int id, int objectsPerRow, int objectsPerColumn, int objectWidth, int objectHeight, int currObjectCount, bool isFull) {
		this.id = id;
		buttons = new List<Mixer_Button>();
		isOn = id == 0 ? true : false;
		this.objectsPerRow = objectsPerRow;
		this.objectsPerColumn = objectsPerColumn;
		this.objectWidth = objectWidth;
		this.objectHeight = objectHeight;
	}

	
}
