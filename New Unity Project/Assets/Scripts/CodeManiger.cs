using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeManiger : MonoBehaviour
{
    int code1,code2,code3 = 0;
    public int rigtigKode = 000;
    public int maxNumber = 10, minNumber = 0;
    public Text[] numbers;

    public void UpdateCode(int _number)
    {
        switch (_number)
        {
            case 1:
                    code1++;
                if (code1>maxNumber)
                {
                    code1 = minNumber;
                }
                break;
            case -1:
                    code1--;
                if (code1 < minNumber)
                {
                    code1 = maxNumber;
                }
                break;
            case 2:
                    code2++;
                if (code2 > maxNumber)
                {
                    code2 = minNumber;
                }
                break;
            case -2:
                    code2--;
                if (code2 < minNumber)
                {
                    code2 = maxNumber;
                }
                break;
            case 3:
                    code3++;
                if (code3 > maxNumber)
                {
                    code3 = minNumber;
                }
                break;
            case -3:
                    code3--;
                if (code3 < minNumber)
                {
                    code3 = maxNumber;
                }
                break;
            default:
                break;
        }
        numbers[0].text = code1.ToString();
        numbers[1].text = code2.ToString();
        numbers[2].text = code3.ToString();
    }

    public void CheakCode()
    {
        if (code1*100+code2*10+code3==rigtigKode)
        {
            Debug.Log("rigtig code");
        }
        else
        {
            Debug.Log(code1 * 100 + code2 * 10 + code3);
        }

    }
}
