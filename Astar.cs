using System;
using System.Collections.Generic;

namespace Test3
{
	public class AstarNode
	{
		public bool isWall;
		public AstarNode ParentNode;

		public int x, y, G, H;
		public int F
		{
			get { return G + H ;}
		}
		public AstarNode(bool isWall, int x, int y)
		{
			this.isWall = isWall;
			this.x = x;
			this.y = y;
		}
	}
	public class Astar
	{
		private AstarNode[,] nodes;
		private AstarNode startNode;
		private AstarNode endNode;
		private AstarNode currentNode;
		private List<AstarNode> openList = new List<AstarNode>();
		private List<AstarNode> closeList = new List<AstarNode>();

		public int Solution(int[,] maps)
		{
			CreateNode(maps);
			SetTargetLocation(maps);
			PathFinding();

			if (openList.Count == 0)
				return -1;
			return closeList.Count;
		}

		public void SetTargetLocation(int[,] maps)
		{
			startNode = nodes[0,0];
			endNode = nodes[maps.GetLength(1) - 1, maps.GetLength(0) - 1];
		}

		public void CreateNode(int[,] maps)
		{
			nodes = new AstarNode[maps.GetLength(1), maps.GetLength(0)];

			for (int x = 0; x < maps.GetLength(1); x++)
			{
				for (int y = 0; y < maps.GetLength(0); y++)
				{
					if (maps[x,y] == 1)
					{
						bool isWall = false;
						nodes[x,y] = new AstarNode(isWall, x, y);
					}
					else
					{
						bool isWall = true;
						nodes[x,y] = new AstarNode(isWall, x, y);
					}
				}
			}
		}

		public void PathFinding()
		{
			openList.Clear();
			closeList.Clear();

			openList.Add(startNode);

			while (openList.Count > 0)
			{
				currentNode = openList[0];
				for (int i = 1; i < openList.Count; ++i)
				{
					if (openList[i].F <= currentNode.F && openList[i].H < currentNode.H)
						currentNode = openList[i];
				}

				openList.Remove(currentNode);
				closeList.Add(currentNode);

				if (currentNode == endNode)
				{
					return ;
				}

				OpenListAdd(currentNode.x, currentNode.y + 1);
				OpenListAdd(currentNode.x + 1, currentNode.y);
				OpenListAdd(currentNode.x, currentNode.y - 1);
				OpenListAdd(currentNode.x - 1, currentNode.y);
			}
		}

		public void OpenListAdd(int checkx, int checky)
		{
			if (checkx < 0 || checkx >= nodes.GetLength(0) || checky < 0 || checky >= nodes.GetLength(1))
				return ;
			
			if (closeList.Contains(nodes[checkx, checky]))
				return ;

			if (nodes[checkx, checky].isWall)
				return ;

			AstarNode NeighborNode = nodes[checkx, checky];
			int moveCost = currentNode.G + (currentNode.x - checkx == 0 || currentNode.y - checky == 0 ? 10 : 14);

			if (moveCost < NeighborNode.G || !openList.Contains(NeighborNode))
			{
				NeighborNode.G = moveCost;
				NeighborNode.H = ((int)MathF.Abs(NeighborNode.x - endNode.x) + (int)MathF.Abs(NeighborNode.y - endNode.y)) * 10;

				NeighborNode.ParentNode = currentNode;

				openList.Add(NeighborNode);
			}
		}
	}
}