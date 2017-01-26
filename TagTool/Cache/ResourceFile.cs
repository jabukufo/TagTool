using System.Collections.Generic;
using System.IO;

namespace TagTool.Cache
{
    public class ResourceFile
    {
        public byte[] Padding0 { get; set; } // Padding at beginning of file
        public uint TableOffset { get; set; } // Offset of where the offsets-table begins.
        public int ResourceCount { get; set; } // Amount of resources in the file.
        public byte[] Padding1 { get; set; } // Padding following the resource count.
        public long TimeStamp { get; set; } // Uh, a timestamp?
        public byte[] Padding2 { get; set; } // Padding following the timestamp.
        public List<Resource> Resources { get; set; } = new List<Resource> { }; // List of all the resources in their file (with their index, offset, size, and data).

        public ResourceFile(FileInfo file)
        {
            using (var stream = file.OpenRead())
            using (var reader = new BinaryReader(stream))
            {
                // Read the resource file header.
                Padding0 = reader.ReadBytes(0x4);
                TableOffset = reader.ReadUInt32();
                ResourceCount = reader.ReadInt32();
                Padding1 = reader.ReadBytes(0x4);
                TimeStamp = reader.ReadInt64();
                Padding2 = reader.ReadBytes(0x8);

                // Add all resources except the last one to the resources List... (it will get added right after this for-loop.)
                reader.BaseStream.Position = TableOffset;
                for (int i = 0; (Resources != null ? Resources.Count : 0) < ResourceCount - 1; i++)
                {
                    Resource resource = new Resource();
                    resource.Index = i;
                    resource.StartOffset = reader.ReadUInt32();

                    // Used to find our place in the offset's table again after calculating the resource size and data.
                    long returnPosition = reader.BaseStream.Position;

                    // Add the next resource Offset and use it's start offset for the resource's
                    // EndOffset if it's non-nulled (uint.MaxValue for offset). In that case use the next one. If there isn't a next one,
                    // use the TableOffset instead.
                    resource.EndOffset = reader.ReadUInt32();
                    resource.NextIndex = i + 1;
                    while (resource.EndOffset == uint.MaxValue)
                    {
                        try
                        {
                            resource.EndOffset = reader.ReadUInt32();
                            resource.NextIndex = resource.NextIndex + 1;
                        }
                        catch { resource.EndOffset = TableOffset; }
                    }

                    // Don't try to read data for null resources.
                    if (resource.StartOffset == uint.MaxValue)
                    {
                        Resources.Add(resource);
                        reader.BaseStream.Position = returnPosition;
                        continue;
                    }
                    // Read the resource data.
                    resource.Size = resource.EndOffset - resource.StartOffset;
                    reader.BaseStream.Position = resource.StartOffset;
                    resource.Data = reader.ReadBytes((int)resource.Size);
                    // Add the resource to the list and return the stream position.
                    Resources.Add(resource);
                    reader.BaseStream.Position = returnPosition;
                }

                // Add the last resource in the file to the resources List.
                Resource lastResource = new Resource();
                lastResource.Index = ResourceCount - 1;
                lastResource.StartOffset = reader.ReadUInt32();
                // Don't try to read data for a null resource. Just add the resource to the list then return, since we are done here now.
                if (lastResource.StartOffset == uint.MaxValue)
                {
                    Resources.Add(lastResource);
                    return;
                }

                // Read the resource data.
                lastResource.Size = TableOffset - lastResource.StartOffset;
                reader.BaseStream.Position = lastResource.StartOffset;
                lastResource.Data = reader.ReadBytes((int)lastResource.Size);
                // Add the resource to the list.
                Resources.Add(lastResource);
            }
        }

        public void Serialize(FileInfo file)
        {
            for (var i = Resources.Count - 1; i >= 0; i--)
            {
                if (Resources[i].StartOffset != uint.MaxValue)
                    break;

                Resources.RemoveAt(i);
            }

            using (var stream = file.Create())
            using (var writer = new BinaryWriter(stream))
            {
                // Write the header
                writer.Write(Padding0);
                writer.Write(TableOffset);
                writer.Write(Resources.Count);
                writer.Write(Padding1);
                writer.Write(TimeStamp);
                writer.Write(Padding2);

                // Write the resources data (if it has any) and add it's offset to the list.
                List<uint> offsets = new List<uint> { };
                foreach (Resource resource in Resources)
                {
                    if (resource.Data != null)
                        writer.Write(resource.Data);

                    offsets.Add(resource.StartOffset);
                }

                // Write each offset.
                foreach (uint offset in offsets)
                    writer.Write(offset);
            }
        }

        public void NullResource(int index)
        {
            if (index == -1)
                return;

            uint size = Resources[index].Size;
            Resources[index].Size = 0; // Set the size to 0.
            Resources[index].StartOffset = uint.MaxValue; // The offset gets left in the table as 0xFFFFFFFF
            Resources[index].EndOffset = uint.MaxValue;
            Resources[index].Data = null; // Null the resource data.
            TableOffset -= size; // Remove it's size from the table-offset.

            // Fix up the offset for each resource which follows the nulled resource. Skip previously nulled resources, as their offset
            // should remain at 0xFFFFFFFF
            int nextIndex = index;
            while (Resources[nextIndex].NextIndex != 0)
            {
                nextIndex = Resources[nextIndex].NextIndex;

                if (Resources[nextIndex].StartOffset != uint.MaxValue)
                    Resources[nextIndex].StartOffset -= size;
            }
        }

        public class Resource
        {
            public int Index { get; set; } = 0; // Index of the resource's offset in the offsets-table.
            public int NextIndex { get; set; } = 0; // Index of the next resource...
            public uint StartOffset { get; set; } = 0; // Offset of where the resource's data begins.
            public uint EndOffset { get; set; } = 0; // Offset of where the resource's data ends.
            public uint Size { get; set; } = 0; // Size of the resource data.
            public byte[] Data { get; set; } = null; // Raw resource data.
        }
    }
}
