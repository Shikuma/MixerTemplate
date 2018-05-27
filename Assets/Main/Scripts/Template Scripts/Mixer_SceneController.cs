using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer_SceneController : MonoBehaviour {

	//
	[SerializeField]
	private int objectsPerRow, objectsPerColumn, objectWidth, objectHeight;

	private List<Mixer_Scene> allScenes;

	// Use this for initialization
	void Start () {
		allScenes = new List<Mixer_Scene>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Create list of dynamic scenes
	public List<Mixer_Scene> CreateDynamicScenes(int objectsPerRow, int objectsPerColumn, int objectWidth, int objectHeight, bool isFull) {
		List<Mixer_Scene> scenes = new List<Mixer_Scene>();
		Mixer_Scene firstScene = new Mixer_Scene(0, objectsPerRow, objectsPerColumn, objectWidth, objectHeight, 0, false);
		scenes.Add(firstScene);
		allScenes.Add(firstScene);
		firstScene.id = allScenes.Count - 1;
		return scenes;
	}

	public Mixer_Scene CreateStaticScene(int objectsPerRow, int objectsPerColumn, int objectWidth, int objectHeight, bool isFull) {
		Mixer_Scene scene = new Mixer_Scene(0, objectsPerRow, objectsPerColumn, objectWidth, objectHeight, 0, false);
		allScenes.Add(scene);
		scene.id = allScenes.Count-1;
		return scene;
	}

	public Mixer_Scene BlankSCene() {
		Mixer_Scene scene = new Mixer_Scene(0);
		allScenes.Add(scene);
		scene.id = allScenes.Count - 1;
		return scene;
	}

	//Use this method to add onto dynamically created scenes
	public void AddDynamicObject(List<Mixer_Scene> scenes, Mixer_Control thisObject) {
		foreach(Mixer_Scene scene in scenes) {
			int maxObjects = scene.objectsPerColumn * scene.objectsPerRow;
			if (scene.currObjectCount < maxObjects) {
				int objectNum = ++scene.currObjectCount;
				int yPos = (scene.currObjectCount / objectsPerRow) + 1;
				int xPos = (scene.currObjectCount % objectsPerRow);
				//Finish setting position based on scene size
				
			}else {
				continue;
			}
		}
	}

	public void AddDynamicObject(Mixer_Scene scene) {

	}
	

	//TODO

	//Create one scene

	//Create dynamic scenes by passing n number of objects

	//Add one object at a time to dynamic scenes


}
