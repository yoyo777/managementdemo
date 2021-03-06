﻿
using System;
using System.Collections.Generic;
using Project.Model;
using Project.Dal;
using System.Data.SqlClient;
namespace Project.Bll
{
	///========================================================================
	/// Project: 权限系统	
	/// Copyright: Copyright (c) 2008
	/// Company: 
   	///========================================================================
	
	///Title: ArticleType类
	///Description: ArticleType业务逻辑操作类
	///@author xu
	///@version 1.0.0.0
	///@date 2012-9-21
	///@modify 
	///@date 
	/// </summary>
	public class ArticleTypeBll
	{
		private readonly ArticleTypeDal dal = new ArticleTypeDal();
		
		#region 基本方法
		
		/// <summary>
		/// 在dbo.ArticleType中新增一条记录,支持数据库事务
		/// </summary>
		/// <param name="model">包含被插入数据的实体对象</param>
		/// <param name="trans">事务参数，没有请填null</param>
		/// <returns>影响行数</returns>
		public int Insert(ArticleType model,SqlTransaction trans)
		{
            return dal.Insert(model, trans);
		}
		
		/// <summary>
		/// 在dbo.ArticleType表中完整更新一条记录,支持数据库事务
		/// </summary>
		/// <param name="model">包含被更新数据的实体对象</param>
		/// <param name="trans">事务参数，没有请填null</param>
		/// <returns>影响行数</returns>
		public int Update(ArticleType model,SqlTransaction trans)
		{
			return dal.Update(model,trans);	
		}
		
		/// <summary>
		/// 在dbo.ArticleType中删除一条记录,支持数据库事务
		/// </summary>
		/// <param name="id">主键</param>
		/// <param name="trans">事务参数，没有请填null</param>
		/// <returns>所影响的行数</returns>
		public int Delete(int id,SqlTransaction trans)
		{
			return dal.Delete(id,trans);	
		}
		
		
		/// <summary>
		/// 根据主键获取dbo.ArticleType中的一条记录
		/// </summary>
		/// <param name="id">主键id</param>
		/// <returns>实体模型</returns>
		public ArticleType  GetModel(int id)
		{
			return dal.GetModel(id);
		}
		#endregion
	}
}
