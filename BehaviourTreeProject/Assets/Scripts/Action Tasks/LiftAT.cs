using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class LiftAT : ActionTask {

		public BBParameter<bool> boxHeld;
        public Animator animator;
		public BBParameter<GameObject> liftObject;
		public BBParameter<GameObject> parentObject;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			animator.SetTrigger("Raise"); //start the raise arms animation
            animator.ResetTrigger("Lower");

            liftObject.value = GameObject.FindAnyObjectByType<Box>().gameObject; //find a box in the scene

            liftObject.value.GetComponent<Rigidbody>().useGravity = false; //turn off gravity for the box
            liftObject.value.transform.parent = parentObject.value.transform; //make box a child of the arms

            EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}