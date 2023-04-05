using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairCurser : MonoBehaviour
{
    public Texture2D MenuCurcorImage;
    public Texture2D GameCursorImage;

    bool IsStart = StartViewController.IsStarted();
    private bool IsStartedtemp = true;



    void Start()
    {
        Cursor.visible = true;
        Cursor.SetCursor(MenuCurcorImage, Vector2.zero, CursorMode.ForceSoftware);
    }
    // Update is called once per frame
    void Update()
    {
        IsStart = StartViewController.IsStarted();
        if (IsStart == true && IsStart != IsStartedtemp)
        {
            Cursor.SetCursor(GameCursorImage, Vector2.zero, CursorMode.ForceSoftware);
        }
        if (IsStart == false && IsStart != IsStartedtemp)
        {
            Cursor.SetCursor(MenuCurcorImage, Vector2.zero, CursorMode.ForceSoftware);
        }
        IsStartedtemp = IsStart;
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 1.0f;
        transform.position = position;

    }


}


