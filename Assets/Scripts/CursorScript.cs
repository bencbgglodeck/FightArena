using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start ()
    {
        Cursor.visible = true;
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Cursor.visible = false;
        }
        else if (Input.GetMouseButtonUp(0) == true)
        {
            Cursor.visible = true;
        }
    }
}
