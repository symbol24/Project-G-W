using UnityEngine;
using System.Collections;

public static class Control {

	public static KeyCode right = KeyCode.RightArrow;

	public static KeyCode left = KeyCode.LeftArrow;

	public static KeyCode space = KeyCode.Space;

	public static KeyCode up = KeyCode.UpArrow;
	
	public static bool getKeyRight(){
		return Input.GetKey(right);
	}

	public static bool getKeyLeft(){
		return Input.GetKey(left);
	}

	public static bool getKeySpace() {
		return Input.GetKey(space);
	}

    public static bool getKeyDownRight()
    {
        return Input.GetKeyDown(right);
    }
    public static bool getKeyDownLeft()
    {
        return Input.GetKeyDown(left);
    }

    public static bool getKeyDownSpace()
    {
        return Input.GetKeyDown(space);
    }

}
