using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI label;
    [SerializeField] private TextMeshProUGUI labelBtn;
    // Start is called before the first frame update
    void Start()
    {
        label.text = "Hola món";
        labelBtn.text = "Press me";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void onClickButton()
    {
        Debug.Log("Hola món");
        SceneManager.LoadScene("GameScene");
    }

    public void onValueChange(string value)
    {
        Debug.Log("el contingut és:"+ value);
    }
    
    public void onValueChange2()
    {
        Debug.Log("el contingut és:");
    }
    
    public void OnToogleClicked(bool flag)
    {
        if (flag)
        {
            Debug.Log("click ");    
        }
        
    }
}
