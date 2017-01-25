using System;
using System.Collections.Generic;
using System.Collections;
using TagTool.Serialization;
using TagTool.Common;
using TagTool.Tags;
using TagTool.Cache.HaloOnline;

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
                else if (fieldType == typeof(StringID))
                    valueString = CacheContext.StringIdCache.GetString((StringID)fieldValue);
                else if (fieldType == typeof(TagInstance))
                    valueString = $"[0x{((TagInstance)fieldValue).Index:X4}] {CacheContext.TagNames[((TagInstance)fieldValue).Index]}.{CacheContext.StringIdCache.GetString(((TagInstance)fieldValue).Group.Name)}";
                else
                    valueString = fieldValue.ToString();
                
                Console.WriteLine("{0}: {1} = {2}", nameString, typeString, valueString);
            }

            return true;
        }
    }
}
