using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.IMGUI.Controls
{
	internal interface ITreeViewDragging
	{
		bool drawRowMarkerAbove
		{
			get;
			set;
		}

		void OnInitialize();

		bool CanStartDrag(TreeViewItem targetItem, List<int> draggedItemIDs, Vector2 mouseDownPosition);

		void StartDrag(TreeViewItem draggedItem, List<int> draggedItemIDs);

		bool DragElement(TreeViewItem targetItem, Rect targetItemRect, int row);

		void DragCleanup(bool revertExpanded);

		int GetDropTargetControlID();

		int GetRowMarkerControlID();
	}
}
