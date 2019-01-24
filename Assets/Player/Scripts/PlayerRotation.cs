﻿using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private void LateUpdate()
    {
       AimMouse();
    }
    void AimMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y
            );
        transform.up = direction;
    }
}
