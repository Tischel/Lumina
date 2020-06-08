using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingLandSet", columnHash: 0x89377fc8 )]
    public class HousingLandSet : IExcelRow
    {
        
        public byte[] PlotSize;
        public uint[] MinPrice;
        public uint Unknown120;
        public uint Unknown121;
        public uint Unknown122;
        public uint Unknown123;
        public uint Unknown124;
        public uint Unknown125;
        public uint Unknown126;
        public uint Unknown127;
        public uint Unknown128;
        public uint Unknown129;
        public uint Unknown130;
        public uint Unknown131;
        public uint Unknown132;
        public uint Unknown133;
        public uint Unknown134;
        public uint Unknown135;
        public uint Unknown136;
        public uint Unknown137;
        public uint Unknown138;
        public uint Unknown139;
        public uint Unknown140;
        public uint Unknown141;
        public uint Unknown142;
        public uint Unknown143;
        public uint Unknown144;
        public uint Unknown145;
        public uint Unknown146;
        public uint Unknown147;
        public uint Unknown148;
        public uint Unknown149;
        public uint Unknown150;
        public uint Unknown151;
        public uint Unknown152;
        public uint Unknown153;
        public uint Unknown154;
        public uint Unknown155;
        public uint Unknown156;
        public uint Unknown157;
        public uint Unknown158;
        public uint Unknown159;
        public uint Unknown160;
        public uint Unknown161;
        public uint Unknown162;
        public uint Unknown163;
        public uint Unknown164;
        public uint Unknown165;
        public uint Unknown166;
        public uint Unknown167;
        public uint Unknown168;
        public uint Unknown169;
        public uint Unknown170;
        public uint Unknown171;
        public uint Unknown172;
        public uint Unknown173;
        public uint Unknown174;
        public uint Unknown175;
        public uint Unknown176;
        public uint Unknown177;
        public uint Unknown178;
        public uint Unknown179;
        public uint Unknown180;
        public uint Unknown181;
        public uint Unknown182;
        public uint Unknown183;
        public uint Unknown184;
        public uint Unknown185;
        public uint Unknown186;
        public uint Unknown187;
        public uint Unknown188;
        public uint Unknown189;
        public uint Unknown190;
        public uint Unknown191;
        public uint Unknown192;
        public uint Unknown193;
        public uint Unknown194;
        public uint Unknown195;
        public uint Unknown196;
        public uint Unknown197;
        public uint Unknown198;
        public uint Unknown199;
        public uint Unknown200;
        public uint Unknown201;
        public uint Unknown202;
        public uint Unknown203;
        public uint Unknown204;
        public uint Unknown205;
        public uint Unknown206;
        public uint Unknown207;
        public uint Unknown208;
        public uint Unknown209;
        public uint Unknown210;
        public uint Unknown211;
        public uint Unknown212;
        public uint Unknown213;
        public uint Unknown214;
        public uint Unknown215;
        public uint Unknown216;
        public uint Unknown217;
        public uint Unknown218;
        public uint Unknown219;
        public uint Unknown220;
        public uint Unknown221;
        public uint Unknown222;
        public uint Unknown223;
        public uint Unknown224;
        public uint Unknown225;
        public uint Unknown226;
        public uint Unknown227;
        public uint Unknown228;
        public uint Unknown229;
        public uint Unknown230;
        public uint Unknown231;
        public uint Unknown232;
        public uint Unknown233;
        public uint Unknown234;
        public uint Unknown235;
        public uint Unknown236;
        public uint Unknown237;
        public uint Unknown238;
        public uint Unknown239;
        public uint[] InitialPrice;
        public uint Unknown300;
        public uint Unknown301;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PlotSize = new byte[ 60 ];
            for( var i = 0; i < 60; i++ )
                PlotSize[ i ] = parser.ReadColumn< byte >( 0 + i );
            MinPrice = new uint[ 60 ];
            for( var i = 0; i < 60; i++ )
                MinPrice[ i ] = parser.ReadColumn< uint >( 60 + i );
            Unknown120 = parser.ReadColumn< uint >( 120 );
            Unknown121 = parser.ReadColumn< uint >( 121 );
            Unknown122 = parser.ReadColumn< uint >( 122 );
            Unknown123 = parser.ReadColumn< uint >( 123 );
            Unknown124 = parser.ReadColumn< uint >( 124 );
            Unknown125 = parser.ReadColumn< uint >( 125 );
            Unknown126 = parser.ReadColumn< uint >( 126 );
            Unknown127 = parser.ReadColumn< uint >( 127 );
            Unknown128 = parser.ReadColumn< uint >( 128 );
            Unknown129 = parser.ReadColumn< uint >( 129 );
            Unknown130 = parser.ReadColumn< uint >( 130 );
            Unknown131 = parser.ReadColumn< uint >( 131 );
            Unknown132 = parser.ReadColumn< uint >( 132 );
            Unknown133 = parser.ReadColumn< uint >( 133 );
            Unknown134 = parser.ReadColumn< uint >( 134 );
            Unknown135 = parser.ReadColumn< uint >( 135 );
            Unknown136 = parser.ReadColumn< uint >( 136 );
            Unknown137 = parser.ReadColumn< uint >( 137 );
            Unknown138 = parser.ReadColumn< uint >( 138 );
            Unknown139 = parser.ReadColumn< uint >( 139 );
            Unknown140 = parser.ReadColumn< uint >( 140 );
            Unknown141 = parser.ReadColumn< uint >( 141 );
            Unknown142 = parser.ReadColumn< uint >( 142 );
            Unknown143 = parser.ReadColumn< uint >( 143 );
            Unknown144 = parser.ReadColumn< uint >( 144 );
            Unknown145 = parser.ReadColumn< uint >( 145 );
            Unknown146 = parser.ReadColumn< uint >( 146 );
            Unknown147 = parser.ReadColumn< uint >( 147 );
            Unknown148 = parser.ReadColumn< uint >( 148 );
            Unknown149 = parser.ReadColumn< uint >( 149 );
            Unknown150 = parser.ReadColumn< uint >( 150 );
            Unknown151 = parser.ReadColumn< uint >( 151 );
            Unknown152 = parser.ReadColumn< uint >( 152 );
            Unknown153 = parser.ReadColumn< uint >( 153 );
            Unknown154 = parser.ReadColumn< uint >( 154 );
            Unknown155 = parser.ReadColumn< uint >( 155 );
            Unknown156 = parser.ReadColumn< uint >( 156 );
            Unknown157 = parser.ReadColumn< uint >( 157 );
            Unknown158 = parser.ReadColumn< uint >( 158 );
            Unknown159 = parser.ReadColumn< uint >( 159 );
            Unknown160 = parser.ReadColumn< uint >( 160 );
            Unknown161 = parser.ReadColumn< uint >( 161 );
            Unknown162 = parser.ReadColumn< uint >( 162 );
            Unknown163 = parser.ReadColumn< uint >( 163 );
            Unknown164 = parser.ReadColumn< uint >( 164 );
            Unknown165 = parser.ReadColumn< uint >( 165 );
            Unknown166 = parser.ReadColumn< uint >( 166 );
            Unknown167 = parser.ReadColumn< uint >( 167 );
            Unknown168 = parser.ReadColumn< uint >( 168 );
            Unknown169 = parser.ReadColumn< uint >( 169 );
            Unknown170 = parser.ReadColumn< uint >( 170 );
            Unknown171 = parser.ReadColumn< uint >( 171 );
            Unknown172 = parser.ReadColumn< uint >( 172 );
            Unknown173 = parser.ReadColumn< uint >( 173 );
            Unknown174 = parser.ReadColumn< uint >( 174 );
            Unknown175 = parser.ReadColumn< uint >( 175 );
            Unknown176 = parser.ReadColumn< uint >( 176 );
            Unknown177 = parser.ReadColumn< uint >( 177 );
            Unknown178 = parser.ReadColumn< uint >( 178 );
            Unknown179 = parser.ReadColumn< uint >( 179 );
            Unknown180 = parser.ReadColumn< uint >( 180 );
            Unknown181 = parser.ReadColumn< uint >( 181 );
            Unknown182 = parser.ReadColumn< uint >( 182 );
            Unknown183 = parser.ReadColumn< uint >( 183 );
            Unknown184 = parser.ReadColumn< uint >( 184 );
            Unknown185 = parser.ReadColumn< uint >( 185 );
            Unknown186 = parser.ReadColumn< uint >( 186 );
            Unknown187 = parser.ReadColumn< uint >( 187 );
            Unknown188 = parser.ReadColumn< uint >( 188 );
            Unknown189 = parser.ReadColumn< uint >( 189 );
            Unknown190 = parser.ReadColumn< uint >( 190 );
            Unknown191 = parser.ReadColumn< uint >( 191 );
            Unknown192 = parser.ReadColumn< uint >( 192 );
            Unknown193 = parser.ReadColumn< uint >( 193 );
            Unknown194 = parser.ReadColumn< uint >( 194 );
            Unknown195 = parser.ReadColumn< uint >( 195 );
            Unknown196 = parser.ReadColumn< uint >( 196 );
            Unknown197 = parser.ReadColumn< uint >( 197 );
            Unknown198 = parser.ReadColumn< uint >( 198 );
            Unknown199 = parser.ReadColumn< uint >( 199 );
            Unknown200 = parser.ReadColumn< uint >( 200 );
            Unknown201 = parser.ReadColumn< uint >( 201 );
            Unknown202 = parser.ReadColumn< uint >( 202 );
            Unknown203 = parser.ReadColumn< uint >( 203 );
            Unknown204 = parser.ReadColumn< uint >( 204 );
            Unknown205 = parser.ReadColumn< uint >( 205 );
            Unknown206 = parser.ReadColumn< uint >( 206 );
            Unknown207 = parser.ReadColumn< uint >( 207 );
            Unknown208 = parser.ReadColumn< uint >( 208 );
            Unknown209 = parser.ReadColumn< uint >( 209 );
            Unknown210 = parser.ReadColumn< uint >( 210 );
            Unknown211 = parser.ReadColumn< uint >( 211 );
            Unknown212 = parser.ReadColumn< uint >( 212 );
            Unknown213 = parser.ReadColumn< uint >( 213 );
            Unknown214 = parser.ReadColumn< uint >( 214 );
            Unknown215 = parser.ReadColumn< uint >( 215 );
            Unknown216 = parser.ReadColumn< uint >( 216 );
            Unknown217 = parser.ReadColumn< uint >( 217 );
            Unknown218 = parser.ReadColumn< uint >( 218 );
            Unknown219 = parser.ReadColumn< uint >( 219 );
            Unknown220 = parser.ReadColumn< uint >( 220 );
            Unknown221 = parser.ReadColumn< uint >( 221 );
            Unknown222 = parser.ReadColumn< uint >( 222 );
            Unknown223 = parser.ReadColumn< uint >( 223 );
            Unknown224 = parser.ReadColumn< uint >( 224 );
            Unknown225 = parser.ReadColumn< uint >( 225 );
            Unknown226 = parser.ReadColumn< uint >( 226 );
            Unknown227 = parser.ReadColumn< uint >( 227 );
            Unknown228 = parser.ReadColumn< uint >( 228 );
            Unknown229 = parser.ReadColumn< uint >( 229 );
            Unknown230 = parser.ReadColumn< uint >( 230 );
            Unknown231 = parser.ReadColumn< uint >( 231 );
            Unknown232 = parser.ReadColumn< uint >( 232 );
            Unknown233 = parser.ReadColumn< uint >( 233 );
            Unknown234 = parser.ReadColumn< uint >( 234 );
            Unknown235 = parser.ReadColumn< uint >( 235 );
            Unknown236 = parser.ReadColumn< uint >( 236 );
            Unknown237 = parser.ReadColumn< uint >( 237 );
            Unknown238 = parser.ReadColumn< uint >( 238 );
            Unknown239 = parser.ReadColumn< uint >( 239 );
            InitialPrice = new uint[ 60 ];
            for( var i = 0; i < 60; i++ )
                InitialPrice[ i ] = parser.ReadColumn< uint >( 240 + i );
            Unknown300 = parser.ReadColumn< uint >( 300 );
            Unknown301 = parser.ReadColumn< uint >( 301 );
        }
    }
}