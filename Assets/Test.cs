using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�z�������������
        int[] array = new int[5];

        //�z��̊e�v�f�ɒl��������B
        array[0] = 10;
        array[1] = 20;
        array[2] = 40;
        array[3] = 70;
        array[4] = 90;
        

        //�z��̗v�f��S�ĕ\������
        for(int a = 0; a<5; a++)
        {
            Debug.Log(array[a]);
        }
        //�z��̗v�f��S�ċt���ɕ\������
        for(int b = 4; b>=0; b--)
        {
            Debug.Log(array[b]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
