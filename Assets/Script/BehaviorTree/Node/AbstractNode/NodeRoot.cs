﻿namespace BehaviorTree
{
    /// <summary>
    /// 节点超类
    /// </summary>
    public abstract class NodeRoot
    {
        /// <summary>
        /// 节点类型
        /// </summary>
        protected NodeType nodeType;
        /// <summary>
        /// 节点序列
        /// </summary>
        private int nodeIndex;

        public NodeRoot(NodeType nodeType)
        {
            this.nodeType = nodeType;
        }

        /// <summary>
        /// 执行节点抽象方法
        /// </summary>
        /// <returns>返回执行结果</returns>
        public abstract ResultType Execute();

        public int NodeIndex
        {
            get { return nodeIndex; }
            set { nodeIndex = value; }
        }
    }
}