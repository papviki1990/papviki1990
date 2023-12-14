using UnityEngine;

class AutoResize : MonoBehaviour
{

    [SerializeField] float minSize = 0.2f, maxSize = 2;

    void Start()
    {
        Transform[] allChildren = GetComponentsInChildren<Transform>();


        Transform self = transform;
        foreach (Transform t in allChildren)
        {
            if (t == self) continue;
            {
                float size = Random.Range(minSize, maxSize);
                Vector3 sizeVector = Vector3.one * size;
                t.localScale = sizeVector;
            }

          
        }
    }

   

}

/*  using UnityEngine;    Gyerek objektumok sorba tétele

class ChildrenInLine : MonoBehaviour
{
  void Update()
  {
      Transform[] children = new Transform[transform.childCount];
      for (int i = 0; i < transform.childCount; i++)
      {
          children[i] = transform.GetChild(i);
      }

      Transform first = children[0];
      Transform last = children[^1];
      Vector3 firstPoint = first.position;
      Vector3 lastPoint = last.position;

      for (int i = 0; i < children.Length; i++)
      {
          Transform t = children[i];
          float rate = (float)i / (children.Length - 1);
          t.position = Vector3.Lerp(firstPoint, lastPoint, rate);
      }


  }
}
*/
