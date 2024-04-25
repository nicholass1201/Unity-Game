using UnityEngine;

public class Points : MonoBehaviour
{
   public Transform locationPointIcon;
   public float minimumDistance = 400.0f; // Minimum distance between point A and point B
   public float minimumDistanceA = 100.0f; // Minimum distance between point and camera
   public Light startBeacon;
   public Light endBeacon;
   public Timer timer;
   private Transform[] pointIcons = new Transform[2];
   private Vector3[] fixedPoints = new Vector3[]
    {
        new Vector3(130, 2, 165),
        new Vector3(30, 2, 124),
        new Vector3(83, 2, -174),
        new Vector3(67, 2, 185),
        new Vector3(51, 2, 103),
        new Vector3(30, 2, -107),
        new Vector3(83, 2, -563),
        new Vector3(376, 2, 176),
        new Vector3(220, 2, 243),
        new Vector3(259, 2, -166),
        new Vector3(216, 2, -343),
        new Vector3(-158, 2, 78),
        new Vector3(-158, 2, 297),
        new Vector3(-112, 2, 211),
        new Vector3(-223, 2, -52),
        new Vector3(-223, 2, -227)
   };

   public void Start()
   {
      SpawnRandomPoints();
   }

   public void Update()
   {
      if (Spin.activeSpinCount == 0)
      {
         SpawnRandomPoints();
         Spin.activeSpinCount = 2;
         timer.resetTimer();
      }
   }

   void SetLocationPoint(Vector3 point, ref Transform icon, Light beacon)
   {
      // Check if the icon already exists, update its position; if not, instantiate it
      if (icon != null)
      {
         icon.position = point; // Update position if already instantiated
         icon.gameObject.SetActive(true);
         beacon.transform.position = new Vector3(point.x, point.y + 325, point.z);
      }
      else
      {
         icon = Instantiate(locationPointIcon, point, Quaternion.identity);
         icon.gameObject.SetActive(true);
         beacon.transform.position = new Vector3(point.x, point.y + 325, point.z);
      }
   }

   void SpawnRandomPoints()
   {
      // Randomly pick two distinct indices
      int indexA = Random.Range(0, fixedPoints.Length);
      int indexB = Random.Range(0, fixedPoints.Length);
      while (indexB == indexA) // Ensure indexB is different from indexA
      {
         indexB = Random.Range(0, fixedPoints.Length);
      }

      // Set the points
      SetLocationPoint(fixedPoints[indexA], ref pointIcons[0], startBeacon);
      SetLocationPoint(fixedPoints[indexB], ref pointIcons[1], endBeacon);
   }
}