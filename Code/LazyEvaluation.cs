using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyEvaluation : MonoBehaviour
{
    private IEnumerator<int> lazyFibonacci;

    void Start()
    {
        lazyFibonacci = LazyFibonacci();
        StartCoroutine(RequestFibonacciNumbers());
    }


    IEnumerator RequestFibonacciNumbers()
    {
        for (int i = 0; i < 10; i++)
        {

            Debug.Log($"Fibonacci {i + 1}: {GetNextFibonacci()}");
            
   
            yield return new WaitForSeconds(1f);
        }
    }

    int GetNextFibonacci()
    {
        lazyFibonacci.MoveNext();
        return lazyFibonacci.Current;
    }

    IEnumerator<int> LazyFibonacci()
    {
        int a = 0, b = 1;

        while (true)
        {
            yield return a; 
            int temp = a;
            a = b;
            b = temp + b; 
        }
    }
}
