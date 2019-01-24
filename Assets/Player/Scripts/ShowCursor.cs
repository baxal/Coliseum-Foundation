using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour
{
    int flag = 0;
    public void Update()
    {        
        if(Cursor.visible == false && flag == 0)
        {
            Cursor.visible = true;
            flag = 1;
        }else if(Cursor.visible == true && flag == 1)
        {
            Cursor.visible = false;
            flag = 0;
        }
    }
}
