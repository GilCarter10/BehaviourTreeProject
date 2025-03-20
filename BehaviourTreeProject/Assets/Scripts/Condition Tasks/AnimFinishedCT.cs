using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class AnimFinishedCT : ConditionTask {

		public Animator animator;
		public string animName;

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
            if (animator.GetCurrentAnimatorStateInfo(0).IsName(animName)) //get information on the specified animation state
            {
                if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) //if the animation is complete
                {
					return true;
                } else
				{
					return false;
				}
            } else
			{
				return false;
			}

		}
	}
}