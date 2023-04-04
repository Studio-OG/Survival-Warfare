using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairCurser : MonoBehaviour
{
    public Texture2D CursorImage;

    void Start()
    {
        Cursor.visible = true;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 1.0f;
        transform.position = position;
        Cursor.SetCursor(CursorImage, Vector2.zero, CursorMode.ForceSoftware);
    }


}


