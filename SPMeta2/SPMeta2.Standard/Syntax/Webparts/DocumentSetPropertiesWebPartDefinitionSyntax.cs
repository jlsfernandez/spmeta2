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
    public class DocumentSetPropertiesWebPartModelNode : WebPartModelNode
    {

    }

    public static class DocumentSetPropertiesWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddDocumentSetPropertiesWebPart<TModelNode>(this TModelNode model, DocumentSetPropertiesWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddDocumentSetPropertiesWebPart(model, definition, null);
        }

        public static TModelNode AddDocumentSetPropertiesWebPart<TModelNode>(this TModelNode model, DocumentSetPropertiesWebPartDefinition definition,
            Action<DocumentSetPropertiesWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddDocumentSetPropertiesWebParts<TModelNode>(this TModelNode model, IEnumerable<DocumentSetPropertiesWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
