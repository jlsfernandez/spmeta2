using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Standard.Syntax
{

    [Serializable]
    [DataContract]
    public class MyMembershipWebPartModelNode : WebPartModelNode
    {

    }

    public static class MyMembershipWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddMyMembershipWebPart<TModelNode>(this TModelNode model, MyMembershipWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddMyMembershipWebPart(model, definition, null);
        }

        public static TModelNode AddMyMembershipWebPart<TModelNode>(this TModelNode model, MyMembershipWebPartDefinition definition,
            Action<MyMembershipWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddMyMembershipWebParts<TModelNode>(this TModelNode model, IEnumerable<MyMembershipWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
