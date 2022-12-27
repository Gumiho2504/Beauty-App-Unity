using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator DrawingBar,Profile;
    public void OpenDrawingBar()
    {
        DrawingBar.Play("OpenDrawingBar");
    }
    public void CloseDrawingBar()
    {
        DrawingBar.Play("CloseDrawingBar");
    }
    public void OpenProfile()
    {
        Profile.Play("OpenProfile");
    }
    public void CloseProfile()
    {
        Profile.Play("CloseProfile");
    }
}
