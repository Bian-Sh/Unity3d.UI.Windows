//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     You may simply edit this file to setup your behavior.
//     See more: https://github.com/chromealex/Unity3d.UI.Windows
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Components;
using System.Collections;
using UnityEngine.UI.Windows.Plugins.Analytics;

namespace ExampleProject.UI.Other.MainLoader {

	public class MainLoaderScreen : MainLoaderScreenBase {

		private ProgressComponent progress;

		public override void OnInit() {

			base.OnInit();

			this.progress = this.GetLayoutComponent<ProgressComponent>();

			User.instance.id = Random.Range(0, 500);
			this.FlowUserInfo();

		}

		public override void OnShowEnd() {

			base.OnShowEnd();

			this.progress.SetValue(0f);

			this.StartCoroutine(this.Loading());

		}

		private System.Collections.IEnumerator Loading() {

			var timer = 0f;
			while (timer < 1f) {

				timer += Time.deltaTime;

				this.progress.SetValue(timer);
				yield return 0;

			}

			this.progress.SetValue(timer);
			
			yield return new WaitForSeconds(this.progress.duration);

			this.FlowHideABTest();

		}

	}

}