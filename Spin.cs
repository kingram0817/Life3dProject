using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float number = 0;
    float rotSpeed = 0;

    void Update()
    {
        transform.Rotate(0, 0, rotSpeed);
        switch (number)
        {
            case 10:
                this.rotSpeed *= 0.989f;
                break;
            case 9:
                this.rotSpeed *= 0.99f;
                break;
            case 8:
                this.rotSpeed *= 0.9873f;
                break;
            case 7:
                this.rotSpeed *= 0.9871f;
                break;
            case 6:
                this.rotSpeed *= 0.987f;
                break;
            case 5:
                this.rotSpeed *= 0.9868f;
                break;
            case 4:
                this.rotSpeed *= 0.9866f;
                break;
            case 3:
                this.rotSpeed *= 0.9864f;
                break;
            case 2:
                this.rotSpeed *= 0.9862f;
                break;
            case 1:
                this.rotSpeed *= 0.986f;
                break;
        }

    }

    public void SpinWheel()
    {
        number = Random.Range(1, 10);
        rotSpeed = 35;
    }


}
