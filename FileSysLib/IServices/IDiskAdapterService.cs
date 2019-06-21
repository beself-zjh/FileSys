﻿using System;
using System.Collections.Generic;
using System.Text;
using FileSysLib.Models;

namespace FileSysLib.IServices {
    /// <summary>
    /// 提供磁盘读写服务，内含数据转换
    /// </summary>
    interface IDiskAdapterService {
        /// <summary>
        /// 写入超级块
        /// </summary>
        /// <param name="superblock">超级块对象</param>
        void WriteSuperBlock(SuperBlock superblock);

        /// <summary>
        /// 写入磁盘i节点
        /// </summary>
        /// <param name="diskInode">磁盘i节点对象</param>
        void WriteDiskInode(DiskInode diskInode, int index);

        /// <summary>
        /// 写入普通数据块
        /// </summary>
        /// <param name="dataBlock"></param>
        void WriteDataBlock(DataBlock dataBlock, int index);

        /// <summary>
        /// 读取超级块
        /// </summary>
        SuperBlock ReadSuperBlock();

        /// <summary>
        /// 读取i节点
        /// </summary>
        DiskInode ReaDiskInode(int index);

        /// <summary>
        /// 读取数据块
        /// </summary>
        DataBlock ReaDataBlock(int index);
    }
}