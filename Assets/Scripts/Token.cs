using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject o = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = o.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        gameManager.TokenPressed(gameObject.name);
    }

    public void ShowToken()
    {
        transform.Rotate(Vector3.right, 180);
    }
    
    public void HideToken()
    {
        transform.Rotate(Vector3.right, -180);
    }
    
    public void MatchToken()
    {
        Destroy(gameObject);
    }
}
