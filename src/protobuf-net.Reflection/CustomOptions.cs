// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: protogen.proto

#pragma warning disable CS1591, CS0612, CS3021

namespace ProtoBuf.Reflection
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenFileOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"namespace")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Namespace { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"extensions")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExtensionTypeName { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"langver")]
        [global::System.ComponentModel.DefaultValue("")]
        public string LanguageVersion { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"requiredDefaults")]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool EmitRequiredDefaults { get; set; }
    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenMessageOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"extensions")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ExtensionTypeName { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenFieldOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"asRef")]
        public bool AsReference { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"dynamicType")]
        public bool DynamicType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenEnumOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenEnumValueOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenServiceOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"access")]
        public Access Access { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ProtogenMethodOptions
    {
        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public enum Access
    {
        [global::ProtoBuf.ProtoEnum(Name = @"INHERIT")]
        Inherit = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"PUBLIC")]
        Public = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"PRIVATE")]
        Private = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"INTERNAL")]
        Internal = 3,
    }

    public static class Extensions
    {
        public static ProtogenFileOptions GetOptions(this global::Google.Protobuf.Reflection.FileOptions obj)
        => obj == null ? default(ProtogenFileOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenFileOptions>(obj, 1037);

        public static ProtogenMessageOptions GetOptions(this global::Google.Protobuf.Reflection.MessageOptions obj)
        => obj == null ? default(ProtogenMessageOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenMessageOptions>(obj, 1037);

        public static ProtogenFieldOptions GetOptions(this global::Google.Protobuf.Reflection.FieldOptions obj)
        => obj == null ? default(ProtogenFieldOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenFieldOptions>(obj, 1037);

        public static ProtogenEnumOptions GetOptions(this global::Google.Protobuf.Reflection.EnumOptions obj)
        => obj == null ? default(ProtogenEnumOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenEnumOptions>(obj, 1037);

        public static ProtogenEnumValueOptions GetOptions(this global::Google.Protobuf.Reflection.EnumValueOptions obj)
        => obj == null ? default(ProtogenEnumValueOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenEnumValueOptions>(obj, 1037);

        public static ProtogenServiceOptions GetOptions(this global::Google.Protobuf.Reflection.ServiceOptions obj)
        => obj == null ? default(ProtogenServiceOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenServiceOptions>(obj, 1037);

        public static ProtogenMethodOptions GetOptions(this global::Google.Protobuf.Reflection.MethodOptions obj)
        => obj == null ? default(ProtogenMethodOptions) : global::ProtoBuf.Extensible.GetValue<ProtogenMethodOptions>(obj, 1037);

    }
}

#pragma warning restore CS1591, CS0612, CS3021
