using System;

namespace Adjutant.Library.Definitions
{
    public static class DefinitionsManager
    {
        private static string errorMessage = "Supplied definition set does not support \"----\" tags.";

        //---, ---, H3R, ODST, HRB, HRR, H4R
        public static cache_file_resource_layout_table play(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo3Retail:
                case DefinitionSet.Halo3ODST:
                    return new Halo3Retail.cache_file_resource_layout_table(Cache, Tag.Offset);

                default:
                    return null; //this tag is required for map loading, so return null if not supported
            }
        }

        //---, H3B, H3R, ODST, HRB, HRR, H4R
        public static cache_file_resource_gestalt zone(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo3Beta:
                    return new Halo3Beta.cache_file_resource_gestalt(Cache, Tag.Offset);

                case DefinitionSet.Halo3Retail:
                case DefinitionSet.Halo3ODST:
                    return new Halo3Retail.cache_file_resource_gestalt(Cache, Tag.Offset);
                    
                default:
                    return null; //this tag is required for map loading, so return null if not supported
            }
        }

        //---, ---, H3R, ODST, HRB, HRR, ---
        public static sound_cache_file_gestalt ugh_(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo3Retail:
                    return new Halo3Retail.sound_cache_file_gestalt(Cache, Tag.Offset);

                case DefinitionSet.Halo3ODST:
                    return new Halo3ODST.sound_cache_file_gestalt(Cache, Tag.Offset);
                    
                default:
                    return null; //this tag is required for map loading, so return null if not supported
            }
        }

        //H2X, H3B, H3R, ODST, HRB, HRR, H4R
        public static bitmap bitm(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo1PC:
                    return new Halo1PC.bitmap(Cache, Tag.Offset);

                case DefinitionSet.Halo1CE:
                    return new Halo1CE.bitmap(Cache, Tag.Offset);

                case DefinitionSet.Halo2Xbox:
                    return new Halo2Xbox.bitmap(Cache, Tag.Offset);

                case DefinitionSet.Halo3Beta:
                case DefinitionSet.Halo3Retail:
                case DefinitionSet.Halo3ODST:
                    return new Halo3Beta.bitmap(Cache, Tag.Offset);
                    
                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "bitm"));
            }
        }

        //H2X, H3B, H3R, ODST, HRB, HRR, H4R
        public static render_model mode(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo1PC:
                case DefinitionSet.Halo1CE:
                    return new Halo1PC.gbxmodel(Cache, Tag.Offset);

                case DefinitionSet.Halo2Xbox:
                    return new Halo2Xbox.render_model(Cache, Tag.Offset);

                case DefinitionSet.Halo3Beta:
                case DefinitionSet.Halo3Retail:
                    return new Halo3Beta.render_model(Cache, Tag.Offset);

                case DefinitionSet.Halo3ODST:
                    return new Halo3ODST.render_model(Cache, Tag.Offset);
                    
                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "mode"));
            }
        }

        //H2X, H3B, H3R, ODST, HRB, HRR, H4R
        public static scenario_structure_bsp sbsp(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo1PC:
                case DefinitionSet.Halo1CE:
                    return new Halo1PC.scenario_structure_bsp(Cache, Tag);

                case DefinitionSet.Halo2Xbox:
                    return new Halo2Xbox.scenario_structure_bsp(Cache, Tag);

                case DefinitionSet.Halo3Beta:
                    return new Halo3Beta.scenario_structure_bsp(Cache, Tag.Offset);

                case DefinitionSet.Halo3Retail:
                    return new Halo3Retail.scenario_structure_bsp(Cache, Tag.Offset);

                case DefinitionSet.Halo3ODST:
                    return new Halo3ODST.scenario_structure_bsp(Cache, Tag.Offset);
                    
                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "sbsp"));
            }
        }

        //---, H3B, H3R, ODST, HRB, HRR, ---
        public static render_method_template rmt2(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo3Beta:
                case DefinitionSet.Halo3Retail:
                case DefinitionSet.Halo3ODST:
                    return new Halo3Beta.render_method_template(Cache, Tag.Offset);

                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "rmt2"));
            }
        }

        //H2X, H3B, H3R, ODST, HRB, HRR, H4R
        public static shader rmsh(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo1PC:
                case DefinitionSet.Halo1CE:
                    return new Halo1PC.shader_model(Cache, Tag);

                case DefinitionSet.Halo2Xbox:
                    return new Halo2Xbox.shader(Cache, Tag.Offset);
                    
                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "mode"));
            }
        }

        //---, ---, H3R, ODST, HRB, HRR, H4R
        public static sound snd_(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo3Retail:
                case DefinitionSet.Halo3ODST:
                    return new Halo3Retail.sound(Cache, Tag.Offset);
                    
                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "snd!"));
            }
        }
        
        //---, H3B, H3R, ODST, HRB, HRR, H4R
        public static multilingual_unicode_string_list unic(CacheBase Cache, CacheBase.IndexItem Tag)
        {
            switch (Cache.Version)
            {
                case DefinitionSet.Halo3Beta:
                case DefinitionSet.Halo3Retail:
                case DefinitionSet.Halo3ODST:
                    return new Halo3Beta.multilingual_unicode_string_list(Cache, Tag.Offset);
                    
                default:
                    throw new NotSupportedException(errorMessage.Replace("----", "unic"));
            }
        }
    }
}
