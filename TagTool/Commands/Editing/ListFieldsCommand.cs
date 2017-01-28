using System;
using System.Collections.Generic;
using System.Collections;
using TagTool.Serialization;
using TagTool.Common;
using TagTool.Cache;

namespace TagTool.Commands.Editing
{
    class ListFieldsCommand : Command
    {
        private GameCacheContext CacheContext { get; }
        private TagStructureInfo Structure { get; }
        private object Value { get; }
        
        public ListFieldsCommand(GameCacheContext cacheContext, TagStructureInfo structure, object value)
            : base(CommandFlags.Inherit,

                  "list-fields",
                  $"Lists the fields in the current {structure.Types[0].Name} definition.",

                  "list-fields",

                  $"Lists the fields in the current {structure.Types[0].Name} definition.")
        {
            CacheContext = cacheContext;
            Structure = structure;
            Value = value;
        }

        public override bool Execute(List<string> args)
        {
            if (args.Count > 1)
                return false;

            var match = (args.Count == 1);
            var token = match ? args[0].ToLower() : "";
            
            var enumerator = new TagFieldEnumerator(Structure);

            while (enumerator.Next())
            {
                if (enumerator.Attribute != null && enumerator.Attribute.Padding == true)
                    continue;

                var nameString = enumerator.Field.Name;

                if (match && !nameString.ToLower().Contains(token))
                    continue;

                var fieldType = enumerator.Field.FieldType;
                var fieldValue = enumerator.Field.GetValue(Value);

                var typeString =
                    fieldType.IsGenericType ?
                        $"{fieldType.Name}<{fieldType.GenericTypeArguments[0].Name}>" :
                    fieldType.Name;

                string valueString;

                if (fieldValue == null)
                    valueString = "null";
                else if (fieldType.GetInterface(typeof(IList).Name) != null)
                    valueString =
                        ((IList)fieldValue).Count != 0 ?
                            $"{{...}}[{((IList)fieldValue).Count}]" :
                        "null";
                else if (fieldType == typeof(StringId))
                    valueString = CacheContext.StringIdCache.GetString((StringId)fieldValue);
                else if (fieldType == typeof(TagInstance))
                    valueString = $"[0x{((TagInstance)fieldValue).Index:X4}] {CacheContext.TagNames[((TagInstance)fieldValue).Index]}.{CacheContext.StringIdCache.GetString(((TagInstance)fieldValue).Group.Name)}";
                else
                    valueString = fieldValue.ToString();

                var fieldName = $"{enumerator.Field.DeclaringType.FullName}.{enumerator.Field.Name}".Replace("+", ".");
                var documentationNode = EditTagContextFactory.Documentation.SelectSingleNode($"//member[starts-with(@name, 'F:{fieldName}')]");
                
                Console.WriteLine("{0}: {1} = {2} {3}", nameString, typeString, valueString,
                    documentationNode != null ?
                        $":: {documentationNode.FirstChild.InnerText.Replace("\r\n", "").TrimStart().TrimEnd()}" :
                        "");
            }

            return true;
        }
    }
}
