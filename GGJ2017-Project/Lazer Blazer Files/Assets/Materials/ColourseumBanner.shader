// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:33979,y:33522,varname:node_4013,prsc:2|emission-5799-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:32869,y:33081,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0.9586205,c4:1;n:type:ShaderForge.SFN_Color,id:5587,x:32572,y:33526,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.3103448,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:6612,x:32627,y:34050,ptovrint:False,ptlb:Color3,ptin:_Color3,varname:_Color_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6551723,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:1389,x:32790,y:34589,ptovrint:False,ptlb:Color4,ptin:_Color4,varname:_Color_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.8482759,c3:0,c4:1;n:type:ShaderForge.SFN_Time,id:2470,x:32051,y:32538,varname:node_2470,prsc:2;n:type:ShaderForge.SFN_Frac,id:8638,x:32619,y:32583,varname:node_8638,prsc:2|IN-897-OUT;n:type:ShaderForge.SFN_TexCoord,id:6091,x:32051,y:32399,varname:node_6091,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:8968,x:32275,y:32583,varname:node_8968,prsc:2|A-6091-UVOUT,B-2470-TSL,C-435-OUT;n:type:ShaderForge.SFN_ComponentMask,id:897,x:32438,y:32583,varname:node_897,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-8968-OUT;n:type:ShaderForge.SFN_Abs,id:5329,x:32728,y:32766,varname:node_5329,prsc:2|IN-5668-OUT;n:type:ShaderForge.SFN_Subtract,id:5668,x:32570,y:32766,varname:node_5668,prsc:2|A-8638-OUT,B-5006-OUT;n:type:ShaderForge.SFN_Multiply,id:2605,x:32728,y:32898,varname:node_2605,prsc:2|A-5329-OUT,B-3311-OUT;n:type:ShaderForge.SFN_TexCoord,id:969,x:32102,y:33002,varname:node_969,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:2672,x:32102,y:33141,varname:node_2672,prsc:2;n:type:ShaderForge.SFN_Add,id:8316,x:32326,y:33186,varname:node_8316,prsc:2|A-969-UVOUT,B-2672-TSL,C-4056-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9417,x:32489,y:33186,varname:node_9417,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-8316-OUT;n:type:ShaderForge.SFN_Frac,id:1659,x:32670,y:33186,varname:node_1659,prsc:2|IN-9417-OUT;n:type:ShaderForge.SFN_Subtract,id:6285,x:32621,y:33369,varname:node_6285,prsc:2|A-1659-OUT,B-5006-OUT;n:type:ShaderForge.SFN_Abs,id:9009,x:32779,y:33369,varname:node_9009,prsc:2|IN-6285-OUT;n:type:ShaderForge.SFN_Multiply,id:3331,x:32779,y:33501,varname:node_3331,prsc:2|A-9009-OUT,B-3311-OUT;n:type:ShaderForge.SFN_Vector1,id:4056,x:32102,y:33276,varname:node_4056,prsc:2,v1:0.25;n:type:ShaderForge.SFN_Add,id:5799,x:33736,y:33624,varname:node_5799,prsc:2|A-1330-OUT,B-8061-OUT,C-8695-OUT,D-801-OUT;n:type:ShaderForge.SFN_TexCoord,id:6827,x:32183,y:33530,varname:node_6827,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:2016,x:32183,y:33669,varname:node_2016,prsc:2;n:type:ShaderForge.SFN_Vector1,id:9470,x:32183,y:33804,varname:node_9470,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Add,id:7937,x:32407,y:33714,varname:node_7937,prsc:2|A-6827-UVOUT,B-2016-TSL,C-9470-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9244,x:32570,y:33714,varname:node_9244,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-7937-OUT;n:type:ShaderForge.SFN_Frac,id:6788,x:32751,y:33714,varname:node_6788,prsc:2|IN-9244-OUT;n:type:ShaderForge.SFN_Abs,id:48,x:32860,y:33897,varname:node_48,prsc:2|IN-7382-OUT;n:type:ShaderForge.SFN_Multiply,id:5565,x:32860,y:34026,varname:node_5565,prsc:2|A-48-OUT,B-3311-OUT;n:type:ShaderForge.SFN_Subtract,id:7382,x:32702,y:33897,varname:node_7382,prsc:2|A-6788-OUT,B-5006-OUT;n:type:ShaderForge.SFN_TexCoord,id:3867,x:32297,y:34060,varname:node_3867,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:9656,x:32297,y:34199,varname:node_9656,prsc:2;n:type:ShaderForge.SFN_Add,id:7977,x:32521,y:34244,varname:node_7977,prsc:2|A-3867-UVOUT,B-9656-TSL,C-6369-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6964,x:32684,y:34244,varname:node_6964,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-7977-OUT;n:type:ShaderForge.SFN_Frac,id:9796,x:32865,y:34244,varname:node_9796,prsc:2|IN-6964-OUT;n:type:ShaderForge.SFN_Subtract,id:1540,x:32816,y:34427,varname:node_1540,prsc:2|A-9796-OUT,B-5006-OUT;n:type:ShaderForge.SFN_Multiply,id:1032,x:32981,y:34558,varname:node_1032,prsc:2|A-3482-OUT,B-3311-OUT;n:type:ShaderForge.SFN_Abs,id:3482,x:32974,y:34427,varname:node_3482,prsc:2|IN-1540-OUT;n:type:ShaderForge.SFN_Vector1,id:6369,x:32297,y:34376,varname:node_6369,prsc:2,v1:0.75;n:type:ShaderForge.SFN_Vector1,id:435,x:32051,y:32669,varname:node_435,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:5006,x:31367,y:33137,varname:node_5006,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:3311,x:31367,y:33240,varname:node_3311,prsc:2,v1:2;n:type:ShaderForge.SFN_Power,id:8169,x:32990,y:32890,varname:node_8169,prsc:2|VAL-2605-OUT,EXP-5763-OUT;n:type:ShaderForge.SFN_Multiply,id:1330,x:33148,y:33050,varname:node_1330,prsc:2|A-8169-OUT,B-1304-RGB;n:type:ShaderForge.SFN_Power,id:9250,x:33025,y:33497,varname:node_9250,prsc:2|VAL-3331-OUT,EXP-5763-OUT;n:type:ShaderForge.SFN_Multiply,id:8061,x:33183,y:33657,varname:node_8061,prsc:2|A-9250-OUT,B-5587-RGB;n:type:ShaderForge.SFN_Power,id:7250,x:33110,y:34014,varname:node_7250,prsc:2|VAL-5565-OUT,EXP-5763-OUT;n:type:ShaderForge.SFN_Multiply,id:8695,x:33268,y:34174,varname:node_8695,prsc:2|A-7250-OUT,B-6612-RGB;n:type:ShaderForge.SFN_Multiply,id:801,x:33385,y:34702,varname:node_801,prsc:2|A-5095-OUT,B-1389-RGB;n:type:ShaderForge.SFN_Vector1,id:5763,x:31460,y:33370,varname:node_5763,prsc:2,v1:6;n:type:ShaderForge.SFN_Power,id:5095,x:33227,y:34542,varname:node_5095,prsc:2|VAL-1032-OUT,EXP-5763-OUT;proporder:1304-5587-6612-1389;pass:END;sub:END;*/

Shader "Shader Forge/ColourseumBanner" {
    Properties {
        _Color1 ("Color1", Color) = (0,1,0.9586205,1)
        _Color2 ("Color2", Color) = (1,0.3103448,0,1)
        _Color3 ("Color3", Color) = (0.6551723,0,1,1)
        _Color4 ("Color4", Color) = (1,0.8482759,0,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color1;
            uniform float4 _Color2;
            uniform float4 _Color3;
            uniform float4 _Color4;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_2470 = _Time + _TimeEditor;
                float node_5006 = 0.5;
                float node_3311 = 2.0;
                float node_5763 = 6.0;
                float4 node_2672 = _Time + _TimeEditor;
                float4 node_2016 = _Time + _TimeEditor;
                float4 node_9656 = _Time + _TimeEditor;
                float3 emissive = ((pow((abs((frac((i.uv0+node_2470.r+0.0).r)-node_5006))*node_3311),node_5763)*_Color1.rgb)+(pow((abs((frac((i.uv0+node_2672.r+0.25).r)-node_5006))*node_3311),node_5763)*_Color2.rgb)+(pow((abs((frac((i.uv0+node_2016.r+0.5).r)-node_5006))*node_3311),node_5763)*_Color3.rgb)+(pow((abs((frac((i.uv0+node_9656.r+0.75).r)-node_5006))*node_3311),node_5763)*_Color4.rgb));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
