using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ChangePickupBoolAT : ActionTask {

        public BBParameter<bool> boxHeld;
		public bool newValue;
		public BBParameter<GameObject> liftObject;
        public Spawner spawner;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//the script sets the boxHeld bool to a new value
			if (newValue == true)
			{
				//box is now picked up
				boxHeld.value = newValue;
			} else
			{
                //box is now put down
                boxHeld.value = false;
                
				liftObject.value.transform.parent = null; //box has no parent
                liftObject.value.GetComponent<Rigidbody>().useGravity = true; //turn gravity back on 
                liftObject.value.GetComponent<Box>().SendOff(); //start the "SendOff" on the box script
                spawner.SpawnNewBox(); //spawn a new box from the spawner
            }
			
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