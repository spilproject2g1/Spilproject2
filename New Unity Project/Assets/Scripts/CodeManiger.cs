using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeManiger : MonoBehaviour
{
    public int code1,code2,code3 = 0;

    public Text[] numbers;

    public void UpdateCode(int _number)
    {
        switch (_number)
        {
            case 1:
                    code1++;
                break;
            case -1:
                    code1--;
                break;
            case 2:
                    code2++;
                break;
            case -2:
                    code2--;
                break;
            case 3:
                    code3++;                
                break;
            case -3:
                    code3--;
                break;
            default:
                break;
        }
        numbers[0].text = code1.ToString();
        numbers[1].text = code2.ToString();
        numbers[2].text = code3.ToString();
    }
}
