using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypad : MonoBehaviour
{
    [SerializeField] private Text ans;
    private string answer = "1999";
    public GameObject box;
   public GameObject key;
    public GameObject a;
    public  static float no;
    public static float ll;
    
    
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
          
        
    }
   public void number(int number)
    {
        ans.text += number.ToString();
    }

    public void execute()
    {
        if (ans.text == answer)
        {
            box.SetActive(false);
            key.SetActive(false);
            a.SetActive(false);
            
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            no = 0;
            ll = 1;
        }
        else
        {
           
           
            ans.text = "";
            
               // ans.text = "";
            
            
                a.SetActive(false);

            no = 1;
        }
    }
    public void reset()
    {
        ans.text = "";
    }
}
