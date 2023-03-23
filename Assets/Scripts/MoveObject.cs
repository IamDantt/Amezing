using UnityEngine;

public class MoveObject : MonoBehaviour
{
   public float speed = 5f; // La velocidad a la que se moverá el objeto

   public GameObject BoxPrefab; 

   [SerializeField] private float leftBound = -10f; // El punto en el que el objeto debe reaparecer en el lado izquierdo de la pantalla

    void Update()
    {
        // Mueve el objeto hacia la izquierda a la velocidad especificada
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Si el objeto ha alcanzado el punto de reaparición, lo reposiciona en el lado derecho de la pantalla
        if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(10f, transform.position.y, transform.position.z);

            if (leftBound > -15f && leftBound < 15f)
            {
                // Instancia el prefab en la posición deseada
                Instantiate(BoxPrefab, new Vector3(7f, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
    }



}
