using UnityEngine;
using System.Collections;

public class Listener : MonoBehaviour
{
	//Reference to gloabl Notifications Manager
	public NotificationsManager Notifications = null;
	public GameObject obj = null;

	// Use this for initialization
	void Start () 
	{
		//Register this object as a listener for keyboard notifications
		if(Notifications!=null)
			Notifications.AddListener(this, "OnKeyboardInput2");
	}

	//This function will be called by the NotificationsManager when keyboard events occur
	public void OnKeyboardInput(Component Sender)
	{
		//Print to console
		Debug.Log("Keyboard Event Occurred on " + obj.name);
	}

	public void OnKeyboardInput2(Component Sender)
	{
		Debug.Log (Sender.name);
		obj.transform.Translate(new Vector3(1,1,0) * Time.deltaTime * 5);
	}
}
