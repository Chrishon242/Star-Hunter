using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour {
    public int width;
    public int length;
    public void Screenwidth(int setwidth)
    {
        width  = setwidth ;
    }

    public void Screenlength (int setlength)
    {
        length = setlength ;
    }



  public void SetRes()
    {
        Screen.SetResolution(width, length, false);
    }

}
