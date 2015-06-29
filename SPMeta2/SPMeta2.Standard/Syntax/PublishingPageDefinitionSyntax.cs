﻿using System;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions;
using SPMeta2.Syntax.Default.Extensions;
using System.Collections.Generic;
using SPMeta2.Definitions;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Standard.Syntax
{
    public class PublishingPageModelNode : TypedModelNode,
        IWebpartHostModelNode,
        ISecurableObjectHostModelNode
    {

    }

    public static class PublishingPageDefinitionSyntax
    {
        #region methods

        public static TModelNode AddPublishingPage<TModelNode>(this TModelNode model, PublishingPageDefinition definition)
            where TModelNode : ModelNode, IPageHostModelNode, new()
        {
            return AddPublishingPage(model, definition, null);
        }

        public static TModelNode AddPublishingPage<TModelNode>(this TModelNode model, PublishingPageDefinition definition,
            Action<PublishingPageModelNode> action)
            where TModelNode : ModelNode, IPageHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddPublishingPages<TModelNode>(this TModelNode model, IEnumerable<PublishingPageDefinition> definitions)
           where TModelNode : ModelNode, IPageHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion

        #region host override

        public static ListModelNode AddHostPublishingPage(this ListModelNode model, PublishingPageDefinition definition)
        {
            return AddHostPublishingPage(model, definition, null);
        }

        public static ListModelNode AddHostPublishingPage(this ListModelNode model,
            PublishingPageDefinition definition, Action<PublishingPageModelNode> action)
        {
            return model.AddTypedDefinitionNodeWithOptions(definition, action, ModelNodeOptions.New().NoSelfProcessing());
        }

        #endregion
    }
}
