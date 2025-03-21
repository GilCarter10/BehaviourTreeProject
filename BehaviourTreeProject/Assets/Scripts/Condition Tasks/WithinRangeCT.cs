using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class WithinRangeCT : ConditionTask {

        public BBParameter<Transform> targetTransform;
        public float arrivalDistance;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            //get the agent's distance to the target transform
			float distanceToTarget = Vector3.Distance(agent.transform.position, targetTransform.value.position); 

            return distanceToTarget < arrivalDistance; //true once the distance is less than the specified arrival distance
        }
	}
}