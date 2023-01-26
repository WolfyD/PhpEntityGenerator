using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhpEntityGenerator
{
    public class Field
    {
        /// <summary>
        /// Name in Snake Case (eg: my_field_name)
        /// </summary>
        public string Name { get; set; }
        public FieldType Type { get; set; }
        public int Length { get; set; }
        public int Scale { get; set; }
        public bool Nullable { get; set; }

        public string ProperName;

        public Field(string name, FieldType type, int length = 0, int scale = 0, bool nullable = true)
        {
            Name = name.ToLower();
            Type = type;
            Length = length;
            Scale = scale;
            Nullable = nullable;

            GenerateProperName();
        }

        private void GenerateProperName()
        {
            if(Name == "") { ProperName = ""; return; }

            for (int i = 0; i < Name.Length; i++)
            {
                if (i == 0 && Name[i] != '_')
                {
                    ProperName += Name[i].ToString().ToUpper();
                }
                else if (i > 0 && Name[i-1] == '_')
                {
                    ProperName += Name[i].ToString().ToUpper();
                }
                else if (Name[i] != '_')
                {
                    ProperName += Name[i];
                }
            }
        }

        public string GenerateColumnDefinition()
        {
            switch (Type)
            {
                case FieldType.String:
                case FieldType.Text:
                case FieldType.VarChar:
                case FieldType.Char:
                    return "type=\"string\", length={length}, name=\"{field_name}\", nullable={nullable}";
                case FieldType.Boolean:
                    return "type=\"boolean\", name=\"{field_name}\", nullable={nullable}";
                case FieldType.Integer:
                    return "type=\"integer\", length={length}, name=\"{field_name}\", nullable={nullable}";
                case FieldType.Double:
                    return "type=\"double\", precision={length}, scale={scale}, name=\"{field_name}\", nullable={nullable}";
                case FieldType.Float:
                    return "type=\"float\", precision={length}, scale={scale}, name=\"{field_name}\", nullable={nullable}";
                case FieldType.Decimal:
                    return "type=\"decimal\", precision={length}, scale={scale}, name=\"{field_name}\", nullable={nullable}";
                case FieldType.Date:
                    return "type=\"date\", name=\"{field_name}\"";
                case FieldType.TimeStamp:
                    return "type=\"timestamp\", name=\"{field_name}\"";
                default:
                    return "";
            }
        }

        public static FieldType GetTypeFromString(string input)
        {
            FieldType[] vals = (FieldType[])Enum.GetValues(typeof(FieldType));
            FieldType? val = (from type in vals where type.ToString().ToLower() == input select type as FieldType?).FirstOrDefault();
            return val ?? FieldType.String; //If type is not definable or not set, use string
        }

        public override string ToString()
        {

            return $"{Name} - {ProperName} | {Type} | {Length} - {Scale} | {(Nullable ? "Null" : "Not Null")}";
        }

    }

    public enum FieldType
    {
        String,
        Text,
        VarChar,
        Char,
        Boolean,
        Integer,
        Double,
        Float,
        Decimal,
        Date,
        TimeStamp,
        Enum,
        Set,
        None
    }
}
