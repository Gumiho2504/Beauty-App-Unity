using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class ProdutController : MonoBehaviour
{
    [SerializeField] private Sprite[] wigsSprite;
    [SerializeField] private Image[] wigsImage;
    [SerializeField] Button[] wigsButton;
    GameObject wig;
    struct Product
    {
        public string name;
        public int id;
        public float price;
    }

    Product[] product =  { new Product(), new Product(), new Product(), new Product(), new Product() };
    
    
    // Start is called before the first frame update
    void Start()
    {
        product[0].id = 1;
        product[0].name = "Green wigs";
        product[0].price = 120;
        for(int i = 0; i < wigsSprite.Length; i++)
        {
            wigsImage[i].sprite = wigsSprite[i];
            product[i].id = i;
            product[i].name = wigsSprite[i].name;
            print(product[i].name);
            print(product[i].id);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
