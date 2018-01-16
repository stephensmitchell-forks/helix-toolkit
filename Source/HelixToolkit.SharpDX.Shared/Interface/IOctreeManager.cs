﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOctreeManager.cs" company="Helix Toolkit">
//   Copyright (c) 2018 Helix Toolkit contributors
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
#if NETFX_CORE
namespace HelixToolkit.UWP
#else
namespace HelixToolkit.Wpf.SharpDX
#endif
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOctreeManager
    {
        /// <summary>
        /// 
        /// </summary>
        event EventHandler<IOctree> OnOctreeCreated;
        IOctree Octree { get; }
        bool Enabled { get; set; }
        bool RequestUpdateOctree { get; }
        OctreeBuildParameter Parameter { set; get; }
        bool AddPendingItem(IRenderable item);
        void ProcessPendingItems();
        void Clear();
        void RebuildTree(IEnumerable<IRenderable> items);
        void RemoveItem(IRenderable item);
        void RequestRebuild();
    }
}