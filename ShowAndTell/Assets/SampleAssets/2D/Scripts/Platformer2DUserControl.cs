using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private int jump = 0;
        public float speed = 1;
        private int wind = 0;
		private deathManager m_dManager;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
			m_dManager = GetComponent<deathManager>();
        }

        private void Update()
        {
            //if(!jump)
            // Read the jump input in Update so button presses aren't missed.
            //jump = CrossPlatformInputManager.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            //bool crouch = Input.GetKey(KeyCode.LeftControl);

            //float h = CrossPlatformInputManager.GetAxis("Horizontal");

            character.Move(speed, false, jump, wind);

            //speed = 0.2f;
            jump = 0;
            wind = 0;
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.tag == "Jump")
            {
                if ((character.facingRight && collider.GetComponent<Jump>().right) || (!character.facingRight && collider.GetComponent<Jump>().left))
                {
                    jump = 1;
					m_dManager.JumpCount();
                }
            }
            else if (collider.tag == "Flip")
            {
                speed *= -1;
                character.Flip();
            }
            else if (collider.tag == "Bounce")
            {
                jump = 3;
            }
            else if (collider.tag == "Death")
            {
                Debug.Log("Collided with Death");
                m_dManager.DeathCount();
            }
        }

        private void OnTriggerStay2D(Collider2D collider)
        {
            if (collider.tag == "Wind")
            {
                if (collider.GetComponent<Wind>().right)
                {
                    wind = 1;
                    if(speed < 0)
                    {
                        speed *= -1;
                    }
                    //speed = wind;
                }
                else if (collider.GetComponent<Wind>().left)
                {
                    wind = -1;
                    if (speed > 0)
                    {
                        speed *= -1;
                    }
                    //speed = wind;
                }
            }
        }
    }
}