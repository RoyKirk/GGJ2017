// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:33286,y:32367,varname:node_1,prsc:2|emission-4435-OUT,alpha-6709-OUT;n:type:ShaderForge.SFN_Subtract,id:18,x:32114,y:32340,varname:node_18,prsc:2|A-22-OUT,B-19-OUT;n:type:ShaderForge.SFN_Vector1,id:19,x:31935,y:32422,varname:node_19,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Abs,id:21,x:32286,y:32340,varname:node_21,prsc:2|IN-18-OUT;n:type:ShaderForge.SFN_Frac,id:22,x:31935,y:32288,varname:node_22,prsc:2|IN-24-OUT;n:type:ShaderForge.SFN_ComponentMask,id:24,x:31772,y:32312,varname:node_24,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6072-OUT;n:type:ShaderForge.SFN_Multiply,id:25,x:32461,y:32390,cmnt:Triangle Wave,varname:node_25,prsc:2|A-21-OUT,B-26-OUT;n:type:ShaderForge.SFN_Vector1,id:26,x:32286,y:32476,varname:node_26,prsc:2,v1:2;n:type:ShaderForge.SFN_Power,id:133,x:32628,y:32469,cmnt:Panning gradient,varname:node_133,prsc:2|VAL-25-OUT,EXP-7078-OUT;n:type:ShaderForge.SFN_Color,id:168,x:32628,y:32255,ptovrint:False,ptlb:Glow Color,ptin:_GlowColor,varname:_GlowColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07586217,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_TexCoord,id:5169,x:31341,y:32210,varname:node_5169,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:4435,x:32837,y:32494,varname:node_4435,prsc:2|A-168-RGB,B-6156-OUT;n:type:ShaderForge.SFN_Slider,id:6709,x:32650,y:32672,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_6709,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:4.65837,max:10;n:type:ShaderForge.SFN_Time,id:1299,x:31224,y:32382,varname:node_1299,prsc:2;n:type:ShaderForge.SFN_Append,id:4120,x:31310,y:32654,varname:node_4120,prsc:2|A-3723-OUT,B-9095-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3723,x:31120,y:32654,ptovrint:False,ptlb:X speed,ptin:_Xspeed,varname:node_3723,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9095,x:31120,y:32745,ptovrint:False,ptlb:Y speed,ptin:_Yspeed,varname:_Xspeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8742,x:31494,y:32609,varname:node_8742,prsc:2|A-1299-T,B-4120-OUT;n:type:ShaderForge.SFN_Add,id:6072,x:31544,y:32280,varname:node_6072,prsc:2|A-5169-UVOUT,B-8742-OUT;n:type:ShaderForge.SFN_Sin,id:5589,x:31935,y:32611,varname:node_5589,prsc:2|IN-104-OUT;n:type:ShaderForge.SFN_RemapRange,id:7078,x:32361,y:32607,varname:node_7078,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:3|IN-5589-OUT;n:type:ShaderForge.SFN_ComponentMask,id:9697,x:31748,y:32074,varname:node_9697,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6072-OUT;n:type:ShaderForge.SFN_Frac,id:9257,x:31911,y:32050,varname:node_9257,prsc:2|IN-9697-OUT;n:type:ShaderForge.SFN_Vector1,id:423,x:31911,y:32184,varname:node_423,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Subtract,id:2674,x:32090,y:32102,varname:node_2674,prsc:2|A-9257-OUT,B-423-OUT;n:type:ShaderForge.SFN_Abs,id:8463,x:32262,y:32102,varname:node_8463,prsc:2|IN-2674-OUT;n:type:ShaderForge.SFN_Vector1,id:3665,x:32262,y:32238,varname:node_3665,prsc:2,v1:2;n:type:ShaderForge.SFN_Multiply,id:466,x:32437,y:32152,cmnt:Triangle Wave,varname:node_466,prsc:2|A-8463-OUT,B-3665-OUT;n:type:ShaderForge.SFN_Multiply,id:7690,x:32847,y:32106,varname:node_7690,prsc:2|A-8112-OUT,B-133-OUT;n:type:ShaderForge.SFN_Power,id:8112,x:32665,y:32089,varname:node_8112,prsc:2|VAL-466-OUT,EXP-7078-OUT;n:type:ShaderForge.SFN_Multiply,id:7132,x:33070,y:32301,varname:node_7132,prsc:2|A-168-RGB,B-6156-OUT,C-4435-OUT;n:type:ShaderForge.SFN_OneMinus,id:6156,x:32892,y:31967,varname:node_6156,prsc:2|IN-7690-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2901,x:31564,y:32758,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_2901,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:104,x:31765,y:32667,varname:node_104,prsc:2|A-1299-T,B-2901-OUT;proporder:168-6709-3723-9095-2901;pass:END;sub:END;*/

Shader "Shader Forge/Examples/Vertex Animation" {
    Properties {
        _GlowColor ("Glow Color", Color) = (0.07586217,1,0,1)
        _Opacity ("Opacity", Range(0, 10)) = 4.65837
        _Xspeed ("X speed", Float ) = 0
        _Yspeed ("Y speed", Float ) = 0
        _Speed ("Speed", Float ) = 10
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _GlowColor;
            uniform float _Opacity;
            uniform float _Xspeed;
            uniform float _Yspeed;
            uniform float _Speed;
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
                float4 node_1299 = _Time + _TimeEditor;
                float2 node_6072 = (i.uv0+(node_1299.g*float2(_Xspeed,_Yspeed)));
                float node_7078 = (sin((node_1299.g*_Speed))*1.5+1.5);
                float node_6156 = (1.0 - (pow((abs((frac(node_6072.g)-0.5))*2.0),node_7078)*pow((abs((frac(node_6072.r)-0.5))*2.0),node_7078)));
                float3 node_4435 = (_GlowColor.rgb+node_6156);
                float3 emissive = node_4435;
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,_Opacity);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #include "UnityCG.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _GlowColor;
            uniform float _Xspeed;
            uniform float _Yspeed;
            uniform float _Speed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 node_1299 = _Time + _TimeEditor;
                float2 node_6072 = (i.uv0+(node_1299.g*float2(_Xspeed,_Yspeed)));
                float node_7078 = (sin((node_1299.g*_Speed))*1.5+1.5);
                float node_6156 = (1.0 - (pow((abs((frac(node_6072.g)-0.5))*2.0),node_7078)*pow((abs((frac(node_6072.r)-0.5))*2.0),node_7078)));
                float3 node_4435 = (_GlowColor.rgb+node_6156);
                o.Emission = node_4435;
                
                float3 diffColor = float3(0,0,0);
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
