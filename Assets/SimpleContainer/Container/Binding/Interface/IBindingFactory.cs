﻿/**
 * This file is part of SimpleContainer.
 *
 * Licensed under The MIT License
 * For full copyright and license information, please see the MIT-LICENSE.txt
 * Redistributions of files must retain the above copyright notice.
 *
 * @copyright Joey1258
 * @link https://github.com/joey1258/SimpleContainer_For_Unity
 * @license http://www.opensource.org/licenses/mit-license.php MIT License
 */

using System;

namespace SimpleContainer.Container
{
    public interface IBindingFactory
    {
        /// <summary>
        /// binding 数组
        /// </summary>
        IBinding[] bindings { get; }

        #region Create default (MANY)

        /// <summary>
        /// 创建并返回指定类型的Binding实例，ConstraintType 为 MULTIPLE
        /// </summary>
        IBinding Create<T>(BindingType bindingType);

        /// <summary>
        /// 创建并返回指定类型的Binding实例，ConstraintType 为 MULTIPLE
        /// </summary>
        IBinding Create(Type type, BindingType bindingType);

        #endregion

        #region Create SINGLE

        /// <summary>
        /// 创建并返回指定类型的Binding实例，ConstraintType 为 SINGLE
        /// </summary>
        IBinding CreateSingle<T>(BindingType bindingType);

        /// <summary>
        /// 创建并返回指定类型的Binding实例，ConstraintType 为 SINGLE
        /// </summary>
        IBinding CreateSingle(Type type, BindingType bindingType);

        #endregion

        /// <summary>
        /// 创建指定类型的多个 Binding 实例，ConstraintType 为 MULTIPLE，并返回 IBindingFactory
        /// </summary>
        IBindingFactory MultipleCreate(Type[] types, BindingType[] bindingType);

        #region Binding System Function

        /// <summary>
        /// 为多个 binding 添加值,如果参数长度短于 binding 数量，参数的最后一个元素将被重复使用
        /// </summary>
        IBindingFactory To(object[] os);

        /// <summary>
        /// 设置多个 binding 的 id 属性
        /// </summary>
        IBindingFactory As(object[] os);

        /// <summary>
        /// 设置多个 binding 的 condition 属性
        /// 如果参数长度短于 binding 数量，参数的最后一个元素将被重复使用
        /// </summary>
        IBindingFactory When(Condition[] cs);

        /// <summary>
        /// 设置多个 binding 的 condition 属性为 context.parentType 与指定类型相等
        /// 如果参数长度短于 binding 数量，参数的最后一个元素将被重复使用
        /// </summary>
        IBindingFactory Into(Type[] ts);

        /// <summary>
        /// 返回一个新的Binding实例，并设置指定类型给 type, BindingType 为 ADDRESS，值约束为 MULTIPLE
        /// </summary>
        IBinding Bind<T>();

        /// <summary>
        /// 返回一个新的Binding实例，并设置指定类型给 type, BindingType 为 SINGLETON，值约束为 SINGLE
        /// </summary>
        IBinding BindSingleton<T>();

        /// <summary>
        ///  返回一个新的Binding实例，并设置指定类型给 type 属性和 BindingType 属性为 FACTORY，值约束为 SINGLE
        /// </summary>
        IBinding BindFactory<T>();

        /// <summary>
        /// 创建多个指定类型的 binding，并返回 IBindingFactory
        /// </summary>
        IBindingFactory MultipleBind(Type[] types, BindingType[] bindingTypes);

        #endregion
    }
}