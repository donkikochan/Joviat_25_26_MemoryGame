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
        if (numTokensOpened == 0)
        {
            token1Name = name;
            //dir-li al token que es mostri
            
            int i, j; ////a partir del nom obtenim els valors de i,j
            tokens[i,j].GetComponent<Token>().ShowToken();
            
            numTokensOpened++;
        }
        else if (numTokensOpened == 1)
        {
            token2Name = name;
            //dir-li al token que es mostri
            numTokensOpened++;
            //Cridar un timer a x segons per fer check o match
        }

       
        
    }
}