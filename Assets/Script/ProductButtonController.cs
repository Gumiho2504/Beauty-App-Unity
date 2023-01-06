using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProductButtonController : MonoBehaviour
{
    [SerializeField] private GameObject wigs, eyelashes, lipstick, cream;
    [SerializeField] private Button wigsBtn,eyelahesBtn,lipstickBtn,creamBtn;
    [SerializeField] private Text wigsTxt,eyelahesTxt,lipstickTxt,creamTxt;
    private Color32 seletedColor = new Color32(228, 33, 117, 255) , nomalColor = new Color32(255, 210, 241, 255);

    public void WigsButton()
    {
        wigsBtn.image.color = seletedColor;
        eyelahesBtn.image.color = nomalColor;
        lipstickBtn.image.color = nomalColor;
        creamBtn.image.color = nomalColor;

        wigs.SetActive(true);
        eyelashes.SetActive(false);
        lipstick.SetActive(false);
        cream.SetActive(false);

        wigsTxt.color = seletedColor;
        eyelahesTxt.color = Color.gray;
        lipstickTxt.color = Color.gray;
        creamTxt.color = Color.gray;
    }
    public void CreamButton()
    {
        wigsBtn.image.color = nomalColor;
        eyelahesBtn.image.color = nomalColor;
        lipstickBtn.image.color = nomalColor;
        creamBtn.image.color = seletedColor;
        wigs.SetActive(false);
        eyelashes.SetActive(false);
        lipstick.SetActive(false);
        cream.SetActive(true);

        wigsTxt.color = Color.gray;
        eyelahesTxt.color = Color.gray;
        lipstickTxt.color = Color.gray;
        creamTxt.color = seletedColor;
    }
    public void EyelashesButton()
    {
        wigsBtn.image.color = nomalColor;
        eyelahesBtn.image.color = seletedColor;
        lipstickBtn.image.color = nomalColor;
        creamBtn.image.color = nomalColor;
        wigs.SetActive(false);
        eyelashes.SetActive(true);
        lipstick.SetActive(false);
        cream.SetActive(false);

        wigsTxt.color = Color.gray;
        eyelahesTxt.color = seletedColor;
        lipstickTxt.color = Color.gray;
        creamTxt.color = Color.gray;
    }
    public void LipstickButton()
    {
        wigsBtn.image.color = nomalColor;
        eyelahesBtn.image.color = nomalColor;
        lipstickBtn.image.color = seletedColor;
        creamBtn.image.color = nomalColor;
        wigs.SetActive(false);
        eyelashes.SetActive(false);
        lipstick.SetActive(true);
        cream.SetActive(false);

        wigsTxt.color = Color.gray;
        eyelahesTxt.color = Color.gray;
        lipstickTxt.color = seletedColor;
        creamTxt.color = Color.gray;
    }
    public void HomeBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}// end of class
