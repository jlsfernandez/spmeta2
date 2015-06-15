﻿using SPMeta2.Definitions;
using SPMeta2.Definitions.Base;
using SPMeta2.Models;
using SPMeta2.Services.Impl;
using SPMeta2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SPMeta2.Syntax.Default
{
    /// <summary>
    /// Initial entry to start model build up process.
    /// </summary>
    public static class SPMeta2Model
    {
        #region static

        static SPMeta2Model()
        {
            RegisterKnownDefinition(typeof(FieldDefinition).Assembly);
        }

        #endregion

        #region farm

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty model".
        /// Model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// </summary>
        /// <returns></returns>
        public static FarmModelNode NewFarmModel()
        {
            return NewFarmModel((FarmDefinition)null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty model".
        /// Model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// Use action to get access to the "model node" and construct model tree.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static ModelNode NewFarmModel(Action<FarmModelNode> action)
        {
            return NewFarmModel(new FarmDefinition { RequireSelfProcessing = false }, action);
        }


        /// <summary>
        /// Creates a new instance of the ModelNode adding model provided.
        /// If RequireSelfProcessing set as 'true', then model is going to be processed and pushed by SPMeta2 API.
        /// </summary>
        /// <param name="farmDefinition"></param>
        /// <returns></returns>
        public static FarmModelNode NewFarmModel(FarmDefinition farmDefinition)
        {
            return NewFarmModel(farmDefinition, null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding model provided.
        /// If RequireSelfProcessing set as 'true', then site model is going to be processed and pushed by SPMeta2 API.
        /// Use action to get access to the "model node" and construct model tree.
        /// </summary>
        /// <param name="farmDefinition"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static FarmModelNode NewFarmModel(FarmDefinition farmDefinition, Action<FarmModelNode> action)
        {
            return NewModelNode<FarmDefinition, FarmModelNode>(farmDefinition, action);

        }

        #endregion

        #region web applications


        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty model".
        /// Model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// </summary>
        /// <returns></returns>
        public static WebApplicationModelNode NewWebApplicationModel()
        {
            return NewWebApplicationModel((WebApplicationDefinition)null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty model".
        /// Model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// Use action to get access to the "model node" and construct model tree.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static WebApplicationModelNode NewWebApplicationModel(Action<WebApplicationModelNode> action)
        {
            return NewWebApplicationModel(new WebApplicationDefinition { RequireSelfProcessing = false }, action);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding model provided.
        /// If RequireSelfProcessing set as 'true', then model is going to be processed and pushed by SPMeta2 API.
        /// </summary>
        /// <param name="webApplicationDefinition"></param>
        /// <returns></returns>
        public static WebApplicationModelNode NewWebApplicationModel(WebApplicationDefinition webApplicationDefinition)
        {
            return NewWebApplicationModel(webApplicationDefinition, null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding model provided.
        /// If RequireSelfProcessing set as 'true', then site model is going to be processed and pushed by SPMeta2 API.
        /// Use action to get access to the "model node" and construct model tree.
        /// </summary>
        /// <param name="webApplicationDefinition"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static WebApplicationModelNode NewWebApplicationModel(WebApplicationDefinition webApplicationDefinition, Action<WebApplicationModelNode> action)
        {
            return NewModelNode<WebApplicationDefinition, WebApplicationModelNode>(webApplicationDefinition, action);

        }

        #endregion

        #region sites



        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty site model".
        /// Site model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// </summary>
        /// <returns></returns>
        public static SiteModelNode NewSiteModel()
        {
            return NewSiteModel((SiteDefinition)null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty site model".
        /// Site model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// Use action to get access to the "site model node" and construct model tree.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static SiteModelNode NewSiteModel(Action<SiteModelNode> action)
        {
            return NewSiteModel(new SiteDefinition { RequireSelfProcessing = false }, action);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding site model provided.
        /// If RequireSelfProcessing set as 'true', then site model is going to be processed and pushed by SPMeta2 API.
        /// </summary>
        /// <param name="siteDefinition"></param>
        /// <returns></returns>
        public static SiteModelNode NewSiteModel(SiteDefinition siteDefinition)
        {
            return NewSiteModel(siteDefinition, null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding site model provided.
        /// If RequireSelfProcessing set as 'true', then site model is going to be processed and pushed by SPMeta2 API.
        /// Use action to get access to the "site model node" and construct model tree.
        /// </summary>
        /// <param name="siteDefinition"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static SiteModelNode NewSiteModel(SiteDefinition siteDefinition, Action<SiteModelNode> action)
        {
            return NewModelNode<SiteDefinition, SiteModelNode>(siteDefinition, action);
        }

        #endregion

        #region webs

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty web model".
        /// Web model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// </summary>
        /// <returns></returns>
        public static WebModelNode NewWebModel()
        {
            return NewWebModel((WebDefinition)null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding web model provided.
        /// If RequireSelfProcessing set as 'true', then web model is going to be processed and pushed by SPMeta2 API.
        /// </summary>
        /// <param name="webDefinition"></param>
        /// <returns></returns>
        public static WebModelNode NewWebModel(WebDefinition webDefinition)
        {
            return NewWebModel(webDefinition, null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty web model".
        /// Web model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// Use action to get access to the "site model node" and construct model tree.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static WebModelNode NewWebModel(Action<WebModelNode> action)
        {
            return NewWebModel(new WebDefinition { RequireSelfProcessing = false }, action);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding web model provided.
        /// If RequireSelfProcessing set as 'true', then web model is going to be processed and pushed by SPMeta2 API.
        /// Use action to get access to the "web model node" and construct model tree.
        /// </summary>
        /// <param name="webDefinition"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static WebModelNode NewWebModel(WebDefinition webDefinition, Action<WebModelNode> action)
        {
            return NewModelNode<WebDefinition, WebModelNode>(webDefinition, action);
        }

        #endregion

        #region webs

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty list model".
        /// List model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// </summary>
        /// <returns></returns>
        public static ModelNode NewListModel()
        {
            return NewListModel((ListDefinition)null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding web model provided.
        /// If RequireSelfProcessing set as 'true', then web model is going to be processed and pushed by SPMeta2 API.
        /// </summary>
        /// <param name="listDefinition"></param>
        /// <returns></returns>
        public static ModelNode NewListModel(ListDefinition listDefinition)
        {
            return NewListModel(listDefinition, null);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding "empty list model".
        /// Web model is not going to be pushes by SPMeta2 API, it just required to be there for model tree processing.
        /// Use action to get access to the "list model node" and construct model tree.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static ModelNode NewListModel(Action<ModelNode> action)
        {
            return NewListModel(new ListDefinition { RequireSelfProcessing = false }, action);
        }

        /// <summary>
        /// Creates a new instance of the ModelNode adding list model provided.
        /// If RequireSelfProcessing set as 'true', then list model is going to be processed and pushed by SPMeta2 API.
        /// Use action to get access to the "list model node" and construct model tree.
        /// </summary>
        /// <param name="listDefinition"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static ModelNode NewListModel(ListDefinition listDefinition, Action<ModelNode> action)
        {
            return NewModelNode<ListDefinition, ListModelNode>(listDefinition, action);
        }

        #endregion

        #region utils

        private static TNodeType NewModelNode<TModelDefinition, TNodeType>(TModelDefinition model, Action<TNodeType> action)
            where TModelDefinition : DefinitionBase, new()
            where TNodeType : TypedModelNode, new()
        {
            var newModelNode = new TNodeType { Value = model ?? new TModelDefinition { RequireSelfProcessing = false } };

            // levacy
            newModelNode.Options.RequireSelfProcessing = newModelNode.Value.RequireSelfProcessing;

            if (action != null)
                action(newModelNode);

            return newModelNode;
        }

        #endregion

        #region serialization

        public static void RegisterKnownDefinition(Type type)
        {
            RegisterKnownDefinition(new[] { type });
        }

        public static void RegisterKnownDefinition(Assembly assembly)
        {
            RegisterKnownDefinition(new[] { assembly });
        }

        public static void RegisterKnownDefinition(IEnumerable<Assembly> assemblies)
        {
            RegisterKnownDefinition(ReflectionUtils.GetTypesFromAssemblies<DefinitionBase>(assemblies));
        }

        public static void RegisterKnownDefinition(IEnumerable<Type> types)
        {
            foreach (var type in types)
                if (!KnownTypes.Contains(type))
                    KnownTypes.Add(type);
        }

        public static List<Type> KnownTypes = new List<Type>();

        public static ModelNode FromJSON(string jsonString)
        {
            var serializer = ServiceContainer.Instance.GetService<DefaultJSONSerializationService>();
            serializer.RegisterKnownTypes(KnownTypes);

            return serializer.Deserialize(typeof(ModelNode), jsonString) as ModelNode;
        }

        public static string ToJSON(ModelNode model)
        {
            var serializer = ServiceContainer.Instance.GetService<DefaultJSONSerializationService>();
            serializer.RegisterKnownTypes(KnownTypes);

            return serializer.Serialize(model);
        }

        public static ModelNode FromXML(string jsonString)
        {
            var serializer = ServiceContainer.Instance.GetService<DefaultXMLSerializationService>();
            serializer.RegisterKnownTypes(KnownTypes);

            return serializer.Deserialize(typeof(ModelNode), jsonString) as ModelNode;
        }

        public static string ToXML(ModelNode model)
        {
            var serializer = ServiceContainer.Instance.GetService<DefaultXMLSerializationService>();
            serializer.RegisterKnownTypes(KnownTypes);

            return serializer.Serialize(model);
        }

        #endregion
    }
}
