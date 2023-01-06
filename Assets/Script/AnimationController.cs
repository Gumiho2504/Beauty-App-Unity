using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator DrawingBar,Profile,SearchScreen,ShoppingCartScreen;
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
    public void OpenSearchScreen()
    {
        SearchScreen.Play("OpenSearchScreen");
    }
    public void CloseSearchScreen()
    {
        SearchScreen.Play("CloseSearchScreen");
    }
    public void OpenShoppingCartScreen()
    {
        ShoppingCartScreen.Play("Open");
    }
    public void CloseShoppingCartScreen()
    {
        ShoppingCartScreen.Play("Close");
    }
}
