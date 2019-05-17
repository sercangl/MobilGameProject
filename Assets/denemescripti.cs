using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class denemescripti : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Time.time >= 0)
        {
            movv();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void movv()
    {



        DOTween.Sequence()
              .Append(
                transform.DOMoveX(-5, 1)
                     .SetEase(Ease.Linear)


                    )
                 .Append(
                    transform.DOMoveX(5, 2)
                      .SetEase(Ease.Linear)


                    )
                 .Append(
                    transform.DOMoveX(0, 1)
                      .SetEase(Ease.Linear)

                    )
                 .SetEase(Ease.Linear)
                .SetLoops(-1);


    }
}
