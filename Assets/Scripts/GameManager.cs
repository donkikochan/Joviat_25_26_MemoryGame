using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabToken;
    
    public int rows = 4;
    public int cols = 4;
    public float spacing = 2f; // Espacio entre tokens

    private GameObject[,] tokens; // Array 2D para guardar los tokens


    private int numTokensOpened;
    private string token1Name;
    private string token2Name;
    void Start()
    {
        numTokensOpened = 0;
        tokens = new GameObject[rows, cols];

        // Coordenada inicial (puedes ajustarla según tu escena)
        Vector3 startPos = new Vector3(-((cols - 1) * spacing) / 2, 0, ((rows - 1) * spacing) / 2 );

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Vector3 pos = startPos + new Vector3(j * spacing * 1.25f, 0, -i * spacing );
                GameObject o = Instantiate(prefabToken, pos, Quaternion.identity);
                o.name = $"Token_{i}_{j}";
                tokens[i, j] = o;
            }
        }
    }

    public void TokenPressed(string name)
    {
        if (numTokensOpened < 2)
        {
            if (numTokensOpened == 0)
            {
                token1Name = name;
                //dir-li al token que es mostri
            }
            else if (numTokensOpened == 1)
            {
                if (token1Name == name)
                {
                    return;
                }
                token2Name = name;
                
            }
            
            int i, j; ////a partir del nom obtenim els valors de i,j
            string[] parts = name.Split('_');
            i = int.Parse(parts[1]);
            j = int.Parse(parts[2]);
            tokens[i,j].GetComponent<Token>().ShowToken();
            
            numTokensOpened++;
            Debug.Log("Tokens opened: " + numTokensOpened);
            
            
        }
        

        //si hem obert dos tokens aleshores posar timer en marxa:
        Invoke("CheckTokens", 2.0f);
       
        
    }

    public void CheckTokens()
    {
        
    }
   
    public void Update()
    {
       
       
    }
    
    
}