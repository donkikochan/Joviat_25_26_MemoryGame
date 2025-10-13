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

    void Start()
    {
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
}