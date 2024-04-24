/*using UnityEngine;

public class Points : MonoBehaviour
{
   public Transform locationPointIcon;
   public float minimumDistance = 400.0f; // Minimum distance between point A and point B (adjust this value)
   public float minimumDistanceA = 50.0f;
   public Light startBeacon;
   public Light endBeacon;
   private Transform pointAIcon;
   private Transform pointBIcon;

   public float planeMinX = -500.0f; // Define your plane boundaries here
   public float planeMinZ = -500.0f;
   public float planeMaxX = 500.0f;
   public float planeMaxZ = 500.0f;
   public float raycastDistance = 35.0f; // Distance for raycast

   public void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Vector3 pointA, pointB;
         Vector3 cameraPosition = Camera.main.transform.position;

         do
         {
            Vector3 tempPointA = new Vector3(Random.Range(planeMinX, planeMaxX), 1, Random.Range(planeMinZ, planeMaxZ));
            Vector3 tempPointB = new Vector3(Random.Range(planeMinX, planeMaxX), 1, Random.Range(planeMinZ, planeMaxZ));
            float distanceToCamera = Vector3.Distance(tempPointA, cameraPosition);
            if (distanceToCamera >= minimumDistanceA && Vector3.Distance(tempPointA, tempPointB) >= minimumDistance)
            {
               RaycastHit hit;
               if (Physics.Raycast(tempPointA, Vector3.down, out hit, raycastDistance))
               {
                  if (hit.point.y > 0.2f) // Check if hit point is above ground level
                  {
                     continue; // Repeat the loop if on a building
                  }
               }
               pointA = tempPointA;
               pointB = tempPointB;
               if (pointAIcon != null)
               {
                  pointAIcon.gameObject.SetActive(true);
                  pointAIcon.transform.position = pointA;

               }
               else
               {
                  pointAIcon = Instantiate(locationPointIcon, pointA, Quaternion.identity);
               }
               if (pointBIcon != null)
               {
                  pointBIcon.gameObject.SetActive(true);
                  pointBIcon.transform.position = pointB;
               }
               else
               {
                  pointBIcon = Instantiate(locationPointIcon, pointB, Quaternion.identity);
               }
               break;
            }
         } while (true);

         startBeacon.transform.position = new Vector3(pointA.x, pointA.y + 175, pointA.z);
         endBeacon.transform.position = new Vector3(pointB.x, pointB.y + 175, pointB.z);
      }
   }
}*/
/*using UnityEngine;

public class Points : MonoBehaviour
{
  public Transform locationPointIcon;
  public float minimumDistance = 400.0f; // Minimum distance between point A and point B (adjust this value)
  public float minimumDistanceA = 50.0f;
  public Light startBeacon;
  public Light endBeacon;
  private Transform pointAIcon;
  private Transform pointBIcon;

  public float planeMinX = -500.0f; // Define your plane boundaries here
  public float planeMinZ = -500.0f;
  public float planeMaxX = 500.0f;
  public float planeMaxZ = 500.0f;
  public float raycastDistance = 35.0f; // Distance for raycast

  public void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Vector3 pointA, pointB;
      Vector3 cameraPosition = Camera.main.transform.position;

      do
      {
        Vector3 tempPointA = new Vector3(Random.Range(planeMinX, planeMaxX), 1, Random.Range(planeMinZ, planeMaxZ));
        Vector3 tempPointB = new Vector3(Random.Range(planeMinX, planeMaxX), 1, Random.Range(planeMinZ, planeMaxZ));
        float distanceToCamera = Vector3.Distance(tempPointA, cameraPosition);
        if (distanceToCamera >= minimumDistanceA && Vector3.Distance(tempPointA, tempPointB) >= minimumDistance)
        {
          RaycastHit hit;
          if (Physics.Raycast(tempPointA, Vector3.down, out hit, raycastDistance))
          {
            // Check if normal vector y-component is close to 1 (pointing upwards)
            if (Mathf.Abs(hit.normal.y) >= 0.9f)
            {
              pointA = tempPointA;
              pointB = tempPointB;
              if (pointAIcon != null)
              {
                pointAIcon.gameObject.SetActive(true);
                pointAIcon.transform.position = pointA;
              }
              else
              {
                pointAIcon = Instantiate(locationPointIcon, pointA, Quaternion.identity);
              }
              if (pointBIcon != null)
              {
                pointBIcon.gameObject.SetActive(true);
                pointBIcon.transform.position = pointB;
              }
              else
              {
                pointBIcon = Instantiate(locationPointIcon, pointB, Quaternion.identity);
              }
              break;
            }
          }
        }
      } while (true);

      startBeacon.transform.position = new Vector3(pointA.x, pointA.y + 175, pointA.z);
      endBeacon.transform.position = new Vector3(pointB.x, pointB.y + 175, pointB.z);
    }
  }
}*/
using UnityEngine;

public class Points : MonoBehaviour
{
   public Transform locationPointIcon;
   public float minimumDistance = 400.0f; // Minimum distance between point A and point B
   public float minimumDistanceA = 50.0f;
   public Light startBeacon;
   public Light endBeacon;
   private Transform pointAIcon;
   private Transform pointBIcon;

   public float planeMinX = -500.0f; // Define your plane boundaries here
   public float planeMinZ = -500.0f;
   public float planeMaxX = 500.0f;
   public float planeMaxZ = 500.0f;

   public void Start()
   {
      
   }

   public void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Vector3 pointA, pointB;
         Vector3 cameraPosition = Camera.main.transform.position;
         do
         {
            Vector3 tempPointA = new Vector3(Random.Range(planeMinX, planeMaxX), 2, Random.Range(planeMinZ, planeMaxZ));
            Vector3 tempPointB = new Vector3(Random.Range(planeMinX, planeMaxX), 2, Random.Range(planeMinZ, planeMaxZ));
            float distanceToCamera = Vector3.Distance(tempPointA, cameraPosition);
            if (distanceToCamera >= minimumDistanceA && Vector3.Distance(tempPointA, tempPointB) >= minimumDistance)
            {
               pointA = tempPointA;
               pointB = tempPointB;
               if (pointAIcon != null)
               {
                  pointAIcon.gameObject.SetActive(true);
                  pointAIcon.transform.position = pointA;
               }
               else
               {
                  pointAIcon = Instantiate(locationPointIcon, pointA, Quaternion.identity);
               }
               if (pointBIcon != null)
               {
                  pointBIcon.gameObject.SetActive(true);
                  pointBIcon.transform.position = pointB;
               }
               else
               {
                  pointBIcon = Instantiate(locationPointIcon, pointB, Quaternion.identity);
               }
               break;
            }
         } while (true);
         startBeacon.transform.position = new Vector3(pointA.x, pointA.y + 175, pointA.z);
         endBeacon.transform.position = new Vector3(pointB.x, pointB.y + 175, pointB.z);
      }
   }
}