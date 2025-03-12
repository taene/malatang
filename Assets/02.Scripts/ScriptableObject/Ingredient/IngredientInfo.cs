using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class IngredientInfo
{
    public string ingredientName;   // 재료 이름
    public bool isSkewer; // 꼬치인지 아닌지 구분
    public float gram;  // 개당 그램(g)

    [TextArea(3, 5)]  // 인스펙터 정리 - 라인 수 늘려주는 속성. + Multiline(int)
    public string howToTrim;    // 손질하는 방법 설명
}
